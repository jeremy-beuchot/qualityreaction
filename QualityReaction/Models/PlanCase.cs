using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace QualityReaction.Models
{
    public class PlanCase
    {
        [Key, Column(Order = 1)]
        public int PlanId { get; set; }

        [Key, Column(Order = 2)]
        public int CaseId { get; set; }


        public virtual Plan Plan { get; set; }
        public virtual Case Case { get; set; }
        public virtual int Index { get; set; }
        public virtual bool ReadOnly { get; set; }
    }
}