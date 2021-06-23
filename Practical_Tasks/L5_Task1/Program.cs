using System;

namespace L5_Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Task1: An array can't be empty. Anyway it will be filled out with default values of the corresponding type"); //TASK 1
            MethodTask2();
            MethodTask3();
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

        private static void MethodTask3()
        {
            int value;
            int number;
            int arraySize = 13;

            Random arrayRnd = new Random();
            int[] arrayNum = new int[arraySize];
            Console.WriteLine("Task3: Random array:");

            for (int i = 0; i < arrayNum.Length; i++)
            {
                arrayNum[i] = arrayRnd.Next(100);
                Console.Write(arrayNum[i] + " " + "| ");
            }
            
            number = 0;
            value = arrayNum[number];

            for (int i = 1; i < arrayNum.Length; i++)
            {
                if (arrayNum[i] > value)
                {
                    value = arrayNum[i];
                    number = i;
                }
            }
            Console.WriteLine("The largest Value is: " + value);
        }

        /*
        private static void MethodTask4()
        {
            short shortValue = 100;
            object obj = shortValue */
        }
}
