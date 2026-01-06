using System;
using System.Collections.Generic;
using System.Text;

namespace RealEstateListingManagement
{
    internal class RealEstateListing : IRealEstateListing
    {
        public int ID { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public int Price { get; set; }
        public string Location { get; set; }

    }
}
