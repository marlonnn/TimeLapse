using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimeLapse.DBADO
{
    public class DBADOFactory
    {
        private LogADO logADO;

        private PatientADO patientADO;

        private SlideADO slideADO;

        private TransferADO transferADO;

        private TreamentADO treamentADO;

        public DBADOFactory(LogADO logADO, PatientADO patientADO, SlideADO slideADO, TransferADO transferADO, TreamentADO treamentADO)
        {
            this.logADO = logADO;
            this.patientADO = patientADO;
            this.slideADO = slideADO;
            this.transferADO = transferADO;
            this.treamentADO = treamentADO;
        }

        public IList<TLog> QueryAllLogData()
        {
            string sql = "Select * from log";
            return logADO.FindAll(sql);
        }

        public IList<TPatient> QueryAllPatientData()
        {
            string sql = "Select * from patient";
            return patientADO.FindAll(sql);
        }
        public IList<TSlide> QueryAllSlideData()
        {
            string sql = "Select * from slide";
            return slideADO.FindAll(sql);
        }

        public IList<TTransfer> QueryAllTransferData()
        {
            string sql = "Select * from transfer";
            return transferADO.FindAll(sql);
        }
        public IList<TTreament> QueryAllTreamentData()
        {
            string sql = "Select * from treatment";
            return treamentADO.FindAll(sql);
        }
    }
}
