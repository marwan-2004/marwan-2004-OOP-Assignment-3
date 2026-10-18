using System;
using System.Collections.Generic;
using System.Text;

namespace Generics
{
    public class StudentStore
    {
        private readonly List<Student> _students = new();

        public void Add(Student student) => _students.Add(student);

        public Student? GetById(int id)
        {
            foreach (var student in _students)
            {
                if (student.Id == id) return student;
            }
            return null;
        }

        public List<Student> GetAll() => _students;

        public bool Remove(int id)
        {
            var student = GetById(id);
            if (student != null)
            {
                return _students.Remove(student);
            }
            return false;
        }
    }
}
