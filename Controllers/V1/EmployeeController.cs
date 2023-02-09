using Application.Features.EmployeeFeatures.Commands;
using Application.Features.EmployeeFeatures.Queries;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Update.Internal;
using System;
using System.Collections;
using System.Threading.Tasks;

namespace WebAPIs.Controllers.V1
{
    [Route("[controller]")]
    public class EmployeeController : BaseApiController
    {
       /* private getAllEmployeesQuery _get;
        public EmployeeController(getAllEmployeesQuery get)
        {
            _get = get;
        }*/

        [HttpPost]
        public async Task<IActionResult> Post([FromBody] CreateEmployeeCommand cmd)
        {
            return Ok(await Mediator.Send(cmd));
        }

        [HttpPut("{Id}")]

        public async Task<IActionResult> Put(int Id,[FromBody]UpdateEmployeeCommand cmd)
        {


            var empid = await Mediator.Send(new GetEmployeeByIdQuery { Id=Id});
            if (empid == null)
            {
                return NotFound();
            }
            else
            {
                Console.Write(cmd);
                return Ok(await Mediator.Send(cmd));
            }
            
        
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            return Ok(await Mediator.Send(new GetAllEmployeesQuery()));
        }

        [HttpGet("{Id}")]
        public async Task<IActionResult> GetById(int Id)
        {
            return Ok(await Mediator.Send(new GetEmployeeByIdQuery { Id = Id }));
        }

        [HttpDelete("{Id}")]

        public async Task<IActionResult> DeleteByID(int Id)
        {
            return Ok(await Mediator.Send(new deleteEmployeeByIdCommand { Id=Id}));
        }

    }
}
