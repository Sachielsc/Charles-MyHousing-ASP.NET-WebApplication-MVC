using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using CharlesMyHousing.Models;
using PagedList;

namespace CharlesMyHousing.ViewModels
{
    public class SearchView
    {
        public virtual SearchCondition SearchCondition{ set; get; }
        public virtual IPagedList<SearchView> SearchViews { set; get; }
    }
}