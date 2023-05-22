using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Models
{
  // one class 
  // Single Responsibility  
  public class Employee
  {
    public int EmployeeID { get; set; }
    public string EmployeeName { get; set; }
    public string EmployeeSurname { get; set; }
    // forigen key 
    public int DepartmentID { get; set; }
  }
}
