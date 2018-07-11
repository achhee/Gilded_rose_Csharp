using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using csharp.Interface;

namespace csharp.Quality
{
    class ConjuredProduct:IProduct
    {
        public void UpdateQuality(Item item)
        {
            item.SellIn -= 1;
            if (item.Quality > 0)
            {
                if (item.SellIn >= 0)
                {
                    item.Quality -= 2;
                }
                else
                {
                    item.Quality -= 4;
                }
            }

            if (item.Quality < 0)
            {
                item.Quality = 0;
            }
        }
    }
}
