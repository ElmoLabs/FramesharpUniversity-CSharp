using Framesharp.Core.Interfaces;
using Framesharp.DomainService;
using System.Collections.Generic;
using FramesharpUniversity.Domain;
using FramesharpUniversity.DomainService.Interfaces;
using FramesharpUniversity.Repository.Interfaces;

namespace FramesharpUniversity.DomainService
{
    public class InstructorDomainService : CrudDomainService<Instructor, IInstructorRepository>, IInstructorDomainService
    {
        public InstructorDomainService(IOperationCallContext context) : 
                base(context)
        {
        }
    }
}
