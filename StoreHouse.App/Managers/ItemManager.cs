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
            //_actionService = actionService;
            _itemService = new ItemService();
        }
        public List<Item> Items { get; set; }
        int itemId = 0;
        //public ItemService()
        //{
        //    Items = new List<Item>();
        //}



        public ConsoleKeyInfo AddNewItemView(MenuActionService _actionService)
        //public int AddNewItem(char itemType)


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
            //public int AddNewItem(char itemType)

            // dodane linijki

            // var operatio=Console.ReadKey();
            return operation;
        }
        public int AddNewItem(char itemType)
        { 
        //int typeId;
        //Int32.TryParse(operation.KeyChar.ToString(), out typeId);
            Console.WriteLine("Please insert name of item");
            var name = Console.ReadLine();
        //public int AddNewItem(char itemType)
        //{
        Console.WriteLine();
                int itemTypeId;
        Int32.TryParse(itemType.ToString(), out itemTypeId);
                Item item = new Item();
        item.Id = itemId++;
                item.TypeId = itemTypeId;
                Console.WriteLine();
                Console.WriteLine("Please enter serial number for new item:");
                var sn = Console.ReadLine();
        int itemSn;
        Int32.TryParse(sn, out itemSn);
                //Console.WriteLine("Please enter name for new item:");
                //var name = Console.ReadLine();
                Console.WriteLine("Please enter price for new item:");
                var price = Console.ReadLine();
        int priceId;
        Int32.TryParse(price, out priceId);
                item.Id = itemId;
                item.Sn = itemSn;
                item.Name = name;
                item.Price = priceId;
               // Items.Add(item);
               // return itemSn;
                var lastId = _itemService.GetLastId();

        //brak instancji obiektu

        //  Item item=new Item(lastId+1, name, typeId);
        _itemService.AddItem(item);
           return item.Id;
        } 
    }
}
