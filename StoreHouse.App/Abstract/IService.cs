﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreHouse.App.Abstract
{
    public interface IService<T>
    {
        List<T> Items { get; set; }
       // List<T> ToStringTable {  get; set; }

        List<T> GetAllItems();
        int GetLastId();
        T GetItemById(int id);
        int AddItem(T item);
        int UpdateItem(T item);
        void RemoveItem(T item);
    }
}
