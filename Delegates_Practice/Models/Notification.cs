using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates_Practice.Models
{
    internal class Notification
    {
        public delegate bool Notify(string message);
        public bool SendNotification(string message)
        {
            Console.WriteLine("Notification: " + message);
            return true;
        }

        public bool EmailNotification(string message)
        {
            Console.WriteLine("Email notification: " + message);
            return true;
        }
    }
}
