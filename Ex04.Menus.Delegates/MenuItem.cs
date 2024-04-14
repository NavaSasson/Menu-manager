using System;
using System.Collections.Generic;

namespace Ex04.Menus.Delegates
{
    public class MenuItem
    {
        public event Action WasSelected;
        private readonly string r_Title;
        private readonly List<MenuItem> r_SubMenuItems;
        private bool m_IsLeaf;

        public bool IsLeaf
        {
            get
            {
                return m_IsLeaf;
            }
            set
            {
                m_IsLeaf = value;
            }
        }

        public List<MenuItem> SubMenuItems
        {
            get
            {
                return r_SubMenuItems;
            }
        }

        public string Title
        {
            get
            {
                return r_Title;
            }
        }

        public MenuItem(string i_Title)
        {
            r_Title = i_Title;
            r_SubMenuItems = new List<MenuItem>();
            m_IsLeaf = true;
        }

        public void AddSubMenuItem(MenuItem i_MenuItemToAdd)
        {
            SubMenuItems.Add(i_MenuItemToAdd);
            IsLeaf = false;
        }

        internal void DoWhenItemWasSelected()
        {
            OnWasSelected();
        }

        protected virtual void OnWasSelected()
        {
            if (WasSelected != null)
            {
                WasSelected.Invoke();
            }
        }
    }
}