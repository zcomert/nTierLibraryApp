using Library.DataAccess.Abstract;
using Library.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Business.Abstract
{
    public interface ICategoryService 
    {
        List<Category> GetAll();   
    }
}
