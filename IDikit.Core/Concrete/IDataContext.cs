using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations;
using IDikit.Core.Model;

namespace IDikit.Core.Concrete
{
    public class IDataContext: DbContext
    {
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Member>().HasKey(e => e.ID);
            modelBuilder.Entity<Member>().Property(e => e.ID).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            modelBuilder.Entity<Member>().ToTable("Member");

            modelBuilder.Entity<Bookmark>().HasKey(e => e.ID);
            modelBuilder.Entity<Bookmark>().Property(e => e.ID).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            modelBuilder.Entity<Bookmark>().ToTable("Bookmark");

            base.OnModelCreating(modelBuilder);
        }

        public DbSet<Member> Members { get; set; }
        public DbSet<Bookmark> Bookmarks { get; set; }
    }
}
