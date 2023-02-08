/*
using Application.Features.EmployeeFeatures.Queries;
using Application.Interfaces;
using Dapper;
using Dapper.Context;
using Domain.Entities;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.EmployeeFeatures.Queries
{
    public class getAllEmployeesQuery
    {

        private readonly DapperContext _context;
        public getAllEmployeesQuery(DapperContext context)
        {
            _context = context;
        }
        
        public async Task<IEnumerable<Employee>> getAll()
        {
            var sql = "select * from employees";
            using (var connection = _context.CreateConnection())
            {
                var result = await connection.QueryAsync<Employee>(sql);
                return result.ToList();
            }
        }
    }

   
        
        
        
    
}*/


/* 
public class getAllEmployeesQueryHandler : IRequestHandler<getAllEmployeesQuery, IEnumerable<Employee>>
        {
            private DapperContext _context;
            public getAllEmployeesQueryHandler(DapperContext context)
            {
                _context = context;
            }
           
        }
 */

/*public async Task<IEnumerable<Employee>> Handle(getAllEmployeesQuery query, CancellationToken cancellatiotoken)
{



    var EmployeeList = await _context.employees.ToListAsync();


    return EmployeeList.AsReadOnly();

}*/

using Application.Features.EmployeeFeatures.Queries;
using Application.Interfaces;
using Dapper;
using Domain.Entities;
using Domain.QueriesInterface;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.EmployeeFeatures.Queries
{
    public class GetAllEmployeesQuery:IRequest<IEnumerable<Employee>>

    {
        public class GetAllEmployeesQueryHandler:IRequestHandler<GetAllEmployeesQuery,IEnumerable<Employee>>
        { 
            private readonly IEmployeeRepository _employeerepository;
            public GetAllEmployeesQueryHandler(IEmployeeRepository employeerepository)
            {
                _employeerepository= employeerepository;
            }
            public async Task<IEnumerable<Employee>> Handle(GetAllEmployeesQuery query, CancellationToken cancellationtoken)
            {
                var res = await _employeerepository.GetEmployees();
                return res;
            }
        }
        
    }
}