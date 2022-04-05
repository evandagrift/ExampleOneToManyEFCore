using System.ComponentModel.DataAnnotations;

namespace ForeignKeyEFPractice.Models
{
    public class Employee
    {
        [Key]
        public string Name { get; set; }
        public string Role { get; set; }
        public int Age { get; set; }

        public string CompanyName { get; set; }
        public Company Company { get; set; }
    }
}
