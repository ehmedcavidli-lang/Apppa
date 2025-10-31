namespace List_Generic_Collections.Services
{
    internal interface ICustomService
    {
        List<Customer> GetAll();
        Customer GetbyId(int id);
    }
}