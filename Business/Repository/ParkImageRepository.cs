using AutoMapper;
using Business.Repository.IRepository;
using DataAccess.Data;
using Microsoft.EntityFrameworkCore;
using Models;

namespace Business.Repository
{
    public class ParkImageRepository : IParkImageRepository
    {
        private readonly ApplicationDbContext _db;
        private readonly IMapper _mapper;

        public ParkImageRepository(ApplicationDbContext db, IMapper mapper)
        {
            _mapper = mapper;
            _db = db;
        }
        public async Task<int> CreateParkImage(ParkImageDto imageDto)
        {
            var image = _mapper.Map<ParkImageDto, ParkImage>(imageDto);
            _db.ParkImages.AddAsync(image);
            return await _db.SaveChangesAsync();
        }

        public async Task<int> DeleteParkImageByImageId(int imageId)
        {
            var image = await _db.ParkImages.FindAsync(imageId);
            _db.ParkImages.Remove(image);
            return await _db.SaveChangesAsync();
        }

        public async Task<int> DeleteParkImageByParkId(int parkId)
        {
            var image = await _db.ParkImages.FindAsync(parkId);
            _db.ParkImages.Remove(image);
            return await _db.SaveChangesAsync();
        }

        public async Task<IEnumerable<ParkImageDto>> GetParkImages(int parkId)
        {
            return _mapper.Map<IEnumerable<ParkImage>, IEnumerable<ParkImageDto>>(
                await _db.ParkImages.Where(x => x.ParkId == parkId).ToListAsync());
        }
    }
}
