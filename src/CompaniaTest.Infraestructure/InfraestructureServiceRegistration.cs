using System;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Configuration;
using CompaniaTest.Application.Contracts;
using CompaniaTest.Infraestructure.Repository;
using CompaniaTest.Infraestructure.Context;
using Microsoft.EntityFrameworkCore;

namespace CompaniaTest.Infraestructure;

public static class InfraestructureServiceRegistration
{
    public static IServiceCollection AddInfraestructureServices(this IServiceCollection services, IConfiguration configuration) {
        services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());

        services.AddScoped<ICompaniaContract, CompaniaRepository>();

        services.AddDbContext<CompaniaContext>(opt => opt.UseSqlServer(configuration.GetConnectionString("conexion_db")));

        return services;
    }
}
