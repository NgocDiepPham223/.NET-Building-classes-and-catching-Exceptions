using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab01_Exception.Bai_2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Sport> sports = new List<Sport>();

            Console.WriteLine("Enter information for sports:");

            Console.WriteLine("\nEnter football information:");
            Football football = new Football();
            football.InputInfo();
            sports.Add(football);

            Console.WriteLine("\nEnter tennis information:");
            Tennis tennis = new Tennis();
            tennis.InputInfo();
            sports.Add(tennis);

            Console.WriteLine("\nEnter volleyball information:");
            Volleyball volleyball = new Volleyball();
            volleyball.InputInfo();
            sports.Add(volleyball);

            Console.WriteLine("\nSports information:");
            foreach (var sport in sports)
            {
                sport.DisplayInfo();
                Console.WriteLine();
            }
        }
    }
}

