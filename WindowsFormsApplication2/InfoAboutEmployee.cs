using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Windows.Forms;

namespace WindowsFormsApplication2
{
    class InfoAboutEmployee : ConnectDataBase
    {
        //
        protected List<int> newListIdClient;
        public List<string> nameComboBoxSelect = new List<string> { "Имя", "Фамилия", 
                "Отчество", "Должность", "Уникальный индекс", "Вид услуги"};
        public List<string> newListNameCategory = new List<string> { "Name", "SecondName", "MiddleName", 
            "NameJobTitle", "IdEmployee", "NameKind" };

        //параметр для записи перечисления 
        private string parameter;
        public string Parameter
        {
            get { return parameter; }
            set { parameter = value; }
        }
        //переменная для записи запроса
        private string selection5;
        public string Selection5
        {
            get { return selection5; }
            set { selection5 = value; }
        }

        public InfoAboutEmployee(ToolStripComboBox comboBoxCategory)
        {
            for (int i = 0; i < nameComboBoxSelect.Count; i++)
            {
                comboBoxCategory.Items.Add(nameComboBoxSelect[i]);
            }
            NewListNameColumnsClient = newListNameCategory;
        }
        public InfoAboutEmployee(){}
        
        //выборка в GridView
        public virtual void GridFill(DataGridView newGridView, string nameIdParametr, CheckBox jurBox, CheckBox physBox)
        {
            try
            {
                List<int> newListIdClientTime = new List<int>();
                string sqlCommandName = null;
                if (jurBox.Checked)
                {
                    sqlCommandName = string.Format(Selection1);
                }
                else if (physBox.Checked)
                {
                    sqlCommandName = string.Format(Selection2);
                }  
                SelectData(newGridView, sqlCommandName, NumberTable);

                for (int j = 0; j < NewDataTable.Rows.Count; j++)
                {
                    newListIdClientTime.Add(Convert.ToInt32(NewDataTable.Rows[j][nameIdParametr]));
                }
                newListIdClient = new List<int>(newListIdClientTime.Distinct());
            }
            catch (Exception)
            {
                MessageBox.Show("Не выбрано 'лицо'!");
            }
        } 
        //добавление значений в комбобокс
        protected virtual void EnterDataTextFromEmployee(ToolStripComboBox comboBoxEnterData,
            string sqlCommandOnEnterToData, CheckBox checkBoxClientPhyz, CheckBox checkBoxClientJur)
        {
            try
            {
                string sqlCommandToData = null; 
                comboBoxEnterData.Items.Clear();
                if (checkBoxClientPhyz.Checked)
                {
                    sqlCommandToData = string.Format(Selection1, sqlCommandOnEnterToData);
                }  
                else if(checkBoxClientJur.Checked)
                {
                    sqlCommandToData = string.Format(Selection2, sqlCommandOnEnterToData);
                } 
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
        //метод сортировки повторяющихся параметров поиска.
        protected virtual void EnterDataTextFromOtherTable(ToolStripComboBox comboBoxEnterData,
           string sqlCommandOnEnterToData)
        {
            try
            {
                string sqlCommandToData = null;
                comboBoxEnterData.Items.Clear();
                sqlCommandToData = string.Format(Selection1, sqlCommandOnEnterToData);  

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
        public void SearchBut(DataGridView newGridView, ToolStripComboBox selectionCategory, ToolStripComboBox comboBoxEnterData, 
            string nameIdParametr, CheckBox checkBoxClientPhyz, CheckBox checkBoxClientJur) 
        {
            try
            {
                List<int> newListIdClientTime = new List<int>();

                if (selectionCategory.SelectedIndex != -1)
                {
                    if (selectionCategory.Text == "Вид услуги")
                    {
                        if (checkBoxClientPhyz.Checked == true)
                        {
                            for (int i = 0; i < selectionCategory.Items.Count; i++)
                            {
                                if (selectionCategory.SelectedIndex == i)
                                {
                                    int indexElem = i;
                                    string sqlCommandName = string.Format(Selection1,
                                        NewListNameColumnsClient[indexElem], comboBoxEnterData.Text);
                                    SelectData(newGridView, sqlCommandName, NumberTable);

                                    for (int j = 0; j < NewDataTable.Rows.Count; j++)
                                    {
                                        newListIdClientTime.Add(Convert.ToInt32(NewDataTable.Rows[j][nameIdParametr]));
                                    }
                                }
                            }
                        }
                        else if (checkBoxClientJur.Checked == true)
                        {
                            for (int i = 0; i < selectionCategory.Items.Count; i++)
                            {
                                if (selectionCategory.SelectedIndex == i)
                                {
                                    int indexElem = i;
                                    string sqlCommandName = string.Format(Selection2,
                                        NewListNameColumnsClient[indexElem], comboBoxEnterData.Text);
                                    SelectData(newGridView, sqlCommandName, NumberTable);

                                    for (int j = 0; j < NewDataTable.Rows.Count; j++)
                                    {
                                        newListIdClientTime.Add(Convert.ToInt32(NewDataTable.Rows[j][nameIdParametr]));
                                    }
                                }
                            }
                        }
                    }
                    
                    else if (selectionCategory.Text == "Должность")
                    {
                        if (checkBoxClientPhyz.Checked == true)
                        {
                            for (int i = 0; i < selectionCategory.Items.Count; i++)
                            {
                                if (selectionCategory.SelectedIndex == i)
                                {
                                    int indexElem = i;
                                    string sqlCommandName = string.Format(Selection3,
                                        NewListNameColumnsClient[indexElem], comboBoxEnterData.Text);
                                    SelectData(newGridView, sqlCommandName, NumberTable);

                                    for (int j = 0; j < NewDataTable.Rows.Count; j++)
                                    {
                                        newListIdClientTime.Add(Convert.ToInt32(NewDataTable.Rows[j][nameIdParametr]));
                                    }
                                }
                            }
                        }
                        else if (checkBoxClientJur.Checked == true)
                        {
                            for (int i = 0; i < selectionCategory.Items.Count; i++)
                            {
                                if (selectionCategory.SelectedIndex == i)
                                {
                                    int indexElem = i;
                                    string sqlCommandName = string.Format(Selection4,
                                        NewListNameColumnsClient[indexElem], comboBoxEnterData.Text);
                                    SelectData(newGridView, sqlCommandName, NumberTable);

                                    for (int j = 0; j < NewDataTable.Rows.Count; j++)
                                    {
                                        newListIdClientTime.Add(Convert.ToInt32(NewDataTable.Rows[j][nameIdParametr]));
                                    }
                                }
                            }
                        }
                    }

                    else
                    {
                        for (int i = 0; i < selectionCategory.Items.Count; i++)
                        {
                            if (selectionCategory.SelectedIndex == i)
                            {
                                int indexElem = i;
                                string sqlCommandName = string.Format(Selection5,
                                    NewListNameColumnsClient[indexElem], comboBoxEnterData.Text);
                                SelectData(newGridView, sqlCommandName, NumberTable);

                                for (int j = 0; j < NewDataTable.Rows.Count; j++)
                                {
                                    newListIdClientTime.Add(Convert.ToInt32(NewDataTable.Rows[j][nameIdParametr]));
                                }
                            }
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Не выбрана категория поиска!");
                }

                newListIdClient = new List<int>(newListIdClientTime.Distinct());
            }
            catch (Exception)
            {
                MessageBox.Show("fd");
            }
        }
        //поиск по выбранному критерию
        public void SelectionInCombo(ToolStripComboBox selectionCategory, ToolStripComboBox comboBoxEnterData, 
            CheckBox checkBoxClientPhyz, CheckBox checkBoxClientJur)
        {
            switch (selectionCategory.SelectedIndex)
            {
                case 0:
                    Selection1 = "select {0} from Employee where Employee.ForPhysPerson = 'True'";
                    Selection2 = "select {0} from Employee where Employee.ForJurPerson = 'True'";
                    EnterDataTextFromEmployee(comboBoxEnterData, "Name", checkBoxClientPhyz, checkBoxClientJur);
                    break;
                case 1:
                    Selection1 = "select {0} from Employee where Employee.ForPhysPerson = 'True'";
                    Selection2 = "select {0} from Employee where Employee.ForJurPerson = 'True'";
                    EnterDataTextFromEmployee(comboBoxEnterData, "SecondName", checkBoxClientPhyz, checkBoxClientJur);
                    break;
                case 2:
                    Selection1 = "select {0} from Employee where Employee.ForPhysPerson = 'True'";
                    Selection2 = "select {0} from Employee where Employee.ForJurPerson = 'True'";
                    EnterDataTextFromEmployee(comboBoxEnterData, "MiddleName", checkBoxClientPhyz, checkBoxClientJur);
                    break;              
                case 3:
                    Selection1 = "select {0} from JobTitle";
                    EnterDataTextFromOtherTable(comboBoxEnterData, "NameJobTitle");
                    break;
                case 4:
                    Selection1 = "select {0} from Employee where Employee.ForPhysPerson = 'True'";
                    Selection2 = "select {0} from Employee where Employee.ForJurPerson = 'True'";
                    EnterDataTextFromEmployee(comboBoxEnterData, "IdEmployee", checkBoxClientPhyz, checkBoxClientJur);
                    break;
                case 5:
                    Selection1 = "select {0} from KindsService";
                    EnterDataTextFromOtherTable(comboBoxEnterData, "NameKind");
                    break;
            }
        }
        //метод для вывода инф. в другую таблицу по Id
        protected void MethodFillOnGrid(DataGridView mainGridView, DataGridView conntactGridView, String stringSelect, List<int> listId)
        {
            try
            {
                if (mainGridView.RowCount == 0)
                {
                    throw new Exception("Не выполнен поиск данных по критерию!");
                }
                conntactGridView.Rows.Clear();
                conntactGridView.Columns.Clear();

                SqlConnection connection = ConDB();
                DataSet newSetSelect = new DataSet();
                for (int i = 0; i < listId.Count; i++)
                {
                    string sqlCommandToData = string.Format(stringSelect, listId[i]);
                    SqlDataAdapter newDataAdapter = new SqlDataAdapter(sqlCommandToData, connection);
                    newDataAdapter.Fill(newSetSelect);
                    connection.Close();
                }
                PrintData(newSetSelect, 0, conntactGridView);
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }        
        //вывод информации во вторую таблицу
        public void SelectBut(DataGridView mainGridView, DataGridView selectGridView,
            CheckBox checkBoxClientPhyz, CheckBox checkBoxClientJur) 
        {
            try
            {     
               
                if (checkBoxClientPhyz.Checked == true && checkBoxClientJur.Checked == false)
                {
                    MethodFillOnGrid(mainGridView, selectGridView, Selection1, newListIdClient);
                }
                else if (checkBoxClientJur.Checked == true && checkBoxClientPhyz.Checked == false)
                {
                    MethodFillOnGrid(mainGridView, selectGridView, Selection2, newListIdClient);
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }
        //метод возникающий, для предотвращения нажатия кнопки «Вид услуги», при выборе критерия поиска «Вид услуги». 
        public void KindsBut(DataGridView mainGridView, DataGridView selectGridView, ToolStripComboBox selectionCategory,
           CheckBox checkBoxClientPhyz, CheckBox checkBoxClientJur)
        {
            try
            {
                if (selectionCategory.Text == "Вид услуги")
                {
                    throw new Exception("Данная функция не доступна для выбранной категории поиска!");
                }
                else { }
                SelectBut(mainGridView,selectGridView,checkBoxClientPhyz,checkBoxClientJur);
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        } 
        //поиск по ячейке
        public void InformationOnTheCell(DataGridView gridView, CheckBox jurBox,CheckBox physBox)
        {
            string valueParemetr = null;
            string valueCategori = null;

            if (jurBox.Checked)
            {
                InfoAboutClientsJur newAboutJur = new InfoAboutClientsJur();

                for (int i = 0; i < newAboutJur.newListNameCategory.Count; i++)
                {
                    if (gridView.Columns[gridView.CurrentCell.ColumnIndex].HeaderText ==
                        newAboutJur.newListNameCategory[i])
                    {
                        valueParemetr = gridView.Rows[gridView.CurrentRow.Index].
                        Cells[gridView.CurrentCell.ColumnIndex].Value.ToString();
                        valueCategori = newAboutJur.nameComboBoxSelect[i];
                    }
                }
                JurClients main = new JurClients();
                main.ComboCategory.Text = valueCategori;
                main.ComTxtData.Text = valueParemetr;
                main.Show();
                main.Search_Click();
            }
            else if(physBox.Checked)
            {
                InfoAboutClientsPhys newAboutPhys = new InfoAboutClientsPhys();

                for (int i = 0; i < newAboutPhys.newListNameCategory.Count; i++)
                {
                    if (gridView.Columns[gridView.CurrentCell.ColumnIndex].HeaderText ==
                        newAboutPhys.newListNameCategory[i])
                    {
                        valueParemetr = gridView.Rows[gridView.CurrentRow.Index].
                        Cells[gridView.CurrentCell.ColumnIndex].Value.ToString();
                        valueCategori = newAboutPhys.nameComboBoxSelect[i];
                    }
                }
                PhysClients main = new PhysClients();
                main.ComboCategory.Text = valueCategori;
                main.ComTxtData.Text = valueParemetr;
                main.Show();
                main.Search_Click();
            }  
        }
        //метод подсчёта сколько в среднем работают лет, сотрудники. 
        public void OfficeWorkExpEmployee(DataGridView gridView)
        {
            try
            {
                int averageEmployee = 0;
                int rezult = 0;
                int countClient = 0;
            
                for (int i = 0; i < gridView.Rows.Count; i++)
                {
                    for (int j = 0; j < gridView.Columns.Count; j++)
                    {
                        if (gridView.Columns[j].HeaderText == "WorkExperience")
                        {
                            averageEmployee += Convert.ToInt32(gridView.Rows[i].Cells[j].Value);
                            countClient++;
                        } 
                    }
                }
                if (countClient == 0)
                {
                    throw new Exception("Не найдено поле WorkExperience!");
                }
                rezult = averageEmployee / countClient;
                if (rezult.ToString() == "NaN")
                {
                    throw new Exception("Не найдено поле WorkExperience!");
                }
                else
                {
                    MessageBox.Show("Средний возраст выслуги: " + rezult.ToString(), "Результат");   
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }
        //метод подсчёта среднего возраста работников.
        public void OfficeBirthEmployee(DataGridView gridView)
        {
            try
            {
                int nowYear = DateTime.Now.Year;
                int averageEmployee = 0;
                int rezult = 0;
                int countClient = 0;
                for (int i = 0; i < gridView.Rows.Count; i++)
                {
                    for (int j = 0; j < gridView.Columns.Count; j++)
                    {
                        if (gridView.Columns[j].HeaderText == "BirthDate")
                        {
                            averageEmployee += (nowYear - Convert.ToDateTime(gridView.Rows[i].Cells[j].Value).Year);
                            countClient++;
                        }
                    }
                }
                if (countClient == 0)
                {
                    throw new Exception("Не найдено поле BirthDate!"); 
                }
                rezult = averageEmployee/countClient;
                if (rezult.ToString() == "NaN" && rezult == 0)
                {
                    throw new Exception("Не найдено поле BirthDate!");
                }
                else
                {
                    MessageBox.Show("Средний возраст сотрудников: " + rezult.ToString() + " лет(года)", "Результат");
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            } 
        }
    }
}
