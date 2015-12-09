using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Windows.Forms;

namespace WindowsFormsApplication2
{
    abstract class InfoAboutClients : ConnectDataBase
    {
        //список для записи Id выведенных данных, с параметром.
        protected List<int> newListIdClient;   

        //выборка в GridView
        public virtual void GridFill(DataGridView newGridView, string nameIdParametr)
        {
            try
            {
                List<int> newListIdClientTime = new List<int>();

                            string sqlCommandName = string.Format(Selection1);
                            SelectData(newGridView, sqlCommandName, NumberTable);

                            for (int j = 0; j < NewDataTable.Rows.Count; j++)
                            {
                                newListIdClientTime.Add(Convert.ToInt32(NewDataTable.Rows[j][nameIdParametr]));
                            }

                newListIdClient = new List<int>(newListIdClientTime.Distinct());
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }
        //добавление значений в комбобокс
        protected virtual void EnterDataText(ToolStripComboBox comboBoxEnterData,
            string sqlCommandOnEnterToData)
        {
            try
            {
                comboBoxEnterData.Items.Clear();
                string sqlCommandToData = string.Format(Selection1, sqlCommandOnEnterToData);
                SqlConnection newSqlConnection = ConDB();
                newSqlConnection.Close();
                newSqlConnection.Open();
                SqlCommand newCommand = new SqlCommand(sqlCommandToData, newSqlConnection);
                SqlDataReader newReader = newCommand.ExecuteReader();

                while (newReader.Read())
                {
                    comboBoxEnterData.Items.Add(newReader[sqlCommandOnEnterToData].ToString().Trim());
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }  
        //метод "события" поиска необходимых данных
        public abstract void SearchBut(DataGridView newGridView, ToolStripComboBox selectionCategory,
            ToolStripComboBox comboBoxEnterData, string nameIdParametr);
        //поиск по выбранному критерию
        public abstract void SelectionInCombo(ToolStripComboBox selectionCategory, ToolStripComboBox comboBoxEnterData);
        //добавление данных в DataGridView
        public void SelectBut(DataGridView mainGridView, DataGridView selectGridView)
        {
            try
            {
                MethodFillOnGrid(mainGridView, selectGridView, Selection1, newListIdClient);
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }
        //виды услуг выбранных пользователей
        public void KindsBut(DataGridView mainGridView, DataGridView selectGridView, ToolStripComboBox selectionCategory)
        {
            try
            {
                if (selectionCategory.Text == "Вид услуги")
                {
                    throw new Exception("Данная функция не доступна для выбранной категории поиска!");
                }
                SelectBut(mainGridView,selectGridView); 
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }
        //метод подсчёта дохода
        public virtual void Revenue(DataGridView gridView, string revenueName)
        {
            try
            {
                double averageClient = 0;
                double rezult = 0;
                int countClient = 0;
                for (int i = 0; i < gridView.Rows.Count; i++)
                {
                    for (int j = 0; j < gridView.Columns.Count; j++)
                    {
                        if (gridView.Columns[j].HeaderText == "Revenue")
                        {
                            averageClient += Convert.ToDouble(gridView.Rows[i].Cells[j].Value);
                            countClient++;
                        }
                    }
                }
                rezult = averageClient / countClient;
                if (rezult.ToString() == "NaN")
                {
                    throw new Exception("Не найдено поле Revenue!");
                }
                else
                {
                    MessageBox.Show(revenueName + rezult.ToString(), "Результат");
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }
    }
}
