using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce.DummyJson.Dtos.DummyDto
{
    public class Product
    {
        public int SkuId { get; set; }
        public string? SkuTitle { get; set; }
        public string? SkuDescription { get; set; }
        public decimal SkuPrice { get; set; }
        public int SkuStock { get; set; }
 
    }
}
