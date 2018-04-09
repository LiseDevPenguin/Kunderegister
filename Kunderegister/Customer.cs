using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kunderegister
{
    abstract class Customer
    {
        static private Int32 idCounter = 0;
        public Customer(String name, String address, String postCode, String phoneNumber)
        {
            ID = (idCounter++).ToString();
            Name = name;
            Address = address;
            PostCode = postCode;
            PhoneNumber = phoneNumber;

            Services = new List<Service>();
        }
        public String ID { get; }
        public String Name { get; set; }
        public String Address { get; set; }
        public String PostCode { get; set; }
        public String PhoneNumber { get; set; }
        public List<Service> Services { get; private set; }
    }
}
