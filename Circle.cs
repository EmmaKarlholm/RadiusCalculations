using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RadiusCalculations
{
    internal class Circle
    {
        public double Radius { get; set; }


        public Circle(double radius)
        {
            Radius = radius;
        }
        public double GetCircumference()
        {
            return Radius * 2;
        }

        public double GetArea()
        {
            return Radius * Radius * Math.PI;
        }

        public double GetVolume()
        {
            return Radius * Radius * Radius;
        }

    }
}
