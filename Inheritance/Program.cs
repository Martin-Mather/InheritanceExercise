using System;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            // TODO Be sure to follow best practice when creating your classes

            // Create a class Animal -Done
            // give this class 4 members that all Animals have in common


            // Create a class Bird -done
            // give this class 4 members that are specific to Bird - done
            // Set this class to inherit from your Animal Class

            // Create a class Reptile-Done
            // give this class 4 members that are specific to Reptile
            // Set this class to inherit from your Animal Class




            /*Create an object of your Bird class -Done
             *  give values to your members using the object of your Bird class
             *  
             * Creatively display the class member values 
             */
            Bird zapados = new Bird()
            {
                Name = "Zapados",
                Age = 1000,
                Legs = 2,
                HasBackbone = true,
                HasFeathers = true,
                Wings = 2,
                Type = "electric",

            };
            Console.WriteLine($"{zapados.Name} is an {zapados.Type} pokemon that is {zapados.Age} years old and has"+
                $"{zapados.Legs} legs and {zapados.Wings} wings" );
            Console.WriteLine($"Is {zapados.Name} a vertebrate, warm blooded and has feathers?"+
                $"{zapados.HasBackbone}, {zapados.IsWarmBlooded}, and {zapados.HasFeathers}");
            //Bird penguin = new Bird(15, 2, true, true, true, true, true);
            /*Create an object of your Reptile class
             *  give values to your members using the object of your Bird class
             *  
             * Creatively display the class member values 
             */
            Reptile dragon = new Reptile()
            {
                Name = "Smaug",
                Age = 1200,
                Legs = 4,
                HasBackbone = true,
                IsColdBlooded = true,
                HasScales = true,
                Environment = "Erabor",
                Defense = "Breathes Fire"

            };
            Console.WriteLine($"{dragon.Name} is a {dragon.Age} year old dragon that lives under {dragon.Environment}" +
                $"he has {dragon.Legs} legs and {dragon.Defense}.");
            Console.WriteLine($"Is {dragon.Name} a vertebrate, cold blooded and has scales?" +
                $"{dragon.HasBackbone}, {dragon.IsColdBlooded}, and {dragon.HasScales}");
            Console.WriteLine();
        }
    }
}
