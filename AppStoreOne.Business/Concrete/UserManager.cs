using AppStoreOne.Business.Interfaces;
using AppStoreOne.DataAccess.Concrete.UOW;
using AppStoreOne.Entities.Concrete;

namespace AppStoreOne.Business.Concrete
{
    public class UserManager : GenericManager<User>, IUserService
    {
        public UserManager(IUnitOfWork uow) : base(uow)
        {

        }
    }
}
