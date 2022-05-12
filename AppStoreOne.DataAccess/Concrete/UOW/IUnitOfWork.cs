using AppStoreOne.DataAccess.Interfaces;
using AppStoreOne.Entities;
using System.Threading.Tasks;

namespace AppStoreOne.DataAccess.Concrete.UOW
{
    public interface IUnitOfWork
    {
        ICustomerDal CustomerDal { get; set; }
        IUserDal UserDal { get; set; }
        IEstateDal EstateDal { get; set; }
        Task SaveChanges();
        IGenericDal<TEntity> GetRepository<TEntity>() where TEntity : class, ITable, new();
    }
}
