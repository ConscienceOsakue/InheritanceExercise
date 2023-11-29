using System;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            // TODO Be sure to follow best practice when creating your classes

            // Done-Create a class Animal
            // Done-give this class 4 members that all Animals have in common


            // Done-Create a class Bird
            // Done-give this class 4 members that are specific to Bird
            // Done-Set this class to inherit from your Animal Class

            // Done-Create a class Reptile
            // Done-give this class 4 members that are specific to Reptile
            // Done-Set this class to inherit from your Animal Class




            /*Create an object of your Bird class
             *  give values to your members using the object of your Bird class
             *  
             * Creatively display the class member value
             */

            var myBird = new Bird();
            myBird.CanFly = true;
            myBird.DoMigrate = true;
            myBird.BeakLength = 6.8;
            myBird.WingColor = "White";

            /*Create an object of your Reptile class
             *  give values to your members using the object of your Reptile class
             *  
             * Creatively display the class member values 
             */
             //Using Object initialize method 

            var myReptile = new Reptile()
            {
                CanGrowTail = true,
                ColdBlooded = true,
                IsScaly = true,
                Habitat = "Sea"
            };

            var myAnimals = new Animal[] { myBird, myReptile };
            
            foreach(var animal in myAnimals)
            {
                Console.WriteLine($"Alive: {animal.IsAlive}");
                Console.WriteLine($"Age: {animal.Age}");
                Console.WriteLine($"It's Leg count is: {animal.LegCount}");
                Console.WriteLine($"The name is : {animal.Name}");
                Console.WriteLine("");
            }
            
        }
    }
}
