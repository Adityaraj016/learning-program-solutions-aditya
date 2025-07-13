using Microsoft.AspNetCore.Mvc;
using WebAPI_CRUD_Part4_Project.Models;
using System.Collections.Generic;
using System;
using System.Linq;



namespace WebAPI_CRUD_Part4_Project.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EmployeeController : ControllerBase
    {
        private static List<Employee> employees = new List<Employee>
        {
            new Employee { Id = 1, Name = "Alice", Salary = 50000, Permanent = true, Department = new Department{ DeptId = 1, DeptName = "HR" }, Skills = new List<Skill>{ new Skill{ SkillId = 1, SkillName = "C#" } }, DateOfBirth = new DateTime(1990, 1, 1) },
            new Employee { Id = 2, Name = "Bob", Salary = 60000, Permanent = false, Department = new Department{ DeptId = 2, DeptName = "IT" }, Skills = new List<Skill>{ new Skill{ SkillId = 2, SkillName = "SQL" } }, DateOfBirth = new DateTime(1992, 2, 2) }
        };

        [HttpPut]
        public ActionResult<Employee> UpdateEmployee([FromBody] Employee emp)
        {
            if (emp.Id <= 0)
                return BadRequest("Invalid employee id");

            var existing = employees.FirstOrDefault(e => e.Id == emp.Id);
            if (existing == null)
                return BadRequest("Invalid employee id");

            existing.Name = emp.Name;
            existing.Salary = emp.Salary;
            existing.Permanent = emp.Permanent;
            existing.Department = emp.Department;
            existing.Skills = emp.Skills;
            existing.DateOfBirth = emp.DateOfBirth;

            return Ok(existing);
        }
    }
}