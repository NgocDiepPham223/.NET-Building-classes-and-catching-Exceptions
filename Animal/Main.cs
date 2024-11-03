using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lab01_Exception.Bai_1;


namespace Lab01_Exception.Bai_1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Dog> dogs = new List<Dog>();
            List<Cat> cats = new List<Cat>();

            Console.WriteLine("Enter Dog information:");
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine($"\n {i + 1}. Dog:");
                Dog dog = new Dog();
                dog.InputInfo();
                dogs.Add(dog);
            }

            Console.WriteLine("\nEnter Cat information:");
            for (int i = 0; i < 2; i++)
            {
                Console.WriteLine($"\n {i + 1}. Cat:");
                Cat cat = new Cat();
                cat.InputInfo();
                cats.Add(cat);
            }

            Console.WriteLine("\nDog information:");
            foreach (var dog in dogs)
            {
                dog.DisplayInfo();
            }

            Console.WriteLine("\nCat information:");
            foreach (var cat in cats)
            {
                cat.DisplayInfo();
            }
        }
    }
}
