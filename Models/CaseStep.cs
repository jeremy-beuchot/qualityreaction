namespace QualityReaction.Models
{
    public class CaseStep : AbstractDatabaseEntity
    {
        public virtual Case Case { get; set; }

        public virtual Step Step { get; set; }

        public virtual int Index { get; set; }
    }
}