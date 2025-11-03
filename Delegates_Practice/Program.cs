using Delegates_Practice.Models;
using System.Security.Cryptography.X509Certificates;
using static Delegates_Practice.Models.Notification;


#region Even and Positives
//EvenAndPositives even = new EvenAndPositives();

//Find findEven = new Find(even.isEven);
//Find findPositive = new Find(even.isPositive);

//int[] numbers = { 1, 2, 3, 4, 5, 6, -4, -5, -7, 10 };
//Console.WriteLine("Even numbers: ");
//foreach (int number in numbers)
//{
//    if (findEven(number))
//    {
//        Console.WriteLine(number);
//    }
//}
//Console.WriteLine("Positive numbers: ");
//foreach (int number in numbers)
//{
//    if (findPositive(number))
//    {
//        Console.WriteLine(number);
//    }
//} 
#endregion

Notification notification = new Notification();
Notify not1 = new Notify(notification.SendNotification);
not1 += notification.EmailNotification;

bool result = not1("Tasklariniz yuklendi");
Console.WriteLine(result);

