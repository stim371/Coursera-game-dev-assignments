using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assignment1
{
    /// <summary>
    /// Gathers game data and shows it to the user.
    /// </summary>
    class Program
    {
        /// <summary>
        /// Gathering and printing game data
        /// </summary>
        /// <param name="args">command-line arguments</param>
        static void Main(string[] args)
        {
            // Welcome the user
            Console.WriteLine("Welcome, adventurer! Tell me your secrets, and I will judge ye.");

            GenerateNewLine();

            // Ask for gold stats
            Console.Write("How much gold have you gathered? ");
            int gold = int.Parse(Console.ReadLine());

            // Ask for time stats
            Console.Write("How long have you been playing? (in hours) ");
            float hours = float.Parse(Console.ReadLine());

            // Convert hours to minutes
            float mins = HoursToMinutes(hours);

            // Calculate gold per minute
            float gpm = GoldPerMinute(gold, mins);

            GenerateNewLine();

            // Output the calculations to the user
            Console.WriteLine("Your game statistics:");
            Console.WriteLine("Total Gold: " + gold + " gold");
            Console.WriteLine("Hours Played: " + hours + " hours");
            Console.WriteLine("Gold Per Minute: " + gpm + " gold per minute");

            GenerateNewLine();
        }

        /// <summary>
        /// Generate a new line so the UI has extra space
        /// </summary>
        private static void GenerateNewLine()
        {
            Console.WriteLine();
        }

        /// <summary>
        /// Converts hours to minutes
        /// </summary>
        /// <param name="hours">Hours of play</param>
        /// <returns>Minutes of play</returns>
        private static float HoursToMinutes(float hours)
        {
            return hours * 60;
        }

        /// <summary>
        /// Calculates the amount of gold a player earns each minute of play
        /// </summary>
        /// <param name="gold">Total gold gathered during the game</param>
        /// <param name="mins">Number of minutes played in the game</param>
        /// <returns>Ratio of gold to minutes for the session</returns>
        private static float GoldPerMinute(int gold, float mins)
        {
            return gold / mins;
        }
    }
}
