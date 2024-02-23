using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SquareCalcLib
{
    public class Triangle : Figure
    {
        double sizeA, sizeB, sizeC;

        bool isRight = false;
        bool isTriangle;

        public Triangle() { }

        public Triangle( double _sizeA, double _sizeB, double _sizeC)
        {
            if (IsTriangle(_sizeA, _sizeB, _sizeC) == false)
            {
                throw new Exception("такой треугольник не может существовать");

            }
            if (_sizeA != 0.0 && _sizeB != 0.0 && _sizeC != 0.0)
            {
               
                sizeA = _sizeA;
                sizeB = _sizeB;
                sizeC = _sizeC;
                
            }
            else
            {
                throw new Exception("Сторона не должна быть 0");
            }
            
        }

        public override double Square()
        {
            return TriangleSquare(sizeA,sizeB,sizeC);
        }

        double TriangleSquare(double a, double b, double c)
        {
            double p = (a + b + c) / 2;

            double S = Math.Sqrt(p * (p - a) * (p - b) * ( p - c));

            return double.Round(S,2);
        }

        public bool IsRight()
        {
            if (Math.Pow(sizeA, 2) == Math.Pow(sizeB, 2) + Math.Pow(sizeC,2) ||
                Math.Pow(sizeB,2) == Math.Pow(sizeA,2) + Math.Pow(sizeC,2) ||
                Math.Pow(sizeC,2) == Math.Pow(sizeA,2) + Math.Pow(sizeB,2))
                isRight = true;
            return isRight;
        }

        public bool IsTriangle(double sizeA, double sizeB, double sizeC)
        {
            if (sizeA + sizeB < sizeC ||
                sizeB + sizeC < sizeA ||
                sizeC + sizeA < sizeB)
            {
                isTriangle = false;
            }
            else isTriangle = true;
            return isTriangle;
        }

    }
}
