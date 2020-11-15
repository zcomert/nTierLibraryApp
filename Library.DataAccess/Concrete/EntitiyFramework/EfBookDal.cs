using Library.DataAccess.Abstract;
using Library.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.DataAccess.Concrete.EntitiyFramework
{
    public class EfBookDal : 
        EfRepositoryBase<Book,LibraryDBContext>,
        IBookDal
    {

    }
}
