using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Sysprog
{
    [Serializable]
    class BusinessCustomer : Customer, ISerializable
    {
        public BusinessCustomer(String name, String address, String postCode, String phoneNumber, Contact contact = null) 
            :base(name, address, postCode, phoneNumber)
        {
            Contact = contact;
        }

        public Contact Contact { get; set; }

        protected BusinessCustomer(SerializationInfo info, StreamingContext context)
            :base(info, context)
        {
            Contact = (Contact)info.GetValue("Contact", typeof(Contact));
        }

        public virtual new void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            info.AddValue("ID", ID);
            info.AddValue("Name", Name);
            info.AddValue("Address", Address);
            info.AddValue("PostCode", PostCode);
            info.AddValue("PhoneNumber", PhoneNumber);
            info.AddValue("Services", Services, typeof(List<Service>));
            info.AddValue("Contact", Contact, typeof(Contact));
        }
    }
}
