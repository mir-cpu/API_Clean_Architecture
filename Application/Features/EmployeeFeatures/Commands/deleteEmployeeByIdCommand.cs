using Application.Interfaces;
using Domain.QueriesInterface;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.EmployeeFeatures.Commands
{
    public class deleteEmployeeByIdCommand : IRequest<int>
   
    {
        public int Id { get; set; } 

        public class deleteEmployeeByIdCommandHandler : IRequestHandler<deleteEmployeeByIdCommand, int>
        {
            private IEmployeeRepository _employeerepository;
            public deleteEmployeeByIdCommandHandler(IEmployeeRepository employeerepository)
            {
                _employeerepository= employeerepository;
            }
            public async Task<int> Handle(deleteEmployeeByIdCommand command,CancellationToken cancellationtoken)
            {
                var res = await _employeerepository.DeleteEmployee(command.Id);
                return res;
            }

        }
    }
}
