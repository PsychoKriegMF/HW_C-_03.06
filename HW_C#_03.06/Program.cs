namespace HW_C__03._06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var inventory = new StoreInventory();
            var random = new Random();
            for(int i = 0; i < 20; i++)
            {
                var item = new StoreItem(i,(decimal)random.NextDouble() * 100);
                inventory.AddItem(item);
            }
            //Тут срабатывает исключение
            //StoreItem doubleItem = new StoreItem(10,13.9m);
            //inventory.AddItem(doubleItem);
            
            //поиск товара по id
            var findID = inventory.FindItem(10);
            Console.WriteLine($"Информация о найденом товаре: id: {findID.ItemId}, price: {Math.Round(findID.Price),2}");
            Console.WriteLine();

            //поиск товаров с прайсом выше 50
            var findPrice = inventory.GetAllItems().Where(i => i.Price > 50);
            foreach(var item in findPrice)
            {
                Console.WriteLine($"ID: {item.ItemId}, Price: {Math.Round(item.Price,2)}");
            }
            //изменение цены
            var updatePrice = inventory.FindItem(3);
            updatePrice.Price = 99.99m;
            // отчет
            Console.WriteLine();
            Console.WriteLine("Товары по ценовым диапазонам.");
            var report = inventory.GetAllItems()
                .GroupBy(i => (int)(i.Price / 10)*10)
                .Select(g => new { price = $"{g.Key} - {g.Key + 9}", Count = g.Count() });

            foreach(var item in report)
            {
                Console.WriteLine($"{item.price} : {item.Count} items");
            }


        }
    }
}
