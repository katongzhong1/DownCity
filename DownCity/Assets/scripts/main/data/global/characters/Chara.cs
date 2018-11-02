using System;
using GST.DesireSpace;

namespace GST.CharaSpace {
    public class Chara {
        //======================================================================
        // Public Properties
        //======================================================================
        public CProperties cp;

        /// <summary>
        /// The magic find.
        /// </summary>
        public int mf;

        //======================================================================
        // Private Properties
        //======================================================================
        /// <summary>
        /// The desires.
        /// 需求列表
        /// </summary>
        private Desire desire;

        //======================================================================
        // Public Functions
        //======================================================================

        public Chara(String data) {
            cp = new CProperties(data);
            desire = new Desire();
        }

        /// <summary>
        /// Gets the actions.
        /// 人物可执行的操作
        /// </summary>
        /// <returns>The actions.</returns>
        public String[] GetActions() {
            String[] actions = { };
            return actions;
        }

        /// <summary>
        /// Excutes the action.
        /// </summary>
        /// <param name="name">动作名称</param>
        public void ExcuteAction(String name) {

        }

        public void WantTODO() {

        }

        //======================================================================
        // Private Functions
        //======================================================================

        private void ActivityPath() {

        }
    }
}
