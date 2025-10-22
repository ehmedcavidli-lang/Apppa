using Abstract_Polimorphism.Models;
using static System.Reflection.Metadata.BlobBuilder;

Ebook ebook = new Ebook("7 gozel", "Nizami Gencevi", "1 sevgi macerasi", "Url linki123");
Ebook ebook2 = new Ebook("Don Kixot", "Nizami Gencevi", "Qatil", "Url linki1234");
Ebook ebook3 = new Ebook("Cinayet ve Ceza", "Dostoyevski", "Cinayetin cezasi", "Url linki12345");
Ebook ebook4 = new Ebook("Cerpeleng ucuran", "Xalid Huseyni", "Usaqliq dostu", "Url linki123456");
Ebook ebook5 = new Ebook("Kosmos", "Karl seqan", "Kosmosun fethi", "Url linki1234567");
Ebook[] books = { ebook, ebook2, ebook3, ebook4, ebook5 };

bool found = false;



foreach (var book in books)
{
    if (book.Author == "Behruz Gencevi")
    {
        book.PrintBookInfo();
        found = true;
    }
}

if (!found)
{
    Console.WriteLine("Tapilmadi");
}



