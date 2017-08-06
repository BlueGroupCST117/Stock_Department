using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Stock_Department
{
    public partial class StockDepartment : Form
    {
        public StockDepartment()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            StockBox.Visible = false;
            StockInventoryBox.Visible = true;
            ProductsBox.Visible = false;

        }

        private void tableLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            StockBox.Visible = true;
            StockInventoryBox.Visible = false;
            ProductsBox.Visible = false;
        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            StockBox.Visible = false;
            StockInventoryBox.Visible = false;
            ProductsBox.Visible = true;
        }

        private void label17_Click(object sender, EventArgs e)
        {

        }

        private void StockBox_Paint(object sender, PaintEventArgs e)
        {

        }

        private void stockDepartmentExit_Click(object sender, EventArgs e)
        {
            this.Close();
           
        }

        private void StockDepartment_Load(object sender, EventArgs e)
        {
            DataTable Item=new DataTable();
            Item.Columns.Add("ID");
            Item.Columns.Add("Description");
            Item.Columns.Add("Quantity");
            Item.Columns.Add("Price");






            Item.Rows.Add("01", "Red Ball", "12", "2.99");
            Item.Rows.Add("01", "Green Ball", "10", "4.99");
            Item.Rows.Add("01", "Black Ball", "2", "12.99");
            Item.Rows.Add("01", "Gold Ball", "112", "1.99");
            Item.Rows.Add("01", "Hat Small", "12", "24.99");
            Item.Rows.Add("01", "Hat Large", "12", "22.99");
            dataGridView1.DataSource = Item;
            dataGridView3.DataSource = Item;
            dataGridView4.DataSource = Item;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
    
        {

        }
          

      

      

        private void dataGridView3_CellContentClick(object sender, DataGridViewCellEventArgs e)

        {
            
        }

        private void dataGridView4_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
