using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ForeignKeyEFPractice.Models
{
    public class Company
    {


        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public string CompanyName { get; set; }


        public string CompanyDescription { get; set; }

        public List<Employee> Employees { get; set; }


    }
}
