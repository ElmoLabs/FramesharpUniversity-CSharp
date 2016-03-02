using Framesharp.DomainService.Interfaces;
using System.Collections.Generic;
using FramesharpUniversity.Domain;

namespace FramesharpUniversity.DomainService.Interfaces
{
    public interface IPersonDomainService : ICrudDomainService<Person>
    {
    }
}
