using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Intepro.DataAccess;
using System.Data;

namespace Contacts.BusinessLogic
{
    class ContactsBLL
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string ContactNo { get; set; }

        private mssqlDAL dal = new mssqlDAL();

        public void Add()
        {
            dal.Open();
            dal.SetSql("INSERT INTO Contacts VALUES (@a, @b, @c)");
            dal.AddParameter("@a", ID);
            dal.AddParameter("@b", Name);
            dal.AddParameter("@c", ContactNo);
            dal.Execute();
            dal.Close();
        }
        public DataTable GetAll()
        {
            dal.Open();
            dal.SetSql("SELECT * FROM Contacts");
            DataTable dt = dal.GetData();
            dal.Close();

            return dt;
        }
        public void Delete()
        {
            dal.Open();
            dal.SetSql("DELETE Contacts WHERE ContactID = @id");
            dal.AddParameter("@id", ID);
            dal.Execute();
            dal.Close();    
        }
        public void Edit(int oldID)
        {
            dal.Open();
            dal.SetSql("UPDATE Contacts " +
                "SET ContactID = @id," +
                "   Name = @n," +
                "   ContactNo = @cNo " +
                "WHERE ContactID = @oldID");
            dal.AddParameter("@id", ID);
            dal.AddParameter("@n", Name);
            dal.AddParameter("@cNo", ContactNo);
            dal.AddParameter("@oldID", oldID);
            dal.Execute();
            dal.Close();
        }
        public void Validate()
        {
            //1.) Ensure that ContactID is 7 digits only
            if (ID.ToString().Length < 7)
            {
                Exception err = new Exception("ID must have exactly 7 digits.");
                err.Source = "Contact Information rules";
                throw err;
            }
            //2.) Name of Contact is 5 - 100 chars only
            if (Name.Length < 5 || Name.Length > 100)
            {
                Exception err = new Exception("Contact name must be between 5 - 100 characters only.");
                err.Source = "Contact information rules";
                throw err;
            }
            //3.) Contact no must be 7 or 11 chars only
            if (ContactNo.Length < 11)
            {
                Exception err = new Exception("Contact number must have 11 characters.");
                err.Source = "Contact information rules";
                throw err;
            }

        }
    }
}
