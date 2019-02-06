namespace DA
{
    using NLog;
    using NLog.Config;
    using NLog.LayoutRenderers;
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.ModelConfiguration.Conventions;
    using System.Linq;
    using Newtonsoft.Json;

    public partial class MAS_DB : DbContext
    {
        // Your context has been configured to use a 'MAS_DB' connection string from your application's 
        // configuration file (App.config or Web.config). By default, this connection string targets the 
        // 'MerchantAquiringSystemWithWF.MAS_DB' database on your LocalDb instance. 
        // 
        // If you wish to target a different database and/or database provider, modify the 'MAS_DB' 
        // connection string in the application configuration file.
        private static NLog.Logger logger = NLog.LogManager.GetLogger("db");
        public MAS_DB()
            : base("name=MAS_DB")
        {
         
        }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            CreateModelRelationship(modelBuilder);
        }
        // Add a DbSet for each entity type that you want to include in your model. For more information 
        // on configuring and using a Code First model, see http://go.microsoft.com/fwlink/?LinkId=390109.

        // public virtual DbSet<MyEntity> MyEntities { get; set; 
        public virtual DbSet<Models.Request> Request { get; set; }
        public virtual DbSet<Models.POSRequest> POSRequest { get; set; }
        public virtual DbSet<Models.MAEF> MAEF { get; set; }
        public virtual DbSet<Models.Branch> Branch { get; set; }
        public virtual DbSet<Models.ApprovalSetup> ApprovalSetup { get; set; }
        public virtual DbSet<Models.MerchantGroup> MerchantGroup { get; set; }
        public virtual DbSet<Models.Customer> Customer { get; set; }
        public virtual DbSet<Models.NewAffiliation> NewAffiliation { get; set; }
        public virtual DbSet<Models.AdditionalFacility> AdditionalFacility { get; set; }
        public virtual DbSet<Models.BranchAffiliation> BranchAffiliation { get; set; }
        public virtual DbSet<Models.DocumentList> DocumentList { get; set; }
        public virtual DbSet<Models.OcularInspectionForm> OcularInspectionForm { get; set; }

        

        public virtual System.Data.Entity.DbSet<DA.Models.MaintenanceMaster> MaintenanceMaster { get; set; }
        public virtual System.Data.Entity.DbSet<DA.Models.MaintenanceDetails> MaintenanceDetails { get; set; }
        public virtual System.Data.Entity.DbSet<DA.Models.AuditLog> AuditLog { get; set; }
        

        public override int SaveChanges()
        {
           // LogManager.Configuration.Uninstall(new InstallationContext());
           // LogManager.Configuration.Install(new InstallationContext());
           
            //var modifiedEntities = ChangeTracker.Entries()
            //    .Where(p => p.State == EntityState.Modified).ToList();
            var modifiedEntities = ChangeTracker.Entries().ToList();
            LogEventInfo theEvent = new LogEventInfo(LogLevel.Info, "db", "test");
            

            var now = DateTime.UtcNow;

            foreach (var change in modifiedEntities)
            {
                var entityName = change.Entity.GetType().Name;
                var ent = change.Entity;
                
                //var primaryKey = GetPrimaryKeyValue(change);
               
                //if has original values its create
                if (change.State == EntityState.Added )
                {
                    var values = change.CurrentValues.PropertyNames;
                    var newValues = JsonConvert.SerializeObject(change.CurrentValues.ToObject());
                    var userName = change.CurrentValues["CreatedBy"];
                    var createdDate = change.CurrentValues["CreatedDate"];
                   
                    theEvent.Properties["CreatedBy"] = userName;
                    theEvent.Properties["CreatedDate"] = createdDate;
                    theEvent.Properties["NewValues"] = newValues;

                    foreach (var prop in change.CurrentValues.PropertyNames)
                    {
                        // var originalValue = change.OriginalValues[prop].ToString();

                        if (prop.Equals("TrackingNo"))
                        {

                            theEvent.Properties["TrackingNo"] = change.CurrentValues["TrackingNo"];
                        }



                    }
                }
                else if(change.State == EntityState.Modified)
                {
                    var values = change.CurrentValues.PropertyNames;
                    var oldValues = JsonConvert.SerializeObject(change.OriginalValues.ToObject());
                    var newValues = JsonConvert.SerializeObject(change.CurrentValues.ToObject());
                    var userName = change.CurrentValues["UpdatedBy"];
                    var updatedDate = change.CurrentValues["UpdatedDate"];

                    theEvent.Properties["OldValues"] = oldValues;
                    theEvent.Properties["NewValues"] = newValues;
                    theEvent.Properties["UpdatedDate"] = updatedDate;
                    theEvent.Properties["UpdatedBy"] = userName;

                    foreach (var prop in change.CurrentValues.PropertyNames)
                    {
                        // var originalValue = change.OriginalValues[prop].ToString();

                        if (prop.Equals("TrackingNo"))
                        {

                            theEvent.Properties["TrackingNo"] = change.CurrentValues["TrackingNo"];
                        }



                    }

                }
               
                theEvent.Properties["Entity"] = entityName;


               
                logger.Log(theEvent);
            }
            return base.SaveChanges();
        }

    }
}