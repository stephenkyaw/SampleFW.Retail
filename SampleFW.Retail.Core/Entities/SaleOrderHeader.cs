using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleFW.Retail.Core.Entities
{
    public class SaleOrderHeader : BaseEntity
    {
        public string SaleOrderHeaderID { get; set; }

        public DateTime SaleDate { get; set; }

        public string SaleVoucherNo { get; set; }

        public string Description { get; set; }

        public virtual ICollection<SaleOrderDetail> SaleOrderDetails { get; set; }
    }
}
