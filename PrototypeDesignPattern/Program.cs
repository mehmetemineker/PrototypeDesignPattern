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
            // Shallow Copy 
            Book book1 = new Book();
            book1.Name = "Journey to the Moon";

            Console.WriteLine("book1.Name: " + book1.Name);

            Book book2 = book1;

            Console.WriteLine("book2.Name: " + book2.Name);

            book2.Name = "Around The World in 80 Days";

            Console.WriteLine("book1.Name: " + book1.Name);
            Console.WriteLine("book2.Name: " + book2.Name);

            Book book3 = (Book)book1.Clone();
            // Book book3 = (Book)book1.Copy(); // or

            book3.Name = "Journey to the Center of the Earth";

            Console.WriteLine("book1.Name: " + book1.Name);
            Console.WriteLine("book2.Name: " + book2.Name);
            Console.WriteLine("book3.Name: " + book3.Name);

            Console.ReadLine();
        }
    }
}
