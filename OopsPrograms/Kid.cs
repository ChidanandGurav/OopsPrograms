using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopsPrograms
{
    public class Inhe
    {
        static void Main(string[] args)
        {
            Kid k = new Bigkid();
            k.readbook();
            k.readbook("Ram", "Sham");
            
        }
    }
    public class Kid
    {
        public virtual void readbook()
        {
            Console.WriteLine("Kids are Read The book");
        }
        public void readbook(string a , string b)
        {
            Console.WriteLine($" {a} & {b} are read the books.");
        }

    }
    public class Bigkid : Kid
    {
        public override void readbook()
        {
            Console.WriteLine("Kids are Read The book");
        }
    }
}
