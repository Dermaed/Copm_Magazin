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
    public partial class frmProduct : Form
    {
        public frmProduct()
        {
            InitializeComponent();
        }

        private void productBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.productBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.st01DataSet);

        }

        private void frmProduct_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "st01DataSet.Product". При необходимости она может быть перемещена или удалена.
            this.productTableAdapter.Fill(this.st01DataSet.Product);

        }
    }
}
