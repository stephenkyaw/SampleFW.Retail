using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace SampleFW.Retail.Core.Entities
{
    [Table("SaleOrderHeader")]
    public class SaleOrderHeader : BaseEntity
    {
        public SaleOrderHeader()
        {
            SaleDate = DateTime.Now;
        }

        public DateTime SaleDate { get; set; }

        public string SaleVoucherNo { get; set; }

        public string Description { get; set; }

        public decimal TotalAmount { get; set; }

        public decimal NetAmount { get; set; }

        public virtual ICollection<SaleOrderDetail> SaleOrderDetails { get; set; }
    }
}
