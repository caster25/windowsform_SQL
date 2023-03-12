using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tast02
{
    internal class Dbdatabast
    {
        public static MySqlConnection GetConnection()
        {

            string sql = "datasource=localhost;port=3306;username=root;password=;database=products";
            MySqlConnection con = new MySqlConnection(sql);
            try
            {
                con.Open();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("MySQL Connection! \n " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            return con;
        }
        public static void AddProduct(ClassProduct std)
        {
            string sql = "INSERT INTO product_table VALUES (NULL ,@ClassProductProdusts,@ClassProductQuantity,Null)";
            MySqlConnection con = GetConnection();
            MySqlCommand cmd = new MySqlCommand(sql, con);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add("@ClassProductProdusts", MySqlDbType.VarChar).Value = std.Product;
            cmd.Parameters.Add("@ClassProductQuantity", MySqlDbType.VarChar).Value = std.Quantity;

            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Add Successfury! \n ", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Student not insert! \n " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            con.Close();
        }
        public static void UpdateProduct(ClassProduct std, string id)
        {
            string sql = "UPDATE  product_table SET Products = @ClassProductProducts, Quantity = @ClassProductQuantity WHERE ID = @ClassProductID";
            MySqlConnection con = GetConnection();
            MySqlCommand cmd = new MySqlCommand(sql, con);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add("@ClassProductID", MySqlDbType.VarChar).Value = id;
            cmd.Parameters.Add("@ClassProductProducts", MySqlDbType.VarChar).Value = std.Product;
            cmd.Parameters.Add("@ClassProductQuantity", MySqlDbType.VarChar).Value = std.Quantity;

            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Updated Successfury! \n ", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Student not Update! \n " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            con.Close();
        }

        public static void DeleteProduct(string id)
        {
            string sql = "DELETE FROM product_table WHERE ID = @ClassProductID";
            MySqlConnection con = GetConnection();
            MySqlCommand cmd = new MySqlCommand(sql, con);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add("@ClassProductID", MySqlDbType.VarChar).Value = id;
            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Deleted Successfury! \n ", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Student not Delete! \n " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            con.Close();
        }
        public static void DisplayAndSearch(string query, DataGridView dgv)
        {
            string sql = query;
            MySqlConnection con = GetConnection();
            MySqlCommand cmd = new MySqlCommand(sql, con);
            MySqlDataAdapter adp = new MySqlDataAdapter(cmd);
            DataTable tbl = new DataTable();
            adp.Fill(tbl);
            dgv.DataSource = tbl;
            con.Close();
        }
    }
}
