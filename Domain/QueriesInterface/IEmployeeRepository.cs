using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.QueriesInterface
{
    public interface IEmployeeRepository
    {
        public Task<IEnumerable<Employee>> GetEmployees();
        public Task<Employee> GetEmployeeById(int Id);
        public Task<Employee> AddEmployee(Employee employee);
        public Task<int> UpdateEmployee(int Id, Employee employee);
        public Task<int> DeleteEmployee(int Id);
     }
}
