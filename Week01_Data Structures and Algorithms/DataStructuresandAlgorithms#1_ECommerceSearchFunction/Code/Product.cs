using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommercePlatformSearch
{
    public class Product
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public string Category { get; set; }

        public Product (int productId, string productName, string category)
        {
            ProductId = productId;
            ProductName = productName;
            Category = category;

        }

        public override string ToString()
        {
            return $"[{ProductId}]{ProductName}-{Category}";
        }

        




    }
}
