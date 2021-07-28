using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L13_Task1
{
    class UniqueItem
    {
        private static int _count = 0;

        public int ItemNumber { get; private set; }

        public UniqueItem()
        {
            _count++;
            ItemNumber = _count;   
        }

        public UniqueItem(int itemNumber)
        {
            _count = itemNumber;
            ItemNumber = _count;
        }
    }
}
