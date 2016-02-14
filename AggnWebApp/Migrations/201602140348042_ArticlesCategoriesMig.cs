namespace AggnWebApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ArticlesCategoriesMig : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Articles",
                c => new
                    {
                        ArticleID = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Body = c.String(),
                        Published = c.Boolean(nullable: false),
                        Public = c.Boolean(nullable: false),
                        AuthorUserID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ArticleID);
            
            CreateTable(
                "dbo.Categories",
                c => new
                    {
                        CategoryID = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.CategoryID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Categories");
            DropTable("dbo.Articles");
        }
    }
}
