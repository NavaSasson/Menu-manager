using Ex04.Menus.Delegates;

namespace Ex04.Menus.Test
{
    internal class DelegateMenuTest
    {
        private readonly MainMenu r_DelegatesMenuTest;

        public MainMenu DelegatesMenuTest
        {
            get
            {
                return r_DelegatesMenuTest;
            }
        }

        public DelegateMenuTest() 
        {
            r_DelegatesMenuTest = new MainMenu();
        }

        private void initilizeDelegateMenu()
        {
            MenuItem showDateOrTimeMenuItem = new MenuItem("Show Date/Time");
            MenuItem verAndCapitalMenuItem = new MenuItem("Version and Capitals");
            MenuItem showDateMenuItem = new MenuItem("Show Date");
            MenuItem showTimeMenuItem = new MenuItem("Show Time");
            MenuItem countCapitalsMenuItem = new MenuItem("Count Capitals");
            MenuItem showVersionMenuItem = new MenuItem("Show Version");
            LeafFunctionsForDelegates leafFunForDelegates = new LeafFunctionsForDelegates();

            DelegatesMenuTest.AddMenuItem(showDateOrTimeMenuItem);
            DelegatesMenuTest.AddMenuItem(verAndCapitalMenuItem);
            showDateOrTimeMenuItem.AddSubMenuItem(showDateMenuItem);
            showDateOrTimeMenuItem.AddSubMenuItem(showTimeMenuItem);
            verAndCapitalMenuItem.AddSubMenuItem(countCapitalsMenuItem);
            verAndCapitalMenuItem.AddSubMenuItem(showVersionMenuItem);
            showDateMenuItem.WasSelected += leafFunForDelegates.ShowDate_WasSelected;
            showTimeMenuItem.WasSelected += leafFunForDelegates.ShowTime_WasSelected;
            countCapitalsMenuItem.WasSelected += leafFunForDelegates.CountCapitals_WasSelected;
            showVersionMenuItem.WasSelected += leafFunForDelegates.ShowVersion_WasSelected;
        }

        internal void Show()
        {
            initilizeDelegateMenu();
            DelegatesMenuTest.Show();
        }
    }
}