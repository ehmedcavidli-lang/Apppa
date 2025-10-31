using List_Generic_Collections.Models;
using List_Generic_Collections.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace List_Generic_Collections.Database
{
    internal static class AppDbContext
    {
        public static List<Customer> customers;
        static AppDbContext()
        {
            customers = new List<Customer>()
            {
                new Customer { Id = 1, Name = "Aybeniz Eziziova", Age = 20, Adress = "Sebail" },
                new Customer { Id = 2, Name = "Elvin Aliyev", Age = 25, Adress = "Iceriseher" },
                new Customer { Id = 3, Name = "Rauf Memmedli", Age = 40, Adress = "Sabuncu" },
                new Customer { Id = 4, Name = "Gulay Huseynova", Age = 20, Adress = "Suraxani" },
                new Customer { Id = 5, Name = "Ceyhun Mirzeyev", Age = 32, Adress = "Yasmal" }

            };
        

        }
    }
}
