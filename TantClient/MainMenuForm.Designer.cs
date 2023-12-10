namespace TantClient
{
    partial class TantClient
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TantClient));
            this.panelMenu = new System.Windows.Forms.Panel();
            this.panelDevelopedBy = new System.Windows.Forms.Panel();
            this.labelDevelopedBy = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonSettings = new System.Windows.Forms.Button();
            this.buttonWorkers = new System.Windows.Forms.Button();
            this.buttonTurnover = new System.Windows.Forms.Button();
            this.buttonAnalytics = new System.Windows.Forms.Button();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.labelLogo = new System.Windows.Forms.Label();
            this.panelHeader = new System.Windows.Forms.Panel();
            this.btnCloseChildForm = new System.Windows.Forms.Button();
            this.labelHeader = new System.Windows.Forms.Label();
            this.panelDesktopPanel = new System.Windows.Forms.Panel();
            this.labelUpdateBaseInfo = new System.Windows.Forms.Label();
            this.buttonUpdateBaseInfo = new System.Windows.Forms.Button();
            this.richTextBoxInfo = new System.Windows.Forms.RichTextBox();
            this.richTextBoxPaymentDetails = new System.Windows.Forms.RichTextBox();
            this.labelPaymentDetails = new System.Windows.Forms.Label();
            this.richTextBoxWorkers = new System.Windows.Forms.RichTextBox();
            this.labelWorkers = new System.Windows.Forms.Label();
            this.richTextBoxBaseInfo = new System.Windows.Forms.RichTextBox();
            this.labelBaseInfo = new System.Windows.Forms.Label();
            this.panelMenu.SuspendLayout();
            this.panelDevelopedBy.SuspendLayout();
            this.panelLogo.SuspendLayout();
            this.panelHeader.SuspendLayout();
            this.panelDesktopPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(66)))), ((int)(((byte)(71)))));
            this.panelMenu.Controls.Add(this.panelDevelopedBy);
            this.panelMenu.Controls.Add(this.buttonSettings);
            this.panelMenu.Controls.Add(this.buttonWorkers);
            this.panelMenu.Controls.Add(this.buttonTurnover);
            this.panelMenu.Controls.Add(this.buttonAnalytics);
            this.panelMenu.Controls.Add(this.panelLogo);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(220, 1055);
            this.panelMenu.TabIndex = 0;
            // 
            // panelDevelopedBy
            // 
            this.panelDevelopedBy.Controls.Add(this.labelDevelopedBy);
            this.panelDevelopedBy.Controls.Add(this.label1);
            this.panelDevelopedBy.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelDevelopedBy.Location = new System.Drawing.Point(0, 955);
            this.panelDevelopedBy.Name = "panelDevelopedBy";
            this.panelDevelopedBy.Size = new System.Drawing.Size(220, 100);
            this.panelDevelopedBy.TabIndex = 7;
            // 
            // labelDevelopedBy
            // 
            this.labelDevelopedBy.AutoSize = true;
            this.labelDevelopedBy.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.labelDevelopedBy.Location = new System.Drawing.Point(27, 43);
            this.labelDevelopedBy.Name = "labelDevelopedBy";
            this.labelDevelopedBy.Size = new System.Drawing.Size(96, 16);
            this.labelDevelopedBy.TabIndex = 5;
            this.labelDevelopedBy.Text = "Developed by:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label1.Location = new System.Drawing.Point(127, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 16);
            this.label1.TabIndex = 6;
            this.label1.Text = "@belofflab";
            // 
            // buttonSettings
            // 
            this.buttonSettings.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(103)))), ((int)(((byte)(122)))));
            this.buttonSettings.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonSettings.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonSettings.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonSettings.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.buttonSettings.Location = new System.Drawing.Point(0, 310);
            this.buttonSettings.Name = "buttonSettings";
            this.buttonSettings.Size = new System.Drawing.Size(220, 70);
            this.buttonSettings.TabIndex = 4;
            this.buttonSettings.Text = "Настройки (inDev)";
            this.buttonSettings.UseVisualStyleBackColor = false;
            this.buttonSettings.Click += new System.EventHandler(this.buttonSettings_Click);
            // 
            // buttonWorkers
            // 
            this.buttonWorkers.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(103)))), ((int)(((byte)(122)))));
            this.buttonWorkers.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonWorkers.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonWorkers.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonWorkers.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.buttonWorkers.Location = new System.Drawing.Point(0, 240);
            this.buttonWorkers.Name = "buttonWorkers";
            this.buttonWorkers.Size = new System.Drawing.Size(220, 70);
            this.buttonWorkers.TabIndex = 3;
            this.buttonWorkers.Text = "Сотрудники";
            this.buttonWorkers.UseVisualStyleBackColor = false;
            this.buttonWorkers.Click += new System.EventHandler(this.buttonWorkers_Click);
            // 
            // buttonTurnover
            // 
            this.buttonTurnover.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(103)))), ((int)(((byte)(122)))));
            this.buttonTurnover.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonTurnover.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonTurnover.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonTurnover.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.buttonTurnover.Location = new System.Drawing.Point(0, 170);
            this.buttonTurnover.Name = "buttonTurnover";
            this.buttonTurnover.Size = new System.Drawing.Size(220, 70);
            this.buttonTurnover.TabIndex = 2;
            this.buttonTurnover.Text = "Оборот";
            this.buttonTurnover.UseVisualStyleBackColor = false;
            this.buttonTurnover.Click += new System.EventHandler(this.buttonTurnover_Click);
            // 
            // buttonAnalytics
            // 
            this.buttonAnalytics.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(103)))), ((int)(((byte)(122)))));
            this.buttonAnalytics.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonAnalytics.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonAnalytics.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonAnalytics.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.buttonAnalytics.Location = new System.Drawing.Point(0, 100);
            this.buttonAnalytics.Name = "buttonAnalytics";
            this.buttonAnalytics.Size = new System.Drawing.Size(220, 70);
            this.buttonAnalytics.TabIndex = 1;
            this.buttonAnalytics.Text = "Аналитика";
            this.buttonAnalytics.UseVisualStyleBackColor = false;
            this.buttonAnalytics.Click += new System.EventHandler(this.buttonAnalytics_Click);
            // 
            // panelLogo
            // 
            this.panelLogo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(47)))), ((int)(((byte)(51)))));
            this.panelLogo.Controls.Add(this.labelLogo);
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(220, 100);
            this.panelLogo.TabIndex = 0;
            // 
            // labelLogo
            // 
            this.labelLogo.AutoSize = true;
            this.labelLogo.BackColor = System.Drawing.Color.Transparent;
            this.labelLogo.Font = new System.Drawing.Font("Microsoft YaHei", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelLogo.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.labelLogo.Location = new System.Drawing.Point(24, 33);
            this.labelLogo.Name = "labelLogo";
            this.labelLogo.Size = new System.Drawing.Size(176, 36);
            this.labelLogo.TabIndex = 0;
            this.labelLogo.Text = "Tant Service";
            this.labelLogo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelHeader
            // 
            this.panelHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(66)))), ((int)(((byte)(71)))));
            this.panelHeader.Controls.Add(this.btnCloseChildForm);
            this.panelHeader.Controls.Add(this.labelHeader);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Location = new System.Drawing.Point(220, 0);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(1262, 100);
            this.panelHeader.TabIndex = 1;
            this.panelHeader.Paint += new System.Windows.Forms.PaintEventHandler(this.panelHeader_Paint);
            this.panelHeader.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelHeader_MouseDown);
            // 
            // btnCloseChildForm
            // 
            this.btnCloseChildForm.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnCloseChildForm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCloseChildForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnCloseChildForm.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnCloseChildForm.Location = new System.Drawing.Point(0, 0);
            this.btnCloseChildForm.Name = "btnCloseChildForm";
            this.btnCloseChildForm.Size = new System.Drawing.Size(75, 100);
            this.btnCloseChildForm.TabIndex = 1;
            this.btnCloseChildForm.Text = "<";
            this.btnCloseChildForm.UseVisualStyleBackColor = true;
            this.btnCloseChildForm.Click += new System.EventHandler(this.btnCloseChildForm_Click);
            // 
            // labelHeader
            // 
            this.labelHeader.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelHeader.AutoSize = true;
            this.labelHeader.Font = new System.Drawing.Font("Microsoft YaHei", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelHeader.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.labelHeader.Location = new System.Drawing.Point(100, 33);
            this.labelHeader.Name = "labelHeader";
            this.labelHeader.Size = new System.Drawing.Size(489, 36);
            this.labelHeader.TabIndex = 0;
            this.labelHeader.Text = "Основная информация о проекте";
            this.labelHeader.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelDesktopPanel
            // 
            this.panelDesktopPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(218)))), ((int)(((byte)(224)))));
            this.panelDesktopPanel.Controls.Add(this.labelUpdateBaseInfo);
            this.panelDesktopPanel.Controls.Add(this.buttonUpdateBaseInfo);
            this.panelDesktopPanel.Controls.Add(this.richTextBoxInfo);
            this.panelDesktopPanel.Controls.Add(this.richTextBoxPaymentDetails);
            this.panelDesktopPanel.Controls.Add(this.labelPaymentDetails);
            this.panelDesktopPanel.Controls.Add(this.richTextBoxWorkers);
            this.panelDesktopPanel.Controls.Add(this.labelWorkers);
            this.panelDesktopPanel.Controls.Add(this.richTextBoxBaseInfo);
            this.panelDesktopPanel.Controls.Add(this.labelBaseInfo);
            this.panelDesktopPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDesktopPanel.Location = new System.Drawing.Point(220, 100);
            this.panelDesktopPanel.Name = "panelDesktopPanel";
            this.panelDesktopPanel.Size = new System.Drawing.Size(1262, 955);
            this.panelDesktopPanel.TabIndex = 2;
            this.panelDesktopPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.panelDesktopPanel_Paint);
            // 
            // labelUpdateBaseInfo
            // 
            this.labelUpdateBaseInfo.AutoSize = true;
            this.labelUpdateBaseInfo.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelUpdateBaseInfo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(47)))), ((int)(((byte)(51)))));
            this.labelUpdateBaseInfo.Location = new System.Drawing.Point(979, 25);
            this.labelUpdateBaseInfo.Name = "labelUpdateBaseInfo";
            this.labelUpdateBaseInfo.Size = new System.Drawing.Size(168, 23);
            this.labelUpdateBaseInfo.TabIndex = 8;
            this.labelUpdateBaseInfo.Text = "Обновить данные:";
            // 
            // buttonUpdateBaseInfo
            // 
            this.buttonUpdateBaseInfo.BackColor = System.Drawing.Color.Transparent;
            this.buttonUpdateBaseInfo.BackgroundImage = global::TantClient.Properties.Resources.upico;
            this.buttonUpdateBaseInfo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonUpdateBaseInfo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonUpdateBaseInfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonUpdateBaseInfo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(218)))), ((int)(((byte)(224)))));
            this.buttonUpdateBaseInfo.Location = new System.Drawing.Point(1167, 22);
            this.buttonUpdateBaseInfo.Name = "buttonUpdateBaseInfo";
            this.buttonUpdateBaseInfo.Size = new System.Drawing.Size(35, 33);
            this.buttonUpdateBaseInfo.TabIndex = 7;
            this.buttonUpdateBaseInfo.UseVisualStyleBackColor = false;
            this.buttonUpdateBaseInfo.Click += new System.EventHandler(this.buttonUpdateBaseInfo_Click);
            // 
            // richTextBoxInfo
            // 
            this.richTextBoxInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(218)))), ((int)(((byte)(224)))));
            this.richTextBoxInfo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBoxInfo.Cursor = System.Windows.Forms.Cursors.Default;
            this.richTextBoxInfo.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.richTextBoxInfo.Font = new System.Drawing.Font("Microsoft YaHei", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.richTextBoxInfo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(66)))), ((int)(((byte)(71)))));
            this.richTextBoxInfo.Location = new System.Drawing.Point(0, 826);
            this.richTextBoxInfo.Margin = new System.Windows.Forms.Padding(13, 13, 13, 3);
            this.richTextBoxInfo.Name = "richTextBoxInfo";
            this.richTextBoxInfo.ReadOnly = true;
            this.richTextBoxInfo.Size = new System.Drawing.Size(1262, 129);
            this.richTextBoxInfo.TabIndex = 6;
            this.richTextBoxInfo.Text = resources.GetString("richTextBoxInfo.Text");
            // 
            // richTextBoxPaymentDetails
            // 
            this.richTextBoxPaymentDetails.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(218)))), ((int)(((byte)(224)))));
            this.richTextBoxPaymentDetails.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBoxPaymentDetails.Cursor = System.Windows.Forms.Cursors.Default;
            this.richTextBoxPaymentDetails.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.richTextBoxPaymentDetails.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(66)))), ((int)(((byte)(71)))));
            this.richTextBoxPaymentDetails.Location = new System.Drawing.Point(774, 90);
            this.richTextBoxPaymentDetails.Name = "richTextBoxPaymentDetails";
            this.richTextBoxPaymentDetails.ReadOnly = true;
            this.richTextBoxPaymentDetails.Size = new System.Drawing.Size(364, 326);
            this.richTextBoxPaymentDetails.TabIndex = 5;
            this.richTextBoxPaymentDetails.Text = "";
            // 
            // labelPaymentDetails
            // 
            this.labelPaymentDetails.AutoSize = true;
            this.labelPaymentDetails.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelPaymentDetails.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(47)))), ((int)(((byte)(51)))));
            this.labelPaymentDetails.Location = new System.Drawing.Point(769, 43);
            this.labelPaymentDetails.Name = "labelPaymentDetails";
            this.labelPaymentDetails.Size = new System.Drawing.Size(130, 27);
            this.labelPaymentDetails.TabIndex = 4;
            this.labelPaymentDetails.Text = "Реквизиты:";
            // 
            // richTextBoxWorkers
            // 
            this.richTextBoxWorkers.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(218)))), ((int)(((byte)(224)))));
            this.richTextBoxWorkers.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBoxWorkers.Cursor = System.Windows.Forms.Cursors.Default;
            this.richTextBoxWorkers.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.richTextBoxWorkers.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(66)))), ((int)(((byte)(71)))));
            this.richTextBoxWorkers.Location = new System.Drawing.Point(434, 90);
            this.richTextBoxWorkers.Name = "richTextBoxWorkers";
            this.richTextBoxWorkers.ReadOnly = true;
            this.richTextBoxWorkers.Size = new System.Drawing.Size(296, 326);
            this.richTextBoxWorkers.TabIndex = 3;
            this.richTextBoxWorkers.Text = "";
            // 
            // labelWorkers
            // 
            this.labelWorkers.AutoSize = true;
            this.labelWorkers.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelWorkers.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(47)))), ((int)(((byte)(51)))));
            this.labelWorkers.Location = new System.Drawing.Point(429, 43);
            this.labelWorkers.Name = "labelWorkers";
            this.labelWorkers.Size = new System.Drawing.Size(142, 27);
            this.labelWorkers.TabIndex = 2;
            this.labelWorkers.Text = "Сотрудники:";
            // 
            // richTextBoxBaseInfo
            // 
            this.richTextBoxBaseInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(218)))), ((int)(((byte)(224)))));
            this.richTextBoxBaseInfo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBoxBaseInfo.Cursor = System.Windows.Forms.Cursors.Default;
            this.richTextBoxBaseInfo.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.richTextBoxBaseInfo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(66)))), ((int)(((byte)(71)))));
            this.richTextBoxBaseInfo.Location = new System.Drawing.Point(31, 90);
            this.richTextBoxBaseInfo.Name = "richTextBoxBaseInfo";
            this.richTextBoxBaseInfo.ReadOnly = true;
            this.richTextBoxBaseInfo.Size = new System.Drawing.Size(296, 326);
            this.richTextBoxBaseInfo.TabIndex = 1;
            this.richTextBoxBaseInfo.Text = "";
            // 
            // labelBaseInfo
            // 
            this.labelBaseInfo.AutoSize = true;
            this.labelBaseInfo.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelBaseInfo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(47)))), ((int)(((byte)(51)))));
            this.labelBaseInfo.Location = new System.Drawing.Point(26, 43);
            this.labelBaseInfo.Name = "labelBaseInfo";
            this.labelBaseInfo.Size = new System.Drawing.Size(76, 27);
            this.labelBaseInfo.TabIndex = 0;
            this.labelBaseInfo.Text = "Касса:";
            // 
            // TantClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1482, 1055);
            this.Controls.Add(this.panelDesktopPanel);
            this.Controls.Add(this.panelHeader);
            this.Controls.Add(this.panelMenu);
            this.MaximumSize = new System.Drawing.Size(1500, 1500);
            this.MinimumSize = new System.Drawing.Size(1500, 1018);
            this.Name = "TantClient";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tant Service - Аналитика для вас";
            this.panelMenu.ResumeLayout(false);
            this.panelDevelopedBy.ResumeLayout(false);
            this.panelDevelopedBy.PerformLayout();
            this.panelLogo.ResumeLayout(false);
            this.panelLogo.PerformLayout();
            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            this.panelDesktopPanel.ResumeLayout(false);
            this.panelDesktopPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.Button buttonSettings;
        private System.Windows.Forms.Button buttonWorkers;
        private System.Windows.Forms.Button buttonTurnover;
        private System.Windows.Forms.Button buttonAnalytics;
        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Label labelHeader;
        private System.Windows.Forms.Panel panelDesktopPanel;
        private System.Windows.Forms.Button btnCloseChildForm;
        private System.Windows.Forms.Label labelLogo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelDevelopedBy;
        private System.Windows.Forms.Panel panelDevelopedBy;
        private System.Windows.Forms.RichTextBox richTextBoxBaseInfo;
        private System.Windows.Forms.Label labelBaseInfo;
        private System.Windows.Forms.RichTextBox richTextBoxWorkers;
        private System.Windows.Forms.Label labelWorkers;
        private System.Windows.Forms.RichTextBox richTextBoxPaymentDetails;
        private System.Windows.Forms.Label labelPaymentDetails;
        private System.Windows.Forms.RichTextBox richTextBoxInfo;
        private System.Windows.Forms.Button buttonUpdateBaseInfo;
        private System.Windows.Forms.Label labelUpdateBaseInfo;
    }
}

