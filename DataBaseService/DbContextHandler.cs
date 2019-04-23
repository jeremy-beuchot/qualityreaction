using QualityReaction.Models;
using System.Data.Entity;

namespace QualityReaction.DataBaseService
{
    public class DbContextHandler : DbContext
    {
        public DbContextHandler() : base("DbContextHandler")
        {
        }

        public DbSet<Case> Cases { get; set; }

        public DbSet<CaseStep> CaseSteps { get; set; }

        public DbSet<Plan> Plans { get; set; }

        public DbSet<PlanCase> PlanCases { get; set; }

        public DbSet<Project> Projects { get; set; }

        public DbSet<Run> Runs { get; set; }

        public DbSet<RunCase> RunCases { get; set; }

        public DbSet<RunPlan> RunPlans { get; set; }

        public DbSet<RunStep> RunSteps { get; set; }

        public DbSet<Step> Steps { get; set; }

        public DbSet<User> Users { get; set; }

        public DbSet<Version> Versions { get; set; }
    }
}

