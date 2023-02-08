using DapperProj.Context;
using DapperProj.Repository;
using Domain.QueriesInterface;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DapperProj
{
    public static class DependencyInjection
    {
        public static void AddDapper( this IServiceCollection services)
        {
            services.AddSingleton<DapperContext>();
            services.AddScoped<IEmployeeRepository, EmployeeRepository>();
        }
    }
}
