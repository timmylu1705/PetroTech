namespace PetroTech.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _1902019 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Footers",
                c => new
                    {
                        FooterID = c.Int(nullable: false, identity: true),
                        FooterContent = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.FooterID);
            
            CreateTable(
                "dbo.MenuGroups",
                c => new
                    {
                        MenuGroupID = c.String(nullable: false, maxLength: 128),
                        MenuGroupName = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.MenuGroupID);
            
            CreateTable(
                "dbo.Menus",
                c => new
                    {
                        MenuID = c.Int(nullable: false, identity: true),
                        MenuGroupID = c.String(nullable: false, maxLength: 128),
                        MenuName = c.String(nullable: false),
                        MenuURL = c.String(nullable: false),
                        DisplayOrder = c.Int(nullable: false),
                        Target = c.String(),
                        Status = c.String(nullable: false),
                    })
                .PrimaryKey(t => new { t.MenuID, t.MenuGroupID })
                .ForeignKey("dbo.MenuGroups", t => t.MenuGroupID, cascadeDelete: true)
                .Index(t => t.MenuGroupID);
            
            CreateTable(
                "dbo.OrderDetails",
                c => new
                    {
                        OrderID = c.String(nullable: false, maxLength: 128),
                        ProductID = c.String(nullable: false, maxLength: 128),
                        Quantitty = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.OrderID, t.ProductID })
                .ForeignKey("dbo.Orders", t => t.OrderID, cascadeDelete: true)
                .ForeignKey("dbo.Products", t => t.ProductID, cascadeDelete: true)
                .Index(t => t.OrderID)
                .Index(t => t.ProductID);
            
            CreateTable(
                "dbo.Orders",
                c => new
                    {
                        OrderID = c.String(nullable: false, maxLength: 128),
                        CustomerName = c.String(nullable: false, maxLength: 256),
                        CustomerAddress = c.String(nullable: false, maxLength: 256),
                        CustomerEmail = c.String(nullable: false, maxLength: 50),
                        CustomerMobile = c.String(nullable: false, maxLength: 50),
                        CustomerMessage = c.String(nullable: false, maxLength: 256),
                        PaymentMethod = c.String(maxLength: 256),
                        CreatedBy = c.String(),
                        CreatedDateTime = c.DateTime(),
                        LastUpdatedBy = c.String(),
                        LastUpdatedDateTime = c.DateTime(),
                        Status = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.OrderID);
            
            CreateTable(
                "dbo.Products",
                c => new
                    {
                        ProductID = c.String(nullable: false, maxLength: 128),
                        ProductName = c.String(nullable: false, maxLength: 256),
                        Alias = c.String(nullable: false, maxLength: 256),
                        ProductCatelogyID = c.String(maxLength: 128),
                        Image = c.String(),
                        MoreImage = c.String(storeType: "xml"),
                        Price = c.Decimal(nullable: false, precision: 18, scale: 2),
                        PromotionPrice = c.Decimal(precision: 18, scale: 2),
                        Warranty = c.Int(),
                        Description = c.String(maxLength: 500),
                        Content = c.String(),
                        HomeFlag = c.String(),
                        HotFlag = c.Boolean(),
                        ViewCount = c.Int(),
                        CreateDateTime = c.DateTime(),
                        CreatedBy = c.String(maxLength: 256),
                        LastUpdatedDateTime = c.DateTime(),
                        LastUpdatedBy = c.String(maxLength: 256),
                        Status = c.String(maxLength: 256),
                        MetaKeyWord = c.String(maxLength: 256),
                        MetaDescription = c.String(maxLength: 256),
                    })
                .PrimaryKey(t => t.ProductID)
                .ForeignKey("dbo.ProductCatelogies", t => t.ProductCatelogyID)
                .Index(t => t.ProductCatelogyID);
            
            CreateTable(
                "dbo.ProductCatelogies",
                c => new
                    {
                        ProductCatelogyID = c.String(nullable: false, maxLength: 128),
                        ProductCatelogyName = c.String(nullable: false, maxLength: 256),
                        Alias = c.String(nullable: false, maxLength: 256),
                        Description = c.String(maxLength: 500),
                        PartnerID = c.Int(),
                        DisplayOrder = c.Int(),
                        Image = c.String(maxLength: 256),
                        HomeFlag = c.String(),
                        CreateDateTime = c.DateTime(),
                        CreatedBy = c.String(maxLength: 256),
                        LastUpdatedDateTime = c.DateTime(),
                        LastUpdatedBy = c.String(maxLength: 256),
                        Status = c.String(maxLength: 256),
                        MetaKeyWord = c.String(maxLength: 256),
                        MetaDescription = c.String(maxLength: 256),
                    })
                .PrimaryKey(t => t.ProductCatelogyID);
            
            CreateTable(
                "dbo.Pages",
                c => new
                    {
                        PageID = c.String(nullable: false, maxLength: 128),
                        PageName = c.String(nullable: false, maxLength: 256),
                        Alias = c.String(nullable: false, maxLength: 256),
                        Content = c.String(),
                        CreateDateTime = c.DateTime(),
                        CreatedBy = c.String(maxLength: 256),
                        LastUpdatedDateTime = c.DateTime(),
                        LastUpdatedBy = c.String(maxLength: 256),
                        Status = c.String(maxLength: 256),
                        MetaKeyWord = c.String(maxLength: 256),
                        MetaDescription = c.String(maxLength: 256),
                    })
                .PrimaryKey(t => t.PageID);
            
            CreateTable(
                "dbo.PostCatelogies",
                c => new
                    {
                        PostCatelogyID = c.String(nullable: false, maxLength: 128),
                        PostCatelogyName = c.String(nullable: false, maxLength: 256),
                        Alias = c.String(nullable: false, maxLength: 256),
                        Desctiption = c.String(maxLength: 500),
                        PartnerID = c.Int(),
                        DisplayOrder = c.Int(),
                        Image = c.String(maxLength: 256),
                        HomeFlag = c.String(),
                        CreateDateTime = c.DateTime(),
                        CreatedBy = c.String(maxLength: 256),
                        LastUpdatedDateTime = c.DateTime(),
                        LastUpdatedBy = c.String(maxLength: 256),
                        Status = c.String(maxLength: 256),
                        MetaKeyWord = c.String(maxLength: 256),
                        MetaDescription = c.String(maxLength: 256),
                    })
                .PrimaryKey(t => t.PostCatelogyID);
            
            CreateTable(
                "dbo.Posts",
                c => new
                    {
                        PostID = c.String(nullable: false, maxLength: 50),
                        PostName = c.String(nullable: false, maxLength: 256),
                        Alias = c.String(nullable: false, maxLength: 256),
                        PostCatelogyID = c.String(nullable: false, maxLength: 128),
                        Image = c.String(),
                        Description = c.String(),
                        Content = c.String(),
                        HomeFlag = c.Boolean(),
                        HotFlag = c.Boolean(),
                        ViewCount = c.Int(nullable: false),
                        CreateDateTime = c.DateTime(),
                        CreatedBy = c.String(maxLength: 256),
                        LastUpdatedDateTime = c.DateTime(),
                        LastUpdatedBy = c.String(maxLength: 256),
                        Status = c.String(maxLength: 256),
                        MetaKeyWord = c.String(maxLength: 256),
                        MetaDescription = c.String(maxLength: 256),
                    })
                .PrimaryKey(t => t.PostID)
                .ForeignKey("dbo.PostCatelogies", t => t.PostCatelogyID, cascadeDelete: true)
                .Index(t => t.PostCatelogyID);
            
            CreateTable(
                "dbo.PostTags",
                c => new
                    {
                        PostID = c.String(nullable: false, maxLength: 50),
                        TagID = c.String(nullable: false, maxLength: 50),
                    })
                .PrimaryKey(t => new { t.PostID, t.TagID })
                .ForeignKey("dbo.Posts", t => t.PostID, cascadeDelete: true)
                .ForeignKey("dbo.Tags", t => t.TagID, cascadeDelete: true)
                .Index(t => t.PostID)
                .Index(t => t.TagID);
            
            CreateTable(
                "dbo.Tags",
                c => new
                    {
                        TagID = c.String(nullable: false, maxLength: 50),
                        TagName = c.String(nullable: false, maxLength: 50),
                        TagType = c.String(nullable: false, maxLength: 50),
                    })
                .PrimaryKey(t => t.TagID);
            
            CreateTable(
                "dbo.ProductTags",
                c => new
                    {
                        ProductID = c.String(nullable: false, maxLength: 128),
                        TagID = c.String(nullable: false, maxLength: 50),
                    })
                .PrimaryKey(t => new { t.ProductID, t.TagID })
                .ForeignKey("dbo.Products", t => t.ProductID, cascadeDelete: true)
                .ForeignKey("dbo.Tags", t => t.TagID, cascadeDelete: true)
                .Index(t => t.ProductID)
                .Index(t => t.TagID);
            
            CreateTable(
                "dbo.Sildes",
                c => new
                    {
                        SildeID = c.String(nullable: false, maxLength: 128),
                        SildeName = c.String(nullable: false, maxLength: 256),
                        Description = c.String(maxLength: 256),
                        Image = c.String(maxLength: 256),
                        Url = c.String(maxLength: 256),
                        DisplayOrder = c.Int(),
                        Status = c.String(),
                    })
                .PrimaryKey(t => t.SildeID);
            
            CreateTable(
                "dbo.SupportOnlines",
                c => new
                    {
                        SupportOnlineID = c.String(nullable: false, maxLength: 128),
                        SupportOnlineName = c.String(maxLength: 50),
                        Department = c.String(maxLength: 50),
                        Skype = c.String(maxLength: 50),
                        Mobile = c.String(maxLength: 50),
                        Facebook = c.String(maxLength: 50),
                        Status = c.String(),
                        DisplayOrder = c.Int(),
                    })
                .PrimaryKey(t => t.SupportOnlineID);
            
            CreateTable(
                "dbo.SystemConfigs",
                c => new
                    {
                        SystemConfigID = c.String(nullable: false, maxLength: 128),
                        Code = c.String(nullable: false, maxLength: 50),
                        ValueString = c.String(maxLength: 50),
                        ValueInt = c.Int(),
                    })
                .PrimaryKey(t => t.SystemConfigID);
            
            CreateTable(
                "dbo.VisitorStatistics",
                c => new
                    {
                        VisitorStatisticID = c.Guid(nullable: false),
                        VisitedDate = c.DateTime(nullable: false),
                        IPAddress = c.String(maxLength: 50),
                    })
                .PrimaryKey(t => t.VisitorStatisticID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.ProductTags", "TagID", "dbo.Tags");
            DropForeignKey("dbo.ProductTags", "ProductID", "dbo.Products");
            DropForeignKey("dbo.PostTags", "TagID", "dbo.Tags");
            DropForeignKey("dbo.PostTags", "PostID", "dbo.Posts");
            DropForeignKey("dbo.Posts", "PostCatelogyID", "dbo.PostCatelogies");
            DropForeignKey("dbo.OrderDetails", "ProductID", "dbo.Products");
            DropForeignKey("dbo.Products", "ProductCatelogyID", "dbo.ProductCatelogies");
            DropForeignKey("dbo.OrderDetails", "OrderID", "dbo.Orders");
            DropForeignKey("dbo.Menus", "MenuGroupID", "dbo.MenuGroups");
            DropIndex("dbo.ProductTags", new[] { "TagID" });
            DropIndex("dbo.ProductTags", new[] { "ProductID" });
            DropIndex("dbo.PostTags", new[] { "TagID" });
            DropIndex("dbo.PostTags", new[] { "PostID" });
            DropIndex("dbo.Posts", new[] { "PostCatelogyID" });
            DropIndex("dbo.Products", new[] { "ProductCatelogyID" });
            DropIndex("dbo.OrderDetails", new[] { "ProductID" });
            DropIndex("dbo.OrderDetails", new[] { "OrderID" });
            DropIndex("dbo.Menus", new[] { "MenuGroupID" });
            DropTable("dbo.VisitorStatistics");
            DropTable("dbo.SystemConfigs");
            DropTable("dbo.SupportOnlines");
            DropTable("dbo.Sildes");
            DropTable("dbo.ProductTags");
            DropTable("dbo.Tags");
            DropTable("dbo.PostTags");
            DropTable("dbo.Posts");
            DropTable("dbo.PostCatelogies");
            DropTable("dbo.Pages");
            DropTable("dbo.ProductCatelogies");
            DropTable("dbo.Products");
            DropTable("dbo.Orders");
            DropTable("dbo.OrderDetails");
            DropTable("dbo.Menus");
            DropTable("dbo.MenuGroups");
            DropTable("dbo.Footers");
        }
    }
}
