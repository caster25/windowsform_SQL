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
    public partial class FormOrders : Form
    {
        public FormOrders()
        {
            InitializeComponent();
        }
        private void FormOrders_Load(object sender, EventArgs e)
        {
            LoadTheme();
        }

        public void Display()
        {
            Dbdatabast.DisplayAndSearch("SELECT ID, Products, Quantity, Time FROM product_table", dataGridView2);
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
            label4.ForeColor = ThemeColor.SecondaryColor;
        }

        private void FormOrders_Shown(object sender, EventArgs e)
        {
            Display();
        }

        private void textSeach_TextChanged(object sender, EventArgs e)
        {
            Dbdatabast.DisplayAndSearch("SELECT ID, Products, Quantity, Time FROM product_table WHERE ID LIKE '%" + txtSearch.Text + "%'", dataGridView2);
        }
    }
}
