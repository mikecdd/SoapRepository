using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace QADAL.EntityFrameWorkCore.Mapping
{
    public class CollectMap : EntityTypeConfiguration<Models.Collect>
    {
        public CollectMap()
        {
            // Primary Key
            this.HasKey(t => t.Qid).HasKey(t => new { t.Qid,t.personid});

            // Properties
            this.Property(t => t.Id)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            this.Property(t => t.personid)
              .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.Qid)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);


            // Table & Column Mappings
            this.ToTable("collect");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.personid).HasColumnName("personid");
            this.Property(t => t.Qid).HasColumnName("Qid");
            this.Property(t => t.collecttime).HasColumnName("collecttime");
            this.Property(t => t.name).HasColumnName("name");

            // Relationships
            this.HasRequired(t => t.question)
                .WithMany(t => t.collects)
                .HasForeignKey(d => d.Qid);

        }
    }
}
