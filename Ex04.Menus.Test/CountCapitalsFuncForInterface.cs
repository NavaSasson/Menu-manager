using Ex04.Menus.Interfaces;
using System;
using System.Linq;

namespace Ex04.Menus.Test
{
    internal class CountCapitalsFuncForInterface : ISelectionListener
    {
        public void ReportSelection(MenuItem i_SelectedMenuItem)
        {
            countCapitals();
        }

        private void countCapitals()
        {
            Console.WriteLine("Please enter your sentence:");
            string userInputSentence = Console.ReadLine();
            int capitalCount = userInputSentence.Count(char.IsUpper);
            Console.WriteLine($"There are {capitalCount} capitals in your sentence");
        }
    }
}