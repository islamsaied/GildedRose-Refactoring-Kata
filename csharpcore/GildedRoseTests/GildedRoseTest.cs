using Xunit;
using System.Collections.Generic;
using GildedRoseKata;

namespace GildedRoseTests
{
    public class GildedRoseTest
    {
        [Fact]
        public void UpdateQuality()
        {
            IList<Item> Items = new List<Item>{
                new Item {Name = "+5 Dexterity Vest", SellIn = 10, Quality = 20},
                new Item {Name = "Aged Brie", SellIn = 2, Quality = 0},
                new Item {Name = "Elixir of the Mongoose", SellIn = 5, Quality = 7},
                new Item {Name = "Sulfuras, Hand of Ragnaros", SellIn = 0, Quality = 80},
                new Item {Name = "Sulfuras, Hand of Ragnaros", SellIn = -1, Quality = 80},
                new Item {Name = "Backstage passes to a TAFKAL80ETC concert", SellIn = 15, Quality = 20 },

                new Item {Name = "Backstage passes to a TAFKAL80ETC concert", SellIn = 10, Quality = 49 },
                new Item {Name = "Backstage passes to a TAFKAL80ETC concert", SellIn = 5, Quality = 49 },
                new Item {Name = "Conjured Mana Cake", SellIn = 3, Quality = 6},
                new Item {Name = "Backstage passes to a TAFKAL80ETC concert", SellIn = 10, Quality = 20 },
                new Item {Name = "Backstage passes to a TAFKAL80ETC concert", SellIn = 4, Quality = 20 },
                new Item {Name = "+5 Dexterity Vest", SellIn = 10, Quality = 1},
                new Item {Name = "+5 Dexterity Vest", SellIn = 10, Quality = 0},
                new Item {Name = "Backstage passes to a TAFKAL80ETC concert", SellIn = 0, Quality = 49 },
                new Item {Name = "Conjured Mana Cake", SellIn = 3, Quality = 0},



            };
            GildedRose app = new GildedRose(Items);
            app.UpdateQuality();
            Assert.Equal(19, Items[0].Quality);
            Assert.Equal(9, Items[0].SellIn);
            Assert.Equal(1, Items[1].Quality);
            Assert.Equal(1, Items[1].SellIn);
            Assert.Equal(6, Items[2].Quality);
            Assert.Equal(4, Items[2].SellIn);
            Assert.Equal(80, Items[3].Quality);
            Assert.Equal(0, Items[3].SellIn);
            Assert.Equal(21, Items[5].Quality);
            Assert.Equal(14, Items[5].SellIn);
            Assert.Equal(50, Items[6].Quality);
            Assert.Equal(9, Items[6].SellIn);
            Assert.Equal(50, Items[7].Quality);
            Assert.Equal(4, Items[7].SellIn);
            Assert.Equal(4, Items[8].Quality);
            Assert.Equal(2, Items[8].SellIn);
            Assert.Equal(22, Items[9].Quality);
            Assert.Equal(9, Items[9].SellIn);
            Assert.Equal(23, Items[10].Quality);
            Assert.Equal(3, Items[10].SellIn);
            Assert.Equal(0, Items[11].Quality);
            Assert.Equal(9, Items[11].SellIn);
            Assert.Equal(9, Items[12].SellIn);
            Assert.Equal(0, Items[12].Quality);
            Assert.Equal(0, Items[13].Quality);
            Assert.Equal(0, Items[14].Quality);
        }
    }
}
