﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Stock
{
    public partial class StockMain : Form
    {
        
        public StockMain()
        {
            InitializeComponent();
        }

        private void StockMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit(); 
        }

        private void ürünlerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Ürünlere basıldığında ürünler menüsü açılması
            Product pro = new Product();
            pro.MdiParent = this;
            pro.Show();

        }

        private void stokToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
