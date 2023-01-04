using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Queries.GetStudents
{
    public class GetStudentsViewModel
    {
        public GetStudentsViewModel(string fullName)
        {
            FullName = fullName;
        }
        public string FullName { get; set; }
    }
}
