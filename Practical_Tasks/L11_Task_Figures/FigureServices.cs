using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L11_Task_Figures
{
    public class FigureServices
    {
        public void Start()
        {
            var figures = GetArrayFigure();
            foreach (var figure in figures)
            {
                Console.WriteLine(figure.ToString());
            }
        }

        private IFigureArea[] GetArrayFigure()
        {
            Random random = new Random();
            IFigureArea[] array = new IFigureArea[]
            {
                new Triangle(random.Next(1,10), random.Next(1,10)),
                new Circle(random.Next(1,10)),
                new Square(random.Next(1,10)),
                new Triangle(random.Next(1,10), random.Next(1,10)),
                new Circle(random.Next(1,10))
            };
            return array;
        }
    }
}
