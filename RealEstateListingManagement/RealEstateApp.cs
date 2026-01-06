using System;
using System.Collections.Generic;
using System.Text;

namespace RealEstateListingManagement
{
    internal class RealEstateApp 
    {
        private List<IRealEstateListing> listing = null;

        public void AddListing(IRealEstateListing list)
        {
            listing.Add(list);
        }

        public void RemoveListing(int listingID)
        {
            if(listingID != 0)
            {
                IRealEstateListing li = listing.Find(l => l.ID == listingID);
                if (li != null)
                {
                    listing.Remove(li);
                }
            }
        }

        public bool UpdateListing(int listingID, IRealEstateListing newList)
        {

            bool flag = false;
            if (listingID != 0 && newList != null)
            {
                IRealEstateListing li = listing.Find(l => l.ID == listingID);
                if (li != null)
                {
                    li.Title = newList.Title;
                    li.Description = newList.Description;
                    li.Location = newList.Location;
                    li.Price = newList.Price;

                    flag = true;
                }
            }
            return flag;
        }
            
        
        public List<IRealEstateListing> GetListings()
        {
            return listing; 
        }

        public List<IRealEstateListing> GetListingByLocation(string location)
        {
            return listing.FindAll(l => l.Location == location);
        }

        public List<IRealEstateListing> GetListingByPriceRange(int minPrice,int maxPrice)
        {
            return listing.FindAll(l => l.Price >= minPrice && l.Price < maxPrice);
        }



    }
     

}
