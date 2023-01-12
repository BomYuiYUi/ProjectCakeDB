using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace CakeShop
{
    public partial class Process10 : Form
    {
        SqlConnection CakesConnection;
        public Process10()
        {
            InitializeComponent();
        }
        private void Process10_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'cakeDBDataSetOrderPay.OrderPay' table. You can move, or remove it, as needed.
            this.orderPayTableAdapter.Fill(this.cakeDBDataSetOrderPay.OrderPay);
            CakesConnection = new SqlConnection("Data Source=LAPTOP-UIF87597;" + "Initial Catalog=CakeDB;" +
           "User ID=user1;Password=mypass1");
            CakesConnection.Open();
            SqlCommand resultCommand = null;
            SqlDataAdapter resultAdapter = new SqlDataAdapter();
            DataTable resultTable = new DataTable();
            resultCommand = new SqlCommand("SELECT * FROM ReqBuy", CakesConnection);
            resultAdapter.SelectCommand = resultCommand;
            resultAdapter.Fill(resultTable);
            dataGridVReqBuy.DataSource = resultTable;
        }

        private void buttonInsert_Click(object sender, EventArgs e)
        {
            SqlCommand command;
            SqlDataAdapter adapter = new SqlDataAdapter();
            var sql = $"INSERT INTO OrderPay(OrderPayID,OrderPayName,OrderPayPrice,OrderPayQuantity,ReqBuyID) VALUES('{orderPayIDTextBox.Text}','{orderPayNameTextBox.Text}','{orderPayPriceTextBox.Text}','{orderPayQuantityTextBox.Text}','{reqBuyIDTextBox.Text}')";
            command = new SqlCommand(sql, CakesConnection);
            adapter.InsertCommand = command;
            adapter.InsertCommand.ExecuteNonQuery();
            this.orderPayTableAdapter.Fill(this.cakeDBDataSetOrderPay.OrderPay);
            command.Dispose();
        }

        private void buttonDeL_Click(object sender, EventArgs e)
        {
            SqlCommand command;
            SqlDataAdapter adapter = new SqlDataAdapter();
            var sql = $"Delete OrderPay where OrderPayID = '{orderPayIDTextBox.Text}'";
            command = new SqlCommand(sql, CakesConnection);
            adapter.InsertCommand = command;
            adapter.InsertCommand.ExecuteNonQuery();
            this.orderPayTableAdapter.Fill(this.cakeDBDataSetOrderPay.OrderPay);
            command.Dispose();
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            SqlCommand command;
            SqlDataAdapter adapter = new SqlDataAdapter();
            var sql = $"Update OrderPay set OrderPayName = '{orderPayNameTextBox.Text}',OrderPayPrice = '{orderPayPriceTextBox.Text}',OrderPayQuantity = '{orderPayQuantityTextBox.Text}',ReqBuyID = '{reqBuyIDTextBox.Text}' where OrderPayID='{orderPayIDTextBox.Text}'";
            command = new SqlCommand(sql, CakesConnection);
            adapter.InsertCommand = command;
            adapter.InsertCommand.ExecuteNonQuery();
            this.orderPayTableAdapter.Fill(this.cakeDBDataSetOrderPay.OrderPay);
            command.Dispose();
        }

        private void Process10_FormClosing(object sender, FormClosingEventArgs e)
        {
            CakesConnection.Close();
            CakesConnection.Dispose();
        }

        private void cakesearchbutton_Click(object sender, EventArgs e)
        {
            SqlCommand resultCommand = null;
            SqlDataAdapter resultAdapter = new SqlDataAdapter();
            DataTable resultTable = new DataTable();
            string sql = "";
            int All = searchcomboBox.SelectedIndex;

            if (All == 0)
            {
                sql = $"SELECT * FROM ReqBuy WHERE ReqBuyID ='{searchtextBox.Text}'";
            }
            else if (All == 1)
            {
                sql = $"SELECT * FROM ReqBuy WHERE ReqBuyDate ='{searchtextBox.Text}'";
            }
            else if (All == 2)
            {
                sql = $"SELECT * FROM ReqBuy WHERE ReqBuyNRM ='{searchtextBox.Text}'";
            }
            else if (All == 3)
            {
                sql = $"SELECT * FROM ReqBuy WHERE ReqBuyName ='{searchtextBox.Text}'";
            }
            else if (All == 4)
            {
                sql = $"SELECT * FROM ReqBuy WHERE ReqBuyQuantity ='{searchtextBox.Text}'";
            }
            else if (All == 5)
            {
                sql = $"SELECT * FROM ReqBuy WHERE EmpID ='{searchtextBox.Text}'";
            }
            resultCommand = new SqlCommand(sql, CakesConnection);
            resultAdapter.SelectCommand = resultCommand;
            resultAdapter.Fill(resultTable);
            dataGridVReqBuy.DataSource = resultTable;
        }

        private void buttonR_Click(object sender, EventArgs e)
        {
            SqlCommand resultCommand = null;
            SqlDataAdapter resultAdapter = new SqlDataAdapter();
            DataTable resultTable = new DataTable();
            resultCommand = new SqlCommand("SELECT * FROM ReqBuy", CakesConnection);
            resultAdapter.SelectCommand = resultCommand;
            resultAdapter.Fill(resultTable);
            dataGridVReqBuy.DataSource = resultTable;
        }
    }
}
