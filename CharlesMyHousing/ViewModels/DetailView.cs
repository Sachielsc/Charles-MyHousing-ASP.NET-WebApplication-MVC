using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using CharlesMyHousing.Models;

namespace CharlesMyHousing.ViewModels
{
    public class DetailView
    {
        // house information
        public virtual HouseState HouseState{ set; get; }

        // house image list
        public virtual List<HousePicture> HousePictures { set; get; }

        // house renting list from today
        public virtual List<RentCase> RentCases { set; get; }
    }
}