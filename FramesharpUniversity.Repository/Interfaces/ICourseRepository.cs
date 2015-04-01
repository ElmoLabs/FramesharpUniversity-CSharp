using Framesharp.Core.Interfaces;
using Framesharp.Repository;
using System.Collections.Generic;
using FramesharpUniversity.Domain;

namespace FramesharpUniversity.Repository.Interfaces
{
    public interface ICourseRepository : IRepository<Domain.Course>
    {
    }
}
