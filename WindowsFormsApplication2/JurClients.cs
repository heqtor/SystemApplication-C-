using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace WindowsFormsApplication2
{
    public partial class JurClients : Form
    {
        SaveData saveDataInExel = new SaveData();
        FunctionWhisParameters newFunction = new FunctionWhisParameters();
        private InfoAboutClientsJur newJur;
        
       
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

        public JurClients()
        {
            InitializeComponent();
  
            newJur = new InfoAboutClientsJur(ComboCategory);

            parametrSelary.Enabled = false;
            parametrYear.Enabled = false;

            SelaryPanel.Location = new Point(240, 119);
            DateAvailablePanel.Location = new Point(240, 119);
 
        }
        

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
            newJur.Selection1 =
                "select OrganizationClient.IdOrganization, OrganizationClient.NameOrganization, Revenue from KindsService, " +
                "OrganizationClient, PaymentJurPerson, InteractionJur where {0} = '{1}' " +
                "and PaymentJurPerson.IdPaymentJur = InteractionJur.IdPaymentJur and OrganizationClient.IdOrganization = " +
                "InteractionJur.IdOrganization and KindsService.IdKind = PaymentJurPerson.IdService;";
            newJur.Selection2 = "select OrganizationClient.IdOrganization, OrganizationClient.NameOrganization, Regions.NameRegion from Regions, " +
                                "OrganizationClient, Cities, InteractionJur where {0} = '{1}' " +
                                "and OrganizationClient.City = Cities.IdCity and Cities.IdRegion = Regions.IdRegion " +
                                "and OrganizationClient.IdOrganization = InteractionJur.IdOrganization";
            newJur.Selection3 = "select OrganizationClient.IdOrganization, OrganizationClient.NameOrganization, " +
                                "Cities.NameCity from OrganizationClient, Cities, InteractionJur where {0} = '{1}' " +
                                "and OrganizationClient.City = Cities.IdCity and OrganizationClient.IdOrganization = " +
                                "InteractionJur.IdOrganization";
            newJur.Selection4 = "select * from OrganizationClient where {0} = '{1}'";
            newJur.SearchBut(TableGrid, ComboCategory, ComTxtData, "IdOrganization");
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
            newJur.SelectionInCombo(ComboCategory, ComTxtData);
        }
        //инф. о всех физ. колиентах
        private void AllInfo_Click_1(object sender, EventArgs e)
        {
            newJur.Selection1 = "select * from OrganizationClient";
            newJur.GridFill(TableGrid, "IdOrganization");
            parameter = ChoiceEnum.Search.ToString();
        }
        //контакты
        private void ConntatsSel_Click(object sender, EventArgs e)
        {
            parameterByWritheParametr = null;
            newJur.Selection1 = "select NameOrganization, Fax, Telephone, Cities.NameCity, Address from " +
                                 "OrganizationClient, Cities where IdOrganization = {0} " +
                                 "and OrganizationClient.City = Cities.IdCity";
            string selection = newJur.Selection1;
            if (parameter == ChoiceEnum.Search.ToString())
            {
                newJur.SelectBut(TableGrid, TableGrid2);
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
            newJur.Selection1 = "select OrganizationClient.NameOrganization, KindsService.NameKind from " +
                                 "KindsService, OrganizationClient, PaymentJurPerson, InteractionJur where " +
                                 "OrganizationClient.IdOrganization = {0} and PaymentJurPerson.IdPaymentJur = " +
                                 "InteractionJur.IdPaymentJur and OrganizationClient.IdOrganization = " +
                                 "InteractionJur.IdOrganization and KindsService.IdKind = PaymentJurPerson.IdService";
            string selection = newJur.Selection1;
            if (parameter == ChoiceEnum.Search.ToString())
            {
                newJur.KindsBut(TableGrid, TableGrid2, ComboCategory);
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
            newJur.Selection1 = "select OrganizationClient.IdOrganization AS Клиент, OrganizationClient.NameOrganization, " +
                                 "Employee.IdEmployee, Employee.Name, " +
                                 "Employee.SecondName from Employee, OrganizationClient, " +
                                 "PaymentJurPerson, InteractionJur where OrganizationClient.IdOrganization = {0} " +
                                 "and InteractionJur.IdEmployee = Employee.IdEmployee and OrganizationClient.IdOrganization = " +
                                 "InteractionJur.IdOrganization and PaymentJurPerson.IdPaymentJur = InteractionJur.IdPaymentJur";
            string selection = newJur.Selection1;
            if (parameter == ChoiceEnum.Search.ToString())
            {
                newJur.SelectBut(TableGrid, TableGrid2);
            }
            else if (parameter == ChoiceEnum.Selary.ToString())
            {
                newFunction.SelectWhisParametr(TableGrid2, TableGrid, selection);
            }
            
        }
        //директор
        private void Director_Click(object sender, EventArgs e)
        {
            parameterByWritheParametr = null;
            newJur.Selection1 = "select OrganizationClient.IdOrganization AS Клиент, OrganizationClient.NameOrganization, " +
                               "DirectorOrg.IdDirector AS Директор, DirectorOrg.Name, DirectorOrg.MiddleName, " +
                               "DirectorOrg.SecondName, DirectorOrg.Telephone from DirectorOrg, OrganizationClient " +
                               "where OrganizationClient.IdOrganization = {0} and OrganizationClient.IdDirector = " +
                               "DirectorOrg.IdDirector";
            string selection = newJur.Selection1;
            if (parameter == ChoiceEnum.Search.ToString())
            {
                newJur.SelectBut(TableGrid, TableGrid2);
            }
            else if (parameter == ChoiceEnum.Selary.ToString())
            {
                newFunction.SelectWhisParametr(TableGrid2, TableGrid, selection);
            }
        }
        //представитель
        private void Agent_Click(object sender, EventArgs e)
        {
            parameterByWritheParametr = null;
            newJur.Selection1 = "select OrganizationClient.IdOrganization AS Клиент, OrganizationClient.NameOrganization, " +
                               "RepresentativeOrg.IdRepresentative AS Представитель, RepresentativeOrg.Name, " +
                               "RepresentativeOrg.MiddleName, RepresentativeOrg.SecondName, RepresentativeOrg.Telephone " +
                               "from RepresentativeOrg, OrganizationClient where OrganizationClient.IdOrganization = {0}" +
                               "and OrganizationClient.IdDirector = RepresentativeOrg.IdRepresentative";
            string selection = newJur.Selection1;
            if (parameter == ChoiceEnum.Search.ToString())
            {
                newJur.SelectBut(TableGrid, TableGrid2);
            }
            else if (parameter == ChoiceEnum.Selary.ToString())
            {
                newFunction.SelectWhisParametr(TableGrid2, TableGrid, selection);
            }
        }
        //cредний доход
        private void AverageClient_Click(object sender, EventArgs e)
        {
            parameterByWritheParametr = null;
            string revenueName = "Средний доход юредических лиц: ";
            newJur.Revenue(TableGrid, revenueName);
        }

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
                string selection = "select IdOrganization, NameOrganization,Revenue from OrganizationClient where Revenue < {0}";
                SelaryPanel.Visible = false;
                newFunction.SelaryLessBetter(TableGrid, parametrSelary, "IdOrganization", selection);
                SelaryPanel.Enabled = false;
                SelaryPanel.Visible = false;
                LessSel.Enabled = true;
                LargerSel.Enabled = true;
                parametrSelary.Enabled = false;
                parameter = ChoiceEnum.Selary.ToString();
            }
            else if (e.KeyData == Keys.Enter && LargerSel.Enabled == true)
            {
                string selection = "select IdOrganization, NameOrganization, Revenue from OrganizationClient where Revenue > {0}";
                SelaryPanel.Visible = false;
                newFunction.SelaryLessBetter(TableGrid, parametrSelary, "IdOrganization",selection);
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
                string selection = "select OrganizationClient.IdOrganization, OrganizationClient.NameOrganization, " +
                                    "PaymentJurPerson.IdPaymentJur,Revenue, DateAvailable from OrganizationClient,PaymentJurPerson, " +
                                    "InteractionJur where DateAvailable < '{0}' " +
                                    "and InteractionJur.IdPaymentJur = PaymentJurPerson.IdPaymentJur " +
                                    "and InteractionJur.IdOrganization = OrganizationClient.IdOrganization";
                SelaryPanel.Visible = false;
                newFunction.DataLessBetter(TableGrid, parametrYear, parametrMonth, parametrDay, "IdOrganization", selection);
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
                string selection = "select OrganizationClient.IdOrganization, OrganizationClient.NameOrganization, " +
                                    "PaymentJurPerson.IdPaymentJur,Revenue, DateAvailable from OrganizationClient,PaymentJurPerson, " +
                                    "InteractionJur where DateAvailable > '{0}' " +
                                    "and InteractionJur.IdPaymentJur = PaymentJurPerson.IdPaymentJur " +
                                    "and InteractionJur.IdOrganization = OrganizationClient.IdOrganization";
                SelaryPanel.Visible = false;
                newFunction.DataLessBetter(TableGrid, parametrYear, parametrMonth, parametrDay, "IdOrganization",selection);
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
            if(parameterByWritheParametr == ChoiceEnum.EmployeeWhisClient.ToString())
            newJur.InformationOnTheCell(TableGrid2);
        }
        //закрытие формы
        private void JurClients_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult resultDialog = MessageBox.Show("Вы уверены, что хотите закрыть окно?",
                "Закрытие", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (resultDialog == DialogResult.No)
            {
                e.Cancel = true;
            }
        }
        //сохранение данных
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
