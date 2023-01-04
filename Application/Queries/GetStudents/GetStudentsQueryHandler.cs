using System.Threading;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Interfaces;

namespace Application.Queries.GetStudents
{
    public class GetStudentsQueryHandler : IRequestHandler<GetStudentsQuery, List<GetStudentsViewModel>>
    {
        private readonly IStudentRepository _studentRepository;
        public GetStudentsQueryHandler(IStudentRepository studentRepository)
        {
            _studentRepository = studentRepository;
        }

        public Task<List<GetStudentsViewModel>> Handle(GetStudentsQuery request, CancellationToken cancellationToken)
        {
            var students = _studentRepository.GetAll();

            var getStudentsViewModelList = students
                .Select(s => new GetStudentsViewModel(s.FullName))
                .ToList();

            return Task.FromResult(getStudentsViewModelList);
        }
    }
}
