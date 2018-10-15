using System;

namespace GST.ItemSpace {
    public class Item {
        //======================================================================
        // Public Properties
        //======================================================================
        /// <summary>
        /// The item type.
        /// </summary>
        public ItemType type;
        /// <summary>
        /// 基础物品 The identifier.
        /// </summary>
        public int id;
        /// <summary>
        /// 品质等级 The quality level.
        /// </summary>
        public int qlvl;
        /// <summary>
        /// 财宝等级 The treasure class.
        /// </summary>
        public int tc;
        /// <summary>
        /// 物品等级 The item level.
        /// </summary>
        public int ilvl;
        /// <summary>
        /// 需求等级 The require level.
        /// </summary>
        public int reqlvl;
    }
}
