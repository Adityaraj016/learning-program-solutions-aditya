using System;
using System.Collections.Generic;

namespace WebAPI_CRUD_Part4_Project.Models
{
    public class Department
    {
        public int DeptId { get; set; }
        public string DeptName { get; set; }
    }

    public class Skill
    {
        public int SkillId { get; set; }
        public string SkillName { get; set; }
    }

    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Salary { get; set; }
        public bool Permanent { get; set; }
        public Department Department { get; set; }
        public List<Skill> Skills { get; set; }
        public DateTime DateOfBirth { get; set; }
    }
}