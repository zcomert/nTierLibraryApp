using Library.DataAccess.Abstract;
using Library.DataAccess.Concrete.EntitiyFramework;
using Library.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.DataAccess.Concrete
{
    public class EfCategoryDal : 
        EfRepositoryBase<Category, LibraryDBContext>,
        ICategoryDal
    {

    }
}
