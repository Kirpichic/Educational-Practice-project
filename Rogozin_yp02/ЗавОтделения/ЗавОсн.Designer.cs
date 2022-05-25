namespace Rogozin_yp02
{
    partial class ЗавОсн
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
            this.Статус = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Сотрудники = new System.Windows.Forms.TabPage();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FIO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Телефон = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Birth = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Специальность = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Дата_приёма = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Услуги = new System.Windows.Forms.TabPage();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.номер = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Услуга = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Стоимость = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Исполняющий_сотрудник = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Вакцины = new System.Windows.Forms.TabPage();
            this.dataGridView4 = new System.Windows.Forms.DataGridView();
            this.Регистрационный_номер = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Вакцина = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Валентность = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Способ_введения = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Тип = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Количество = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Адъювант = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Другие_вещества = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Страна_производитель = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Возраст = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Беременность = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.создатьОтчетToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.заМесяцToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.обОказанныхУслугахToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.оРасходеВакцинToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.оПрививкахToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.оЗарплатахСотрудникамToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.заГодToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.обОказанныхУслугахToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.оРасходеВакцинToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.оПрививкахToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.оЗарплатахСотрудникамToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.просмотрДоговоровToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.пользовательToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выходToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выходToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.tabControl1.SuspendLayout();
            this.Клиенты.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.Сотрудники.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.Услуги.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            this.Вакцины.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.Клиенты);
            this.tabControl1.Controls.Add(this.Сотрудники);
            this.tabControl1.Controls.Add(this.Услуги);
            this.tabControl1.Controls.Add(this.Вакцины);
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
            this.Мед_карта,
            this.Статус});
            this.dataGridView1.Location = new System.Drawing.Point(4, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(749, 535);
            this.dataGridView1.TabIndex = 2;
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
            // Сотрудники
            // 
            this.Сотрудники.Controls.Add(this.dataGridView2);
            this.Сотрудники.Location = new System.Drawing.Point(4, 22);
            this.Сотрудники.Name = "Сотрудники";
            this.Сотрудники.Padding = new System.Windows.Forms.Padding(3);
            this.Сотрудники.Size = new System.Drawing.Size(759, 541);
            this.Сотрудники.TabIndex = 1;
            this.Сотрудники.Text = "Сотрудники";
            this.Сотрудники.UseVisualStyleBackColor = true;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.FIO,
            this.Телефон,
            this.Birth,
            this.Специальность,
            this.Дата_приёма});
            this.dataGridView2.Location = new System.Drawing.Point(3, 3);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.Size = new System.Drawing.Size(750, 535);
            this.dataGridView2.TabIndex = 2;
            // 
            // id
            // 
            this.id.HeaderText = "id";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            // 
            // FIO
            // 
            this.FIO.HeaderText = "ФИО";
            this.FIO.Name = "FIO";
            this.FIO.ReadOnly = true;
            // 
            // Телефон
            // 
            this.Телефон.HeaderText = "Номер_телефона";
            this.Телефон.Name = "Телефон";
            this.Телефон.ReadOnly = true;
            // 
            // Birth
            // 
            this.Birth.HeaderText = "Дата рождения";
            this.Birth.Name = "Birth";
            this.Birth.ReadOnly = true;
            // 
            // Специальность
            // 
            this.Специальность.HeaderText = "Специальность";
            this.Специальность.Name = "Специальность";
            this.Специальность.ReadOnly = true;
            // 
            // Дата_приёма
            // 
            this.Дата_приёма.HeaderText = "Дата приёма на работу";
            this.Дата_приёма.Name = "Дата_приёма";
            this.Дата_приёма.ReadOnly = true;
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
            this.dataGridView3.TabIndex = 2;
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
            // Вакцины
            // 
            this.Вакцины.Controls.Add(this.dataGridView4);
            this.Вакцины.Location = new System.Drawing.Point(4, 22);
            this.Вакцины.Name = "Вакцины";
            this.Вакцины.Size = new System.Drawing.Size(759, 541);
            this.Вакцины.TabIndex = 3;
            this.Вакцины.Text = "Вакцины";
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
            this.Количество,
            this.Адъювант,
            this.Другие_вещества,
            this.Страна_производитель,
            this.Возраст,
            this.Беременность});
            this.dataGridView4.Location = new System.Drawing.Point(3, 3);
            this.dataGridView4.Name = "dataGridView4";
            this.dataGridView4.ReadOnly = true;
            this.dataGridView4.Size = new System.Drawing.Size(753, 535);
            this.dataGridView4.TabIndex = 1;
            // 
            // Регистрационный_номер
            // 
            this.Регистрационный_номер.HeaderText = "Регистрационный номер";
            this.Регистрационный_номер.Name = "Регистрационный_номер";
            this.Регистрационный_номер.ReadOnly = true;
            // 
            // Вакцина
            // 
            this.Вакцина.HeaderText = "Вакцина";
            this.Вакцина.Name = "Вакцина";
            this.Вакцина.ReadOnly = true;
            // 
            // Валентность
            // 
            this.Валентность.HeaderText = "Валентность";
            this.Валентность.Name = "Валентность";
            this.Валентность.ReadOnly = true;
            // 
            // Способ_введения
            // 
            this.Способ_введения.HeaderText = "Способ введения";
            this.Способ_введения.Name = "Способ_введения";
            this.Способ_введения.ReadOnly = true;
            // 
            // Тип
            // 
            this.Тип.HeaderText = "Тип";
            this.Тип.Name = "Тип";
            this.Тип.ReadOnly = true;
            // 
            // Количество
            // 
            this.Количество.HeaderText = "Количество";
            this.Количество.Name = "Количество";
            this.Количество.ReadOnly = true;
            // 
            // Адъювант
            // 
            this.Адъювант.HeaderText = "Адъювант";
            this.Адъювант.Name = "Адъювант";
            this.Адъювант.ReadOnly = true;
            // 
            // Другие_вещества
            // 
            this.Другие_вещества.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Другие_вещества.HeaderText = "Другие вещества";
            this.Другие_вещества.Name = "Другие_вещества";
            this.Другие_вещества.ReadOnly = true;
            this.Другие_вещества.Width = 112;
            // 
            // Страна_производитель
            // 
            this.Страна_производитель.HeaderText = "Страна-производитель";
            this.Страна_производитель.Name = "Страна_производитель";
            this.Страна_производитель.ReadOnly = true;
            // 
            // Возраст
            // 
            this.Возраст.HeaderText = "Возраст";
            this.Возраст.Name = "Возраст";
            this.Возраст.ReadOnly = true;
            // 
            // Беременность
            // 
            this.Беременность.HeaderText = "Беременность";
            this.Беременность.Name = "Беременность";
            this.Беременность.ReadOnly = true;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.создатьОтчетToolStripMenuItem,
            this.просмотрДоговоровToolStripMenuItem,
            this.пользовательToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(791, 24);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // создатьОтчетToolStripMenuItem
            // 
            this.создатьОтчетToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.заМесяцToolStripMenuItem,
            this.заГодToolStripMenuItem});
            this.создатьОтчетToolStripMenuItem.Name = "создатьОтчетToolStripMenuItem";
            this.создатьОтчетToolStripMenuItem.Size = new System.Drawing.Size(95, 20);
            this.создатьОтчетToolStripMenuItem.Text = "Создать отчет";
            // 
            // заМесяцToolStripMenuItem
            // 
            this.заМесяцToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.обОказанныхУслугахToolStripMenuItem,
            this.оРасходеВакцинToolStripMenuItem,
            this.оПрививкахToolStripMenuItem,
            this.оЗарплатахСотрудникамToolStripMenuItem});
            this.заМесяцToolStripMenuItem.Name = "заМесяцToolStripMenuItem";
            this.заМесяцToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.заМесяцToolStripMenuItem.Text = "За месяц";
            // 
            // обОказанныхУслугахToolStripMenuItem
            // 
            this.обОказанныхУслугахToolStripMenuItem.Name = "обОказанныхУслугахToolStripMenuItem";
            this.обОказанныхУслугахToolStripMenuItem.Size = new System.Drawing.Size(216, 22);
            this.обОказанныхУслугахToolStripMenuItem.Text = "Об оказанных услугах";
            this.обОказанныхУслугахToolStripMenuItem.Click += new System.EventHandler(this.обОказанныхУслугахToolStripMenuItem_Click_1);
            // 
            // оРасходеВакцинToolStripMenuItem
            // 
            this.оРасходеВакцинToolStripMenuItem.Name = "оРасходеВакцинToolStripMenuItem";
            this.оРасходеВакцинToolStripMenuItem.Size = new System.Drawing.Size(216, 22);
            this.оРасходеВакцинToolStripMenuItem.Text = "О расходе вакцин";
            this.оРасходеВакцинToolStripMenuItem.Click += new System.EventHandler(this.оРасходеВакцинToolStripMenuItem_Click);
            // 
            // оПрививкахToolStripMenuItem
            // 
            this.оПрививкахToolStripMenuItem.Name = "оПрививкахToolStripMenuItem";
            this.оПрививкахToolStripMenuItem.Size = new System.Drawing.Size(216, 22);
            this.оПрививкахToolStripMenuItem.Text = "О прививках";
            this.оПрививкахToolStripMenuItem.Click += new System.EventHandler(this.оПрививкахToolStripMenuItem_Click);
            // 
            // оЗарплатахСотрудникамToolStripMenuItem
            // 
            this.оЗарплатахСотрудникамToolStripMenuItem.Name = "оЗарплатахСотрудникамToolStripMenuItem";
            this.оЗарплатахСотрудникамToolStripMenuItem.Size = new System.Drawing.Size(216, 22);
            this.оЗарплатахСотрудникамToolStripMenuItem.Text = "О зарплатах сотрудникам";
            this.оЗарплатахСотрудникамToolStripMenuItem.Click += new System.EventHandler(this.оЗарплатахСотрудникамToolStripMenuItem_Click);
            // 
            // заГодToolStripMenuItem
            // 
            this.заГодToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.обОказанныхУслугахToolStripMenuItem1,
            this.оРасходеВакцинToolStripMenuItem1,
            this.оПрививкахToolStripMenuItem1,
            this.оЗарплатахСотрудникамToolStripMenuItem1});
            this.заГодToolStripMenuItem.Name = "заГодToolStripMenuItem";
            this.заГодToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.заГодToolStripMenuItem.Text = "За год";
            // 
            // обОказанныхУслугахToolStripMenuItem1
            // 
            this.обОказанныхУслугахToolStripMenuItem1.Name = "обОказанныхУслугахToolStripMenuItem1";
            this.обОказанныхУслугахToolStripMenuItem1.Size = new System.Drawing.Size(216, 22);
            this.обОказанныхУслугахToolStripMenuItem1.Text = "Об оказанных услугах";
            this.обОказанныхУслугахToolStripMenuItem1.Click += new System.EventHandler(this.обОказанныхУслугахToolStripMenuItem1_Click);
            // 
            // оРасходеВакцинToolStripMenuItem1
            // 
            this.оРасходеВакцинToolStripMenuItem1.Name = "оРасходеВакцинToolStripMenuItem1";
            this.оРасходеВакцинToolStripMenuItem1.Size = new System.Drawing.Size(216, 22);
            this.оРасходеВакцинToolStripMenuItem1.Text = "О расходе вакцин";
            this.оРасходеВакцинToolStripMenuItem1.Click += new System.EventHandler(this.оРасходеВакцинToolStripMenuItem1_Click);
            // 
            // оПрививкахToolStripMenuItem1
            // 
            this.оПрививкахToolStripMenuItem1.Name = "оПрививкахToolStripMenuItem1";
            this.оПрививкахToolStripMenuItem1.Size = new System.Drawing.Size(216, 22);
            this.оПрививкахToolStripMenuItem1.Text = "О прививках";
            this.оПрививкахToolStripMenuItem1.Click += new System.EventHandler(this.оПрививкахToolStripMenuItem1_Click);
            // 
            // оЗарплатахСотрудникамToolStripMenuItem1
            // 
            this.оЗарплатахСотрудникамToolStripMenuItem1.Name = "оЗарплатахСотрудникамToolStripMenuItem1";
            this.оЗарплатахСотрудникамToolStripMenuItem1.Size = new System.Drawing.Size(216, 22);
            this.оЗарплатахСотрудникамToolStripMenuItem1.Text = "О зарплатах сотрудникам";
            this.оЗарплатахСотрудникамToolStripMenuItem1.Click += new System.EventHandler(this.оЗарплатахСотрудникамToolStripMenuItem1_Click);
            // 
            // просмотрДоговоровToolStripMenuItem
            // 
            this.просмотрДоговоровToolStripMenuItem.Name = "просмотрДоговоровToolStripMenuItem";
            this.просмотрДоговоровToolStripMenuItem.Size = new System.Drawing.Size(137, 20);
            this.просмотрДоговоровToolStripMenuItem.Text = "Просмотр договоров";
            this.просмотрДоговоровToolStripMenuItem.Click += new System.EventHandler(this.просмотрДоговоровToolStripMenuItem_Click);
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
            // ЗавОсн
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSkyBlue;
            this.ClientSize = new System.Drawing.Size(791, 616);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.tabControl1);
            this.Name = "ЗавОсн";
            this.Text = "Зав. отделением";
            this.Load += new System.EventHandler(this.ЗавОсн_Load);
            this.tabControl1.ResumeLayout(false);
            this.Клиенты.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.Сотрудники.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.Услуги.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            this.Вакцины.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage Клиенты;
        private System.Windows.Forms.TabPage Сотрудники;
        private System.Windows.Forms.TabPage Услуги;
        private System.Windows.Forms.TabPage Вакцины;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn FIO;
        private System.Windows.Forms.DataGridViewTextBoxColumn Телефон;
        private System.Windows.Forms.DataGridViewTextBoxColumn Birth;
        private System.Windows.Forms.DataGridViewTextBoxColumn Специальность;
        private System.Windows.Forms.DataGridViewTextBoxColumn Дата_приёма;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Полис;
        private System.Windows.Forms.DataGridViewTextBoxColumn ФИО;
        private System.Windows.Forms.DataGridViewTextBoxColumn Номер_телефона;
        private System.Windows.Forms.DataGridViewTextBoxColumn Дата_рождения;
        private System.Windows.Forms.DataGridViewTextBoxColumn Пол;
        private System.Windows.Forms.DataGridViewTextBoxColumn Мед_карта;
        private System.Windows.Forms.DataGridViewTextBoxColumn Статус;
        private System.Windows.Forms.DataGridView dataGridView4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Регистрационный_номер;
        private System.Windows.Forms.DataGridViewTextBoxColumn Вакцина;
        private System.Windows.Forms.DataGridViewTextBoxColumn Валентность;
        private System.Windows.Forms.DataGridViewTextBoxColumn Способ_введения;
        private System.Windows.Forms.DataGridViewTextBoxColumn Тип;
        private System.Windows.Forms.DataGridViewTextBoxColumn Количество;
        private System.Windows.Forms.DataGridViewTextBoxColumn Адъювант;
        private System.Windows.Forms.DataGridViewTextBoxColumn Другие_вещества;
        private System.Windows.Forms.DataGridViewTextBoxColumn Страна_производитель;
        private System.Windows.Forms.DataGridViewTextBoxColumn Возраст;
        private System.Windows.Forms.DataGridViewTextBoxColumn Беременность;
        private System.Windows.Forms.DataGridViewTextBoxColumn номер;
        private System.Windows.Forms.DataGridViewTextBoxColumn Услуга;
        private System.Windows.Forms.DataGridViewTextBoxColumn Стоимость;
        private System.Windows.Forms.DataGridViewTextBoxColumn Исполняющий_сотрудник;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem создатьОтчетToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem заМесяцToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem обОказанныхУслугахToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem оРасходеВакцинToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem оПрививкахToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem оЗарплатахСотрудникамToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem заГодToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem обОказанныхУслугахToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem оРасходеВакцинToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem оПрививкахToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem оЗарплатахСотрудникамToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem пользовательToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem выходToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem выходToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem просмотрДоговоровToolStripMenuItem;
    }
}