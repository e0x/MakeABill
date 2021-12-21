using MakeABill.Application.Interfaces;
using MakeABill.Infraestrecture.Context;
using MakeABill.Infraestrecture.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace MakeABill.Infraestructure.ServicesInjection
{
    public static class ServicesExtensions
    {
        public static void AddInfraestructure(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<MakeABillApiDbContext>(Op => Op.UseSqlServer(configuration.GetConnectionString("default"), x => x.MigrationsAssembly(typeof(MakeABillApiDbContext).Assembly.FullName)));
            services.AddTransient(typeof(IGenericRepository<>), typeof(GenericRepository<>));
        }
    }
}
