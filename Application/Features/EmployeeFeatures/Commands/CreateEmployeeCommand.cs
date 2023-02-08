using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Application.Interfaces;
using Domain.Entities;
using Domain.QueriesInterface;
using MediatR;

namespace Application.Features.EmployeeFeatures.Commands
{
    public class CreateEmployeeCommand:IRequest<Employee>
    {
        public int Id { get; set; } 
        public string? ename { get; set; }
        public string? department { get; set; }
        public int? salary { get; set; }

        public class CreateEmployeeCommandHandler : IRequestHandler<CreateEmployeeCommand, Employee>
        {
            private readonly IEmployeeRepository _employeerepository;
           public CreateEmployeeCommandHandler(IEmployeeRepository employeerepository)
            {
                _employeerepository= employeerepository;
            }
            public async Task<Employee> Handle(CreateEmployeeCommand command,CancellationToken cancellationToken)
            {
                try
                {
                    var employee = new Employee();
                    employee.Id = command.Id;
                    employee.ename = command.ename;
                    employee.department = command.department;
                    employee.salary = command.salary;

                    var res = await _employeerepository.AddEmployee(employee);

                    return employee;
                }
                catch (Exception e)
                {

                    throw;
                }

                
            }
        }
    }
}
