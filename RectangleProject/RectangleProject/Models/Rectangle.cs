using System;
using System.Collections.Generic;
using System.Text;

namespace RectangleProject.Models
{
    public class Rectangle
    {
        private double sideA, sideB;

        public Rectangle(double SideA, double SideB)
        {
            if (sideA <= 0)
                throw new RectangleSideIsNullOrZero(sideA + " oldalú négyzet nincs. A négyzetet nem jön létre.");
            if (sideB <= 0)
                throw new RectangleSideIsNullOrZero(sideB + " oldalú négyzet nincs. A négyzetet nem jön létre.");


            this.sideA = SideA;
            this.sideB = SideB;
        }



        public double SideA
        {
            get
            {
                return sideA;
            }
            set
            {
                if(SideA <= 0)
                    throw new RectangleSideIsNullOrZero(SideA + " oldalú négyzet nincs. A négyzetet nem jön létre.");
                else
                {
                    sideA = value;
                }
            }
        }
        public double SideB
        {
            get
            {
                return sideB;
            }
            set
            {
                if (SideB <= 0)
                    throw new RectangleSideIsNullOrZero(SideB + " oldalú négyzet nincs. A négyzetet nem jön létre.");
                else
                {
                    sideB = value;
                }
            }
        }
        public double Area
        {
            get
            {
                return Math.Round(sideA * sideB,2);
            }
        }
        public double Perimeter
        {
            get
            {
                return Math.Round((2 * (sideA + sideB)),2);
            }
        }
        public override string ToString()
        {
            return "A téglalap A oldala: "+sideA+" a B oldala: "+sideB+" kerülete: "+Perimeter+" területe: "+Area;
        }
    }
}
