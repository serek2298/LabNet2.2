
namespace LabNet2._2
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
            this.button1 = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.country = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.value = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.comboBoxChooseCurrency = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxRateOfThisCurrency = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxResultOfCalculating = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.buttonSaveToDataBase = new System.Windows.Forms.Button();
            this.textBoxShowLog = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxtimeStamp = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.buttonToShowHistory = new System.Windows.Forms.Button();
            this.recordsCurrencyExchangeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.recordsCurrencyExchangeBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.form1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.singleCurrencyExchangeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.timeStampDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameOfCurrencyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.exchangeRateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.amountToExchangeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.resultOfCalculatingDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.recordsCurrencyExchangeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.recordsCurrencyExchangeBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.form1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.singleCurrencyExchangeBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(42, 9);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(256, 47);
            this.button1.TabIndex = 1;
            this.button1.Text = "Search Data";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.country,
            this.value});
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(42, 148);
            this.listView1.Margin = new System.Windows.Forms.Padding(4);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(248, 382);
            this.listView1.TabIndex = 2;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // country
            // 
            this.country.Text = "Country";
            this.country.Width = 64;
            // 
            // value
            // 
            this.value.Text = "Value";
            this.value.Width = 119;
            // 
            // comboBoxChooseCurrency
            // 
            this.comboBoxChooseCurrency.FormattingEnabled = true;
            this.comboBoxChooseCurrency.Location = new System.Drawing.Point(368, 51);
            this.comboBoxChooseCurrency.Name = "comboBoxChooseCurrency";
            this.comboBoxChooseCurrency.Size = new System.Drawing.Size(121, 24);
            this.comboBoxChooseCurrency.TabIndex = 4;
            this.comboBoxChooseCurrency.SelectedIndexChanged += new System.EventHandler(this.comboBoxChooseCurrency_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(365, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "Choose Currency";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // textBoxRateOfThisCurrency
            // 
            this.textBoxRateOfThisCurrency.Location = new System.Drawing.Point(495, 51);
            this.textBoxRateOfThisCurrency.Name = "textBoxRateOfThisCurrency";
            this.textBoxRateOfThisCurrency.Size = new System.Drawing.Size(172, 22);
            this.textBoxRateOfThisCurrency.TabIndex = 6;
            this.textBoxRateOfThisCurrency.TextChanged += new System.EventHandler(this.textBoxRateOfThisCurrency_TextChanged);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(673, 51);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(191, 22);
            this.textBox1.TabIndex = 7;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged_1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(670, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(194, 17);
            this.label2.TabIndex = 8;
            this.label2.Text = "Amount of currency (to Write)";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(492, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(164, 17);
            this.label3.TabIndex = 9;
            this.label3.Text = "Selected Currency Value";
            // 
            // textBoxResultOfCalculating
            // 
            this.textBoxResultOfCalculating.Location = new System.Drawing.Point(870, 51);
            this.textBoxResultOfCalculating.Name = "textBoxResultOfCalculating";
            this.textBoxResultOfCalculating.Size = new System.Drawing.Size(94, 22);
            this.textBoxResultOfCalculating.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(870, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 17);
            this.label4.TabIndex = 11;
            this.label4.Text = "Result";
            // 
            // buttonSaveToDataBase
            // 
            this.buttonSaveToDataBase.Location = new System.Drawing.Point(368, 98);
            this.buttonSaveToDataBase.Name = "buttonSaveToDataBase";
            this.buttonSaveToDataBase.Size = new System.Drawing.Size(288, 104);
            this.buttonSaveToDataBase.TabIndex = 12;
            this.buttonSaveToDataBase.Text = "Save to DataBase";
            this.buttonSaveToDataBase.UseVisualStyleBackColor = true;
            this.buttonSaveToDataBase.Click += new System.EventHandler(this.buttonSaveToDataBase_Click);
            // 
            // textBoxShowLog
            // 
            this.textBoxShowLog.Location = new System.Drawing.Point(396, 252);
            this.textBoxShowLog.Name = "textBoxShowLog";
            this.textBoxShowLog.Size = new System.Drawing.Size(536, 22);
            this.textBoxShowLog.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(42, 64);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 17);
            this.label5.TabIndex = 14;
            this.label5.Text = "Time Stamp";
            // 
            // textBoxtimeStamp
            // 
            this.textBoxtimeStamp.Location = new System.Drawing.Point(42, 98);
            this.textBoxtimeStamp.Name = "textBoxtimeStamp";
            this.textBoxtimeStamp.Size = new System.Drawing.Size(245, 22);
            this.textBoxtimeStamp.TabIndex = 15;
            this.textBoxtimeStamp.TextChanged += new System.EventHandler(this.textBoxtimeStamp_TextChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.timeStampDataGridViewTextBoxColumn,
            this.nameOfCurrencyDataGridViewTextBoxColumn,
            this.exchangeRateDataGridViewTextBoxColumn,
            this.amountToExchangeDataGridViewTextBoxColumn,
            this.resultOfCalculatingDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.singleCurrencyExchangeBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(396, 293);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(620, 210);
            this.dataGridView1.TabIndex = 16;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // buttonToShowHistory
            // 
            this.buttonToShowHistory.Location = new System.Drawing.Point(677, 98);
            this.buttonToShowHistory.Name = "buttonToShowHistory";
            this.buttonToShowHistory.Size = new System.Drawing.Size(287, 104);
            this.buttonToShowHistory.TabIndex = 17;
            this.buttonToShowHistory.Text = "Show History";
            this.buttonToShowHistory.UseVisualStyleBackColor = true;
            this.buttonToShowHistory.Click += new System.EventHandler(this.buttonToShowHistory_Click);
            // 
            // recordsCurrencyExchangeBindingSource
            // 
            this.recordsCurrencyExchangeBindingSource.DataSource = typeof(LabNet2._2.RecordsCurrencyExchange);
            // 
            // recordsCurrencyExchangeBindingSource1
            // 
            this.recordsCurrencyExchangeBindingSource1.DataSource = typeof(LabNet2._2.RecordsCurrencyExchange);
            // 
            // form1BindingSource
            // 
            this.form1BindingSource.DataSource = typeof(LabNet2._2.Form1);
            // 
            // singleCurrencyExchangeBindingSource
            // 
            this.singleCurrencyExchangeBindingSource.DataSource = typeof(LabNet2._2.SingleCurrencyExchange);
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            this.iDDataGridViewTextBoxColumn.ReadOnly = true;
            this.iDDataGridViewTextBoxColumn.Width = 125;
            // 
            // timeStampDataGridViewTextBoxColumn
            // 
            this.timeStampDataGridViewTextBoxColumn.DataPropertyName = "timeStamp";
            this.timeStampDataGridViewTextBoxColumn.HeaderText = "timeStamp";
            this.timeStampDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.timeStampDataGridViewTextBoxColumn.Name = "timeStampDataGridViewTextBoxColumn";
            this.timeStampDataGridViewTextBoxColumn.ReadOnly = true;
            this.timeStampDataGridViewTextBoxColumn.Width = 125;
            // 
            // nameOfCurrencyDataGridViewTextBoxColumn
            // 
            this.nameOfCurrencyDataGridViewTextBoxColumn.DataPropertyName = "nameOfCurrency";
            this.nameOfCurrencyDataGridViewTextBoxColumn.HeaderText = "nameOfCurrency";
            this.nameOfCurrencyDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nameOfCurrencyDataGridViewTextBoxColumn.Name = "nameOfCurrencyDataGridViewTextBoxColumn";
            this.nameOfCurrencyDataGridViewTextBoxColumn.ReadOnly = true;
            this.nameOfCurrencyDataGridViewTextBoxColumn.Width = 125;
            // 
            // exchangeRateDataGridViewTextBoxColumn
            // 
            this.exchangeRateDataGridViewTextBoxColumn.DataPropertyName = "exchangeRate";
            this.exchangeRateDataGridViewTextBoxColumn.HeaderText = "exchangeRate";
            this.exchangeRateDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.exchangeRateDataGridViewTextBoxColumn.Name = "exchangeRateDataGridViewTextBoxColumn";
            this.exchangeRateDataGridViewTextBoxColumn.ReadOnly = true;
            this.exchangeRateDataGridViewTextBoxColumn.Width = 125;
            // 
            // amountToExchangeDataGridViewTextBoxColumn
            // 
            this.amountToExchangeDataGridViewTextBoxColumn.DataPropertyName = "amountToExchange";
            this.amountToExchangeDataGridViewTextBoxColumn.HeaderText = "amountToExchange";
            this.amountToExchangeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.amountToExchangeDataGridViewTextBoxColumn.Name = "amountToExchangeDataGridViewTextBoxColumn";
            this.amountToExchangeDataGridViewTextBoxColumn.ReadOnly = true;
            this.amountToExchangeDataGridViewTextBoxColumn.Width = 125;
            // 
            // resultOfCalculatingDataGridViewTextBoxColumn
            // 
            this.resultOfCalculatingDataGridViewTextBoxColumn.DataPropertyName = "resultOfCalculating";
            this.resultOfCalculatingDataGridViewTextBoxColumn.HeaderText = "resultOfCalculating";
            this.resultOfCalculatingDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.resultOfCalculatingDataGridViewTextBoxColumn.Name = "resultOfCalculatingDataGridViewTextBoxColumn";
            this.resultOfCalculatingDataGridViewTextBoxColumn.ReadOnly = true;
            this.resultOfCalculatingDataGridViewTextBoxColumn.Width = 125;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.buttonToShowHistory);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.textBoxtimeStamp);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBoxShowLog);
            this.Controls.Add(this.buttonSaveToDataBase);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxResultOfCalculating);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.textBoxRateOfThisCurrency);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBoxChooseCurrency);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.button1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.recordsCurrencyExchangeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.recordsCurrencyExchangeBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.form1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.singleCurrencyExchangeBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader country;
        private System.Windows.Forms.ColumnHeader value;
        private System.Windows.Forms.ComboBox comboBoxChooseCurrency;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxRateOfThisCurrency;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxResultOfCalculating;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button buttonSaveToDataBase;
        private System.Windows.Forms.TextBox textBoxShowLog;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxtimeStamp;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button buttonToShowHistory;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn timeStampDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameOfCurrencyDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn exchangeRateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn amountToExchangeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn resultOfCalculatingDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource singleCurrencyExchangeBindingSource;
        private System.Windows.Forms.BindingSource recordsCurrencyExchangeBindingSource;
        private System.Windows.Forms.BindingSource recordsCurrencyExchangeBindingSource1;
        private System.Windows.Forms.BindingSource form1BindingSource;
    }
}

