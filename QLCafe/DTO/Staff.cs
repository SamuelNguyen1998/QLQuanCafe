using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLCafe.DTO
{
    public class Staff
    {
        public Staff(int id, string name, string address, string numberPhone)
        {
            this.ID = id;
            this.Name = name;
            this.Address = address;
            this.NumberPhone = numberPhone;
        }
        public Staff(DataRow row)
        {
            this.ID = (int)row["id"];
            this.Name = row["name"].ToString();
            this.Address = row["address"].ToString();
            this.NumberPhone = row["phone"].ToString();
        }
        private int iD;
        private string name;
        private string address;
        private string numberPhone;

        public int ID
        {
            get
            {
                return iD;
            }

            set
            {
                iD = value;
            }
        }

        public string Name
        {
            get
            {
                return name;
            }

            set
            {
                name = value;
            }
        }

        public string Address
        {
            get
            {
                return address;
            }

            set
            {
                address = value;
            }
        }

        public string NumberPhone
        {
            get
            {
                return numberPhone;
            }

            set
            {
                numberPhone = value;
            }
        }
    }
}
