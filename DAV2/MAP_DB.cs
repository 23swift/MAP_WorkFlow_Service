namespace DAV2
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;
    using System.Data.Entity.ModelConfiguration.Conventions;

    public partial class MAP_DB : DbContext
    {
        public MAP_DB()
            : base("name=MAP_DB")
        {
        }
      
        public virtual DbSet<AdditionalFacility> AdditionalFacility { get; set; }
        public virtual DbSet<Affiliation> Affiliation { get; set; }
        public virtual DbSet<Branches> Branches { get; set; }
        public virtual DbSet<Business> Business { get; set; }
        public virtual DbSet<FileMaintenance> FileMaintenance { get; set; }
        public virtual DbSet<MaintenanceMID> MaintenanceMID { get; set; }
        public virtual DbSet<MasterBranches> MasterBranches { get; set; }
        public virtual DbSet<MasterBusiness> MasterBusiness { get; set; }
        public virtual DbSet<MasterMaintenance> MasterMaintenance { get; set; }
        public virtual DbSet<MasterMID> MasterMID { get; set; }
        public virtual DbSet<MasterTID> MasterTID { get; set; }
        public virtual DbSet<MID> MID { get; set; }
        public virtual DbSet<POS> POS { get; set; }
        public virtual DbSet<Request> Request { get; set; }
       
        public virtual DbSet<TID> TID { get; set; }
        public virtual DbSet<AdditionalMID> AdditionalMID { get; set; }
        public virtual DbSet<BranchAffiliation> BranchAffiliation { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            modelBuilder.Entity<AdditionalFacility>()
                .HasOptional(e => e.AdditionalMID)
                .WithRequired(e => e.AdditionalFacility);

            modelBuilder.Entity<Affiliation>()
                .HasOptional(e => e.BranchAffiliation)
                .WithRequired(e => e.Affiliation);

            modelBuilder.Entity<Branches>()
                .HasMany(e => e.BranchAffiliation)
                .WithOptional(e => e.Branches)
                .HasForeignKey(e => e.Branch_Id);

            modelBuilder.Entity<Branches>()
                .HasMany(e => e.MID)
                .WithOptional(e => e.Branches)
                .HasForeignKey(e => e.Branch_Id);

            modelBuilder.Entity<Branches>()
                .HasMany(e => e.TID)
                .WithOptional(e => e.Branches)
                .HasForeignKey(e => e.Branch_Id);

            modelBuilder.Entity<Business>()
                .HasMany(e => e.Affiliation)
                .WithOptional(e => e.Business)
                .HasForeignKey(e => e.Business_Id);

            modelBuilder.Entity<Business>()
                .HasMany(e => e.Branches)
                .WithOptional(e => e.Business)
                .HasForeignKey(e => e.Business_Id);

            modelBuilder.Entity<FileMaintenance>()
                .HasOptional(e => e.MaintenanceMID)
                .WithRequired(e => e.FileMaintenance);

            modelBuilder.Entity<MasterBranches>()
                .HasMany(e => e.AdditionalFacility)
                .WithOptional(e => e.MasterBranches)
                .HasForeignKey(e => e.Branch_Id);

            modelBuilder.Entity<MasterBranches>()
                .HasMany(e => e.MasterMID)
                .WithOptional(e => e.MasterBranches)
                .HasForeignKey(e => e.Branch_Id);

            modelBuilder.Entity<MasterBranches>()
                .HasMany(e => e.MasterTID)
                .WithOptional(e => e.MasterBranches)
                .HasForeignKey(e => e.Branch_Id);

            modelBuilder.Entity<MasterBusiness>()
                .HasMany(e => e.Affiliation)
                .WithOptional(e => e.MasterBusiness)
                .HasForeignKey(e => e.Business_Id);

            modelBuilder.Entity<MasterBusiness>()
                .HasMany(e => e.FileMaintenance)
                .WithOptional(e => e.MasterBusiness)
                .HasForeignKey(e => e.Business_Id);

            modelBuilder.Entity<MasterBusiness>()
                .HasMany(e => e.MasterBranches)
                .WithOptional(e => e.MasterBusiness)
                .HasForeignKey(e => e.Business_Id);

            modelBuilder.Entity<MasterMaintenance>()
                .Property(e => e.Code)
                .IsFixedLength();

            modelBuilder.Entity<Request>()
                .HasOptional(e => e.AdditionalFacility)
                .WithRequired(e => e.Request);

            modelBuilder.Entity<Request>()
                .HasOptional(e => e.Affiliation)
                .WithRequired(e => e.Request);

            modelBuilder.Entity<Request>()
                .HasOptional(e => e.FileMaintenance)
                .WithRequired(e => e.Request);

            modelBuilder.Entity<Request>()
                .HasOptional(e => e.POS)
                .WithRequired(e => e.Request);
        }
    }
}
