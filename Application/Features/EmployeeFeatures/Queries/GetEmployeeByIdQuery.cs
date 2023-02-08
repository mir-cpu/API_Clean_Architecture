using Application.Interfaces;
using Domain.Entities;
using Domain.QueriesInterface;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.EmployeeFeatures.Queries
{
    public class GetEmployeeByIdQuery:IRequest<Employee>
    {
        public int Id { get; set; }
        public class GetEmployeeByIdQueryHandler : IRequestHandler<GetEmployeeByIdQuery, Employee>
        {
            private IEmployeeRepository _employeerepository;
            public GetEmployeeByIdQueryHandler(IEmployeeRepository employeerepository)
            {
                _employeerepository= employeerepository;
            }
            public async Task<Employee> Handle(GetEmployeeByIdQuery query,CancellationToken cancellationtoken)
            {
                var res = await _employeerepository.GetEmployeeById(query.Id);
                return res;
            }
        }
    }
}
