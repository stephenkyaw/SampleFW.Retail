using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleFW.Retail.Core.Entities
{
    public class Currency : BaseEntity
    {
        public string CurrencyID { get; set; }

        public string Code { get; set; }

        public string Description { get; set; }

        public bool IsHomeCurrency { get; set; }
    }
}
