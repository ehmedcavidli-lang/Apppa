using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates_Practice.Models
{
    public delegate bool Find(int num);
    internal class EvenAndPositives
    {
        public bool isEven(int num)
        {
            return num % 2 == 0;
        }

        public bool isPositive(int num)
        {
            return num > 0;
        }
       

    }
}
