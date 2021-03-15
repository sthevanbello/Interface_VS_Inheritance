using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceVSInheritance.Model.Entities
{
    class Circle : AbstractShape
    {
        public double Radius { get; set; }

        //public Circle(double radius)
        //{
        //    Radius = radius;
        //}

        public override double Area()
        {
            return Math.PI * Math.Pow(Radius, 2);
        }

        public override string ToString()
        {
            return $"Color: {Color}\nRadius: {Radius.ToString("F2", CultureInfo.InvariantCulture)}\nArea: {Area().ToString("F2", CultureInfo.InvariantCulture)}";
        }
    }
}
