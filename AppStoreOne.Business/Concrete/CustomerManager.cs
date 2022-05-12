using AppStoreOne.Business.Interfaces;
using AppStoreOne.DataAccess.Concrete.UOW;
using AppStoreOne.Entities.Concrete;

namespace AppStoreOne.Business.Concrete
{
    public class CustomerManager : GenericManager<Customer>, ICustomerService
    {
        public CustomerManager(IUnitOfWork uow) : base(uow)
        {

        }
    }
}
