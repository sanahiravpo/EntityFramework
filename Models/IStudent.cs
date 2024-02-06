using AutoMapper;
using Microsoft.EntityFrameworkCore;

namespace EntityFramework.Models
{
    public interface IStudent
    {
        public IEnumerable<Student> GetAllStudents();
       Student GetStudentById(int id);

        void  AddStudent(StudentDTO student);
        void DeleteStudent(int id);
        void UpdateStudent(int id,Student updatestudent);
       
    }
    public class StudentService: IStudent
    {
        private readonly StudentDbContext _context;
        private readonly IMapper _mapper;
        public StudentService(StudentDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public IEnumerable<Student> GetAllStudents()
        {
            return _context.students.ToList();
            
        }
  public Student GetStudentById(int id)
        {
            return _context.students.Find(id);
        }


        public void AddStudent(StudentDTO student)
        {
            var std = _mapper.Map<Student>(student);
             _context.students.Add(std);
            _context.SaveChanges();

        }



        public void DeleteStudent(int id)
        {
            var employeetodelete= _context.students.Find(id);
            if (employeetodelete != null)
            {
                _context.students.Remove(employeetodelete);
                _context.SaveChanges();
            }
        }
        public void UpdateStudent(int id, Student updatestudent)
        {
            var existingstudent= _context.students.Find(id);
            if (existingstudent != null)
            {
                existingstudent.Name = updatestudent.Name;
                existingstudent.salary = updatestudent.salary;
                _context.SaveChanges();
            }
        }

        




    }
        








}
