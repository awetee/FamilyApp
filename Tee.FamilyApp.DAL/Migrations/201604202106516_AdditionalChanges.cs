namespace Tee.FamilyApp.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AdditionalChanges : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Link", "BranchID", "dbo.Branch");
            DropPrimaryKey("dbo.Branch");
            DropPrimaryKey("dbo.Link");
            CreateTable(
                "dbo.BirthDetail",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Country = c.String(),
                        DateOfBirth = c.DateTime(nullable: false),
                        Province = c.String(),
                        Town = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            AddColumn("dbo.Branch", "Id", c => c.Int(nullable: false, identity: true));
            AddColumn("dbo.Branch", "BirthDetails_Id", c => c.Int());
            AddColumn("dbo.Link", "Id", c => c.Int(nullable: false, identity: true));
            AddPrimaryKey("dbo.Branch", "Id");
            AddPrimaryKey("dbo.Link", "Id");
            CreateIndex("dbo.Branch", "BirthDetails_Id");
            AddForeignKey("dbo.Branch", "BirthDetails_Id", "dbo.BirthDetail", "Id");
            AddForeignKey("dbo.Link", "BranchID", "dbo.Branch", "Id", cascadeDelete: true);
            DropColumn("dbo.Branch", "BranchID");
            DropColumn("dbo.Branch", "BirthDetails_Country");
            DropColumn("dbo.Branch", "BirthDetails_Province");
            DropColumn("dbo.Branch", "BirthDetails_Town");
            DropColumn("dbo.Branch", "BirthDetails_DateOfBirth");
            DropColumn("dbo.Link", "LinkID");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Link", "LinkID", c => c.Int(nullable: false, identity: true));
            AddColumn("dbo.Branch", "BirthDetails_DateOfBirth", c => c.DateTime(nullable: false));
            AddColumn("dbo.Branch", "BirthDetails_Town", c => c.String());
            AddColumn("dbo.Branch", "BirthDetails_Province", c => c.String());
            AddColumn("dbo.Branch", "BirthDetails_Country", c => c.String());
            AddColumn("dbo.Branch", "BranchID", c => c.Int(nullable: false, identity: true));
            DropForeignKey("dbo.Link", "BranchID", "dbo.Branch");
            DropForeignKey("dbo.Branch", "BirthDetails_Id", "dbo.BirthDetail");
            DropIndex("dbo.Branch", new[] { "BirthDetails_Id" });
            DropPrimaryKey("dbo.Link");
            DropPrimaryKey("dbo.Branch");
            DropColumn("dbo.Link", "Id");
            DropColumn("dbo.Branch", "BirthDetails_Id");
            DropColumn("dbo.Branch", "Id");
            DropTable("dbo.BirthDetail");
            AddPrimaryKey("dbo.Link", "LinkID");
            AddPrimaryKey("dbo.Branch", "BranchID");
            AddForeignKey("dbo.Link", "BranchID", "dbo.Branch", "BranchID", cascadeDelete: true);
        }
    }
}
