﻿using Microsoft.AspNetCore.Mvc;


namespace MyWebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        [Route("")]
        public List<EmployeeModel> GetEmployees()
        {
            return new List<EmployeeModel>() {
                new EmployeeModel() { Id = 1, Name = "Employee 1" },
                new EmployeeModel() { Id = 2, Name = "Employee 2"}}
            ;
        }
        [Route("{id}")]
        public IActionResult GetEmployees(int id)
        {
            if (id == 0)
            {
                return NotFound();
            }
            return Ok(new List<EmployeeModel>() {
                new EmployeeModel() { Id = 1, Name = "Employee 1" },
                new EmployeeModel() { Id = 2, Name = "Employee 2"}}
            );
        }
        [Route("{id}/basic")]
        public ActionResult<EmployeeModel> GetEmployeeBasicDetails(int id)
        {
            if (id == 0)
            {
                return NotFound();
            }

            return new EmployeeModel() { Id = 1, Name = "Employee 1" };
        }
    }
}
    
