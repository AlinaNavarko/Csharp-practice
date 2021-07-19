using System;

namespace L11_Task_Figures
{
    class Program
    {
        static void Main(string[] args)
        {
            FigureServices service = new FigureServices();
            service.Start();

            Console.ReadLine();
        }
    }
}
