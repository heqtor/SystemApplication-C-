using System.Windows.Forms;

namespace WindowsFormsApplication2
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.TableGrid = new System.Windows.Forms.DataGridView();
            this.Menu1 = new System.Windows.Forms.ToolStrip();
            this.AllInfo = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.ComboCategory = new System.Windows.Forms.ToolStripComboBox();
            this.ComTxtData = new System.Windows.Forms.ToolStripComboBox();
            this.ButtSearch1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.Menu2 = new System.Windows.Forms.ToolStrip();
            this.EmployeeSel = new System.Windows.Forms.ToolStripButton();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.TableGrid2 = new System.Windows.Forms.DataGridView();
            this.ConntatsSel = new System.Windows.Forms.ToolStripButton();
            this.KindsSel = new System.Windows.Forms.ToolStripButton();
            ((System.ComponentModel.ISupportInitialize)(this.TableGrid)).BeginInit();
            this.Menu1.SuspendLayout();
            this.Menu2.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TableGrid2)).BeginInit();
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
            this.TableGrid.Size = new System.Drawing.Size(675, 188);
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
            this.Menu1.Size = new System.Drawing.Size(675, 23);
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
            this.ComTxtData.Size = new System.Drawing.Size(180, 23);
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
            this.EmployeeSel});
            this.Menu2.Location = new System.Drawing.Point(0, 47);
            this.Menu2.Name = "Menu2";
            this.Menu2.Size = new System.Drawing.Size(675, 25);
            this.Menu2.TabIndex = 7;
            this.Menu2.Text = "toolStrip1";
            // 
            // EmployeeSel
            // 
            this.EmployeeSel.Image = global::WindowsFormsApplication2.Properties.Resources.Client;
            this.EmployeeSel.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.EmployeeSel.Name = "EmployeeSel";
            this.EmployeeSel.Size = new System.Drawing.Size(141, 22);
            this.EmployeeSel.Text = "Кто обслужива(л/ет)";
            this.EmployeeSel.Click += new System.EventHandler(this.EmployeeSel_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.menuStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1});
            this.menuStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(675, 24);
            this.menuStrip1.TabIndex = 8;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Image = global::WindowsFormsApplication2.Properties.Resources.tests;
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(74, 20);
            this.toolStripMenuItem1.Text = "Печать";
            // 
            // TableGrid2
            // 
            this.TableGrid2.AllowUserToAddRows = false;
            this.TableGrid2.AllowUserToDeleteRows = false;
            this.TableGrid2.BackgroundColor = System.Drawing.SystemColors.Control;
            this.TableGrid2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TableGrid2.Location = new System.Drawing.Point(0, 269);
            this.TableGrid2.Name = "TableGrid2";
            this.TableGrid2.ReadOnly = true;
            this.TableGrid2.Size = new System.Drawing.Size(675, 139);
            this.TableGrid2.TabIndex = 9;
            // 
            // ConntatsSel
            // 
            this.ConntatsSel.Image = global::WindowsFormsApplication2.Properties.Resources.themes;
            this.ConntatsSel.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ConntatsSel.Name = "ConntatsSel";
            this.ConntatsSel.Size = new System.Drawing.Size(72, 22);
            this.ConntatsSel.Text = "Котакты";
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
            // PhysClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WindowsFormsApplication2.Properties.Resources.bright_light_textures1;
            this.ClientSize = new System.Drawing.Size(675, 410);
            this.Controls.Add(this.TableGrid2);
            this.Controls.Add(this.Menu2);
            this.Controls.Add(this.Menu1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.TableGrid);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "PhysClient";
            this.Text = "PhysClient";
            ((System.ComponentModel.ISupportInitialize)(this.TableGrid)).EndInit();
            this.Menu1.ResumeLayout(false);
            this.Menu1.PerformLayout();
            this.Menu2.ResumeLayout(false);
            this.Menu2.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TableGrid2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView TableGrid;
        private System.Windows.Forms.ToolStrip Menu1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripComboBox ComboCategory;
        private System.Windows.Forms.ToolStripButton ButtSearch1;
        private System.Windows.Forms.ToolStrip Menu2;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private ToolStripComboBox ComTxtData;
        private DataGridView TableGrid2;
        private ToolStripButton AllInfo;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripButton EmployeeSel;
        private ToolStripButton ConntatsSel;
        private ToolStripButton KindsSel;
    }
}