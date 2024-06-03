using System;

namespace Octopus
{
    public class Octopus
    {
        public readonly int Legs;
        public readonly int Eyes;
        
        public string Species;
        public string Location;
        public string Name;

        // Constructor to initialize read-only fields
        public Octopus()
        {
            Legs = 8;
            Eyes = 2;
        }
    }
    public class Program
    {
        static void Main(string[] args)
        {
            Octopus octopus1 = new Octopus();

            //The user will enter the Octopus's name and where they live
            Console.Write("Enter the octopus's name: ");
            octopus1.Name = Console.ReadLine();
            Console.Write("What ocean do they live in? ");
            octopus1.Location = Console.ReadLine();
            Console.WriteLine("What species is the octopus?");
            octopus1.Species = Console.ReadLine();
            // Output using string interpolation
            Console.WriteLine($"{octopus1.Name} the octopus has {octopus1.Eyes} eyes and {octopus1.Legs} legs.");
            Console.WriteLine($"{octopus1.Name} belongs to the {octopus1.Species} family.");
            Console.WriteLine($"{octopus1.Name} the octopus can be found in the {octopus1.Location} ocean.");
        }
    }
}
