using Framesharp.Core.Interfaces;
using Framesharp.DomainService;
using System.Collections.Generic;
using FramesharpUniversity.Domain;
using FramesharpUniversity.DomainService.Interfaces;
using FramesharpUniversity.Repository.Interfaces;

namespace FramesharpUniversity.DomainService
{
    public class ClassroomDomainService : CrudDomainService<Classroom, IClassroomRepository>, IClassroomDomainService
    {
        public ClassroomDomainService(IOperationCallContext context) : 
                base(context)
        {
        }
    }
}
