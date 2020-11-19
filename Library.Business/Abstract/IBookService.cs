using Library.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Business.Abstract
{
    public interface IBookService
    {
        List<Book> GetAll();
        List<Book> GetProductsByCategory(int id);
        void Add(Book book);
        Book GetById(int Id);
        void Update(Book book);
    }
}
