using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication2
{
    class InfoAboutClientsJur : InfoAboutClients
    {
        public List<string> nameComboBoxSelect = new List<string> { "Имя", "Город", 
                "Регион", "Уникальный индекс", "Вид услуги"};
        public List<string> newListNameCategory = new List<string> { "NameOrganization", "NameCity", "NameRegion", 
            "IdOrganization", "NameKind" };


        public InfoAboutClientsJur(ToolStripComboBox comboBoxCategory)
        { 
            for (int i = 0; i < nameComboBoxSelect.Count; i++)
            {
                comboBoxCategory.Items.Add(nameComboBoxSelect[i]);
            }
            NewListNameColumnsClient = newListNameCategory;
        }
        public InfoAboutClientsJur(){}

        //метод сортировки повторяющихся параметров поиска.
        private void EnterDataText(ToolStripComboBox com, ToolStripComboBox comboBoxEnterData,
            string sqlCommandOnEnterToData, string nameColumn1InDataBase, string nameColumn1InForm)
        {
            try
            {
                comboBoxEnterData.Items.Clear();
                string sqlCommandToData = string.Format(Selection1, sqlCommandOnEnterToData);
                SqlConnection newSqlConnection = new SqlConnection();
                newSqlConnection = ConDB();
                newSqlConnection.Close();
                newSqlConnection.Open();
                SqlCommand newCommand = new SqlCommand(sqlCommandToData, newSqlConnection);
                SqlDataReader newReader = newCommand.ExecuteReader();

                List<string> newListParametr1 = new List<string>();


                while (newReader.Read())
                {
                    if (sqlCommandOnEnterToData == nameColumn1InDataBase)
                    {
                        newListParametr1.Add(newReader[sqlCommandOnEnterToData].ToString().Trim());
                    }
                    else
                    {
                        comboBoxEnterData.Items.Add(newReader[sqlCommandOnEnterToData].ToString().Trim());
                    }
                }

                List<string> newListParametr1Dis = new List<string>(newListParametr1.Distinct());

                if (com.Text == nameColumn1InForm)
                {
                    for (int i = 0; i < newListParametr1Dis.Count; i++)
                    {
                        comboBoxEnterData.Items.Add(newListParametr1Dis[i].ToString().Trim());
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
                    else if (selectionCategory.Text == "Регион")
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
                    else if (selectionCategory.Text == "Город")
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
                    else
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
        public override void SelectionInCombo(ToolStripComboBox selectionCategory, 
            ToolStripComboBox comboBoxEnterData)
        {
            switch (selectionCategory.SelectedIndex)
            {
                case 0:
                    Selection1 = "select {0} from OrganizationClient";
                    EnterDataText(selectionCategory, comboBoxEnterData, "NameOrganization", "NameOrganization", "Имя");
                    break;
                case 1:
                    Selection1 = "select {0} from Cities";
                    EnterDataText(comboBoxEnterData, "NameCity");
                    break;
                case 2:
                    Selection1 = "select {0} from Regions";
                    EnterDataText(comboBoxEnterData, "NameRegion");
                    break;
                case 3:
                    Selection1 = "select {0} from OrganizationClient";
                    EnterDataText(comboBoxEnterData, "IdOrganization");
                    break;
                case 4:
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
            main.JurCheckBox.Checked = true;
            main.ComboCategory.Text = valueCategori;
            main.ComTxtData.Text = valueParemetr;
            main.Show();
            main.Search_Click();   
        }
        
    }
}
