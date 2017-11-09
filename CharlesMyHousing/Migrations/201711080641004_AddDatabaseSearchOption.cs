namespace CharlesMyHousing.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddDatabaseSearchOption : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.SearchOption",
                c => new
                    {
                        SearchOptionId = c.Int(nullable: false, identity: true),
                        GroupName = c.String(),
                        ItemValue = c.Int(nullable: false),
                        ItemName = c.String(),
                    })
                .PrimaryKey(t => t.SearchOptionId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.SearchOption");
        }
    }
}
