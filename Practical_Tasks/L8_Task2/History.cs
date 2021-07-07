using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L8_Task2
{
    class History
    {
        public Guid HistoryId { get; private set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
        public int Distance { get; set; }
        public int cost { get; set; }
        // Мотоцикл (Производитель и Модель)
    }
}
