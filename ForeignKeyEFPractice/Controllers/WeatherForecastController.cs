using ForeignKeyEFPractice.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace ForeignKeyEFPractice.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        public CompanyContext context { get; set; }
        public WeatherForecastController(CompanyContext c)
        {
            context = c;
        }


        [HttpPost]
        public IActionResult Post()
        {
            context.Company.Add(new Company{ CompanyName = "SEHA", CompanyDescription = "Silicon Company" }); ;



            context.SaveChanges();

            Company company = context.Company.Include(c => c.Employees).Where(c => c.CompanyName == "SEHA").First();

            Employee e = new Employee { Name = "Elijah", Age = 24, CompanyName = "SEHA", Role = "Engineer" };
            
            company.Employees.Add(e);          
            
            

            context.SaveChanges();

            Employee elijah = context.Company.Where(c => c.CompanyName == "SEHA").FirstOrDefault().Employees.Where(e => e.Name == "Elijah").FirstOrDefault();


            return Ok(elijah);
        }

    }
}