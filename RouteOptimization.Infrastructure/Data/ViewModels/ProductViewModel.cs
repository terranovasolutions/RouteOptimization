﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RouteOptimization.Infrastructure.Data.ViewModels
{
    class ProductViewModel
    {
        public Product Product { get; set; }

        public IEnumerable<Product> AllProducts { get; set; }

    }
}
