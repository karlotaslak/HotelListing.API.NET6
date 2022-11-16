using HotelListing.API.Data;

namespace HotelListing.API.IRepository
{
    public interface IHotelsRepository : IRepository<Hotel>
    {
       // Task<Hotel> GetHotelDetails(int id);
    }
}
