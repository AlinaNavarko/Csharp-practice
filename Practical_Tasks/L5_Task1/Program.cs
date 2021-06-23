using System;

namespace L5_Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Task1: An array can't be empty. Anyway it will be filled out with default values of the corresponding type"); //TASK 1
            MethodTask2();
        }

        private static void MethodTask2()
        {
            Object[] arrayTypes = new object[3];
            arrayTypes[0] = 32;
            arrayTypes[1] = 'A';
            arrayTypes[2] = "Hello";

            Console.WriteLine("Task2: The initial array looks like:");

            for (int i = 0; i < arrayTypes.Length; i++)
            {
                Console.WriteLine(i + ": " + arrayTypes[i]);
            }

            arrayTypes[0] = (int)arrayTypes[0] + 10;
            arrayTypes[2] = "Hello, guys!";

            Console.WriteLine("The updated array looks like:");

            for (int i = 0; i < arrayTypes.Length; i++)
            {
                Console.WriteLine(i + ": " + arrayTypes[i]);
            }
        }
    }
}
