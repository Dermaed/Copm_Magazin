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
    public partial class tablefrm : Form
    {
        private DataGridViewColumn COL;
        private DataGridViewColumn dataGridViewTextBoxColumn3;
        private DataGridViewColumn dataGridViewTextBoxColumn5;

        public tablefrm()
        {
            InitializeComponent();
        }

        private void pCBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.pCBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.st01DataSet);

        }

        private void tablefrm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "st01DataSet.makerProd". При необходимости она может быть перемещена или удалена.
            this.makerProdTableAdapter.Fill(this.st01DataSet.makerProd);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "st01DataSet.PC". При необходимости она может быть перемещена или удалена.
            this.pCTableAdapter.Fill(this.st01DataSet.PC);

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            button1.Enabled = true;
        }

        private void button1_Click(object sender, EventArgs e)
        { 
           /* COL = new System.Windows.Forms.DataGridViewColumn();
            switch (listBox1.SelectedIndex)
            {
                case 0:
                    COL = dataGridViewTextBoxColumn2;
                    break;
                case 1:
                    COL = dataGridViewTextBoxColumn3;
                    break;
                case 2:
                    COL = dataGridViewTextBoxColumn4;
                    break;
                case 3:
                    COL = dataGridViewTextBoxColumn5;
                    break;
            }
            if (radioButton1.Checked)
                pCDataGridView.Sort(COL,
                System.ComponentModel.ListSortDirection.Ascending);
            else
                pCDataGridView.Sort(COL,
                System.ComponentModel.ListSortDirection.Descending);*/
        }

        private void button2_Click(object sender, EventArgs e)
        {
            pCBindingSource.Filter = "NAME='" + comboBox1 + "'";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            pCBindingSource.Filter = "";
        }

        private void button4_Click(object sender, EventArgs e)
        {
           /* for (int i = 0; i < pCDataGridView.ColumnCount - 1; i++)
            {
                for (int j = 0; j < pCDataGridView.RowCount - 1; j++)
                {
                    pCDataGridView[i, j].Style.BackColor = Color.White;
                    pCDataGridView[i, j].Style.ForeColor = Color.Black;
                }
            }
            for (int i = 0; i < pCDataGridView.ColumnCount - 1; i++)
            {
                for (int j = 0; j < pCDataGridView.RowCount - 1; j++)
                {
                    if (pCDataGridView[i,
                    j].Value.ToString().IndexOf(textBox1.Text) != -1)
                    {
                        pCDataGridView[i, j].Style.BackColor = Color.AliceBlue;
                        pCDataGridView[i, j].Style.ForeColor = Color.Blue;

                    }
                }
            }*/
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
