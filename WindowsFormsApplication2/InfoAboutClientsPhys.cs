using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Windows.Forms;

namespace WindowsFormsApplication2
{
    class InfoAboutClientsPhys : InfoAboutClients
    {
        //список имен категорий
        public List<string> nameComboBoxSelect = new List<string>() { "Имя", "Фамилия", 
                "Отчество","Место работы", "Должность", "Уникальный индекс", "Вид услуги"};
        //список имен категорий, соответствующих именам в базе данных
        public List<string> newListNameCategory = new List<string> { "Name", "SecondName", "MiddleName", 
            "Job", "JobTitle", "IdClient", "NameKind" };

        //параметр для записи значения перечисления 
        private string parameter;
        public string Parameter
        {
            get { return parameter; }
            set { parameter = value; }
        }

        public InfoAboutClientsPhys(ToolStripComboBox comboBoxCategory)
        { 
            for (int i = 0; i < nameComboBoxSelect.Count; i++)
            {
                comboBoxCategory.Items.Add(nameComboBoxSelect[i]);
            }
            NewListNameColumnsClient = newListNameCategory;
        }

        public InfoAboutClientsPhys(){}

        //метод сортировки повторяющихся параметров поиска.
        private void EnterDataText(ToolStripComboBox com, ToolStripComboBox comboBoxEnterData,
            string sqlCommandOnEnterToData, string nameColumn1InDataBase,
            string nameColumn2InDataBase, string nameColumn1InForm, string nameColumn2InForm)
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

                List<string> newListParametr1 = new List<string>();
                List<string> newListParametr2 = new List<string>();

                while (newReader.Read())
                {
                    if (sqlCommandOnEnterToData == nameColumn1InDataBase)
                    {
                        newListParametr1.Add(newReader[sqlCommandOnEnterToData].ToString().Trim());
                    }
                    else if (sqlCommandOnEnterToData == nameColumn2InDataBase)
                    {
                        newListParametr2.Add(newReader[sqlCommandOnEnterToData].ToString().Trim());
                    }
                    else
                    {
                        comboBoxEnterData.Items.Add(newReader[sqlCommandOnEnterToData].ToString().Trim());
                    }
                }

                List<string> newListParametr1Dis = new List<string>(newListParametr1.Distinct());
                List<string> newListParametr2Dis = new List<string>(newListParametr2.Distinct());

                if (com.Text == nameColumn1InForm || com.Text == nameColumn2InForm)
                {
                    for (int i = 0; i < newListParametr1Dis.Count; i++)
                    {
                        comboBoxEnterData.Items.Add(newListParametr1Dis[i].ToString().Trim());
                    }
                    for (int i = 0; i < newListParametr2Dis.Count; i++)
                    {
                        comboBoxEnterData.Items.Add(newListParametr2Dis[i].ToString().Trim());
                    }
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }

        }
        //метод поиска
        public override void SearchBut(DataGridView newGridView, ToolStripComboBox selectionCategory, 
            ToolStripComboBox comboBoxEnterData, string nameIdParametr)
        {
            try
            {
                List<int> newListIdClientTime = new List<int>();

                if (selectionCategory.SelectedIndex != -1)
                {
                    if (selectionCategory.Text == "Вид услуги")
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
                    else
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
                else
                {
                    MessageBox.Show("Не выбрана категория поиска!");
                }

                newListIdClient = new List<int>(newListIdClientTime.Distinct());
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }
        //метод выбора категории поиска
        public override void SelectionInCombo(ToolStripComboBox selectionCategory, ToolStripComboBox comboBoxEnterData)
        {
            switch (selectionCategory.SelectedIndex)
            {
                case 0:
                    Selection1 = "select {0} from PhysPersonClient";
                    EnterDataText(comboBoxEnterData, "Name");
                    break;
                case 1:
                    Selection1 = "select {0} from PhysPersonClient";
                    EnterDataText(comboBoxEnterData, "SecondName");
                    break;
                case 2:
                    Selection1 = "select {0} from PhysPersonClient";
                    EnterDataText(comboBoxEnterData, "MiddleName");
                    break;
                case 3:
                    Selection1 = "select {0} from PhysPersonClient";
                    EnterDataText(selectionCategory, comboBoxEnterData, "Job", "Job", "JobTitle",
                        "Место работы", "Должность");
                    break;
                case 4:
                    Selection1 = "select {0} from PhysPersonClient";
                    EnterDataText(selectionCategory, comboBoxEnterData, "JobTitle", "Job", "JobTitle",
                        "Место работы", "Должность");
                    break;
                case 5:
                    Selection1 = "select {0} from PhysPersonClient";
                    EnterDataText(comboBoxEnterData, "IdClient");
                    break;
                case 6:
                    Selection1 = "select {0} from KindsService";
                    EnterDataText(comboBoxEnterData, "NameKind");
                    break;
            }
        }
        //метод получени информации по ячейке
        public void InformationOnTheCell(DataGridView gridView)
        {
            InfoAboutEmployee newAboutEmployee = new InfoAboutEmployee();

            string valueParemetr = null;
            string valueCategori = null;
            for (int i = 0; i < newAboutEmployee.newListNameCategory.Count; i++)
            {
                if (gridView.Columns[gridView.CurrentCell.ColumnIndex].HeaderText ==
                    newAboutEmployee.newListNameCategory[i])
                {
                    valueParemetr = gridView.Rows[gridView.CurrentRow.Index].
                    Cells[gridView.CurrentCell.ColumnIndex].Value.ToString();
                    valueCategori = newAboutEmployee.nameComboBoxSelect[i];
                }
            }

            Employee main = new Employee();
            main.PhyzCheckBox.Checked = true;
            main.ComboCategory.Text = valueCategori;
            main.ComTxtData.Text = valueParemetr;
            main.Show();
            main.Search_Click(); 
        }    
    }
}
