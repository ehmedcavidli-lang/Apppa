using List_Generic_Collections.Database;
using List_Generic_Collections.Helpers;
using List_Generic_Collections.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace List_Generic_Collections.Services
{
    internal class CustomerService : ICustomService
    {
        public List<Customer> GetAll()
        {
            return AppDbContext.customers;
        }

        public Customer GetbyId(int? id)
        {
            if (id is null) throw new NotFoundException("Customer not found");
                return AppDbContext.customers.FirstOrDefault(c=>c.id,Id=id);
        }
    }
}
