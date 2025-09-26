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
        public double SideA { get; set; }
        public double SideB { get; set; }
        public double SideC { get; set; }

        
        public Triangle(double sideA, double sideB, double sideC)
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

        public double GetAngles()
        {
            // Law of cosines, step by step...
            double squaredSideA = SideA * SideA;
            double squaredSideB = SideB * SideB;
            double squaredSideC = SideC * SideC;

            double alphaCosineAngleX = (squaredSideA + squaredSideB - squaredSideC);
            //double betaCosineAngleX = 
            return 0; // TEMPORARY
        }

    }


}
