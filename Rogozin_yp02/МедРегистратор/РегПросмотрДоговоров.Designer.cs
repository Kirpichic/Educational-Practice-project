namespace Rogozin_yp02.МедРегистратор
{
    partial class РегПросмотрДоговоров
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.Вакцины = new System.Windows.Forms.TabPage();
            this.dataGridView4 = new System.Windows.Forms.DataGridView();
            this.Регистрационный_номер = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Вакцина = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Валентность = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Способ_введения = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Тип = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.название_услуги = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Количество = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.способ_оплаты = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.скидка = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id_вакцины = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.пользовательToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выходToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выходToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.button2 = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.Вакцины.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.Вакцины);
            this.tabControl1.Location = new System.Drawing.Point(12, 31);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(775, 567);
            this.tabControl1.TabIndex = 31;
            // 
            // Вакцины
            // 
            this.Вакцины.Controls.Add(this.dataGridView4);
            this.Вакцины.Location = new System.Drawing.Point(4, 22);
            this.Вакцины.Name = "Вакцины";
            this.Вакцины.Size = new System.Drawing.Size(767, 541);
            this.Вакцины.TabIndex = 3;
            this.Вакцины.Text = "Договора";
            this.Вакцины.UseVisualStyleBackColor = true;
            // 
            // dataGridView4
            // 
            this.dataGridView4.AllowUserToAddRows = false;
            this.dataGridView4.AllowUserToDeleteRows = false;
            this.dataGridView4.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView4.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Регистрационный_номер,
            this.Вакцина,
            this.Валентность,
            this.Способ_введения,
            this.Тип,
            this.название_услуги,
            this.Количество,
            this.способ_оплаты,
            this.скидка,
            this.id_вакцины});
            this.dataGridView4.Location = new System.Drawing.Point(3, 3);
            this.dataGridView4.Name = "dataGridView4";
            this.dataGridView4.ReadOnly = true;
            this.dataGridView4.Size = new System.Drawing.Size(761, 535);
            this.dataGridView4.TabIndex = 1;
            // 
            // Регистрационный_номер
            // 
            this.Регистрационный_номер.HeaderText = "№";
            this.Регистрационный_номер.Name = "Регистрационный_номер";
            this.Регистрационный_номер.ReadOnly = true;
            // 
            // Вакцина
            // 
            this.Вакцина.HeaderText = "Дата";
            this.Вакцина.Name = "Вакцина";
            this.Вакцина.ReadOnly = true;
            // 
            // Валентность
            // 
            this.Валентность.HeaderText = "Лечащий врач";
            this.Валентность.Name = "Валентность";
            this.Валентность.ReadOnly = true;
            // 
            // Способ_введения
            // 
            this.Способ_введения.HeaderText = "Пациент";
            this.Способ_введения.Name = "Способ_введения";
            this.Способ_введения.ReadOnly = true;
            // 
            // Тип
            // 
            this.Тип.HeaderText = "Номер услуга";
            this.Тип.Name = "Тип";
            this.Тип.ReadOnly = true;
            // 
            // название_услуги
            // 
            this.название_услуги.HeaderText = "Название услуги";
            this.название_услуги.Name = "название_услуги";
            this.название_услуги.ReadOnly = true;
            // 
            // Количество
            // 
            this.Количество.HeaderText = "Стоимость услуги";
            this.Количество.Name = "Количество";
            this.Количество.ReadOnly = true;
            // 
            // способ_оплаты
            // 
            this.способ_оплаты.HeaderText = "Способ оплаты";
            this.способ_оплаты.Name = "способ_оплаты";
            this.способ_оплаты.ReadOnly = true;
            // 
            // скидка
            // 
            this.скидка.HeaderText = "Скидка";
            this.скидка.Name = "скидка";
            this.скидка.ReadOnly = true;
            // 
            // id_вакцины
            // 
            this.id_вакцины.HeaderText = "Идентифекатор вакцины";
            this.id_вакцины.Name = "id_вакцины";
            this.id_вакцины.ReadOnly = true;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.пользовательToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(799, 24);
            this.menuStrip1.TabIndex = 32;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // пользовательToolStripMenuItem
            // 
            this.пользовательToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.выходToolStripMenuItem,
            this.выходToolStripMenuItem1});
            this.пользовательToolStripMenuItem.Name = "пользовательToolStripMenuItem";
            this.пользовательToolStripMenuItem.Size = new System.Drawing.Size(96, 20);
            this.пользовательToolStripMenuItem.Text = "Пользователь";
            // 
            // выходToolStripMenuItem
            // 
            this.выходToolStripMenuItem.Name = "выходToolStripMenuItem";
            this.выходToolStripMenuItem.Size = new System.Drawing.Size(200, 22);
            this.выходToolStripMenuItem.Text = "Сменить пользователя";
            this.выходToolStripMenuItem.Click += new System.EventHandler(this.выходToolStripMenuItem_Click);
            // 
            // выходToolStripMenuItem1
            // 
            this.выходToolStripMenuItem1.Name = "выходToolStripMenuItem1";
            this.выходToolStripMenuItem1.Size = new System.Drawing.Size(200, 22);
            this.выходToolStripMenuItem1.Text = "Выход";
            this.выходToolStripMenuItem1.Click += new System.EventHandler(this.выходToolStripMenuItem1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2.Location = new System.Drawing.Point(12, 616);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(166, 41);
            this.button2.TabIndex = 33;
            this.button2.Text = "Выход";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // РегПросмотрДоговоров
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSkyBlue;
            this.ClientSize = new System.Drawing.Size(799, 669);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.tabControl1);
            this.Name = "РегПросмотрДоговоров";
            this.Text = "Договора за сегодня";
            this.Load += new System.EventHandler(this.РегПросмотрДоговоров_Load);
            this.tabControl1.ResumeLayout(false);
            this.Вакцины.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage Вакцины;
        private System.Windows.Forms.DataGridView dataGridView4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Регистрационный_номер;
        private System.Windows.Forms.DataGridViewTextBoxColumn Вакцина;
        private System.Windows.Forms.DataGridViewTextBoxColumn Валентность;
        private System.Windows.Forms.DataGridViewTextBoxColumn Способ_введения;
        private System.Windows.Forms.DataGridViewTextBoxColumn Тип;
        private System.Windows.Forms.DataGridViewTextBoxColumn название_услуги;
        private System.Windows.Forms.DataGridViewTextBoxColumn Количество;
        private System.Windows.Forms.DataGridViewTextBoxColumn способ_оплаты;
        private System.Windows.Forms.DataGridViewTextBoxColumn скидка;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_вакцины;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem пользовательToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem выходToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem выходToolStripMenuItem1;
        private System.Windows.Forms.Button button2;
    }
}