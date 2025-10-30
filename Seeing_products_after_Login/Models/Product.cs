using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Seeing_products_after_Login.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public float Price { get; set; }
        public float Discount { get; set; }
        public DateTime CreatedAt { get; set; }=DateTime.Now;
        public DateTime DiscountExpired { get; set; } = DateTime.Now.AddDays(3);
        public Product(int id,string name,float price,float discount)
        {
            Id = id;
            Name = name;
            Price = price;
            Discount = discount;
           

        }
     
        public  void GetInfo()
        {
            Console.WriteLine($"Product ID : {Id}\nProduct Name: {Name}\nProduct " +
                $"Price {Price}\nProduct " +
                $"last price: " +
                $"{Price*(100-Discount)/100}\nCreated Product :{CreatedAt}\n" +
                $"Expired Discount:{DiscountExpired} ");
        }
    }
    
}
