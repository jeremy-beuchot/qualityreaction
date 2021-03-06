﻿using System.ComponentModel.DataAnnotations;

namespace QualityReaction.Models
{
    public class RunStep
    {
        [Key]
        public virtual long Id { get; set; }
        public virtual Step Step { get; set; }
        public virtual Status Status { get; set; }
        public virtual User ModifiedBy { get; set; }
        public virtual string Description { get; set; }
        public virtual string Ticket { get; set; }
    }
}