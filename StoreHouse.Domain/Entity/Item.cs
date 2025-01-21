using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StoreHouse.Domain.Common;


namespace StoreHouse.Domain.Entity
{
    public class Item:BaseEntity
    {

        public int Id { get; set; }
        public int TypeId { get; set; }
        public int Sn { get; set; }
        public string Name { get; set; }
        public int Price { get; set; }

        public Item(int id, string name, int typeId)
        {
          // Id = id;
            Name = name;
            TypeId = typeId;
        }
        public Item() 
        {
        }

    }

  
}