using System.ComponentModel.DataAnnotations.Schema;

namespace SampleFW.Retail.Core.Entities
{
    [Table("Category")]
    public class Category : BaseEntity
    {
        public string Code { get; set; }

        public string Description { get; set; }
    }
}
