using HotelListing.API.Data;

namespace HotelListing.API.Contracts
{
    public interface ICountriesRepository: IGenricRepository<Country> 
    {
        Task<Country> GetDetails(int id);
    }
    }
