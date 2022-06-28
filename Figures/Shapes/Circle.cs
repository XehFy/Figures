using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Figures.Shapes
{
    public class Circle : Shape
    {
        public double  Area;
        public double Radius;

        public Circle (double radius)
        {
            if (radius < 0)
            {
                throw new Exception("Невозможно создать данный круг");
            }
            else
            {
                Radius = radius;
            }
        }

        public override double GetArea()
        {
            Area = Math.PI * Math.Pow(Radius, 2);
            return Area;
        }

        public override double GetPerimeter()
        {
            return 2 * Math.PI * Radius;
        }
    }
}
