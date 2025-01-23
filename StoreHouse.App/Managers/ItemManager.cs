using StoreHouse.App.Concrete;
using StoreHouse.Domain.Entity;
using StoreHouse.App.Abstract;

namespace StoreHouse.App.Managers
{
    public class ItemManager
    {
        private readonly MenuActionService _actionService;
        private IService<Item> _itemService;
        public ItemManager(MenuActionService actionService, IService<Item> itemService)
        {
            _itemService = itemService;
            _actionService = actionService;
        }
        public int AddNewItem()
        {
            var addNewItemMenu = _actionService.GetMenuActionsByMenuName("AddNewItemMenu");
            Console.WriteLine("Please select item type:");
            for (int i = 0; i < addNewItemMenu.Count; i++)
            {
                Console.WriteLine($"{addNewItemMenu[i].Id}. {addNewItemMenu[i].Name}");
            }

            var operation = Console.ReadKey();
            int typeId;
            Int32.TryParse(operation.KeyChar.ToString(), out typeId);

            Console.WriteLine();
           
            Console.WriteLine("Please enter serial number for new item:");
            var sn = Console.ReadLine();
            int itemSn;
            if (!Int32.TryParse(sn, out itemSn))
            {
                Console.WriteLine("Invalid serial number. Defaulting to 0.");
                itemSn = 0;
            }

            Console.WriteLine("Please enter name for new item:");
            var nameProduct = Console.ReadLine();

            Console.WriteLine("Please enter price for new item:");
            var price = Console.ReadLine();
            if (!Int32.TryParse(price, out int priceId))
            {
                Console.WriteLine("Invalid price. Defaulting to 0.");
                priceId = 0;
            }
            var lastId = _itemService.GetLastId();
            Item item = new Item(lastId + 1, typeId,itemSn,nameProduct,priceId);
            _itemService.AddItem(item);
            return item.Id;
        }

        public void RemoveItemById(int id)
        {
            var item = _itemService.GetItemById(id);
            _itemService.RemoveItem(item);
        }

        public Item GetItemById(int id)
        {
            var item = _itemService.GetItemById(id);
            return item;
        }
    }
}

