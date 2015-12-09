using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace WindowsFormsApplication2
{
    class FunctionWhisParameters : ConnectDataBase
    {
        //список для записи Id выведенных данных 
        private List<int> newListId;

        //зарплата больше/меньше 
        public void SelaryLessBetter(DataGridView conntactGridView, TextBox newTextBox, string nameIdParametr, 
            string selection)
        {
            try
            {
                List<int> timeList = new List<int>();
                string newConntact = string.Format(selection, Convert.ToInt32(newTextBox.Text));
                SelectData(conntactGridView, newConntact, 0);
                for (int j = 0; j < NewDataTable.Rows.Count; j++)
                {
                    timeList.Add(Convert.ToInt32(NewDataTable.Rows[j][nameIdParametr]));
                }
                newListId = timeList;
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
            
        }
        //дата меньше/больше
        public void DataLessBetter(DataGridView conntactGridView, TextBox year, TextBox month,
            TextBox day, string nameIdParametr, string selection)
        {

            try
            {
                List<int> timeList = new List<int>();
                DateTime newDateTime = new DateTime(Convert.ToInt32(year.Text), Convert.ToInt32(month.Text), Convert.ToInt32(day.Text));
                string newConntact = string.Format(selection, newDateTime);
                SelectData(conntactGridView, newConntact, 0);
                for (int j = 0; j < NewDataTable.Rows.Count; j++)
                {
                    timeList.Add(Convert.ToInt32(NewDataTable.Rows[j][nameIdParametr]));
                }
                newListId = timeList;
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }

        }
        //метод вывода информации с переменными
        public void SelectWhisParametr(DataGridView conntactGridView, DataGridView mainGridView, string selection)
        {
            try
            {
                MethodFillOnGrid(mainGridView, conntactGridView, selection, newListId);
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }     
    }
}
