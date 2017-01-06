using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThExpr.Utility
{
    class SettingsUtility
    {
        public static string Basic_Username
        {
            set
            {
                Properties.Settings.Default["Basic_Username"] = value;
                Properties.Settings.Default.Save();
            }
            get
            {
                return Properties.Settings.Default["Basic_Username"] as string;
            }
        }

        public static string Basic_Password
        {
            set
            {
                Properties.Settings.Default["Basic_Password"] = value;
                Properties.Settings.Default.Save();
            }
            get
            {
                return Properties.Settings.Default["Basic_Password"] as string;
            }
        }

        public static string ApiUrl
        {
            set
            {
                Properties.Settings.Default["ApiUrl"] = value;
                Properties.Settings.Default.Save();
            }
            get
            {
                return Properties.Settings.Default["ApiUrl"] as string;
            }
        }
    }
}
