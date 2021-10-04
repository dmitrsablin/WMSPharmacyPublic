namespace WMSPharmacy.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ZeroMigaration : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.History",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        UserName = c.Int(nullable: false),
                        Medicines = c.Int(nullable: false),
                        WasQuantity = c.Int(nullable: false),
                        HasQuantity = c.Int(nullable: false),
                        DateOfChange = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Medicines", t => t.Medicines)
                .ForeignKey("dbo.Users", t => t.UserName)
                .Index(t => t.UserName)
                .Index(t => t.Medicines);
            
            CreateTable(
                "dbo.Medicines",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        MedicineName = c.String(nullable: false, maxLength: 255, unicode: false),
                        Manufacturer = c.Int(nullable: false),
                        MedicinesType = c.Int(nullable: false),
                        Quantity = c.Int(nullable: false),
                        Price = c.Double(nullable: false),
                        Description = c.String(nullable: false, maxLength: 2048, unicode: false),
                        Structure = c.String(nullable: false, maxLength: 2048, unicode: false),
                        Diseases = c.String(nullable: false, maxLength: 2048, unicode: false),
                        IsDrug = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Manufacturers", t => t.Manufacturer)
                .ForeignKey("dbo.MedicinesTypes", t => t.MedicinesType)
                .Index(t => t.Manufacturer)
                .Index(t => t.MedicinesType);
            
            CreateTable(
                "dbo.Manufacturers",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        ManufacturerName = c.String(nullable: false, maxLength: 255, unicode: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.MedicinesTypes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        MedicinesTypeName = c.String(nullable: false, maxLength: 255, unicode: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        LastName = c.String(nullable: false, maxLength: 255, unicode: false),
                        FirstName = c.String(nullable: false, maxLength: 255, unicode: false),
                        MiddleName = c.String(maxLength: 255, unicode: false),
                        UserRole = c.Int(nullable: false),
                        Email = c.String(nullable: false, maxLength: 255, unicode: false),
                        Password = c.String(nullable: false, maxLength: 255, unicode: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.UserRoles", t => t.UserRole)
                .Index(t => t.UserRole);
            
            CreateTable(
                "dbo.UserRoles",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        NameRole = c.String(nullable: false, maxLength: 255, unicode: false),
                    })
                .PrimaryKey(t => t.Id);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Users", "UserRole", "dbo.UserRoles");
            DropForeignKey("dbo.History", "UserName", "dbo.Users");
            DropForeignKey("dbo.Medicines", "MedicinesType", "dbo.MedicinesTypes");
            DropForeignKey("dbo.Medicines", "Manufacturer", "dbo.Manufacturers");
            DropForeignKey("dbo.History", "Medicines", "dbo.Medicines");
            DropIndex("dbo.Users", new[] { "UserRole" });
            DropIndex("dbo.Medicines", new[] { "MedicinesType" });
            DropIndex("dbo.Medicines", new[] { "Manufacturer" });
            DropIndex("dbo.History", new[] { "Medicines" });
            DropIndex("dbo.History", new[] { "UserName" });
            DropTable("dbo.UserRoles");
            DropTable("dbo.Users");
            DropTable("dbo.MedicinesTypes");
            DropTable("dbo.Manufacturers");
            DropTable("dbo.Medicines");
            DropTable("dbo.History");
        }
    }
}
