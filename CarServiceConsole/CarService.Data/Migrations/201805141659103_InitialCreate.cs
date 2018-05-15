namespace CarService.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Brand",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        ModelId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Model",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        BrandId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Brand", t => t.BrandId, cascadeDelete: true)
                .Index(t => t.BrandId);
            
            CreateTable(
                "dbo.Car",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        VIN = c.String(),
                        RegistrationPlateNumber = c.String(),
                        Color = c.Int(nullable: false),
                        UserId = c.Int(nullable: false),
                        Brand_Id = c.Int(),
                        Model_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Brand", t => t.Brand_Id)
                .ForeignKey("dbo.Model", t => t.Model_Id)
                .ForeignKey("dbo.User", t => t.UserId, cascadeDelete: true)
                .Index(t => t.UserId)
                .Index(t => t.Brand_Id)
                .Index(t => t.Model_Id);
            
            CreateTable(
                "dbo.RepairWork",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        RepairDate = c.DateTime(nullable: false),
                        Description = c.String(),
                        Price = c.Decimal(nullable: false, precision: 18, scale: 2),
                        CarId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Car", t => t.CarId, cascadeDelete: true)
                .Index(t => t.CarId);
            
            CreateTable(
                "dbo.User",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(maxLength: 60),
                        IdNumber = c.Long(nullable: false),
                        UniqueIdNumber = c.String(maxLength: 10),
                        Address = c.String(),
                        Gender = c.Int(nullable: false),
                        PhoneNumber = c.String(),
                        Email = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Car", "UserId", "dbo.User");
            DropForeignKey("dbo.RepairWork", "CarId", "dbo.Car");
            DropForeignKey("dbo.Car", "Model_Id", "dbo.Model");
            DropForeignKey("dbo.Car", "Brand_Id", "dbo.Brand");
            DropForeignKey("dbo.Model", "BrandId", "dbo.Brand");
            DropIndex("dbo.RepairWork", new[] { "CarId" });
            DropIndex("dbo.Car", new[] { "Model_Id" });
            DropIndex("dbo.Car", new[] { "Brand_Id" });
            DropIndex("dbo.Car", new[] { "UserId" });
            DropIndex("dbo.Model", new[] { "BrandId" });
            DropTable("dbo.User");
            DropTable("dbo.RepairWork");
            DropTable("dbo.Car");
            DropTable("dbo.Model");
            DropTable("dbo.Brand");
        }
    }
}
