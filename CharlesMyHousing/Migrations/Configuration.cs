using CharlesMyHousing.Models;

namespace CharlesMyHousing.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<CharlesMyHousing.Models.MyHousingContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(CharlesMyHousing.Models.MyHousingContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data.

            context.HouseStates.AddOrUpdate(x => x.HouseName,
                new HouseState
                {
                    // HouseStateId = 1,
                    HouseName = "My Auckland Address",
                    HouseType = 1,
                    Postcode = "0600",
                    RentRate = 0.8m,
                    MainAddress = "6/14 Ambrico Place",
                    Suburb = "New Lynn",
                    Region = "Auckland",
                    Description = "My Auckland Address",
                    Bedroom = 3,
                    Bathroom = 2,
                    CarparkOk = true,
                    PetOk = false,
                    OnMarktetFlg = true,
                    Latitude = 0,
                    Longitude = 0
                },
                new HouseState
                {
                    // HouseStateId = 2,
                    HouseName = "My Christchurch Address",
                    HouseType = 1,
                    Postcode = "8042",
                    RentRate = 0.9m,
                    MainAddress = "26 Valiant Street",
                    Suburb = "Wigram",
                    Region = "Christchurch",
                    Description = "My Christchurch Address",
                    Bedroom = 2,
                    Bathroom = 2,
                    CarparkOk = true,
                    PetOk = false,
                    OnMarktetFlg = true,
                    Latitude = 0,
                    Longitude = 0
                },
                new HouseState
                {
                    // HouseStateId = 3,
                    HouseName = "My Wellington Address",
                    HouseType = 1,
                    Postcode = "6037",
                    RentRate = 1.0m,
                    MainAddress = "11 Angell St",
                    Suburb = "Johnsonville",
                    Region = "Wellington",
                    Description = "My Wellington Address",
                    Bedroom = 4,
                    Bathroom = 2,
                    CarparkOk = true,
                    PetOk = false,
                    OnMarktetFlg = true,
                    Latitude = 0,
                    Longitude = 0
                }
            );
        }
    }
}
