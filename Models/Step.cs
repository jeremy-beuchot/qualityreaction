namespace QualityReaction.Models
{
    public class Step : AbstractDatabaseEntity
    {
        public virtual string Description { get; set; }

        public virtual string ExpectendResult { get; set; }
    }
}