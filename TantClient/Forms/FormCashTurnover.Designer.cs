namespace TantClient.Forms
{
    partial class FormCashTurnover
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnApplyCashTurnoverFilters = new System.Windows.Forms.Button();
            this.labelCashTurnoverTo = new System.Windows.Forms.Label();
            this.labelTurnoverPeriod = new System.Windows.Forms.Label();
            this.labelCashTurnoverFrom = new System.Windows.Forms.Label();
            this.dateTimePickerCashTurnoverFrom = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerCashTurnoverTo = new System.Windows.Forms.DateTimePicker();
            this.panel2 = new System.Windows.Forms.Panel();
            this.richTextBoxCashTurnover = new System.Windows.Forms.RichTextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnApplyCashTurnoverFilters);
            this.panel1.Controls.Add(this.labelCashTurnoverTo);
            this.panel1.Controls.Add(this.labelTurnoverPeriod);
            this.panel1.Controls.Add(this.labelCashTurnoverFrom);
            this.panel1.Controls.Add(this.dateTimePickerCashTurnoverFrom);
            this.panel1.Controls.Add(this.dateTimePickerCashTurnoverTo);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(722, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(313, 450);
            this.panel1.TabIndex = 0;
            // 
            // btnApplyCashTurnoverFilters
            // 
            this.btnApplyCashTurnoverFilters.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(47)))), ((int)(((byte)(51)))));
            this.btnApplyCashTurnoverFilters.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnApplyCashTurnoverFilters.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnApplyCashTurnoverFilters.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnApplyCashTurnoverFilters.Location = new System.Drawing.Point(8, 295);
            this.btnApplyCashTurnoverFilters.Name = "btnApplyCashTurnoverFilters";
            this.btnApplyCashTurnoverFilters.Size = new System.Drawing.Size(226, 52);
            this.btnApplyCashTurnoverFilters.TabIndex = 19;
            this.btnApplyCashTurnoverFilters.Text = "Применить фильтры";
            this.btnApplyCashTurnoverFilters.UseVisualStyleBackColor = false;
            this.btnApplyCashTurnoverFilters.Click += new System.EventHandler(this.btnApplyCashTurnoverFilters_Click);
            // 
            // labelCashTurnoverTo
            // 
            this.labelCashTurnoverTo.AutoSize = true;
            this.labelCashTurnoverTo.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelCashTurnoverTo.Location = new System.Drawing.Point(3, 172);
            this.labelCashTurnoverTo.Name = "labelCashTurnoverTo";
            this.labelCashTurnoverTo.Size = new System.Drawing.Size(94, 27);
            this.labelCashTurnoverTo.TabIndex = 18;
            this.labelCashTurnoverTo.Text = "Дата до:";
            // 
            // labelTurnoverPeriod
            // 
            this.labelTurnoverPeriod.AutoSize = true;
            this.labelTurnoverPeriod.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelTurnoverPeriod.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(47)))), ((int)(((byte)(51)))));
            this.labelTurnoverPeriod.Location = new System.Drawing.Point(3, 33);
            this.labelTurnoverPeriod.Name = "labelTurnoverPeriod";
            this.labelTurnoverPeriod.Size = new System.Drawing.Size(185, 27);
            this.labelTurnoverPeriod.TabIndex = 14;
            this.labelTurnoverPeriod.Text = "Задайте период:";
            // 
            // labelCashTurnoverFrom
            // 
            this.labelCashTurnoverFrom.AutoSize = true;
            this.labelCashTurnoverFrom.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelCashTurnoverFrom.Location = new System.Drawing.Point(6, 77);
            this.labelCashTurnoverFrom.Name = "labelCashTurnoverFrom";
            this.labelCashTurnoverFrom.Size = new System.Drawing.Size(91, 27);
            this.labelCashTurnoverFrom.TabIndex = 17;
            this.labelCashTurnoverFrom.Text = "Дата от:";
            // 
            // dateTimePickerCashTurnoverFrom
            // 
            this.dateTimePickerCashTurnoverFrom.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dateTimePickerCashTurnoverFrom.Location = new System.Drawing.Point(8, 125);
            this.dateTimePickerCashTurnoverFrom.Name = "dateTimePickerCashTurnoverFrom";
            this.dateTimePickerCashTurnoverFrom.Size = new System.Drawing.Size(226, 34);
            this.dateTimePickerCashTurnoverFrom.TabIndex = 15;
            this.dateTimePickerCashTurnoverFrom.Value = new System.DateTime(2023, 12, 1, 11, 23, 0, 0);
            // 
            // dateTimePickerCashTurnoverTo
            // 
            this.dateTimePickerCashTurnoverTo.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dateTimePickerCashTurnoverTo.Location = new System.Drawing.Point(8, 215);
            this.dateTimePickerCashTurnoverTo.Name = "dateTimePickerCashTurnoverTo";
            this.dateTimePickerCashTurnoverTo.Size = new System.Drawing.Size(226, 34);
            this.dateTimePickerCashTurnoverTo.TabIndex = 16;
            this.dateTimePickerCashTurnoverTo.Value = new System.DateTime(2023, 12, 31, 11, 24, 0, 0);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.richTextBoxCashTurnover);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(716, 450);
            this.panel2.TabIndex = 20;
            // 
            // richTextBoxCashTurnover
            // 
            this.richTextBoxCashTurnover.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(218)))), ((int)(((byte)(224)))));
            this.richTextBoxCashTurnover.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBoxCashTurnover.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.richTextBoxCashTurnover.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(47)))), ((int)(((byte)(51)))));
            this.richTextBoxCashTurnover.Location = new System.Drawing.Point(288, 53);
            this.richTextBoxCashTurnover.Name = "richTextBoxCashTurnover";
            this.richTextBoxCashTurnover.Size = new System.Drawing.Size(425, 385);
            this.richTextBoxCashTurnover.TabIndex = 22;
            this.richTextBoxCashTurnover.Text = "";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::TantClient.Properties.Resources.ruble;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(270, 314);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 21;
            this.pictureBox1.TabStop = false;
            // 
            // FormCashTurnover
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(218)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(1035, 450);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "FormCashTurnover";
            this.Text = "Оборот проекта";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnApplyCashTurnoverFilters;
        private System.Windows.Forms.DateTimePicker dateTimePickerCashTurnoverFrom;
        private System.Windows.Forms.Label labelCashTurnoverTo;
        private System.Windows.Forms.DateTimePicker dateTimePickerCashTurnoverTo;
        private System.Windows.Forms.Label labelCashTurnoverFrom;
        private System.Windows.Forms.Label labelTurnoverPeriod;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.RichTextBox richTextBoxCashTurnover;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}