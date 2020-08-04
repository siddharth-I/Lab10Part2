using System;

namespace Circle
{
    class Program
    {
        public double Radius { get; set; }
        public double Circumference { get; set; }

        public double Area { get; set; }

        public Circle(double radius)
        {
            Radius = radius;
        }
        public double CalculateCircumference()
        {
            double Circumference = 2 * Math.PI * Radius;
        }

        public double CalculateFormattedCircumference()
        {
            Math.Round(Circumference, 2);
        }

        public double CalculateArea()
        {
            double Area = Math.PI * (Radius * Radius);
        }

        public double CalculateFormattedArea()
        {
            Math.Round(Area, 2);
        }

        public double FormatNumber(double x)
        {
            //???
        }
    }
}
