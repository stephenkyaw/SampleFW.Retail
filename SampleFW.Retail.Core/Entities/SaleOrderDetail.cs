using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleFW.Retail.Core.Entities
{
    public class SaleOrderDetail : BaseEntity
    {
        public string SaleOrderDetailID { get; set; }

        public string SaleOrderHeaderID { get; set; }

        public virtual SaleOrderHeader SaleOrderHeader { get; set; }

        public string SaleVourcherNo { get; set; }

        public string ProductID { get; set; }

        public virtual Product Product { get; set; }

        public decimal SellingPrice { get; set; }

        public decimal BuyingPrice { get; set; }

        public Int32 Quantity { get; set; }

        public decimal DiscountPercent { get; set; }

        public decimal DiscountAmount { get; set; }

        public decimal SaleAmount { get; set; }
    }
}
