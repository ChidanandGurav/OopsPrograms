using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopsPrograms.Array
{
    public class Accept5Name
    {
        static void Main(string[] args)
        {
            string[] Name = new string[5];

            for(int nam = 0; nam < Name.Length; nam++)
            {
                Console.WriteLine("Enter Name");
                Name[nam] = Console.ReadLine();
            }

            for(int nam = 0; nam < Name.Length; nam++)
            {
                Console.WriteLine($"{Name[nam]}");
            }
        }
    }
}
