using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//--
using DataLayer;
using TransferObject;

namespace BusinessLayer //vai tro Truong Phong
{
    public class LoginBL
    {
        private LoginDL loginDL; //goi ham nhanvien yeu cau thuc hien task
        public LoginBL()
        {
            loginDL = new LoginDL(); //khai bao va tao dtuong LoginDL
        }
        public bool Login(Account account)
        {
            try
            {
                return (loginDL.Login(account)); //yeu cau nien LoginDL dung phuong thuc bool Login dang nhap vao 1 account
            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }
     
    }
}
