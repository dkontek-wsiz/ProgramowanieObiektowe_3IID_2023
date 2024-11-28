using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2.Models
{
    internal class Shape
    {

        public int Y { get; set; }
        public int X { get; set; }
        public int Height { get; set; }
        public int Width { get; set; }


        public virtual void Draw()
        {
            Console.WriteLine("Shape");
        }

    }
}
