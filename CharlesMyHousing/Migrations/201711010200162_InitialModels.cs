namespace CharlesMyHousing.Migrations
{
    using System;
    using System.Data.Entity.Migrations;

    public partial class InitialModel : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.HousePicture",
                c => new
                {
                    HousePictureId = c.Int(nullable: false, identity: true),
                    ImagePath = c.String(),
                    MainImgFlg = c.Int(),
                    HouseStateId = c.Int(nullable: false),
                })
                .PrimaryKey(t => t.HousePictureId)
                .ForeignKey("dbo.HouseState", t => t.HouseStateId, cascadeDelete: true)
                .Index(t => t.HouseStateId);

            CreateTable(
                "dbo.HouseState",
                c => new
                {
                    HouseStateId = c.Int(nullable: false, identity: true),
                    HouseType = c.Int(nullable: false),
                    Postcode = c.String(),
                    RentRate = c.Decimal(nullable: false, precision: 18, scale: 2),
                    MainAddress = c.String(),
                    Suburb = c.String(),
                    Region = c.String(),
                    Description = c.String(),
                    Bedroom = c.Int(),
                    Bathroom = c.Int(),
                    CarparkOk = c.Int(),
                    PetOk = c.Int(),
                    OnMarktetFlg = c.Int(nullable: false),
                    Latitude = c.Int(),
                    Longitude = c.Int(),
                })
                .PrimaryKey(t => t.HouseStateId);

            CreateTable(
                "dbo.RentCase",
                c => new
                {
                    RentCaseId = c.Int(nullable: false, identity: true),
                    StartDate = c.DateTime(nullable: false),
                    EndDate = c.DateTime(nullable: false),
                    UserId = c.Int(nullable: false),
                    HouseStateId = c.Int(nullable: false),
                })
                .PrimaryKey(t => t.RentCaseId)
                .ForeignKey("dbo.HouseState", t => t.HouseStateId, cascadeDelete: true)
                .Index(t => t.HouseStateId);

        }

        public override void Down()
        {
            DropForeignKey("dbo.RentCase", "HouseStateId", "dbo.HouseState");
            DropForeignKey("dbo.HousePicture", "HouseStateId", "dbo.HouseState");
            DropIndex("dbo.RentCase", new[] { "HouseStateId" });
            DropIndex("dbo.HousePicture", new[] { "HouseStateId" });
            DropTable("dbo.RentCase");
            DropTable("dbo.HouseState");
            DropTable("dbo.HousePicture");
        }
    }
}