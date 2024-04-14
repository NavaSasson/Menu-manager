using System;
using System.Collections.Generic;
using System.Linq;

namespace Ex04.Menus.Interfaces
{
    internal class InterfaceUI
    {
        internal int GetValidItemChoice(MenuItem i_MenuItem, List<MenuItem> i_MenuItemsList)
        {
            string userChoiceStr = Console.ReadLine();
            bool isChoiceInteger = int.TryParse(userChoiceStr, out int value);

            while (!isChoiceInteger)
            {
                Console.WriteLine("Invalid choice. Please try again.");
                userChoiceStr = Console.ReadLine();
                isChoiceInteger = int.TryParse(userChoiceStr, out value);
            }

            int userChoiceInteger = int.Parse(userChoiceStr);
            bool isChoiceInOptions = isChoiceInMenuOptions(i_MenuItem, userChoiceInteger, i_MenuItemsList);
            if (!isChoiceInOptions)
            {
                Console.WriteLine("Invalid choice. Please try again.");
                userChoiceInteger = GetValidItemChoice(i_MenuItem, i_MenuItemsList);
            }

            return userChoiceInteger;
        }

        private bool isChoiceInMenuOptions(MenuItem i_MenuItem, int i_Choice, List<MenuItem> i_MenuItemsList)
        {
            List<MenuItem> menuItemList = GetMenuItemsList(i_MenuItem, i_MenuItemsList);

            return i_Choice >= 0 && i_Choice <= menuItemList.Count;
        }

        internal void PrintTitle(MenuItem i_MenuItem)
        {
            string menuTitle = i_MenuItem == null ? "**Interface Main Menu**" : $"**{i_MenuItem.Title}**";

            Console.WriteLine(string.Format(
@"{0}
-------------------------", menuTitle));
        }

        internal void PrintMenuOptions(MenuItem i_MenuItem, List<MenuItem> i_MenuItemsList)
        {
            string backOrExitStr = i_MenuItem == null ? "Exit" : "Back";
            List<MenuItem> menuItemList = GetMenuItemsList(i_MenuItem, i_MenuItemsList);

            foreach ((MenuItem menuItem, int idx) in menuItemList.Select((item, index) => (item, index + 1)))
            {
                Console.WriteLine($"{idx} -> {menuItem.Title}");
            }

            Console.WriteLine(string.Format(
@"0 -> {0}
-------------------------
Enter your request (1 to {1} '0' to go {2}):", backOrExitStr, menuItemList.Count, backOrExitStr));
        }

        internal List<MenuItem> GetMenuItemsList(MenuItem i_MenuItem, List<MenuItem> i_MenuItemsList)
        {
            return i_MenuItem == null ? i_MenuItemsList : i_MenuItem.SubMenuItems;
        }
    }
}