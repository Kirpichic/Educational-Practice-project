namespace Rogozin_yp02
{
    partial class РегОсн
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
            this.Клиенты = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Полис = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ФИО = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Номер_телефона = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Дата_рождения = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Пол = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Мед_карта = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Услуги = new System.Windows.Forms.TabPage();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.номер = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Услуга = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Стоимость = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Исполняющий_сотрудник = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.изменениеТаблицToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.добавитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.удалитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.изменитьЭлементToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.просмотрДоговоровToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.просмотрДоговоровToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.созданиеДоговораToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.пользовательToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выходToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выходToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.tabControl1.SuspendLayout();
            this.Клиенты.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.Услуги.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.Клиенты);
            this.tabControl1.Controls.Add(this.Услуги);
            this.tabControl1.Location = new System.Drawing.Point(12, 37);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(767, 567);
            this.tabControl1.TabIndex = 2;
            // 
            // Клиенты
            // 
            this.Клиенты.Controls.Add(this.dataGridView1);
            this.Клиенты.Location = new System.Drawing.Point(4, 22);
            this.Клиенты.Name = "Клиенты";
            this.Клиенты.Padding = new System.Windows.Forms.Padding(3);
            this.Клиенты.Size = new System.Drawing.Size(759, 541);
            this.Клиенты.TabIndex = 0;
            this.Клиенты.Text = "Клиенты";
            this.Клиенты.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Полис,
            this.ФИО,
            this.Номер_телефона,
            this.Дата_рождения,
            this.Пол,
            this.Мед_карта});
            this.dataGridView1.Location = new System.Drawing.Point(4, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(749, 535);
            this.dataGridView1.TabIndex = 1;
            // 
            // Полис
            // 
            this.Полис.HeaderText = "Полис";
            this.Полис.Name = "Полис";
            this.Полис.ReadOnly = true;
            this.Полис.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Полис.ToolTipText = "int";
            // 
            // ФИО
            // 
            this.ФИО.HeaderText = "ФИО";
            this.ФИО.Name = "ФИО";
            this.ФИО.ReadOnly = true;
            // 
            // Номер_телефона
            // 
            this.Номер_телефона.HeaderText = "Номер телефона";
            this.Номер_телефона.Name = "Номер_телефона";
            this.Номер_телефона.ReadOnly = true;
            // 
            // Дата_рождения
            // 
            this.Дата_рождения.HeaderText = "Дата рождения";
            this.Дата_рождения.Name = "Дата_рождения";
            this.Дата_рождения.ReadOnly = true;
            // 
            // Пол
            // 
            this.Пол.HeaderText = "Пол";
            this.Пол.Name = "Пол";
            this.Пол.ReadOnly = true;
            // 
            // Мед_карта
            // 
            this.Мед_карта.HeaderText = "Медицинская карта";
            this.Мед_карта.Name = "Мед_карта";
            this.Мед_карта.ReadOnly = true;
            // 
            // Услуги
            // 
            this.Услуги.Controls.Add(this.dataGridView3);
            this.Услуги.Location = new System.Drawing.Point(4, 22);
            this.Услуги.Name = "Услуги";
            this.Услуги.Size = new System.Drawing.Size(759, 541);
            this.Услуги.TabIndex = 2;
            this.Услуги.Text = "Услуги";
            this.Услуги.UseVisualStyleBackColor = true;
            // 
            // dataGridView3
            // 
            this.dataGridView3.AllowUserToAddRows = false;
            this.dataGridView3.AllowUserToDeleteRows = false;
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.номер,
            this.Услуга,
            this.Стоимость,
            this.Исполняющий_сотрудник});
            this.dataGridView3.Location = new System.Drawing.Point(3, 3);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.ReadOnly = true;
            this.dataGridView3.Size = new System.Drawing.Size(753, 535);
            this.dataGridView3.TabIndex = 1;
            // 
            // номер
            // 
            this.номер.HeaderText = "№";
            this.номер.Name = "номер";
            this.номер.ReadOnly = true;
            // 
            // Услуга
            // 
            this.Услуга.HeaderText = "Услуга";
            this.Услуга.Name = "Услуга";
            this.Услуга.ReadOnly = true;
            // 
            // Стоимость
            // 
            this.Стоимость.HeaderText = "Стоимость";
            this.Стоимость.Name = "Стоимость";
            this.Стоимость.ReadOnly = true;
            // 
            // Исполняющий_сотрудник
            // 
            this.Исполняющий_сотрудник.HeaderText = "Исполняющий сотрудник";
            this.Исполняющий_сотрудник.Name = "Исполняющий_сотрудник";
            this.Исполняющий_сотрудник.ReadOnly = true;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.изменениеТаблицToolStripMenuItem,
            this.просмотрДоговоровToolStripMenuItem,
            this.пользовательToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(791, 24);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // изменениеТаблицToolStripMenuItem
            // 
            this.изменениеТаблицToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.добавитьToolStripMenuItem,
            this.удалитьToolStripMenuItem,
            this.изменитьЭлементToolStripMenuItem});
            this.изменениеТаблицToolStripMenuItem.Name = "изменениеТаблицToolStripMenuItem";
            this.изменениеТаблицToolStripMenuItem.Size = new System.Drawing.Size(99, 20);
            this.изменениеТаблицToolStripMenuItem.Text = "Редактировать";
            // 
            // добавитьToolStripMenuItem
            // 
            this.добавитьToolStripMenuItem.Name = "добавитьToolStripMenuItem";
            this.добавитьToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.добавитьToolStripMenuItem.Text = "Добавить элементы";
            this.добавитьToolStripMenuItem.Click += new System.EventHandler(this.добавитьToolStripMenuItem_Click);
            // 
            // удалитьToolStripMenuItem
            // 
            this.удалитьToolStripMenuItem.Name = "удалитьToolStripMenuItem";
            this.удалитьToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.удалитьToolStripMenuItem.Text = "Удалить элементы";
            this.удалитьToolStripMenuItem.Click += new System.EventHandler(this.удалитьToolStripMenuItem_Click);
            // 
            // изменитьЭлементToolStripMenuItem
            // 
            this.изменитьЭлементToolStripMenuItem.Name = "изменитьЭлементToolStripMenuItem";
            this.изменитьЭлементToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.изменитьЭлементToolStripMenuItem.Text = "Изменить элементы";
            // 
            // просмотрДоговоровToolStripMenuItem
            // 
            this.просмотрДоговоровToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.просмотрДоговоровToolStripMenuItem1,
            this.созданиеДоговораToolStripMenuItem});
            this.просмотрДоговоровToolStripMenuItem.Name = "просмотрДоговоровToolStripMenuItem";
            this.просмотрДоговоровToolStripMenuItem.Size = new System.Drawing.Size(72, 20);
            this.просмотрДоговоровToolStripMenuItem.Text = "Договора";
            // 
            // просмотрДоговоровToolStripMenuItem1
            // 
            this.просмотрДоговоровToolStripMenuItem1.Name = "просмотрДоговоровToolStripMenuItem1";
            this.просмотрДоговоровToolStripMenuItem1.Size = new System.Drawing.Size(192, 22);
            this.просмотрДоговоровToolStripMenuItem1.Text = "Просмотр договоров";
            this.просмотрДоговоровToolStripMenuItem1.Click += new System.EventHandler(this.просмотрДоговоровToolStripMenuItem1_Click);
            // 
            // созданиеДоговораToolStripMenuItem
            // 
            this.созданиеДоговораToolStripMenuItem.Name = "созданиеДоговораToolStripMenuItem";
            this.созданиеДоговораToolStripMenuItem.Size = new System.Drawing.Size(192, 22);
            this.созданиеДоговораToolStripMenuItem.Text = "Создание договора";
            this.созданиеДоговораToolStripMenuItem.Click += new System.EventHandler(this.созданиеДоговораToolStripMenuItem_Click);
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
            this.выходToolStripMenuItem.Click += new System.EventHandler(this.выходToolStripMenuItem_Click_1);
            // 
            // выходToolStripMenuItem1
            // 
            this.выходToolStripMenuItem1.Name = "выходToolStripMenuItem1";
            this.выходToolStripMenuItem1.Size = new System.Drawing.Size(200, 22);
            this.выходToolStripMenuItem1.Text = "Выход";
            this.выходToolStripMenuItem1.Click += new System.EventHandler(this.выходToolStripMenuItem1_Click_1);
            // 
            // РегОсн
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSkyBlue;
            this.ClientSize = new System.Drawing.Size(791, 616);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.tabControl1);
            this.Name = "РегОсн";
            this.Text = "Мед. регистратор";
            this.Load += new System.EventHandler(this.РегОсн_Load);
            this.tabControl1.ResumeLayout(false);
            this.Клиенты.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.Услуги.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage Клиенты;
        private System.Windows.Forms.TabPage Услуги;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Полис;
        private System.Windows.Forms.DataGridViewTextBoxColumn ФИО;
        private System.Windows.Forms.DataGridViewTextBoxColumn Номер_телефона;
        private System.Windows.Forms.DataGridViewTextBoxColumn Дата_рождения;
        private System.Windows.Forms.DataGridViewTextBoxColumn Пол;
        private System.Windows.Forms.DataGridViewTextBoxColumn Мед_карта;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.DataGridViewTextBoxColumn номер;
        private System.Windows.Forms.DataGridViewTextBoxColumn Услуга;
        private System.Windows.Forms.DataGridViewTextBoxColumn Стоимость;
        private System.Windows.Forms.DataGridViewTextBoxColumn Исполняющий_сотрудник;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem изменениеТаблицToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem добавитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem удалитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem изменитьЭлементToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem пользовательToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem выходToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem выходToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem просмотрДоговоровToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem просмотрДоговоровToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem созданиеДоговораToolStripMenuItem;
    }
}