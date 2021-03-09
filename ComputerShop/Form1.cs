using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ComputerShop
{
    public partial class Form1 : Form
    {
        private frmDesktop frmDesktop;
        private frmLaptop frmLaptop;
        private frmPrinter frmPrinter;
        private frmProduct frmProduct;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmDesktop = new frmDesktop();
            this.Hide();
            frmDesktop.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmLaptop = new frmLaptop();
            this.Hide();
            frmLaptop.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            frmPrinter = new frmPrinter();
            this.Hide();
            frmPrinter.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            frmProduct = new frmProduct();
            this.Hide();
            frmProduct.ShowDialog();
        }
    }
}
