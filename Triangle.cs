using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace RadiusCalculations
{
    internal class Triangle
    {
        private double SideA { get; set; }
        private double SideB { get; set; }
        private double SideC { get; set; }


        public Triangle()
        {
            // Empty, I want to practice using methods instead.
        }


        public void SetSides(double sideA, double sideB, double sideC)
        {
            SideA = sideA;
            SideB = sideB;
            SideC = sideC;
        }

        public bool IsTriangle()
        {
            bool isTriangle = false;

            // Check if all sides are longer than 0.
            if (SideA > 0 && SideB > 0 && SideC > 0)
            {
                // Check if any two sides added together are bigger than the last side.
                if ((SideA + SideB > SideC) && (SideA + SideC > SideB) && (SideB + SideC > SideA))
                {
                    isTriangle = true;
                }
            }
            return isTriangle;
        }

        public double GetPerimeter()
        {
            return (SideA + SideB + SideC);
        }

        public double GetArea()
        {
            // Heron's formula, here we go...
            double semiPerimeter = (SideA + SideB + SideC) / 2;
            double subtractedSideA = semiPerimeter - SideA;
            double subtractedSideB = semiPerimeter - SideB;
            double subtractedSideC = semiPerimeter - SideC;
            double multipliedTerms = semiPerimeter * subtractedSideA * subtractedSideB * subtractedSideC;
            double area = Math.Sqrt(multipliedTerms);
            return area;
        }

        public string GetAngles()
        {
            // Law of cosines, step by step...
            double squaredSideA = SideA * SideA;
            double squaredSideB = SideB * SideB;
            double squaredSideC = SideC * SideC;

            double cosineAngleX = (squaredSideA + squaredSideB - squaredSideC) / (SideA * SideB * 2);
            double angleXInRadians = Math.Acos(cosineAngleX);
            double angleXInDegrees = angleXInRadians * (180 / Math.PI);

            double cosineAngleY = (squaredSideA + squaredSideB - squaredSideC) / (SideA * SideC * 2);
            double angleYInRadians = Math.Acos(cosineAngleY);
            double angleYInDegrees = angleYInRadians * (180 / Math.PI);

            double angleZInDegrees = 180 - angleXInDegrees - angleYInDegrees;
            string angleResults = $"{angleXInDegrees}, {angleYInDegrees} and {angleZInDegrees}";
            return angleResults;
        }
    }
}
