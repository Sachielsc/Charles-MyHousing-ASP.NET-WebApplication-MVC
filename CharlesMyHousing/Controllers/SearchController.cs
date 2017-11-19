using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CharlesMyHousing.Models;
using CharlesMyHousing.ViewModels;

namespace CharlesMyHousing.Controllers
{
    public class SearchController : Controller
    {
        private MyHousingContext db = new MyHousingContext();

        private void InitilizeSearchViewCondition(SearchViewModel searchViewModel)
        {
            // Declare the location list in searchoptions
            var locationList = (from pk in db.SearchOptions
                where pk.GroupName == "Location"
                orderby pk.SearchOptionId
                select pk).ToList();

            // Declare the location list in searchoptions
            var houseTypeList = (from pk in db.SearchOptions
                where pk.GroupName == "House Type"
                orderby pk.SearchOptionId
                select pk).ToList();

            // Declare the number list of room selections
            List<SelectListItem> selectListItems
                = new List<SelectListItem>
                {
                    new SelectListItem
                    {
                        Text = @"1 room",
                        Value = "1"
                    },
                    new SelectListItem
                    {
                        Text = @"2 rooms",
                        Value = "2"
                    },
                    new SelectListItem
                    {
                        Text = @"3 rooms",
                        Value = "3"
                    },
                    new SelectListItem
                    {
                        Text = @"4 rooms",
                        Value = "4"
                    },
                    new SelectListItem
                    {
                        Text = @"more rooms",
                        Value = "5"
                    }
                };

            searchViewModel.SelectListItems = selectListItems;
            searchViewModel.LocationList = locationList;
            searchViewModel.HouseTypeList = houseTypeList;
        }

        public ActionResult SearchViewPage()
        {
            SearchViewModel searchViewModel = new SearchViewModel();
            InitilizeSearchViewCondition(searchViewModel);
            return View(searchViewModel);
        }

        public ActionResult SearchResultListViewPage(SearchViewModel searchViewModel, string actionButton)
        {
            switch (actionButton)
            {
                case "btnSearch":
                    // search action
                    break;
            }

            return View();
        }
    }
}