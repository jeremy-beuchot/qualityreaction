using System.ComponentModel.DataAnnotations;

namespace QualityReaction.Models
{
    public class Version
    {
        [Key]
        public virtual long Id { get; set; }
        public virtual string Name { get; set; }
    }
}