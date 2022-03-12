namespace Layer_Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Brands",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Brand_Name = c.String(nullable: false),
                        CreateDate = c.DateTime(),
                        UpdateDate = c.DateTime(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Servers",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Server_Name = c.String(nullable: false),
                        Server_Url = c.String(nullable: false),
                        Server_Desc = c.String(nullable: false),
                        Status = c.Boolean(nullable: false),
                        Modelo = c.String(nullable: false),
                        CreateDate = c.DateTime(),
                        UpdateDate = c.DateTime(),
                        Brand_Id = c.Int(nullable: false),
                        Category_Id = c.Int(nullable: false),
                        SO_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Brands", t => t.Brand_Id, cascadeDelete: true)
                .ForeignKey("dbo.Categories", t => t.Category_Id, cascadeDelete: true)
                .ForeignKey("dbo.SOes", t => t.SO_Id, cascadeDelete: true)
                .Index(t => t.Brand_Id)
                .Index(t => t.Category_Id)
                .Index(t => t.SO_Id);
            
            CreateTable(
                "dbo.Categories",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Category_Name = c.String(nullable: false),
                        Category_Desc = c.String(nullable: false),
                        CreateDate = c.DateTime(),
                        UpdateDate = c.DateTime(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.SOes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Server_So = c.String(nullable: false),
                        Develop = c.String(nullable: false),
                        SO_Url = c.String(nullable: false),
                        SO_Date = c.DateTime(),
                        SO_Desc = c.String(nullable: false),
                        CreateDate = c.DateTime(),
                        UpdateDate = c.DateTime(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Servers", "SO_Id", "dbo.SOes");
            DropForeignKey("dbo.Servers", "Category_Id", "dbo.Categories");
            DropForeignKey("dbo.Servers", "Brand_Id", "dbo.Brands");
            DropIndex("dbo.Servers", new[] { "SO_Id" });
            DropIndex("dbo.Servers", new[] { "Category_Id" });
            DropIndex("dbo.Servers", new[] { "Brand_Id" });
            DropTable("dbo.SOes");
            DropTable("dbo.Categories");
            DropTable("dbo.Servers");
            DropTable("dbo.Brands");
        }
    }
}
