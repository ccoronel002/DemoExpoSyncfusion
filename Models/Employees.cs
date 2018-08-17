using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EJ2MVCSampleBrowser.Models
{
    public class Employees
    {
        public string Name { get; set; }
        public string Eimg { get; set; }
        public string Designation { get; set; }
        public string Country { get; set; }
        public List<Employees> EmployeesList()
        {
            List<Employees> emp = new List<Models.Employees>();
            emp.Add(new Employees { Name= "Carlos Coronel", Eimg= "7", Designation = "Team Coordinator", Country= "Costa Rica"});
            emp.Add(new Employees { Name= "Diego ", Eimg= "1", Designation = "Developer", Country= "USA"});
            emp.Add(new Employees { Name= "Jose Villalobos", Eimg= "3", Designation = "Team Leader", Country= "Costa Rica"});
            emp.Add(new Employees { Name= "Ricardo Garbanzo", Eimg= "2", Designation = "Product Manager", Country= "Costa RIca"});
            emp.Add(new Employees { Name= "Margaret Peacock", Eimg= "6", Designation = "Developer", Country= "USA"});
            emp.Add(new Employees { Name= "Michael Suyama", Eimg= "9", Designation = "Team Lead", Country= "USA"});
            emp.Add(new Employees { Name= "Nancy Davolio", Eimg= "4", Designation = "Product Manager", Country= "USA"});
            emp.Add(new Employees { Name= "Robert King", Eimg= "8", Designation = "Developer ", Country= "England"});
            emp.Add(new Employees { Name= "Steven Buchanan", Eimg= "10", Designation = "CEO", Country= "England" });
            return emp;
        }
    }
}
