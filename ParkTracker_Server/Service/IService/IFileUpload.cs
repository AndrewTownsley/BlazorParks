using Microsoft.AspNetCore.Components.Forms;

namespace ParkTracker_Server.Service.IService
{
    public interface IFileUpload
    {
        Task<string> UploadFile(IBrowserFile file);

        bool DeleteFile(string fileName);
    }
}
