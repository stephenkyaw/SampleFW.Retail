using System.ComponentModel.DataAnnotations.Schema;

namespace SampleFW.Retail.Core.Entities
{
    [Table("Currency")]
    public class Currency : BaseEntity
    {
        public Currency()
        {
            IsHomeCurrency = false;
        }

        public string Code { get; set; }

        public string Description { get; set; }

        public bool IsHomeCurrency { get; set; }
    }
}
