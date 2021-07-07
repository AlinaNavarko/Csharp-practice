using System;

namespace L8_Task2
{
    class User
    {
        readonly Guid _id = Guid.NewGuid();
        string _login;
        string _password;
        string _firstName;
        string _lastName;
        int _rides;
        int _year;

        public Guid Id { get { return _id; } }

        bool isValidLogin = false;
        public string Login
        {
            get { return _login; }
            set
            {
                while (!isValidLogin)
                {
                    if (value.Length > 5 && value.Contains("@"))
                    {
                        isValidLogin = true;
                        _login = value;
                    }

                    else
                    {
                        Console.Write("The Login should be your email.Try Once Again:");
                        value = Console.ReadLine();
                    }
                }
            }
        }

        bool isValid = false;
        public string Password
        {
            get { return _password; }
            set
            {
                while (!isValid)
                {
                    if (value.Length == 8)
                    {             
                        isValid = true;
                        _password = value;
                    }
                   
                    else
                    {
                        Console.Write("The length of password should be equal to 8 symbols.Try Once Again:");
                        value = Console.ReadLine();
                    }
                }
            }
        }

        bool isValidFirstName = false;
        public string FirstName
        {
            get { return _firstName; }
            set
            {
                while (!isValidFirstName)
                {
                    if (value.Length > 0)
                    {
                        isValidFirstName = true;
                        _firstName = value;
                    }
                    else
                    {
                        Console.Write("The First Name can't be empty.Try Once Again:");
                        value = Console.ReadLine();
                    }
                }
            }
        }

        bool isValidLastName = false;
        public string LastName
        {
            get { return _lastName; }
            set
            {
                while (!isValidLastName)
                {
                    if (value.Length > 0)
                    {
                        isValidLastName = true;
                        _lastName = value;
                    }
                    else
                    {
                        Console.Write("The First Name can't be empty.Try Once Again:");
                        value = Console.ReadLine();
                    }
                }
            }
        }

        public int Rides
        {
            get { return _rides; }
        }

        public int Year
        {
            get { return _year; }
            set
            {
                if (value > DateTime.Now.Year - 16)
                    Console.WriteLine("The age should be more than 16");
                else _year = value;
            }
        }

        private void ResetHistory() // метод
        {
        }

        public User() // Конструктор
        {
            _rides = 0;
        }
    }
}
