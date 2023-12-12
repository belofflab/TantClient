namespace TantClient.Forms
{
    partial class FormAnalytics
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxWorkerLink = new System.Windows.Forms.TextBox();
            this.dateTimePickerFrom = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerTo = new System.Windows.Forms.DateTimePicker();
            this.labelFrom = new System.Windows.Forms.Label();
            this.labelTo = new System.Windows.Forms.Label();
            this.btnApplyFilters = new System.Windows.Forms.Button();
            this.richTextBoxResult = new System.Windows.Forms.RichTextBox();
            this.panelWorkerLink = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.buttonTrafficGo = new System.Windows.Forms.Button();
            this.dateTimePickerTrafficTo = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerTrafficFrom = new System.Windows.Forms.DateTimePicker();
            this.labelUserTraffics = new System.Windows.Forms.Label();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.panelWorkerLink.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(47)))), ((int)(((byte)(51)))));
            this.label1.Location = new System.Drawing.Point(17, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(445, 27);
            this.label1.TabIndex = 0;
            this.label1.Text = "Анализ переходов по ссылке сотрудника";
            // 
            // textBoxWorkerLink
            // 
            this.textBoxWorkerLink.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(218)))), ((int)(((byte)(224)))));
            this.textBoxWorkerLink.Font = new System.Drawing.Font("Microsoft YaHei", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxWorkerLink.ForeColor = System.Drawing.Color.Black;
            this.textBoxWorkerLink.Location = new System.Drawing.Point(23, 88);
            this.textBoxWorkerLink.MaxLength = 255;
            this.textBoxWorkerLink.Name = "textBoxWorkerLink";
            this.textBoxWorkerLink.Size = new System.Drawing.Size(352, 38);
            this.textBoxWorkerLink.TabIndex = 1;
            this.textBoxWorkerLink.Text = "?start=sasha_tarolog";
            // 
            // dateTimePickerFrom
            // 
            this.dateTimePickerFrom.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dateTimePickerFrom.Location = new System.Drawing.Point(406, 121);
            this.dateTimePickerFrom.Name = "dateTimePickerFrom";
            this.dateTimePickerFrom.Size = new System.Drawing.Size(226, 34);
            this.dateTimePickerFrom.TabIndex = 2;
            this.dateTimePickerFrom.Value = new System.DateTime(2023, 12, 1, 11, 23, 0, 0);
            // 
            // dateTimePickerTo
            // 
            this.dateTimePickerTo.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dateTimePickerTo.Location = new System.Drawing.Point(406, 211);
            this.dateTimePickerTo.Name = "dateTimePickerTo";
            this.dateTimePickerTo.Size = new System.Drawing.Size(226, 34);
            this.dateTimePickerTo.TabIndex = 3;
            this.dateTimePickerTo.Value = new System.DateTime(2023, 12, 31, 11, 24, 0, 0);
            // 
            // labelFrom
            // 
            this.labelFrom.AutoSize = true;
            this.labelFrom.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelFrom.Location = new System.Drawing.Point(401, 91);
            this.labelFrom.Name = "labelFrom";
            this.labelFrom.Size = new System.Drawing.Size(91, 27);
            this.labelFrom.TabIndex = 4;
            this.labelFrom.Text = "Дата от:";
            // 
            // labelTo
            // 
            this.labelTo.AutoSize = true;
            this.labelTo.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelTo.Location = new System.Drawing.Point(406, 181);
            this.labelTo.Name = "labelTo";
            this.labelTo.Size = new System.Drawing.Size(94, 27);
            this.labelTo.TabIndex = 5;
            this.labelTo.Text = "Дата до:";
            // 
            // btnApplyFilters
            // 
            this.btnApplyFilters.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(47)))), ((int)(((byte)(51)))));
            this.btnApplyFilters.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnApplyFilters.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnApplyFilters.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnApplyFilters.Location = new System.Drawing.Point(406, 291);
            this.btnApplyFilters.Name = "btnApplyFilters";
            this.btnApplyFilters.Size = new System.Drawing.Size(226, 52);
            this.btnApplyFilters.TabIndex = 6;
            this.btnApplyFilters.Text = "Применить фильтры";
            this.btnApplyFilters.UseVisualStyleBackColor = false;
            this.btnApplyFilters.Click += new System.EventHandler(this.btnApplyFilters_Click);
            // 
            // richTextBoxResult
            // 
            this.richTextBoxResult.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(218)))), ((int)(((byte)(224)))));
            this.richTextBoxResult.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBoxResult.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.richTextBoxResult.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(47)))), ((int)(((byte)(51)))));
            this.richTextBoxResult.Location = new System.Drawing.Point(22, 143);
            this.richTextBoxResult.Name = "richTextBoxResult";
            this.richTextBoxResult.ReadOnly = true;
            this.richTextBoxResult.Size = new System.Drawing.Size(353, 271);
            this.richTextBoxResult.TabIndex = 7;
            this.richTextBoxResult.Text = "Здесь будет выведен результат запроса...";
            // 
            // panelWorkerLink
            // 
            this.panelWorkerLink.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panelWorkerLink.Controls.Add(this.label1);
            this.panelWorkerLink.Controls.Add(this.richTextBoxResult);
            this.panelWorkerLink.Controls.Add(this.textBoxWorkerLink);
            this.panelWorkerLink.Controls.Add(this.btnApplyFilters);
            this.panelWorkerLink.Controls.Add(this.dateTimePickerFrom);
            this.panelWorkerLink.Controls.Add(this.labelTo);
            this.panelWorkerLink.Controls.Add(this.dateTimePickerTo);
            this.panelWorkerLink.Controls.Add(this.labelFrom);
            this.panelWorkerLink.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelWorkerLink.Location = new System.Drawing.Point(0, 0);
            this.panelWorkerLink.Name = "panelWorkerLink";
            this.panelWorkerLink.Size = new System.Drawing.Size(637, 697);
            this.panelWorkerLink.TabIndex = 8;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.buttonTrafficGo);
            this.panel2.Controls.Add(this.dateTimePickerTrafficTo);
            this.panel2.Controls.Add(this.dateTimePickerTrafficFrom);
            this.panel2.Controls.Add(this.labelUserTraffics);
            this.panel2.Controls.Add(this.chart1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(637, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(623, 697);
            this.panel2.TabIndex = 9;
            // 
            // buttonTrafficGo
            // 
            this.buttonTrafficGo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(47)))), ((int)(((byte)(51)))));
            this.buttonTrafficGo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonTrafficGo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonTrafficGo.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.buttonTrafficGo.Location = new System.Drawing.Point(477, 87);
            this.buttonTrafficGo.Name = "buttonTrafficGo";
            this.buttonTrafficGo.Size = new System.Drawing.Size(75, 35);
            this.buttonTrafficGo.TabIndex = 5;
            this.buttonTrafficGo.Text = ">";
            this.buttonTrafficGo.UseVisualStyleBackColor = false;
            this.buttonTrafficGo.Click += new System.EventHandler(this.buttonTrafficGo_Click);
            // 
            // dateTimePickerTrafficTo
            // 
            this.dateTimePickerTrafficTo.CalendarFont = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dateTimePickerTrafficTo.Location = new System.Drawing.Point(258, 93);
            this.dateTimePickerTrafficTo.Name = "dateTimePickerTrafficTo";
            this.dateTimePickerTrafficTo.Size = new System.Drawing.Size(200, 22);
            this.dateTimePickerTrafficTo.TabIndex = 4;
            // 
            // dateTimePickerTrafficFrom
            // 
            this.dateTimePickerTrafficFrom.CalendarFont = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dateTimePickerTrafficFrom.Location = new System.Drawing.Point(43, 93);
            this.dateTimePickerTrafficFrom.Name = "dateTimePickerTrafficFrom";
            this.dateTimePickerTrafficFrom.Size = new System.Drawing.Size(200, 22);
            this.dateTimePickerTrafficFrom.TabIndex = 3;
            // 
            // labelUserTraffics
            // 
            this.labelUserTraffics.AutoSize = true;
            this.labelUserTraffics.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelUserTraffics.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(47)))), ((int)(((byte)(51)))));
            this.labelUserTraffics.Location = new System.Drawing.Point(38, 32);
            this.labelUserTraffics.Name = "labelUserTraffics";
            this.labelUserTraffics.Size = new System.Drawing.Size(395, 27);
            this.labelUserTraffics.TabIndex = 2;
            this.labelUserTraffics.Text = "Анализ эффективности сотрудников";
            // 
            // chart1
            // 
            this.chart1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(218)))), ((int)(((byte)(224)))));
            chartArea2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(218)))), ((int)(((byte)(224)))));
            chartArea2.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea2);
            legend2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(218)))), ((int)(((byte)(224)))));
            legend2.Name = "Legend1";
            this.chart1.Legends.Add(legend2);
            this.chart1.Location = new System.Drawing.Point(43, 143);
            this.chart1.Name = "chart1";
            this.chart1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.SeaGreen;
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Doughnut;
            series2.Legend = "Legend1";
            series2.Name = "SeriesWorkers";
            this.chart1.Series.Add(series2);
            this.chart1.Size = new System.Drawing.Size(509, 300);
            this.chart1.TabIndex = 1;
            this.chart1.Text = "chartWorkers";
            // 
            // FormAnalytics
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(218)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(1347, 697);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panelWorkerLink);
            this.Name = "FormAnalytics";
            this.Text = "Аналитика";
            this.panelWorkerLink.ResumeLayout(false);
            this.panelWorkerLink.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxWorkerLink;
        private System.Windows.Forms.DateTimePicker dateTimePickerFrom;
        private System.Windows.Forms.DateTimePicker dateTimePickerTo;
        private System.Windows.Forms.Label labelFrom;
        private System.Windows.Forms.Label labelTo;
        private System.Windows.Forms.Button btnApplyFilters;
        private System.Windows.Forms.RichTextBox richTextBoxResult;
        private System.Windows.Forms.Panel panelWorkerLink;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Button buttonTrafficGo;
        private System.Windows.Forms.DateTimePicker dateTimePickerTrafficTo;
        private System.Windows.Forms.DateTimePicker dateTimePickerTrafficFrom;
        private System.Windows.Forms.Label labelUserTraffics;
    }
}