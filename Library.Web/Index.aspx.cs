using Library.Business.Abstract;
using Library.Business.DependencyResolvers.Ninject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Library.Web
{

    public partial class Index : System.Web.UI.Page
    {
        IBookService _bookService;
        ICategoryService _categoryService;
        protected void Page_Load(object sender, EventArgs e)
        {
            _bookService = 
                InstanceFactory.GetInstance<IBookService>();
            _categoryService = 
                InstanceFactory.GetInstance<ICategoryService>();

            Response.Write("<h1>Books</h1>");
            var books =  _bookService.GetAll();
            foreach (var book in books)
            {
                Response.Write(string.Format($"<p>{book}</p>"));
            }
        }
    }
}