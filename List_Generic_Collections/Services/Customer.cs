namespace List_Generic_Collections.Services
{
    public class Customer:BaseEntity
    {
        public string Name { get; set; }
        public int Id { get; set; }
        public string Adress { get; set; }
    }

    public abstract class BaseEntity
    {

    }
}