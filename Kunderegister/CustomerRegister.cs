using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kunderegister
{
    [Serializable]
    class CustomerRegister
    {
        private List<Customer> customers;

        public CustomerRegister()
        {
            customers = new List<Customer>();
        }

        public IReadOnlyList<Customer> Customers
        { get => customers.AsReadOnly(); }

        public void Add(Customer customer) => customers.Add(customer);
        public void Remove(Customer customer) => customers.Remove(customer);
        public void Remove(String ID) => customers.RemoveAll((Customer customer) => customer.ID == ID);
    }
}
