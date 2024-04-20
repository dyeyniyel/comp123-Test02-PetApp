using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Javier_COMP123_Test02
{
    public class Program
    {

        public struct AnimalAge
        {
            // Properties
            public int Day { get; }
            public int Month { get; }

            // Constructor
            public AnimalAge(int month, int day)
            {
                Month = month;
                Day = day;
            }

            // Methods
            public override string ToString()
            {
                return $"{Month}mos {Day}days";
            }
        }
        public enum AnimalGender
        {
            Male,
            Female,
            Hermaphrodite
        }

        public class Animal
        {
            // Properties
            public AnimalAge Age { get; }
            public AnimalGender Gender { get; }
            public string Species { get; }

            // Constructor
            public Animal(string species, AnimalAge age, AnimalGender gender)
            {
                Species = species;
                Age = age;
                Gender = gender;
            }
        }


        public class Pet : Animal
        {
            // Properties
            public string Name { get; }
            public double Weight { get; }

            // Constructor
            public Pet(string name, string species, AnimalAge age, double weight, AnimalGender gender = AnimalGender.Female)
                : base(species, age, gender)
            {
                Name = name;
                Weight = weight;
            }
            // Static method
            public static List<Pet> CreatePets()
            {
                List<Pet> pets = new List<Pet>();

                // Create and add specific Pet objects to the list
                pets.Add(new Pet("Bethoven", "Species", new AnimalAge(2, 4), 3.1, AnimalGender.Female));
                pets.Add(new Pet("Oscar", "Species", new AnimalAge(1, 0), 0.1, AnimalGender.Hermaphrodite));
                pets.Add(new Pet("Jake", "Species", new AnimalAge(10, 4), 8.1, AnimalGender.Male));
                pets.Add(new Pet("Sylvester", "Species", new AnimalAge(2, 4), 4.5, AnimalGender.Female));
                pets.Add(new Pet("Tweety", "Species", new AnimalAge(0, 0), 0.2, AnimalGender.Female));
                return pets;
            }

            // Instance method
            public override string ToString()
            {
                return $"{Name} {Age.ToString()} {Weight}kg {Gender}";
            }
        }

        static void Main(string[] args) {
            //Creating and printing a pet object - 2 marks 
            Console.WriteLine("Creating and printing a pet");
            //write the statement to instantiate the Pet class and display the resulting object

            // Instantiate the Pet class
            Pet pet1 = new Pet("Jake", "Dog", new AnimalAge(5, 3), 2.6, AnimalGender.Male);

            // Display the resulting object
            Console.WriteLine(pet1.ToString());


            Console.WriteLine("\n\nGetting a collection of pets");

            //write the statement to get a list of pets - 2 marks 
            //(By calling the CreatePets() method) and display the resulting collection 
            // Get a list of pets
            List<Pet> pets = Pet.CreatePets();

            // Display the resulting collection
            foreach (Pet pet in pets)
            {
                Console.WriteLine(pet.ToString());
            }

            double weight = 1.0;
            Console.WriteLine($"\n\nDisplaying all pets heavier than {weight}kg");
            //write the statement to filter out only the - 2 marks 
            //required pets from the previous collection 

            // Get a list of pets
            List<Pet> pets2 = Pet.CreatePets();

            // Filter the pets that are heavier than the specified weight
            var heavyPets = pets.Where(pet => pet.Weight > weight);

            // Display the resulting collection
            foreach (Pet pet in heavyPets)
            {
                Console.WriteLine(pet.ToString());
            }

            string filename = "pets.json";
            Console.WriteLine($"\n\nSerializing the pets to the file {filename}");
            //write the statement to save the current - 2 marks //collection to a file 
            // Serialize the list of pets to a JSON string
            string json = System.Text.Json.JsonSerializer.Serialize(pets);

            // Write the JSON string to a file
            System.IO.File.WriteAllText(filename, json);

            Console.ReadKey();
        }


    }


}


