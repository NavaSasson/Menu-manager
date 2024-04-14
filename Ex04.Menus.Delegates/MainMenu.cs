using System;
using System.Collections.Generic;

namespace Ex04.Menus.Delegates
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
            DelegateUI delegatesUI = new DelegateUI();

            showMenu(selectedSubMenuItem, delegatesUI);
        }

        private void showMenu(MenuItem i_MenuItem, DelegateUI i_DelegatesUI)
        {
            int userChoice = -1;

            while (userChoice != 0)
            {
                i_DelegatesUI.PrintTitle(i_MenuItem);
                i_DelegatesUI.PrintMenuOptions(i_MenuItem, MenuItemsList);
                userChoice = i_DelegatesUI.GetValidItemChoice(i_MenuItem, MenuItemsList);
                if (userChoice != 0)
                {
                    List<MenuItem> menuItemsList = i_DelegatesUI.GetMenuItemsList(i_MenuItem, MenuItemsList);
                    MenuItem selectedMenuItem = menuItemsList[userChoice - 1];
                    Console.Clear();
                    selectedMenuItem.DoWhenItemWasSelected();
                    if (selectedMenuItem.IsLeaf)
                    {
                        Console.WriteLine("\n");
                    }
                    else
                    {
                        showMenu(selectedMenuItem, i_DelegatesUI);
                    }
                }
            }
        }
    }
}