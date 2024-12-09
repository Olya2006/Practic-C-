using Project.Models;

namespace Project.Services
{
    public class StudentService
    {
        private readonly List<Student> _students = new()
        {
            new Student { Name = "Alice", Age = 20, Subjects = new List<string> { "Math", "Physics" } },
            new Student { Name = "Bob", Age = 22, Subjects = new List<string> { "Chemistry", "Biology" } }
        };

        public IEnumerable<Student> GetAllStudents() => _students;

        public Student GetStudentByName(string name) => 
            _students.FirstOrDefault(s => s.Name == name);

        public void AddStudent(Student student) => _students.Add(student);

        public bool UpdateStudent(string name, Student updatedStudent)
        {
            var student = GetStudentByName(name);
            if (student == null) return false;

            student.Age = updatedStudent.Age;
            student.Subjects = updatedStudent.Subjects;
            return true;
        }

        public bool DeleteStudent(string name)
        {
            var student = GetStudentByName(name);
            if (student == null) return false;

            _students.Remove(student);
            return true;
        }
    }
}