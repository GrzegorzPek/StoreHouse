﻿using StoreHouse.App.Common;
using StoreHouse.Domain.Entity;

namespace StoreHouse.App.Concrete
{
    public class MenuActionService:BaseService<MenuAction>
    {
        public MenuActionService() 
        {
        Initialize();
        }
        public List<MenuAction> GetMenuActionsByMenuName(string menuName)
        {
            List<MenuAction> result = new List<MenuAction>();
            foreach (var menuAction in Items) 
                // Items = menuAction
            {
                if (menuAction.MenuName == menuName)
                {
                    result.Add(menuAction);
                }
            }
            return result;
        }
        private void Initialize()
        {
            AddItem(new MenuAction(1, "Add item", "Main"));
            AddItem(new MenuAction(2, "Remove item by Serial Number", "Main"));
            AddItem(new MenuAction(3, "Show details by Serial Number", "Main") );
            AddItem(new MenuAction(4, "Show details by ID", "Main"));
            AddItem(new MenuAction(5, "Show list, to show all items by TypeId press /1-AGD, /2-RTV, /3-Electronics", "Main"));
            AddItem(new MenuAction(6, "Show all items", "Main"));

            AddItem(new MenuAction(1, "AGD", "AddNewItemMenu"));
            AddItem(new MenuAction(2, "RTV", "AddNewItemMenu"));
            AddItem(new MenuAction(3, "Electronics", "AddNewItemMenu"));
            
        }
    }
}

