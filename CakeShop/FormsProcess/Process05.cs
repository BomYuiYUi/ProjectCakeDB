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
    public partial class Process05 : Form
    {
        SqlConnection CakesConnection;
        public Process05()
        {
            InitializeComponent();
        }
        private void Process05_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'cakeDBDataSetPay.Pay' table. You can move, or remove it, as needed.
            this.payTableAdapter.Fill(this.cakeDBDataSetPay.Pay);
            CakesConnection = new SqlConnection("Data Source=LAPTOP-UIF87597;" + "Initial Catalog=CakeDB;" +
           "User ID=user1;Password=mypass1");
            CakesConnection.Open();
            SqlCommand resultCommand = null;
            SqlDataAdapter resultAdapter = new SqlDataAdapter();
            DataTable resultTable = new DataTable();
            resultCommand = new SqlCommand("SELECT * FROM Orders", CakesConnection);
            resultAdapter.SelectCommand = resultCommand;
            resultAdapter.Fill(resultTable);
            dataGridOrders.DataSource = resultTable;

        }

        private void buttonInsert_Click(object sender, EventArgs e)
        {
            SqlCommand command;
            SqlDataAdapter adapter = new SqlDataAdapter();
            string Date = payDateDateTimePicker.Value.Day.ToString();
            string Month = payDateDateTimePicker.Value.Month.ToString();
            string Year = payDateDateTimePicker.Value.Year.ToString();
            string All = Month + "/" + Date + "/" + Year;

            SqlCommand command1;
            SqlDataReader dataReader;
            String strSQL;
            double Price = 0;
            string CakID = "";
            int Orquan = 0; 

            strSQL = $"Select OrderPrice,CakeID,OrderQuantity from Orders where OrderID ='{orderIDTextBox.Text}'";
            command1 = new SqlCommand(strSQL, CakesConnection);
            dataReader = command1.ExecuteReader();
            if (dataReader.Read())
            {
                Price = Convert.ToDouble(dataReader.GetValue(0));
                CakID = Convert.ToString(dataReader.GetValue(1));
                Orquan = Convert.ToInt32(dataReader.GetValue(2));

            }
            dataReader.Close();
            SqlCommand command2;
            SqlDataReader dataReader1;
            int Caquan = 0;
            strSQL = $"Select CakeQuantity from Cake where CakeID ='{CakID}'";
            command2 = new SqlCommand(strSQL, CakesConnection);
            dataReader1 = command2.ExecuteReader();
            if (dataReader1.Read())
            {
                Caquan = Convert.ToInt32(dataReader1.GetValue(0));
            }
            dataReader1.Close();



            double receive = Convert.ToDouble(payReceiveTextBox.Text);

            double result = receive - Price;
            if (result < 0)
            {
                MessageBox.Show("เงินน้อยเกิ้น");
                return;
            }

            var sql = $"INSERT INTO Pay(PayID,PayTime,PayDate,PayPrice,PayReceive,PayExchange,OrderID) VALUES('{payIDTextBox.Text}','{payTimeTextBox.Text}','{All}','{Price}','{payReceiveTextBox.Text}','{result}','{orderIDTextBox.Text}')";
            command = new SqlCommand(sql, CakesConnection);
            adapter.InsertCommand = command;
            adapter.InsertCommand.ExecuteNonQuery();
            this.payTableAdapter.Fill(this.cakeDBDataSetPay.Pay);
            command.Dispose();

            int Max = Caquan - Orquan;


            var sql1 = $"Update Cake set CakeQuantity = '{Max}'where CakeID='{CakID}'";
            command = new SqlCommand(sql1, CakesConnection);
            adapter.InsertCommand = command;
            adapter.InsertCommand.ExecuteNonQuery();
            this.payTableAdapter.Fill(this.cakeDBDataSetPay.Pay);
            command.Dispose();

        }

        private void buttonDeL_Click(object sender, EventArgs e)
        {
            SqlCommand command;
            SqlDataAdapter adapter = new SqlDataAdapter();
            SqlDataReader dataReader;
            String strSQL;
            string OrID = "";

            strSQL = $"Select OrderID from Pay where PayID ='{payIDTextBox.Text}'";
            command = new SqlCommand(strSQL, CakesConnection);
            dataReader = command.ExecuteReader();
            if (dataReader.Read())
            {
                OrID = Convert.ToString(dataReader.GetValue(0));
            }
            dataReader.Close();

            SqlCommand command1;
            string CakID = "";
            int Orquan = 0;
            strSQL = $"Select CakeID,OrderQuantity from Orders where OrderID ='{OrID}'";
            command1 = new SqlCommand(strSQL, CakesConnection);
            dataReader = command1.ExecuteReader();
            if (dataReader.Read())
            {
                CakID = Convert.ToString(dataReader.GetValue(0));
                Orquan = Convert.ToInt32(dataReader.GetValue(1));

            }
            dataReader.Close();
            SqlCommand command2;
            SqlDataReader dataReader1;
            int Caquan = 0;
            strSQL = $"Select CakeQuantity from Cake where CakeID ='{CakID}'";
            command2 = new SqlCommand(strSQL, CakesConnection);
            dataReader1 = command2.ExecuteReader();
            if (dataReader1.Read())
            {
                Caquan = Convert.ToInt32(dataReader1.GetValue(0));
            }
            dataReader1.Close();

            int result = Orquan+Caquan;

            var sql1 = $"Update Cake set CakeQuantity = '{result}'where CakeID='{CakID}'";
            command = new SqlCommand(sql1, CakesConnection);
            adapter.InsertCommand = command;
            adapter.InsertCommand.ExecuteNonQuery();
            this.payTableAdapter.Fill(this.cakeDBDataSetPay.Pay);
            command.Dispose();


            SqlCommand command3;
            SqlDataAdapter adapter3 = new SqlDataAdapter();
            var sql = $"Delete Pay where PayID = '{payIDTextBox.Text}'";
            command3 = new SqlCommand(sql, CakesConnection);
            adapter3.InsertCommand = command3;
            adapter3.InsertCommand.ExecuteNonQuery();
            this.payTableAdapter.Fill(this.cakeDBDataSetPay.Pay);
            command3.Dispose();
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            SqlCommand command;
            SqlDataAdapter adapter = new SqlDataAdapter();
            string Date = payDateDateTimePicker.Value.Day.ToString();
            string Month = payDateDateTimePicker.Value.Month.ToString();
            string Year = payDateDateTimePicker.Value.Year.ToString();
            string All = Month + "/" + Date + "/" + Year;

            SqlCommand command1;
            SqlDataReader dataReader;
            String strSQL;
            double Price = 0;
            strSQL = $"Select OrderPrice from Orders where OrderID ='{orderIDTextBox.Text}'";
            command1 = new SqlCommand(strSQL, CakesConnection);
            dataReader = command1.ExecuteReader();
            if (dataReader.Read())
            {
                Price = Convert.ToDouble(dataReader.GetValue(0));
            }
            dataReader.Close();

            double receive = Convert.ToDouble(payReceiveTextBox.Text);

            double result = receive - Price;
            if (result < 0)
            {
                MessageBox.Show("เงินน้อยเกิ้น");
                return;
            }


            var sql = $"Update Pay set PayTime = '{payTimeTextBox.Text}',PayDate = '{All}',PayPrice = '{Price}',PayReceive = '{payReceiveTextBox.Text}'" +
                $",PayExchange = '{result}',OrderID = '{orderIDTextBox.Text}' where PayID='{payIDTextBox.Text}'";
            command = new SqlCommand(sql, CakesConnection);
            adapter.InsertCommand = command;
            adapter.InsertCommand.ExecuteNonQuery();
            this.payTableAdapter.Fill(this.cakeDBDataSetPay.Pay);
            command.Dispose();
        }

        private void Process05_FormClosing(object sender, FormClosingEventArgs e)
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
                sql = $"SELECT * FROM Orders WHERE OrderID ='{searchtextBox.Text}'";
            }
            else if (All == 1)
            {
                sql = $"SELECT * FROM Orders WHERE OrderStyle ='{searchtextBox.Text}'";
            }
            else if (All == 2)
            {
                sql = $"SELECT * FROM Orders WHERE OrderType ='{searchtextBox.Text}'";
            }
            else if (All == 3)
            {
                sql = $"SELECT * FROM Orders WHERE OrderQuantity ='{searchtextBox.Text}'";
            }
            else if (All == 4)
            {
                sql = $"SELECT * FROM Orders WHERE OrderPrice ='{searchtextBox.Text}'";
            }
            else if (All == 5)
            {
                sql = $"SELECT * FROM Orders WHERE OrderExp ='{searchtextBox.Text}'";
            }
            else if (All == 6)
            {
                sql = $"SELECT * FROM Orders WHERE CakeID ='{searchtextBox.Text}'";
            }
            else if (All == 7)
            {
                sql = $"SELECT * FROM Orders WHERE MemberID ='{searchtextBox.Text}'";
            }
            resultCommand = new SqlCommand(sql, CakesConnection);
            resultAdapter.SelectCommand = resultCommand;
            resultAdapter.Fill(resultTable);
            dataGridView2.DataSource = resultTable;
        }

        private void buttonR_Click(object sender, EventArgs e)
        {
            SqlCommand resultCommand = null;
            SqlDataAdapter resultAdapter = new SqlDataAdapter();
            DataTable resultTable = new DataTable();
            resultCommand = new SqlCommand("SELECT * FROM Orders", CakesConnection);
            resultAdapter.SelectCommand = resultCommand;
            resultAdapter.Fill(resultTable);
            dataGridOrders.DataSource = resultTable;
        }
    }
}
