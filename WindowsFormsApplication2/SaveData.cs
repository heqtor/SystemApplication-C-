using System;
using System.Windows.Forms;

namespace WindowsFormsApplication2
{
    class SaveData
    {
        //метод вывода данных в Exel
        public void MethodSaveData(DataGridView gridViewSave)
        {
            Microsoft.Office.Interop.Excel.Application ExcelApp = new Microsoft.Office.Interop.Excel.Application();
            ExcelApp.Application.Workbooks.Add(Type.Missing);
            ExcelApp.DisplayAlerts = true;
            ExcelApp.Columns.ColumnWidth = 20;

            int numberCells = 0;
            for (int i = 0; i < gridViewSave.ColumnCount; i++)
            {
                numberCells++;
                ExcelApp.Cells[1, numberCells] = gridViewSave.Columns[i].HeaderText;
            }

            for (int i = 0; i < gridViewSave.ColumnCount; i++)
            {
                ExcelApp.Cells[1, numberCells] = gridViewSave.Columns[i].HeaderText;
                for (int j = 0; j < gridViewSave.RowCount; j++)
                {
                    ExcelApp.Cells[j + 2, i + 1] = (gridViewSave[i, j].Value).ToString();
                }
            }
            ExcelApp.Visible = true;
        }
    }
}
