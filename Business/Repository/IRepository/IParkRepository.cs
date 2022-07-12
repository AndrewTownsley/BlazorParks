using Models;

namespace Business.Repository.IRepository
{
    public interface IParkRepository
    {
        public Task<ParkDto> CreatePark(ParkDto parkDto);

        public Task<ParkDto> UpdatePark(int parkId, ParkDto parkDto);

        public Task<ParkDto> GetPark(int parkId);

        public Task<int> DeletePark(int parkId);

        public Task<IEnumerable<ParkDto>> GetAllParks();

        public Task<ParkDto> DuplicateParkNameCheck(string name);
    }
}
