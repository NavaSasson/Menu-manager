using Ex04.Menus.Interfaces;
using System;
using System.Globalization;

namespace Ex04.Menus.Test
{
    internal class ShowDateFuncForInterface : ISelectionListener
    {
        public void ReportSelection(MenuItem i_SelectedMenuItem)
        {
            showDate();
        }

        private void showDate()
        {
            Console.WriteLine(DateTime.Now.ToString("dd/MM/yyyy", CultureInfo.InvariantCulture));
        }
    }
}