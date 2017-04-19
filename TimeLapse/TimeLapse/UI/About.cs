using System;
using System.Reflection;
using System.Windows.Forms;
using DevComponents.DotNetBar;
using TimeLapse.Properties;

namespace TimeLapse.UI
{
    /// <summary>
    /// 关于窗口
    /// </summary>
    partial class About : Office2007Form
    {
        public About()
        {
            InitializeComponent();
            this.Text = String.Format(Resources.StrAbout, Application.ProductName);
            this.labelProductName.Text = Application.ProductName + " " + Program.MajorVersion;
            this.labelBuiltTime.Text = Resources.StrBuiltDate +
                                      System.IO.File.GetLastWriteTime(this.GetType().Assembly.Location).ToCSTTime().ToString();
            this.labelCopyright.Text = Resources.StrCopyRight;
            this.labelCompanyName.Text = Resources.StrCompanyName;
            this.textBoxDescription.Text = Resources.StrWarning;
        }

        #region Assembly Attribute Accessors

        public string AssemblyDescription
        {
            get
            {
                object[] attributes = Assembly.GetExecutingAssembly().GetCustomAttributes(typeof(AssemblyDescriptionAttribute), false);
                if (attributes.Length == 0)
                {
                    return "";
                }
                return ((AssemblyDescriptionAttribute)attributes[0]).Description;
            }
        }

        public string AssemblyProduct
        {
            get
            {
                object[] attributes = Assembly.GetExecutingAssembly().GetCustomAttributes(typeof(AssemblyProductAttribute), false);
                if (attributes.Length == 0)
                {
                    return "";
                }
                return ((AssemblyProductAttribute)attributes[0]).Product;
            }
        }

        public string AssemblyCopyright
        {
            get
            {
                object[] attributes = Assembly.GetExecutingAssembly().GetCustomAttributes(typeof(AssemblyCopyrightAttribute), false);
                if (attributes.Length == 0)
                {
                    return "";
                }
                return ((AssemblyCopyrightAttribute)attributes[0]).Copyright;
            }
        }

        public string AssemblyCompany
        {
            get
            {
                object[] attributes = Assembly.GetExecutingAssembly().GetCustomAttributes(typeof(AssemblyCompanyAttribute), false);
                if (attributes.Length == 0)
                {
                    return "";
                }
                return ((AssemblyCompanyAttribute)attributes[0]).Company;
            }
        }
        #endregion

        private void labelCopyright_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("http://www.cii-tech.com");
        }

    }
}
