using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Queries.GetStudents
{
    public class GetStudentsQuery : IRequest<List<GetStudentsViewModel>>
    {
    }
}
