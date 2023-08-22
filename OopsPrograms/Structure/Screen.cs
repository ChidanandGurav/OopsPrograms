using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopsPrograms.Structure
{
    public struct Screen
    {
        private int X;
        private int Y;

        public Screen(int X, int Y)
        {
            this.X = X;
            this.Y = Y;
        }

        public string Print()
        {
            return $" X = {X}, Y = {Y}";
        }
    }

    public class Scr
    {
        static void Main(string[] args)
        {
            Screen s1 = new Screen(10, 20);
            Console.WriteLine(s1.Print());
        }
    }
}
