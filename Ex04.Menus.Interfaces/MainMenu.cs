using System;
using System.Collections.Generic;

namespace Ex04.Menus.Interfaces
{
    public class MainMenu
    {
        private readonly List<MenuItem> r_MenuItemsList;

        public MainMenu()
        {
            r_MenuItemsList = new List<MenuItem>();
        }

        public List<MenuItem> MenuItemsList
        {
            get
            {
                return r_MenuItemsList;
            }
        }

        public void AddMenuItem(MenuItem i_MenuItemToAdd)
        {
            MenuItemsList.Add(i_MenuItemToAdd);
        }

        public void Show()
        {
            MenuItem selectedSubMenuItem = null;
            InterfaceUI interfaceUI = new InterfaceUI();

            showMenu(selectedSubMenuItem, interfaceUI);
        }

        private void showMenu(MenuItem i_MenuItem, InterfaceUI i_InterfaceUI)
        {
            int userChoice = -1;

            while (userChoice != 0)
            {
                i_InterfaceUI.PrintTitle(i_MenuItem);
                i_InterfaceUI.PrintMenuOptions(i_MenuItem, MenuItemsList);
                userChoice = i_InterfaceUI.GetValidItemChoice(i_MenuItem, MenuItemsList);
                if (userChoice != 0)
                {
                    List<MenuItem> menuItemsList = i_InterfaceUI.GetMenuItemsList(i_MenuItem, MenuItemsList);
                    MenuItem selectedMenuItem = menuItemsList[userChoice - 1];
                    Console.Clear();
                    selectedMenuItem.NotifyAllSelectedListeners();
                    if (selectedMenuItem.IsLeaf)
                    {
                        Console.WriteLine("\n");
                    }
                    else
                    {
                        showMenu(selectedMenuItem, i_InterfaceUI);
                    }
                }
            }
        }
    }
}