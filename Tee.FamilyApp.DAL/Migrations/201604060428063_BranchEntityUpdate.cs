namespace Tee.FamilyApp.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class BranchEntityUpdate : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Branch", "BirthDetails_DateOfBirth", c => c.DateTime(nullable: false));
            DropColumn("dbo.Branch", "Age");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Branch", "Age", c => c.Int(nullable: false));
            DropColumn("dbo.Branch", "BirthDetails_DateOfBirth");
        }
    }
}
