using Microsoft.ApplicationInsights.Extensibility.Implementation;

namespace CharlesMyHousing.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateSearchOptionTable : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO SearchOption (GroupName, ItemValue, ItemName) VALUES ('Location', 1, 'Auckland')");
        }
        
        public override void Down()
        {
        }
    }
}
