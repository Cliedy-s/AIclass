﻿using System;
using System.Windows.Forms;

namespace Utility_1028
{
    public class UtiliyClass
    {
        static public void AddNewColumnToDataGridView(string headerText, string dataPropertyName,
                                                                    DataGridView dataGridView, Type type, int colWidth = 100, string name = null, bool visibility = true,
                                                                    DataGridViewContentAlignment alignment = DataGridViewContentAlignment.MiddleCenter)
        {
            DataGridViewTextBoxColumn col = new DataGridViewTextBoxColumn();
            col.HeaderText = headerText;
            col.DataPropertyName = dataPropertyName;
            col.Name = name ?? dataPropertyName;
            col.Width = colWidth;
            col.Visible = visibility;
            col.ValueType = type;
            col.ReadOnly = true;
            col.DefaultCellStyle.Alignment = alignment;
            dataGridView.Columns.Add(col);
        }
    }
}
