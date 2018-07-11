﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp.Interface
{
    public interface IProductFactory
    {
        IProduct CreateProduct(string productName);
    }
}
