using System;

namespace L8_Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            int arrayUserSize = 1;
            User[] user = new User[arrayUserSize];

            for (int i = 0; i < user.Length; i++)
            {
                //User Registration
                user[i] = new User();
                Console.Write("Login: ");
                user[i].Login = Console.ReadLine();
                Console.Write("Password: ");
                user[i].Password = Console.ReadLine();
                Console.Write("FirstName: ");
                user[i].FirstName = Console.ReadLine();
                Console.Write("LastName: ");
                user[i].LastName = Console.ReadLine();
                Console.Write("Year of Birth: ");
                user[i].Year = Int32.Parse(Console.ReadLine());
            }

            //Fill out info about motorcycles
            int arrayMotorcycleSize = 1;
            Motorcycle[] motorcycle = new Motorcycle[arrayMotorcycleSize];

            for (int i = 0; i < motorcycle.Length; i++)
            {
                motorcycle[i] = new Motorcycle();
                Console.Write("Producer: ");
                motorcycle[i].Producer = Console.ReadLine();
                Console.Write("Model: ");
                motorcycle[i].Model = Console.ReadLine();
                Console.Write("ModelYear: ");
                motorcycle[i].ModelYear = Int32.Parse(Console.ReadLine());
                Console.Write("Odometer: ");
                motorcycle[i].Odometer = Int32.Parse(Console.ReadLine());
            }

            //Show User Data
            for (int i = 0; i < user.Length; i++)
            {
                Console.WriteLine($"{user[i].Id},{user[i].Login},{user[i].Password},{user[i].FirstName},{user[i].LastName},{user[i].Year},{user[i].Rides} ");
            }
        }
    }
}

