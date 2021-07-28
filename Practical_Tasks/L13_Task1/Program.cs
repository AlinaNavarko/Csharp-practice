using System;

namespace L13_Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            UniqueItem uniqueItemAuto1 = new UniqueItem();
            Console.WriteLine(uniqueItemAuto1.ItemNumber);
            
            UniqueItem uniqueItemAuto2 = new UniqueItem();
            Console.WriteLine(uniqueItemAuto2.ItemNumber);
           
            UniqueItem uniqueItemCustom = new UniqueItem(5);
            Console.WriteLine(uniqueItemCustom.ItemNumber);
           
            UniqueItem uniqueItemAuto3 = new UniqueItem();
            Console.WriteLine(uniqueItemAuto3.ItemNumber);
        }
    }
}
