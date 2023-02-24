using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OptimizeMemoryPerformanceWithCollection
{
    public class CustomerService
    {
        public List<Customer> Customers { get; set; }
        public CustomerService()
        {
            Customers = new List<Customer>
            {
                new Customer{Id=1,Name="Zahra",Age=28},
                new Customer{Id=2,Name="Sara",Age=-9},
                new Customer{Id=3,Name="Ali",Age=30},
            };
        }
        public IEnumerable<Customer> GetCustomer(int age)
        {
            if (age < 20 || age>70)
            {
                //return null;
                //return new List<Customer>();
              return Enumerable.Empty<Customer>();
            }
            var customers = Customers.Where(x => x.Age > age).ToList();

            return customers;
        }

    }
}
