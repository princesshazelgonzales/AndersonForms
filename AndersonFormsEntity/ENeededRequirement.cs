using BaseEntity;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AndersonFormsEntity
{
    [Table("NeededRequirement")]
    public class ENeededRequirement : EBase
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int NeededRequirementId { get; set; }
        [ForeignKey("Requirement")]
        public int RequirementId { get; set; }

        public virtual ERequirement Requirement { get; set; }
    }
}
