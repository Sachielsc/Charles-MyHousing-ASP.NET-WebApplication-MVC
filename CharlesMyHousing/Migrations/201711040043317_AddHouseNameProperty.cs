namespace CharlesMyHousing.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddHouseNameProperty : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.HouseState", "HouseName", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.HouseState", "HouseName");
        }
    }
}
