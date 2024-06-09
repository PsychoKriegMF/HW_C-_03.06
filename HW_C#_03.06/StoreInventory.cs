using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_C__03._06
{
    public class StoreInventory
    {
        private Dictionary<int, StoreItem> Items;
        public StoreInventory()
        {
            Items = new Dictionary<int, StoreItem>();
        }
        public void AddItem(StoreItem item)
        {
            if(Items.ContainsKey(item.ItemId))
            {
                throw new ArgumentException($"Товар с id {item.ItemId} уже существует.");
            }
            Items[item.ItemId] = item;
        }
        public void RemoveItem(int id)
        {
            if(!Items.ContainsKey(id))
            {
                throw new ArgumentException($"Товар с id {id} не существует.");
            }
            Items.Remove(id);
        }
        public StoreItem FindItem(int id) 
        {
            if (!Items.ContainsKey(id))
            {
                throw new ArgumentException($"Товар с id {id} не существует.");
            }
            return Items[id];
        }
        public IEnumerable<StoreItem> GetAllItems()
        {
            return Items.Values;
        }
    }
}
