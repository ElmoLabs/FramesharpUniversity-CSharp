using System;
using Framesharp.Presentation.Web.Mvc.Models;

namespace FramesharpUniversity.WebApplication.Models
{
    public class Demonstration : ModelBase
    {
        public static implicit operator Domain.Demonstration(Demonstration model)
        {
            return Transcriptors.DemonstrationTranscriptor.ConvertFromModelToDomain(model, new Domain.Demonstration());
        }

        public static implicit operator Demonstration(Domain.Demonstration domain)
        {
            return Transcriptors.DemonstrationTranscriptor.ConvertToModelFromDomain(new Demonstration(), domain);
        }

        public virtual int DemonstrationId { get; set; }

        public virtual string SomeDescription { get; set; }

        public virtual int SomeNumber { get; set; }

        public virtual bool SomeFlag { get; set; }

        public virtual DateTime? CreationDate { get; set; }

        public virtual DateTime? EditionDate { get; set; }

        /// <summary>
        /// Class constructor
        /// </summary>
        public Demonstration()
        {
            this.InitializeObject();
        }

        /// <summary>
        /// Initilizes class properties with default values
        /// </summary>
        private void InitializeObject()
        {
            // Virtual properties initilization instructions
        }

        public override bool Equals(object obj)
        {
            return (obj as Demonstration) != null && this.DemonstrationId == (obj as Demonstration).DemonstrationId;
        }

        public override int GetHashCode()
        {
            return string.Concat(this.DemonstrationId).GetHashCode();
        }
    }
}