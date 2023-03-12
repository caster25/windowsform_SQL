using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tast02.Foms
{
    public partial class FormCustomers : Form
    {

        FormCustomers form;

        public string id, product, quantity, time;
        public FormCustomers()
        {
            InitializeComponent();
        }
        private void FormOrders_Load(object sender, EventArgs e)
        {
            LoadTheme();
        }

        public void Display()
        {
            Dbdatabast.DisplayAndSearch("SELECT ID, Products, Quantity, Time FROM product_table", dataGridView1);
        }
        private void LoadTheme()
        {
            foreach (Control btns in this.Controls)
            {
                if (btns.GetType() == typeof(Button))
                {
                    Button btn = (Button)btns;
                    btn.BackColor = ThemeColor.PrimaryColor;
                    btn.ForeColor = Color.White;
                    btn.FlatAppearance.BorderColor = ThemeColor.SecondaryColor;
                }
            }

        }

        private void textSaerch1_TextChanged(object sender, EventArgs e)
        {
            Dbdatabast.DisplayAndSearch("SELECT ID, Products, Quantity, Time FROM product_table WHERE ID LIKE '%" + txtSearch1.Text + "%'", dataGridView1);
        }

        private void FormCustomers_Shown(object sender, EventArgs e)
        {
            Display();
        }

        private void bntCustomer_Click(object sender, EventArgs e)
        {
            if (checkCustomer.Checked)
            {
                string id = txtSearch1.Text;
                string product = comboCustomer.Text;
                string quantity = textNum.Text;
                MessageBox.Show("Selected ID: "+id+"\n"+"Selected Products: " + product + "\n" + "Selected Quantity:" + quantity);

                // Save the product to the database
                ClassProduct std = new ClassProduct(comboCustomer.Text.Trim(), textNum.Text.Trim());
                Dbdatabast.UpdateProduct(std, id);

                // Clear the input fields
                txtSearch1.Text = "";
                comboCustomer.SelectedIndex = -1;
                textNum.Text = "";
                checkCustomer.Checked = false;

                // Disable the "SAVE" button
                bntCustomer.Enabled = false;
            }

        }

        private void checkCustomer_CheckedChanged(object sender, EventArgs e)
        {
            bntCustomer.Enabled = checkCustomer.Checked;
        }

    }
}
