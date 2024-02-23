using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SquareCalcLib
{
    public class Circle : Figure
    {
        int radius;

        public Circle() { }
        public Circle(int radius)
        {
            if (radius > 0) this.radius = radius;
            else throw new Exception("Радиус должен быть больше 0");
        }

        public override double Square()
        {
            return CircleSquare(radius);
        }

        double CircleSquare(int r)
        {
            
            return double.Round(Math.Pow(r, 2) * Math.PI,2);
        }

    }
}
