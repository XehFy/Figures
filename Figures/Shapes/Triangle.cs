using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figures.Shapes
{
    public class Triangle : IShape
    {
        private double Area;
        public double sideA;
        public double sideB;
        public double sideC;

        public Triangle (double sideA, double sideB, double sideC)
        {
            if ((sideA + sideB > sideC) 
             && (sideA + sideC > sideB)
             && (sideC + sideB > sideA))
            {
                this.sideA = sideA;
                this.sideB = sideB;
                this.sideC = sideC;
            }
            else
            {
                throw new Exception("Невозможно создать данный треугольник");
            }
        }

        public double GetPerimeter()
        {
            return sideA + sideB + sideC;
        }

        public double GetArea()
        {
            double semiPerimeter = GetPerimeter() / 2;
            Area = Math.Sqrt(semiPerimeter * (semiPerimeter - sideA) * (semiPerimeter - sideB) * (semiPerimeter - sideC));
            return Area;
        }
        public bool IsRight()
        {
            if ((sideA * sideA == sideB * sideB + sideC * sideC) ||
                (sideB * sideB == sideA * sideA + sideC * sideC) ||
                (sideC * sideC == sideA * sideA + sideB * sideB))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
