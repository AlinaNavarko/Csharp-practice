using System;

namespace L8_Tasks
{
    class Program
    {
        static void Main()
        {
            Greeting greeting = new Greeting();
            greeting.Main();
        }
    }
    public class Greeting
    {
        public void Main()
        {
            int morningStart = 9;
            int dayStart = 12;
            int eveningStart = 15;
            int nightStart = 22;

            Console.WriteLine(value: DateTime.Now.TimeOfDay);
            int hour = DateTime.Now.Hour;

           switch (hour)
            {
                case int x when (hour >= morningStart && hour < dayStart):
                    Console.WriteLine("Good morning, guys!");
                    break;

                case int x when (hour >= dayStart && hour < eveningStart):
                    Console.WriteLine("Good day, guys!");
                    break;

                case int x when (hour >= eveningStart && hour < nightStart):
                    Console.WriteLine("Good evening, guys!");
                    break;

                default:
                    Console.WriteLine("Good night!");
                    break;
            }
        }
    }
}
