using Business.Repository.IRepository;
using Models;

namespace Business.Repository
{
    public class AdminParkRepository : IAdminParkRepository
    {
        public Task<AdminParkDto> CreateAdminPark(AdminParkDto adminParkDto)
        {
            throw new NotImplementedException();
        }

        public Task<int> DeleteAdminPark(int AdminParkId)
        {
            throw new NotImplementedException();
        }

        public Task<AdminParkDto> DuplicateAdminParkNameCheck(string name, int AdminParkId = 0)
        {
            throw new NotImplementedException();
        }

        public Task<AdminParkDto> GetAdminPark(int AdminParkId)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<AdminParkDto>> GetAllAdminParks()
        {
            throw new NotImplementedException();
        }

        public Task<AdminParkDto> UpdateAdminPark(int AdminParkId, AdminParkDto adminParkDto)
        {
            throw new NotImplementedException();
        }
    }
}
