using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace SampleFW.Retail.Core.Entities
{
    [Table("Product")]
    public class Product : BaseEntity
    {
        public string CodeName { get; set; }

        public string Description { get; set; }

        public string CategoryID { get; set; }

        [ForeignKey("CategoryID")]
        public virtual Category Category { get; set; }

        public string CurrencyID { get; set; }

        [ForeignKey("CurrencyID")]
        public virtual Currency Currency { get; set; }

        public decimal SellingPrice { get; set; }

        public decimal BuyingPrice { get; set; }

        public Int32 Quantity { get; set; }

    }
}
