using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Intepro.DataAccess;
using System.Data;

namespace AddAcct.BusinessLogic
{
    class AddAcctBLL
    {
        public string Username { get; set; }
        public string Password { get; set; }
        public string ConfirmPWD { get; set; }
        public string OldPWD { get; set; }

        private mssqlDAL dal = new mssqlDAL();

        public void AddAcct()
        {
            dal.Open();
            dal.SetSql("INSERT INTO Login VALUES (@a, @b)");
            dal.AddParameter("@a", Username);
            dal.AddParameter("@b", Password);
            dal.Execute();
            dal.Close();
        }
        public void EditPwd()
        {
            dal.Open();
            dal.SetSql("UPDATE Login " +
                "SET    Password = @pwd " +
                "WHERE Username = @username");
            dal.AddParameter("@pwd", Password);
            dal.AddParameter("@username", Username);
            dal.Execute();
            dal.Close();
        }
        public void Login()
        {
            dal.Open();
            dal.SetSql("SELECT * FROM Login WHERE " +
                "Username = @userName and Password = @pass");
            dal.AddParameter("@userName", Username);
            dal.AddParameter("@pass", Password);
            dal.Execute();
            dal.Close();
        }
        public void Validate1()
        {
            if (ConfirmPWD != Password)
            {
                Exception err1 = new Exception("Passwords do not match.");
                err1.Source = "Account Creation Rules";
                throw err1;
            }
        }
    }
}
