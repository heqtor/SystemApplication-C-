using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using ThreadState = System.Diagnostics.ThreadState;

namespace WindowsFormsApplication2
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            PanelInfoClientsBut.Location = InfoAboutClientsBut.Location;
        }

        //кнопка информации о клиентах
        private void InfoAboutClientsBut_Click(object sender, EventArgs e)
        {
            InfoAboutClientsBut.Visible = false;
            InfoAboutEmployeeBut.Visible = false;
            
            PanelInfoClientsBut.Visible = true;
        }
        //кнопка возврата
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            InfoAboutClientsBut.Visible = true;
            InfoAboutEmployeeBut.Visible = true;
            PanelInfoClientsBut.Visible = false;
        }
        //вызов окна информации юридических лиц
        private void Jur_Click(object sender, EventArgs e)
        {
            JurClients jerClients = new JurClients();
            jerClients.ShowDialog();   
        }
        //вызов окна информации физических лиц
        private void JurBut_Click(object sender, EventArgs e)
        {
            PhysClients jerClients = new PhysClients();
            jerClients.ShowDialog(); 
        }
        //кнопка информации о сотрудниках
        private void InfoAboutEmployeeBut_Click(object sender, EventArgs e)
        {
            Employee employee = new Employee();
            employee.ShowDialog();
        }
        //выход
        private void exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
