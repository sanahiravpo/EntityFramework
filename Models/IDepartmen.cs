

using AutoMapper;

namespace EntityFramework.Models
{
    public interface IDepartmen
    {

         void AddDepartment(DepartmentDTO department);
        IEnumerable<Department> GetAllDepartments();
        Department GetDepartmentById(int id);
        void DeleteDepartment(int id);
        void UpdateDepartment(int id,DepartmentDTO updatedepartment);
    }


    public class DepartmentRepository: IDepartmen
    {

        private readonly StudentDbContext _context;
        private readonly IMapper _mapper;
        public DepartmentRepository(StudentDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }


        public void AddDepartment(DepartmentDTO department)
        {
            var dept= _mapper.Map<Department>(department);
            _context.departments.Add(dept);
            _context.SaveChanges();

        }
        public IEnumerable<Department> GetAllDepartments()
        {
           return _context.departments.ToList();

        }
        public Department GetDepartmentById(int id)
        {
            return _context.departments.Find(id);
            
        }
        public void DeleteDepartment(int id)
        {
            var deleteid=_context.departments.Find(id);
            if (deleteid != null)
            {
                _context.departments.Remove(deleteid);
                _context.SaveChanges();

            }
        }


       public void UpdateDepartment(int id, DepartmentDTO updatedepartment)
        {
  var existingstudent = _context.departments.Find(id);
            if (existingstudent != null)
            {
                existingstudent.deptname = updatedepartment.deptname;
                _context.SaveChanges();
            }
        }

       

        
    }
}
