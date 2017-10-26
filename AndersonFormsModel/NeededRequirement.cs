namespace AndersonFormsModel
{
    public class NeededRequirement : Base.Base
    {
        public bool Checked { get; set; }
        public bool IsProvided { get; set; }

        public int NeededRequirementId { get; set; }
        public int RequirementId { get; set; }

        public virtual Requirement Requirement { get; set; }
    }
}
