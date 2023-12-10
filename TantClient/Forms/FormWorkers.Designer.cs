namespace TantClient.Forms
{
    partial class FormWorkers
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
            this.listBoxWorkers = new System.Windows.Forms.ListBox();
            this.labelWorkerChoose = new System.Windows.Forms.Label();
            this.panelWorkerChoose = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonDeleteWorker = new System.Windows.Forms.Button();
            this.buttonReward = new System.Windows.Forms.Button();
            this.buttonPenalty = new System.Windows.Forms.Button();
            this.richTextBoxChoosenWorker = new System.Windows.Forms.RichTextBox();
            this.labelWhatDo = new System.Windows.Forms.Label();
            this.buttonAddWorker = new System.Windows.Forms.Button();
            this.panelWorkerChoose.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // listBoxWorkers
            // 
            this.listBoxWorkers.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(218)))), ((int)(((byte)(224)))));
            this.listBoxWorkers.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listBoxWorkers.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.listBoxWorkers.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(47)))), ((int)(((byte)(51)))));
            this.listBoxWorkers.FormattingEnabled = true;
            this.listBoxWorkers.ItemHeight = 23;
            this.listBoxWorkers.Location = new System.Drawing.Point(17, 138);
            this.listBoxWorkers.Name = "listBoxWorkers";
            this.listBoxWorkers.Size = new System.Drawing.Size(390, 276);
            this.listBoxWorkers.TabIndex = 0;
            this.listBoxWorkers.SelectedIndexChanged += new System.EventHandler(this.listBoxWorkers_SelectedIndexChanged);
            // 
            // labelWorkerChoose
            // 
            this.labelWorkerChoose.AutoSize = true;
            this.labelWorkerChoose.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelWorkerChoose.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(47)))), ((int)(((byte)(51)))));
            this.labelWorkerChoose.Location = new System.Drawing.Point(12, 41);
            this.labelWorkerChoose.Name = "labelWorkerChoose";
            this.labelWorkerChoose.Size = new System.Drawing.Size(206, 25);
            this.labelWorkerChoose.TabIndex = 3;
            this.labelWorkerChoose.Text = "Выбор сотрудника:";
            // 
            // panelWorkerChoose
            // 
            this.panelWorkerChoose.Controls.Add(this.buttonAddWorker);
            this.panelWorkerChoose.Controls.Add(this.listBoxWorkers);
            this.panelWorkerChoose.Controls.Add(this.labelWorkerChoose);
            this.panelWorkerChoose.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelWorkerChoose.Location = new System.Drawing.Point(0, 0);
            this.panelWorkerChoose.Name = "panelWorkerChoose";
            this.panelWorkerChoose.Size = new System.Drawing.Size(451, 450);
            this.panelWorkerChoose.TabIndex = 4;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.buttonDeleteWorker);
            this.panel1.Controls.Add(this.buttonReward);
            this.panel1.Controls.Add(this.buttonPenalty);
            this.panel1.Controls.Add(this.richTextBoxChoosenWorker);
            this.panel1.Controls.Add(this.labelWhatDo);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(457, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(523, 450);
            this.panel1.TabIndex = 5;
            // 
            // buttonDeleteWorker
            // 
            this.buttonDeleteWorker.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(47)))), ((int)(((byte)(51)))));
            this.buttonDeleteWorker.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonDeleteWorker.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDeleteWorker.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonDeleteWorker.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.buttonDeleteWorker.Location = new System.Drawing.Point(289, 87);
            this.buttonDeleteWorker.Name = "buttonDeleteWorker";
            this.buttonDeleteWorker.Size = new System.Drawing.Size(152, 36);
            this.buttonDeleteWorker.TabIndex = 8;
            this.buttonDeleteWorker.Text = "Удалить";
            this.buttonDeleteWorker.UseVisualStyleBackColor = false;
            this.buttonDeleteWorker.Click += new System.EventHandler(this.buttonDeleteWorker_Click);
            // 
            // buttonReward
            // 
            this.buttonReward.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(47)))), ((int)(((byte)(51)))));
            this.buttonReward.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonReward.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonReward.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonReward.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.buttonReward.Location = new System.Drawing.Point(131, 87);
            this.buttonReward.Name = "buttonReward";
            this.buttonReward.Size = new System.Drawing.Size(152, 36);
            this.buttonReward.TabIndex = 7;
            this.buttonReward.Text = "Поощрение";
            this.buttonReward.UseVisualStyleBackColor = false;
            this.buttonReward.Click += new System.EventHandler(this.buttonReward_Click);
            // 
            // buttonPenalty
            // 
            this.buttonPenalty.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(47)))), ((int)(((byte)(51)))));
            this.buttonPenalty.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonPenalty.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonPenalty.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonPenalty.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.buttonPenalty.Location = new System.Drawing.Point(32, 87);
            this.buttonPenalty.Name = "buttonPenalty";
            this.buttonPenalty.Size = new System.Drawing.Size(93, 36);
            this.buttonPenalty.TabIndex = 6;
            this.buttonPenalty.Text = "Штраф";
            this.buttonPenalty.UseVisualStyleBackColor = false;
            this.buttonPenalty.Click += new System.EventHandler(this.buttonPenalty_Click);
            // 
            // richTextBoxChoosenWorker
            // 
            this.richTextBoxChoosenWorker.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(218)))), ((int)(((byte)(224)))));
            this.richTextBoxChoosenWorker.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBoxChoosenWorker.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.richTextBoxChoosenWorker.Location = new System.Drawing.Point(32, 129);
            this.richTextBoxChoosenWorker.Name = "richTextBoxChoosenWorker";
            this.richTextBoxChoosenWorker.ReadOnly = true;
            this.richTextBoxChoosenWorker.Size = new System.Drawing.Size(407, 223);
            this.richTextBoxChoosenWorker.TabIndex = 5;
            this.richTextBoxChoosenWorker.Text = "";
            // 
            // labelWhatDo
            // 
            this.labelWhatDo.AutoSize = true;
            this.labelWhatDo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelWhatDo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(47)))), ((int)(((byte)(51)))));
            this.labelWhatDo.Location = new System.Drawing.Point(27, 41);
            this.labelWhatDo.Name = "labelWhatDo";
            this.labelWhatDo.Size = new System.Drawing.Size(307, 25);
            this.labelWhatDo.TabIndex = 4;
            this.labelWhatDo.Text = "Что делаем с сотрудником?";
            // 
            // buttonAddWorker
            // 
            this.buttonAddWorker.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(47)))), ((int)(((byte)(51)))));
            this.buttonAddWorker.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonAddWorker.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAddWorker.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonAddWorker.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.buttonAddWorker.Location = new System.Drawing.Point(17, 87);
            this.buttonAddWorker.Name = "buttonAddWorker";
            this.buttonAddWorker.Size = new System.Drawing.Size(152, 36);
            this.buttonAddWorker.TabIndex = 9;
            this.buttonAddWorker.Text = "Добавить";
            this.buttonAddWorker.UseVisualStyleBackColor = false;
            this.buttonAddWorker.Click += new System.EventHandler(this.buttonAddWorker_Click);
            // 
            // FormWorkers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(218)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(980, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelWorkerChoose);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.HelpButton = true;
            this.Name = "FormWorkers";
            this.Text = "Сотрудники";
            this.panelWorkerChoose.ResumeLayout(false);
            this.panelWorkerChoose.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxWorkers;
        private System.Windows.Forms.Label labelWorkerChoose;
        private System.Windows.Forms.Panel panelWorkerChoose;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RichTextBox richTextBoxChoosenWorker;
        private System.Windows.Forms.Label labelWhatDo;
        private System.Windows.Forms.Button buttonReward;
        private System.Windows.Forms.Button buttonPenalty;
        private System.Windows.Forms.Button buttonDeleteWorker;
        private System.Windows.Forms.Button buttonAddWorker;
    }
}