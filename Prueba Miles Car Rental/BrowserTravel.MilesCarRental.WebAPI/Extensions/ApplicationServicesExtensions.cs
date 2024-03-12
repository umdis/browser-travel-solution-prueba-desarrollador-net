namespace BrowserTravel.MilesCarRental.WebAPI.Extensions;

public static class ApplicationServicesExtensions
{
    public static IServiceCollection AddApplicationServices(this IServiceCollection services)
    {
        services.AddScoped<IUnitOfWork, UnitOfWork>();
        services.AddScoped(typeof(IGenericRepository<>), typeof(GenericRepository<>));
        services.AddScoped(typeof(IRentService), typeof(RentService));
        services.AddScoped(typeof(IRentRepository), typeof(RentRepository));

        return services;
    }
}