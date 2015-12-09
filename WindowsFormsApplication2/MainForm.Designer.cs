namespace WindowsFormsApplication2
{
    partial class MainForm
    {
        /// <summary>
        /// Требуется переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.InfoAboutClientsBut = new System.Windows.Forms.Button();
            this.InfoAboutEmployeeBut = new System.Windows.Forms.Button();
            this.exit = new System.Windows.Forms.PictureBox();
            this.JurBut = new System.Windows.Forms.Button();
            this.PhysBut = new System.Windows.Forms.Button();
            this.менюToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.печатьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.PanelInfoClientsBut = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.exit)).BeginInit();
            this.PanelInfoClientsBut.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // InfoAboutClientsBut
            // 
            this.InfoAboutClientsBut.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.InfoAboutClientsBut.Cursor = System.Windows.Forms.Cursors.Hand;
            this.InfoAboutClientsBut.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.InfoAboutClientsBut.Image = global::WindowsFormsApplication2.Properties.Resources.Client;
            this.InfoAboutClientsBut.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.InfoAboutClientsBut.Location = new System.Drawing.Point(12, 43);
            this.InfoAboutClientsBut.Name = "InfoAboutClientsBut";
            this.InfoAboutClientsBut.Size = new System.Drawing.Size(154, 47);
            this.InfoAboutClientsBut.TabIndex = 1;
            this.InfoAboutClientsBut.Text = "Информация о клиентах";
            this.InfoAboutClientsBut.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.InfoAboutClientsBut.UseVisualStyleBackColor = false;
            this.InfoAboutClientsBut.Click += new System.EventHandler(this.InfoAboutClientsBut_Click);
            // 
            // InfoAboutEmployeeBut
            // 
            this.InfoAboutEmployeeBut.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.InfoAboutEmployeeBut.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.InfoAboutEmployeeBut.ForeColor = System.Drawing.SystemColors.ControlText;
            this.InfoAboutEmployeeBut.Image = global::WindowsFormsApplication2.Properties.Resources.Secretary;
            this.InfoAboutEmployeeBut.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.InfoAboutEmployeeBut.Location = new System.Drawing.Point(12, 99);
            this.InfoAboutEmployeeBut.Name = "InfoAboutEmployeeBut";
            this.InfoAboutEmployeeBut.Size = new System.Drawing.Size(154, 47);
            this.InfoAboutEmployeeBut.TabIndex = 1;
            this.InfoAboutEmployeeBut.Text = "Сотрудники";
            this.InfoAboutEmployeeBut.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.InfoAboutEmployeeBut.UseVisualStyleBackColor = false;
            this.InfoAboutEmployeeBut.Click += new System.EventHandler(this.InfoAboutEmployeeBut_Click);
            // 
            // exit
            // 
            this.exit.Image = global::WindowsFormsApplication2.Properties.Resources.exit_83331;
            this.exit.Location = new System.Drawing.Point(398, 257);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(32, 32);
            this.exit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.exit.TabIndex = 5;
            this.exit.TabStop = false;
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // JurBut
            // 
            this.JurBut.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.JurBut.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.JurBut.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.JurBut.Location = new System.Drawing.Point(0, 0);
            this.JurBut.Name = "JurBut";
            this.JurBut.Size = new System.Drawing.Size(132, 44);
            this.JurBut.TabIndex = 7;
            this.JurBut.Text = "Юр. лицо";
            this.JurBut.UseVisualStyleBackColor = false;
            this.JurBut.Click += new System.EventHandler(this.Jur_Click);
            // 
            // PhysBut
            // 
            this.PhysBut.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.PhysBut.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PhysBut.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.PhysBut.Location = new System.Drawing.Point(0, 50);
            this.PhysBut.Name = "PhysBut";
            this.PhysBut.Size = new System.Drawing.Size(132, 44);
            this.PhysBut.TabIndex = 8;
            this.PhysBut.Text = "Физ. Лицо";
            this.PhysBut.UseVisualStyleBackColor = false;
            this.PhysBut.Click += new System.EventHandler(this.JurBut_Click);
            // 
            // менюToolStripMenuItem
            // 
            this.менюToolStripMenuItem.Name = "менюToolStripMenuItem";
            this.менюToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.менюToolStripMenuItem.Text = "Меню";
            // 
            // печатьToolStripMenuItem
            // 
            this.печатьToolStripMenuItem.Name = "печатьToolStripMenuItem";
            this.печатьToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.печатьToolStripMenuItem.Text = "Печать";
            // 
            // PanelInfoClientsBut
            // 
            this.PanelInfoClientsBut.BackColor = System.Drawing.Color.Transparent;
            this.PanelInfoClientsBut.Controls.Add(this.JurBut);
            this.PanelInfoClientsBut.Controls.Add(this.PhysBut);
            this.PanelInfoClientsBut.Location = new System.Drawing.Point(172, 46);
            this.PanelInfoClientsBut.Name = "PanelInfoClientsBut";
            this.PanelInfoClientsBut.Size = new System.Drawing.Size(134, 100);
            this.PanelInfoClientsBut.TabIndex = 14;
            this.PanelInfoClientsBut.Visible = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::WindowsFormsApplication2.Properties.Resources.go_back;
            this.pictureBox1.Location = new System.Drawing.Point(12, 257);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(35, 31);
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.BackgroundImage = global::WindowsFormsApplication2.Properties.Resources.bright_light_textures1;
            this.ClientSize = new System.Drawing.Size(454, 301);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.PanelInfoClientsBut);
            this.Controls.Add(this.exit);
            this.Controls.Add(this.InfoAboutEmployeeBut);
            this.Controls.Add(this.InfoAboutClientsBut);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BanksPayment";
            ((System.ComponentModel.ISupportInitialize)(this.exit)).EndInit();
            this.PanelInfoClientsBut.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button InfoAboutClientsBut;
        private System.Windows.Forms.Button InfoAboutEmployeeBut;
        private System.Windows.Forms.PictureBox exit;
        private System.Windows.Forms.Button JurBut;
        private System.Windows.Forms.Button PhysBut;
        private System.Windows.Forms.ToolStripMenuItem менюToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem печатьToolStripMenuItem;
        private System.Windows.Forms.Panel PanelInfoClientsBut;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

