using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kunderegister
{
    class BusinessCustomer : Customer
    {
        public BusinessCustomer(String name, String address, String postCode, String phoneNumber, Contact contact) 
            :base(name, address, postCode, phoneNumber)
        {
            Contact = contact;
        }

        public Contact Contact { get; set; }
    }
}
