using FluentNHibernate.Mapping;
using FramesharpUniversity.Domain;
using NHibernate.Mapping;

namespace FramesharpUniversity.Repository.Mappings
{
    public class DemonstrationMapping : ClassMap<Demonstration>
    {
        public DemonstrationMapping()
        {
            Id(c => c.DemonstrationId).Column("DemonstrationId").GeneratedBy.Native();

            Map(c => c.SomeDescription);
            Map(c => c.SomeNumber);
            Map(c => c.SomeFlag);
            Map(c => c.CreationDate).ReadOnly().Not.Insert().Not.Update();
            Map(c => c.EditionDate).Nullable();
        }
    }
}