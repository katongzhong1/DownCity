using System;
using System.Collections.Generic;
using GST.MonsterSpace;
using GST.CharaSpace;

namespace GST.ItemSpace {
    /// <summary>
    /// Item type.
    /// 物品分类
    /// </summary>
    public enum ItemType {
        /// <summary>
        /// 武器.
        /// </summary>
        Weapon = 0,
        /// <summary>
        /// 防具.
        /// </summary>
        Armor,
        /// <summary>
        /// 杂物.
        /// </summary>
        Misc
    };

    /// <summary>
    /// 武器 抽象类型, 决定外观和基本属性.
    /// </summary>
    public enum WeaponType {
        /// <summary>
        /// 剑.
        /// </summary>
        Sword = 1000,
        /// <summary>
        /// 短剑.
        /// </summary>
        ShortSword,
        /// <summary>
        /// 弓.
        /// </summary>
        Bow,
        /// <summary>
        /// 棍棒.
        /// </summary>
        Club,
        /// <summary>
        /// 法杖.
        /// </summary>
        Staff
    };

    /// <summary>
    /// 防具 抽象类型, 决定外观和基本属性.
    /// </summary>
    public enum ArmorType {
        /// <summary>
        /// 头盔.
        /// </summary>
        Helm,
        /// <summary>
        /// 项链.
        /// </summary>
        Amulet,
        /// <summary>
        /// 盔甲.
        /// </summary>
        Armor,
        /// <summary>
        /// 护腕.
        /// </summary>
        Brace,
        /// <summary>
        /// 戒指.
        /// </summary>
        Ring,
        /// <summary>
        /// 腰带
        /// </summary>
        Blet,
        /// <summary>
        /// 护腿.
        /// </summary>
        Leg,
        /// <summary>
        /// 鞋.
        /// </summary>
        Shose
    }

    /// <summary>
    /// 杂物 抽象类型, 决定外观和基本属性.
    /// </summary>
    public enum MicsType {
        /// <summary>
        /// 药剂.
        /// </summary>
        Potion,
        /// <summary>
        /// 卷轴.
        /// </summary>
        Scroll,
        /// <summary>
        /// 书籍
        /// </summary>
        Book,
        /// <summary>
        /// 弹药.
        /// </summary>
        Bullet,
        /// <summary>
        /// 宝石.
        /// </summary>
        Gem,
        /// <summary>
        /// 符文.
        /// </summary>
        Rune,
        /// <summary>
        /// 护符.
        /// </summary>
        Charm,
        /// <summary>
        /// 金钱.
        /// </summary>
        Gold,
        /// <summary>
        /// 任务物品.
        /// </summary>
        Quest
    }

    public enum Grade {
        /// <summary>
        /// 低劣的.
        /// </summary>
        Low,
        /// <summary>
        /// 普通的.
        /// </summary>
        Normal,
        /// <summary>
        /// 超强的.
        /// </summary>
        Superior,
        /// <summary>
        /// 魔法的.
        /// </summary>
        Magical,
        /// <summary>
        /// 稀有的.
        /// </summary>
        Rare,
        /// <summary>
        /// 成套的.
        /// </summary>
        Set,
        /// <summary>
        /// 独有的.
        /// </summary>
        Unique,
        /// <summary>
        /// 远古的.
        /// </summary>
        Ancient
    }

    public static class ItemManager {
        //======================================================================
        // Public Functions
        //======================================================================
        /// <summary>
        /// 物品掉落 Drops the items.
        /// </summary>
        /// <returns>The items.</returns>
        /// <param name="monster">Monster.</param>
        /// <param name="chara">Chara.</param>
        public static List<Item> DropItems(Monster monster, Chara chara) {

            return new List<Item>();
        }

        //======================================================================
        // Public Functions
        //======================================================================

        private static Item DropItem(Monster monster, Chara chara, int num) {
            // 1. 是否掉落物品
            if (IsNoDrop(monster, chara)) {
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
            return new Item();
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
                return GetItemTC(tc-3, type);
            }
            return 0;
        }

        private static ItemType GetItemType() {
            return ItemType.Weapon;
        }

        private static bool IsNoDrop(Monster monster, Chara chara) {
            return false;
        }
    }
}
