﻿using Library.DataAccess.Concrete.EntitiyFramework;
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
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LibraryDBContext context = new LibraryDBContext();
            dgvBooks.DataSource = context.Books.ToList();
        }
    }
}