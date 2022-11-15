using HotelListing.API.Data;

namespace HotelListing.API.IRepository
{
    public interface ICountriesRepository : IRepository<Country>
    {
        Task<Country> GetDetails(int id);
    }
}
