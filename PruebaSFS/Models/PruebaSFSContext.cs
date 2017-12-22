using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace PruebaSFS.Models
{
    public class PruebaSFSContext : DbContext
    {
    
        public PruebaSFSContext() : base("name=PruebaSFSContext")
        {
            Database.SetInitializer
            <PruebaSFSContext>
            (
                new DropCreateDatabaseIfModelChanges
                <PruebaSFSContext>()
            );
        }

        public DbSet<Student> Students { get; set; }
        public DbSet<Course> Courses { get; set; }
    }
}
