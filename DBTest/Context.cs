using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace DBTest
{
    class Context : DbContext 
    {

        // This code defines what classees (models) that are stored in the database.

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            // Where the data is going to be stored
            //options.UseSqlServer(@"Data Source=localhost; Initial Catalog=DBTest;Integrated Security=True");

            // Data Source=<Server name>; Initial Catalog=<database>; User ID =<database username>; Password =<database password>;
            // https://www.connectionstrings.com/sql-server/

            options.UseSqlServer(@"Data Source=192.168.10.109; Initial Catalog=QuestDB; User ID =sa; Password =.sql!;");
        }

        // Add-Migration  --- Creating a script for class/Table structure in the database. (create database script)
        // Update-Database --- Updateing the Database. (Run database Script)

        public DbSet<QuestModel> Quest { get; set; } // Table in the database
        public DbSet<NewTable> MyNewDatabaseTable { get; set; } // Table in the database

    }

    public class NewTable
    {
        public int id { get; set; }
        public string Name { get; set; }
    }


}
