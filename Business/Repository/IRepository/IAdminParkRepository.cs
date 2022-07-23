using Models;

namespace Business.Repository.IRepository
{
    public interface IAdminParkRepository
    {
        // Create, Get Single, Get all, Update, Delete, Duplicate park Check
        Task<AdminParkDto> CreateAdminPark(AdminParkDto adminParkDto);

        Task<AdminParkDto> GetAdminPark(int AdminParkId);

        Task<IEnumerable<AdminParkDto>> GetAllAdminParks();

        Task<AdminParkDto> UpdateAdminPark(int AdminParkId, AdminParkDto adminParkDto);

        Task<int> DeleteAdminPark(int AdminParkId);

        Task<AdminParkDto> DuplicateAdminParkNameCheck(string name, int AdminParkId = 0);
    }
}
