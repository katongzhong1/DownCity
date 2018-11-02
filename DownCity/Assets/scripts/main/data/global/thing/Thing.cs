using System;
using GST.EarningSpace;

namespace GST.ThingSpace {
    public class Thing {
        //======================================================================
        // Public Properties
        //======================================================================
        /// <summary>
        /// The earnings.
        /// 事件收益
        /// </summary>
        public Earning earning;

        //======================================================================
        // Private Properties
        //======================================================================
        /// <summary>
        /// The subs.
        /// 事件组成
        /// </summary>
        private Thing[] subs;
        /// <summary>
        /// The current step.
        /// 当前进度
        /// </summary>
        private int curStep;

        //======================================================================
        // Public Properties
        //======================================================================
        /// <summary>
        /// Cans the trigger.
        /// 事件能否被触发
        /// </summary>
        /// <returns><c>true</c>, if trigger was caned, <c>false</c> otherwise.</returns>
        public bool CanTrigger() {
            return false;
        }

        #region 事件驱动
        #endregion  



    }
}