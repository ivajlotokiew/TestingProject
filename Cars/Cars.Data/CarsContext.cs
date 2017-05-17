namespace Cars.Data
{
    using Models;
    using System;
    using System.Data.Entity;
    using System.Linq;

    public class CarsContext : DbContext
    {
        // Your context has been configured to use a 'CarsContext' connection string from your application's 
        // configuration file (App.config or Web.config). By default, this connection string targets the 
        // 'Cars.Data.CarsContext' database on your LocalDb instance. 
        // 
        // If you wish to target a different database and/or database provider, modify the 'CarsContext' 
        // connection string in the application configuration file.
        public CarsContext()
            : base("name=CarsContext")
        {
        }

        public virtual DbSet<Car> Cars { get; set; }

        public virtual DbSet<User> Users { get; set; }

    }
}