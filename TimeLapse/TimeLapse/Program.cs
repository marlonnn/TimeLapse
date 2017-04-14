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

                MainForm mainForm = SpringHelper.GetObject<MainForm>("mainForm");
                ControlForm controlForm = SpringHelper.GetObject<ControlForm>("controlForm");
                Application.Run(controlForm);
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
