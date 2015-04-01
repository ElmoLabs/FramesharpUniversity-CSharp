using Framesharp.Core.Interfaces;
using Framesharp.DomainService;
using System.Collections.Generic;
using FramesharpUniversity.Domain;
using FramesharpUniversity.DomainService.Interfaces;
using FramesharpUniversity.Repository.Interfaces;

namespace FramesharpUniversity.DomainService
{
    public class CourseEnrollmentDomainService : CrudDomainService<Domain.CourseEnrollment, ICourseEnrollmentRepository>, ICourseEnrollmentDomainService
    {
        public CourseEnrollmentDomainService(IOperationCallContext context) : 
                base(context)
        {
        }
    }
}
