using QualityReaction.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace QualityReaction.DB
{
    public class QualityReactionContext : DbContext
    {
        public QualityReactionContext() : base("QualityReactionDBConnectionString")
        {

            // Disable initializer
            // Database.SetInitializer<QualityReactionContext>(null);


            // Strategy : On init => Create database if not exist
            Database.SetInitializer<QualityReactionContext>(new CreateDatabaseIfNotExists<QualityReactionContext>());


            // Strategy : On init => Drop and Create database if model changes
            // Database.SetInitializer<QualityReactionContext>(new DropCreateDatabaseIfModelChanges<QualityReactionContext>());

        }

        public DbSet<Case> Cases { get; set; }
        public DbSet<Plan> Plans { get; set; }        
        public DbSet<Step> Steps { get; set; }
        public DbSet<CaseStep> CaseSteps { get; set; }
        public DbSet<PlanCase> PlanCases { get; set; }
        public DbSet<Project> Projects { get; set; }
        public DbSet<Run> Runs { get; set; }
        public DbSet<RunCase> RunCases { get; set; }
        public DbSet<RunPlan> RunPlans { get; set; }
        public DbSet<RunStep> RunSteps { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Models.Version> Versions { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}