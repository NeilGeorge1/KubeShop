using PlatformService.Models;

//interface to create multiple instances if needed

namespace PlatformService.Data
{
    public interface IPlatformRepo 
    {
        bool SaveChanges();

        IEnumerable<Platform> GetAllPlatforms();

        Platform GetPlatformById(int id);

        void CreatePlatform(Platform plat);
    }
}