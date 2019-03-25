using System.ComponentModel.DataAnnotations;

namespace QualityReaction.Models
{
    public class Project
    {
        [Key]
        public virtual long Id { get; set; }
        public virtual string Name { get; set; }
        public virtual string Description { get; set; }
        public virtual string Picture { get; set; }
        public virtual bool Discontinued { get; set; }
    }
}