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
        /// 全概率参数 All.
        /// </summary>
        private int all;
        /// <summary>
        /// 0或多个tc The tcs.
        /// </summary>
        private Dictionary<Treasure, float> tcs;
        /// <summary>
        /// 0或多个基础物品 The objects.
        /// </summary>
        private Dictionary<int, float> objs;

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
            if (IsNoDrop()) {
                return null;
            }
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

        private static Grade GetItemGrade() {
            // 怪物等级/类型、人物MF、物品ilvl决定
            return Grade.Ancient;
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
