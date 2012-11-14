using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Configuration;

namespace MsgManagerUI
{
    public static class UiUtils
    {
        public static void IncToDelete(System.Windows.Forms.Label labelIn, int count)
        {
            labelIn.Text = count.ToString();
        }
        public static string GetPathFromConfig()
        {
            AppSettingsReader ar = new AppSettingsReader();
            string retVal = (string)ar.GetValue("V1PATH", typeof(string));
            return (retVal);
        }
        public static void WritePathToConfig()
        {
            
        }
    }
}
