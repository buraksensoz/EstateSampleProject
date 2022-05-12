using AppStoreOne.DataAccess.Concrete.EfCore.Context;
using AppStoreOne.DataAccess.Interfaces;
using AppStoreOne.Entities.Concrete;

namespace AppStoreOne.DataAccess.Concrete.EfCore.Repositories
{
    public class CustomerRepository : GenericRepository<Customer>, ICustomerDal
    {
        public CustomerRepository(AppDbContext context) : base(context)
        {

        }
    }
}
