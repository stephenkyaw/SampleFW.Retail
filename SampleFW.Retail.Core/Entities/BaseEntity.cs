using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleFW.Retail.Core.Entities
{
    public class BaseEntity
    {
        public string CreatedUserID { get; set; }

        public DateTime CreatedDate { get; set; }

        public string UpdatedUserID { get; set; }

        public DateTime UpdatedDate { get; set; }

        public bool IsActive { get; set; }
    }
}
