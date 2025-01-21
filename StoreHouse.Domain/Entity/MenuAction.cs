using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using StoreHouse.Domain.Common;

namespace StoreHouse.Domain.Entity
{
    public class MenuAction: BaseEntity
    {
      
        public string? Name { get; set; }
        public string MenuName { get; set; }

        public MenuAction(int ida, string name, string menuName)
        {
            Id = ida;
            Name = name;
            MenuName = menuName;
        }
    }
  
   
}
