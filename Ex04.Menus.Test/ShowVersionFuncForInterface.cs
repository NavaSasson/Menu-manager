using Ex04.Menus.Interfaces;
using System;

namespace Ex04.Menus.Test
{
    internal class ShowVersionFuncForInterface : ISelectionListener
    {
        public void ReportSelection(MenuItem i_SelectedMenuItem)
        {
            showVersion();
        }

        private void showVersion()
        {
            Console.WriteLine("Version: 24.1.4.9633");
        }
    }
}