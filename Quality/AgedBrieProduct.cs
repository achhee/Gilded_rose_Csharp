using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using csharp.Interface;

namespace csharp.Quality
{
    class AgedBrieProduct:IProduct
    {
        public void UpdateQuality(Item item)
        {
            item.SellIn -= 1;
            if (item.Quality < 50)
            {
                item.Quality += 1;
            }
        }
    }
}
