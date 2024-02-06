namespace EntityFramework.Models
{
    public class Student
    {
        public int Id {  get; set; } 
            public string Name { get; set; }
 public decimal salary { get; set; } 
        public int deptid { get; set; }
        public Department departments { get; set; }
        
    }
}
