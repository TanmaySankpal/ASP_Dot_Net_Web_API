using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ASPNetCoreWebAPIDemo.Model
{
    public class Employee
    {
        [Key]
        public int EmployeeId
        {
            get;
            set;
        }
        public string EmployeeFirstName
        {
            get;
            set;
        }
        public string EmployeeLastName
        {
            get;    
            set;    
        }
        [Column(TypeName = "decimal(18, 2)")]
        public decimal Salary
        {
            get;
            set;
        }
        public string Designation
        {
            get; 
            set;
        }
    }

}
