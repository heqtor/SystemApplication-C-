using System.Windows.Forms;

namespace WindowsFormsApplication2
{
    partial class Employee
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Employee));
            this.TableGrid = new System.Windows.Forms.DataGridView();
            this.Menu1 = new System.Windows.Forms.ToolStrip();
            this.AllInfo = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.ComboCategory = new System.Windows.Forms.ToolStripComboBox();
            this.ComTxtData = new System.Windows.Forms.ToolStripComboBox();
            this.ButtSearch1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.Menu2 = new System.Windows.Forms.ToolStrip();
            this.ConntatsSel = new System.Windows.Forms.ToolStripButton();
            this.KindsSel = new System.Windows.Forms.ToolStripButton();
            this.Departament = new System.Windows.Forms.ToolStripButton();
            this.CheifSel = new System.Windows.Forms.ToolStripButton();
            this.PaymentOpen = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.SalaryBut = new System.Windows.Forms.ToolStripButton();
            this.DateAvailableBut = new System.Windows.Forms.ToolStripButton();
            this.WorkExpBut = new System.Windows.Forms.ToolStripButton();
            this.BirthBut = new System.Windows.Forms.ToolStripButton();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.SaveData = new System.Windows.Forms.ToolStripMenuItem();
            this.SaveTable1 = new System.Windows.Forms.ToolStripMenuItem();
            this.SaveTable2 = new System.Windows.Forms.ToolStripMenuItem();
            this.TableGrid2 = new System.Windows.Forms.DataGridView();
            this.SelaryPanel = new System.Windows.Forms.Panel();
            this.exitPanelSelary = new System.Windows.Forms.Button();
            this.BackSel = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.parametrSelary = new System.Windows.Forms.TextBox();
            this.LargerSel = new System.Windows.Forms.Button();
            this.LessSel = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.DateAvailablePanel = new System.Windows.Forms.Panel();
            this.exitPanelDate = new System.Windows.Forms.Button();
            this.parametrDay = new System.Windows.Forms.TextBox();
            this.parametrMonth = new System.Windows.Forms.TextBox();
            this.BackDate = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.parametrYear = new System.Windows.Forms.TextBox();
            this.LargerDate = new System.Windows.Forms.Button();
            this.LessDate = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.PhyzCheckBox = new System.Windows.Forms.CheckBox();
            this.JurCheckBox = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.TableGrid)).BeginInit();
            this.Menu1.SuspendLayout();
            this.Menu2.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TableGrid2)).BeginInit();
            this.SelaryPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BackSel)).BeginInit();
            this.DateAvailablePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BackDate)).BeginInit();
            this.SuspendLayout();
            // 
            // TableGrid
            // 
            this.TableGrid.AllowUserToAddRows = false;
            this.TableGrid.AllowUserToDeleteRows = false;
            this.TableGrid.BackgroundColor = System.Drawing.SystemColors.Control;
            this.TableGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TableGrid.Location = new System.Drawing.Point(0, 75);
            this.TableGrid.Name = "TableGrid";
            this.TableGrid.ReadOnly = true;
            this.TableGrid.Size = new System.Drawing.Size(841, 202);
            this.TableGrid.TabIndex = 0;
            // 
            // Menu1
            // 
            this.Menu1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.Menu1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.Menu1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AllInfo,
            this.toolStripSeparator1,
            this.ComboCategory,
            this.ComTxtData,
            this.ButtSearch1,
            this.toolStripSeparator2});
            this.Menu1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Flow;
            this.Menu1.Location = new System.Drawing.Point(0, 24);
            this.Menu1.Name = "Menu1";
            this.Menu1.Size = new System.Drawing.Size(839, 23);
            this.Menu1.TabIndex = 6;
            this.Menu1.Text = "toolStrip1";
            // 
            // AllInfo
            // 
            this.AllInfo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.AllInfo.Image = ((System.Drawing.Image)(resources.GetObject("AllInfo.Image")));
            this.AllInfo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.AllInfo.Name = "AllInfo";
            this.AllInfo.Size = new System.Drawing.Size(105, 19);
            this.AllInfo.Text = "Вся информация";
            this.AllInfo.Click += new System.EventHandler(this.AllInfo_Click_1);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 23);
            // 
            // ComboCategory
            // 
            this.ComboCategory.Name = "ComboCategory";
            this.ComboCategory.Size = new System.Drawing.Size(140, 23);
            this.ComboCategory.Text = "Критерий поска";
            this.ComboCategory.ToolTipText = "Критерий, по которому в дальнейшем\r\nосуществляется поиск";
            this.ComboCategory.SelectedIndexChanged += new System.EventHandler(this.ComboCategory_SelectedIndexChanged);
            this.ComboCategory.Click += new System.EventHandler(this.ComboCategory_Click);
            // 
            // ComTxtData
            // 
            this.ComTxtData.Name = "ComTxtData";
            this.ComTxtData.Size = new System.Drawing.Size(250, 23);
            this.ComTxtData.Text = "Ввод и выбор данных";
            this.ComTxtData.Click += new System.EventHandler(this.ComTxtData_Click);
            // 
            // ButtSearch1
            // 
            this.ButtSearch1.BackColor = System.Drawing.SystemColors.Control;
            this.ButtSearch1.Image = global::WindowsFormsApplication2.Properties.Resources.analysis;
            this.ButtSearch1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ButtSearch1.Name = "ButtSearch1";
            this.ButtSearch1.Size = new System.Drawing.Size(62, 20);
            this.ButtSearch1.Text = "Поиск";
            this.ButtSearch1.Click += new System.EventHandler(this.ButtSearch1_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 23);
            // 
            // Menu2
            // 
            this.Menu2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.Menu2.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.Menu2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ConntatsSel,
            this.KindsSel,
            this.Departament,
            this.CheifSel,
            this.PaymentOpen,
            this.toolStripSeparator3,
            this.SalaryBut,
            this.DateAvailableBut,
            this.WorkExpBut,
            this.BirthBut});
            this.Menu2.Location = new System.Drawing.Point(0, 47);
            this.Menu2.Name = "Menu2";
            this.Menu2.Size = new System.Drawing.Size(839, 25);
            this.Menu2.TabIndex = 7;
            this.Menu2.Text = "toolStrip1";
            // 
            // ConntatsSel
            // 
            this.ConntatsSel.Image = global::WindowsFormsApplication2.Properties.Resources.themes;
            this.ConntatsSel.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ConntatsSel.Name = "ConntatsSel";
            this.ConntatsSel.Size = new System.Drawing.Size(75, 22);
            this.ConntatsSel.Text = "Клиенты";
            this.ConntatsSel.Click += new System.EventHandler(this.ConntatsSel_Click);
            // 
            // KindsSel
            // 
            this.KindsSel.Image = global::WindowsFormsApplication2.Properties.Resources.content;
            this.KindsSel.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.KindsSel.Name = "KindsSel";
            this.KindsSel.Size = new System.Drawing.Size(87, 22);
            this.KindsSel.Text = "Вид услуги";
            this.KindsSel.Click += new System.EventHandler(this.KindsSel_Click);
            // 
            // Departament
            // 
            this.Departament.Image = global::WindowsFormsApplication2.Properties.Resources.organization;
            this.Departament.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Departament.Name = "Departament";
            this.Departament.Size = new System.Drawing.Size(60, 22);
            this.Departament.Text = "Отдел";
            this.Departament.Click += new System.EventHandler(this.Departament_Click);
            // 
            // CheifSel
            // 
            this.CheifSel.Image = global::WindowsFormsApplication2.Properties.Resources.Client;
            this.CheifSel.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.CheifSel.Name = "CheifSel";
            this.CheifSel.Size = new System.Drawing.Size(87, 22);
            this.CheifSel.Text = "Дирректор";
            this.CheifSel.Click += new System.EventHandler(this.CheifSel_Click);
            // 
            // PaymentOpen
            // 
            this.PaymentOpen.Image = global::WindowsFormsApplication2.Properties.Resources.semi_success;
            this.PaymentOpen.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.PaymentOpen.Name = "PaymentOpen";
            this.PaymentOpen.Size = new System.Drawing.Size(133, 22);
            this.PaymentOpen.Text = "Открытые платежи";
            this.PaymentOpen.Click += new System.EventHandler(this.PaymentOpen_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
            // 
            // SalaryBut
            // 
            this.SalaryBut.Image = global::WindowsFormsApplication2.Properties.Resources.theory;
            this.SalaryBut.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.SalaryBut.Name = "SalaryBut";
            this.SalaryBut.Size = new System.Drawing.Size(99, 22);
            this.SalaryBut.Text = "Стаж работы";
            this.SalaryBut.Click += new System.EventHandler(this.SalaryBut_Click);
            // 
            // DateAvailableBut
            // 
            this.DateAvailableBut.Image = global::WindowsFormsApplication2.Properties.Resources.schedule;
            this.DateAvailableBut.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.DateAvailableBut.Name = "DateAvailableBut";
            this.DateAvailableBut.Size = new System.Drawing.Size(95, 22);
            this.DateAvailableBut.Text = "Дата плтежа";
            this.DateAvailableBut.Click += new System.EventHandler(this.DateAvailableBut_Click);
            // 
            // WorkExpBut
            // 
            this.WorkExpBut.Image = global::WindowsFormsApplication2.Properties.Resources.attachment;
            this.WorkExpBut.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.WorkExpBut.Name = "WorkExpBut";
            this.WorkExpBut.Size = new System.Drawing.Size(88, 22);
            this.WorkExpBut.Text = "Выроботка";
            this.WorkExpBut.Click += new System.EventHandler(this.WorkExpBut_Click);
            // 
            // BirthBut
            // 
            this.BirthBut.Image = global::WindowsFormsApplication2.Properties.Resources.attachment;
            this.BirthBut.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BirthBut.Name = "BirthBut";
            this.BirthBut.Size = new System.Drawing.Size(70, 22);
            this.BirthBut.Text = "Возраст";
            this.BirthBut.Click += new System.EventHandler(this.BirthBut_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.menuStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SaveData});
            this.menuStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(839, 24);
            this.menuStrip1.TabIndex = 8;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // SaveData
            // 
            this.SaveData.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SaveTable1,
            this.SaveTable2});
            this.SaveData.Image = global::WindowsFormsApplication2.Properties.Resources.tests;
            this.SaveData.Name = "SaveData";
            this.SaveData.Size = new System.Drawing.Size(101, 20);
            this.SaveData.Text = "Сохранение";
            // 
            // SaveTable1
            // 
            this.SaveTable1.Name = "SaveTable1";
            this.SaveTable1.Size = new System.Drawing.Size(202, 22);
            this.SaveTable1.Text = "Сохранение Таблицы 1";
            this.SaveTable1.Click += new System.EventHandler(this.SaveTable1_Click);
            // 
            // SaveTable2
            // 
            this.SaveTable2.Name = "SaveTable2";
            this.SaveTable2.Size = new System.Drawing.Size(202, 22);
            this.SaveTable2.Text = "Сохранение Таблицы 2";
            this.SaveTable2.Click += new System.EventHandler(this.SaveTable2_Click);
            // 
            // TableGrid2
            // 
            this.TableGrid2.AllowUserToAddRows = false;
            this.TableGrid2.AllowUserToDeleteRows = false;
            this.TableGrid2.BackgroundColor = System.Drawing.SystemColors.Control;
            this.TableGrid2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TableGrid2.Location = new System.Drawing.Point(0, 283);
            this.TableGrid2.Name = "TableGrid2";
            this.TableGrid2.ReadOnly = true;
            this.TableGrid2.Size = new System.Drawing.Size(841, 154);
            this.TableGrid2.TabIndex = 9;
            this.TableGrid2.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.TableGrid2_MouseDoubleClick);
            // 
            // SelaryPanel
            // 
            this.SelaryPanel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.SelaryPanel.Controls.Add(this.exitPanelSelary);
            this.SelaryPanel.Controls.Add(this.BackSel);
            this.SelaryPanel.Controls.Add(this.label2);
            this.SelaryPanel.Controls.Add(this.parametrSelary);
            this.SelaryPanel.Controls.Add(this.LargerSel);
            this.SelaryPanel.Controls.Add(this.LessSel);
            this.SelaryPanel.Controls.Add(this.label1);
            this.SelaryPanel.Location = new System.Drawing.Point(240, 119);
            this.SelaryPanel.Name = "SelaryPanel";
            this.SelaryPanel.Size = new System.Drawing.Size(349, 117);
            this.SelaryPanel.TabIndex = 10;
            this.SelaryPanel.Visible = false;
            // 
            // exitPanelSelary
            // 
            this.exitPanelSelary.BackColor = System.Drawing.Color.MintCream;
            this.exitPanelSelary.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exitPanelSelary.Location = new System.Drawing.Point(39, 91);
            this.exitPanelSelary.Name = "exitPanelSelary";
            this.exitPanelSelary.Size = new System.Drawing.Size(62, 23);
            this.exitPanelSelary.TabIndex = 7;
            this.exitPanelSelary.Text = "Закрыть";
            this.exitPanelSelary.UseVisualStyleBackColor = false;
            this.exitPanelSelary.Click += new System.EventHandler(this.exitPanelSelary_Click);
            // 
            // BackSel
            // 
            this.BackSel.Image = global::WindowsFormsApplication2.Properties.Resources.go_back;
            this.BackSel.InitialImage = global::WindowsFormsApplication2.Properties.Resources.go_back;
            this.BackSel.Location = new System.Drawing.Point(4, 91);
            this.BackSel.Name = "BackSel";
            this.BackSel.Size = new System.Drawing.Size(29, 23);
            this.BackSel.TabIndex = 5;
            this.BackSel.TabStop = false;
            this.BackSel.Click += new System.EventHandler(this.BackSel_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(74, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 22);
            this.label2.TabIndex = 4;
            this.label2.Text = "Параметр:";
            // 
            // parametrSelary
            // 
            this.parametrSelary.Location = new System.Drawing.Point(179, 53);
            this.parametrSelary.Name = "parametrSelary";
            this.parametrSelary.Size = new System.Drawing.Size(127, 20);
            this.parametrSelary.TabIndex = 0;
            this.parametrSelary.Text = "Число";
            this.parametrSelary.Enter += new System.EventHandler(this.parametrSelary_Enter);
            this.parametrSelary.KeyDown += new System.Windows.Forms.KeyEventHandler(this.parametrSelary_KeyDown);
            // 
            // LargerSel
            // 
            this.LargerSel.Location = new System.Drawing.Point(260, 13);
            this.LargerSel.Name = "LargerSel";
            this.LargerSel.Size = new System.Drawing.Size(75, 23);
            this.LargerSel.TabIndex = 2;
            this.LargerSel.Text = "Больше";
            this.LargerSel.UseVisualStyleBackColor = true;
            this.LargerSel.Click += new System.EventHandler(this.LargerSel_Click);
            // 
            // LessSel
            // 
            this.LessSel.Location = new System.Drawing.Point(179, 13);
            this.LessSel.Name = "LessSel";
            this.LessSel.Size = new System.Drawing.Size(75, 23);
            this.LessSel.TabIndex = 1;
            this.LessSel.Text = "Меньше";
            this.LessSel.UseVisualStyleBackColor = true;
            this.LessSel.Click += new System.EventHandler(this.LessSel_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(42, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Срок службы:";
            // 
            // DateAvailablePanel
            // 
            this.DateAvailablePanel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.DateAvailablePanel.Controls.Add(this.exitPanelDate);
            this.DateAvailablePanel.Controls.Add(this.parametrDay);
            this.DateAvailablePanel.Controls.Add(this.parametrMonth);
            this.DateAvailablePanel.Controls.Add(this.BackDate);
            this.DateAvailablePanel.Controls.Add(this.label3);
            this.DateAvailablePanel.Controls.Add(this.parametrYear);
            this.DateAvailablePanel.Controls.Add(this.LargerDate);
            this.DateAvailablePanel.Controls.Add(this.LessDate);
            this.DateAvailablePanel.Controls.Add(this.label4);
            this.DateAvailablePanel.Location = new System.Drawing.Point(240, 283);
            this.DateAvailablePanel.Name = "DateAvailablePanel";
            this.DateAvailablePanel.Size = new System.Drawing.Size(349, 117);
            this.DateAvailablePanel.TabIndex = 11;
            this.DateAvailablePanel.Visible = false;
            // 
            // exitPanelDate
            // 
            this.exitPanelDate.BackColor = System.Drawing.Color.MintCream;
            this.exitPanelDate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exitPanelDate.Location = new System.Drawing.Point(39, 91);
            this.exitPanelDate.Name = "exitPanelDate";
            this.exitPanelDate.Size = new System.Drawing.Size(62, 23);
            this.exitPanelDate.TabIndex = 9;
            this.exitPanelDate.Text = "Закрыть";
            this.exitPanelDate.UseVisualStyleBackColor = false;
            this.exitPanelDate.Click += new System.EventHandler(this.exitPanelDate_Click);
            // 
            // parametrDay
            // 
            this.parametrDay.Enabled = false;
            this.parametrDay.Location = new System.Drawing.Point(272, 55);
            this.parametrDay.Name = "parametrDay";
            this.parametrDay.Size = new System.Drawing.Size(63, 20);
            this.parametrDay.TabIndex = 8;
            this.parametrDay.Text = "День";
            this.parametrDay.Enter += new System.EventHandler(this.parametrDay_Enter);
            this.parametrDay.KeyDown += new System.Windows.Forms.KeyEventHandler(this.parametrDay_KeyDown);
            // 
            // parametrMonth
            // 
            this.parametrMonth.Enabled = false;
            this.parametrMonth.Location = new System.Drawing.Point(216, 55);
            this.parametrMonth.Name = "parametrMonth";
            this.parametrMonth.Size = new System.Drawing.Size(63, 20);
            this.parametrMonth.TabIndex = 7;
            this.parametrMonth.Text = "Месяц";
            this.parametrMonth.Enter += new System.EventHandler(this.parametrMonth_Enter);
            this.parametrMonth.KeyDown += new System.Windows.Forms.KeyEventHandler(this.parametrMonth_KeyDown);
            // 
            // BackDate
            // 
            this.BackDate.Image = global::WindowsFormsApplication2.Properties.Resources.go_back;
            this.BackDate.InitialImage = global::WindowsFormsApplication2.Properties.Resources.go_back;
            this.BackDate.Location = new System.Drawing.Point(4, 91);
            this.BackDate.Name = "BackDate";
            this.BackDate.Size = new System.Drawing.Size(29, 23);
            this.BackDate.TabIndex = 6;
            this.BackDate.TabStop = false;
            this.BackDate.Click += new System.EventHandler(this.BackDate_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(53, 53);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 22);
            this.label3.TabIndex = 4;
            this.label3.Text = "Параметр:";
            // 
            // parametrYear
            // 
            this.parametrYear.Enabled = false;
            this.parametrYear.Location = new System.Drawing.Point(158, 55);
            this.parametrYear.Name = "parametrYear";
            this.parametrYear.Size = new System.Drawing.Size(63, 20);
            this.parametrYear.TabIndex = 3;
            this.parametrYear.Text = "Год";
            this.parametrYear.Enter += new System.EventHandler(this.parametrYear_Enter);
            this.parametrYear.KeyDown += new System.Windows.Forms.KeyEventHandler(this.parametrYear_KeyDown);
            // 
            // LargerDate
            // 
            this.LargerDate.Location = new System.Drawing.Point(260, 16);
            this.LargerDate.Name = "LargerDate";
            this.LargerDate.Size = new System.Drawing.Size(75, 23);
            this.LargerDate.TabIndex = 2;
            this.LargerDate.Text = "Больше";
            this.LargerDate.UseVisualStyleBackColor = true;
            this.LargerDate.Click += new System.EventHandler(this.LargerDate_Click);
            // 
            // LessDate
            // 
            this.LessDate.Location = new System.Drawing.Point(179, 16);
            this.LessDate.Name = "LessDate";
            this.LessDate.Size = new System.Drawing.Size(75, 23);
            this.LessDate.TabIndex = 1;
            this.LessDate.Text = "Меньше";
            this.LessDate.UseVisualStyleBackColor = true;
            this.LessDate.Click += new System.EventHandler(this.LessDate_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(38, 13);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(135, 24);
            this.label4.TabIndex = 0;
            this.label4.Text = "Дата платежа";
            // 
            // PhyzCheckBox
            // 
            this.PhyzCheckBox.AutoSize = true;
            this.PhyzCheckBox.BackColor = System.Drawing.SystemColors.ControlLight;
            this.PhyzCheckBox.Location = new System.Drawing.Point(652, 27);
            this.PhyzCheckBox.Name = "PhyzCheckBox";
            this.PhyzCheckBox.Size = new System.Drawing.Size(81, 17);
            this.PhyzCheckBox.TabIndex = 12;
            this.PhyzCheckBox.Text = "Физ. Лица";
            this.PhyzCheckBox.UseVisualStyleBackColor = false;
            this.PhyzCheckBox.CheckedChanged += new System.EventHandler(this.PhyzCheckBox_CheckedChanged);
            // 
            // JurCheckBox
            // 
            this.JurCheckBox.AutoSize = true;
            this.JurCheckBox.BackColor = System.Drawing.SystemColors.ControlLight;
            this.JurCheckBox.Location = new System.Drawing.Point(574, 27);
            this.JurCheckBox.Name = "JurCheckBox";
            this.JurCheckBox.Size = new System.Drawing.Size(73, 17);
            this.JurCheckBox.TabIndex = 13;
            this.JurCheckBox.Text = "Юр. Лица";
            this.JurCheckBox.UseVisualStyleBackColor = false;
            this.JurCheckBox.CheckedChanged += new System.EventHandler(this.JurCheckBox_CheckedChanged);
            // 
            // Employee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WindowsFormsApplication2.Properties.Resources.bright_light_textures1;
            this.ClientSize = new System.Drawing.Size(839, 437);
            this.Controls.Add(this.JurCheckBox);
            this.Controls.Add(this.PhyzCheckBox);
            this.Controls.Add(this.DateAvailablePanel);
            this.Controls.Add(this.SelaryPanel);
            this.Controls.Add(this.TableGrid2);
            this.Controls.Add(this.Menu2);
            this.Controls.Add(this.Menu1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.TableGrid);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Employee";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Employee";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Employee_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.TableGrid)).EndInit();
            this.Menu1.ResumeLayout(false);
            this.Menu1.PerformLayout();
            this.Menu2.ResumeLayout(false);
            this.Menu2.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TableGrid2)).EndInit();
            this.SelaryPanel.ResumeLayout(false);
            this.SelaryPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BackSel)).EndInit();
            this.DateAvailablePanel.ResumeLayout(false);
            this.DateAvailablePanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BackDate)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip Menu1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStrip Menu2;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private DataGridView TableGrid2;
        private ToolStripButton AllInfo;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripButton CheifSel;
        private ToolStripButton ConntatsSel;
        private ToolStripButton KindsSel;
        private Panel SelaryPanel;
        private Label label2;
        private TextBox parametrSelary;
        private Button LargerSel;
        private Button LessSel;
        private Label label1;
        private Panel DateAvailablePanel;
        private Label label3;
        private TextBox parametrYear;
        private Button LargerDate;
        private Button LessDate;
        private Label label4;
        private ToolStripButton SalaryBut;
        private PictureBox BackSel;
        private ToolStripButton DateAvailableBut;
        private PictureBox BackDate;
        private TextBox parametrDay;
        private TextBox parametrMonth;
        private ToolStripSeparator toolStripSeparator3;
        private Button exitPanelSelary;
        private Button exitPanelDate;
        private ToolStripButton Departament;
        private ToolStripButton PaymentOpen;
        public ToolStripComboBox ComboCategory;
        public CheckBox JurCheckBox;
        public ToolStripButton ButtSearch1;
        public ToolStripComboBox ComTxtData;
        public CheckBox PhyzCheckBox;
        public DataGridView TableGrid;
        private ToolStripButton WorkExpBut;
        private ToolStripButton BirthBut;
        private ToolStripMenuItem SaveData;
        private ToolStripMenuItem SaveTable1;
        private ToolStripMenuItem SaveTable2;
    }
}