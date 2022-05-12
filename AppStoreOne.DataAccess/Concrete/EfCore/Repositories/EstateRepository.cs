using AppStoreOne.DataAccess.Concrete.EfCore.Context;
using AppStoreOne.DataAccess.Interfaces;
using AppStoreOne.Entities.Concrete;

namespace AppStoreOne.DataAccess.Concrete.EfCore.Repositories
{
    public class EstateRepository : GenericRepository<Estate>, IEstateDal
    {
        public EstateRepository(AppDbContext context) : base(context)
        {

        }
    }
}
