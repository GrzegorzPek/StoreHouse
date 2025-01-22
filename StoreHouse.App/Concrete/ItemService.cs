using StoreHouse.App.Common;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StoreHouse.Domain.Entity;
using StoreHouse;


namespace StoreHouse.App.Concrete
{

    public class ItemService : BaseService<Item>
    {
        public List<Item> Items { get; set; }
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
            Console.WriteLine("Please enter name for new item:");
            var name = Console.ReadLine();
            Console.WriteLine("Please enter price for new item:");
            var price = Console.ReadLine();
            int priceId;
            Int32.TryParse(price, out priceId);
            item.Id = itemId;
            item.Sn = itemSn;
            item.Name = name;
            item.Price = priceId;
            Items.Add(item);
            return itemSn;
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


            //List<Item> toShow = new List<Item>();
            //foreach (var item in Items)
            //{
            //    if (item.TypeId == typeId)
            //    {
            //        toShow.Add(item);
            //    }
            //}
            //Console.WriteLine(toShow);
            //Console.WriteLine(toShow.ToStringTable(new[] { "Id", "TypeId", "Serial Number", "Name", "Price" }, a => a.Id, a => a.TypeId, a => a.Sn, a => a.Name, a => a.Price));
        }
        public void ItemsAllView()
        {

            foreach (var item in Items)
            {
                Console.WriteLine(item.ToString());
            }
            //List<Item> toShow = new List<Item>();
            //foreach (var item in Items)
            //{
            //    toShow.Add(item);
            //}
            //Console.WriteLine(toShow);
            // Console.WriteLine(toShow.ToStringTable(new[] { "Id", "TypeId", "Serial Number", "Name", "Price" }, a => a.Id, a => a.TypeId, a => a.Sn, a => a.Name, a => a.Price));
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
//using StoreHouse.App.Common;
//using System;
//using System.Collections.Generic;
//using System.Data;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using StoreHouse.Domain.Entity;
//using StoreHouse;

//namespace StoreHouse.App.Concrete
//{
//    public class ItemService : BaseService<Item>
//    {
//        public List<Item> Items { get; set; }
//        private int itemId = 0; // **Dodano modyfikator `private` dla zmiennej itemId**

//        public ItemService()
//        {
//            Items = new List<Item>();
//        }

//        public ConsoleKeyInfo AddNewItemView(MenuActionService actionService)
//        {
//            var addNewItemMenu = actionService.GetMenuActionsByMenuName("AddNewItemMenu");
//            Console.WriteLine("\nPlease select items assortment to Add, TypeId: 1-3 ");
//            for (int i = 0; i < addNewItemMenu.Count; i++)
//            {
//                Console.WriteLine($"{addNewItemMenu[i].Id}. {addNewItemMenu[i].Name}");
//            }
//            var operation = Console.ReadKey();
//            return operation;
//        }

//        public int AddNewItem(char itemType)
//        {
//            Console.WriteLine();
//            if (!int.TryParse(itemType.ToString(), out int itemTypeId)) // **Zmieniono sposób parsowania na bardziej czytelny**
//            {
//                Console.WriteLine("Invalid TypeId.");
//                return -1;
//            }

//            Item item = new Item
//            {
//                Id = ++itemId, // **Poprawiono logikę przypisania Id**
//                TypeId = itemTypeId
//            };

//            Console.WriteLine("\nPlease enter serial number for new item:");
//            if (!int.TryParse(Console.ReadLine(), out int itemSn))
//            {
//                Console.WriteLine("Invalid serial number.");
//                return -1;
//            }
//            item.Sn = itemSn;

//            Console.WriteLine("Please enter name for new item:");
//            item.Name = Console.ReadLine();

//            Console.WriteLine("Please enter price for new item:");
//            if (!int.TryParse(Console.ReadLine(), out int priceId))
//            {
//                Console.WriteLine("Invalid price.");
//                return -1;
//            }
//            item.Price = priceId;

//            Items.Add(item);
//            return item.Sn; // **Zmieniono na zwracanie Sn zamiast priceId**
//        }

//        public int RemoveItemView()
//        {
//            Console.WriteLine("Please enter the serial number of the item you want to remove:");
//            if (int.TryParse(Console.ReadLine(), out int sn))
//            {
//                return sn;
//            }
//            else
//            {
//                Console.WriteLine("Invalid serial number.");
//                return -1;
//            }
//        }

//        public void RemoveItem(int removeSn)
//        {
//            var productToRemove = Items.FirstOrDefault(item => item.Sn == removeSn); // **Zmieniono na bardziej wydajną metodę LINQ**
//            if (productToRemove != null)
//            {
//                Items.Remove(productToRemove);
//                Console.WriteLine("Item removed successfully.");
//            }
//            else
//            {
//                Console.WriteLine("Item not found.");
//            }
//        }

//        public void ItemsByTypeIdView(int typeId)
//        {
//            var toShow = Items.Where(item => item.TypeId == typeId).ToList(); // **Zmieniono pętlę na LINQ**

//            if (!toShow.Any())
//            {
//                Console.WriteLine("No items found for the specified TypeId.");
//                return;
//            }

//            Console.WriteLine("Items:");
//            Console.WriteLine(toShow.ToStringTable(
//                new[] { "Id", "TypeId", "Serial Number", "Name", "Price" },
//                a => a.Id, a => a.TypeId, a => a.Sn, a => a.Name, a => a.Price));
//        }

//        public void ItemsAllView()
//        {
//            if (!Items.Any())
//            {
//                Console.WriteLine("No items available.");
//                return;
//            }

//            Console.WriteLine("All Items:");
//            Console.WriteLine(Items.ToStringTable(
//                new[] { "Id", "TypeId", "Serial Number", "Name", "Price" },
//                a => a.Id, a => a.TypeId, a => a.Sn, a => a.Name, a => a.Price)); // **Odkomentowano ToStringTable**
//        }

//        public int ItemTypeSelectionView()
//        {
//            Console.WriteLine("Please enter number of assortments: 1 - AGD, 2 - RTV, 3 - Laptops:");
//            if (int.TryParse(Console.ReadLine(), out int sn))
//            {
//                return sn;
//            }
//            else
//            {
//                Console.WriteLine("Invalid input.");
//                return -1;
//            }
//        }

//        public void ItemDetailViewbySn(int detailSn)
//        {
//            var productToShow = Items.FirstOrDefault(item => item.Sn == detailSn); // **Zmieniono na LINQ**
//            if (productToShow != null)
//            {
//                DisplayItemDetails(productToShow);
//            }
//            else
//            {
//                Console.WriteLine("Item not found.");
//            }
//        }

//        public void ItemDetailViewbyId(int detailId)
//        {
//            var productToShow = Items.FirstOrDefault(item => item.Id == detailId); // **Zmieniono na LINQ**
//            if (productToShow != null)
//            {
//                DisplayItemDetails(productToShow);
//            }
//            else
//            {
//                Console.WriteLine("Item not found.");
//            }
//        }

//        private void DisplayItemDetails(Item productToShow) // **Dodano wspólną metodę wyświetlania szczegółów**
//        {
//            Console.WriteLine($"Item ID: {productToShow.Id}");
//            Console.WriteLine($"Item Serial Number: {productToShow.Sn}");
//            Console.WriteLine($"Item Name: {productToShow.Name}");
//            Console.WriteLine($"Item Price: {productToShow.Price}");
//            Console.WriteLine($"Item TypeId: {productToShow.TypeId}");
//        }

//        public int ItemDetailSelectionViewbySn()
//        {
//            Console.WriteLine("Please enter the serial number of the item for details:");
//            if (int.TryParse(Console.ReadLine(), out int sn))
//            {
//                return sn;
//            }
//            else
//            {
//                Console.WriteLine("Invalid input.");
//                return -1;
//            }
//        }

//        public int ItemDetailSelectionViewbyId()
//        {
//            Console.WriteLine("Please enter the ID of the item for details:");
//            if (int.TryParse(Console.ReadLine(), out int id))
//            {
//                return id;
//            }
//            else
//            {
//                Console.WriteLine("Invalid input.");
//                return -1;
//            }
//        }
//    }
//}