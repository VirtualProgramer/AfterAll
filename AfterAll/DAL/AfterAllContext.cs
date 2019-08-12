namespace AfterAll.DAL {
    using System;
    using System.Data.Entity;
    using System.Linq;

    public class AfterAllContext : DbContext {
        // Your context has been configured to use a 'AfterAllContext' connection string from your application's 
        // configuration file (App.config or Web.config). By default, this connection string targets the 
        // 'AfterAll.DAL.AfterAllContext' database on your LocalDb instance. 
        // 
        // If you wish to target a different database and/or database provider, modify the 'AfterAllContext' 
        // connection string in the application configuration file.
        public AfterAllContext()
            : base("name=AfterAllContext") {
        }

        public System.Data.Entity.DbSet<AfterAll.Models.Member> Members { get; set; }

        // Add a DbSet for each entity type that you want to include in your model. For more information 
        // on configuring and using a Code First model, see http://go.microsoft.com/fwlink/?LinkId=390109.

        // public virtual DbSet<MyEntity> MyEntities { get; set; }
    }

    //public class MyEntity
    //{
    //    public int Id { get; set; }
    //    public string Name { get; set; }
    //}
}