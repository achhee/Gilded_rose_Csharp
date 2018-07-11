using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using csharp.Interface;

namespace csharp.Quality
{
    class StandardProduct:IProduct
    {
        public void UpdateQuality(Item item)
        {
            item.SellIn -= 1;
            if (item.Quality > 0)
            {
                if (item.SellIn >= 0)
                {
                    item.Quality -= 1;
                }
                else
                {
                    item.Quality -= 2;
                }
            }

            if (item.Quality < 0)
            {
                item.Quality = 0;
            }
        }
    }
}
