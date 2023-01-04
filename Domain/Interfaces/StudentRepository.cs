using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Interfaces
{
    public class StudentRepository : IStudentRepository
    {
        public void Add(Student student)
        {

        }

        public List<Student> GetAll()
        {
            return new List<Student>
            {
                new Student("luis", DateTime.Now),
                new Student("gabriel", DateTime.Now),
                new Student("Douglas", DateTime.Now)

            };
        }
    }
}
