using System;
using System.Collections.Generic;
using System.Text;

namespace RectangleProject.Models
{
    public class Rectangle
    {
        public double SideA, SideB;

        public Rectangle(double SideA, double SideB)
        {
            this.SideA = SideA;
            this.SideB = SideB;
        }
        public double Area
        {
            get
            {
                return Math.Round(SideA * SideB,2);
            }
        }
        public double Perimeter
        {
            get
            {
                return Math.Round((2 * (SideA + SideB)),2);
            }
        }
        public override string ToString()
        {
            return "A téglalap a oldala: "+SideA+" a B oldala: "+SideB+" kerülete: "+Perimeter+" területe: "+Area;
        }
    }
}
