using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TransferObject;

namespace DataLayer //vai tro nhanvien 
{
    public class LoginDL : DataProvider //LoginDL ke thua lop Dataprovider
    {
        public bool Login(Account account)
        {
            //table Users chua username, password
            string sql = "SELECT COUNT(username) FROM Users WHERE Username = '" + account.Username + "' AND Password = '" + account.Password + "'";

            try
            {
                return ((int)(MyExcuteScalar(sql, CommandType.Text)) > 0); //?
            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }
    }
}
