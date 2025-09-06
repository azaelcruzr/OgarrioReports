using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;

namespace OgarrioReports.Models
{
    public class ReportDaily_Context
    {
        private readonly string connectionString =
            ConfigurationManager.ConnectionStrings["OgarriosDb"].ConnectionString;

        public List<ReportDailyDB> GetDailyReports()
        {
            var result = new List<ReportDailyDB>();

            using (var con = new SqlConnection(connectionString))
            using (var cmd = new SqlCommand(
                @"SELECT TOP 100
                        D202_ID,
                        D202_START_DATE,
                        D202_END_DATE,
                        D202_PRINT_DATE,
                        D202_VOL_OP,
                        D202_VOL_CL,
                        D202_IVOL,
                        D202_GUVOL,
                        D202_MASS,
                        D202_GSVOL_60,
                        D202_NSVOL_60,
                        D202_GSVOL_68,
                        D202_NSVOL_68,
                        D202_PULSES,
                        D202_PRESS,
                        D202_TEMP,
                        D202_DENS_OBS,
                        D202_DENS_60,
                        D202_WCT,
                        D202_CTL_60,
                        D202_CPL_60,
                        D202_MF,
                        D202_KF,
                        D202_TIME_F
                  FROM dbo.Daily_202
                  ORDER BY D202_YEAR DESC, D202_MONTH DESC, D202_DAY DESC;", con))
            {
                con.Open();
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        result.Add(new ReportDailyDB
                        {
                            D202_ID = reader["D202_ID"].ToString(),
                            D202_START_DATE = reader["D202_START_DATE"] == DBNull.Value ? "" : reader["D202_START_DATE"].ToString(),
                            D202_END_DATE = reader["D202_END_DATE"] == DBNull.Value ? "" : reader["D202_END_DATE"].ToString(),
                            D202_PRINT_DATE = reader["D202_PRINT_DATE"] == DBNull.Value ? "" : reader["D202_PRINT_DATE"].ToString(),
                            D202_VOL_OP = Convert.ToDouble(reader["D202_VOL_OP"]),
                            D202_VOL_CL = Convert.ToDouble(reader["D202_VOL_CL"]),
                            D202_IVOL = Convert.ToDouble(reader["D202_IVOL"]),
                            D202_GUVOL = Convert.ToDouble(reader["D202_GUVOL"]),
                            D202_MASS = Convert.ToDouble(reader["D202_MASS"]),
                            D202_GSVOL_60 = Convert.ToDouble(reader["D202_GSVOL_60"]),
                            D202_NSVOL_60 = Convert.ToDouble(reader["D202_NSVOL_60"]),
                            D202_GSVOL_68 = Convert.ToDouble(reader["D202_GSVOL_68"]),
                            D202_NSVOL_68 = Convert.ToDouble(reader["D202_NSVOL_68"]),
                            D202_PULSES = Convert.ToInt64(reader["D202_PULSES"]),
                            D202_PRESS = Convert.ToDouble(reader["D202_PRESS"]),
                            D202_TEMP = Convert.ToDouble(reader["D202_TEMP"]),
                            D202_DENS_OBS = Convert.ToDouble(reader["D202_DENS_OBS"]),
                            D202_DENS_60 = Convert.ToDouble(reader["D202_DENS_60"]),
                            D202_WCT = Convert.ToDouble(reader["D202_WCT"]),
                            D202_CTL_60 = Convert.ToDouble(reader["D202_CTL_60"]),
                            D202_CPL_60 = Convert.ToDouble(reader["D202_CPL_60"]),
                            D202_MF = Convert.ToDouble(reader["D202_MF"]),
                            D202_KF = Convert.ToDouble(reader["D202_KF"]),
                            D202_TIME_F = Convert.ToDouble(reader["D202_TIME_F"])
                        });
                    }
                }
            }

            return result;
        }
    }
}
