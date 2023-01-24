using GildedRose.Application.Services;
using GildedRose.Console.Entities;
using NUnit.Framework.Internal;

namespace GildedRose.Console.Test.Services
{
    [TestFixture]
    public class ItemServiceTests
    {
        // Without this empty constructor, the tests fail. Looks like it is a problem with NUnit
        // as it throws the following error: "OneTimeSetUp: No suitable constructor was found"
        public ItemServiceTests()
        {
        }

        [TestCase("Elixir of the Mongoose", 5, 7, 6)]
        [TestCase("Elixir of the Mongoose", 0, 7, 5)]
        [TestCase("+5 Dexterity Vest", 5, 0, 0)]
        [TestCase("+5 Dexterity Vest", 5, 50, 49)]
        [TestCase("Aged Brie", 5, 50, 50)]
        [TestCase("Aged Brie", 0, 50, 50)]
        [TestCase("Aged Brie", 0, 10, 12)]
        public void UpdateQuality_ShouldSucceed(string itemName,
                                                int sellIn,
                                                int quality,
                                                int expectedQuality)
        {
            var item = new Item
            {
                Name = itemName,
                SellIn = sellIn,
                Quality = quality
            };

            var items = new List<Item>
            {
                item
            };

            ItemService.UpdateQuality(items);

            Assert.Multiple(() =>
            {
                Assert.That(items.First(x => x.Name == item.Name).Quality, Is.EqualTo(expectedQuality));
            });
        }
    }
}