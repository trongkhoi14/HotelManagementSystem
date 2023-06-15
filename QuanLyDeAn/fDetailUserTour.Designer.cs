namespace QuanLyDeAn
{
    partial class fDetailUserTour
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
            this.acceptedServiceFormLabel = new System.Windows.Forms.Label();
            this.acceptedServiceFormPanel = new System.Windows.Forms.Panel();
            this.acceptedServiceFormDtgv = new System.Windows.Forms.DataGridView();
            this.service_searchBtn = new System.Windows.Forms.Button();
            this.service_userId = new System.Windows.Forms.Label();
            this.service_userNamePanel = new System.Windows.Forms.Panel();
            this.service_userName = new System.Windows.Forms.Label();
            this.service_userNameTextBox = new System.Windows.Forms.TextBox();
            this.service_userIdTextBox = new System.Windows.Forms.TextBox();
            this.service_userIdPanel = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.service_userInfoPanel = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.tourFormIdTextBox = new System.Windows.Forms.TextBox();
            this.acceptedServiceFormPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.acceptedServiceFormDtgv)).BeginInit();
            this.service_userNamePanel.SuspendLayout();
            this.service_userIdPanel.SuspendLayout();
            this.panel1.SuspendLayout();
            this.service_userInfoPanel.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // acceptedServiceFormLabel
            // 
            this.acceptedServiceFormLabel.AutoSize = true;
            this.acceptedServiceFormLabel.Location = new System.Drawing.Point(3, 13);
            this.acceptedServiceFormLabel.Name = "acceptedServiceFormLabel";
            this.acceptedServiceFormLabel.Size = new System.Drawing.Size(202, 16);
            this.acceptedServiceFormLabel.TabIndex = 3;
            this.acceptedServiceFormLabel.Text = "Phiếu đăng ký tour du lịch đã lập:";
            // 
            // acceptedServiceFormPanel
            // 
            this.acceptedServiceFormPanel.Controls.Add(this.acceptedServiceFormDtgv);
            this.acceptedServiceFormPanel.Controls.Add(this.acceptedServiceFormLabel);
            this.acceptedServiceFormPanel.Location = new System.Drawing.Point(3, 3);
            this.acceptedServiceFormPanel.Name = "acceptedServiceFormPanel";
            this.acceptedServiceFormPanel.Size = new System.Drawing.Size(625, 524);
            this.acceptedServiceFormPanel.TabIndex = 4;
            // 
            // acceptedServiceFormDtgv
            // 
            this.acceptedServiceFormDtgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.acceptedServiceFormDtgv.Location = new System.Drawing.Point(3, 32);
            this.acceptedServiceFormDtgv.Name = "acceptedServiceFormDtgv";
            this.acceptedServiceFormDtgv.RowHeadersWidth = 51;
            this.acceptedServiceFormDtgv.RowTemplate.Height = 24;
            this.acceptedServiceFormDtgv.Size = new System.Drawing.Size(619, 489);
            this.acceptedServiceFormDtgv.TabIndex = 2;
            // 
            // service_searchBtn
            // 
            this.service_searchBtn.Location = new System.Drawing.Point(305, 104);
            this.service_searchBtn.Name = "service_searchBtn";
            this.service_searchBtn.Size = new System.Drawing.Size(89, 23);
            this.service_searchBtn.TabIndex = 4;
            this.service_searchBtn.Text = "Tìm kiếm";
            this.service_searchBtn.UseVisualStyleBackColor = true;
            this.service_searchBtn.Click += new System.EventHandler(this.service_searchBtn_Click);
            // 
            // service_userId
            // 
            this.service_userId.AutoSize = true;
            this.service_userId.Location = new System.Drawing.Point(5, 4);
            this.service_userId.Name = "service_userId";
            this.service_userId.Size = new System.Drawing.Size(101, 16);
            this.service_userId.TabIndex = 0;
            this.service_userId.Text = "Mã khách hàng:";
            // 
            // service_userNamePanel
            // 
            this.service_userNamePanel.Controls.Add(this.service_userName);
            this.service_userNamePanel.Controls.Add(this.service_userNameTextBox);
            this.service_userNamePanel.Location = new System.Drawing.Point(3, 32);
            this.service_userNamePanel.Name = "service_userNamePanel";
            this.service_userNamePanel.Size = new System.Drawing.Size(394, 27);
            this.service_userNamePanel.TabIndex = 1;
            // 
            // service_userName
            // 
            this.service_userName.AutoSize = true;
            this.service_userName.Location = new System.Drawing.Point(4, 4);
            this.service_userName.Name = "service_userName";
            this.service_userName.Size = new System.Drawing.Size(106, 16);
            this.service_userName.TabIndex = 0;
            this.service_userName.Text = "Tên khách hàng:";
            // 
            // service_userNameTextBox
            // 
            this.service_userNameTextBox.Location = new System.Drawing.Point(116, 1);
            this.service_userNameTextBox.Name = "service_userNameTextBox";
            this.service_userNameTextBox.Size = new System.Drawing.Size(275, 22);
            this.service_userNameTextBox.TabIndex = 0;
            // 
            // service_userIdTextBox
            // 
            this.service_userIdTextBox.Location = new System.Drawing.Point(116, 1);
            this.service_userIdTextBox.Name = "service_userIdTextBox";
            this.service_userIdTextBox.Size = new System.Drawing.Size(275, 22);
            this.service_userIdTextBox.TabIndex = 0;
            // 
            // service_userIdPanel
            // 
            this.service_userIdPanel.Controls.Add(this.service_userId);
            this.service_userIdPanel.Controls.Add(this.service_userIdTextBox);
            this.service_userIdPanel.Location = new System.Drawing.Point(3, 3);
            this.service_userIdPanel.Name = "service_userIdPanel";
            this.service_userIdPanel.Size = new System.Drawing.Size(394, 27);
            this.service_userIdPanel.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.service_userIdPanel);
            this.panel1.Controls.Add(this.service_userNamePanel);
            this.panel1.Controls.Add(this.service_searchBtn);
            this.panel1.Location = new System.Drawing.Point(640, 35);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(400, 139);
            this.panel1.TabIndex = 7;
            // 
            // service_userInfoPanel
            // 
            this.service_userInfoPanel.Controls.Add(this.panel1);
            this.service_userInfoPanel.Controls.Add(this.acceptedServiceFormPanel);
            this.service_userInfoPanel.Location = new System.Drawing.Point(12, 12);
            this.service_userInfoPanel.Name = "service_userInfoPanel";
            this.service_userInfoPanel.Size = new System.Drawing.Size(1043, 530);
            this.service_userInfoPanel.TabIndex = 3;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.tourFormIdTextBox);
            this.panel2.Location = new System.Drawing.Point(3, 61);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(394, 27);
            this.panel2.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã phiếu:";
            // 
            // tourFormIdTextBox
            // 
            this.tourFormIdTextBox.Location = new System.Drawing.Point(116, 1);
            this.tourFormIdTextBox.Name = "tourFormIdTextBox";
            this.tourFormIdTextBox.Size = new System.Drawing.Size(275, 22);
            this.tourFormIdTextBox.TabIndex = 0;
            // 
            // fDetailUserTour
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.service_userInfoPanel);
            this.Name = "fDetailUserTour";
            this.Text = "fDetailUserTour";
            this.acceptedServiceFormPanel.ResumeLayout(false);
            this.acceptedServiceFormPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.acceptedServiceFormDtgv)).EndInit();
            this.service_userNamePanel.ResumeLayout(false);
            this.service_userNamePanel.PerformLayout();
            this.service_userIdPanel.ResumeLayout(false);
            this.service_userIdPanel.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.service_userInfoPanel.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label acceptedServiceFormLabel;
        private System.Windows.Forms.Panel acceptedServiceFormPanel;
        private System.Windows.Forms.DataGridView acceptedServiceFormDtgv;
        private System.Windows.Forms.Button service_searchBtn;
        private System.Windows.Forms.Label service_userId;
        private System.Windows.Forms.Panel service_userNamePanel;
        private System.Windows.Forms.TextBox service_userIdTextBox;
        private System.Windows.Forms.Panel service_userIdPanel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel service_userInfoPanel;
        private System.Windows.Forms.Label service_userName;
        private System.Windows.Forms.TextBox service_userNameTextBox;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tourFormIdTextBox;
    }
}