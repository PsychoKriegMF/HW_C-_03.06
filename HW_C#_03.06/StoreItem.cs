using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_C__03._06
{
    public class StoreItem : IStoreItem
    {
        public int ItemId { get; set; }
        public decimal Price { get; set; }
        public StoreItem(int itemId, decimal price)
        {
            ItemId = itemId;
            Price = price;
        }
    }
}
