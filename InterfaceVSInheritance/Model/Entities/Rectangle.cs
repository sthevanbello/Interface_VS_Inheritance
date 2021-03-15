using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceVSInheritance.Model.Entities
{
    class Rectangle : AbstractShape
    {
        public double Height { get; set; }
        public double Width { get; set; }

        //public Rectangle(double height, double width)
        //{
        //    Height = height;
        //    Width = width;
        //}

        public override double Area()
        {
            return Height * Width;
        }

        public override string ToString()
        {
            return $"Color: {Color}\nHeight: {Height.ToString("F2")}\nWidth: {Width.ToString("F2")}\nArea: {Area().ToString("F2", CultureInfo.InvariantCulture)}";
        }
    }
}
