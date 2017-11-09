namespace CharlesMyHousing.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateRemainingDataToSearchOption : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO SearchOption (GroupName, ItemValue, ItemName) VALUES ('Location', 2, 'Christchurch')");
            Sql("INSERT INTO SearchOption (GroupName, ItemValue, ItemName) VALUES ('Location', 3, 'Wellington')");
            Sql("INSERT INTO SearchOption (GroupName, ItemValue, ItemName) VALUES ('Location', 4, 'Hamilton')");
            Sql("INSERT INTO SearchOption (GroupName, ItemValue, ItemName) VALUES ('House Type', 1, 'House')");
            Sql("INSERT INTO SearchOption (GroupName, ItemValue, ItemName) VALUES ('House Type', 2, 'Townhouse')");
            Sql("INSERT INTO SearchOption (GroupName, ItemValue, ItemName) VALUES ('House Type', 3, 'Unit')");
            Sql("INSERT INTO SearchOption (GroupName, ItemValue, ItemName) VALUES ('House Type', 4, 'Apartment')");
        }

        public override void Down()
        {
        }
    }
}
