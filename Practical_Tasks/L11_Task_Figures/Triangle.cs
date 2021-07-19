using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L11_Task_Figures
{
    class Triangle : IFigureArea, IFigurePrint
    {
            public int Edge { get; set; }
            public int Height { get; set; }

            public Triangle(int edge, int height) => (Edge, Height) = (edge, height);
            public double Area() => (Edge * Height) / 2;

            public override string ToString() => $"This is {this.GetType().Name}. CLR Type in {this.GetType()}. Square is {Area()}";
    }
}
