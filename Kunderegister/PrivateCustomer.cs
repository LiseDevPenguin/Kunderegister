using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kunderegister
{
    [Serializable]
    class PrivateCustomer : Customer
    {
        public PrivateCustomer(String firstName, String lastName, String address, String postCode, String phoneNumber) 
            :base(firstName + " " + lastName, address, postCode, phoneNumber)
        {
            FirstName = firstName;
            LastName = lastName;
        }

        new public String Name
        {
            get => FirstName + " " + LastName;
            
            set
            {
                List<String> names = new List<String>(value.Split(' '));
                LastName = names.Last();
                names.RemoveAt(names.Count - 1);
                FirstName = names.Aggregate((String first, String second) => first + " " + second);
            }
        }
        public String FirstName { get; set; }
        public String LastName { get; set; }
    }
}
