using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;
using Excel = Microsoft.Office.Interop.Excel;
using System.Data.OleDb;
using System.Text.RegularExpressions;

namespace WinDataExportImport
{
    public partial class Form1 : Form
    {
        string strConn;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            strConn = ConfigurationManager.ConnectionStrings["MyProject"].ConnectionString;

            string sql = "select * from Categories";
            SqlConnection conn = new SqlConnection(strConn);
            SqlDataAdapter dapt = new SqlDataAdapter(sql, conn);
            DataSet ds = new DataSet();
            conn.Open();
            dapt.Fill(ds, "category");
            conn.Close();

            dataGridView1.DataSource = ds.Tables[0];
            //Class1.SetDataGridView(dataGridView1);            
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.ShowDialog();
            
            //printDocument1.Print();
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Bitmap bm = new Bitmap(this.dataGridView1.Width, this.dataGridView1.Height);
            dataGridView1.DrawToBitmap(bm, new Rectangle(0, 0, this.dataGridView1.Width, this.dataGridView1.Height));
            e.Graphics.DrawImage(bm, 0, 0);
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            Excel.Application xlApp;
            Excel.Workbook xlWorkBook;
            Excel.Worksheet xlWorkSheet;

            int i, j;

            saveFileDialog1.Filter = "Excel Files (*.xls)|*.xls";
            saveFileDialog1.InitialDirectory = "C:";
            saveFileDialog1.Title = "Save";
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                xlApp = new Excel.Application();
                xlWorkBook = xlApp.Workbooks.Add();
                xlWorkSheet = (Excel.Worksheet)xlWorkBook.Worksheets.get_Item(1);

                for (i = 0; i <= dataGridView1.RowCount - 2; i++)
                {
                    for (j = 0; j <= dataGridView1.ColumnCount - 1; j++)
                    {
                        xlWorkSheet.Cells[i + 1, j + 1] = dataGridView1[j, i].Value.ToString();
                    }
                }

                xlWorkBook.SaveAs(saveFileDialog1.FileName, Excel.XlFileFormat.xlWorkbookNormal);
                xlWorkBook.Close(true);
                xlApp.Quit();

                releaseObject(xlWorkSheet);
                releaseObject(xlWorkBook);
                releaseObject(xlApp);
            }
        }

        private void releaseObject(object obj)
        {
            try
            {
                System.Runtime.InteropServices.Marshal.ReleaseComObject(obj);
                obj = null;
            }
            catch (Exception ex)
            {
                obj = null;
                MessageBox.Show("Exception Occured while releasing object " + ex.ToString());
            }
            finally
            {
                GC.Collect();
            }
        }

        private void btnImport_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            string Excel03ConString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source={0};Extended Properties='Excel 8.0;HDR={1}'";
            string Excel07ConString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source={0};Extended Properties='Excel 8.0;HDR={1}'";


            string filePath = openFileDialog1.FileName;
            string fileExtension = System.IO.Path.GetExtension(filePath);
            string connectionString = string.Empty;
            string sheetName = string.Empty;

            // 확장자로 구분하여 커넥션 스트링을 가져옮
            switch (fileExtension)
            {
                case ".xls":    //Excel 97-03
                    connectionString = string.Format(Excel03ConString, filePath, "Yes");//header 포함여부
                    break;
                case ".xlsx":  //Excel 07
                    connectionString = string.Format(Excel07ConString, filePath, "Yes");
                    break;
            }

            // 첫 번째 시트의 이름을 가져옮
            // 이름을 아는 경우에는 [Sheet$] 으로 한다.  이름을 모를 경우에 이 부분을 추가.
            using (OleDbConnection conn = new OleDbConnection(connectionString))
            {
                using (OleDbCommand cmd = new OleDbCommand())
                {
                    cmd.Connection = conn;
                    conn.Open();
                    DataTable dtExcelSchema = conn.GetOleDbSchemaTable(OleDbSchemaGuid.Tables, null);
                    sheetName = dtExcelSchema.Rows[0]["TABLE_NAME"].ToString();
                    conn.Close();
                }
            }

            // 첫 번째 쉬트의 데이타를 읽어서 datagridview 에 보이게 함.
            using (OleDbConnection conn = new OleDbConnection(connectionString))
            {
                using (OleDbDataAdapter oda = new OleDbDataAdapter())
                {
                    DataTable dt = new DataTable();                    
                    oda.SelectCommand = new OleDbCommand("SELECT * From [" + sheetName + "]", conn);
                    conn.Open();
                    oda.Fill(dt);
                    conn.Close();

                    dataGridView1.DataSource = dt;
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Employees 데이터를 엑셀파일로 저장하기...
            string sql = @"select EmployeeID, concat(FirstName, LastName) emp_name, TitleOfCourtesy,
                                  Year(getdate()) - year(BirthDate) age, convert(char(10), HireDate, 23) HireDate
                            from Employees";
            SqlConnection conn = new SqlConnection(strConn);
            SqlDataAdapter dapt = new SqlDataAdapter(sql, conn);
            DataSet ds = new DataSet();
            conn.Open();
            dapt.Fill(ds, "Employee");
            conn.Close();

            saveFileDialog1.Filter = "Excel Files (*.xlsx)|*.xlsx";
            saveFileDialog1.InitialDirectory = "C:";
            saveFileDialog1.Title = "Save";
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                ExportDataSetToExcel(saveFileDialog1.FileName, ds);
                MessageBox.Show("엑셀파일에 저장하였습니다");
            }
        }

        private void ExportDataSetToExcel(string ExcelFile, DataSet ds)
        {
            Cursor currentCursor = this.Cursor;
            try
            {
                this.Cursor = Cursors.WaitCursor;

                ds.Tables[0].Columns[0].ColumnName = "사원번호";
                ds.Tables[0].Columns[1].ColumnName = "사원명";
                ds.Tables[0].Columns[2].ColumnName = "성별";
                ds.Tables[0].Columns[3].ColumnName = "연령";
                ds.Tables[0].Columns[4].ColumnName = "고용일자";
                
                Excel.Application excelApp = new Excel.Application();
                Excel.Workbook excelWorkBook = excelApp.Workbooks.Add();

                foreach (DataTable table in ds.Tables)
                {
                    Excel.Worksheet excelWorkSheet = (Excel.Worksheet)excelWorkBook.Sheets.Add();
                    excelWorkSheet.Name = table.TableName;

                    excelWorkSheet.Cells[1, 1] = "- 사원명 : FirstName + LastName\n- 연령 : 현재년도 기준의 만 나이 \n- Research 의 사원만 출력...";
                    excelWorkSheet.Range[excelWorkSheet.Cells[1, 1], excelWorkSheet.Cells[1, 5]].Merge();
                    ((Excel.Range)excelWorkSheet.Cells[1, 1]).EntireRow.RowHeight = 200;
                    ((Excel.Range)excelWorkSheet.Cells[1, 1]).Interior.Color = Excel.XlRgbColor.rgbAliceBlue;

                    for (int i = 1; i < table.Columns.Count+1; i++)
                    {
                        excelWorkSheet.Cells[2, i] = table.Columns[i - 1].ColumnName;
                        ((Excel.Range)excelWorkSheet.Cells[2, i]).EntireRow.ColumnWidth = 8;
                        ((Excel.Range)excelWorkSheet.Cells[2, i]).Interior.Color = Excel.XlRgbColor.rgbGhostWhite;
                    }

                    for (int j = 0; j < table.Rows.Count; j++)
                    {
                        for (int k = 0; k < table.Columns.Count; k++)
                        {
                            if (k == 3 || k == 4)
                            {
                                excelWorkSheet.Cells[j + 3, k + 1] = string.Format("'{0}", table.Rows[j].ItemArray[k].ToString());
                            }
                            else
                            {
                                excelWorkSheet.Cells[j + 3, k + 1] = table.Rows[j].ItemArray[k].ToString();
                            }
                        }
                    }
                    excelWorkSheet.Columns.AutoFit();
                    releaseObject(excelWorkSheet);
                }

                excelWorkBook.SaveAs(ExcelFile);
                excelWorkBook.Close();
                excelApp.Quit();
                
                releaseObject(excelWorkBook);
                releaseObject(excelApp);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                this.Cursor = currentCursor;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            copyAlltoClipboard();

            Microsoft.Office.Interop.Excel.Application xlexcel;
            Microsoft.Office.Interop.Excel.Workbook xlWorkBook;
            Microsoft.Office.Interop.Excel.Worksheet xlWorkSheet;
            object misValue = System.Reflection.Missing.Value;
            xlexcel = new Excel.Application();
            xlexcel.Visible = true;
            xlWorkBook = xlexcel.Workbooks.Add(misValue);
            xlWorkSheet = (Excel.Worksheet)xlWorkBook.Worksheets.get_Item(1);
            Excel.Range CR = (Excel.Range)xlWorkSheet.Cells[1, 1];
            CR.Select();
            xlWorkSheet.PasteSpecial(CR, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, true);

            //dataGridView1.ClearSelection();
        }

        private void copyAlltoClipboard()
        {
            dataGridView1.SelectAll();
            DataObject dataObj = dataGridView1.GetClipboardContent();
            if (dataObj != null)
                Clipboard.SetDataObject(dataObj);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = null;

            DataObject o = (DataObject)Clipboard.GetDataObject();
            if (o.GetDataPresent(DataFormats.Text))
            {
                if (dataGridView1.RowCount > 0)
                    dataGridView1.Rows.Clear();

                if (dataGridView1.ColumnCount > 0)
                    dataGridView1.Columns.Clear();

                bool columnsAdded = false;
                string[] pastedRows = Regex.Split(o.GetData(DataFormats.Text).ToString().TrimEnd("\r\n".ToCharArray()), "\r\n");
                int j = 0;
                foreach (string pastedRow in pastedRows)
                {
                    string[] pastedRowCells = pastedRow.Split(new char[] { '\t' });

                    if (!columnsAdded)
                    {
                        for (int i = 0; i < pastedRowCells.Length; i++)
                            dataGridView1.Columns.Add("col" + i, pastedRowCells[i]);

                        columnsAdded = true;
                        continue;
                    }

                    dataGridView1.Rows.Add();
                    int myRowIndex = dataGridView1.Rows.Count - 1;

                    using (DataGridViewRow myDataGridViewRow = dataGridView1.Rows[j])
                    {
                        for (int i = 0; i < pastedRowCells.Length; i++)
                            myDataGridViewRow.Cells[i].Value = pastedRowCells[i];
                    }
                    j++;
                }
            }
        }
    }
}
