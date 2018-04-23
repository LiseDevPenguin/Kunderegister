using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Sysprog
{
    [Serializable]
    class PrivateCustomer : Customer, ISerializable
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

        protected PrivateCustomer(SerializationInfo info, StreamingContext context)
            :base(info, context)
        {
            Name = base.Name;
        }

        public virtual new void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            info.AddValue("ID", ID);
            info.AddValue("Name", Name);
            info.AddValue("Address", Address);
            info.AddValue("PostCode", PostCode);
            info.AddValue("PhoneNumber", PhoneNumber);
            info.AddValue("Services", Services, typeof(List<Service>));
        }
    }
}
