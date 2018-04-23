using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sysprog
{
    [Serializable]
    class Contact
    {
        public Contact(String firstName, String lastName, String phoneNumber)
        {
            FirstName = firstName;
            LastName = lastName;
            PhoneNumber = phoneNumber;
        }

        public String FirstName { get; set; }
        public String LastName { get; set; }
        public String PhoneNumber { get; set; }
    }
}
