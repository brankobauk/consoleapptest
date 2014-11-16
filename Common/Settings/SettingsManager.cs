using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Common.Properties;


namespace Common
{
    public class SettingsManager
    {
        public static string ApplicationName { get { return Settings.Default.ApplicationName; } }
        public static string SMTP { get { return Settings.Default.SMTP; } }

    }
}
