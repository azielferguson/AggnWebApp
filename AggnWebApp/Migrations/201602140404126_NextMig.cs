namespace AggnWebApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class NextMig : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Publications",
                c => new
                    {
                        PublicationID = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.PublicationID);
            
            CreateTable(
                "dbo.Roles",
                c => new
                    {
                        RoleID = c.String(nullable: false, maxLength: 128),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.RoleID);
            
            AddColumn("dbo.Articles", "UserID", c => c.Int(nullable: false));
            DropColumn("dbo.Articles", "AuthorUserID");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Articles", "AuthorUserID", c => c.Int(nullable: false));
            DropColumn("dbo.Articles", "UserID");
            DropTable("dbo.Roles");
            DropTable("dbo.Publications");
        }
    }
}
