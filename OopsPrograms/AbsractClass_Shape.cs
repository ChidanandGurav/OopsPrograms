using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopsPrograms
{
    public abstract class AbsractClass_Shape
    {
        public abstract string Draw(string Name);

        public abstract void Area();

    }

    public class Rectangular : AbsractClass_Shape
    {
        private double L, W;
        private double area;

        public Rectangular(double L, double W)
        {
            this.L = L;
            this.W = W;
        }

        public override void Area()
        {
            area = L * W;
        }

        public override string Draw(string Name)
        {
            return Name;
        }

        public string print()
        {
            return $"Area Of Ractangular is = {area}";
        }
    }

    public class Circle : AbsractClass_Shape
    {
        private double pi = 3.14;
        private int r;
        private double area;

        public Circle(double pi, int r, double area)
        {
            this.pi = pi;
            this.r = r;
            this.area = area;
        }

        public override void Area()
        {
            area = pi * r * r;
        }

        public override string Draw(string Name)
        {
            return Name;
        }

        public string print()
        {
            return $"Area Of Circle is = {area}";
        }
    }
}
