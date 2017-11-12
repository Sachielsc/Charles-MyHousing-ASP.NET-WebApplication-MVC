namespace CharlesMyHousing.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateHousePictureTable : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO HousePicture (ImagePath, MainImgFlg, HouseStateId) VALUES ('Content/Images/house_1.jpg', null, 22)");
            Sql("INSERT INTO HousePicture (ImagePath, MainImgFlg, HouseStateId) VALUES ('Content/Images/house_2.jpg', null, 23)");
            Sql("INSERT INTO HousePicture (ImagePath, MainImgFlg, HouseStateId) VALUES ('Content/Images/house_3.jpg', null, 24)");
        }
        
        public override void Down()
        {
        }
    }
}
