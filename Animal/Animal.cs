using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lab01_Exception.Bai_1;

namespace Lab01_Exception.Bai_1
{
    public class Animal
    {
        public string Name { get; set; } = "Unknown";
        public int Age { get; set; }
        public double Height { get; set; }
        public double Weight { get; set; }

        public virtual void InputInfo()
        {
            Console.Write("Enter name: ");
            Name = Console.ReadLine() ?? "Unknown"; 

            while (true)
            {
                try
                {
                    Console.Write("Enter age: ");
                    string ageInput = Console.ReadLine() ?? "Unknown";
                    if (string.IsNullOrEmpty(ageInput))
                    {
                        Console.WriteLine("Age cannot be blank.");
                        continue;
                    }

                    Age = int.Parse(ageInput);
                    if (Age < 0 || Age > 20)
                    {
                        throw new Exception("Age must be between 0 and 20.");
                    }
                    break;
                }
                catch (FormatException)
                {
                    Console.WriteLine("Please enter an integer for age.");
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }

            while (true)
            {
                try
                {
                    Console.Write("Enter height (cm): ");
                    string heightInput = Console.ReadLine() ?? "Unknown";
                    if (string.IsNullOrEmpty(heightInput))
                    {
                        Console.WriteLine("Height cannot be empty.");
                        continue;
                    }

                    Height = double.Parse(heightInput);
                    break;
                }
                catch (FormatException)
                {
                    Console.WriteLine("Please enter a number for height.");
                }
            }

            while (true)
            {
                try
                {
                    Console.Write("Enter weight (kg): ");
                    string weightInput = Console.ReadLine() ?? "Unknown";
                    if (string.IsNullOrEmpty(weightInput))
                    {
                        Console.WriteLine("Weight cannot be empty.");
                        continue;
                    }

                    Weight = double.Parse(weightInput);
                    break;
                }
                catch (FormatException)
                {
                    Console.WriteLine("Please enter a number for weight.");
                }
            }
        }

        public virtual void DisplayInfo()
        {
            Console.WriteLine($"Name: {Name}, Age: {Age}, Height: {Height} cm, Weight: {Weight} kg");
        }
    }
}
