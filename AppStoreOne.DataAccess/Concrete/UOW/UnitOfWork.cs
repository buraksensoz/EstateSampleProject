using AppStoreOne.DataAccess.Concrete.EfCore.Context;
using AppStoreOne.DataAccess.Concrete.EfCore.Repositories;
using AppStoreOne.DataAccess.Interfaces;
using AppStoreOne.Entities;
using System.Threading.Tasks;

namespace AppStoreOne.DataAccess.Concrete.UOW
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly AppDbContext _context;
        public ICustomerDal CustomerDal { get; set; }
        public IUserDal UserDal { get; set; }
        public IEstateDal EstateDal { get; set; }

        public UnitOfWork(AppDbContext context)
        {
            _context = context;
            CustomerDal = new CustomerRepository(context);
            UserDal = new UserRepository(context);
            EstateDal = new EstateRepository(context);
        }

        public IGenericDal<TEntity> GetRepository<TEntity>() where TEntity : class, ITable, new()
        {

            return new GenericRepository<TEntity>(_context);
        }

        public async Task SaveChanges()
        {
            await _context.SaveChangesAsync();

        }
    }
}
