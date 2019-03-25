namespace QualityReaction.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitDb : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Cases",
                c => new
                    {
                        Id = c.Long(nullable: false, identity: true),
                        Description = c.String(),
                        Requirements = c.String(),
                        Title = c.String(),
                        CreatedBy_Id = c.Long(),
                        Project_Id = c.Long(),
                        Version_Id = c.Long(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Users", t => t.CreatedBy_Id)
                .ForeignKey("dbo.Projects", t => t.Project_Id)
                .ForeignKey("dbo.Versions", t => t.Version_Id)
                .Index(t => t.CreatedBy_Id)
                .Index(t => t.Project_Id)
                .Index(t => t.Version_Id);
            
            CreateTable(
                "dbo.CaseSteps",
                c => new
                    {
                        CaseId = c.Int(nullable: false),
                        StepId = c.Int(nullable: false),
                        Index = c.Int(nullable: false),
                        Case_Id = c.Long(),
                        Step_Id = c.Long(),
                    })
                .PrimaryKey(t => new { t.CaseId, t.StepId })
                .ForeignKey("dbo.Cases", t => t.Case_Id)
                .ForeignKey("dbo.Steps", t => t.Step_Id)
                .Index(t => t.Case_Id)
                .Index(t => t.Step_Id);
            
            CreateTable(
                "dbo.Steps",
                c => new
                    {
                        Id = c.Long(nullable: false, identity: true),
                        Description = c.String(),
                        ExpectendResult = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        Id = c.Long(nullable: false, identity: true),
                        FirstName = c.String(),
                        LastName = c.String(),
                        ShortName = c.String(),
                        Picture = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.PlanCases",
                c => new
                    {
                        PlanId = c.Int(nullable: false),
                        CaseId = c.Int(nullable: false),
                        Index = c.Int(nullable: false),
                        ReadOnly = c.Boolean(nullable: false),
                        Case_Id = c.Long(),
                        Plan_Id = c.Long(),
                    })
                .PrimaryKey(t => new { t.PlanId, t.CaseId })
                .ForeignKey("dbo.Cases", t => t.Case_Id)
                .ForeignKey("dbo.Plans", t => t.Plan_Id)
                .Index(t => t.Case_Id)
                .Index(t => t.Plan_Id);
            
            CreateTable(
                "dbo.Plans",
                c => new
                    {
                        Id = c.Long(nullable: false, identity: true),
                        Description = c.String(),
                        CreatedBy_Id = c.Long(),
                        Project_Id = c.Long(),
                        Version_Id = c.Long(),
                        Run_Id = c.Long(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Users", t => t.CreatedBy_Id)
                .ForeignKey("dbo.Projects", t => t.Project_Id)
                .ForeignKey("dbo.Versions", t => t.Version_Id)
                .ForeignKey("dbo.Runs", t => t.Run_Id)
                .Index(t => t.CreatedBy_Id)
                .Index(t => t.Project_Id)
                .Index(t => t.Version_Id)
                .Index(t => t.Run_Id);
            
            CreateTable(
                "dbo.Projects",
                c => new
                    {
                        Id = c.Long(nullable: false, identity: true),
                        Name = c.String(),
                        Description = c.String(),
                        Picture = c.String(),
                        Discontinued = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Versions",
                c => new
                    {
                        Id = c.Long(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.RunCases",
                c => new
                    {
                        Id = c.Long(nullable: false, identity: true),
                        Case_Id = c.Long(),
                        RunPlan_Id = c.Long(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Cases", t => t.Case_Id)
                .ForeignKey("dbo.RunPlans", t => t.RunPlan_Id)
                .Index(t => t.Case_Id)
                .Index(t => t.RunPlan_Id);
            
            CreateTable(
                "dbo.RunSteps",
                c => new
                    {
                        Id = c.Long(nullable: false, identity: true),
                        Status = c.Int(nullable: false),
                        Description = c.String(),
                        Ticket = c.String(),
                        ModifiedBy_Id = c.Long(),
                        Step_Id = c.Long(),
                        RunCase_Id = c.Long(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Users", t => t.ModifiedBy_Id)
                .ForeignKey("dbo.Steps", t => t.Step_Id)
                .ForeignKey("dbo.RunCases", t => t.RunCase_Id)
                .Index(t => t.ModifiedBy_Id)
                .Index(t => t.Step_Id)
                .Index(t => t.RunCase_Id);
            
            CreateTable(
                "dbo.RunPlans",
                c => new
                    {
                        Id = c.Long(nullable: false, identity: true),
                        State = c.Int(nullable: false),
                        ModifiedBy_Id = c.Long(),
                        Plan_Id = c.Long(),
                        Run_Id = c.Long(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Users", t => t.ModifiedBy_Id)
                .ForeignKey("dbo.Plans", t => t.Plan_Id)
                .ForeignKey("dbo.Runs", t => t.Run_Id)
                .Index(t => t.ModifiedBy_Id)
                .Index(t => t.Plan_Id)
                .Index(t => t.Run_Id);
            
            CreateTable(
                "dbo.Runs",
                c => new
                    {
                        Id = c.Long(nullable: false, identity: true),
                        Description = c.String(),
                        CreatedBy_Id = c.Long(),
                        Version_Id = c.Long(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Users", t => t.CreatedBy_Id)
                .ForeignKey("dbo.Versions", t => t.Version_Id)
                .Index(t => t.CreatedBy_Id)
                .Index(t => t.Version_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Runs", "Version_Id", "dbo.Versions");
            DropForeignKey("dbo.RunPlans", "Run_Id", "dbo.Runs");
            DropForeignKey("dbo.Plans", "Run_Id", "dbo.Runs");
            DropForeignKey("dbo.Runs", "CreatedBy_Id", "dbo.Users");
            DropForeignKey("dbo.RunCases", "RunPlan_Id", "dbo.RunPlans");
            DropForeignKey("dbo.RunPlans", "Plan_Id", "dbo.Plans");
            DropForeignKey("dbo.RunPlans", "ModifiedBy_Id", "dbo.Users");
            DropForeignKey("dbo.RunSteps", "RunCase_Id", "dbo.RunCases");
            DropForeignKey("dbo.RunSteps", "Step_Id", "dbo.Steps");
            DropForeignKey("dbo.RunSteps", "ModifiedBy_Id", "dbo.Users");
            DropForeignKey("dbo.RunCases", "Case_Id", "dbo.Cases");
            DropForeignKey("dbo.Cases", "Version_Id", "dbo.Versions");
            DropForeignKey("dbo.Cases", "Project_Id", "dbo.Projects");
            DropForeignKey("dbo.Plans", "Version_Id", "dbo.Versions");
            DropForeignKey("dbo.Plans", "Project_Id", "dbo.Projects");
            DropForeignKey("dbo.PlanCases", "Plan_Id", "dbo.Plans");
            DropForeignKey("dbo.Plans", "CreatedBy_Id", "dbo.Users");
            DropForeignKey("dbo.PlanCases", "Case_Id", "dbo.Cases");
            DropForeignKey("dbo.Cases", "CreatedBy_Id", "dbo.Users");
            DropForeignKey("dbo.CaseSteps", "Step_Id", "dbo.Steps");
            DropForeignKey("dbo.CaseSteps", "Case_Id", "dbo.Cases");
            DropIndex("dbo.Runs", new[] { "Version_Id" });
            DropIndex("dbo.Runs", new[] { "CreatedBy_Id" });
            DropIndex("dbo.RunPlans", new[] { "Run_Id" });
            DropIndex("dbo.RunPlans", new[] { "Plan_Id" });
            DropIndex("dbo.RunPlans", new[] { "ModifiedBy_Id" });
            DropIndex("dbo.RunSteps", new[] { "RunCase_Id" });
            DropIndex("dbo.RunSteps", new[] { "Step_Id" });
            DropIndex("dbo.RunSteps", new[] { "ModifiedBy_Id" });
            DropIndex("dbo.RunCases", new[] { "RunPlan_Id" });
            DropIndex("dbo.RunCases", new[] { "Case_Id" });
            DropIndex("dbo.Plans", new[] { "Run_Id" });
            DropIndex("dbo.Plans", new[] { "Version_Id" });
            DropIndex("dbo.Plans", new[] { "Project_Id" });
            DropIndex("dbo.Plans", new[] { "CreatedBy_Id" });
            DropIndex("dbo.PlanCases", new[] { "Plan_Id" });
            DropIndex("dbo.PlanCases", new[] { "Case_Id" });
            DropIndex("dbo.CaseSteps", new[] { "Step_Id" });
            DropIndex("dbo.CaseSteps", new[] { "Case_Id" });
            DropIndex("dbo.Cases", new[] { "Version_Id" });
            DropIndex("dbo.Cases", new[] { "Project_Id" });
            DropIndex("dbo.Cases", new[] { "CreatedBy_Id" });
            DropTable("dbo.Runs");
            DropTable("dbo.RunPlans");
            DropTable("dbo.RunSteps");
            DropTable("dbo.RunCases");
            DropTable("dbo.Versions");
            DropTable("dbo.Projects");
            DropTable("dbo.Plans");
            DropTable("dbo.PlanCases");
            DropTable("dbo.Users");
            DropTable("dbo.Steps");
            DropTable("dbo.CaseSteps");
            DropTable("dbo.Cases");
        }
    }
}
