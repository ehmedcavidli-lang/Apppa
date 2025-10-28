
using OOP_PRACRICE.Helpers.Enums;
using OOP_PRACRICE.Models;

void GetMenu()
{
    Console.WriteLine("Please ENter Operation\n\n\n\n\n");
    Console.WriteLine("1 ==> Create Product");
    Console.WriteLine("2 ==> Get All Product");
    Console.WriteLine("3 ==> Update Product");
}
Product product = new Product();
while (true)
{
    GetMenu();

    string input = Console.ReadLine();
    int operation;
    bool isCheck = int.TryParse(input, out operation);

    if (isCheck)
    {
        switch (operation)
        {
            case 1: 
                product.CreateProduct(product);
                break;
            case 2:
                product.GetAllProduct();
                Console.WriteLine("\nPress any key to continue...");
                Console.ReadKey(); // Burada dayanır ki, istifadəçi görsün
                break;
            default:
                Console.WriteLine(" Düzgün seçim etmədiniz!");
                break;
            case 3: // Update Product
                product.UpdateProduct();

                break;
        }
    }
    else
    {
        Console.WriteLine(" Zəhmət olmasa düzgün rəqəm daxil edin!");
    }
}