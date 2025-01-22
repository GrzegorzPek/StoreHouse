using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StoreHouse.Domain.Common;


namespace StoreHouse.Domain.Entity
{
    public class Item : BaseEntity
    {

        public int Id { get; set; }
        public int TypeId { get; set; }
        public int Sn { get; set; }
        public string Name { get; set; }
        public int Price { get; set; }

        public Item()
        {
            //  // Id = id;   
            //    TypeId = typeId;
            //    Sn = sn;
            //    Name = name;
            //    Price = price;


        }


        public override string ToString()
        {
            return $"Id: {Id}, TypeId: {TypeId}, Sn: {Sn}, Name: {Name}, Price: {Price}";
        }
    }

    //public Item(int id, int typeId, int sn, string name, int price)
    //{
    //  // Id = id;   
    //    TypeId = typeId;
    //    Sn = sn;
    //    Name = name;
    //    Price = price;
    //}
   

}

  
