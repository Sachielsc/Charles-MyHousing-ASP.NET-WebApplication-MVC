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
        public ActionResult SearchViewPage()
        {
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
                        Text = @"5 rooms",
                        Value = "5"
                    },
                    new SelectListItem
                    {
                        Text = @"6 rooms",
                        Value = "6"
                    }
                };

            var searchViewModel = new SearchViewModel
            { 
                SelectListItems = selectListItems
            };

            return View(searchViewModel);
        }
    }
}