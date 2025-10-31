using List_Generic_Collections.Services;

CustomerService customerService = new CustomerService();
var customers = customerService.GetAll();
foreach (var customer in customers)
{
    Console.WriteLine($"Id : {customer.Id},Name: {customer.Name}" +
        $",Age: {customer.Age}" +
        $",Adress:" +
        $" {customer.Adress},CreatedDate:{customer.CreateDate}");
}

Console.WriteLine("===========================");
try
{
    var costumer = customerService.GetbyId(3);
    Console.WriteLine($"Id : {customer.Id},Name: {customer.Name}" +
        $",Age: {customer.Age}" +
        $",Adress:" +
        $" {customer.Adress},CreatedDate:{customer.CreateDate}");
}
catch (Exception ex)
{

    Console.WriteLine($"Error : {ex.Message}");
}