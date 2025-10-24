using Intyerfaces_static.Interfaces;

namespace Intyerfaces_static.Models
{
    public class Food : IFood
    {
        public string FoodName { get; set; }
        public string Ingridents { get; set; }
        public decimal Price { get; set; }
        public DateTime ExpiredTime { get; set; }
        public DateTime CookingTime { get; set; } = DateTime.Now;

        public void CreateFood()
        {
            Console.WriteLine("Please add Food : ");
            FoodName = Console.ReadLine();
            Console.WriteLine("Please add ingridents : ");
            Ingridents = Console.ReadLine();
            Console.WriteLine("Please add price : ");
            Price = Convert.ToDecimal(Console.ReadLine());
            ExpiredTime = CookingTime.AddMinutes(180);

        }

        public void GetAllFood()
        {
            Console.WriteLine($"Food Name : {FoodName}\nIngridents : {Ingridents}\n Price : {Price}" +
                $"Cooking Time : {CookingTime} End Time : {ExpiredTime}");
        }

        public void SortFoodByPrice(decimal price)
        {

        }
    }
}
