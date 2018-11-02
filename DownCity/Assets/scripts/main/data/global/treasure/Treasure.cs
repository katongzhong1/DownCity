using System;
using System.Collections.Generic;
using GST.ItemSpace;
using GST.MonsterSpace;

namespace GST.TreasureSpace {
    public class Treasure {
        // https://wenku.baidu.com/view/bf2d5b3231126edb6f1a1020.html?rec_flag=default
        //======================================================================
        // Public Properties
        //======================================================================
        /// <summary>
        /// 检索次数 The pick.
        /// </summary>
        public int pick;
        /// <summary>
        /// 不掉落率 The nodrop.
        /// </summary>
        public int nodrop;

        //======================================================================
        // Private Properties
        //======================================================================
        /// <summary>
        /// 0或多个tc The tcs.
        /// </summary>
        private int[,] tcs;
        private int tall;
        /// <summary>
        /// 0或多个基础物品 The objects.
        /// </summary>
        private int[,] objs;
        private int oall;

        //======================================================================
        // Public Functions
        //======================================================================
        /// <summary>
        /// 物品掉落 Drops the items.
        /// </summary>
        /// <returns>The items.</returns>
        /// <param name="monster">Monster.</param>
        public List<Item> DropItems(Monster monster) {
            List<Item> list = new List<Item>();
            for (var i = 0; i < pick; i++) {
                Item item = DropItem(monster);
            }
            return list;
        }

        //======================================================================
        // Public Functions
        //======================================================================

        private Item DropItem(Monster monster) {
            // 1. 是否掉落物品
            Random rand = new Random();
            int num = rand.Next(nodrop + tall + oall);
            if (num <= nodrop) {
                return null;
            }
            // 2. 是否是子tc
            if (num <= tall) {
                int cur = nodrop;
                for (var i = 0; i < tcs.Length; i++) {
                    cur += tcs[i, 0];
                    if (num <= cur) {
                        Treasure temp = new Treasure();
                        return temp.DropItem(monster);
                    }
                }
            }
            // 3. 掉落物品
            int curfinal = nodrop + tall;
            for (var j = 0; j < objs.Length; j++) {
                curfinal += objs[j, 0];
                if (num <= curfinal) {
                    Item item = new Item();
                    // 2. 检测物品类型 
                    item.type = GetItemType();
                    // 3. 物品的TC检定
                    item.tc = GetItemTC(monster.tc, item.type);
                    // 4. 物品的等级
                    item.ilvl = 0;
                    // 5. 物品的类型检定
                    item.id = GetItemId(item.tc, item.type);
                    // 6. 物品的品质检定
                    item.qlvl = GetItemGrade();
                    // 7. 是否有插槽

                    // 8. 是否是超凡的Ethereal
                    return item;
                }
            }
            return null;
        }

        private Grade GetItemGrade() {
            // 怪物等级/类型、人物MF、物品ilvl决定
            return Grade.Ancient;
        }

        private Grade GetGrade(int mlvl, int qlvl, float mf, int[,] vds, int idx) {
            //==> ch1 = value - (mlvl - qlvl) / Divisor
            int ch1 = vds[idx, 0] - (mlvl - qlvl) / vds[idx, 1];
            //==> ch2 = ch1 * 128 * (1 - CX / 1024)
            int ch2 = ch1 * 128 * (1 - vds[idx, 2] / 1024);
            //==> MF<10, UF=SF=RF=MF; MF>=10: XF = MF * x / (x + MF)
            float xf = mf < 10 ? mf : mf * vds[idx, 3] / (mf + vds[idx, 3]);
            float final = ch2 * 100 / (100 + xf);
            Random ran = new Random();
            int rand = ran.Next((int)final);
            if (rand > 128) {
                return GetGrade(mlvl, qlvl, mf, vds, idx);
            }
            return (Grade)vds[idx, 4];
        }

        private static int GetItemId(int tc, ItemType type) {
            return 0;
        }

        /// <summary>
        /// Gets the item tc.
        /// </summary>
        /// <returns>The item tc.</returns>
        /// <param name="tc">The monster tc.</param>
        /// <param name="type">Type.</param>
        private static int GetItemTC(int tc, ItemType type) {
            // 由tc开始向下检测, 如果无则
            bool hasTc = false;
            if (hasTc) {
                return GetItemTC(tc - 3, type);
            }
            return 0;
        }

        private static ItemType GetItemType() {
            return ItemType.Weapon;
        }

        private static bool IsNoDrop() {
            return false;
        }
    }
}
