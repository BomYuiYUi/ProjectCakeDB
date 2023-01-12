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
    public partial class Process11 : Form
    {
        SqlConnection CakesConnection;
        public Process11()
        {
            InitializeComponent();
        }
        private void Process11_Load(object sender, EventArgs e)
        {
            
            // TODO: This line of code loads data into the 'cakeDBDataSetRmaterial.Rmaterial' table. You can move, or remove it, as needed.
            this.rmaterialTableAdapter.Fill(this.cakeDBDataSetRmaterial.Rmaterial);
            CakesConnection = new SqlConnection("Data Source=LAPTOP-UIF87597;" + "Initial Catalog=CakeDB;" +
           "User ID=user1;Password=mypass1");
            CakesConnection.Open();

        }

        private void buttonInsert_Click(object sender, EventArgs e)
        {
            SqlCommand command;
            SqlDataAdapter adapter = new SqlDataAdapter();
            string Date = rmaterialExpDateTimePicker.Value.Day.ToString();
            string Month = rmaterialExpDateTimePicker.Value.Month.ToString();
            string Year = rmaterialExpDateTimePicker.Value.Year.ToString();
            string All = Month + "/" + Date + "/" + Year;
            var sql = "";
            string A1 = Convert.ToString(reqIDTextBox.Text);
            if (A1 == "")
            {
                sql = $"INSERT INTO Rmaterial(RmaterialID,RmaterialQuantity,RmaterialPrice,RmaterialExp,RmaterialType,RmaterialName,OrderPayID) VALUES('{rmaterialIDTextBox.Text}','{rmaterialQuantityTextBox.Text}','{rmaterialPriceTextBox.Text}','{All}','{rmaterialTypeTextBox.Text}','{rmaterialNameTextBox.Text}','{orderPayIDTextBox.Text}')";
            }
            else
            {
                sql = $"INSERT INTO Rmaterial(RmaterialID,RmaterialQuantity,RmaterialPrice,RmaterialExp,RmaterialType,RmaterialName,ReqID,OrderPayID) VALUES('{rmaterialIDTextBox.Text}','{rmaterialQuantityTextBox.Text}','{rmaterialPriceTextBox.Text}','{All}','{rmaterialTypeTextBox.Text}','{rmaterialNameTextBox.Text}','{reqIDTextBox.Text}','{orderPayIDTextBox.Text}')";
            }

            command = new SqlCommand(sql, CakesConnection);
            adapter.InsertCommand = command;
            adapter.InsertCommand.ExecuteNonQuery();
            this.rmaterialTableAdapter.Fill(this.cakeDBDataSetRmaterial.Rmaterial);
            command.Dispose();
        }

        private void buttonDeL_Click(object sender, EventArgs e)
        {
            SqlCommand command;
            SqlDataAdapter adapter = new SqlDataAdapter();
            var sql = $"Delete Rmaterial where RmaterialID = '{rmaterialIDTextBox.Text}'";
            command = new SqlCommand(sql, CakesConnection);
            adapter.InsertCommand = command;
            adapter.InsertCommand.ExecuteNonQuery();
            this.rmaterialTableAdapter.Fill(this.cakeDBDataSetRmaterial.Rmaterial);
            command.Dispose();
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            SqlCommand command;
            SqlDataAdapter adapter = new SqlDataAdapter();
            string Date = rmaterialExpDateTimePicker.Value.Day.ToString();
            string Month = rmaterialExpDateTimePicker.Value.Month.ToString();
            string Year = rmaterialExpDateTimePicker.Value.Year.ToString();
            string All = Month + "/" + Date + "/" + Year;
            var sql = "";
            string A1 = Convert.ToString(reqIDTextBox.Text);
            if (A1 == "")
            {
                sql = $"Update Rmaterial set RmaterialQuantity = '{rmaterialQuantityTextBox.Text}',RmaterialPrice = '{rmaterialPriceTextBox.Text}',RmaterialExp = '{All}',RmaterialName = '{rmaterialNameTextBox.Text}'" +
                $",OrderPayID = '{orderPayIDTextBox.Text}'where RmaterialID='{rmaterialIDTextBox.Text}'";
            }
            else
            {
                sql = $"Update Rmaterial set RmaterialQuantity = '{rmaterialQuantityTextBox.Text}',RmaterialPrice = '{rmaterialPriceTextBox.Text}',RmaterialExp = '{All}',RmaterialName = '{rmaterialNameTextBox.Text}'" +
                $",ReqID = '{reqIDTextBox.Text}',OrderPayID = '{orderPayIDTextBox.Text}'where RmaterialID='{rmaterialIDTextBox.Text}'";
            }
                
            command = new SqlCommand(sql, CakesConnection);
            adapter.InsertCommand = command;
            adapter.InsertCommand.ExecuteNonQuery();
            this.rmaterialTableAdapter.Fill(this.cakeDBDataSetRmaterial.Rmaterial);
            command.Dispose();
        }

        private void Process11_FormClosing(object sender, FormClosingEventArgs e)
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
            dataGridView1.DataSource = resultTable;
        }

        private void buttonR_Click(object sender, EventArgs e)
        {
            SqlCommand resultCommand = null;
            SqlDataAdapter resultAdapter = new SqlDataAdapter();
            DataTable resultTable = new DataTable();
            resultCommand = new SqlCommand("SELECT * FROM Rmaterial", CakesConnection);
            resultAdapter.SelectCommand = resultCommand;
            resultAdapter.Fill(resultTable);
            dataGridView1.DataSource = resultTable;
        }
    }
}
