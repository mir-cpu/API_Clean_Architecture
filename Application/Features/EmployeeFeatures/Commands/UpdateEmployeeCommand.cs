using Application.Features.EmployeeFeatures.Commands;
using Application.Interfaces;
using Domain.Entities;
using Domain.QueriesInterface;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.EmployeeFeatures.Commands
{
    public class UpdateEmployeeCommand : IRequest<int>
    {
        public int Id { get; set; }
        public string? ename { get; set; }
        public string? department { get; set; }
        public int? salary { get; set; }

        public class UpdateEmployeeCommandHandler : IRequestHandler<UpdateEmployeeCommand, int>
        {
            public IEmployeeRepository _employeerepository;
            private int Id;

            public UpdateEmployeeCommandHandler(IEmployeeRepository employeerepository)
            {
                _employeerepository = employeerepository;
            }
            public async Task<int> Handle(UpdateEmployeeCommand command,CancellationToken cancellationToken)
            {
                var employee = new Employee();
                employee.Id = command.Id;
                employee.ename= command.ename;
                employee.department= command.department;
                employee.salary= command.salary;

                Console.Write(employee);

                var res = await _employeerepository.UpdateEmployee(Id, employee);

                return res;
                
            }
            

        }
   

    }

}

