using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace WindowsFormsApplication2
{
    abstract class ConnectDataBase
    {
        private DataTable newDataTable; //переменная для созд. таблицы
        protected DataTable NewDataTable
        {
            get { return newDataTable; }
            set { newDataTable = value; }
        }

        //переменная служит для определения номера таблицы, выбранной из БД
        private int numberTable;
        protected int NumberTable
        {
            get { return numberTable = 0; }
        }
        //список для записи имени выбраной категории поиска
        protected List<string> newListNameColumnsClient;
        public List<string> NewListNameColumnsClient
        {
            get { return newListNameColumnsClient; }
            set { newListNameColumnsClient = value; }
        }      
        //первая переменная для запроса
        private string selection1;
        public string Selection1
        {
            get { return selection1; }
            set { selection1 = value; }
        }
        //вторая переменная для запроса
        private string selection2;
        public string Selection2
        {
            get { return selection2; }
            set { selection2 = value; }
        }
        //третья переменная для запроса
        private string selection3;
        public string Selection3
        {
            get { return selection3; }
            set { selection3 = value; }
        }
        //четвертая переменная для запроса
        private string selection4;
        public string Selection4
        {
            get { return selection4; }
            set { selection4 = value; }
        }
        //подключение к бд
        protected SqlConnection ConDB()
        {
            SqlConnection newConnection = new SqlConnection(@"Data Source=ALEXANDER-ПК\SQLEXPRESS; 
                    Integrated Security=SSPI; Initial Catalog = dulski;");
            newConnection.Open();
            return newConnection;
        }

        //добавление данных в таблицу
        protected void SelectData(DataGridView newGridView, String sqlCommand, Int32 indexTable)
        {
            
                newGridView.Rows.Clear();
                DataSet newSet = new DataSet();

                SqlConnection connection = ConDB();
                SqlDataAdapter newDataAdapter = new SqlDataAdapter(sqlCommand, connection);
                newDataAdapter.Fill(newSet);
                connection.Close();

                PrintData(newSet, indexTable, newGridView);
                 
        }
        //добавление данных в "главный" DataGridView
        protected void PrintData(DataSet newSet, int indexTable, DataGridView newGridView)
        {
            try
            {
                NewDataTable = newSet.Tables[indexTable];

                newGridView.ColumnCount = NewDataTable.Columns.Count;
                newGridView.Rows.Add(NewDataTable.Rows.Count);

                for (int c = 0; c < NewDataTable.Columns.Count; c++)
                {
                    newGridView.Columns[c].HeaderText = NewDataTable.Columns[c].ToString().Trim();
                }

                for (int r = 0; r < newGridView.Rows.Count; r++)
                {
                    for (int c = 0; c < NewDataTable.Columns.Count; c++)
                    {
                        newGridView.Rows[r].Cells[c].Value = NewDataTable.Rows[r][c].ToString().Trim();
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Не найдено данных по вашему запросу!","",MessageBoxButtons.OK,MessageBoxIcon.None);
            }      
        }
        //добавление данных в "зависимый" DataGridView
        protected void MethodFillOnGrid(DataGridView mainGridView, DataGridView conntactGridView, 
            String stringSelect, List<int> listId)
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
    }
}
