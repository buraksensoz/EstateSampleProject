using AppStoreOne.Business.Concrete;
using AppStoreOne.Business.Interfaces;
using AppStoreOne.Business.Validation;
using AppStoreOne.Business.Validation.EstateValidator;
using AppStoreOne.DataAccess.Concrete.EfCore.Context;
using AppStoreOne.DataAccess.Concrete.EfCore.Repositories;
using AppStoreOne.DataAccess.Concrete.UOW;
using AppStoreOne.DataAccess.Interfaces;
using AppStoreOne.Dtos.Dtos;
using AppStoreOne.Dtos.EstateTypeDtos;
using FluentValidation;
using Microsoft.Extensions.DependencyInjection;

namespace AppStoreOne.Business.Extentions
{
    public static class CustomIOCExtentions
    {
        public static void AddDependensies(this IServiceCollection services)
        {
            services.AddDbContext<AppDbContext>();
            services.AddScoped(typeof(IGenericDal<>), typeof(GenericRepository<>));
            services.AddScoped(typeof(IGenericService<>), typeof(GenericManager<>));
            services.AddScoped<ICustomerDal, CustomerRepository>();
            services.AddScoped<IUserDal, UserRepository>();
            services.AddScoped<IEstateDal, EstateRepository>();
            services.AddScoped<ICustomerService, CustomerManager>();
            services.AddScoped<IUserService, UserManager>();
            services.AddScoped<IEstateService, EstateManager>();
            services.AddScoped<IUnitOfWork, UnitOfWork>();
            services.AddTransient<IValidator<UserAddDto>, UserAddDtoValidator>();
            services.AddTransient<IValidator<UserUpdateDto>, UserUpdateDtoValidator>();
            services.AddTransient<IValidator<CustomerAddDto>, CustomerAddDtoValidator>();
            services.AddTransient<IValidator<CustomerUpdateDto>, CustomerUpdateDtoValidator>();
            services.AddTransient<IValidator<EstateDaireDto>, EstateDaireDtoValidator>();

        }
    }
}
