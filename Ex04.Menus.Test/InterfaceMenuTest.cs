using Ex04.Menus.Interfaces;

namespace Ex04.Menus.Test
{
    internal class InterfaceMenuTest
    {
        private readonly MainMenu r_InterfacesMenuTest;

        public MainMenu InterfacesMainMenu
        {
            get
            {
                return r_InterfacesMenuTest;
            }
        }
        
        public InterfaceMenuTest()
        {
            r_InterfacesMenuTest = new MainMenu();
        }

        private void initilizeInterfaceMenu()
        {
            MenuItem showDateOrTimeMenuItem = new MenuItem("Show Date/Time");
            MenuItem verAndCapitalMenuItem = new MenuItem("Version and Capitals");
            MenuItem showDateMenuItem = new MenuItem("Show Date");
            MenuItem showTimeMenuItem = new MenuItem("Show Time");
            MenuItem countCapitalsMenuItem = new MenuItem("Count Capitals");
            MenuItem showVersionMenuItem = new MenuItem("Show Version");

            InterfacesMainMenu.AddMenuItem(showDateOrTimeMenuItem);
            InterfacesMainMenu.AddMenuItem(verAndCapitalMenuItem);
            showDateOrTimeMenuItem.AddSubMenuItem(showDateMenuItem);
            showDateOrTimeMenuItem.AddSubMenuItem(showTimeMenuItem);
            verAndCapitalMenuItem.AddSubMenuItem(countCapitalsMenuItem);
            verAndCapitalMenuItem.AddSubMenuItem(showVersionMenuItem);
            showDateMenuItem.AddSelectionListener(new ShowDateFuncForInterface());
            showTimeMenuItem.AddSelectionListener(new ShowTimeFuncForInterface());
            countCapitalsMenuItem.AddSelectionListener(new CountCapitalsFuncForInterface());
            showVersionMenuItem.AddSelectionListener(new ShowVersionFuncForInterface());
        }

        internal void Show()
        {
            initilizeInterfaceMenu();
            InterfacesMainMenu.Show();
        }
    }
}