using AppStoreOne.Business.Interfaces;
using AppStoreOne.DataAccess.Concrete.UOW;
using AppStoreOne.Entities.Concrete;

namespace AppStoreOne.Business.Concrete
{
    public class EstateManager : GenericManager<Estate>, IEstateService
    {
        public EstateManager(IUnitOfWork uow) : base(uow)
        {

        }
    }
}
