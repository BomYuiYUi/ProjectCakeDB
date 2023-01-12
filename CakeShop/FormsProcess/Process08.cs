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
    public partial class Process08 : Form
    {
        SqlConnection CakesConnection;
        public Process08()
        {
            InitializeComponent();
        }

        private void Process08_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'cakeDBDataSetReqBuy.ReqBuy' table. You can move, or remove it, as needed.
            this.reqBuyTableAdapter.Fill(this.cakeDBDataSetReqBuy.ReqBuy);
            CakesConnection = new SqlConnection("Data Source=LAPTOP-UIF87597;" + "Initial Catalog=CakeDB;" +
           "User ID=user1;Password=mypass1");
            CakesConnection.Open();
            SqlCommand resultCommand = null;
            SqlDataAdapter resultAdapter = new SqlDataAdapter();
            DataTable resultTable = new DataTable();
            resultCommand = new SqlCommand("SELECT * FROM Rmaterial", CakesConnection);
            resultAdapter.SelectCommand = resultCommand;
            resultAdapter.Fill(resultTable);
            dataGridRaw.DataSource = resultTable;
        }

        private void buttonInsert_Click(object sender, EventArgs e)
        {
            SqlCommand command;
            SqlDataAdapter adapter = new SqlDataAdapter();
            string Date = reqBuyDateDateTimePicker.Value.Day.ToString();
            string Month = reqBuyDateDateTimePicker.Value.Month.ToString();
            string Year = reqBuyDateDateTimePicker.Value.Year.ToString();
            string All = Month + "/" + Date + "/" + Year;
            var sql = $"INSERT INTO ReqBuy(ReqBuyID,ReqBuyDate,ReqBuyNRM,ReqBuyName,ReqBuyQuantity,EmpID) VALUES('{reqBuyIDTextBox.Text}','{All}','{reqBuyNRMTextBox.Text}','{reqBuyNameTextBox.Text}','{reqBuyQuantityTextBox.Text}','{empIDTextBox.Text}')";
            command = new SqlCommand(sql, CakesConnection);
            adapter.InsertCommand = command;
            adapter.InsertCommand.ExecuteNonQuery();
            this.reqBuyTableAdapter.Fill(this.cakeDBDataSetReqBuy.ReqBuy);
            command.Dispose();
        }

        private void buttonDeL_Click(object sender, EventArgs e)
        {
            SqlCommand command;
            SqlDataAdapter adapter = new SqlDataAdapter();
            var sql = $"Delete ReqBuy where ReqBuyID = '{reqBuyIDTextBox.Text}'";
            command = new SqlCommand(sql, CakesConnection);
            adapter.InsertCommand = command;
            adapter.InsertCommand.ExecuteNonQuery();
            this.reqBuyTableAdapter.Fill(this.cakeDBDataSetReqBuy.ReqBuy);
            command.Dispose();
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            SqlCommand command;
            SqlDataAdapter adapter = new SqlDataAdapter();
            string Date = reqBuyDateDateTimePicker.Value.Day.ToString();
            string Month = reqBuyDateDateTimePicker.Value.Month.ToString();
            string Year = reqBuyDateDateTimePicker.Value.Year.ToString();
            string All = Month + "/" + Date + "/" + Year;
            var sql = $"Update ReqBuy set ReqBuyDate = '{All}',ReqBuyNRM = '{reqBuyNRMTextBox.Text}',ReqBuyName = '{reqBuyNameTextBox.Text}',ReqBuyQuantity = '{reqBuyQuantityTextBox.Text}'" +
                $",EmpID = '{empIDTextBox.Text}'where ReqBuyID ='{reqBuyIDTextBox.Text}'";
            command = new SqlCommand(sql, CakesConnection);
            adapter.InsertCommand = command;
            adapter.InsertCommand.ExecuteNonQuery();
            this.reqBuyTableAdapter.Fill(this.cakeDBDataSetReqBuy.ReqBuy);
            command.Dispose();
        }

        private void Process08_FormClosing(object sender, FormClosingEventArgs e)
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
                sql = $"SELECT * FROM Rmaterial WHERE RmaterialID ='{searchtextBox.Text}'";
            }
            else if (All == 1)
            {
                sql = $"SELECT * FROM Rmaterial WHERE RmaterialQuantity ='{searchtextBox.Text}'";
            }
            else if (All == 2)
            {
                sql = $"SELECT * FROM Rmaterial WHERE RmaterialPrice ='{searchtextBox.Text}'";
            }
            else if (All == 3)
            {
                sql = $"SELECT * FROM Rmaterial WHERE RmaterialExp ='{searchtextBox.Text}'";
            }
            else if (All == 4)
            {
                sql = $"SELECT * FROM Rmaterial WHERE RmaterialType ='{searchtextBox.Text}'";
            }
            else if (All == 5)
            {
                sql = $"SELECT * FROM Rmaterial WHERE RmaterialName ='{searchtextBox.Text}'";
            }
            else if (All == 6)
            {
                sql = $"SELECT * FROM Rmaterial WHERE ReqID ='{searchtextBox.Text}'";
            }
            else if (All == 7)
            {
                sql = $"SELECT * FROM Rmaterial WHERE OrderPayID ='{searchtextBox.Text}'";
            }
            resultCommand = new SqlCommand(sql, CakesConnection);
            resultAdapter.SelectCommand = resultCommand;
            resultAdapter.Fill(resultTable);
            dataGridRaw.DataSource = resultTable;
        }

        private void buttonR_Click(object sender, EventArgs e)
        {
            SqlCommand resultCommand = null;
            SqlDataAdapter resultAdapter = new SqlDataAdapter();
            DataTable resultTable = new DataTable();
            resultCommand = new SqlCommand("SELECT * FROM Rmaterial", CakesConnection);
            resultAdapter.SelectCommand = resultCommand;
            resultAdapter.Fill(resultTable);
            dataGridRaw.DataSource = resultTable;
        }
    }
}
