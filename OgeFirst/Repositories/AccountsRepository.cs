using OgeFirst.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;

namespace OgeFirst.Repositories
{
    public class AccountsRepository : RepositoryBase
    {
        public static bool Exists(RegistrationDTO dto)
        {
            try
            {
                Perform(ReadStatus, dto);
                return true;
            }
            catch
            {
                return false;
            }
        }

        public static int GetStatus(RegistrationDTO dto)
        {
            return (int)Perform(ReadStatus, dto);
        }

        private static object ReadStatus(SqlConnection connection, object dto)
        {
            var dtoPrepared = (RegistrationDTO)dto;
            var sql = String.Format("SELECT Status FROM ACCOUNTS WHERE Email = '{0}' AND Password = '{1}'", dtoPrepared.Email, dtoPrepared.Password);
            var scalar = new SqlCommand(sql, connection).ExecuteScalar();
            return Convert.ToInt32(scalar);
        }

        
    }
}