using Ex04.Menus.Interfaces;
using System;

namespace Ex04.Menus.Test
{
    internal class ShowTimeFuncForInterface : ISelectionListener
    {
        public void ReportSelection(MenuItem i_SelectedMenuItem)
        {
            showTime();
        }

        private void showTime()
        {
            Console.WriteLine(DateTime.Now.ToString("HH:mm:ss"));
        }
    }
}