using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleFW.Retail.Core.Entities
{
    public class Product : BaseEntity
    {
        public string ProcuctID { get; set; }

        public string CodeName { get; set; }

        public string Description { get; set; }

        public string CategoryID { get; set; }

        public virtual Category Category { get; set; }

        public string CurrencyID { get; set; }

        public virtual Currency Currency { get; set; }

        public decimal SellingPrice { get; set; }

        public decimal BuyingPrice { get; set; }

        public Int32 Quantity { get; set; }

    }
}
