using System;
using GST.DesireSpace;

namespace GST.CharaSpace {
    public class CProperties {
        //======================================================================
        // Public Properties
        //======================================================================
        /// <summary>
        /// The surname.
        /// 姓名: 姓
        /// </summary>
        public string surname;
        /// <summary>
        /// The lastname.
        /// 姓名: 名
        /// </summary>
        public string lastname;
        /// <summary>
        /// The sex.
        /// 性别
        /// </summary>
        public string sex;

        //======================================================================
        // Public Functions
        //======================================================================

        public CProperties(string str) {
            var list = str.Split(' ');
            surname = list[1];
            lastname = list[2];
            sex = SetSex(list[3]);
        }

        //======================================================================
        // Private Functions
        //======================================================================

        private string SetSex(string i) {
            return (i == "1") ? "男" : "女";
        }
    }
}
