namespace CharlesMyHousing.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class MinorChanges : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.HousePicture", "HouseStateId", "dbo.HouseState");
            DropForeignKey("dbo.RentCase", "HouseStateId", "dbo.HouseState");
            DropPrimaryKey("dbo.HouseState");
            AlterColumn("dbo.HouseState", "HouseStateId", c => c.Int(nullable: false, identity: true));
            AddPrimaryKey("dbo.HouseState", "HouseStateId");
            AddForeignKey("dbo.HousePicture", "HouseStateId", "dbo.HouseState", "HouseStateId", cascadeDelete: true);
            AddForeignKey("dbo.RentCase", "HouseStateId", "dbo.HouseState", "HouseStateId", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.RentCase", "HouseStateId", "dbo.HouseState");
            DropForeignKey("dbo.HousePicture", "HouseStateId", "dbo.HouseState");
            DropPrimaryKey("dbo.HouseState");
            AlterColumn("dbo.HouseState", "HouseStateId", c => c.Int(nullable: false));
            AddPrimaryKey("dbo.HouseState", "HouseStateId");
            AddForeignKey("dbo.RentCase", "HouseStateId", "dbo.HouseState", "HouseStateId", cascadeDelete: true);
            AddForeignKey("dbo.HousePicture", "HouseStateId", "dbo.HouseState", "HouseStateId", cascadeDelete: true);
        }
    }
}
