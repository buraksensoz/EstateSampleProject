using AppStoreOne.DataAccess.Concrete.EfCore.Context;
using AppStoreOne.DataAccess.Interfaces;
using AppStoreOne.Entities.Concrete;

namespace AppStoreOne.DataAccess.Concrete.EfCore.Repositories
{
    public class UserRepository : GenericRepository<User>, IUserDal
    {
        public UserRepository(AppDbContext context) : base(context)
        {

        }
    }
}
