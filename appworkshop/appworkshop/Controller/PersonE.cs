using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace appworkshop.Controller
{
    class PersonE
    {
        private string name;
        private string lastName1;
        private string lastName2;
        private string housePhone;
        private string celphone;
        private string address;

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

        public string LastName1
        {
            get
            {
                return lastName1;
            }

            set
            {
                lastName1 = value;
            }
        }

        public string LastName2
        {
            get
            {
                return lastName2;
            }

            set
            {
                lastName2 = value;
            }
        }

        public string HousePhone
        {
            get
            {
                return housePhone;
            }

            set
            {
                housePhone = value;
            }
        }

        public string Celphone
        {
            get
            {
                return celphone;
            }

            set
            {
                celphone = value;
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

        public PersonE(string pName, string pLastName1, string pLastName2, string pHousePhone, string pCelphone, string pAddress)
        {
            this.Name = pName;
            this.LastName1 = pLastName1;
            this.LastName2 = pLastName2;
            this.HousePhone = pHousePhone;
            this.Celphone = pCelphone;
            this.Address = pAddress;
        }

        public PersonE()
        {
        }

        public virtual string ToString()
        {
            StringBuilder msg = new StringBuilder("");

            /*msg.Append("\n");
            msg.Append("Name       : " + this.Name);
            msg.Append("\n");
            msg.Append("Fecha        : " + this.Date);
            msg.Append("\n");
            msg.Append("Cobro        : " + this.GetPayment());
            msg.Append("\n");
            msg.Append("Impuesto     : " + this.Tax());
            msg.Append("\n");
            msg.Append("Total a pagar: " + this.TotalToPay());*/

            return msg.ToString();
        }
    }
}
