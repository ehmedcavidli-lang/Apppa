using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Polimorphism.Models
{
    internal abstract class Book
    {
        public string Title { get; set; }

        public string Author { get; set; }

        public string Name { get; set; }

        protected Book (string name,string author, string title)
        {
            Name = name;
            Title = title;
            Author = author;
        }
        public abstract void PrintBookInfo();
       
        
    }
}
