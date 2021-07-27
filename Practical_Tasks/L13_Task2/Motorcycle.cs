using System;
using System.IO;

namespace ConsoleApp9
{
    class Motorcycle
    {
        public Guid VinNumber { get; set; }
        public string Model {get; set;}

        public DateTime[] Trips { get; set; }
        int _tripsCounter = default;

        bool _isUpdateAvailable = true;

        public Motorcycle()
        {
          if (_isUpdateAvailable)
            DownloadNewSoftware();
            try
            {
                VinNumber = Guid.Parse("f79564a4-5047-4799-8ea7-0bae9");
            }
            catch (FormatException exF)
            {
                Console.WriteLine(exF.Message);
            }
        }

        protected internal void Drive()
        {
            ++_tripsCounter;
            try
            { Trips[_tripsCounter] = DateTime.Now; }
            catch (IndexOutOfRangeException exI)
            {
                Console.WriteLine(exI.Message);
            }
            Console.WriteLine("Let's Drive!");
        }

        internal void DownloadNewSoftware()
        {
            try
            {
                var getPackage = File.OpenRead("~/update.zip");
                _isUpdateAvailable = false;
            }
            catch (DirectoryNotFoundException exD)
            {
                Console.WriteLine(exD.Message);
            }
        }

        public override string ToString()
        {
            try
            { return Model; }
            catch (NullReferenceException exN)
            { Console.WriteLine(exN.Message);
                return default;
            }
        }
    }
}