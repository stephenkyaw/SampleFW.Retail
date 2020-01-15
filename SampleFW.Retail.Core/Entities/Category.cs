using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleFW.Retail.Core.Entities
{
    public class Category : BaseEntity
    {
        public string CategoryID { get; set; }

        public string Code { get; set; }

        public string Description { get; set; }
    }
}
