using System.Threading;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Interfaces;
using Domain.Entities;

namespace Application.Commands.AddStudent
{
    //commandHandler ele vai pedir um comando e uma resposta
    //Se não quiser passar uma resposta pro cliente coloca unit
    public class AddStudentCommandHandler : IRequestHandler<AddStudentCommand, AddStudentViewModel>
    {

        private readonly IStudentRepository _studentRepository;
        public AddStudentCommandHandler(IStudentRepository studentRepository)
        {
            _studentRepository = studentRepository;
        }

        public Task<AddStudentViewModel> Handle(AddStudentCommand request, CancellationToken cancellationToken)
        {
            var student = new Student(request.FullName, request.BirthDate);
            _studentRepository.Add(student);
            var studentViewModel = new AddStudentViewModel { FullName = student.FullName , BirthDate = student.BirthDate};

            return Task.FromResult(studentViewModel);
        }
    }
}
