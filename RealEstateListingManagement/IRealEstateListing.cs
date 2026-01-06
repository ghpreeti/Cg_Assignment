namespace RealEstateListingManagement
{
    internal interface IRealEstateListing
    {
        int ID { get; set; }
        string Title { get; set; }
        string Description { get; set; }
        string Location { get; set; }
        int Price { get; set; }
    }
}