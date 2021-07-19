using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L11_Task_Figures
{
    class Circle: IFigureArea, IFigurePrint
    {
        public int Radius { get; set; }
        public Circle(int radius) => Radius = radius;

        public double Area() => 3.14 * (Radius ^ 2);
        public override string ToString() => $"This is {this.GetType().Name}. CLR Type in {this.GetType()}. Square is {Area()}";
    }
}
