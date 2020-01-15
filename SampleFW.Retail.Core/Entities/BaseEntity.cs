using SampleFW.Retail.Core.Identity;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

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

        [ForeignKey("CreatedUserID")]
        public virtual ApplicationUser CreatedUser { get; set; }

        public DateTime CreatedDate { get; set; }

        public string UpdatedUserID { get; set; }

        [ForeignKey("UpdatedUserID")]
        public virtual ApplicationUser UpdatedUser { get; set; }

        public DateTime UpdatedDate { get; set; }

        public bool IsActive { get; set; }
    }
}
