using Summer.System.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using TimeLapse.SystemFunction.MiniDump;
using TimeLapse.UI;

namespace TimeLapse
{
    static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            try
            {
                //初始化MiniDump
                MiniDump.Init();

                SplashScreenForm.ShowSplash();


                SplashScreenForm.CloseSplash();

                Form1 form1 = SpringHelper.GetObject<Form1>("form1");

                Application.Run(form1);
            }
            catch (Exception e)
            {

                throw e;
            }
        }

        public static string MajorVersion
        {
            get
            {
                return GetMajorVersion(Application.ProductVersion);
            }
        }

        public static string GetMajorVersion(string version)
        {
            if (version != null && version.Length > 5) version = version.Substring(0, version.Length - 5);
            return version;
        }
    }
}
