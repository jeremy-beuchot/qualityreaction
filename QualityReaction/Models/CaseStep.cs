using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace QualityReaction.Models
{
    public class CaseStep
    {
        [Key, Column(Order = 1)]
        public int CaseId { get; set; }

        [Key, Column(Order = 2)]
        public int StepId { get; set; }


        public virtual Case Case { get; set; }
        public virtual Step Step { get; set; }
        public virtual int Index { get; set; }
    }
}