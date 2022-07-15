using Models;

namespace Business.Repository.IRepository
{
    public interface IParkImageRepository
    {
        public Task<int> CreateParkImage(ParkImageDto image);

        public Task<int> DeleteParkImageByImageId(int imageId);

        public Task<int> DeleteParkImageByParkId(int parkId);

        public Task<IEnumerable<ParkImageDto>> GetParkImages(int parkId);
    }
}
