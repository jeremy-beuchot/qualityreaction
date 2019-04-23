namespace QualityReaction.Models
{
    public class Project : AbstractDatabaseEntity
    {

        public virtual string Name { get; set; }

        public virtual string Description { get; set; }

        public virtual string Picture { get; set; }

        public virtual bool Discontinued { get; set; }
    }
}