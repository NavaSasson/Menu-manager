using System;
using System.Globalization;
using System.Linq;

namespace Ex04.Menus.Test
{
    internal class LeafFunctionsForDelegates
    {
        internal void ShowDate_WasSelected()
        {
            Console.WriteLine(DateTime.Now.ToString("dd/MM/yyyy", CultureInfo.InvariantCulture));
        }

        internal void ShowTime_WasSelected()
        {
            Console.WriteLine(DateTime.Now.ToString("HH:mm:ss"));
        }

        internal void CountCapitals_WasSelected()
        {
            Console.WriteLine("Please enter your sentence:");
            string userInputSentence = Console.ReadLine();
            int capitalCount = userInputSentence.Count(char.IsUpper);
            Console.WriteLine($"There are {capitalCount} capitals in your sentence");
        }

        internal void ShowVersion_WasSelected()
        {
            Console.WriteLine("Version: 24.1.4.9633");
        }
    }
}