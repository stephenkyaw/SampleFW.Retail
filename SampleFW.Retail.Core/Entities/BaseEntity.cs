using System;
using System.ComponentModel.DataAnnotations;

namespace SampleFW.Retail.Core.Entities
{
    public class BaseEntity
    {
        public BaseEntity()
        {
            ID = Guid.NewGuid().ToString();

            IsActive = true;

            CreatedDate = DateTime.Now;
        }

        [Key]
        public string ID { get; set; }

        public string CreatedUserID { get; set; }

        public DateTime CreatedDate { get; set; }

        public string UpdatedUserID { get; set; }

        public DateTime UpdatedDate { get; set; }

        public bool IsActive { get; set; }
    }
}
