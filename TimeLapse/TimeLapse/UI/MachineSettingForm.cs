using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TimeLapse.UI
{
    public partial class MachineSettingForm : ChildForm
    {
        public string IpAddress { get; set; }

        public int MotionStep { get; set; }

        public string StepUnit { get; set; }

        public int MotinSpeed { get; set; }

        public MachineSettingForm()
        {
            InitializeComponent();
        }
    }
}
