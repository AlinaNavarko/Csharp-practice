using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

        public string Login { get; set; }

        public string Password
        {
           get { return _password; }
           set
            {
                if (value.Length != 8)
                    Console.WriteLine("The length of password should be equal 8 symbols");
                else _password = value;
            }
        }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int rides { get; set; }

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

        public User(string LastName, string FirstName) // Конструктор
        {
        }
    }
}
