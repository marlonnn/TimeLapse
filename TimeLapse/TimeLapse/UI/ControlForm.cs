using DevComponents.DotNetBar;
using Summer.System.Core;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TimeLapse.Operation;

namespace TimeLapse.UI
{
    public partial class ControlForm : Office2007RibbonForm
    {
        private CommandQueue CommandQueue;
        public ControlForm()
        {
            InitializeComponent();
        }

        private void Exit()
        {
            try
            {
                Quartz.Impl.StdScheduler scheduler = (Quartz.Impl.StdScheduler)SpringHelper.GetContext().GetObject("scheduler");
                scheduler.Shutdown();
            }
            catch (Exception ee)
            {
            }
        }

        private void buttonItemStart_Click(object sender, EventArgs e)
        {

        }

        private void buttonItemPause_Click(object sender, EventArgs e)
        {

        }

        private void buttonItemStop_Click(object sender, EventArgs e)
        {

        }

        private void buttonItemSnapShot_Click(object sender, EventArgs e)
        {

        }

        private void buttonItemAutoFocus_Click(object sender, EventArgs e)
        {

        }
    }
}
