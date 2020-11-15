using Library.DataAccess.Concrete.EntitiyFramework.Mappings;
using Library.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.DataAccess.Concrete.EntitiyFramework
{
    public class LibraryDBContext : DbContext
    {
        public LibraryDBContext()
        {
            Database.SetInitializer<LibraryDBContext>(null);
        }
        public DbSet<Book> Books { get; set; }
        public DbSet<Category> Categories { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            // add Mapping
            modelBuilder.Configurations.Add(new BookMap());
        }
    }
}
