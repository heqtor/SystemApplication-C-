using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication2
{
    public partial class PhysClients : Form
    {
        SaveData saveDataInExel = new SaveData();
        private InfoAboutClientsPhys newPhuz;
        FunctionWhisParameters newFunction = new FunctionWhisParameters();

        //параметр для записи значения перечисления 
        private string parameter;
        public string Parameter
        {
            get { return parameter; }
            set { parameter = value; }
        }
        //второй параметр для записи перечисления
        private string parameterByWritheParametr;
        public string ParameterByWritheParametr
        {
            get { return parameterByWritheParametr; }
            set { parameterByWritheParametr = value; }
        }

        public PhysClients()
        {
            InitializeComponent();

            newPhuz = new InfoAboutClientsPhys(ComboCategory);  

            parametrSelary.Enabled = false;
            parametrYear.Enabled = false;

            SelaryPanel.Location = new Point(240, 119);
            DateAvailablePanel.Location = new Point(240, 119);
            
        }        

        //очистка combobox при нажатии
        #region CleanText
        private void TextClean(ToolStripComboBox comboBoxClean)
        {
            comboBoxClean.Text = "";
        } 
        private void ComboCategory_Click(object sender, EventArgs e)
        {
            TextClean(ComboCategory);   
        }
        private void ComTxtData_Click(object sender, EventArgs e)
        {
            TextClean(ComTxtData);
        }  
        #endregion


        public void Search_Click()
        {
            newPhuz.Selection1 = "select PhysPersonClient.IdClient, PhysPersonClient.Name, " +
                          "PhysPersonClient.SecondName, PhysPersonClient.MiddleName " +
                          "from KindsService, PhysPersonClient," +
                          " PaymentPhysPerson, InteractionPhys where {0} = '{1}' and " +
                          "PaymentPhysPerson.IdPaymentPhys = InteractionPhys.IdPaymentPhys and  " +
                          "PhysPersonClient.IdClient = InteractionPhys.IdClient and " +
                          "KindsService.IdKind = PaymentPhysPerson.IdService;";
            newPhuz.Selection2 = "select * from PhysPersonClient where {0} = '{1}'";
            newPhuz.SearchBut(TableGrid,ComboCategory,ComTxtData, "IdClient");
            parameter = ChoiceEnum.Search.ToString();
        }
        //кнопка поиск
        private void ButtSearch1_Click(object sender, EventArgs e)
        {
            Search_Click();
        }
        //заполнение ComboBox
        private void ComboCategory_SelectedIndexChanged(object sender, EventArgs e)
        {           
            newPhuz.SelectionInCombo(ComboCategory, ComTxtData);   
        }
        //инф. о всех физ. колиентах
        private void AllInfo_Click_1(object sender, EventArgs e)
        {
            newPhuz.Selection1 = "select * from PhysPersonClient";
            newPhuz.GridFill(TableGrid, "IdClient");
            parameter = ChoiceEnum.Search.ToString();
        }
        //контакты
        private void ConntatsSel_Click(object sender, EventArgs e)
        {
            parameterByWritheParametr = null;

            newPhuz.Selection1 = "select Name, SecondName, MiddleName, MobileTelephone, HomeTelephone, Email, " +
                                 "Address from PhysPersonClient where IdClient = {0}";
            string selection = newPhuz.Selection1;

            if (parameter == ChoiceEnum.Search.ToString()) 
            {
                newPhuz.SelectBut(TableGrid, TableGrid2);
            }
            else if (parameter == ChoiceEnum.Selary.ToString())
            {
                newFunction.SelectWhisParametr(TableGrid2, TableGrid, selection);
            }      
        }
        //вид услуги
        private void KindsSel_Click(object sender, EventArgs e)
        {
            parameterByWritheParametr = null;
            newPhuz.Selection1 = "select PhysPersonClient.Name, PhysPersonClient.MiddleName, PhysPersonClient.SecondName, " +
                                          "KindsService.NameKind from KindsService, PhysPersonClient, PaymentPhysPerson, " +
                                          "InteractionPhys where PhysPersonClient.IdClient = {0} and " +
                                          "PaymentPhysPerson.IdPaymentPhys = InteractionPhys.IdPaymentPhys and " +
                                          "PhysPersonClient.IdClient = InteractionPhys.IdClient and " +
                                          "KindsService.IdKind = PaymentPhysPerson.IdService";
            string selection = newPhuz.Selection1;
            if (parameter == ChoiceEnum.Search.ToString())
            {
                newPhuz.KindsBut(TableGrid, TableGrid2, ComboCategory);
            }
            else if (parameter == ChoiceEnum.Selary.ToString())
            {
                newFunction.SelectWhisParametr(TableGrid2, TableGrid, selection);
            }
        }
        //сотрудник обслуживающий клиента 
        private void EmployeeSel_Click(object sender, EventArgs e)
        {
            parameterByWritheParametr = ChoiceEnum.EmployeeWhisClient.ToString();
            newPhuz.Selection1 = "select PhysPersonClient.IdClient, PhysPersonClient.Name AS NameClient, " +
                                 "PhysPersonClient.MiddleName AS MiddleName, " +
                "PhysPersonClient.SecondName AS SecondNameClient , Employee.IdEmployee, Employee.Name , " +
                "Employee.SecondName from Employee, PhysPersonClient, PaymentPhysPerson, InteractionPhys " +
                "where PhysPersonClient.IdClient = {0} and InteractionPhys.IdEmployee = Employee.IdEmployee " +
                "and PhysPersonClient.IdClient = InteractionPhys.IdClient and " +
                "PaymentPhysPerson.IdPaymentPhys = InteractionPhys.IdPaymentPhys";
            string selection = newPhuz.Selection1;

            if (parameter == ChoiceEnum.Search.ToString())
            {

                newPhuz.SelectBut(TableGrid, TableGrid2);  
            }
            else if (parameter == ChoiceEnum.Selary.ToString())
            {
                newFunction.SelectWhisParametr(TableGrid2, TableGrid, selection);  
            }              
        }
        //средня зарплата
        private void AverageClient_Click(object sender, EventArgs e)
        {
            string revenueName = "Средняя зарплата физических лиц: ";
            newPhuz.Revenue(TableGrid, revenueName);
        }

        //мелкие действия вывода информации по зарплате с параметрами
        #region Selary
        private void SalaryBut_Click(object sender, EventArgs e)
        {
            SelaryPanel.Enabled = true;
            SelaryPanel.Visible = true;
            parametrSelary.Text = "Число";
        }
        private void parametrSelary_KeyDown(object sender, KeyEventArgs e)
        {     
            if (e.KeyData == Keys.Enter && LessSel.Enabled == true)
            {
                string selection = "select IdClient, Name, SecondName, MiddleName " +
                                     "from PhysPersonClient where Revenue < {0}";
                SelaryPanel.Visible = false;
                newFunction.SelaryLessBetter(TableGrid, parametrSelary, "IdClient", selection);
                SelaryPanel.Enabled = false;
                SelaryPanel.Visible = false;
                LessSel.Enabled = true;
                LargerSel.Enabled = true;
                parametrSelary.Enabled = false;
                parameter = ChoiceEnum.Selary.ToString();
            }
            else if (e.KeyData == Keys.Enter && LargerSel.Enabled == true)
            {
                string selection = "select IdClient, Name, SecondName, MiddleName " +
                                     "from PhysPersonClient where Revenue > {0}";
                SelaryPanel.Visible = false;
                newFunction.SelaryLessBetter(TableGrid, parametrSelary, "IdClient", selection);
                SelaryPanel.Enabled = false;
                SelaryPanel.Visible = false;
                LessSel.Enabled = true;
                LargerSel.Enabled = true;
                parametrSelary.Enabled = false;
                parameter = ChoiceEnum.Selary.ToString();
            }
        }
        private void LessSel_Click(object sender, EventArgs e)
        {
            LargerSel.Enabled = false;
            parametrSelary.Enabled = true;
            parametrSelary.Focus();
        }
        private void LargerSel_Click(object sender, EventArgs e)
        {
            LessSel.Enabled = false;
            parametrSelary.Enabled = true;
            parametrSelary.Focus();
        }
        private void BackSel_Click(object sender, EventArgs e)
        {
            LargerSel.Enabled = true;
            LessSel.Enabled = true;
            parametrSelary.Enabled = false;
        }
        private void exitPanelSelary_Click(object sender, EventArgs e)
        {
            SelaryPanel.Enabled = false;
            SelaryPanel.Visible = false;
            LessSel.Enabled = true;
            LargerSel.Enabled = true;
            parametrSelary.Enabled = false;
        }
        private void parametrSelary_Enter(object sender, EventArgs e)
        {
            parametrSelary.Text = "";
        }
        #endregion
        //мелкие действия вывода информации по дате платежа с параметрами
        #region DateAvailable
        private void DateAvailableBut_Click(object sender, EventArgs e)
        {
            DateAvailablePanel.Enabled = true;
            DateAvailablePanel.Visible = true;
            parametrYear.Text = "Год";
            parametrMonth.Text = "Месяц";
            parametrDay.Text = "День";
        }
        private void parametrYear_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Tab)
            {
                parametrMonth.Focus();
            }
        }
        private void parametrMonth_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Tab)
            {
                parametrDay.Focus();
            }
        }
        private void parametrDay_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter && LessDate.Enabled == true && parametrYear.Text != ""
                && parametrMonth.Text != "")
            {
                string selection = "select PhysPersonClient.IdClient, PhysPersonClient.Name, " +
                                     "PhysPersonClient.SecondName, PhysPersonClient.MiddleName, " +
                                     "PaymentPhysPerson.IdPaymentPhys, DateAvailable from " +
                                     "PhysPersonClient, PaymentPhysPerson, InteractionPhys " +
                                     "where DateAvailable < '{0}' and " +
                                     "InteractionPhys.IdPaymentPhys = PaymentPhysPerson.IdPaymentPhys " +
                                     "and InteractionPhys.IdClient = PhysPersonClient.IdClient";
                SelaryPanel.Visible = false;
                newFunction.DataLessBetter(TableGrid, parametrYear, parametrMonth, parametrDay, "IdClient", selection);
                DateAvailablePanel.Enabled = false;
                DateAvailablePanel.Visible = false;
                LessDate.Enabled = true;
                LargerDate.Enabled = true;
                parametrYear.Enabled = false;
                parametrMonth.Enabled = false;
                parametrDay.Enabled = false;
                parameter = ChoiceEnum.Selary.ToString();
            }
            else if (e.KeyData == Keys.Enter && LargerDate.Enabled == true && parametrYear.Text != ""
                && parametrMonth.Text != "")
            {
                string selection = "select PhysPersonClient.IdClient, PhysPersonClient.Name, " +
                                     "PhysPersonClient.SecondName, PhysPersonClient.MiddleName, " +
                                     "PaymentPhysPerson.IdPaymentPhys, DateAvailable from " +
                                     "PhysPersonClient, PaymentPhysPerson, InteractionPhys " +
                                     "where DateAvailable > '{0}' and " +
                                     "InteractionPhys.IdPaymentPhys = PaymentPhysPerson.IdPaymentPhys " +
                                     "and InteractionPhys.IdClient = PhysPersonClient.IdClient";
                SelaryPanel.Visible = false;
                newFunction.DataLessBetter(TableGrid, parametrYear, parametrMonth, parametrDay, "IdClient", selection);
                DateAvailablePanel.Enabled = false;
                DateAvailablePanel.Visible = false;
                LessDate.Enabled = true;
                LargerDate.Enabled = true;
                parametrYear.Enabled = false;
                parametrMonth.Enabled = false;
                parametrDay.Enabled = false;
                parameter = ChoiceEnum.Selary.ToString();
            }
            
        }      
        private void LessDate_Click(object sender, EventArgs e)
        {
            LargerDate.Enabled = false;
            parametrYear.Enabled = true;
            parametrMonth.Enabled = true;
            parametrDay.Enabled = true;
            parametrYear.Focus();
        }
        private void LargerDate_Click(object sender, EventArgs e)
        {
            LessDate.Enabled = false;
            parametrYear.Enabled = true;
            parametrMonth.Enabled = true;
            parametrDay.Enabled = true;
            parametrYear.Focus();
        }
        private void BackDate_Click(object sender, EventArgs e)
        {
            LargerDate.Enabled = true;
            LessDate.Enabled = true;
            parametrYear.Enabled = false;
            parametrMonth.Enabled = false;
            parametrDay.Enabled = false;
        }
        private void exitPanelDate_Click(object sender, EventArgs e)
        {
            DateAvailablePanel.Enabled = false;
            DateAvailablePanel.Visible = false;
            LessDate.Enabled = true;
            LargerDate.Enabled = true;
            parametrYear.Enabled = false;
            parametrMonth.Enabled = false;
            parametrDay.Enabled = false;
        }
        private void parametrYear_Enter(object sender, EventArgs e)
        {
            parametrYear.Text = "";
        }
        private void parametrMonth_Enter(object sender, EventArgs e)
        {
            parametrMonth.Text = "";
        }
        private void parametrDay_Enter(object sender, EventArgs e)
        {
            parametrDay.Text = "";
        }
        #endregion

        //инф. по ячейке
        private void TableGrid2_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (parameterByWritheParametr == ChoiceEnum.EmployeeWhisClient.ToString())
                newPhuz.InformationOnTheCell(TableGrid2);
        }
        //закрытие формы
        private void PhysClients_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult resultDialog = MessageBox.Show("Вы уверены, что хотите закрыть окно?",
                "Закрытие", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (resultDialog == DialogResult.No)
            {
                e.Cancel = true;
            }
        }
        //вызов метода сохранения данных
        private void SaveTable1_Click(object sender, EventArgs e)
        {
            saveDataInExel.MethodSaveData(TableGrid);
        }
        private void SaveTable2_Click(object sender, EventArgs e)
        {
            saveDataInExel.MethodSaveData(TableGrid2);
        }
    }
}
