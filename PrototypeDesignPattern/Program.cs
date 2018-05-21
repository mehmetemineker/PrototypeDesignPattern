using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrototypeDesignPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Book book1 = new Book
            {
                Name = "Journey to the Moon",
                Author = new Author
                {
                    FullName = "Jules Verne - 1"
                }
            };

            Console.WriteLine("book1.Name: " + book1.Name);
            Console.WriteLine("book1.Author.FullName: " + book1.Author.FullName);

            // Object assignment -> Shallow Copy
            Console.WriteLine();
            Console.WriteLine("[ book2 = book1 ]");

            Book book2 = book1;
            
            Console.WriteLine("book2.Name: " + book2.Name);
            Console.WriteLine("book2.Author.FullName: " + book2.Author.FullName);

            book2.Name = "Around The World in 80 Days";
            book2.Author.FullName = "Jules Verne - 2";

            Console.WriteLine("book1.Name: " + book1.Name);
            Console.WriteLine("book1.Author.FullName: " + book1.Author.FullName);
            Console.WriteLine("book2.Name: " + book2.Name);
            Console.WriteLine("book2.Author.FullName: " + book2.Author.FullName);

            Console.WriteLine("--------------------------------");

            // MemberwiseClone -> Shallow Copy
            Console.WriteLine();
            Console.WriteLine("[ book1 -> MemberwiseClone -> book3 ]");

            Book book3 = (Book)book1.Copy();

            book3.Name = "Journey to the Center of the Earth";
            book3.Author.FullName = "Jules Verne - 3";

            Console.WriteLine("book1.Name: " + book1.Name);
            Console.WriteLine("book1.Author.FullName: " + book1.Author.FullName);
            Console.WriteLine("book2.Name: " + book2.Name);
            Console.WriteLine("book2.Author.FullName: " + book2.Author.FullName);
            Console.WriteLine("book3.Name: " + book3.Name);
            Console.WriteLine("book3.Author.FullName: " + book3.Author.FullName);

            Console.WriteLine("--------------------------------");

            // Clone Serialize -> Deep Copy
            Console.WriteLine();
            Console.WriteLine("[ book1 -> Clone Serialize -> book4 ]");

            Book book4 = (Book)book1.Clone();

            book4.Name = "The Mysterious Island";
            book4.Author.FullName = "Jules Verne - 4";

            Console.WriteLine("book1.Name: " + book1.Name);
            Console.WriteLine("book1.Author.FullName: " + book1.Author.FullName);
            Console.WriteLine("book2.Name: " + book2.Name);
            Console.WriteLine("book2.Author.FullName: " + book2.Author.FullName);
            Console.WriteLine("book3.Name: " + book3.Name);
            Console.WriteLine("book3.Author.FullName: " + book3.Author.FullName);
            Console.WriteLine("book4.Name: " + book4.Name);
            Console.WriteLine("book4.Author.FullName: " + book4.Author.FullName);

            Console.ReadLine();
        }
    }
}
