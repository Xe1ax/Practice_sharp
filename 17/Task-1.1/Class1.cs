using Microsoft.Analytics.Interfaces;
using Microsoft.Analytics.Interfaces.Streaming;
using Microsoft.Analytics.Types.Sql;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace Task_1._1
{
    public class Triangle
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

        public bool CheckExistence()
        {
            return (SideA + SideB > SideC) && (SideB + SideC > SideA) && (SideC + SideA > SideB);
        }

        public double CalculatePerimeter()
        {
            return SideA + SideB + SideC;
        }

        public double CalculateArea()
        {
            double s = CalculatePerimeter() / 2;
            return Math.Sqrt(s * (s - SideA) * (s - SideB) * (s - SideC));
        }

        public string DetermineTriangleType()
        {
            if (SideA == SideB && SideB == SideC)
                return "Равносторонний";
            else if (SideA == SideB || SideB == SideC || SideC == SideA)
                return "Равнобедренный";
            else
                return "Разносторонний";
        }
    }
    public class Rectangle
    {
        public double Length { get; set; }
        public double Width { get; set; }

        public Rectangle(double length, double width)
        {
            Length = length;
            Width = width;
        }

        public double CalculatePerimeter()
        {
            return 2 * (Length + Width);
        }

        public double CalculateArea()
        {
            return Length * Width;
        }
    }
}