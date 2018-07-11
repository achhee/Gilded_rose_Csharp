using NUnit.Framework;
using System.Collections.Generic;

namespace csharp
{
    [TestFixture]
    public class GildedRoseTest
    {
        //[Test]
        //public void foo()
        //{
        //    IList<Item> Items = new List<Item> { new Item { Name = "foo", SellIn = 0, Quality = 0 } };
        //    GildedRose app = new GildedRose(Items);
        //    app.UpdateQuality();
        //    Assert.AreEqual("fixme", Items[0].Name);
        //}


        // Asim

        [Test]
        public void UpdateQuality_QualityisZero_QulaityShouldNotLessThanZero()
        {
            IList<Item> Items = new List<Item> { new Item { Name = "Any Item", SellIn = 1, Quality = 0 } };
            GildedRose app = new GildedRose(Items);
            app.UpdateQuality();
            Assert.GreaterOrEqual(0, Items[0].Quality);

        }

        [Test]
        public void UpdateQuality_SellDatePassed_QualityDecreasesTwice()
        {
            IList<Item> Items = new List<Item> { new Item { Name = "Any Item", SellIn = 0, Quality = 10 } };
            GildedRose app = new GildedRose(Items);
            app.UpdateQuality();
            Assert.AreEqual(8, Items[0].Quality);
        }

        [Test]
        public void UpdateQuality_ForAgedBrie_QualityIncrease()
        {
            IList<Item> Items = new List<Item> { new Item { Name = "Aged Brie", SellIn = 1, Quality = 2 } };
            GildedRose app = new GildedRose(Items);
            app.UpdateQuality();
            Assert.AreEqual(3, Items[0].Quality, "Quallity for Aged Brie not increasing");

        }

        [Test]
        public void UpdateQuality_ItemQuality_NeverMoreThanFifty()
        {
            IList<Item> Items = new List<Item> { new Item { Name = "Aged Brie", SellIn = 1, Quality = 50 } };
            GildedRose app = new GildedRose(Items);
            app.UpdateQuality();
            Assert.AreEqual(50, Items[0].Quality, "Quallity for Aged Brie increased from 50");
        }

        [Test]
        public void UpdateQuality_Sulfuras_NeverSoldNorQualityChanged()
        {
            IList<Item> Items = new List<Item> { new Item { Name = "Sulfuras, Hand of Ragnaros", SellIn = 5, Quality = 80 } };
            GildedRose app = new GildedRose(Items);
            app.UpdateQuality();
            Assert.AreEqual(80, Items[0].Quality, "Quallity ");
            Assert.AreEqual(5, Items[0].SellIn, "SellIn");
        }

        [Test]
        public void UpdateQuality_BackstagePassesWithSellInMoreThan10_IncreasesQualityBy1()
        {

            IList<Item> Items = new List<Item> { new Item { Name = "Backstage passes to a TAFKAL80ETC concert", SellIn = 11, Quality = 25 } };
            GildedRose app = new GildedRose(Items);
            app.UpdateQuality();
            Assert.AreEqual(26, Items[0].Quality, "Quallity");
        }

        [Test]
        public void UpdateQuality_BackstagePassesWithSellInLessThan10AndMoreThan5_IncreasesQualityByTwo()
        {
            IList<Item> Items = new List<Item> { new Item { Name = "Backstage passes to a TAFKAL80ETC concert", SellIn = 10, Quality = 25 } };
            GildedRose app = new GildedRose(Items);
            app.UpdateQuality();
            Assert.AreEqual(27, Items[0].Quality, "Quallity");
        }

        [Test]
        public void UpdateQuality_BackstagePassesWithSellInLessThanOrEqualTo5_IncreasesQualityByThree()
        {
            IList<Item> Items = new List<Item> { new Item { Name = "Backstage passes to a TAFKAL80ETC concert", SellIn = 5, Quality = 25 } };
            GildedRose app = new GildedRose(Items);
            app.UpdateQuality();
            Assert.AreEqual(28, Items[0].Quality, "Quallity");
        }

        [Test]
        public void UpdateQuality_BackstagePassesWithSellInZero_QualityBecomesZero()
        {
            IList<Item> Items = new List<Item> { new Item { Name = "Backstage passes to a TAFKAL80ETC concert", SellIn = 0, Quality = 25 } };
            GildedRose app = new GildedRose(Items);
            app.UpdateQuality();
            Assert.AreEqual(0, Items[0].Quality, "Quallity");
        }

        [Test]
        public void UpdateQuality_ConjuredWithQualityEquals0_QualityShouldRemain0()
        {
            IList<Item> Items = new List<Item> { new Item { Name = "Conjured", SellIn = 1, Quality = 1 } };
            GildedRose app = new GildedRose(Items);
            app.UpdateQuality();
            Assert.AreEqual(0, Items[0].Quality, "Quallity");
        }
    }
}
