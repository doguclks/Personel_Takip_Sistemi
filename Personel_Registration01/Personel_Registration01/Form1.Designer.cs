namespace Personel_Registration01
{
    partial class Form1
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
            this.TxtId = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.CmbCity = new System.Windows.Forms.ComboBox();
            this.MskSalary = new System.Windows.Forms.MaskedTextBox();
            this.TxtJob = new System.Windows.Forms.TextBox();
            this.TxtName = new System.Windows.Forms.TextBox();
            this.TxtSurname = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.BtnGraph = new System.Windows.Forms.Button();
            this.BtnIstatistic = new System.Windows.Forms.Button();
            this.BtnClear = new System.Windows.Forms.Button();
            this.BtnUpdate = new System.Windows.Forms.Button();
            this.BtnDelete = new System.Windows.Forms.Button();
            this.BtnSave = new System.Windows.Forms.Button();
            this.BtnList = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.personelidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.personelnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.personelsurnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.personelcityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.personelsalaryDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.personelstatusDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.personeljobDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.personeltableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.personel_DBDataSet1 = new Personel_Registration01.Personel_DBDataSet1();
            this.randomtableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.personel_DBDataSet2 = new Personel_Registration01.Personel_DBDataSet2();
            this.personel_tableTableAdapter = new Personel_Registration01.Personel_DBDataSet1TableAdapters.Personel_tableTableAdapter();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.random_tableTableAdapter = new Personel_Registration01.Personel_DBDataSet2TableAdapters.random_tableTableAdapter();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.personeltableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.personel_DBDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.randomtableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.personel_DBDataSet2)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // TxtId
            // 
            this.TxtId.Location = new System.Drawing.Point(196, 110);
            this.TxtId.Margin = new System.Windows.Forms.Padding(5);
            this.TxtId.Name = "TxtId";
            this.TxtId.Size = new System.Drawing.Size(211, 32);
            this.TxtId.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.radioButton2);
            this.groupBox1.Controls.Add(this.radioButton1);
            this.groupBox1.Controls.Add(this.CmbCity);
            this.groupBox1.Controls.Add(this.MskSalary);
            this.groupBox1.Controls.Add(this.TxtJob);
            this.groupBox1.Controls.Add(this.TxtName);
            this.groupBox1.Controls.Add(this.TxtSurname);
            this.groupBox1.Controls.Add(this.TxtId);
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.groupBox1.Size = new System.Drawing.Size(737, 640);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Registration";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(535, 291);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(0, 24);
            this.label8.TabIndex = 16;
            this.label8.Visible = false;
            this.label8.TextChanged += new System.EventHandler(this.label8_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(88, 538);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(39, 24);
            this.label7.TabIndex = 15;
            this.label7.Text = "Job";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(87, 472);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 24);
            this.label6.TabIndex = 14;
            this.label6.Text = "Status";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(84, 402);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 24);
            this.label5.TabIndex = 13;
            this.label5.Text = "Salary";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(85, 336);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 24);
            this.label4.TabIndex = 12;
            this.label4.Text = "City";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(87, 264);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 24);
            this.label3.TabIndex = 11;
            this.label3.Text = "Surname";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(84, 188);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 24);
            this.label2.TabIndex = 10;
            this.label2.Text = "Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(86, 113);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 24);
            this.label1.TabIndex = 9;
            this.label1.Text = "Id";
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(310, 470);
            this.radioButton2.Margin = new System.Windows.Forms.Padding(5);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(84, 28);
            this.radioButton2.TabIndex = 7;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Single";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(196, 470);
            this.radioButton1.Margin = new System.Windows.Forms.Padding(5);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(97, 28);
            this.radioButton1.TabIndex = 6;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Married";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // CmbCity
            // 
            this.CmbCity.FormattingEnabled = true;
            this.CmbCity.Location = new System.Drawing.Point(196, 333);
            this.CmbCity.Margin = new System.Windows.Forms.Padding(5);
            this.CmbCity.Name = "CmbCity";
            this.CmbCity.Size = new System.Drawing.Size(211, 32);
            this.CmbCity.TabIndex = 4;
            this.CmbCity.SelectedIndexChanged += new System.EventHandler(this.CmbCity_SelectedIndexChanged);
            // 
            // MskSalary
            // 
            this.MskSalary.Location = new System.Drawing.Point(196, 399);
            this.MskSalary.Margin = new System.Windows.Forms.Padding(5);
            this.MskSalary.Mask = "0000";
            this.MskSalary.Name = "MskSalary";
            this.MskSalary.Size = new System.Drawing.Size(211, 32);
            this.MskSalary.TabIndex = 5;
            this.MskSalary.ValidatingType = typeof(int);
            // 
            // TxtJob
            // 
            this.TxtJob.Location = new System.Drawing.Point(196, 535);
            this.TxtJob.Margin = new System.Windows.Forms.Padding(5);
            this.TxtJob.Name = "TxtJob";
            this.TxtJob.Size = new System.Drawing.Size(211, 32);
            this.TxtJob.TabIndex = 8;
            // 
            // TxtName
            // 
            this.TxtName.Location = new System.Drawing.Point(196, 185);
            this.TxtName.Margin = new System.Windows.Forms.Padding(5);
            this.TxtName.Name = "TxtName";
            this.TxtName.Size = new System.Drawing.Size(211, 32);
            this.TxtName.TabIndex = 2;
            // 
            // TxtSurname
            // 
            this.TxtSurname.Location = new System.Drawing.Point(196, 261);
            this.TxtSurname.Margin = new System.Windows.Forms.Padding(5);
            this.TxtSurname.Name = "TxtSurname";
            this.TxtSurname.Size = new System.Drawing.Size(211, 32);
            this.TxtSurname.TabIndex = 3;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.BtnGraph);
            this.groupBox2.Controls.Add(this.BtnIstatistic);
            this.groupBox2.Controls.Add(this.BtnClear);
            this.groupBox2.Controls.Add(this.BtnUpdate);
            this.groupBox2.Controls.Add(this.BtnDelete);
            this.groupBox2.Controls.Add(this.BtnSave);
            this.groupBox2.Controls.Add(this.BtnList);
            this.groupBox2.Location = new System.Drawing.Point(746, 0);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.groupBox2.Size = new System.Drawing.Size(349, 640);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Transactions";
            // 
            // BtnGraph
            // 
            this.BtnGraph.Location = new System.Drawing.Point(117, 526);
            this.BtnGraph.Name = "BtnGraph";
            this.BtnGraph.Size = new System.Drawing.Size(125, 36);
            this.BtnGraph.TabIndex = 15;
            this.BtnGraph.Text = "Graph";
            this.BtnGraph.UseVisualStyleBackColor = true;
            this.BtnGraph.Click += new System.EventHandler(this.BtnGraph_Click);
            // 
            // BtnIstatistic
            // 
            this.BtnIstatistic.Location = new System.Drawing.Point(117, 460);
            this.BtnIstatistic.Name = "BtnIstatistic";
            this.BtnIstatistic.Size = new System.Drawing.Size(125, 36);
            this.BtnIstatistic.TabIndex = 14;
            this.BtnIstatistic.Text = "Istatistic";
            this.BtnIstatistic.UseVisualStyleBackColor = true;
            this.BtnIstatistic.Click += new System.EventHandler(this.BtnIstatistic_Click);
            // 
            // BtnClear
            // 
            this.BtnClear.Location = new System.Drawing.Point(117, 390);
            this.BtnClear.Name = "BtnClear";
            this.BtnClear.Size = new System.Drawing.Size(125, 36);
            this.BtnClear.TabIndex = 13;
            this.BtnClear.Text = "Clear";
            this.BtnClear.UseVisualStyleBackColor = true;
            this.BtnClear.Click += new System.EventHandler(this.BtnClear_Click);
            // 
            // BtnUpdate
            // 
            this.BtnUpdate.Location = new System.Drawing.Point(117, 324);
            this.BtnUpdate.Name = "BtnUpdate";
            this.BtnUpdate.Size = new System.Drawing.Size(125, 36);
            this.BtnUpdate.TabIndex = 12;
            this.BtnUpdate.Text = "Update";
            this.BtnUpdate.UseVisualStyleBackColor = true;
            this.BtnUpdate.Click += new System.EventHandler(this.BtnUpdate_Click);
            // 
            // BtnDelete
            // 
            this.BtnDelete.Location = new System.Drawing.Point(117, 252);
            this.BtnDelete.Name = "BtnDelete";
            this.BtnDelete.Size = new System.Drawing.Size(125, 36);
            this.BtnDelete.TabIndex = 11;
            this.BtnDelete.Text = "Delete";
            this.BtnDelete.UseVisualStyleBackColor = true;
            this.BtnDelete.Click += new System.EventHandler(this.BtnDelete_Click);
            // 
            // BtnSave
            // 
            this.BtnSave.Location = new System.Drawing.Point(117, 176);
            this.BtnSave.Name = "BtnSave";
            this.BtnSave.Size = new System.Drawing.Size(125, 36);
            this.BtnSave.TabIndex = 10;
            this.BtnSave.Text = "Save";
            this.BtnSave.UseVisualStyleBackColor = true;
            this.BtnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // BtnList
            // 
            this.BtnList.Location = new System.Drawing.Point(117, 101);
            this.BtnList.Name = "BtnList";
            this.BtnList.Size = new System.Drawing.Size(125, 36);
            this.BtnList.TabIndex = 9;
            this.BtnList.Text = "List";
            this.BtnList.UseVisualStyleBackColor = true;
            this.BtnList.Click += new System.EventHandler(this.BtnList_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.personelidDataGridViewTextBoxColumn,
            this.personelnameDataGridViewTextBoxColumn,
            this.personelsurnameDataGridViewTextBoxColumn,
            this.personelcityDataGridViewTextBoxColumn,
            this.personelsalaryDataGridViewTextBoxColumn,
            this.personelstatusDataGridViewCheckBoxColumn,
            this.personeljobDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.personeltableBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 28);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1077, 144);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_CellMouseDoubleClick);
            // 
            // personelidDataGridViewTextBoxColumn
            // 
            this.personelidDataGridViewTextBoxColumn.DataPropertyName = "Personel_id";
            this.personelidDataGridViewTextBoxColumn.HeaderText = "Personel_id";
            this.personelidDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.personelidDataGridViewTextBoxColumn.Name = "personelidDataGridViewTextBoxColumn";
            this.personelidDataGridViewTextBoxColumn.ReadOnly = true;
            this.personelidDataGridViewTextBoxColumn.Width = 125;
            // 
            // personelnameDataGridViewTextBoxColumn
            // 
            this.personelnameDataGridViewTextBoxColumn.DataPropertyName = "Personel_name";
            this.personelnameDataGridViewTextBoxColumn.HeaderText = "Personel_name";
            this.personelnameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.personelnameDataGridViewTextBoxColumn.Name = "personelnameDataGridViewTextBoxColumn";
            this.personelnameDataGridViewTextBoxColumn.Width = 125;
            // 
            // personelsurnameDataGridViewTextBoxColumn
            // 
            this.personelsurnameDataGridViewTextBoxColumn.DataPropertyName = "Personel_surname";
            this.personelsurnameDataGridViewTextBoxColumn.HeaderText = "Personel_surname";
            this.personelsurnameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.personelsurnameDataGridViewTextBoxColumn.Name = "personelsurnameDataGridViewTextBoxColumn";
            this.personelsurnameDataGridViewTextBoxColumn.Width = 125;
            // 
            // personelcityDataGridViewTextBoxColumn
            // 
            this.personelcityDataGridViewTextBoxColumn.DataPropertyName = "Personel_city";
            this.personelcityDataGridViewTextBoxColumn.HeaderText = "Personel_city";
            this.personelcityDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.personelcityDataGridViewTextBoxColumn.Name = "personelcityDataGridViewTextBoxColumn";
            this.personelcityDataGridViewTextBoxColumn.Width = 125;
            // 
            // personelsalaryDataGridViewTextBoxColumn
            // 
            this.personelsalaryDataGridViewTextBoxColumn.DataPropertyName = "Personel_salary";
            this.personelsalaryDataGridViewTextBoxColumn.HeaderText = "Personel_salary";
            this.personelsalaryDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.personelsalaryDataGridViewTextBoxColumn.Name = "personelsalaryDataGridViewTextBoxColumn";
            this.personelsalaryDataGridViewTextBoxColumn.Width = 125;
            // 
            // personelstatusDataGridViewCheckBoxColumn
            // 
            this.personelstatusDataGridViewCheckBoxColumn.DataPropertyName = "Personel_status";
            this.personelstatusDataGridViewCheckBoxColumn.HeaderText = "Personel_status";
            this.personelstatusDataGridViewCheckBoxColumn.MinimumWidth = 6;
            this.personelstatusDataGridViewCheckBoxColumn.Name = "personelstatusDataGridViewCheckBoxColumn";
            this.personelstatusDataGridViewCheckBoxColumn.Width = 125;
            // 
            // personeljobDataGridViewTextBoxColumn
            // 
            this.personeljobDataGridViewTextBoxColumn.DataPropertyName = "Personel_job";
            this.personeljobDataGridViewTextBoxColumn.HeaderText = "Personel_job";
            this.personeljobDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.personeljobDataGridViewTextBoxColumn.Name = "personeljobDataGridViewTextBoxColumn";
            this.personeljobDataGridViewTextBoxColumn.Width = 125;
            // 
            // personeltableBindingSource
            // 
            this.personeltableBindingSource.DataMember = "Personel_table";
            this.personeltableBindingSource.DataSource = this.personel_DBDataSet1;
            // 
            // personel_DBDataSet1
            // 
            this.personel_DBDataSet1.DataSetName = "Personel_DBDataSet1";
            this.personel_DBDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // randomtableBindingSource
            // 
            this.randomtableBindingSource.DataMember = "random_table";
            this.randomtableBindingSource.DataSource = this.personel_DBDataSet2;
            // 
            // personel_DBDataSet2
            // 
            this.personel_DBDataSet2.DataSetName = "Personel_DBDataSet2";
            this.personel_DBDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // personel_tableTableAdapter
            // 
            this.personel_tableTableAdapter.ClearBeforeFill = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dataGridView1);
            this.groupBox3.Location = new System.Drawing.Point(12, 646);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(1083, 175);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Archieve";
            // 
            // random_tableTableAdapter
            // 
            this.random_tableTableAdapter.ClearBeforeFill = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSeaGreen;
            this.ClientSize = new System.Drawing.Size(1137, 1055);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Corbel", 12F);
            this.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.Name = "Form1";
            this.Text = "Registration";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.personeltableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.personel_DBDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.randomtableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.personel_DBDataSet2)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox TxtId;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox CmbCity;
        private System.Windows.Forms.MaskedTextBox MskSalary;
        private System.Windows.Forms.TextBox TxtJob;
        private System.Windows.Forms.TextBox TxtName;
        private System.Windows.Forms.TextBox TxtSurname;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnGraph;
        private System.Windows.Forms.Button BtnIstatistic;
        private System.Windows.Forms.Button BtnClear;
        private System.Windows.Forms.Button BtnUpdate;
        private System.Windows.Forms.Button BtnDelete;
        private System.Windows.Forms.Button BtnSave;
        private System.Windows.Forms.Button BtnList;
        private System.Windows.Forms.DataGridView dataGridView1;
        private Personel_DBDataSet1 personel_DBDataSet1;
        private System.Windows.Forms.BindingSource personeltableBindingSource;
        private Personel_DBDataSet1TableAdapters.Personel_tableTableAdapter personel_tableTableAdapter;
        private System.Windows.Forms.GroupBox groupBox3;
        private Personel_DBDataSet2 personel_DBDataSet2;
        private System.Windows.Forms.BindingSource randomtableBindingSource;
        private Personel_DBDataSet2TableAdapters.random_tableTableAdapter random_tableTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn personelidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn personelnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn personelsurnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn personelcityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn personelsalaryDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn personelstatusDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn personeljobDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label8;
    }
}

