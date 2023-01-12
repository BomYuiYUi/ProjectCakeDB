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
    public partial class Process01 : Form
    {
        public Process01()
        {
            InitializeComponent();
        }
        SqlConnection CakesConnection;
        private void Process01_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'cakeDBDataSetOrder.Orders' table. You can move, or remove it, as needed.
            this.ordersTableAdapter.Fill(this.cakeDBDataSetOrder.Orders);

            CakesConnection = new SqlConnection("Data Source=LAPTOP-UIF87597;" + "Initial Catalog=CakeDB;" +
            "User ID=user1;Password=mypass1");
            CakesConnection.Open();
            SqlCommand resultCommand = null;
            SqlDataAdapter resultAdapter = new SqlDataAdapter();
            DataTable resultTable = new DataTable();
            resultCommand = new SqlCommand("SELECT * FROM Cake", CakesConnection);
            resultAdapter.SelectCommand = resultCommand;
            resultAdapter.Fill(resultTable);
            dataGridViewCake.DataSource = resultTable;
        }

        private void Process01_FormClosing(object sender, FormClosingEventArgs e)
        {
            CakesConnection.Close();
            CakesConnection.Dispose();
        }

        private void buttonInsert_Click(object sender, EventArgs e)
        {
            SqlCommand command;
            SqlDataAdapter adapter = new SqlDataAdapter();
            string Date = orderExpDateTimePicker.Value.Day.ToString();
            string Month = orderExpDateTimePicker.Value.Month.ToString();
            string Year = orderExpDateTimePicker.Value.Year.ToString();
            string All = Month + "/" + Date + "/" + Year;


            SqlCommand command1;
            SqlDataReader dataReader;
            String strSQL;
            double Price = 0;
            strSQL = $"Select CakePrice from Cake where CakeID ='{cakeIDTextBox.Text}'";
            command1 = new SqlCommand(strSQL, CakesConnection);
            dataReader = command1.ExecuteReader();
            if (dataReader.Read())
            {
                Price = Convert.ToDouble(dataReader.GetValue(0));
            }
            dataReader.Close();

            SqlCommand command2;
            SqlDataReader dataReader2;
            int Quantity = 0;
            strSQL = $"Select CakeQuantity from Cake where CakeID ='{cakeIDTextBox.Text}'";
            command2 = new SqlCommand(strSQL, CakesConnection);
            dataReader2 = command2.ExecuteReader();
            if (dataReader2.Read())
            {
                Quantity = Convert.ToInt32(dataReader2.GetValue(0));
            }
            dataReader2.Close();
            int quan = Convert.ToInt32(orderQuantityTextBox.Text);
            int resultQuantity = Quantity - quan;
            if (resultQuantity < 0)
            {
                MessageBox.Show("จำนวนที่ใส่มากกว่าจำนวนที่มี");
                return;
            }
            double resultD = Price * quan;
            string result = Convert.ToString(resultD);

            var sql = "";
            string A1 = Convert.ToString(memberIDTextBox.Text);
            if (A1 == "")
            {
                sql = $"INSERT INTO Orders(OrderID,OrderStyle,OrderType,OrderQuantity,OrderPrice,OrderExp,CakeID) VALUES('{orderIDTextBox.Text}','{orderStyleTextBox.Text}','{orderTypeTextBox.Text}','{orderQuantityTextBox.Text}','{result}','{All}','{cakeIDTextBox.Text}')";
            }
            else
            {
                sql = $"INSERT INTO Orders(OrderID,OrderStyle,OrderType,OrderQuantity,OrderPrice,OrderExp,CakeID,MemberID) VALUES('{orderIDTextBox.Text}','{orderStyleTextBox.Text}','{orderTypeTextBox.Text}','{orderQuantityTextBox.Text}','{result}','{All}','{cakeIDTextBox.Text}','{memberIDTextBox.Text}')";
            }
            command = new SqlCommand(sql, CakesConnection);
            adapter.InsertCommand = command;
            adapter.InsertCommand.ExecuteNonQuery();
            this.ordersTableAdapter.Fill(this.cakeDBDataSetOrder.Orders);
            command.Dispose();
        }

        private void buttonDeL_Click(object sender, EventArgs e)
        {
            SqlCommand command;
            SqlDataAdapter adapter = new SqlDataAdapter();
            var sql = $"Delete Orders where OrderID = '{orderIDTextBox.Text}'";
            command = new SqlCommand(sql, CakesConnection);
            adapter.InsertCommand = command;
            adapter.InsertCommand.ExecuteNonQuery();
            this.ordersTableAdapter.Fill(this.cakeDBDataSetOrder.Orders);
            command.Dispose();
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            SqlCommand command;
            SqlDataAdapter adapter = new SqlDataAdapter();
            string Date = orderExpDateTimePicker.Value.Day.ToString();
            string Month = orderExpDateTimePicker.Value.Month.ToString();
            string Year = orderExpDateTimePicker.Value.Year.ToString();
            string All = Month + "/" + Date + "/" + Year;

            SqlCommand command1;
            SqlDataReader dataReader;
            String strSQL;
            double Price = 0;
            strSQL = $"Select CakePrice from Cake where CakeID ='{cakeIDTextBox.Text}'";
            command1 = new SqlCommand(strSQL, CakesConnection);
            dataReader = command1.ExecuteReader();
            if (dataReader.Read())
            {
                Price = Convert.ToDouble(dataReader.GetValue(0));
            }
            dataReader.Close();

            SqlCommand command2;
            SqlDataReader dataReader2;
            int Quantity = 0;
            strSQL = $"Select CakeQuantity from Cake where CakeID ='{cakeIDTextBox.Text}'";
            command2 = new SqlCommand(strSQL, CakesConnection);
            dataReader2 = command2.ExecuteReader();
            if (dataReader2.Read())
            {
                Quantity = Convert.ToInt32(dataReader2.GetValue(0));
            }
            dataReader2.Close();
            int quan = Convert.ToInt32(orderQuantityTextBox.Text);
            int resultQuantity = Quantity - quan;
            if (resultQuantity < 0)
            {
                MessageBox.Show("จำนวนที่ใส่มากกว่าจำนวนที่มี");
                return;
            }
            double resultD = Price * quan;
            string result = Convert.ToString(resultD);

            var sql = "";
            string A1 = Convert.ToString(memberIDTextBox.Text);
            if (A1 == "")
            {
                sql = $"Update Orders set OrderStyle = '{orderStyleTextBox.Text}',OrderType = '{orderTypeTextBox.Text}',OrderQuantity = '{orderQuantityTextBox.Text}',OrderPrice = '{result}'" +
                $",OrderExp = '{All}',CakeID = '{cakeIDTextBox.Text}' where OrderID='{orderIDTextBox.Text}'";
            }
            else
            {
                sql = $"Update Orders set OrderStyle = '{orderStyleTextBox.Text}',OrderType = '{orderTypeTextBox.Text}',OrderQuantity = '{orderQuantityTextBox.Text}',OrderPrice = '{result}'" +
                $",OrderExp = '{All}',CakeID = '{cakeIDTextBox.Text}',MemberID = '{memberIDTextBox.Text}' where OrderID='{orderIDTextBox.Text}'";
            }
            command = new SqlCommand(sql, CakesConnection);
            adapter.InsertCommand = command;
            adapter.InsertCommand.ExecuteNonQuery();
            this.ordersTableAdapter.Fill(this.cakeDBDataSetOrder.Orders);
            command.Dispose();
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
                sql = $"SELECT * FROM Cake WHERE CakeID ='{searchtextBox.Text}'";
            }
            else if (All == 1)
            {
                sql = $"SELECT * FROM Cake WHERE CakeStyle ='{searchtextBox.Text}'";
            }
            else if (All == 2)
            {
                sql = $"SELECT * FROM Cake WHERE CakeType ='{searchtextBox.Text}'";
            }
            else if (All == 3)
            {
                sql = $"SELECT * FROM Cake WHERE CakeQuantity ='{searchtextBox.Text}'";
            }
            else if (All == 4)
            {
                sql = $"SELECT * FROM Cake WHERE CakePrice ='{searchtextBox.Text}'";
            }
            else if (All == 5)
            {
                sql = $"SELECT * FROM Cake WHERE CakeExp ='{searchtextBox.Text}'";
            }
            else if (All == 6)
            {
                sql = $"SELECT * FROM Cake WHERE MadeID ='{searchtextBox.Text}'";
            }
            resultCommand = new SqlCommand(sql, CakesConnection);
            resultAdapter.SelectCommand = resultCommand;
            resultAdapter.Fill(resultTable);
            dataGridViewCake.DataSource = resultTable;
        }

        private void buttonR_Click(object sender, EventArgs e)
        {
            SqlCommand resultCommand = null;
            SqlDataAdapter resultAdapter = new SqlDataAdapter();
            DataTable resultTable = new DataTable();
            resultCommand = new SqlCommand("SELECT * FROM Cake", CakesConnection);
            resultAdapter.SelectCommand = resultCommand;
            resultAdapter.Fill(resultTable);
            dataGridViewCake.DataSource = resultTable;
        }
    }
}
