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
    public partial class DataCustomer : Form
    {
        SqlConnection CakesConnection;
        public DataCustomer()
        {
            InitializeComponent();
        }

        private void DataCustomer_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'cakeDBDataSetCustomer.Customer' table. You can move, or remove it, as needed.
            this.customerTableAdapter.Fill(this.cakeDBDataSetCustomer.Customer);
            CakesConnection = new SqlConnection("Data Source=LAPTOP-UIF87597;" + "Initial Catalog=CakeDB;" +
           "User ID=user1;Password=mypass1");
            CakesConnection.Open();
        }

        private void buttonInsert_Click(object sender, EventArgs e)
        {
            SqlCommand command;
            SqlDataAdapter adapter = new SqlDataAdapter();
            string Date = cusBDDateTimePicker.Value.Day.ToString();
            string Month = cusBDDateTimePicker.Value.Month.ToString();
            string Year = cusBDDateTimePicker.Value.Year.ToString();
            string All = Month + "/" + Date + "/" + Year;
            var sql = $"INSERT INTO Customer(CusID,CusName,CusLast,CusBD,CusSex,CusTel) VALUES('{cusIDTextBox.Text}','{cusNameTextBox.Text}','{cusLastTextBox.Text}','{All}','{cusSexTextBox.Text}','{cusTelTextBox.Text}')";
            command = new SqlCommand(sql, CakesConnection);
            adapter.InsertCommand = command;
            adapter.InsertCommand.ExecuteNonQuery();
            this.customerTableAdapter.Fill(this.cakeDBDataSetCustomer.Customer);
            command.Dispose();
        }

        private void buttonDeL_Click(object sender, EventArgs e)
        {
            SqlCommand command;
            SqlDataAdapter adapter = new SqlDataAdapter();
            var sql = $"Delete Customer where CusID = '{cusIDTextBox.Text}'";
            command = new SqlCommand(sql, CakesConnection);
            adapter.InsertCommand = command;
            adapter.InsertCommand.ExecuteNonQuery();
            this.customerTableAdapter.Fill(this.cakeDBDataSetCustomer.Customer);
            command.Dispose();
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            SqlCommand command;
            SqlDataAdapter adapter = new SqlDataAdapter();
            string Date = cusBDDateTimePicker.Value.Day.ToString();
            string Month = cusBDDateTimePicker.Value.Month.ToString();
            string Year = cusBDDateTimePicker.Value.Year.ToString();
            string All = Month + "/" + Date + "/" + Year;
            var sql = $"Update Customer set CusName = '{cusNameTextBox.Text}',CusLast = '{cusLastTextBox.Text}',CusBD = '{All}',CusSex = '{cusSexTextBox.Text}'" +
                $",CusTel = '{cusTelTextBox.Text}'where CusID ='{cusIDTextBox.Text}'";
            command = new SqlCommand(sql, CakesConnection);
            adapter.InsertCommand = command;
            adapter.InsertCommand.ExecuteNonQuery();
            this.customerTableAdapter.Fill(this.cakeDBDataSetCustomer.Customer);
            command.Dispose();
        }
    }
}
