namespace CharlesMyHousing.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ChangeVariableTypeToBoolean : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.HousePicture", "MainImgFlg", c => c.Boolean());
            AlterColumn("dbo.HouseState", "CarparkOk", c => c.Boolean());
            AlterColumn("dbo.HouseState", "PetOk", c => c.Boolean());
            AlterColumn("dbo.HouseState", "OnMarktetFlg", c => c.Boolean());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.HouseState", "OnMarktetFlg", c => c.Int(nullable: false));
            AlterColumn("dbo.HouseState", "PetOk", c => c.Int());
            AlterColumn("dbo.HouseState", "CarparkOk", c => c.Int());
            AlterColumn("dbo.HousePicture", "MainImgFlg", c => c.Int());
        }
    }
}
