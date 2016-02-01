using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;


namespace Entities
{
    public class SSADbContext : DbContext
    {
        static SSADbContext()
        {
            Database.SetInitializer(new DropCreateDatabaseAlways<SSADbContext>());
        }
        public SSADbContext() : base("name=SSADbConnStr")
        {
        }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.HasDefaultSchema("SSA");
        }

        public virtual DbSet<Student> Students { get; set; }

        public virtual DbSet<Score> Scores { get; set; }

        public virtual DbSet<Config> Configs { get; set; }

        public virtual DbSet<School> Schools { get; set; }

        public virtual DbSet<StudentSchool> StudentSchools { get; set; }

    }
}