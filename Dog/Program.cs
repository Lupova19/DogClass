using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dog
{
    public class Program
    {
        static void Main(string[] args)
        {
            List<Dog> dogs = new List<Dog>();
            Console.Write("Enter start(or another word) to continue: ");
            string input = Console.ReadLine();

            while (input != "stop")
            {
                Console.WriteLine("Enter breed:");
                string breed = Console.ReadLine();

                Console.WriteLine("Enter name:");
                string name = Console.ReadLine();

                Console.WriteLine("Enter age:");
                int age = int.Parse(Console.ReadLine());

                if (age > 30)
                {
                    Console.WriteLine("You have a mistake!");
                }

                Console.WriteLine("Enter owner:");
                string ownerName = Console.ReadLine();

                Dog dog = new Dog(breed, name, age, ownerName);
                dogs.Add(dog);

                Console.Write("Enter start(or other word) if you want to continue, otherwise enter stop: ");
                input = Console.ReadLine(); 
            }

            foreach (var dog in dogs)
            {
                Console.WriteLine(dog);
            }

        }
    }
}
