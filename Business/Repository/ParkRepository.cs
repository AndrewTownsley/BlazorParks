using AutoMapper;
using Business.Repository.IRepository;
using DataAccess.Data;
using Microsoft.EntityFrameworkCore;
using Models;

namespace Business.Repository
{
    public class ParkRepository : IParkRepository
    {

        private readonly ApplicationDbContext _db;
        private readonly IMapper _mapper;

        public ParkRepository(ApplicationDbContext db, IMapper mapper)
        {
            _db = db;
            _mapper = mapper;
        }

        public async Task<ParkDto> CreatePark(ParkDto parkDto)
        {
            Park park = _mapper.Map<ParkDto, Park>(parkDto);
            park.CreatedDate = DateTime.Now;
            park.CreatedBy = "";
            var addedPark = await _db.Parks.AddAsync(park);
            await _db.SaveChangesAsync();

            return _mapper.Map<Park, ParkDto>(addedPark.Entity);
        }

        public async Task<ParkDto> UpdatePark(int parkId, ParkDto parkDto)
        {
            try
            {
                if (parkId == parkDto.Id)
                {
                    Park parkDetails = await _db.Parks.FindAsync(parkId);
                    Park park = _mapper.Map<ParkDto, Park>(parkDto, parkDetails);
                    park.UpdatedBy = "";
                    park.UpdatedDate = DateTime.Now;
                    var updatedPark = _db.Parks.Update(park);
                    await _db.SaveChangesAsync();

                    return _mapper.Map<Park, ParkDto>(updatedPark.Entity);
                }
                else
                {
                    return null;
                }
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public async Task<ParkDto> GetPark(int parkId)
        {
            try
            {
                ParkDto park =
                    _mapper.Map<Park, ParkDto>(await _db.Parks.FirstOrDefaultAsync(item => item.Id == parkId));
                return park;
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public async Task<int> DeletePark(int parkId)
        {
            var parkDetails = await _db.Parks.FindAsync(parkId);
            if (parkDetails != null)
            {
                _db.Parks.Remove(parkDetails);
                return await _db.SaveChangesAsync();
            }
            return 0;
        }

        public async Task<IEnumerable<ParkDto>> GetAllParks()
        {
            try
            {
                IEnumerable<ParkDto> ParkDtos = _mapper.Map<IEnumerable<Park>, IEnumerable<ParkDto>>(
                    _db.Parks);
                return ParkDtos;
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public async Task<ParkDto> DuplicateParkNameCheck(string name)
        {
            try
            {
                ParkDto park =
                    _mapper.Map<Park, ParkDto>(
                        await _db.Parks.FirstOrDefaultAsync(item =>
                            item.Name.ToLower() == name.ToLower()));

                return park;
            }
            catch (Exception ex)
            {
                return null;
            }
        }
    }
}
