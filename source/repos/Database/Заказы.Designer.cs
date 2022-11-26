namespace Database
{
    partial class Заказы
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
            this.components = new System.ComponentModel.Container();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.кодЗаказаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.кодКлиентаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.кодСотрудникаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.датаРазмещенияDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.датаНазначенияDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.датаИсполненияDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.доставкаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.стоимостьДоставкиDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.названиеПолучателяDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.адресПолучателяDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.городПолучателяDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.областьПолучателяDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.индексПолучателяDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.странаПолучателяDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.заказыBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.торговая_компанияDataSet = new Database.Торговая_компанияDataSet();
            this.заказыTableAdapter = new Database.Торговая_компанияDataSetTableAdapters.ЗаказыTableAdapter();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.заказыBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.торговая_компанияDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(455, 570);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 17);
            this.label5.TabIndex = 28;
            this.label5.Text = "label5";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(356, 384);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(146, 17);
            this.label4.TabIndex = 27;
            this.label4.Text = "Поле для изменения";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Items.AddRange(new object[] {
            "КодКлиента",
            "КодСотрудника",
            "ДатаРазмещения",
            "ДатаНазначения",
            "ДатаИсполнения",
            "Доставка",
            "СтоимостьДоставки",
            "АдресПолучателя",
            "ГородПолучателя",
            "ОбластьПолучателя",
            "ИндексПолучателя",
            "СтранаПолучателя"});
            this.listBox1.Location = new System.Drawing.Point(359, 419);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(160, 20);
            this.listBox1.TabIndex = 26;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(753, 394);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(227, 119);
            this.button4.TabIndex = 25;
            this.button4.Text = "Обновить данные";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(1027, 394);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(227, 119);
            this.button3.TabIndex = 24;
            this.button3.Text = "Добавить заказ";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(251, 445);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(447, 68);
            this.button2.TabIndex = 23;
            this.button2.Text = "Изменить данные";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(85, 445);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(146, 68);
            this.button1.TabIndex = 22;
            this.button1.Text = "Удалить заказ";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(525, 417);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(173, 22);
            this.textBox3.TabIndex = 21;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(251, 417);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(102, 22);
            this.textBox2.TabIndex = 20;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(85, 417);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(146, 22);
            this.textBox1.TabIndex = 19;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(248, 384);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 17);
            this.label3.TabIndex = 18;
            this.label3.Text = "КодЗаказа";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(582, 384);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 17);
            this.label2.TabIndex = 17;
            this.label2.Text = "Новое значение";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(82, 384);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 17);
            this.label1.TabIndex = 16;
            this.label1.Text = "Укажите КодЗаказа";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.кодЗаказаDataGridViewTextBoxColumn,
            this.кодКлиентаDataGridViewTextBoxColumn,
            this.кодСотрудникаDataGridViewTextBoxColumn,
            this.датаРазмещенияDataGridViewTextBoxColumn,
            this.датаНазначенияDataGridViewTextBoxColumn,
            this.датаИсполненияDataGridViewTextBoxColumn,
            this.доставкаDataGridViewTextBoxColumn,
            this.стоимостьДоставкиDataGridViewTextBoxColumn,
            this.названиеПолучателяDataGridViewTextBoxColumn,
            this.адресПолучателяDataGridViewTextBoxColumn,
            this.городПолучателяDataGridViewTextBoxColumn,
            this.областьПолучателяDataGridViewTextBoxColumn,
            this.индексПолучателяDataGridViewTextBoxColumn,
            this.странаПолучателяDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.заказыBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(28, 52);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1242, 296);
            this.dataGridView1.TabIndex = 15;
            // 
            // кодЗаказаDataGridViewTextBoxColumn
            // 
            this.кодЗаказаDataGridViewTextBoxColumn.DataPropertyName = "КодЗаказа";
            this.кодЗаказаDataGridViewTextBoxColumn.HeaderText = "КодЗаказа";
            this.кодЗаказаDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.кодЗаказаDataGridViewTextBoxColumn.Name = "кодЗаказаDataGridViewTextBoxColumn";
            this.кодЗаказаDataGridViewTextBoxColumn.Width = 125;
            // 
            // кодКлиентаDataGridViewTextBoxColumn
            // 
            this.кодКлиентаDataGridViewTextBoxColumn.DataPropertyName = "КодКлиента";
            this.кодКлиентаDataGridViewTextBoxColumn.HeaderText = "КодКлиента";
            this.кодКлиентаDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.кодКлиентаDataGridViewTextBoxColumn.Name = "кодКлиентаDataGridViewTextBoxColumn";
            this.кодКлиентаDataGridViewTextBoxColumn.Width = 125;
            // 
            // кодСотрудникаDataGridViewTextBoxColumn
            // 
            this.кодСотрудникаDataGridViewTextBoxColumn.DataPropertyName = "КодСотрудника";
            this.кодСотрудникаDataGridViewTextBoxColumn.HeaderText = "КодСотрудника";
            this.кодСотрудникаDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.кодСотрудникаDataGridViewTextBoxColumn.Name = "кодСотрудникаDataGridViewTextBoxColumn";
            this.кодСотрудникаDataGridViewTextBoxColumn.Width = 125;
            // 
            // датаРазмещенияDataGridViewTextBoxColumn
            // 
            this.датаРазмещенияDataGridViewTextBoxColumn.DataPropertyName = "ДатаРазмещения";
            this.датаРазмещенияDataGridViewTextBoxColumn.HeaderText = "ДатаРазмещения";
            this.датаРазмещенияDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.датаРазмещенияDataGridViewTextBoxColumn.Name = "датаРазмещенияDataGridViewTextBoxColumn";
            this.датаРазмещенияDataGridViewTextBoxColumn.Width = 125;
            // 
            // датаНазначенияDataGridViewTextBoxColumn
            // 
            this.датаНазначенияDataGridViewTextBoxColumn.DataPropertyName = "ДатаНазначения";
            this.датаНазначенияDataGridViewTextBoxColumn.HeaderText = "ДатаНазначения";
            this.датаНазначенияDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.датаНазначенияDataGridViewTextBoxColumn.Name = "датаНазначенияDataGridViewTextBoxColumn";
            this.датаНазначенияDataGridViewTextBoxColumn.Width = 125;
            // 
            // датаИсполненияDataGridViewTextBoxColumn
            // 
            this.датаИсполненияDataGridViewTextBoxColumn.DataPropertyName = "ДатаИсполнения";
            this.датаИсполненияDataGridViewTextBoxColumn.HeaderText = "ДатаИсполнения";
            this.датаИсполненияDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.датаИсполненияDataGridViewTextBoxColumn.Name = "датаИсполненияDataGridViewTextBoxColumn";
            this.датаИсполненияDataGridViewTextBoxColumn.Width = 125;
            // 
            // доставкаDataGridViewTextBoxColumn
            // 
            this.доставкаDataGridViewTextBoxColumn.DataPropertyName = "Доставка";
            this.доставкаDataGridViewTextBoxColumn.HeaderText = "Доставка";
            this.доставкаDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.доставкаDataGridViewTextBoxColumn.Name = "доставкаDataGridViewTextBoxColumn";
            this.доставкаDataGridViewTextBoxColumn.Width = 125;
            // 
            // стоимостьДоставкиDataGridViewTextBoxColumn
            // 
            this.стоимостьДоставкиDataGridViewTextBoxColumn.DataPropertyName = "СтоимостьДоставки";
            this.стоимостьДоставкиDataGridViewTextBoxColumn.HeaderText = "СтоимостьДоставки";
            this.стоимостьДоставкиDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.стоимостьДоставкиDataGridViewTextBoxColumn.Name = "стоимостьДоставкиDataGridViewTextBoxColumn";
            this.стоимостьДоставкиDataGridViewTextBoxColumn.Width = 125;
            // 
            // названиеПолучателяDataGridViewTextBoxColumn
            // 
            this.названиеПолучателяDataGridViewTextBoxColumn.DataPropertyName = "НазваниеПолучателя";
            this.названиеПолучателяDataGridViewTextBoxColumn.HeaderText = "НазваниеПолучателя";
            this.названиеПолучателяDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.названиеПолучателяDataGridViewTextBoxColumn.Name = "названиеПолучателяDataGridViewTextBoxColumn";
            this.названиеПолучателяDataGridViewTextBoxColumn.Width = 125;
            // 
            // адресПолучателяDataGridViewTextBoxColumn
            // 
            this.адресПолучателяDataGridViewTextBoxColumn.DataPropertyName = "АдресПолучателя";
            this.адресПолучателяDataGridViewTextBoxColumn.HeaderText = "АдресПолучателя";
            this.адресПолучателяDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.адресПолучателяDataGridViewTextBoxColumn.Name = "адресПолучателяDataGridViewTextBoxColumn";
            this.адресПолучателяDataGridViewTextBoxColumn.Width = 125;
            // 
            // городПолучателяDataGridViewTextBoxColumn
            // 
            this.городПолучателяDataGridViewTextBoxColumn.DataPropertyName = "ГородПолучателя";
            this.городПолучателяDataGridViewTextBoxColumn.HeaderText = "ГородПолучателя";
            this.городПолучателяDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.городПолучателяDataGridViewTextBoxColumn.Name = "городПолучателяDataGridViewTextBoxColumn";
            this.городПолучателяDataGridViewTextBoxColumn.Width = 125;
            // 
            // областьПолучателяDataGridViewTextBoxColumn
            // 
            this.областьПолучателяDataGridViewTextBoxColumn.DataPropertyName = "ОбластьПолучателя";
            this.областьПолучателяDataGridViewTextBoxColumn.HeaderText = "ОбластьПолучателя";
            this.областьПолучателяDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.областьПолучателяDataGridViewTextBoxColumn.Name = "областьПолучателяDataGridViewTextBoxColumn";
            this.областьПолучателяDataGridViewTextBoxColumn.Width = 125;
            // 
            // индексПолучателяDataGridViewTextBoxColumn
            // 
            this.индексПолучателяDataGridViewTextBoxColumn.DataPropertyName = "ИндексПолучателя";
            this.индексПолучателяDataGridViewTextBoxColumn.HeaderText = "ИндексПолучателя";
            this.индексПолучателяDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.индексПолучателяDataGridViewTextBoxColumn.Name = "индексПолучателяDataGridViewTextBoxColumn";
            this.индексПолучателяDataGridViewTextBoxColumn.Width = 125;
            // 
            // странаПолучателяDataGridViewTextBoxColumn
            // 
            this.странаПолучателяDataGridViewTextBoxColumn.DataPropertyName = "СтранаПолучателя";
            this.странаПолучателяDataGridViewTextBoxColumn.HeaderText = "СтранаПолучателя";
            this.странаПолучателяDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.странаПолучателяDataGridViewTextBoxColumn.Name = "странаПолучателяDataGridViewTextBoxColumn";
            this.странаПолучателяDataGridViewTextBoxColumn.Width = 125;
            // 
            // заказыBindingSource
            // 
            this.заказыBindingSource.DataMember = "Заказы";
            this.заказыBindingSource.DataSource = this.торговая_компанияDataSet;
            // 
            // торговая_компанияDataSet
            // 
            this.торговая_компанияDataSet.DataSetName = "Торговая_компанияDataSet";
            this.торговая_компанияDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // заказыTableAdapter
            // 
            this.заказыTableAdapter.ClearBeforeFill = true;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "dd-MMM-yyyy";
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(525, 419);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(0);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(173, 22);
            this.dateTimePicker1.TabIndex = 29;
            this.dateTimePicker1.Visible = false;
            // 
            // Заказы
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1298, 646);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.dateTimePicker1);
            this.Name = "Заказы";
            this.Text = "Заказы";
            this.Load += new System.EventHandler(this.Заказы_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.заказыBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.торговая_компанияDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private Торговая_компанияDataSet торговая_компанияDataSet;
        private System.Windows.Forms.BindingSource заказыBindingSource;
        private Торговая_компанияDataSetTableAdapters.ЗаказыTableAdapter заказыTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn кодЗаказаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn кодКлиентаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn кодСотрудникаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn датаРазмещенияDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn датаНазначенияDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn датаИсполненияDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn доставкаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn стоимостьДоставкиDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn названиеПолучателяDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn адресПолучателяDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn городПолучателяDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn областьПолучателяDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn индексПолучателяDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn странаПолучателяDataGridViewTextBoxColumn;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
    }
}