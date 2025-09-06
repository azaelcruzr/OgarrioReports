using System;

namespace OgarrioReports.Models
{
    public class ReportDailyDB
    {
        public string D202_ID { get; set; }
        public string D202_START_DATE { get; set; }
        public string D202_END_DATE { get; set; }
        public string D202_PRINT_DATE { get; set; }
        public double D202_VOL_OP { get; set; }
        public double D202_VOL_CL { get; set; }
        public double D202_IVOL { get; set; }
        public double D202_GUVOL { get; set; }
        public double D202_MASS { get; set; }
        public double D202_GSVOL_60 { get; set; }
        public double D202_NSVOL_60 { get; set; }
        public double D202_GSVOL_68 { get; set; }
        public double D202_NSVOL_68 { get; set; }
        public long D202_PULSES { get; set; }
        public double D202_PRESS { get; set; }
        public double D202_TEMP { get; set; }
        public double D202_DENS_OBS { get; set; }
        public double D202_DENS_60 { get; set; }
        public double D202_WCT { get; set; }
        public double D202_CTL_60 { get; set; }
        public double D202_CPL_60 { get; set; }
        public double D202_MF { get; set; }
        public double D202_KF { get; set; }
        public double D202_TIME_F { get; set; }
    }
}
