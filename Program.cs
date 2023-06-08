using System;

namespace Draw
{
    class Circle
    {
        public double Radius { get; set; }
        public string Color { get; set; }

        public Circle(double radius, string color)
        {
            Radius = radius;
            Color = color;
        }

        public override string ToString()
        {
            return $"Circle - Radius: {Radius}, Color: {Color}";
        }
    }

    class Cylinder : Circle
    {
        public double Height { get; set; }

        public Cylinder(double radius, string color, double height) : base(radius, color)
        {
            Height = height;
        }

        public double GetVolume()
        {
            return Math.PI * Radius * Radius * Height;
        }

        public override string ToString()
        {
            return $"Cylinder - Radius: {Radius}, Color: {Color}, Height: {Height}, Volume: {GetVolume()}";
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Circle circle = new Circle(5.0, "Red");
            Cylinder cylinder = new Cylinder(3.0, "Blue", 8.0);

            Console.WriteLine(circle.ToString());
            Console.WriteLine(cylinder.ToString());
        }
    }
}
