using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab01_Exception.Bai_2
{
    public class Sport
    {
        public int NumberOfPlayers { get; set; }
        public int Duration { get; set; } 
        public string BallType { get; set; } = "Unknown";

        public virtual void InputInfo()
        {
            while (true)
            {
                try
                {
                    Console.Write("How many player?: ");
                    NumberOfPlayers = int.Parse(Console.ReadLine() ?? "Unknown");
                    if (NumberOfPlayers <= 0)
                    {
                        throw new Exception("Number of players must be greater than 0.");
                    }
                    break;
                }
                catch (FormatException)
                {
                    Console.WriteLine("Enter an integer for the number of players.");
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
                    Console.Write("Enter play time (minutes): ");
                    Duration = int.Parse(Console.ReadLine() ?? "Unknown");
                    if (Duration <= 0)
                    {
                        throw new Exception("Playtime must be greater than 0.");
                    }
                    break;
                }
                catch (FormatException)
                {
                    Console.WriteLine("Enter an integer for play time.");
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }

            Console.Write("Enter ball type: ");
            BallType = Console.ReadLine() ?? "Unknown";
        }

        public virtual void DisplayInfo()
        {
            Console.WriteLine($"Number of Players: {NumberOfPlayers}, Playing Time: {Duration} minutes, Ball Type: {BallType}");
        }
    }
}

