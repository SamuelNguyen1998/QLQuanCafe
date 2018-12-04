using QLCafe.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLCafe.DAO
{
    public class StaffDAO
    {
        private static StaffDAO instance;

        public static StaffDAO Instance
        {
            get { if (instance == null) instance = new StaffDAO(); return StaffDAO.instance; }
            private set { StaffDAO.instance = value; }
        }
        private StaffDAO() { }
        public List<Staff> LoadStaffList()
        {
            List<Staff> staffList = new List<Staff>();

            DataTable data = Database.Instance.ExecuteQuery("select * from Staff");

            foreach (DataRow item in data.Rows)
            {
                Staff Staff = new Staff(item);
                staffList.Add(Staff);
            }

            return staffList;
        }
        public bool InsertStaff(string name, string address, string numberphone)
        {
            string query = string.Format("INSERT dbo.Staff (name, address,phone )VALUES  ( N'{0}', N'{1}',N'{2}')", name, address,numberphone);
            int result = Database.Instance.ExecuteNonQuery(query);

            return result > 0;
        }
        public bool UpdateStaff(string name, string address, string numberphone, int id)
        {
            string query = string.Format("UPDATE dbo.Staff SET name = N'{0}', address = N'{1}', phone = N'{2}' WHERE id = {3}", name, address, numberphone, id);
            int result = Database.Instance.ExecuteNonQuery(query);

            return result > 0;
        }
        public bool DeleteStaff(int id)
        {

            string query = string.Format("Delete from dbo.Staff where id = {0}", id);
            int result = Database.Instance.ExecuteNonQuery(query);

            return result > 0;
        }
    }
}
