using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace QualityReaction.Models
{
    public class User
    {
        [Key]
        public virtual long Id { get; set; }
        public virtual string FirstName { get; set; }
        public virtual string LastName { get; set; }
        public virtual string ShortName { get; set; }

        [NotMapped]
        public virtual string FullName
        {
            get
            {
                return $"{FirstName} {LastName}";
            }
        }
        public virtual string Picture { get; set; }

    }
}