using Library.Business.Abstract;
using Library.Business.Concrete;
using Library.Business.DependencyResolvers.Ninject;
using Library.DataAccess.Abstract;
using Library.DataAccess.Concrete;
using Library.DataAccess.Concrete.EntitiyFramework;
using Library.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library.WindowsApp
{
    public partial class Form1 : Form
    {
        IBookService _bookService;
        ICategoryService _categoryService;
        public Form1()
        {
            InitializeComponent();
            // _bookService = new BookManager(new EfBookDal());
            // _categoryService = new CategoryManager(new EfCategoryDal());

            _bookService = InstanceFactory.GetInstance<IBookService>();
            _categoryService = InstanceFactory.GetInstance<ICategoryService>();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // LibraryDBContext context = new LibraryDBContext();
            // dgvBooks.DataSource = context.Books.ToList();
            //  var entity = context.Entry(book);

            dgvBooks.DataSource = _bookService.GetAll();
            
        }
    }
}
