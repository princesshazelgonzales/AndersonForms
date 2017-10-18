using BaseEntity;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AndersonFormsEntity
{
    [Table("Requirement")]
    public class ERequirement : EBase
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int RequirementId { get; set; }

        [StringLength(50)]
        public string Name { get; set; }

        public virtual ICollection<ERequestedItem> RequestedItems { get; set; }
    }
}
