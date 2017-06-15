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
using TimeLapse.Operation.MobilityCommand;

namespace TimeLapse.UI
{
    public partial class MobilityForm : Form
    {
        private MobilityThread mobilityThread;

        public CommandFactory CommandFactory { get; set; }

        private AutoFocusForm autoFocusForm;

        public MobilityForm()
        {
            InitializeComponent();
            this.Load += MobilityForm_Load;
        }

        private void MobilityForm_Load(object sender, EventArgs e)
        {
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            mobilityThread.StartWorker();
        }

        private void btnPause_Click(object sender, EventArgs e)
        {
            mobilityThread.PauseWorker();
        }

        private void btnRusume_Click(object sender, EventArgs e)
        {
            mobilityThread.ResumeWorker();
        }

        private void btnFocus_Click(object sender, EventArgs e)
        {
            if (autoFocusForm != null)
                autoFocusForm.ShowDialog();
        }
    }
}
