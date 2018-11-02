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

    }
}
