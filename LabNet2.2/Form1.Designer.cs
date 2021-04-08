
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
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(42, 39);
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
            this.listView1.Location = new System.Drawing.Point(42, 107);
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
            this.label1.Location = new System.Drawing.Point(372, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "Choose Currency";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // textBoxRateOfThisCurrency
            // 
            this.textBoxRateOfThisCurrency.Location = new System.Drawing.Point(508, 53);
            this.textBoxRateOfThisCurrency.Name = "textBoxRateOfThisCurrency";
            this.textBoxRateOfThisCurrency.Size = new System.Drawing.Size(172, 22);
            this.textBoxRateOfThisCurrency.TabIndex = 6;
            this.textBoxRateOfThisCurrency.TextChanged += new System.EventHandler(this.textBoxRateOfThisCurrency_TextChanged);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(689, 51);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(191, 22);
            this.textBox1.TabIndex = 7;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged_1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(686, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(194, 17);
            this.label2.TabIndex = 8;
            this.label2.Text = "Amount of currency (to Write)";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(516, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(164, 17);
            this.label3.TabIndex = 9;
            this.label3.Text = "Selected Currency Value";
            // 
            // textBoxResultOfCalculating
            // 
            this.textBoxResultOfCalculating.Location = new System.Drawing.Point(914, 51);
            this.textBoxResultOfCalculating.Name = "textBoxResultOfCalculating";
            this.textBoxResultOfCalculating.Size = new System.Drawing.Size(94, 22);
            this.textBoxResultOfCalculating.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(911, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 17);
            this.label4.TabIndex = 11;
            this.label4.Text = "Result";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(416, 164);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 17);
            this.label5.TabIndex = 12;
            this.label5.Text = "label5";
            this.label5.Click += new System.EventHandler(this.label5_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.label5);
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
        private System.Windows.Forms.Label label5;
    }
}

