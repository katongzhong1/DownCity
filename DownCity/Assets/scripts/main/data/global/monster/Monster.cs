using System;

namespace GST.MonsterSpace {
    public class Monster {
        //======================================================================
        // Public Properties
        //======================================================================
        public enum MonsterType {
            /// <summary>
            /// The boss.
            /// </summary>
            Boss,
            /// <summary>
            /// 特殊怪物 The super unique.
            /// </summary>
            SuperUnique,
            /// <summary>
            /// 仆从 The minion.
            /// </summary>
            Minion,
            /// <summary>
            /// 小头领 The champion.
            /// </summary>
            Champion,
            /// <summary>
            /// 普通 The normal.
            /// </summary>
            Normal
        }

        //======================================================================
        // Public Properties
        //======================================================================
        /// <summary>
        /// 怪物等级 The monster level.
        /// </summary>
        public int mlvl;
        /// <summary>
        /// 场景等级 The area level.
        /// </summary>
        public int alvl;
        /// <summary>
        /// 财宝等级 The treasure class.
        /// </summary>
        public int tc;
    }
}
