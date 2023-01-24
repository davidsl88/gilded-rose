using GildedRose.Application.Services;
using GildedRose.Console.Entities;

namespace GildedRose.Console
{
    public class Program
    {
        public IList<Item> Items = new List<Item>
                {
                    new Item
                    {
                        Name = "+5 Dexterity Vest",
                        SellIn = 10,
                        Quality = 20
                    },
                    new Item
                    {
                        Name = "Aged Brie",
                        SellIn = 2,
                        Quality = 0
                    },
                    new Item
                    {
                        Name = "Elixir of the Mongoose",
                        SellIn = 5,
                        Quality = 7
                    }
                };

        public static void Main(string[] args)
        {
            System.Console.WriteLine("OMGHAI!");

            var app = new Program();

            ItemService.UpdateQuality(app.Items);

            System.Console.ReadKey();
        }
    }
}
