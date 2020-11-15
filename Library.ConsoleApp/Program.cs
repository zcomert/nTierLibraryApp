using Library.DataAccess.Concrete.EntitiyFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            LibraryDBContext context = new LibraryDBContext();
            var list = context.Books.ToList();
            list.ForEach(p => Console.WriteLine(p));

            Console.ReadKey();
        }
    }
}
