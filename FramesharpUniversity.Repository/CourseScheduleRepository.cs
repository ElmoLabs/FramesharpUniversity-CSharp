using Framesharp.Core.Interfaces;
using Framesharp.Data.Collection;
using Framesharp.Collection;
using Framesharp.Repository;
using NHibernate;
using NHibernate.Criterion;
using System.Collections.Generic;
using FramesharpUniversity.Domain;
using FramesharpUniversity.Repository.Interfaces;

namespace FramesharpUniversity.Repository
{
    public class CourseScheduleRepository : RepositoryBase<CourseSchedule>, ICourseScheduleRepository
    {
        public CourseScheduleRepository(IOperationCallContext context) : 
                base(context)
        {
        }
    }
}
