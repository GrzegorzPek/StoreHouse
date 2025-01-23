using StoreHouse.App.Common;
using System.Data;
using StoreHouse.Domain.Entity;

namespace StoreHouse.App.Concrete
{

    public class ItemService : BaseService<Item>
    {
        int itemId = 0;
        public ItemService()
        {
            Items = new List<Item>();
        }

        public ConsoleKeyInfo AddNewItemView(MenuActionService actionService)
        {
            var addNewItemMenu = actionService.GetMenuActionsByMenuName("AddNewItemMenu");
            Console.WriteLine("\nPlease select items assortment to Add, TypeId: 1-3 ");
            for (int i = 0; i < addNewItemMenu.Count; i++)
            {
                Console.WriteLine($"{addNewItemMenu[i].Id}. {addNewItemMenu[i].Name}");
            }
            var operation = Console.ReadKey();
            
            return operation;
        }
      
        public int AddNewItem(char itemType)
        {
            Console.WriteLine();
            if (!Int32.TryParse(itemType.ToString(), out int itemTypeId))
            {
                Console.WriteLine("Invalid item type. Defaulting to TypeId = 0.");
                itemTypeId = 0;
            }

            Console.WriteLine("Please enter serial number for new item:");
            var sn = Console.ReadLine();
            if (!Int32.TryParse(sn, out int itemSn))
            {
                Console.WriteLine("Invalid serial number. Defaulting to 0.");
                itemSn = 0;
            }

            Console.WriteLine("Please enter name for new item:");
            var name = Console.ReadLine();

            Console.WriteLine("Please enter price for new item:");
            var price = Console.ReadLine();
            if (!Int32.TryParse(price, out int priceId))
            {
                Console.WriteLine("Invalid price. Defaulting to 0.");
                priceId = 0;
            }

            var item = new Item()
            {
                Id = itemId,
                TypeId = itemTypeId,
                Sn = itemSn,
                Name = name ?? "Unknown",
                Price = priceId
            };
            itemId++;
            Items.Add(item);
            Console.WriteLine("Item added successfully!");
            return item.Sn;
        }
        public int RemoveItemView()
        {
            Console.WriteLine("Please enter type serial number for item you want to remove:");
            var itemId = Console.ReadLine();
            int sn;
            Int32.TryParse(itemId.ToString(), out sn);
            return sn;
        }
        public void RemoveItem(int removeSn)
        {
            Item productToRemove = new Item();
            foreach (var item in Items)
            {
                if (item.Sn == removeSn)
                {
                    productToRemove = item;
                    break;
                }
            }
            Items.Remove(productToRemove);
        }
        public void ItemsByTypeIdView(int typeId)
        {

            var toShow = Items.Where(item => item.TypeId == typeId).ToList();

            foreach (var item in toShow)
            {
                Console.WriteLine(item.ToString());
            }
        }
        public void ItemsAllView()
        {

            foreach (var item in Items)
            {
                Console.WriteLine(item.ToString());
            }
        }

        public int ItemTypeSelectionView()
        {
            Console.WriteLine("Please enter number of asortments: /1 - AGD , /2 - RTV , /3 - Laptops to show details items:");
            var itemId = Console.ReadLine();
            int sn;
            Int32.TryParse(itemId.ToString(), out sn);

            return sn;
        }
        public void ItemDetailViewbySn(int detailSn)
        {
            Item productToShow = new Item();
            foreach (var item in Items)
            {
                if (item.Sn == detailSn)
                {
                    productToShow = item;
                    break;
                }
            }
            if (productToShow == null)
            {
                Console.WriteLine("Item not found.");
                return;
            }
            Console.WriteLine($"Item ID: {productToShow.Id}");
            Console.WriteLine($"Item Serial Number: {productToShow.Sn}");
            Console.WriteLine($"Item Name: {productToShow.Name}");
            Console.WriteLine($"Item Price: {productToShow.Price}");
            Console.WriteLine($"Item TypeId 1-3: {productToShow.TypeId}");
        }

        public void ItemDetailViewbyId(int detailId)
        {
            Item productToShow = new Item();
            foreach (var item in Items)
            {
                if (item.Id == detailId)
                {
                    productToShow = item;
                    break;
                }
                if (productToShow == null)
                {
                    Console.WriteLine("Item not found.");
                    return;
                }
                Console.WriteLine($"Item ID: {productToShow.Id}");
            }
            Console.WriteLine($"Item ID: {productToShow.Id}");
            Console.WriteLine($"Item Serial Number: {productToShow.Sn}");
            Console.WriteLine($"Item Name: {productToShow.Name}");
            Console.WriteLine($"Item Price: {productToShow.Price}");
            Console.WriteLine($"Item TypeId 1-3: {productToShow.TypeId}");
        }
        public int ItemDetailSelecionViewbySn()
        {
            Console.WriteLine("Please enter serial number item for item details you want to show:");
            var itemSn = Console.ReadLine();
            int sn;
            Int32.TryParse(itemSn.ToString(), out sn);
            return sn;
        }
        public int ItemDetailSelecionViewbyId()
        {
            Console.WriteLine("Please enter serial number item for item details you want to show:");
            var itemId = Console.ReadLine();
            int id;
            Int32.TryParse(itemId.ToString(), out id);
            return id;
        }
        public int ItemDetailSelecionViewbyIgd()
        {
            Console.WriteLine("Please enter serial number item for item details you want to show:");
            var itemId = Console.ReadLine();
            int id;
            Int32.TryParse(itemId.ToString(), out id);
            return id;
        }
    }
}
