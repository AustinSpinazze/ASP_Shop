using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyShop.Core.Models
{
    public class Product
    {
        public string productID { get; set; }
        [StringLength(20)]
        [DisplayName("Product Name")]
        public string productName { get; set; }
        public string productDescription { get; set; }
        [Range(0, 1000)]
        public string productPrice { get; set; }
        public string productCategory { get; set; }
        public string productImage { get; set; }
        public Product()
        {
            this.productID = Guid.NewGuid().ToString();
        }
    }
}
