using HotelListing.API.Data;
using HotelListing.API.IRepository;
using Microsoft.EntityFrameworkCore;

namespace HotelListing.API.Repository
{
    public class HotelsRepository : Repository<Hotel>, IHotelsRepository
    {
        private readonly HotelListingDbContext _context;
        public HotelsRepository(HotelListingDbContext context) : base(context)
        {
            this._context = context;
        }

        public async Task<Hotel> GetHotelDetails(int id)
        {
            return await _context.Hotels.FirstOrDefaultAsync(q => q.Id == id);
        }
    }
}
