using System.Collections.Generic;

namespace GildedRoseKata
{
    public class GildedRose
    {
        IList<Item> Items;
        public GildedRose(IList<Item> Items)
        {
            this.Items = Items;
        }

        public void UpdateQuality()
        {
            for (var i = 0; i < Items.Count; i++)
            {
                if (Items[i].Name != "Sulfuras, Hand of Ragnaros")
                {
                    Items[i].SellIn = Items[i].SellIn - 1;
                }

                if (Items[i].Quality >= 0 && Items[i].Quality < 50)
                {
                    if (Items[i].Name == "Backstage passes to a TAFKAL80ETC concert")
                    {
                        Items[i] = UpdateBackstage(Items[i]);
                    }
                    else if (Items[i].Name == "Aged Brie")
                    {
                        Items[i] = UpdateAgedBrie(Items[i]);
                    }
                    else if (Items[i].Name == "Conjured Mana Cake")
                    {
                        Items[i] = UpdateConjured(Items[i]);
                    }
                    else
                    {
                        Items[i] = UpdateOthers(Items[i]);
                    }
                }
            }
        }

        public Item UpdateAgedBrie(Item item)
        {
            if (item.Quality < 50)
                item.Quality = item.Quality + 1;
            return item;
        }
        public Item UpdateBackstage(Item item)
        {
            if (item.SellIn > 10)
            {
                item.Quality = item.Quality + 1;
            }
            else if (item.SellIn < 11 && item.SellIn > 5)
            {
                for (int i = 0; i < 2; i++)
                {
                    if (item.Quality < 50)
                        item.Quality = item.Quality + 1;
                }

            }
            else if (item.SellIn < 6 && item.SellIn > 0)
            {
                for (int i = 0; i < 3; i++)
                {
                    if (item.Quality < 50)
                        item.Quality = item.Quality + 1;
                }
            }
            else if (item.SellIn < 0)
            {
                item.Quality = item.Quality - item.Quality;
            }
            return item;
        }

        public Item UpdateConjured(Item item)
        {
            for (int i = 0; i < 2; i++)
            {
                if (item.Quality > 0)
                    item.Quality = item.Quality - 1;
            }

            return item;
        }
        public Item UpdateOthers(Item item)
        {
            if (item.Quality > 0)
                item.Quality = item.Quality - 1;
            return item;
        }
    }
}
