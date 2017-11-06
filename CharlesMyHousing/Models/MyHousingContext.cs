using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Web;
using CharlesMyHousing.ViewModels;

namespace CharlesMyHousing.Models
{
    public class MyHousingContext : DbContext
    {
        public MyHousingContext()
            : base("name=MyHousingContext")
        {
        }

        public DbSet<HouseState> HouseStates { get; set; }
        public DbSet<RentCase> RentCases { get; set; }
        public DbSet<HousePicture> HousePictures { get; set; }
        public DbSet<SearchCondition> SearchConditions { get; set; }
        public DbSet<SearchResult> SearchResults { get; set; }
        public DbSet<DetailView> DetaukDetailViews { get; set; }
        public DbSet<SearchView> SearchViews { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }

}