namespace CharlesMyHousing.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class TryToPopulateRentCaseTable : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO RentCase (StartDate, EndDate, UserId, HouseStateId) VALUES ('2017/11/26', '2017/11/27', 1, 23)");
            Sql("INSERT INTO RentCase (StartDate, EndDate, UserId, HouseStateId) VALUES ('2017/11/27', '2017/11/28', 1, 23)");
            Sql("INSERT INTO RentCase (StartDate, EndDate, UserId, HouseStateId) VALUES('2017/11/28', '2017/12/31', 1, 22)");
            Sql("INSERT INTO RentCase (StartDate, EndDate, UserId, HouseStateId) VALUES('2017/12/10', '2017/12/11', 2, 23)");
            Sql("INSERT INTO RentCase (StartDate, EndDate, UserId, HouseStateId) VALUES('2017/12/11', '2017/12/12', 3, 23)");
            Sql("INSERT INTO RentCase (StartDate, EndDate, UserId, HouseStateId) VALUES('2017/12/10', '2017/12/11', 4, 24)");
            Sql("INSERT INTO RentCase (StartDate, EndDate, UserId, HouseStateId) VALUES('2017/12/11', '2017/12/12', 5, 24)");
        }

        public override void Down()
        {
        }
    }
}
