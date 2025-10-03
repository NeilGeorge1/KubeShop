using PlatformService.Models;
using System.Linq;

namespace PlatformService.Data
{
    public class PlatformRepo : IPlatformRepo
    {
        private readonly AppDbContext _context;
        public PlatformRepo(AppDbContext context)
        {
            _context = context;
        }
        public void CreatePlatform(Platform plat)
        {
            if(plat == null)
            {
                return;
                //add throw exception later
            }

            _context.Platforms.Add(plat);
        }
        public IEnumerable<Platform> GetAllPlatforms()
        {
            return _context.Platforms.ToList();
        }
        public Platform GetPlatformById(int id)
        {
            return _context.Platforms.FirstOrDefault(p => p.Id == id);
        }

        //Needed everytime a change is done to the db
        public bool SaveChanges()
        {
            return (_context.SaveChanges() >= 0);
        }
    }
}