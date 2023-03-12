using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Windows.Forms.LinkLabel;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace Tast02.Foms
{
    public partial class FormProducts : Form
    {
        public FormProducts()
        {
            InitializeComponent();
            LoadTheme();
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

        private void checkProduct_CheckedChanged(object sender, EventArgs e)
        {
            bntProduct.Enabled = checkProduct.Checked;
        }

        private void bntProduct_Click(object sender, EventArgs e)
        {
            if (checkProduct.Checked)
            {
                string product = comboID.Text;
                string quantity = textNum.Text;
                MessageBox.Show("Selected Products: " + product + "\n" + "Selected Quantity:" + quantity);

                // Save the product to the database
                ClassProduct std = new ClassProduct(comboID.Text.Trim(), textNum.Text.Trim());
                Dbdatabast.AddProduct(std);

                // Clear the input fields
                comboID.SelectedIndex = -1;
                textNum.Text = "";
                checkProduct.Checked = false;

                // Disable the "SAVE" button
                bntProduct.Enabled = false;
            }
        }

        
    }
}
