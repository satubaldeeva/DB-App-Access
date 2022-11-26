namespace Database
{
    partial class Товары
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
            this.кодТовараDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.маркаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.кодПоставщикаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.кодТипаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.единицаИзмеренияDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ценаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.наСкладеDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ожидаетсяDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.минимальныйЗапасDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.поставкиПрекращеныDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.товарыBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.торговая_компанияDataSet = new Database.Торговая_компанияDataSet();
            this.товарыTableAdapter = new Database.Торговая_компанияDataSetTableAdapters.ТоварыTableAdapter();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.нетВНаличииToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.списокИмеющихсяТоваровToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.нетВНаличииToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.товарыBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.торговая_компанияDataSet)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(466, 573);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 17);
            this.label5.TabIndex = 43;
            this.label5.Text = "label5";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(367, 387);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(146, 17);
            this.label4.TabIndex = 42;
            this.label4.Text = "Поле для изменения";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Items.AddRange(new object[] {
            "Марка",
            "КодПоставщика",
            "КодТипа",
            "ЕдиницыИзмерения",
            "Цена",
            "НаСкладе",
            "Ожидается",
            "МинимальныйЗапрос",
            "Поставка",
            "ИндексПолучателя",
            "СтранаПолучателя"});
            this.listBox1.Location = new System.Drawing.Point(370, 422);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(160, 20);
            this.listBox1.TabIndex = 41;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(764, 397);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(227, 119);
            this.button4.TabIndex = 40;
            this.button4.Text = "Обновить данные";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(1038, 397);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(227, 119);
            this.button3.TabIndex = 39;
            this.button3.Text = "Добавить товар";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(262, 448);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(447, 68);
            this.button2.TabIndex = 38;
            this.button2.Text = "Изменить данные";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(96, 448);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(146, 68);
            this.button1.TabIndex = 37;
            this.button1.Text = "Удалить товар";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(536, 420);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(173, 22);
            this.textBox3.TabIndex = 36;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(262, 420);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(102, 22);
            this.textBox2.TabIndex = 35;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(96, 420);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(146, 22);
            this.textBox1.TabIndex = 34;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(259, 387);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 17);
            this.label3.TabIndex = 33;
            this.label3.Text = "КодТовара";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(593, 387);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 17);
            this.label2.TabIndex = 32;
            this.label2.Text = "Новое значение";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(93, 387);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 17);
            this.label1.TabIndex = 31;
            this.label1.Text = "Укажите КодТовара";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.кодТовараDataGridViewTextBoxColumn,
            this.маркаDataGridViewTextBoxColumn,
            this.кодПоставщикаDataGridViewTextBoxColumn,
            this.кодТипаDataGridViewTextBoxColumn,
            this.единицаИзмеренияDataGridViewTextBoxColumn,
            this.ценаDataGridViewTextBoxColumn,
            this.наСкладеDataGridViewTextBoxColumn,
            this.ожидаетсяDataGridViewTextBoxColumn,
            this.минимальныйЗапасDataGridViewTextBoxColumn,
            this.поставкиПрекращеныDataGridViewCheckBoxColumn});
            this.dataGridView1.DataSource = this.товарыBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(47, 48);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1242, 296);
            this.dataGridView1.TabIndex = 30;
            // 
            // кодТовараDataGridViewTextBoxColumn
            // 
            this.кодТовараDataGridViewTextBoxColumn.DataPropertyName = "КодТовара";
            this.кодТовараDataGridViewTextBoxColumn.HeaderText = "КодТовара";
            this.кодТовараDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.кодТовараDataGridViewTextBoxColumn.Name = "кодТовараDataGridViewTextBoxColumn";
            this.кодТовараDataGridViewTextBoxColumn.Width = 125;
            // 
            // маркаDataGridViewTextBoxColumn
            // 
            this.маркаDataGridViewTextBoxColumn.DataPropertyName = "Марка";
            this.маркаDataGridViewTextBoxColumn.HeaderText = "Марка";
            this.маркаDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.маркаDataGridViewTextBoxColumn.Name = "маркаDataGridViewTextBoxColumn";
            this.маркаDataGridViewTextBoxColumn.Width = 125;
            // 
            // кодПоставщикаDataGridViewTextBoxColumn
            // 
            this.кодПоставщикаDataGridViewTextBoxColumn.DataPropertyName = "КодПоставщика";
            this.кодПоставщикаDataGridViewTextBoxColumn.HeaderText = "КодПоставщика";
            this.кодПоставщикаDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.кодПоставщикаDataGridViewTextBoxColumn.Name = "кодПоставщикаDataGridViewTextBoxColumn";
            this.кодПоставщикаDataGridViewTextBoxColumn.Width = 125;
            // 
            // кодТипаDataGridViewTextBoxColumn
            // 
            this.кодТипаDataGridViewTextBoxColumn.DataPropertyName = "КодТипа";
            this.кодТипаDataGridViewTextBoxColumn.HeaderText = "КодТипа";
            this.кодТипаDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.кодТипаDataGridViewTextBoxColumn.Name = "кодТипаDataGridViewTextBoxColumn";
            this.кодТипаDataGridViewTextBoxColumn.Width = 125;
            // 
            // единицаИзмеренияDataGridViewTextBoxColumn
            // 
            this.единицаИзмеренияDataGridViewTextBoxColumn.DataPropertyName = "ЕдиницаИзмерения";
            this.единицаИзмеренияDataGridViewTextBoxColumn.HeaderText = "ЕдиницаИзмерения";
            this.единицаИзмеренияDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.единицаИзмеренияDataGridViewTextBoxColumn.Name = "единицаИзмеренияDataGridViewTextBoxColumn";
            this.единицаИзмеренияDataGridViewTextBoxColumn.Width = 125;
            // 
            // ценаDataGridViewTextBoxColumn
            // 
            this.ценаDataGridViewTextBoxColumn.DataPropertyName = "Цена";
            this.ценаDataGridViewTextBoxColumn.HeaderText = "Цена";
            this.ценаDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.ценаDataGridViewTextBoxColumn.Name = "ценаDataGridViewTextBoxColumn";
            this.ценаDataGridViewTextBoxColumn.Width = 125;
            // 
            // наСкладеDataGridViewTextBoxColumn
            // 
            this.наСкладеDataGridViewTextBoxColumn.DataPropertyName = "НаСкладе";
            this.наСкладеDataGridViewTextBoxColumn.HeaderText = "НаСкладе";
            this.наСкладеDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.наСкладеDataGridViewTextBoxColumn.Name = "наСкладеDataGridViewTextBoxColumn";
            this.наСкладеDataGridViewTextBoxColumn.Width = 125;
            // 
            // ожидаетсяDataGridViewTextBoxColumn
            // 
            this.ожидаетсяDataGridViewTextBoxColumn.DataPropertyName = "Ожидается";
            this.ожидаетсяDataGridViewTextBoxColumn.HeaderText = "Ожидается";
            this.ожидаетсяDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.ожидаетсяDataGridViewTextBoxColumn.Name = "ожидаетсяDataGridViewTextBoxColumn";
            this.ожидаетсяDataGridViewTextBoxColumn.Width = 125;
            // 
            // минимальныйЗапасDataGridViewTextBoxColumn
            // 
            this.минимальныйЗапасDataGridViewTextBoxColumn.DataPropertyName = "МинимальныйЗапас";
            this.минимальныйЗапасDataGridViewTextBoxColumn.HeaderText = "МинимальныйЗапас";
            this.минимальныйЗапасDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.минимальныйЗапасDataGridViewTextBoxColumn.Name = "минимальныйЗапасDataGridViewTextBoxColumn";
            this.минимальныйЗапасDataGridViewTextBoxColumn.Width = 125;
            // 
            // поставкиПрекращеныDataGridViewCheckBoxColumn
            // 
            this.поставкиПрекращеныDataGridViewCheckBoxColumn.DataPropertyName = "ПоставкиПрекращены";
            this.поставкиПрекращеныDataGridViewCheckBoxColumn.HeaderText = "ПоставкиПрекращены";
            this.поставкиПрекращеныDataGridViewCheckBoxColumn.MinimumWidth = 6;
            this.поставкиПрекращеныDataGridViewCheckBoxColumn.Name = "поставкиПрекращеныDataGridViewCheckBoxColumn";
            this.поставкиПрекращеныDataGridViewCheckBoxColumn.Width = 125;
            // 
            // товарыBindingSource
            // 
            this.товарыBindingSource.DataMember = "Товары";
            this.товарыBindingSource.DataSource = this.торговая_компанияDataSet;
            // 
            // торговая_компанияDataSet
            // 
            this.торговая_компанияDataSet.DataSetName = "Торговая_компанияDataSet";
            this.торговая_компанияDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // товарыTableAdapter
            // 
            this.товарыTableAdapter.ClearBeforeFill = true;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.нетВНаличииToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1322, 28);
            this.menuStrip1.TabIndex = 44;
            this.menuStrip1.Text = "Поиск";
            // 
            // нетВНаличииToolStripMenuItem
            // 
            this.нетВНаличииToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.списокИмеющихсяТоваровToolStripMenuItem,
            this.нетВНаличииToolStripMenuItem1});
            this.нетВНаличииToolStripMenuItem.Name = "нетВНаличииToolStripMenuItem";
            this.нетВНаличииToolStripMenuItem.Size = new System.Drawing.Size(66, 24);
            this.нетВНаличииToolStripMenuItem.Text = "Поиск";
            this.нетВНаличииToolStripMenuItem.Click += new System.EventHandler(this.нетВНаличииToolStripMenuItem_Click);
            // 
            // списокИмеющихсяТоваровToolStripMenuItem
            // 
            this.списокИмеющихсяТоваровToolStripMenuItem.Name = "списокИмеющихсяТоваровToolStripMenuItem";
            this.списокИмеющихсяТоваровToolStripMenuItem.Size = new System.Drawing.Size(290, 26);
            this.списокИмеющихсяТоваровToolStripMenuItem.Text = "Список имеющихся товаров";
            this.списокИмеющихсяТоваровToolStripMenuItem.Click += new System.EventHandler(this.списокИмеющихсяТоваровToolStripMenuItem_Click);
            // 
            // нетВНаличииToolStripMenuItem1
            // 
            this.нетВНаличииToolStripMenuItem1.Name = "нетВНаличииToolStripMenuItem1";
            this.нетВНаличииToolStripMenuItem1.Size = new System.Drawing.Size(290, 26);
            this.нетВНаличииToolStripMenuItem1.Text = "Нет в наличии";
            this.нетВНаличииToolStripMenuItem1.Click += new System.EventHandler(this.нетВНаличииToolStripMenuItem1_Click);
            // 
            // Товары
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1322, 658);
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
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Товары";
            this.Text = "Товары";
            this.Load += new System.EventHandler(this.Товары_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.товарыBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.торговая_компанияDataSet)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
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
        private System.Windows.Forms.BindingSource товарыBindingSource;
        private Торговая_компанияDataSetTableAdapters.ТоварыTableAdapter товарыTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn кодТовараDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn маркаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn кодПоставщикаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn кодТипаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn единицаИзмеренияDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ценаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn наСкладеDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ожидаетсяDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn минимальныйЗапасDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn поставкиПрекращеныDataGridViewCheckBoxColumn;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem нетВНаличииToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem списокИмеющихсяТоваровToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem нетВНаличииToolStripMenuItem1;
    }
}