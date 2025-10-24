using Intyerfaces_static.Models;

Console.WriteLine();
Food food = new Food();
Console.WriteLine("1=> Create Food");
Console.WriteLine("2=> Get all food");
Console.WriteLine("3=> Choose food");
while (true)
{
    switch (Console.ReadLine())
    {
        case "1":
            food.CreateFood();
            break;
        case "2":
            food.GetAllFood();
            break;
        case "3":
            food.SortFoodByPrice(12);
            break;
    }
}