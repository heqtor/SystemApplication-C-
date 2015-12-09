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
    public partial class Form2 : Form
    {
        InfoAboutClientsPhyz newPhuz = new InfoAboutClientsPhyz();  
        FunctionWhisParameters newFunction = new FunctionWhisParameters();
        
        private string parameter;      
        public string Parameter
        {
            get { return parameter; }
            set { parameter = value; }
        }

        public Form2()
        {
            InitializeComponent();
  
            ComboCategory.Items.Add("Имя");
            ComboCategory.Items.Add("Фамилия");
            ComboCategory.Items.Add("Отчество");
            ComboCategory.Items.Add("Место работы");
            ComboCategory.Items.Add("Должность");
            ComboCategory.Items.Add("Уникальный индекс");
            ComboCategory.Items.Add("Вид услуги");

            parametrSelary.Enabled = false;
            parametrYear.Enabled = false;

            SelaryPanel.Location = new Point(240, 119);
            DateAvailablePanel.Location = new Point(240, 119);
            
        }
        
        //кнопка поиск
        private void ButtSearch1_Click(object sender, EventArgs e)
        {
            newPhuz.SearchBut(TableGrid, ComboCategory, ComTxtData);
            parameter = ChoiceEnum.Search.ToString();
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

        //заполнение ComboBox
        private void ComboCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            newPhuz.SelectionInCombo(ComboCategory, ComTxtData);
        }
        //инф. о всех физ. колиентах
        private void AllInfo_Click_1(object sender, EventArgs e)
        {
            newPhuz.GridFill(TableGrid);
        }
        //контакты
        private void ConntatsSel_Click(object sender, EventArgs e)
        {
            if (parameter == ChoiceEnum.Search.ToString()) 
            {
                newPhuz.Conntact(TableGrid2, TableGrid);
            }
            else if (parameter == ChoiceEnum.Selary.ToString())
            {
                newFunction.Conntact(TableGrid2, TableGrid);
            }      
        }
        //вид услуги
        private void KindsSel_Click(object sender, EventArgs e)
        {
            if (parameter == ChoiceEnum.Search.ToString())
            {
                newPhuz.SelectKindService(TableGrid, TableGrid2, ComboCategory);
            }
            else if (parameter == ChoiceEnum.Selary.ToString())
            {
                newFunction.SelectKindService(TableGrid, TableGrid2, ComboCategory);
            }
        }
        //сотрудник обслуживающий клиента 
        private void EmployeeSel_Click(object sender, EventArgs e)
        {
            if (parameter == ChoiceEnum.Search.ToString())
            {
                newPhuz.SelectEmployee(TableGrid2, TableGrid);  
            }
            else if (parameter == ChoiceEnum.Selary.ToString())
            {
                newFunction.SelectEmployee(TableGrid2, TableGrid);  
            }              
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
                SelaryPanel.Visible = false;
                newFunction.SalaryLess(TableGrid, parametrSelary);
                SelaryPanel.Enabled = false;
                SelaryPanel.Visible = false;
                LessSel.Enabled = true;
                LargerSel.Enabled = true;
                parametrSelary.Enabled = false;
                parameter = ChoiceEnum.Selary.ToString();
            }
            else if (e.KeyData == Keys.Enter && LargerSel.Enabled == true)
            {
                SelaryPanel.Visible = false;
                newFunction.SalaryLarger(TableGrid, parametrSelary);
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
                SelaryPanel.Visible = false;
                newFunction.DataAvilLess(TableGrid, parametrYear, parametrMonth, parametrDay);
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
                SelaryPanel.Visible = false;
                newFunction.DataAvilLarger(TableGrid, parametrYear, parametrMonth, parametrDay);
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

       

        
        

        
        
        

        

        

       

       

        

        

        

    }

}
