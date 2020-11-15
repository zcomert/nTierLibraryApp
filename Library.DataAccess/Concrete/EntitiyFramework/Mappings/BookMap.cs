using Library.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.DataAccess.Concrete.EntitiyFramework.Mappings
{
    public class BookMap : EntityTypeConfiguration<Book>
    {
        public BookMap()
        {
            ToTable(@"Books", @"dbo");
            HasKey(x=> x.Id);

            Property(x => x.Id).HasColumnName("Id");
            Property(x => x.Title).HasColumnName("Title");
            Property(x => x.Description).HasColumnName("Description");
            Property(x => x.CategoryId).HasColumnName("CategoryId");




        }
    }
}
