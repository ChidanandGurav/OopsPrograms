using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopsPrograms.Array
{
    public class Book
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Author { get; set; }

        public double Price { get; set; }
    }
    public class BK_Class1
    {
        static void Main(string[] args)
        {
            Book[] List = new Book[2]
            {
                new Book {Id = 1, Author = "Xyz", Name = "ABC" , Price = 50.2},
                new Book {Id = 2, Author = "Ptr", Name = "DEF" , Price = 200}
            };

            foreach(Book B in List)
            {
                Console.WriteLine($"{B.Id} {B.Name} {B.Author} {B.Price}");
            }
        }
    }
}
