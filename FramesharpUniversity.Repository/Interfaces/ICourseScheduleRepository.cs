using Framesharp.Core.Interfaces;
using Framesharp.Repository;
using System.Collections.Generic;
using FramesharpUniversity.Domain;

namespace FramesharpUniversity.Repository.Interfaces
{
    public interface ICourseScheduleRepository : IRepository<Domain.CourseSchedule>
    {
    }
}
