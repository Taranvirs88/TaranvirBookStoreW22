using System.Linq;
using TaranvirBookStore.DataAccess.Data;
using TaranvirBooks.DataAccess.Repository;
using TaranvirBooks.DataAccess.Repository.IRepository;
using TaranvirBooks.Models;

namespace TaranvirBookStore.DataAccess.Repository
{
    public class CoverTypeRepository : Repository<CoverType>, ICoverTypeRepository
    {
        private readonly ApplicationDbContext _db;
        public CoverTypeRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }

        public void Update(CoverType coverType)
        {
            var objFromDb = _db.Categories.FirstOrDefault(s => s.Id == coverType.Id);
            if (objFromDb != null)
            {
                objFromDb.Name = coverType.Name;
                _db.SaveChanges();
            }
        }
    }
}