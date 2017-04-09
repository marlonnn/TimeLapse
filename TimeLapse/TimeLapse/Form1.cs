using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TimeLapse.DBADO;

namespace TimeLapse
{
    public partial class Form1 : Form
    {
        private DBADOFactory dbADOFactory;
        public Form1()
        {
            InitializeComponent();
            this.Load += Form1_Load;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                var v1 = dbADOFactory.QueryAllPatientData();
                var v2 = dbADOFactory.QueryAllLogData();
                var v3 = dbADOFactory.QueryAllSlideData();
                var v4 = dbADOFactory.QueryAllTransferData();
                var v5 = dbADOFactory.QueryAllTreamentData();

            }
            catch (Exception ee)
            {

                throw ee;
            }
        }
    }
}
