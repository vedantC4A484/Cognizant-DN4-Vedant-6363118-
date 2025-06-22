﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommercePlatformSearch
{

    public static class ProductSearch
    {
        public static Product LinearSearch(Product[] products, string name)
        {
            foreach (Product product in products)
            {
                if (product.ProductName.Equals(name, StringComparison.OrdinalIgnoreCase))
                {
                    return product;
                }
            }
            return null;
        }

        public static Product BinarySearch(Product[] products, string name)
        {
            int left = 0;
            int right = products.Length - 1;

            while (left <= right)
            {
                int mid = (left + right) / 2;
                int comparison = string.Compare(products[mid].ProductName, name, StringComparison.OrdinalIgnoreCase);

                if (comparison == 0)
                    return products[mid];
                else if (comparison < 0)
                    left = mid + 1;
                else
                    right = mid - 1;
            }

            return null;
        }
    }

}
