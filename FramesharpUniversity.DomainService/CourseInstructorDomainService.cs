using Framesharp.Core.Interfaces;
using Framesharp.DomainService;
using System.Collections.Generic;
using FramesharpUniversity.Domain;
using FramesharpUniversity.DomainService.Interfaces;
using FramesharpUniversity.Repository.Interfaces;

namespace FramesharpUniversity.DomainService
{
    public class CourseInstructorDomainService : CrudDomainService<Domain.CourseInstructor, ICourseInstructorRepository>, ICourseInstructorDomainService
    {
        public CourseInstructorDomainService(IOperationCallContext context) : 
                base(context)
        {
        }
    }
}
