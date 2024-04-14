using System.Collections.Generic;

namespace Ex04.Menus.Interfaces
{
    public class MenuItem
    {
        private List<ISelectionListener> m_SelectionListeners;
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

        public string Title
        {
            get
            {
                return r_Title;
            }
        }

        public List<ISelectionListener> SelectionListeners
        {
            get
            {
                return m_SelectionListeners;
            }
            set
            {
                m_SelectionListeners = value;
            }
        }

        public List<MenuItem> SubMenuItems
        {
            get
            {
                return r_SubMenuItems;
            }
        }

        public MenuItem(string i_Title)
        {
            r_Title = i_Title;
            r_SubMenuItems = new List<MenuItem>();
            m_SelectionListeners = new List<ISelectionListener>();
            m_IsLeaf = true;
        }

        public void AddSubMenuItem(MenuItem i_MenuItemToAdd)
        {
            SubMenuItems.Add(i_MenuItemToAdd);
            IsLeaf = false;
        }

        public void AddSelectionListener(ISelectionListener i_SelectionListener)
        {
            SelectionListeners.Add(i_SelectionListener);
        }

        internal void NotifyAllSelectedListeners()
        {
            foreach (ISelectionListener listener in SelectionListeners)
            {
                if (listener != null)
                {
                    listener.ReportSelection(this);
                }
            }
        }
    }
}