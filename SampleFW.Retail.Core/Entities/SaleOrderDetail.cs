using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace SampleFW.Retail.Core.Entities
{
    [Table("SaleOrderDetail")]
    public class SaleOrderDetail : BaseEntity
    {
        public string SaleVourcherNo { get; set; }

        public string SaleOrderHeaderID { get; set; }
        
        [ForeignKey("SaleOrderHeaderID")]
        public virtual SaleOrderHeader SaleOrderHeader { get; set; }

        public string ProductID { get; set; }

        [ForeignKey("ProductID")]
        public virtual Product Product { get; set; }

        public decimal SellingPrice { get; set; }

        public decimal BuyingPrice { get; set; }

        public Int32 Quantity { get; set; }

        public decimal DiscountPercent { get; set; }

        public decimal DiscountAmount { get; set; }

        public decimal SaleAmount { get; set; }
    }
}
