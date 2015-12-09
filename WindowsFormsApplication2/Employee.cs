using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;


namespace WindowsFormsApplication2
{
    public partial class Employee : Form
    {
        private InfoAboutEmployee newEmployeeObject;
        FunctionWhisParameters newFunction = new FunctionWhisParameters();
        SaveData saveDataInExel = new SaveData();

        private JurClients jurClientsForm;
        private PhysClients physClientsForm;

        //параметр для записи перечисления 
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

        public Employee()
        {
            InitializeComponent();

            newEmployeeObject = new InfoAboutEmployee(ComboCategory);
   
            parametrSelary.Enabled = false;
            parametrYear.Enabled = false;

            SelaryPanel.Location = new Point(240, 119);
            DateAvailablePanel.Location = new Point(240, 119);


            if (PhyzCheckBox.Checked == false && JurCheckBox.Checked == false)
            {
                ComboCategory.Enabled = false;
                ComTxtData.Enabled = false;
                ButtSearch1.Enabled = false;
            }
            
             jurClientsForm = this.Owner as JurClients;
             physClientsForm = this.Owner as PhysClients;
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
            newEmployeeObject.Selection1 = "select Employee.IdEmployee, Employee.Name, Employee.SecondName, Employee.MiddleName, " +
                               "KindsService.NameKind from KindsService, Employee, PaymentPhysPerson, InteractionPhys where " +
                               "{0} = '{1}' and PaymentPhysPerson.IdPaymentPhys = InteractionPhys.IdPaymentPhys and " +
                               "Employee.IdEmployee = InteractionPhys.IdEmployee and " +
                               "KindsService.IdKind = PaymentPhysPerson.IdService";
            newEmployeeObject.Selection2 = "select Employee.IdEmployee, Employee.Name, Employee.SecondName, Employee.MiddleName, " +
                                 "KindsService.NameKind from KindsService, Employee, PaymentJurPerson, InteractionJur where " +
                                 "{0} = '{1}' and PaymentJurPerson.IdPaymentJur = InteractionJur.IdPaymentJur and " +
                                 "Employee.IdEmployee = InteractionJur.IdEmployee and " +
                                 "KindsService.IdKind = PaymentJurPerson.IdService";
            newEmployeeObject.Selection3 = "select Employee.IdEmployee, Employee.Name, Employee.SecondName, Employee.MiddleName " +
                                           "from Employee where Employee.IdJobTitle = (select IdJobTitle from JobTitle where " +
                                           "{0} = '{1}') and ForPhysPerson = 'True'";
            newEmployeeObject.Selection4 = "select Employee.IdEmployee, Employee.Name, Employee.SecondName, Employee.MiddleName " +
                                           "from Employee where Employee.IdJobTitle = (select IdJobTitle from JobTitle where " +
                                           "{0} = '{1}') and ForJurPerson = 'True'";
            newEmployeeObject.Selection5 = "select * from Employee where {0} = '{1}'";
            newEmployeeObject.SearchBut(TableGrid, ComboCategory, ComTxtData, "IdEmployee",PhyzCheckBox, JurCheckBox);
            parameter = ChoiceEnum.Search.ToString();
        }
        //кнопка поиск
        public void ButtSearch1_Click(object sender, EventArgs e)
        {
            Search_Click();
        }
        //заполнение ComboBox
        private void ComboCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            newEmployeeObject.SelectionInCombo(ComboCategory, ComTxtData, PhyzCheckBox, JurCheckBox);
        }
        //инф. о всех физ. колиентах
        private void AllInfo_Click_1(object sender, EventArgs e)
        {
            newEmployeeObject.Selection1 = "select * from Employee where ForJurPerson = 'True'";
            newEmployeeObject.Selection2 = "select * from Employee where ForPhysPerson = 'True'";
            newEmployeeObject.GridFill(TableGrid,"IdEmployee", JurCheckBox,PhyzCheckBox);
            parameter = ChoiceEnum.Search.ToString();
        }
        //клиенты
        private void ConntatsSel_Click(object sender, EventArgs e)
        {
            parameterByWritheParametr = ChoiceEnum.EmployeeWhisClient.ToString();
            newEmployeeObject.Selection1 = "select Employee.IdEmployee, PhysPersonClient.IdClient, PhysPersonClient.Name, " +
                                           "PhysPersonClient.SecondName from Employee, PhysPersonClient, InteractionPhys " +
                                           "where Employee.IdEmployee = {0} and InteractionPhys.IdEmployee = Employee.IdEmployee " +
                                           "and InteractionPhys.IdClient = PhysPersonClient.IdClient";
            newEmployeeObject.Selection2 = "select Employee.IdEmployee, OrganizationClient.NameOrganization from Employee, " +
                                           "OrganizationClient, InteractionJur where Employee.IdEmployee = {0} " +
                                           "and InteractionJur.IdEmployee = Employee.IdEmployee and " +
                                           "InteractionJur.IdOrganization = OrganizationClient.IdOrganization";

            string selection = null;

            if (parameter == ChoiceEnum.Search.ToString()) 
            {
                newEmployeeObject.SelectBut(TableGrid, TableGrid2, PhyzCheckBox, JurCheckBox);
            }
            else if (parameter == ChoiceEnum.Selary.ToString())
            {
                if (PhyzCheckBox.Checked == true)
                {
                    selection = newEmployeeObject.Selection1;
                    newFunction.SelectWhisParametr(TableGrid2, TableGrid, selection);
                }
                else if (JurCheckBox.Checked == true)
                {
                    selection = newEmployeeObject.Selection2;
                    newFunction.SelectWhisParametr(TableGrid2, TableGrid, selection);
                }    
            }      
        }
        //вид услуги
        private void KindsSel_Click(object sender, EventArgs e)
        {
            parameterByWritheParametr = null;
            newEmployeeObject.Selection1 = "select Employee.Name, Employee.MiddleName, Employee.SecondName, KindsService.NameKind, " +
                                           "PaymentPhysPerson.DateAvailable " +
                                           "from KindsService, Employee, PaymentPhysPerson, InteractionPhys where Employee.IdEmployee = {0} " +
                                           "and PaymentPhysPerson.IdPaymentPhys = InteractionPhys.IdPaymentPhys and " +
                                           "Employee.IdEmployee = InteractionPhys.IdEmployee and " +
                                           "KindsService.IdKind = PaymentPhysPerson.IdService";
            newEmployeeObject.Selection2 = "select Employee.Name, Employee.MiddleName, Employee.SecondName, KindsService.NameKind, " +
                                           "PaymentJurPerson.DateAvailable " +
                                           "from KindsService, Employee, PaymentJurPerson, InteractionJur where Employee.IdEmployee = {0} " +
                                           "and PaymentJurPerson.IdPaymentJur = InteractionJur.IdPaymentJur and " +
                                           "Employee.IdEmployee = InteractionJur.IdEmployee and " +
                                           "KindsService.IdKind = PaymentJurPerson.IdService";
            string selection = null;
            if (parameter == ChoiceEnum.Search.ToString())
            {
                newEmployeeObject.KindsBut(TableGrid, TableGrid2, ComboCategory, PhyzCheckBox, JurCheckBox);
            }
            else if (parameter == ChoiceEnum.Selary.ToString())
            {
                if (PhyzCheckBox.Checked == true)
                {
                    selection = newEmployeeObject.Selection1;
                    newFunction.SelectWhisParametr(TableGrid2, TableGrid, selection);
                }
                else if (JurCheckBox.Checked == true)
                {
                    selection = newEmployeeObject.Selection2;
                    newFunction.SelectWhisParametr(TableGrid2, TableGrid, selection);
                }
            }
        }
        //отдел
        private void Departament_Click(object sender, EventArgs e)
        {
            parameterByWritheParametr = null;
            newEmployeeObject.Selection1 = "select IdEmployee, Name, SecondName,Office.IdOffice, Office.Fax,Office.Telephone " +
                                          "from Employee, Office where Employee.IdEmployee = {0} and Employee.ForPhysPerson = 'True' " +
                                          "and Employee.IdDepartment = Office.IdOffice";
            newEmployeeObject.Selection2 = "select IdEmployee, Name, SecondName,Office.IdOffice, Office.Fax,Office.Telephone " +
                                           "from Employee, Office where Employee.IdEmployee = {0} and Employee.ForPhysPerson = 'False' " +
                                           "and Employee.IdDepartment = Office.IdOffice";
            string selection = null;
            if (parameter == ChoiceEnum.Search.ToString())
            {
                newEmployeeObject.SelectBut(TableGrid, TableGrid2, PhyzCheckBox, JurCheckBox);
            }
            else if (parameter == ChoiceEnum.Selary.ToString())
            {
                if (PhyzCheckBox.Checked == true)
                {
                    selection = newEmployeeObject.Selection1;
                    newFunction.SelectWhisParametr(TableGrid2, TableGrid, selection);
                }
                else if (JurCheckBox.Checked == true)
                {
                    selection = newEmployeeObject.Selection2;
                    newFunction.SelectWhisParametr(TableGrid2, TableGrid, selection);
                }      
            }          
        }
        //директор
        private void CheifSel_Click(object sender, EventArgs e)
        {
            parameterByWritheParametr = null;
            newEmployeeObject.Selection1 = "select IdEmployee, Employee.Name, Employee.SecondName, DirectorOrg.IdDirector, DirectorOrg.Name, " +
                                           "DirectorOrg.MiddleName, DirectorOrg.SecondName, DirectorOrg.Telephone from " +
                                           "Employee, Office, DirectorOrg where Employee.IdEmployee = {0} " +
                                           "and Employee.ForPhysPerson = 'True' and Employee.IdDepartment = Office.IdOffice " +
                                           "and DirectorOrg.IdDirector = Office.IdChief";
            newEmployeeObject.Selection2 = "select IdEmployee, Employee.Name, Employee.SecondName, DirectorOrg.IdDirector, DirectorOrg.Name, " +
                                           "DirectorOrg.MiddleName, DirectorOrg.SecondName, DirectorOrg.Telephone from " +
                                           "Employee, Office, DirectorOrg where Employee.IdEmployee = {0} " +
                                           "and Employee.ForPhysPerson = 'False' and Employee.IdDepartment = Office.IdOffice " +
                                           "and DirectorOrg.IdDirector = Office.IdChief";
            string selection = null;
            if (parameter == ChoiceEnum.Search.ToString())
            {
                newEmployeeObject.SelectBut(TableGrid, TableGrid2, PhyzCheckBox, JurCheckBox);
            }
            else if (parameter == ChoiceEnum.Selary.ToString())
            {
                if (PhyzCheckBox.Checked == true)
                {
                    selection = newEmployeeObject.Selection1;
                    newFunction.SelectWhisParametr(TableGrid2, TableGrid, selection);
                }
                else if (JurCheckBox.Checked == true)
                {
                    selection = newEmployeeObject.Selection2;
                    newFunction.SelectWhisParametr(TableGrid2, TableGrid, selection);
                }
            }  
        }
        //открытые платежи
        private void PaymentOpen_Click(object sender, EventArgs e)
        {
            parameterByWritheParametr = null;
            newEmployeeObject.Selection1 = "select Employee.IdEmployee, Employee.Name, Employee.SecondName, Employee.MiddleName, " +
                                           "PaymentPhysPerson.IdPaymentPhys, DateAvailable from Employee, PaymentPhysPerson, InteractionPhys " +
                                           "where Employee.IdEmployee = {0} and PaymentPhysPerson.Done = 'False' " +
                                           "and InteractionPhys.IdEmployee = Employee.IdEmployee " +
                                           "and PaymentPhysPerson.IdPaymentPhys = InteractionPhys.IdPaymentPhys";
            newEmployeeObject.Selection2 = "select Employee.IdEmployee, Employee.Name, Employee.SecondName, Employee.MiddleName, " +
                                           "PaymentJurPerson.IdPaymentJur, DateAvailable from Employee, PaymentJurPerson, InteractionJur " +
                                           "where Employee.IdEmployee = {0} and PaymentJurPerson.Done = 'False' " +
                                           "and InteractionJur.IdEmployee = Employee.IdEmployee " +
                                           "and PaymentJurPerson.IdPaymentJur = InteractionJur.IdPaymentJur";
            string selection = null;
            if (parameter == ChoiceEnum.Search.ToString())
            {
                newEmployeeObject.SelectBut(TableGrid, TableGrid2, PhyzCheckBox, JurCheckBox);
            }
            else if (parameter == ChoiceEnum.Selary.ToString())
            {
                if (PhyzCheckBox.Checked == true)
                {
                    selection = newEmployeeObject.Selection1;
                    newFunction.SelectWhisParametr(TableGrid2, TableGrid, selection);
                }
                else if (JurCheckBox.Checked == true)
                {
                    selection = newEmployeeObject.Selection2;
                    newFunction.SelectWhisParametr(TableGrid2, TableGrid, selection);
                }
            }  
        }
        //средняя выроботка
        private void WorkExpBut_Click(object sender, EventArgs e)
        {
            parameterByWritheParametr = null;
            newEmployeeObject.OfficeWorkExpEmployee(TableGrid);
        }
        //средний возраст
        private void BirthBut_Click(object sender, EventArgs e)
        {
            parameterByWritheParametr = null;
            newEmployeeObject.OfficeBirthEmployee(TableGrid);
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
                string selection = null;
                if (PhyzCheckBox.Checked == true)
                {
                    selection = "select IdEmployee, Name, SecondName, MiddleName from Employee where WorkExperience < {0} " +
                                "and ForPhysPerson = 'True'";
                }
                else if (JurCheckBox.Checked == true)
                {
                    selection = "select IdEmployee, Name, SecondName, MiddleName from Employee where WorkExperience < {0} " +
                                "and ForPhysPerson = 'False'";
                }
                SelaryPanel.Visible = false;
                newFunction.SelaryLessBetter(TableGrid, parametrSelary, "IdEmployee", selection);
                SelaryPanel.Enabled = false;
                SelaryPanel.Visible = false;
                LessSel.Enabled = true;
                LargerSel.Enabled = true;
                parametrSelary.Enabled = false;
                parameter = ChoiceEnum.Selary.ToString();
            }
            else if (e.KeyData == Keys.Enter && LargerSel.Enabled == true)
            {
                string selection = null;
                if (PhyzCheckBox.Checked == true)
                {
                    selection = "select IdEmployee, Name, SecondName, MiddleName from Employee where WorkExperience > {0} " +
                                "and ForPhysPerson = 'True'";
                }
                else if (JurCheckBox.Checked == true)
                {
                    selection = "select IdEmployee, Name, SecondName, MiddleName from Employee where WorkExperience > {0} " +
                                "and ForPhysPerson = 'False'";
                }
                SelaryPanel.Visible = false;
                newFunction.SelaryLessBetter(TableGrid, parametrSelary, "IdEmployee", selection);
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
                string selection = null;
                if (PhyzCheckBox.Checked == true)
                {
                    selection = "select Employee.IdEmployee, Employee.Name, Employee.SecondName, " +
                                   "Employee.MiddleName, PaymentPhysPerson.IdPaymentPhys, DateAvailable from Employee, " +
                                   "PaymentPhysPerson, InteractionPhys where DateAvailable < '{0}' " +
                                   "and InteractionPhys.IdPaymentPhys = PaymentPhysPerson.IdPaymentPhys and " +
                                   "InteractionPhys.IdEmployee = Employee.IdEmployee"; 
                }
                else if (JurCheckBox.Checked == true)
                {
                    selection = "select Employee.IdEmployee, Employee.Name, Employee.SecondName, " +
                                   "Employee.MiddleName, PaymentJurPerson.IdPaymentJur, DateAvailable from Employee, " +
                                   "PaymentJurPerson, InteractionJur where DateAvailable < '{0}' " +
                                   "and InteractionJur.IdPaymentJur = PaymentJurPerson.IdPaymentJur and " +
                                   "InteractionJur.IdEmployee = Employee.IdEmployee";
                }
                SelaryPanel.Visible = false;
                newFunction.DataLessBetter(TableGrid, parametrYear, parametrMonth, parametrDay, "IdEmployee", selection);
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
                string selection = null;
                if (PhyzCheckBox.Checked == true)
                {
                    selection = "select Employee.IdEmployee, Employee.Name, Employee.SecondName, " +
                                   "Employee.MiddleName, PaymentPhysPerson.IdPaymentPhys, DateAvailable from Employee, " +
                                   "PaymentPhysPerson, InteractionPhys where DateAvailable > '{0}' " +
                                   "and InteractionPhys.IdPaymentPhys = PaymentPhysPerson.IdPaymentPhys and " +
                                   "InteractionPhys.IdEmployee = Employee.IdEmployee"; 
                }
                else if (JurCheckBox.Checked == true)
                {
                    selection = "select Employee.IdEmployee, Employee.Name, Employee.SecondName, " +
                                   "Employee.MiddleName, PaymentJurPerson.IdPaymentJur, DateAvailable from Employee, " +
                                   "PaymentJurPerson, InteractionJur where DateAvailable > '{0}' " +
                                   "and InteractionJur.IdPaymentJur = PaymentJurPerson.IdPaymentJur and " +
                                   "InteractionJur.IdEmployee = Employee.IdEmployee";
                }
                SelaryPanel.Visible = false;
                newFunction.DataLessBetter(TableGrid, parametrYear, parametrMonth, parametrDay, "IdEmployee", selection);
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

        //check box
        private void JurCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (JurCheckBox.Checked)
            {
                PhyzCheckBox.Enabled = false;
                ComboCategory.Enabled = true;
                ComTxtData.Enabled = true;
                ButtSearch1.Enabled = true;
            }
            else
            {
                PhyzCheckBox.Enabled = true;
                ComboCategory.Enabled = false;
                ComTxtData.Enabled = false;
                ButtSearch1.Enabled = false;
            }
        }
        private void PhyzCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (PhyzCheckBox.Checked)
            {
                JurCheckBox.Enabled = false;
                ComboCategory.Enabled = true;
                ComTxtData.Enabled = true;
                ButtSearch1.Enabled = true;
            }
            else
            {
                JurCheckBox.Enabled = true;
                ComboCategory.Enabled = false;
                ComTxtData.Enabled = false;
                ButtSearch1.Enabled = false;
            }
        }
        //инф. по ячейке
        private void TableGrid2_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (parameterByWritheParametr == ChoiceEnum.EmployeeWhisClient.ToString())
                newEmployeeObject.InformationOnTheCell(TableGrid2,JurCheckBox, PhyzCheckBox);
        }
        //закрытие формы
        private void Employee_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult resultDialog = MessageBox.Show("Вы уверены, что хотите закрыть окно?",
                "Закрытие", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (resultDialog == DialogResult.No)
            {
                e.Cancel = true;
            }
        }
        //сохранение в exel
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
