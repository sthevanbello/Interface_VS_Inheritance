using InterfaceVSInheritance.Model.Entities;
using InterfaceVSInheritance.Model.Enums;
using System;

namespace InterfaceVSInheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            IShape shape1 = new Rectangle() {Width = 3.5, Height = 4.2, Color = Color.Black };
            IShape shape2 = new Circle() { Radius = 2.0, Color = Color.White};


            Console.WriteLine($"Rectangle: \n{shape1}");
            Console.WriteLine($"\nCircle: \n{shape2}");




            Console.ReadKey();
        }
    }
}
