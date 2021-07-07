using System;

namespace L8_Task2
{
    class Motorcycle
    {
        readonly Guid _motoId = Guid.NewGuid();
        string _producer;
        string _model;
        int _modelYear;
        int _odometer;

        // Public properties:
        public Guid MotoId { get { return _motoId; } }
        public string Model
        {
            get { return _model; }
            set
            {
                if (String.IsNullOrEmpty(value))
                {
                    Console.WriteLine("The Model can't be empty. 'Unknown' will be set. ");
                    _model = "Unknown";
                }
                else _model = value;
            }
        }
        public string Producer
        {
            get { return _producer; }
            set
            {
                if (String.IsNullOrEmpty(value))
                {
                    Console.WriteLine("The Producer can't be empty. 'Unknown' will be set. ");
                    _producer = "Unknown";
                }
                else _producer = value;
            }
        }
        public int ModelYear
        {
            get { return _modelYear; }
            set
            {
                if (value < 1900)
                {
                    Console.WriteLine("The year is incorrect. The current Year will be set.");
                    _modelYear = DateTime.Now.Year;
                }

                else _modelYear = value;
            }
        }
        public int Odometer
        {
            get { return _odometer; }
            set
            {
                if (value < 0)
                {
                    Console.WriteLine("The odometer can't be less than 0");
                    _odometer = 0;
                }
                else _odometer = value;
            }
        }
    }
}
