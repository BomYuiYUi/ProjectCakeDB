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
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.IO;

namespace CakeShop
{
    public partial class Process13 : Form
    {
        SqlConnection CakesConnection;
        int R = 0;
        public Process13()
        {
            InitializeComponent();
        }

        private void Process13_Load(object sender, EventArgs e)
        {
            CakesConnection = new SqlConnection("Data Source=LAPTOP-UIF87597;" + "Initial Catalog=CakeDB;" +
            "User ID=user1;Password=mypass1");
            CakesConnection.Open();
        }

        private void Process13_FormClosing(object sender, FormClosingEventArgs e)
        {
            CakesConnection.Close();
            CakesConnection.Dispose();
        }

        private void buttonAll_Click(object sender, EventArgs e)
        {
            SqlCommand resultCommand = null;
            SqlDataAdapter resultAdapter = new SqlDataAdapter();
            DataTable resultTable = new DataTable();

            if ((Button)sender == buttonMember)
            {
                resultCommand = new SqlCommand("SELECT * FROM Member", CakesConnection);
                resultAdapter.SelectCommand = resultCommand;
                resultAdapter.Fill(resultTable);
                dataGridViewSql.DataSource = resultTable;
                R = 1;
            }
            else if ((Button)sender == buttonReqBuy)
            {
                resultCommand = new SqlCommand("SELECT * FROM ReqBuy", CakesConnection);
                resultAdapter.SelectCommand = resultCommand;
                resultAdapter.Fill(resultTable);
                dataGridViewSql.DataSource = resultTable;
                R = 2;
            }
            else if ((Button)sender == buttonRequisition)
            {
                resultCommand = new SqlCommand("SELECT * FROM Requisition", CakesConnection);
                resultAdapter.SelectCommand = resultCommand;
                resultAdapter.Fill(resultTable);
                dataGridViewSql.DataSource = resultTable;
                R = 3;
            }
            else if ((Button)sender == buttonMade)
            {
                resultCommand = new SqlCommand("SELECT * FROM Made", CakesConnection);
                resultAdapter.SelectCommand = resultCommand;
                resultAdapter.Fill(resultTable);
                dataGridViewSql.DataSource = resultTable;
                R = 4;
            }
            else if ((Button)sender == buttonPay)
            {
                resultCommand = new SqlCommand("SELECT * FROM Pay", CakesConnection);
                resultAdapter.SelectCommand = resultCommand;
                resultAdapter.Fill(resultTable);
                dataGridViewSql.DataSource = resultTable;
                R = 5;
            }


            else if ((Button)sender == buttonIncome)
            {
                resultCommand = new SqlCommand("SELECT * FROM Income", CakesConnection);
                resultAdapter.SelectCommand = resultCommand;
                resultAdapter.Fill(resultTable);
                dataGridViewSql.DataSource = resultTable;
                R = 6;
            }
            else if ((Button)sender == buttonExpenses)
            {
                resultCommand = new SqlCommand("SELECT * FROM Expenses", CakesConnection);
                resultAdapter.SelectCommand = resultCommand;
                resultAdapter.Fill(resultTable);
                dataGridViewSql.DataSource = resultTable;
                R = 7;
            }
            else if ((Button)sender == buttonEmployee)
            {
                resultCommand = new SqlCommand("SELECT * FROM Employee", CakesConnection);
                resultAdapter.SelectCommand = resultCommand;
                resultAdapter.Fill(resultTable);
                dataGridViewSql.DataSource = resultTable;
                R = 8;
            }
            else if ((Button)sender == buttonCake)
            {
                resultCommand = new SqlCommand("SELECT * FROM Cake", CakesConnection);
                resultAdapter.SelectCommand = resultCommand;
                resultAdapter.Fill(resultTable);
                dataGridViewSql.DataSource = resultTable;
                R = 9;
            }
            else if ((Button)sender == buttonRmaterial)
            {
                resultCommand = new SqlCommand("SELECT * FROM Rmaterial", CakesConnection);
                resultAdapter.SelectCommand = resultCommand;
                resultAdapter.Fill(resultTable);
                dataGridViewSql.DataSource = resultTable;
                R = 10;
            }
            else if ((Button)sender == buttonOrderPay)
            {
                resultCommand = new SqlCommand("SELECT * FROM OrderPay", CakesConnection);
                resultAdapter.SelectCommand = resultCommand;
                resultAdapter.Fill(resultTable);
                dataGridViewSql.DataSource = resultTable;
                R = 11;
            }
        }

        private void buttonEx_Click(object sender, EventArgs e)
        {
            Microsoft.Office.Interop.Excel.Application app = new Microsoft.Office.Interop.Excel.Application();
            Microsoft.Office.Interop.Excel.Workbook workbook = app.Workbooks.Add(Type.Missing);
            Microsoft.Office.Interop.Excel.Worksheet worksheet = null;
            worksheet = workbook.Sheets["sheet1"];
            worksheet = workbook.ActiveSheet;
            worksheet.Name = "report";
            for (int i = 1; i < dataGridViewSql.Columns.Count + 1; i++)
            {
                worksheet.Cells[1, i] = dataGridViewSql.Columns[i - 1].HeaderText;
            }
            for (int i = 0; i < dataGridViewSql.Rows.Count - 1; i++)
            {
                for (int j = 0; j < dataGridViewSql.Columns.Count; j++)
                {
                    worksheet.Cells[i + 2, j + 1] = dataGridViewSql.Rows[i].Cells[j].Value.ToString();
                }
            }
            var saveFileDialoge = new SaveFileDialog();
            saveFileDialoge.FileName = "output";
            saveFileDialoge.DefaultExt = ".xlsx";
            if (saveFileDialoge.ShowDialog() == DialogResult.OK)
            {
                workbook.SaveAs(saveFileDialoge.FileName, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Microsoft.Office.Interop.Excel.XlSaveAsAccessMode.xlExclusive, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing);

            }
            app.Quit();
        }

        private void buttonPDF_Click(object sender, EventArgs e)
        {
            if (dataGridViewSql.Rows.Count > 0)

            {

                SaveFileDialog save = new SaveFileDialog();

                save.Filter = "PDF (*.pdf)|*.pdf";

                save.FileName = "Result.pdf";

                bool ErrorMessage = false;

                if (save.ShowDialog() == DialogResult.OK)

                {

                    if (File.Exists(save.FileName))

                    {

                        try

                        {

                            File.Delete(save.FileName);

                        }

                        catch (Exception ex)

                        {

                            ErrorMessage = true;

                            MessageBox.Show("Unable to wride data in disk" + ex.Message);

                        }

                    }

                    if (!ErrorMessage)

                    {

                        try

                        {

                            PdfPTable pTable = new PdfPTable(dataGridViewSql.Columns.Count);

                            pTable.DefaultCell.Padding = 2;

                            pTable.WidthPercentage = 100;

                            pTable.HorizontalAlignment = Element.ALIGN_LEFT;

                            foreach (DataGridViewColumn col in dataGridViewSql.Columns)

                            {

                                PdfPCell pCell = new PdfPCell(new Phrase(col.HeaderText));

                                pTable.AddCell(pCell);

                            }

                            foreach (DataGridViewRow viewRow in dataGridViewSql.Rows)

                            {

                                foreach (DataGridViewCell dcell in viewRow.Cells)

                                {

                                    pTable.AddCell(dcell.Value.ToString());

                                }

                            }

                            using (FileStream fileStream = new FileStream(save.FileName, FileMode.Create))

                            {

                                Document document = new Document(PageSize.A4, 8f, 16f, 16f, 8f);

                                PdfWriter.GetInstance(document, fileStream);

                                document.Open();

                                document.Add(pTable);

                                document.Close();

                                fileStream.Close();

                            }

                            MessageBox.Show("Data Export Successfully", "info");

                        }

                        catch (Exception ex)

                        {

                            MessageBox.Show("Error while exporting Data" + ex.Message);

                        }

                    }

                }

            }

            else

            {

                MessageBox.Show("No Record Found", "Info");

            }

        }

        private void buttonPrint_Click(object sender, EventArgs e)
        {
            if(R == 1)
            {
                using (Report.Report1 P1 = new Report.Report1())
                {
                    P1.ShowDialog();
                }
            }
            else if (R == 2)
            {
                using (Report.FormReport2 P2 = new Report.FormReport2())
                {
                    P2.ShowDialog();
                }
            }
            else if (R == 3)
            {
                using (Report.FormReport3 P3 = new Report.FormReport3())
                {
                    P3.ShowDialog();
                }
            }
            else if (R == 4)
            {
                using (Report.FormReport4 P4 = new Report.FormReport4())
                {
                    P4.ShowDialog();
                }
            }
            else if (R == 5)
            {
                using (Report.FormReport5 P5 = new Report.FormReport5())
                {
                    P5.ShowDialog();
                }
            }
            else if (R == 6)
            {
                using (Report.FormReport6 P6 = new Report.FormReport6())
                {
                    P6.ShowDialog();
                }
            }
            else if (R == 7)
            {
                using (Report.FormReport7 P7 = new Report.FormReport7())
                {
                    P7.ShowDialog();
                }
            }
            else if (R == 8)
            {
                using (Report.FormReport8 P8 = new Report.FormReport8())
                {
                    P8.ShowDialog();
                }
            }
            else if (R == 9)
            {
                using (Report.FormReport9 P9 = new Report.FormReport9())
                {
                    P9.ShowDialog();
                }
            }
            else if (R == 10)
            {
                using (Report.FormReport10 P10 = new Report.FormReport10())
                {
                    P10.ShowDialog();
                }
            }
            else if (R == 11)
            {
                using (Report.FormReport11 P11 = new Report.FormReport11())
                {
                    P11.ShowDialog();
                }
            }
        }
    }
}
