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
    public partial class Process03 : Form
    {
        SqlConnection CakesConnection;
        public Process03()
        {
            InitializeComponent();
        }
        private void Process03_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'cakeDBDataSetMade.Made' table. You can move, or remove it, as needed.
            this.madeTableAdapter.Fill(this.cakeDBDataSetMade.Made);
            CakesConnection = new SqlConnection("Data Source=LAPTOP-UIF87597;" + "Initial Catalog=CakeDB;" +
           "User ID=user1;Password=mypass1");
            CakesConnection.Open();
            SqlCommand resultCommand = null;
            SqlDataAdapter resultAdapter = new SqlDataAdapter();
            DataTable resultTable = new DataTable();
            resultCommand = new SqlCommand("SELECT * FROM Cake", CakesConnection);
            resultAdapter.SelectCommand = resultCommand;
            resultAdapter.Fill(resultTable);
            dataGridCake.DataSource = resultTable;


        }
        private void buttonInsert_Click(object sender, EventArgs e)
        {
            SqlCommand command;
            SqlDataAdapter adapter = new SqlDataAdapter();
            string Date = madeDateDateTimePicker.Value.Day.ToString();
            string Month = madeDateDateTimePicker.Value.Month.ToString();
            string Year = madeDateDateTimePicker.Value.Year.ToString();
            string All = Month + "/" + Date + "/" + Year;

            var sql = "";
            string A1 = Convert.ToString(cusIDTextBox.Text);
            if (A1 == "")
            {
                sql = $"INSERT INTO Made(MadeID,MadeType,MadeDate,MadePrice,MadeStatus,MadeStyle,MadeQuantity,EmpID) VALUES('{madeIDTextBox.Text}','{madeTypeTextBox.Text}','{All}','{madePriceTextBox.Text}','{madeStatusTextBox.Text}','{madeStyleTextBox.Text}','{madeQuantityTextBox.Text}','{empIDTextBox.Text}')";
            }
            else
            {
                sql = $"INSERT INTO Made(MadeID,MadeType,MadeDate,MadePrice,MadeStatus,MadeStyle,MadeQuantity,CusID,EmpID) VALUES('{madeIDTextBox.Text}','{madeTypeTextBox.Text}','{All}','{madePriceTextBox.Text}','{madeStatusTextBox.Text}','{madeStyleTextBox.Text}','{madeQuantityTextBox.Text}','{cusIDTextBox.Text}','{empIDTextBox.Text}')";
            }

            command = new SqlCommand(sql, CakesConnection);
            adapter.InsertCommand = command;
            adapter.InsertCommand.ExecuteNonQuery();
            this.madeTableAdapter.Fill(this.cakeDBDataSetMade.Made);
            command.Dispose();
        }

        private void buttonDeL_Click(object sender, EventArgs e)
        {
            SqlCommand command;
            SqlDataAdapter adapter = new SqlDataAdapter();
            var sql = $"Delete Made where MadeID = '{madeIDTextBox.Text}'";
            command = new SqlCommand(sql, CakesConnection);
            adapter.InsertCommand = command;
            adapter.InsertCommand.ExecuteNonQuery();
            this.madeTableAdapter.Fill(this.cakeDBDataSetMade.Made);
            command.Dispose();
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            SqlCommand command;
            SqlDataAdapter adapter = new SqlDataAdapter();
            string Date = madeDateDateTimePicker.Value.Day.ToString();
            string Month = madeDateDateTimePicker.Value.Month.ToString();
            string Year = madeDateDateTimePicker.Value.Year.ToString();
            string All = Month + "/" + Date + "/" + Year;

            var sql = "";
            string A1 = Convert.ToString(cusIDTextBox.Text);
            if (A1 == "")
            {
                sql = $"Update Made set MadeType = '{madeTypeTextBox.Text}',MadeDate = '{All}',MadePrice = '{madePriceTextBox.Text}',MadeStatus = '{madeStatusTextBox.Text}'" +
                $",MadeStyle = '{madeStyleTextBox.Text}',MadeQuantity = '{madeQuantityTextBox.Text}',EmpID = '{empIDTextBox.Text}' where MadeID='{madeIDTextBox.Text}'";
            }
            else
            {
                sql = $"Update Made set MadeType = '{madeTypeTextBox.Text}',MadeDate = '{All}',MadePrice = '{madePriceTextBox.Text}',MadeStatus = '{madeStatusTextBox.Text}'" +
                $",MadeStyle = '{madeStyleTextBox.Text}',MadeQuantity = '{madeQuantityTextBox.Text}',CusID = '{cusIDTextBox.Text}',EmpID = '{empIDTextBox.Text}' where MadeID='{madeIDTextBox.Text}'";
            }
            command = new SqlCommand(sql, CakesConnection);
            adapter.InsertCommand = command;
            adapter.InsertCommand.ExecuteNonQuery();
            this.madeTableAdapter.Fill(this.cakeDBDataSetMade.Made);
            command.Dispose();
        }

        private void Process03_FormClosing(object sender, FormClosingEventArgs e)
        {
            CakesConnection.Close();
            CakesConnection.Dispose();
        }

        private void buttonCus_Click(object sender, EventArgs e)
        {
            using(DataCustomer DC = new DataCustomer())
            {
                DC.ShowDialog();
            }
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
            dataGridCake.DataSource = resultTable;
        }

        private void buttonR_Click(object sender, EventArgs e)
        {
            SqlCommand resultCommand = null;
            SqlDataAdapter resultAdapter = new SqlDataAdapter();
            DataTable resultTable = new DataTable();
            resultCommand = new SqlCommand("SELECT * FROM Cake", CakesConnection);
            resultAdapter.SelectCommand = resultCommand;
            resultAdapter.Fill(resultTable);
            dataGridCake.DataSource = resultTable;
        }
    }
}
