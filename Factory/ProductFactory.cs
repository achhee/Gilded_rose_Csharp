using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using csharp.Interface;
using csharp.Quality;

namespace csharp.Factory
{
    class ProductFactory:IProductFactory
    {
        public IProduct CreateProduct(string productName)
        {
            if (productName == "Aged Brie")
            {
                return new AgedBrieProduct();
            }
            else if (productName == "Conjured Mana Cake")
            {
                return new ConjuredProduct();
            }
            else if(productName == "Backstage passes to a TAFKAL80ETC concert")
            {
                return new PassProduct();
            }
            else if (productName == "Sulfuras, Hand of Ragnaros")
            {
                return new SulfurasProduct();
            }
            else
            {
                return new StandardProduct();
            }
        }
    }
}
