using System;
using System.IO;

namespace ConsoleApp9
{
    class Motorcycle
    {
        public Guid VinNumber { get; set; }
        public string Model => Model;
        public DateTime[] Trips { get; set; }
        int _tripsCounter = default;

        bool _isUpdateAvailable = true;

        public Motorcycle()
        {
          if (_isUpdateAvailable)
            DownloadNewSoftware();

            VinNumber = Guid.Parse("f79564a4-5047-4799-8ea7-0bae9");
        }

        protected internal void Drive()
        {
            ++_tripsCounter;
            Trips[_tripsCounter] = DateTime.Now;
            Console.WriteLine("Let's Drive!");
        }

        internal void DownloadNewSoftware()
        {
            var getPackage = File.OpenRead("~/update.zip");
            _isUpdateAvailable = false;
        }

        public override string ToString()
        {
            return Model ?? throw new NullReferenceException();
        }
    }
}
