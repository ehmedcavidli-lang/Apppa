using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HazirMetodlar
{
    internal class CheckEmail
    {
        public string KelimeleriTersineCevir(string cumle)
        {
            


            string[] kelimeler = cumle.Split(' ', StringSplitOptions.RemoveEmptyEntries);


            Array.Reverse(kelimeler);


            return string.Join(" ", kelimeler);
        }
    }


}
