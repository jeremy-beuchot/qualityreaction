using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace QualityReaction.Models
{
    public enum Status
    {
        // Test is not yet passed
        NotRun = 0,
        // Test is in progress
        InProgress = 1,
        // Test is successfully passed
        Passed = 2,
        // Test failed
        Failed = 3,
        // An issue has been corrected. Waiting for confirmation
        Resolved = 4,
    }
}