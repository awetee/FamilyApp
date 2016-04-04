namespace Tee.FamilyApp.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class FirstDBUpdate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Branch",
                c => new
                    {
                        BranchID = c.Int(nullable: false, identity: true),
                        FirstName = c.String(),
                        LastName = c.String(),
                        CoountryOfOrigin = c.String(),
                        BirthDetails_Country = c.String(),
                        BirthDetails_Province = c.String(),
                        BirthDetails_Town = c.String(),
                        Age = c.Int(nullable: false),
                        Gender = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.BranchID);
            
            CreateTable(
                "dbo.Link",
                c => new
                    {
                        LinkID = c.Int(nullable: false, identity: true),
                        BranchID = c.Int(nullable: false),
                        LinkType = c.Int(nullable: false),
                        LinkBranchID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.LinkID)
                .ForeignKey("dbo.Branch", t => t.BranchID, cascadeDelete: true)
                .Index(t => t.BranchID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Link", "BranchID", "dbo.Branch");
            DropIndex("dbo.Link", new[] { "BranchID" });
            DropTable("dbo.Link");
            DropTable("dbo.Branch");
        }
    }
}
