using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment22
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Source source = new Source
            {
                Id = 21,
                Name = "Jyothi Sweashika",
                Age = 22,
                Occupation = "Software Developer"

            };

            Destination destination = new Destination();

            PropertyMapper.MapProperties(source, destination);

            Console.WriteLine("Mapped properties in the Destination class:");
            Console.WriteLine($"Id: {destination.Id}");
            Console.WriteLine($"Name: {destination.Name}");
            Console.WriteLine($"Occupation: {destination.Occupation}");
            Console.ReadKey();
        }

    }
}

