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

    public partial class Process12 : Form
    {
        SqlConnection CakesConnection;
        public Process12()
        {
            InitializeComponent();
        }
        private void Process12_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'cakeDBDataSetCake.Cake' table. You can move, or remove it, as needed.
            this.cakeTableAdapter.Fill(this.cakeDBDataSetCake.Cake);
            CakesConnection = new SqlConnection("Data Source=LAPTOP-UIF87597;" + "Initial Catalog=CakeDB;" +
           "User ID=user1;Password=mypass1");
            CakesConnection.Open();
            SqlCommand resultCommand = null;
            SqlDataAdapter resultAdapter = new SqlDataAdapter();
            DataTable resultTable = new DataTable();
            resultCommand = new SqlCommand("SELECT * FROM Made", CakesConnection);
            resultAdapter.SelectCommand = resultCommand;
            resultAdapter.Fill(resultTable);
            dataGridMade.DataSource = resultTable;
        }

        private void buttonInsert_Click(object sender, EventArgs e)
        {
            SqlCommand command;
            SqlDataAdapter adapter = new SqlDataAdapter();
            string Date = cakeExpDateTimePicker.Value.Day.ToString();
            string Month = cakeExpDateTimePicker.Value.Month.ToString();
            string Year = cakeExpDateTimePicker.Value.Year.ToString();
            string All = Month + "/" + Date + "/" + Year;
            var sql = "";
            string A1 = Convert.ToString(madeIDTextBox.Text);
            if (A1 == "")
            {
                sql = $"INSERT INTO Cake(CakeID,CakeStyle,CakeType,CakeQuantity,CakePrice,CakeExp) VALUES('{cakeIDTextBox.Text}','{cakeStyleTextBox.Text}','{cakeTypeTextBox.Text}','{cakeQuantityTextBox.Text}','{cakePriceTextBox.Text}','{All}')";
            }
            else
            {
                sql = $"INSERT INTO Cake(CakeID,CakeStyle,CakeType,CakeQuantity,CakePrice,CakeExp,MadeID) VALUES('{cakeIDTextBox.Text}','{cakeStyleTextBox.Text}','{cakeTypeTextBox.Text}','{cakeQuantityTextBox.Text}','{cakePriceTextBox.Text}','{All}','{madeIDTextBox.Text}')";
            }
            command = new SqlCommand(sql, CakesConnection);
            adapter.InsertCommand = command;
            adapter.InsertCommand.ExecuteNonQuery();
            this.cakeTableAdapter.Fill(this.cakeDBDataSetCake.Cake);
            command.Dispose();
        }

        private void buttonDeL_Click(object sender, EventArgs e)
        {
            SqlCommand command;
            SqlDataAdapter adapter = new SqlDataAdapter();
            var sql = $"Delete Cake where CakeID = '{cakeIDTextBox.Text}'";
            command = new SqlCommand(sql, CakesConnection);
            adapter.InsertCommand = command;
            adapter.InsertCommand.ExecuteNonQuery();
            this.cakeTableAdapter.Fill(this.cakeDBDataSetCake.Cake);
            command.Dispose();
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            SqlCommand command;
            SqlDataAdapter adapter = new SqlDataAdapter();
            string Date = cakeExpDateTimePicker.Value.Day.ToString();
            string Month = cakeExpDateTimePicker.Value.Month.ToString();
            string Year = cakeExpDateTimePicker.Value.Year.ToString();
            string All = Month + "/" + Date + "/" + Year;
            var sql = "";
            string A1 = Convert.ToString(madeIDTextBox.Text);
            if (A1 == "")
            {
                sql = $"Update Cake set CakeStyle = '{cakeStyleTextBox.Text}',CakeType = '{cakeTypeTextBox.Text}',CakeQuantity = '{cakeQuantityTextBox.Text}',CakePrice = '{cakePriceTextBox.Text}'" +
                $",CakeExp = '{All}' where CakeID='{cakeIDTextBox.Text}'";
            }
            else
            {
                sql = $"Update Cake set CakeStyle = '{cakeStyleTextBox.Text}',CakeType = '{cakeTypeTextBox.Text}',CakeQuantity = '{cakeQuantityTextBox.Text}',CakePrice = '{cakePriceTextBox.Text}'" +
                $",CakeExp = '{All}',MadeID = '{madeIDTextBox.Text}' where CakeID='{cakeIDTextBox.Text}'";
            }
            command = new SqlCommand(sql, CakesConnection);
            adapter.InsertCommand = command;
            adapter.InsertCommand.ExecuteNonQuery();
            this.cakeTableAdapter.Fill(this.cakeDBDataSetCake.Cake);
            command.Dispose();


        }

        private void Process12_FormClosing(object sender, FormClosingEventArgs e)
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
                sql = $"SELECT * FROM Made WHERE MadeID ='{searchtextBox.Text}'";
            }
            else if (All == 1)
            {
                sql = $"SELECT * FROM Made WHERE MadeType ='{searchtextBox.Text}'";
            }
            else if (All == 2)
            {
                sql = $"SELECT * FROM Made WHERE MadeDate ='{searchtextBox.Text}'";
            }
            else if (All == 3)
            {
                sql = $"SELECT * FROM Made WHERE MadePrice ='{searchtextBox.Text}'";
            }
            else if (All == 4)
            {
                sql = $"SELECT * FROM Made WHERE MadeStatus ='{searchtextBox.Text}'";
            }
            else if (All == 5)
            {
                sql = $"SELECT * FROM Made WHERE MadeStyle ='{searchtextBox.Text}'";
            }
            else if (All == 6)
            {
                sql = $"SELECT * FROM Made WHERE MadeQuantity ='{searchtextBox.Text}'";
            }
            else if (All == 7)
            {
                sql = $"SELECT * FROM Made WHERE CusID ='{searchtextBox.Text}'";
            }
            else if (All == 8)
            {
                sql = $"SELECT * FROM Made WHERE EmpID ='{searchtextBox.Text}'";
            }
            resultCommand = new SqlCommand(sql, CakesConnection);
            resultAdapter.SelectCommand = resultCommand;
            resultAdapter.Fill(resultTable);
            dataGridMade.DataSource = resultTable;
        }

        private void buttonR_Click(object sender, EventArgs e)
        {
            SqlCommand resultCommand = null;
            SqlDataAdapter resultAdapter = new SqlDataAdapter();
            DataTable resultTable = new DataTable();
            resultCommand = new SqlCommand("SELECT * FROM Made", CakesConnection);
            resultAdapter.SelectCommand = resultCommand;
            resultAdapter.Fill(resultTable);
            dataGridMade.DataSource = resultTable;
        }
    }
}
