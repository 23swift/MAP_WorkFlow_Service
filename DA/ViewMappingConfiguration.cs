using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DA
{
    public partial class MAS_DB : DbContext
    {
        public void CreateModelRelationship(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new OwnershipConfiguration());
        }
    }

    public partial class OwnershipConfiguration : EntityTypeConfiguration<DA.Models.Ownership>
    {
        public OwnershipConfiguration()
        {
            this.HasKey(t => t.Id);
            this.Property(p => p.Id).HasColumnName("OwnershipType_Id");
            this.ToTable("dbo.OwnershipTypeView");
        }
    }
    public partial class MerchantGroupConfiguration : EntityTypeConfiguration<DA.Models.MerchantGroup>
    {
        public MerchantGroupConfiguration()
        {
            this.HasKey(t => t.Id);
            this.Property(p => p.Id).HasColumnName("MerchantGroup_Id");
            this.ToTable("dbo.MerchantGroupView");
        }
    }
    
}
