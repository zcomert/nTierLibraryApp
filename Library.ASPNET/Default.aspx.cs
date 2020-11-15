using Library.DataAccess.Concrete.EntitiyFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Library.ASPNET
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            using (LibraryDBContext context = new LibraryDBContext())
            {
                rpt_book_list.DataSource =
                    context.Books.ToList();
                rpt_book_list.DataBind();
            }
        }
    }
}