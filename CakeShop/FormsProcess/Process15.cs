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
    public partial class Process15 : Form
    {
        SqlConnection CakesConnection;
        public Process15()
        {
            InitializeComponent();
        }

        private void Process15_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'cakeDBDataSetExpenses.Expenses' table. You can move, or remove it, as needed.
            this.expensesTableAdapter.Fill(this.cakeDBDataSetExpenses.Expenses);
            CakesConnection = new SqlConnection("Data Source=LAPTOP-UIF87597;" + "Initial Catalog=CakeDB;" +
           "User ID=user1;Password=mypass1");
            CakesConnection.Open();
            SqlCommand resultCommand = null;
            SqlDataAdapter resultAdapter = new SqlDataAdapter();
            DataTable resultTable = new DataTable();
            resultCommand = new SqlCommand("SELECT * FROM OrderPay", CakesConnection);
            resultAdapter.SelectCommand = resultCommand;
            resultAdapter.Fill(resultTable);
            dataGridOrderPay.DataSource = resultTable;

        }

        private void buttonInsert_Click(object sender, EventArgs e)
        {
            SqlCommand command;
            SqlDataAdapter adapter = new SqlDataAdapter();
            string Date = expenDateDateTimePicker.Value.Day.ToString();
            string Month = expenDateDateTimePicker.Value.Month.ToString();
            string Year = expenDateDateTimePicker.Value.Year.ToString();
            string All = Month + "/" + Date + "/" + Year;
            var sql = $"INSERT INTO Expenses(ExpenID,ExpenName,ExpenReq,ExpenPrice,ExpenDate,ExpenApprover,OrderPayID) VALUES('{expenIDTextBox.Text}','{expenNameTextBox.Text}','{expenReqTextBox.Text}','{expenPriceTextBox.Text}','{All}','{expenApproverTextBox.Text}','{orderPayIDTextBox.Text}')";
            command = new SqlCommand(sql, CakesConnection);
            adapter.InsertCommand = command;
            adapter.InsertCommand.ExecuteNonQuery();
            this.expensesTableAdapter.Fill(this.cakeDBDataSetExpenses.Expenses);
            command.Dispose();
        }

        private void buttonDeL_Click(object sender, EventArgs e)
        {
            SqlCommand command;
            SqlDataAdapter adapter = new SqlDataAdapter();
            var sql = $"Delete Expenses where ExpenID = '{expenIDTextBox.Text}'";
            command = new SqlCommand(sql, CakesConnection);
            adapter.InsertCommand = command;
            adapter.InsertCommand.ExecuteNonQuery();
            this.expensesTableAdapter.Fill(this.cakeDBDataSetExpenses.Expenses);
            command.Dispose();
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            SqlCommand command;
            SqlDataAdapter adapter = new SqlDataAdapter();
            string Date = expenDateDateTimePicker.Value.Day.ToString();
            string Month = expenDateDateTimePicker.Value.Month.ToString();
            string Year = expenDateDateTimePicker.Value.Year.ToString();
            string All = Month + "/" + Date + "/" + Year;
            var sql = $"Update Expenses set ExpenName = '{expenNameTextBox.Text}',ExpenReq = '{expenReqTextBox.Text}',ExpenPrice = '{expenPriceTextBox.Text}',ExpenDate = '{All}'" +
                $",ExpenApprover = '{expenApproverTextBox.Text}',OrderPayID = '{orderPayIDTextBox.Text}' where ExpenID='{expenIDTextBox.Text}'";
            command = new SqlCommand(sql, CakesConnection);
            adapter.InsertCommand = command;
            adapter.InsertCommand.ExecuteNonQuery();
            this.expensesTableAdapter.Fill(this.cakeDBDataSetExpenses.Expenses);
            command.Dispose();
        }

        private void Process15_FormClosing(object sender, FormClosingEventArgs e)
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
                sql = $"SELECT * FROM OrderPay WHERE OrderPayID ='{searchtextBox.Text}'";
            }
            else if (All == 1)
            {
                sql = $"SELECT * FROM OrderPay WHERE OrderPayName ='{searchtextBox.Text}'";
            }
            else if (All == 2)
            {
                sql = $"SELECT * FROM OrderPay WHERE OrderPayPrice ='{searchtextBox.Text}'";
            }
            else if (All == 3)
            {
                sql = $"SELECT * FROM OrderPay WHERE OrderPayQuantity ='{searchtextBox.Text}'";
            }
            else if (All == 4)
            {
                sql = $"SELECT * FROM OrderPay WHERE ReqBuyID ='{searchtextBox.Text}'";
            }
            resultCommand = new SqlCommand(sql, CakesConnection);
            resultAdapter.SelectCommand = resultCommand;
            resultAdapter.Fill(resultTable);
            dataGridOrderPay.DataSource = resultTable;
        }

        private void buttonR_Click(object sender, EventArgs e)
        {
            SqlCommand resultCommand = null;
            SqlDataAdapter resultAdapter = new SqlDataAdapter();
            DataTable resultTable = new DataTable();
            resultCommand = new SqlCommand("SELECT * FROM OrderPay", CakesConnection);
            resultAdapter.SelectCommand = resultCommand;
            resultAdapter.Fill(resultTable);
            dataGridOrderPay.DataSource = resultTable;
        }
    }
}
