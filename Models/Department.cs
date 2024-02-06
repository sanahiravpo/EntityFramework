using System.ComponentModel.DataAnnotations.Schema;

namespace EntityFramework.Models
{
    public class Department
    {

 
        public int id { get; set; } 
        public string deptname { get; set; }
      public List<Student> students { get; set; }
    }
}
