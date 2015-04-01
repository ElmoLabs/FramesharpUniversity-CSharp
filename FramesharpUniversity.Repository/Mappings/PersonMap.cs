using System; 
using System.Collections.Generic; 
using System.Text; 
using FluentNHibernate.Mapping;
using FramesharpUniversity.Domain;

namespace FramesharpUniversity.Repository.Mappings
{
    public class PersonMap : ClassMap<Person>
    {
        public PersonMap()
        {
            Id(x => x.DocumentNumber).GeneratedBy.Identity();

			Map(x => x.Name).Not.Nullable().Length(200);
			Map(x => x.Gender).Not.Nullable().Length(1);
        }
    }
}
