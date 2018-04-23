using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Sysprog
{
    [Serializable]
    abstract class Customer : ISerializable
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
        public IList<Service> Services { get; private set; }

        protected Customer(SerializationInfo info, StreamingContext context)
        {
            ID = info.GetString("ID");
            Int32 id = Int32.Parse(ID);
            if (id >= idCounter)
                idCounter = id + 1;
            Name = info.GetString("Name");
            Address = info.GetString("Address");
            PostCode = info.GetString("PostCode");
            PhoneNumber = info.GetString("PhoneNumber");

            Services = (List<Service>)info.GetValue("Services", typeof(List<Service>));
        }

        public virtual void GetObjectData(SerializationInfo info, StreamingContext context)
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
