using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;

namespace IceCreamManager
{
    public static class Helper
    {
        /// <summary>
        /// Export Excel
        /// </summary>
        public static void ExcelExportFromDGVByVOType<VO>(DataGridView dgv, SaveFileDialog dialog)
        {
            void releaseObject(object obj)
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
            dialog.Title = "SaveAs";
            dialog.Filter = "All File|*.*|Excel File|*.x*";
            dialog.RestoreDirectory = true;
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    var dataList = dgv.DataSource as List<VO>;

                    Excel.Application excel = new Excel.Application();
                    Excel.Workbook workbook = excel.Workbooks.Add();
                    Excel.Worksheet worksheet = (Excel.Worksheet)workbook.Worksheets.get_Item(1);

                    excel.Application.Workbooks.Add(true);
                    // Column Name
                    int cindex = 1;

                    foreach (PropertyInfo property in typeof(VO).GetProperties()) // 해당 타입의 모든 속성 가져오기
                    {
                        //if (!property.Name.Equals("Photo")) // Photo의 컬럼을 보여주지 않음
                        //{
                        worksheet.Cells[1, cindex] = property.Name;
                        cindex++;
                        //}
                    }
                    // Datas
                    int rindex = 1;
                    foreach (VO emp in dataList)
                    {
                        rindex++;
                        cindex = 1;
                        foreach (PropertyInfo property in typeof(VO).GetProperties())
                        {
                            if (property.GetValue(emp, null) != null)
                            {
                                worksheet.Cells[rindex, cindex] = property.GetValue(emp, null).ToString();
                                cindex++;
                            }
                        }
                    }
                    // 파일 마무리
                    //1.파일 보이게하기
                    //excel.Visible = true;
                    //worksheet.Activate();

                    //2. 파일 저장하기
                    workbook.SaveAs(dialog.FileName, Excel.XlFileFormat.xlWorkbookNormal);
                    workbook.Close(true);
                    excel.Quit();

                    releaseObject(worksheet);
                    releaseObject(workbook);
                    releaseObject(excel);
                }
                catch (Exception ee)
                {
                    MessageBox.Show(ee.Message);
                }
            }
        }
        /// <summary>
        /// Export Excel
        /// </summary>
        public static void ExcelExportFromDGVByColumns(DataGridView dgv, SaveFileDialog dialog)
        {
            void releaseObject(object obj)
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
            dialog.Title = "SaveAs";
            dialog.Filter = "All File|*.*|Excel File|*.x*";
            dialog.RestoreDirectory = true;
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    Excel.Application excel = new Excel.Application();
                    Excel.Workbook workbook = excel.Workbooks.Add();
                    Excel.Worksheet worksheet = (Excel.Worksheet)workbook.Worksheets.get_Item(1);

                    excel.Application.Workbooks.Add(true);
                    // Column Name
                    int cindex = 1;

                    foreach (DataGridViewColumn column in dgv.Columns) // 해당 타입의 모든 속성 가져오기
                    {
                        worksheet.Cells[1, cindex] = column.HeaderText;
                        cindex++;
                    }
                    // Datas
                    int rindex = 1;
                    foreach (DataGridViewRow row in dgv.Rows)
                    {
                        rindex++;
                        cindex = 1;
                        foreach (DataGridViewCell cell in row.Cells)
                        {
                            if (cell.Value != null)
                            {
                                worksheet.Cells[rindex, cindex] = cell.Value.ToString();
                                cindex++;
                            }
                        }
                    }
                    // 파일 마무리
                    //1.파일 보이게하기
                    //excel.Visible = true;
                    //worksheet.Activate();

                    //2. 파일 저장하기
                    workbook.SaveAs(dialog.FileName, Excel.XlFileFormat.xlWorkbookNormal);
                    workbook.Close(true);
                    excel.Quit();

                    releaseObject(worksheet);
                    releaseObject(workbook);
                    releaseObject(excel);
                }
                catch (Exception ee)
                {
                    MessageBox.Show(ee.Message);
                }
            }
        }
        /// <summary>
        /// Export Excel
        /// </summary>
        public static void ExcelExportFromDGVByColumns(DataGridView[] dgvs, SaveFileDialog dialog)
        {
            void releaseObject(object obj)
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
            dialog.Title = "SaveAs";
            dialog.Filter = "All File|*.*|Excel File|*.x*";
            dialog.RestoreDirectory = true;
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    Excel.Application excel = new Excel.Application();
                    Excel.Workbook workbook = excel.Workbooks.Add();
                    Excel.Worksheet worksheet = (Excel.Worksheet)workbook.Worksheets.get_Item(1);

                    excel.Application.Workbooks.Add(true);
                    // Column Name
                    int cindex = 1;
                    int rindex = 1;
                    foreach (DataGridView dgv in dgvs)
                    {
                        cindex = 1;
                        foreach (DataGridViewColumn column in dgv.Columns) // 해당 타입의 모든 속성 가져오기
                        {
                            worksheet.Cells[rindex, cindex] = column.HeaderText;
                            cindex++;
                        }
                        rindex++;
                        // Datas
                        foreach (DataGridViewRow row in dgv.Rows)
                        {
                            cindex = 1;
                            foreach (DataGridViewCell cell in row.Cells)
                            {
                                if (cell.Value != null)
                                {
                                    worksheet.Cells[rindex, cindex] = cell.Value.ToString();
                                    cindex++;
                                }
                            }
                            rindex++;
                        }
                    }

                    // 파일 마무리
                    //1.파일 보이게하기
                    //excel.Visible = true;
                    //worksheet.Activate();

                    //2. 파일 저장하기
                    workbook.SaveAs(dialog.FileName, Excel.XlFileFormat.xlWorkbookNormal);
                    workbook.Close(true);
                    excel.Quit();

                    releaseObject(worksheet);
                    releaseObject(workbook);
                    releaseObject(excel);
                }
                catch (Exception ee)
                {
                    MessageBox.Show(ee.Message);
                }
            }
        }
        /// <summary>
        /// ComboBoxBinding
        /// </summary>
        public static void ComboBinding<T>(ComboBox combo, List<T> list, string Code, string CodeNm)
        {
            if (list == null)
                list = new List<T>();
            combo.DataSource = list;
            combo.DisplayMember = CodeNm;
            combo.ValueMember = Code;
        }
        /// <summary>
        ///  CodeNm : value가 설정될 프로퍼티명
        /// </summary>
        public static void ComboBinding<T>(ComboBox combo, List<T> list, string Code, string CodeNm, string blankText) where T : class, new()
        {
            if (list == null)
                list = new List<T>();
            T blankItem = new T();
            blankItem.GetType().GetProperty(CodeNm).SetValue(blankItem, blankText);
            list.Insert(0, blankItem);
            combo.DataSource = list;
            combo.DisplayMember = CodeNm;
            combo.ValueMember = Code;
        }
        /// <summary>
        /// MdiParent에 폼 열기
        /// </summary>
        /// <typeparam name="T">where T : Form, new()</typeparam>
        public static void FormOpen<T>(Form MdiParent) where T : Form, new()
        {
            foreach (Form childForm in Application.OpenForms)
            {
                if (childForm is T)
                {
                    childForm.Activate();
                    return;
                }
            }
            T myform = new T();
            myform.MdiParent = MdiParent;
            myform.WindowState = FormWindowState.Maximized;
            myform.Show();
        }
        /// <summary>
        /// Reader => List T
        /// </summary>
        public static List<T> DataReaderMapToList<T>(IDataReader dr)
        {
            try
            {
                List<T> list = new List<T>();
                T obj = default(T);
                while (dr.Read())
                {
                    obj = Activator.CreateInstance<T>();
                    foreach (PropertyInfo prop in obj.GetType().GetProperties())
                    {
                        if (ColumnExists(dr, prop.Name))
                        {
                            if (!object.Equals(dr[prop.Name], DBNull.Value))
                            {
                                prop.SetValue(obj, dr[prop.Name], null);
                            }
                        }
                        else
                        {
                            prop.SetValue(obj, null);
                        }
                    }
                    list.Add(obj);
                }
                return list;
            }
            catch (Exception err)
            {
                Debug.WriteLine(err.Message);
                return null;
            }
        }
        private static bool ColumnExists(IDataReader reader, string columnName)
        {

            return reader.GetSchemaTable()
                         .Rows
                         .OfType<DataRow>()
                         .Any(row => row["ColumnName"].ToString() == columnName);
        }
        /// <summary>
        /// DataTable => List T
        /// </summary>
        public static List<T> ConvertDataTableToList<T>(DataTable table) where T : class, new()
        {
            try
            {
                List<T> list = new List<T>();
                foreach (var row in table.AsEnumerable())
                {
                    T obj = new T();
                    foreach (var prop in obj.GetType().GetProperties())
                    {
                        try
                        {
                            PropertyInfo propertyInfo = obj.GetType().GetProperty(prop.Name);
                            propertyInfo.SetValue(obj, Convert.ChangeType(row[prop.Name], propertyInfo.PropertyType), null);
                        }
                        catch
                        {
                            continue;
                        }
                    }
                    list.Add(obj);
                }
                return list;
            }
            catch
            {
                return null;
            }
        }
    }
}
