using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassMethodDemo
{
    internal class CustomerManager
    {
        List<Customer> Customer = new List<Customer>();
        int index = 0;
        public void AddToCustomer(Customer customer)
        {
            Console.WriteLine("Customer is added");
            Customer.Add(Customer);
        }

        public void Customer1(Customer customer)
        {
            foreach (var item in Customer)
            {
                if (Customer.Id == item.Id && Customer.Name == item.Name)
                {
                    index = item.Id - 1;
                }
            }
            Customer.RemoveAt(index);
            Console.WriteLine("Customer is Deleted");
        }

        public void Customer()
        {
            foreach (var Customer in Customer)
            {
                Console.WriteLine("Customer.Namw : " + Customer.Name);
            }
        }
    }

}
