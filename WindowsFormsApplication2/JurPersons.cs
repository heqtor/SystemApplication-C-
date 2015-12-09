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
        OperationWithButPhysClient neWithButPhysClient = new OperationWithButPhysClient();

        public JurPersons()
        {
            InitializeComponent();
  
            ComboCategory.Items.Add("Имя");
            ComboCategory.Items.Add("Фамилия");
            ComboCategory.Items.Add("Отчество");
            ComboCategory.Items.Add("Место работы");
            ComboCategory.Items.Add("Должность");
            ComboCategory.Items.Add("Уникальный индекс");
            ComboCategory.Items.Add("Вид услуги");
        }
        
        //поиск 1
        private void ButtSearch1_Click(object sender, EventArgs e)
        {
            newPhuz.SearchBut(TableGrid, ComboCategory, ComTxtData);
        }

        //вся информ. 

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

        private void ComboCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            newPhuz.SelectionInCombo(ComboCategory, ComTxtData);
        }

        private void AllInfo_Click_1(object sender, EventArgs e)
        {
            newPhuz.GridFill(TableGrid);
        }

        private void ConntatsSel_Click(object sender, EventArgs e)
        {
            newPhuz.Conntact(TableGrid2);
        }

        private void KindsSel_Click(object sender, EventArgs e)
        {
            newPhuz.SelectKindService(TableGrid2, ComboCategory);
        }

        private void EmployeeSel_Click(object sender, EventArgs e)
        {
            newPhuz.SelectEmployee(TableGrid2);
        }

    }
}
