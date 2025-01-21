using StoreHouse.App.Concrete;
using StoreHouse.Domain.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StoreHouse.Domain.Common;


namespace StoreHouse.App.Managers
{
    public class ItemManager
    {
        private readonly MenuActionService _actionService;
        private ItemService _itemService;

        public ItemManager(MenuActionService actionService)
        {
            _actionService = actionService; // przekazywanie menu action service
            _actionService = actionService;
        }




        //public ConsoleKeyInfo AddNewItemView(MenuActionService actionService)
        public void AddNewItem()

           // public ConsoleKeyInfo AddNewItemView()
        {
            //var addNewItemMenu = actionService.GetMenuActionsByMenuName("AddNewItemMenu");
            var addNewItemMenu = _actionService.GetMenuActionsByMenuName("AddNewItemMenu"); // utworzone pole prywatne
            Console.WriteLine("\nPlease select items assortment to Add, TypeId: 1-3 ");
            for (int i = 0; i < addNewItemMenu.Count; i++)
            {
                Console.WriteLine($"{addNewItemMenu[i].Id}. {addNewItemMenu[i].Name}");
            }
            var operation = Console.ReadKey();


            // dodane linijki

            var operatio=Console.ReadKey();
            int typeId;
            Int32.TryParse(operation.KeyChar.ToString(), out typeId);
            Console.WriteLine("Please insert name of item");
            var name=Console.ReadLine();
            var lastId= _itemService.GetLastId();
            Item item=new Item(lastId+1, name, typeId);
          // return operation;
        }
    }
}
