using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CharlesMyHousing.Models;

namespace CharlesMyHousing.ViewModels
{
    public class SearchViewModel
    {
        public virtual SearchCondition SearchCondition { set; get; }
        public virtual IList<SearchOption> LocationList { get; set; }
        public virtual IList<SearchOption> HouseTypeList { get; set; }
        public virtual IList<SelectListItem> SelectListItems { get; set; }

        // public virtual IPagedList<SearchResult> SearchResults { set; get; }
    }
}