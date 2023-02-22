using System.ComponentModel.DataAnnotations.Schema;

namespace HotelListing.API.Models.Country
{
    public class GetCountryDto: BaseCountryDto
    {
        public int Id { get; set; }
        //public string Name { get; set; }
        //public string ShortName { get; set; }

    }


}
