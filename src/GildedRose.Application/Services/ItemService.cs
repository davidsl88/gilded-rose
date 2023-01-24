using GildedRose.Console.Entities;

namespace GildedRose.Application.Services
{
    public class ItemService
    {
        private static readonly string AgedBrie = "Aged Brie";

        private static readonly decimal PriceQualityFactor = 1.9M;

        private static readonly int MaxQuality = 50;

        private static readonly int MinQuality = 0;

        private static readonly int MinSellIn = 0;

        public static void UpdateQuality(IList<Item> items)
        {
            foreach (var item in items)
            {
                if (item.Name != AgedBrie)
                {
                    DecreaseQuality(item);
                }
                else
                {
                    IncreaseQuality(item);
                }

                item.SellIn--;

                if (item.SellIn < MinSellIn)
                {
                    if (item.Name != AgedBrie)
                    {
                        DecreaseQuality(item);
                    }
                    else
                    {
                        IncreaseQuality(item);
                    }
                }

                item.Price = Math.Round(item.Quality * PriceQualityFactor, 2);
            }
        }

        private static void IncreaseQuality(Item item)
        {
            if (item.Quality < MaxQuality)
            {
                item.Quality++;
            }
        }

        private static void DecreaseQuality(Item item)
        {
            if (item.Quality > MinQuality)
            {
                item.Quality--;
            }
        }
    }
}