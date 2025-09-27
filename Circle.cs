using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RadiusCalculations
{
    internal class Circle
    {
        private double Radius { get; set; }


        public Circle()
        {
            // Empty, I want to practice using methods instead.
        }


        public void SetRadius(double radius)
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
            return (Radius * Radius * Radius) * Math.PI;
        }
    }
}
