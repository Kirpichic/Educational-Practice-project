namespace Rogozin_yp02.МедРегистратор
{
    partial class РегДоб
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
            this.Укажите_пол = new System.Windows.Forms.ComboBox();
            this.Укажите_стат = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Полис = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ФИО = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Номер_телефона = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Дата_рождения = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Пол = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Мед_карта = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Статус = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Введите_номер = new System.Windows.Forms.TextBox();
            this.Введите_Фио = new System.Windows.Forms.TextBox();
            this.ДР_д = new System.Windows.Forms.TextBox();
            this.Номер_карты = new System.Windows.Forms.TextBox();
            this.ДР_м = new System.Windows.Forms.TextBox();
            this.ДР_г = new System.Windows.Forms.TextBox();
            this.Введите_полис = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.Услуги = new System.Windows.Forms.TabPage();
            this.Введите_усл = new System.Windows.Forms.TextBox();
            this.Испол_сотр = new System.Windows.Forms.TextBox();
            this.Введите_стой = new System.Windows.Forms.TextBox();
            this.Введите_Ном = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.dataGridView4 = new System.Windows.Forms.DataGridView();
            this.id_услуги = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Услуга = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Стоимость = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Исполняющий_сотрудник = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button2 = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.Клиенты.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.Услуги.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.Клиенты);
            this.tabControl1.Controls.Add(this.Услуги);
            this.tabControl1.Location = new System.Drawing.Point(12, 1);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1281, 545);
            this.tabControl1.TabIndex = 2;
            // 
            // Клиенты
            // 
            this.Клиенты.Controls.Add(this.Укажите_пол);
            this.Клиенты.Controls.Add(this.Укажите_стат);
            this.Клиенты.Controls.Add(this.dataGridView1);
            this.Клиенты.Controls.Add(this.Введите_номер);
            this.Клиенты.Controls.Add(this.Введите_Фио);
            this.Клиенты.Controls.Add(this.ДР_д);
            this.Клиенты.Controls.Add(this.Номер_карты);
            this.Клиенты.Controls.Add(this.ДР_м);
            this.Клиенты.Controls.Add(this.ДР_г);
            this.Клиенты.Controls.Add(this.Введите_полис);
            this.Клиенты.Controls.Add(this.label9);
            this.Клиенты.Controls.Add(this.label1);
            this.Клиенты.Controls.Add(this.label10);
            this.Клиенты.Controls.Add(this.label11);
            this.Клиенты.Controls.Add(this.label12);
            this.Клиенты.Controls.Add(this.label13);
            this.Клиенты.Controls.Add(this.label14);
            this.Клиенты.Controls.Add(this.button3);
            this.Клиенты.Location = new System.Drawing.Point(4, 22);
            this.Клиенты.Name = "Клиенты";
            this.Клиенты.Padding = new System.Windows.Forms.Padding(3);
            this.Клиенты.Size = new System.Drawing.Size(1273, 519);
            this.Клиенты.TabIndex = 1;
            this.Клиенты.Text = "Клиенты";
            this.Клиенты.UseVisualStyleBackColor = true;
            // 
            // Укажите_пол
            // 
            this.Укажите_пол.FormattingEnabled = true;
            this.Укажите_пол.Items.AddRange(new object[] {
            "Мужской",
            "Женский"});
            this.Укажите_пол.Location = new System.Drawing.Point(1013, 236);
            this.Укажите_пол.Name = "Укажите_пол";
            this.Укажите_пол.Size = new System.Drawing.Size(242, 21);
            this.Укажите_пол.TabIndex = 21;
            // 
            // Укажите_стат
            // 
            this.Укажите_стат.FormattingEnabled = true;
            this.Укажите_стат.Items.AddRange(new object[] {
            "Физическое лицо",
            "Юридическое лицо"});
            this.Укажите_стат.Location = new System.Drawing.Point(1013, 336);
            this.Укажите_стат.Name = "Укажите_стат";
            this.Укажите_стат.Size = new System.Drawing.Size(242, 21);
            this.Укажите_стат.TabIndex = 21;
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
            this.Мед_карта,
            this.Статус});
            this.dataGridView1.Location = new System.Drawing.Point(6, 6);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(750, 507);
            this.dataGridView1.TabIndex = 20;
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
            // Статус
            // 
            this.Статус.HeaderText = "Статус";
            this.Статус.Name = "Статус";
            this.Статус.ReadOnly = true;
            // 
            // Введите_номер
            // 
            this.Введите_номер.Location = new System.Drawing.Point(1013, 125);
            this.Введите_номер.Name = "Введите_номер";
            this.Введите_номер.Size = new System.Drawing.Size(242, 20);
            this.Введите_номер.TabIndex = 19;
            // 
            // Введите_Фио
            // 
            this.Введите_Фио.Location = new System.Drawing.Point(1013, 71);
            this.Введите_Фио.Name = "Введите_Фио";
            this.Введите_Фио.Size = new System.Drawing.Size(242, 20);
            this.Введите_Фио.TabIndex = 12;
            // 
            // ДР_д
            // 
            this.ДР_д.Location = new System.Drawing.Point(1112, 182);
            this.ДР_д.Name = "ДР_д";
            this.ДР_д.Size = new System.Drawing.Size(33, 20);
            this.ДР_д.TabIndex = 16;
            // 
            // Номер_карты
            // 
            this.Номер_карты.Location = new System.Drawing.Point(1027, 288);
            this.Номер_карты.Name = "Номер_карты";
            this.Номер_карты.Size = new System.Drawing.Size(228, 20);
            this.Номер_карты.TabIndex = 16;
            // 
            // ДР_м
            // 
            this.ДР_м.Location = new System.Drawing.Point(1073, 182);
            this.ДР_м.Name = "ДР_м";
            this.ДР_м.Size = new System.Drawing.Size(33, 20);
            this.ДР_м.TabIndex = 16;
            // 
            // ДР_г
            // 
            this.ДР_г.Location = new System.Drawing.Point(1013, 182);
            this.ДР_г.Name = "ДР_г";
            this.ДР_г.Size = new System.Drawing.Size(54, 20);
            this.ДР_г.TabIndex = 16;
            // 
            // Введите_полис
            // 
            this.Введите_полис.Location = new System.Drawing.Point(1013, 19);
            this.Введите_полис.Name = "Введите_полис";
            this.Введите_полис.Size = new System.Drawing.Size(242, 20);
            this.Введите_полис.TabIndex = 18;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.Location = new System.Drawing.Point(762, 284);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(259, 24);
            this.label9.TabIndex = 6;
            this.label9.Text = "Введите номер мед. карты:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(762, 331);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(157, 24);
            this.label1.TabIndex = 7;
            this.label1.Text = "Введите статус:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label10.Location = new System.Drawing.Point(762, 231);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(130, 24);
            this.label10.TabIndex = 7;
            this.label10.Text = "Введите пол:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label11.Location = new System.Drawing.Point(762, 178);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(235, 24);
            this.label11.TabIndex = 8;
            this.label11.Text = "Введите дату рождения:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label12.Location = new System.Drawing.Point(762, 120);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(248, 24);
            this.label12.TabIndex = 9;
            this.label12.Text = "Введите номер телефона:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label13.Location = new System.Drawing.Point(762, 66);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(142, 24);
            this.label13.TabIndex = 10;
            this.label13.Text = "Введите ФИО:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label14.Location = new System.Drawing.Point(762, 14);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(151, 24);
            this.label14.TabIndex = 11;
            this.label14.Text = "Введите полис:";
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button3.Location = new System.Drawing.Point(1091, 461);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(166, 41);
            this.button3.TabIndex = 4;
            this.button3.Text = "Добавить";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Услуги
            // 
            this.Услуги.Controls.Add(this.Введите_усл);
            this.Услуги.Controls.Add(this.Испол_сотр);
            this.Услуги.Controls.Add(this.Введите_стой);
            this.Услуги.Controls.Add(this.Введите_Ном);
            this.Услуги.Controls.Add(this.label17);
            this.Услуги.Controls.Add(this.label18);
            this.Услуги.Controls.Add(this.label19);
            this.Услуги.Controls.Add(this.label20);
            this.Услуги.Controls.Add(this.button4);
            this.Услуги.Controls.Add(this.dataGridView4);
            this.Услуги.Location = new System.Drawing.Point(4, 22);
            this.Услуги.Name = "Услуги";
            this.Услуги.Size = new System.Drawing.Size(1273, 519);
            this.Услуги.TabIndex = 3;
            this.Услуги.Text = "Услуги";
            this.Услуги.UseVisualStyleBackColor = true;
            // 
            // Введите_усл
            // 
            this.Введите_усл.Location = new System.Drawing.Point(1013, 60);
            this.Введите_усл.Name = "Введите_усл";
            this.Введите_усл.Size = new System.Drawing.Size(242, 20);
            this.Введите_усл.TabIndex = 12;
            // 
            // Испол_сотр
            // 
            this.Испол_сотр.Location = new System.Drawing.Point(1013, 171);
            this.Испол_сотр.Name = "Испол_сотр";
            this.Испол_сотр.Size = new System.Drawing.Size(242, 20);
            this.Испол_сотр.TabIndex = 16;
            // 
            // Введите_стой
            // 
            this.Введите_стой.Location = new System.Drawing.Point(1026, 114);
            this.Введите_стой.Name = "Введите_стой";
            this.Введите_стой.Size = new System.Drawing.Size(229, 20);
            this.Введите_стой.TabIndex = 17;
            // 
            // Введите_Ном
            // 
            this.Введите_Ном.Location = new System.Drawing.Point(1013, 18);
            this.Введите_Ном.Name = "Введите_Ном";
            this.Введите_Ном.Size = new System.Drawing.Size(242, 20);
            this.Введите_Ном.TabIndex = 18;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label17.Location = new System.Drawing.Point(762, 167);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(239, 24);
            this.label17.TabIndex = 8;
            this.label17.Text = "Исполняющий сотрудник:";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label18.Location = new System.Drawing.Point(762, 109);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(258, 24);
            this.label18.TabIndex = 9;
            this.label18.Text = "Введите стоимость услуги:";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label19.Location = new System.Drawing.Point(762, 55);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(154, 24);
            this.label19.TabIndex = 10;
            this.label19.Text = "Введите услугу:";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label20.Location = new System.Drawing.Point(762, 13);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(118, 24);
            this.label20.TabIndex = 11;
            this.label20.Text = "Введите №:";
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button4.Location = new System.Drawing.Point(1094, 462);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(166, 41);
            this.button4.TabIndex = 4;
            this.button4.Text = "Добавить";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // dataGridView4
            // 
            this.dataGridView4.AllowUserToAddRows = false;
            this.dataGridView4.AllowUserToDeleteRows = false;
            this.dataGridView4.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView4.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id_услуги,
            this.Услуга,
            this.Стоимость,
            this.Исполняющий_сотрудник});
            this.dataGridView4.Location = new System.Drawing.Point(3, 3);
            this.dataGridView4.Name = "dataGridView4";
            this.dataGridView4.ReadOnly = true;
            this.dataGridView4.Size = new System.Drawing.Size(753, 513);
            this.dataGridView4.TabIndex = 0;
            // 
            // id_услуги
            // 
            this.id_услуги.HeaderText = "№";
            this.id_услуги.Name = "id_услуги";
            this.id_услуги.ReadOnly = true;
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
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2.Location = new System.Drawing.Point(16, 563);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(166, 41);
            this.button2.TabIndex = 4;
            this.button2.Text = "Выход";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // РегДоб
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSkyBlue;
            this.ClientSize = new System.Drawing.Size(1305, 616);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.tabControl1);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "РегДоб";
            this.Text = "Добавить элементы";
            this.Load += new System.EventHandler(this.РегДоб_Load);
            this.tabControl1.ResumeLayout(false);
            this.Клиенты.ResumeLayout(false);
            this.Клиенты.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.Услуги.ResumeLayout(false);
            this.Услуги.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage Услуги;
        private System.Windows.Forms.DataGridView dataGridView4;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_услуги;
        private System.Windows.Forms.DataGridViewTextBoxColumn Услуга;
        private System.Windows.Forms.DataGridViewTextBoxColumn Стоимость;
        private System.Windows.Forms.DataGridViewTextBoxColumn Исполняющий_сотрудник;
        private System.Windows.Forms.TextBox Введите_усл;
        private System.Windows.Forms.TextBox Испол_сотр;
        private System.Windows.Forms.TextBox Введите_стой;
        private System.Windows.Forms.TextBox Введите_Ном;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.TabPage Клиенты;
        private System.Windows.Forms.ComboBox Укажите_стат;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Полис;
        private System.Windows.Forms.DataGridViewTextBoxColumn ФИО;
        private System.Windows.Forms.DataGridViewTextBoxColumn Номер_телефона;
        private System.Windows.Forms.DataGridViewTextBoxColumn Дата_рождения;
        private System.Windows.Forms.DataGridViewTextBoxColumn Пол;
        private System.Windows.Forms.DataGridViewTextBoxColumn Мед_карта;
        private System.Windows.Forms.DataGridViewTextBoxColumn Статус;
        private System.Windows.Forms.TextBox Введите_номер;
        private System.Windows.Forms.TextBox Введите_Фио;
        private System.Windows.Forms.TextBox ДР_д;
        private System.Windows.Forms.TextBox Номер_карты;
        private System.Windows.Forms.TextBox ДР_м;
        private System.Windows.Forms.TextBox ДР_г;
        private System.Windows.Forms.TextBox Введите_полис;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.ComboBox Укажите_пол;
    }
}