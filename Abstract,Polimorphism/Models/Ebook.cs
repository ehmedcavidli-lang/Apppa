using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Polimorphism.Models
{
    internal  class Ebook:Book
    {
        public string Url { get; set; }

        public Ebook(string name,string author,string title,string url):base(name,author,title)
        {
            Url = url;
        }

        public override void PrintBookInfo()
        {
            Console.WriteLine($"Ebook: {Title} Yazar: {Author} Name: {Name} Url: {Url}");
        }
    }
}
