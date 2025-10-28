using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_PRACRICE.Models
{
    public class Product : BaseEntitie
    {
        private string _name;
        private decimal _price;

        public string Name
        {
            get
            { return _name; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    Console.WriteLine("Name boş və ya null ola bilməz.");

                _name = value;
            }
        }

        public decimal Price
        {
            get
            { return _price; }
            set
            {
                if (value < 0)
                    Console.WriteLine("Price mənfi ola bilməz.");

                _price = value;
            }
        }
        public void CreateProduct(Product product)
        {
            int count = 1;
            Console.WriteLine("Please enter product name: ");
            product.Name = Console.ReadLine();
            Console.WriteLine("Enter price");
            product.Price=decimal.Parse(Console.ReadLine());
            Console.WriteLine("Product size: ");
            product.Size = Console.ReadLine();
            Console.WriteLine("Product season: ");
            product.Season=Console.ReadLine();
            Console.WriteLine("Product category: ");
            product.Category = Console.ReadLine();
            product.Id = count;
            product.CreatedDate = DateTime.Now;
            count ++;
            Console.WriteLine("Product created successfully");


        }
        public void GetAllProduct()
        {
            Console.WriteLine($"ID: {Id}");
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"Price: {Price}");
            Console.WriteLine($"Size: {Size}");
            Console.WriteLine($"Season: {Season}");
            Console.WriteLine($"Category: {Category}");
            Console.WriteLine($"Created Date: {CreatedDate}");
        }
        public void UpdateProduct()
        {
            Console.WriteLine("Hansı sahəni dəyişmək istəyirsiniz? (1-Name, 2-Price, 3-Size, 4-Season, 5-Category)");
            string choice = Console.ReadLine();
            switch (choice)
            {
                case "1":
                    Console.Write("Yeni Name: ");
                    Name = Console.ReadLine();
                    break;
                case "2":
                    Console.Write("Yeni Price: ");
                    Price = decimal.Parse(Console.ReadLine());
                    break;
                case "3":
                    Console.Write("Yeni Size: ");
                    Size = Console.ReadLine();
                    break;
                case "4":
                    Console.Write("Yeni Season: ");
                    Season = Console.ReadLine();
                    break;
                case "5":
                    Console.Write("Yeni Category: ");
                    Category = Console.ReadLine();
                    break;
            }
            Console.WriteLine("Məhsul yeniləndi.");
        }
        public string Size { get; set; }
        public string Season { get; set; }
        public string Category { get; set; }

    }
}
