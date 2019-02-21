namespace PetroTech.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _21022019 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Logs",
                c => new
                    {
                        ErrorId = c.Guid(nullable: false),
                        MessageError = c.String(),
                        StackTrance = c.String(),
                        CreatedDateTime = c.DateTime(),
                    })
                .PrimaryKey(t => t.ErrorId);
            
            CreateTable(
                "dbo.Roles",
                c => new
                    {
                        RoleId = c.Guid(nullable: false),
                        RoleName = c.String(nullable: false, maxLength: 250),
                        isSystemRole = c.Boolean(nullable: false),
                        CreateDateTime = c.DateTime(),
                        CreatedBy = c.String(maxLength: 250),
                        LastUpdatedDateTime = c.DateTime(),
                        LastUpdatedBy = c.String(maxLength: 250),
                    })
                .PrimaryKey(t => t.RoleId);
            
            CreateTable(
                "dbo.UserPasswords",
                c => new
                    {
                        UserPasswordId = c.Guid(nullable: false),
                        CompanyCode = c.String(nullable: false),
                        UserId = c.Guid(nullable: false),
                        Password = c.String(nullable: false),
                        LoginCountTime = c.Int(nullable: false),
                        isLock = c.Boolean(nullable: false),
                        CreateDateTime = c.DateTime(),
                        CreatedBy = c.String(maxLength: 250),
                        LastUpdatedDateTime = c.DateTime(),
                        LastUpdatedBy = c.String(maxLength: 250),
                    })
                .PrimaryKey(t => t.UserPasswordId)
                .ForeignKey("dbo.Users", t => t.UserId, cascadeDelete: true)
                .Index(t => t.UserId);
            
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        UserId = c.Guid(nullable: false),
                        CompanyCode = c.String(nullable: false),
                        UserName = c.String(nullable: false, maxLength: 256),
                        FullName = c.String(nullable: false, maxLength: 256),
                        Email = c.String(nullable: false, maxLength: 256),
                        Address = c.String(nullable: false, maxLength: 256),
                        Phone = c.Int(nullable: false),
                        Status = c.String(nullable: false),
                        CreateDateTime = c.DateTime(),
                        CreatedBy = c.String(maxLength: 250),
                        LastUpdatedDateTime = c.DateTime(),
                        LastUpdatedBy = c.String(maxLength: 250),
                    })
                .PrimaryKey(t => t.UserId);
            
            CreateTable(
                "dbo.UserRoles",
                c => new
                    {
                        UserRoleId = c.Guid(nullable: false),
                        RoleId = c.Guid(nullable: false),
                        UserId = c.Guid(nullable: false),
                        LastUpdatedDatetime = c.DateTime(),
                    })
                .PrimaryKey(t => t.UserRoleId)
                .ForeignKey("dbo.Roles", t => t.RoleId, cascadeDelete: true)
                .ForeignKey("dbo.Users", t => t.UserId, cascadeDelete: true)
                .Index(t => t.RoleId)
                .Index(t => t.UserId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.UserRoles", "UserId", "dbo.Users");
            DropForeignKey("dbo.UserRoles", "RoleId", "dbo.Roles");
            DropForeignKey("dbo.UserPasswords", "UserId", "dbo.Users");
            DropIndex("dbo.UserRoles", new[] { "UserId" });
            DropIndex("dbo.UserRoles", new[] { "RoleId" });
            DropIndex("dbo.UserPasswords", new[] { "UserId" });
            DropTable("dbo.UserRoles");
            DropTable("dbo.Users");
            DropTable("dbo.UserPasswords");
            DropTable("dbo.Roles");
            DropTable("dbo.Logs");
        }
    }
}
