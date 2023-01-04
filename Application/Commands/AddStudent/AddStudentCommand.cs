using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Commands.AddStudent
{
    //Irequest significa o que vai retorna para o usuario
    public class AddStudentCommand : IRequest<AddStudentViewModel>
    {
        public AddStudentCommand(string fullName, DateTime birthDate, int idUit)
        {
            FullName = fullName;
            BirthDate = birthDate;
            IdUit = idUit;
        }

        public string FullName { get; set; }
        public DateTime BirthDate { get; set; }
        public int IdUit { get; set; }
    }
}
