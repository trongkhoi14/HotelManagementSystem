namespace QuanLyDeAn
{
    partial class fAdminServiceAndTour
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
            this.userTabControl = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.servicePanel = new System.Windows.Forms.Panel();
            this.unacceptedServiceFormLabel = new System.Windows.Forms.Label();
            this.unacceptedServiceFormDtgv = new System.Windows.Forms.DataGridView();
            this.service_userInfoPanel = new System.Windows.Forms.Panel();
            this.serviceSearchingBtn = new System.Windows.Forms.Button();
            this.service_registerBtn = new System.Windows.Forms.Button();
            this.service_detailBtn = new System.Windows.Forms.Button();
            this.service_acceptBtn = new System.Windows.Forms.Button();
            this.service_searchBtn = new System.Windows.Forms.Button();
            this.service_userIdPanel = new System.Windows.Forms.Panel();
            this.service_userId = new System.Windows.Forms.Label();
            this.service_userIdTextBox = new System.Windows.Forms.TextBox();
            this.service_userNamePanel = new System.Windows.Forms.Panel();
            this.service_userName = new System.Windows.Forms.Label();
            this.service_userNameTextBox = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tourPanel = new System.Windows.Forms.Panel();
            this.unacceptedTourFormLabel = new System.Windows.Forms.Label();
            this.unacceptedTourFormDtgv = new System.Windows.Forms.DataGridView();
            this.tour_userInfoPanel = new System.Windows.Forms.Panel();
            this.tourSearchingBtn = new System.Windows.Forms.Button();
            this.tour_registerBtn = new System.Windows.Forms.Button();
            this.tour_detailBtn = new System.Windows.Forms.Button();
            this.tour_acceptBtn = new System.Windows.Forms.Button();
            this.tour_searchBtn = new System.Windows.Forms.Button();
            this.tour_userIdPanel = new System.Windows.Forms.Panel();
            this.tour_userIdLabel = new System.Windows.Forms.Label();
            this.tour_userIdTextBox = new System.Windows.Forms.TextBox();
            this.tour_userNamePanel = new System.Windows.Forms.Panel();
            this.tour_userNameLabel = new System.Windows.Forms.Label();
            this.tour_userNameTextBox = new System.Windows.Forms.TextBox();
            this.userTabControl.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.servicePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.unacceptedServiceFormDtgv)).BeginInit();
            this.service_userInfoPanel.SuspendLayout();
            this.service_userIdPanel.SuspendLayout();
            this.service_userNamePanel.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tourPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.unacceptedTourFormDtgv)).BeginInit();
            this.tour_userInfoPanel.SuspendLayout();
            this.tour_userIdPanel.SuspendLayout();
            this.tour_userNamePanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // userTabControl
            // 
            this.userTabControl.Controls.Add(this.tabPage1);
            this.userTabControl.Controls.Add(this.tabPage2);
            this.userTabControl.Location = new System.Drawing.Point(12, 22);
            this.userTabControl.Name = "userTabControl";
            this.userTabControl.SelectedIndex = 0;
            this.userTabControl.Size = new System.Drawing.Size(1043, 511);
            this.userTabControl.TabIndex = 3;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.servicePanel);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1035, 482);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Dịch vụ";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // servicePanel
            // 
            this.servicePanel.Controls.Add(this.unacceptedServiceFormLabel);
            this.servicePanel.Controls.Add(this.unacceptedServiceFormDtgv);
            this.servicePanel.Controls.Add(this.service_userInfoPanel);
            this.servicePanel.Location = new System.Drawing.Point(0, 0);
            this.servicePanel.Name = "servicePanel";
            this.servicePanel.Size = new System.Drawing.Size(1035, 482);
            this.servicePanel.TabIndex = 0;
            // 
            // unacceptedServiceFormLabel
            // 
            this.unacceptedServiceFormLabel.AutoSize = true;
            this.unacceptedServiceFormLabel.Location = new System.Drawing.Point(7, 4);
            this.unacceptedServiceFormLabel.Name = "unacceptedServiceFormLabel";
            this.unacceptedServiceFormLabel.Size = new System.Drawing.Size(170, 16);
            this.unacceptedServiceFormLabel.TabIndex = 3;
            this.unacceptedServiceFormLabel.Text = "Phiếu dịch vụ đang chờ lập:";
            // 
            // unacceptedServiceFormDtgv
            // 
            this.unacceptedServiceFormDtgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.unacceptedServiceFormDtgv.Location = new System.Drawing.Point(6, 23);
            this.unacceptedServiceFormDtgv.Name = "unacceptedServiceFormDtgv";
            this.unacceptedServiceFormDtgv.RowHeadersWidth = 51;
            this.unacceptedServiceFormDtgv.RowTemplate.Height = 24;
            this.unacceptedServiceFormDtgv.Size = new System.Drawing.Size(594, 453);
            this.unacceptedServiceFormDtgv.TabIndex = 2;
            // 
            // service_userInfoPanel
            // 
            this.service_userInfoPanel.Controls.Add(this.serviceSearchingBtn);
            this.service_userInfoPanel.Controls.Add(this.service_registerBtn);
            this.service_userInfoPanel.Controls.Add(this.service_detailBtn);
            this.service_userInfoPanel.Controls.Add(this.service_acceptBtn);
            this.service_userInfoPanel.Controls.Add(this.service_searchBtn);
            this.service_userInfoPanel.Controls.Add(this.service_userIdPanel);
            this.service_userInfoPanel.Controls.Add(this.service_userNamePanel);
            this.service_userInfoPanel.Location = new System.Drawing.Point(606, 23);
            this.service_userInfoPanel.Name = "service_userInfoPanel";
            this.service_userInfoPanel.Size = new System.Drawing.Size(423, 453);
            this.service_userInfoPanel.TabIndex = 1;
            // 
            // serviceSearchingBtn
            // 
            this.serviceSearchingBtn.Location = new System.Drawing.Point(231, 100);
            this.serviceSearchingBtn.Name = "serviceSearchingBtn";
            this.serviceSearchingBtn.Size = new System.Drawing.Size(186, 25);
            this.serviceSearchingBtn.TabIndex = 9;
            this.serviceSearchingBtn.Text = "Tra cứu các dịch vụ hiện có";
            this.serviceSearchingBtn.UseVisualStyleBackColor = true;
            this.serviceSearchingBtn.Click += new System.EventHandler(this.serviceSearchingBtn_Click);
            // 
            // service_registerBtn
            // 
            this.service_registerBtn.Location = new System.Drawing.Point(32, 69);
            this.service_registerBtn.Name = "service_registerBtn";
            this.service_registerBtn.Size = new System.Drawing.Size(100, 25);
            this.service_registerBtn.TabIndex = 8;
            this.service_registerBtn.Text = "Đăng ký mới";
            this.service_registerBtn.UseVisualStyleBackColor = true;
            this.service_registerBtn.Click += new System.EventHandler(this.service_registerBtn_Click);
            // 
            // service_detailBtn
            // 
            this.service_detailBtn.Location = new System.Drawing.Point(330, 69);
            this.service_detailBtn.Name = "service_detailBtn";
            this.service_detailBtn.Size = new System.Drawing.Size(90, 25);
            this.service_detailBtn.TabIndex = 6;
            this.service_detailBtn.Text = "Chi tiết";
            this.service_detailBtn.UseVisualStyleBackColor = true;
            this.service_detailBtn.Click += new System.EventHandler(this.service_detailBtn_Click);
            // 
            // service_acceptBtn
            // 
            this.service_acceptBtn.Location = new System.Drawing.Point(234, 69);
            this.service_acceptBtn.Name = "service_acceptBtn";
            this.service_acceptBtn.Size = new System.Drawing.Size(90, 25);
            this.service_acceptBtn.TabIndex = 5;
            this.service_acceptBtn.Text = "Lập phiếu";
            this.service_acceptBtn.UseVisualStyleBackColor = true;
            this.service_acceptBtn.Click += new System.EventHandler(this.service_acceptBtn_Click);
            // 
            // service_searchBtn
            // 
            this.service_searchBtn.Location = new System.Drawing.Point(138, 69);
            this.service_searchBtn.Name = "service_searchBtn";
            this.service_searchBtn.Size = new System.Drawing.Size(90, 25);
            this.service_searchBtn.TabIndex = 4;
            this.service_searchBtn.Text = "Tìm kiếm";
            this.service_searchBtn.UseVisualStyleBackColor = true;
            this.service_searchBtn.Click += new System.EventHandler(this.service_searchBtn_Click);
            // 
            // service_userIdPanel
            // 
            this.service_userIdPanel.Controls.Add(this.service_userId);
            this.service_userIdPanel.Controls.Add(this.service_userIdTextBox);
            this.service_userIdPanel.Location = new System.Drawing.Point(2, 36);
            this.service_userIdPanel.Name = "service_userIdPanel";
            this.service_userIdPanel.Size = new System.Drawing.Size(418, 27);
            this.service_userIdPanel.TabIndex = 2;
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
            // service_userIdTextBox
            // 
            this.service_userIdTextBox.Location = new System.Drawing.Point(116, 1);
            this.service_userIdTextBox.Name = "service_userIdTextBox";
            this.service_userIdTextBox.Size = new System.Drawing.Size(299, 22);
            this.service_userIdTextBox.TabIndex = 0;
            // 
            // service_userNamePanel
            // 
            this.service_userNamePanel.Controls.Add(this.service_userName);
            this.service_userNamePanel.Controls.Add(this.service_userNameTextBox);
            this.service_userNamePanel.Location = new System.Drawing.Point(3, 3);
            this.service_userNamePanel.Name = "service_userNamePanel";
            this.service_userNamePanel.Size = new System.Drawing.Size(417, 27);
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
            this.service_userNameTextBox.Size = new System.Drawing.Size(298, 22);
            this.service_userNameTextBox.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.tourPanel);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1035, 482);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Tour du lịch";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tourPanel
            // 
            this.tourPanel.Controls.Add(this.unacceptedTourFormLabel);
            this.tourPanel.Controls.Add(this.unacceptedTourFormDtgv);
            this.tourPanel.Controls.Add(this.tour_userInfoPanel);
            this.tourPanel.Location = new System.Drawing.Point(0, 0);
            this.tourPanel.Name = "tourPanel";
            this.tourPanel.Size = new System.Drawing.Size(1035, 482);
            this.tourPanel.TabIndex = 1;
            // 
            // unacceptedTourFormLabel
            // 
            this.unacceptedTourFormLabel.AutoSize = true;
            this.unacceptedTourFormLabel.Location = new System.Drawing.Point(7, 4);
            this.unacceptedTourFormLabel.Name = "unacceptedTourFormLabel";
            this.unacceptedTourFormLabel.Size = new System.Drawing.Size(242, 16);
            this.unacceptedTourFormLabel.TabIndex = 3;
            this.unacceptedTourFormLabel.Text = "Phiếu đăng ký tour du lịch đang chờ lập:";
            // 
            // unacceptedTourFormDtgv
            // 
            this.unacceptedTourFormDtgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.unacceptedTourFormDtgv.Location = new System.Drawing.Point(6, 23);
            this.unacceptedTourFormDtgv.Name = "unacceptedTourFormDtgv";
            this.unacceptedTourFormDtgv.RowHeadersWidth = 51;
            this.unacceptedTourFormDtgv.RowTemplate.Height = 24;
            this.unacceptedTourFormDtgv.Size = new System.Drawing.Size(594, 453);
            this.unacceptedTourFormDtgv.TabIndex = 2;
            // 
            // tour_userInfoPanel
            // 
            this.tour_userInfoPanel.Controls.Add(this.tourSearchingBtn);
            this.tour_userInfoPanel.Controls.Add(this.tour_registerBtn);
            this.tour_userInfoPanel.Controls.Add(this.tour_detailBtn);
            this.tour_userInfoPanel.Controls.Add(this.tour_acceptBtn);
            this.tour_userInfoPanel.Controls.Add(this.tour_searchBtn);
            this.tour_userInfoPanel.Controls.Add(this.tour_userIdPanel);
            this.tour_userInfoPanel.Controls.Add(this.tour_userNamePanel);
            this.tour_userInfoPanel.Location = new System.Drawing.Point(606, 23);
            this.tour_userInfoPanel.Name = "tour_userInfoPanel";
            this.tour_userInfoPanel.Size = new System.Drawing.Size(423, 453);
            this.tour_userInfoPanel.TabIndex = 1;
            // 
            // tourSearchingBtn
            // 
            this.tourSearchingBtn.Location = new System.Drawing.Point(234, 100);
            this.tourSearchingBtn.Name = "tourSearchingBtn";
            this.tourSearchingBtn.Size = new System.Drawing.Size(186, 25);
            this.tourSearchingBtn.TabIndex = 10;
            this.tourSearchingBtn.Text = "Tra cứu các tour hiện có";
            this.tourSearchingBtn.UseVisualStyleBackColor = true;
            this.tourSearchingBtn.Click += new System.EventHandler(this.tourSearchingBtn_Click);
            // 
            // tour_registerBtn
            // 
            this.tour_registerBtn.Location = new System.Drawing.Point(32, 69);
            this.tour_registerBtn.Name = "tour_registerBtn";
            this.tour_registerBtn.Size = new System.Drawing.Size(100, 25);
            this.tour_registerBtn.TabIndex = 7;
            this.tour_registerBtn.Text = "Đăng ký mới";
            this.tour_registerBtn.UseVisualStyleBackColor = true;
            this.tour_registerBtn.Click += new System.EventHandler(this.tour_registerBtn_Click);
            // 
            // tour_detailBtn
            // 
            this.tour_detailBtn.Location = new System.Drawing.Point(330, 69);
            this.tour_detailBtn.Name = "tour_detailBtn";
            this.tour_detailBtn.Size = new System.Drawing.Size(90, 25);
            this.tour_detailBtn.TabIndex = 6;
            this.tour_detailBtn.Text = "Chi tiết";
            this.tour_detailBtn.UseVisualStyleBackColor = true;
            this.tour_detailBtn.Click += new System.EventHandler(this.tour_detailBtn_Click);
            // 
            // tour_acceptBtn
            // 
            this.tour_acceptBtn.Location = new System.Drawing.Point(234, 69);
            this.tour_acceptBtn.Name = "tour_acceptBtn";
            this.tour_acceptBtn.Size = new System.Drawing.Size(90, 25);
            this.tour_acceptBtn.TabIndex = 5;
            this.tour_acceptBtn.Text = "Lập phiếu";
            this.tour_acceptBtn.UseVisualStyleBackColor = true;
            this.tour_acceptBtn.Click += new System.EventHandler(this.tour_acceptBtn_Click);
            // 
            // tour_searchBtn
            // 
            this.tour_searchBtn.Location = new System.Drawing.Point(138, 69);
            this.tour_searchBtn.Name = "tour_searchBtn";
            this.tour_searchBtn.Size = new System.Drawing.Size(90, 25);
            this.tour_searchBtn.TabIndex = 4;
            this.tour_searchBtn.Text = "Tìm kiếm";
            this.tour_searchBtn.UseVisualStyleBackColor = true;
            this.tour_searchBtn.Click += new System.EventHandler(this.tour_searchBtn_Click);
            // 
            // tour_userIdPanel
            // 
            this.tour_userIdPanel.Controls.Add(this.tour_userIdLabel);
            this.tour_userIdPanel.Controls.Add(this.tour_userIdTextBox);
            this.tour_userIdPanel.Location = new System.Drawing.Point(2, 36);
            this.tour_userIdPanel.Name = "tour_userIdPanel";
            this.tour_userIdPanel.Size = new System.Drawing.Size(418, 27);
            this.tour_userIdPanel.TabIndex = 2;
            // 
            // tour_userIdLabel
            // 
            this.tour_userIdLabel.AutoSize = true;
            this.tour_userIdLabel.Location = new System.Drawing.Point(5, 4);
            this.tour_userIdLabel.Name = "tour_userIdLabel";
            this.tour_userIdLabel.Size = new System.Drawing.Size(101, 16);
            this.tour_userIdLabel.TabIndex = 0;
            this.tour_userIdLabel.Text = "Mã khách hàng:";
            // 
            // tour_userIdTextBox
            // 
            this.tour_userIdTextBox.Location = new System.Drawing.Point(116, 1);
            this.tour_userIdTextBox.Name = "tour_userIdTextBox";
            this.tour_userIdTextBox.Size = new System.Drawing.Size(299, 22);
            this.tour_userIdTextBox.TabIndex = 0;
            // 
            // tour_userNamePanel
            // 
            this.tour_userNamePanel.Controls.Add(this.tour_userNameLabel);
            this.tour_userNamePanel.Controls.Add(this.tour_userNameTextBox);
            this.tour_userNamePanel.Location = new System.Drawing.Point(3, 3);
            this.tour_userNamePanel.Name = "tour_userNamePanel";
            this.tour_userNamePanel.Size = new System.Drawing.Size(417, 27);
            this.tour_userNamePanel.TabIndex = 1;
            // 
            // tour_userNameLabel
            // 
            this.tour_userNameLabel.AutoSize = true;
            this.tour_userNameLabel.Location = new System.Drawing.Point(4, 4);
            this.tour_userNameLabel.Name = "tour_userNameLabel";
            this.tour_userNameLabel.Size = new System.Drawing.Size(106, 16);
            this.tour_userNameLabel.TabIndex = 0;
            this.tour_userNameLabel.Text = "Tên khách hàng:";
            // 
            // tour_userNameTextBox
            // 
            this.tour_userNameTextBox.Location = new System.Drawing.Point(116, 1);
            this.tour_userNameTextBox.Name = "tour_userNameTextBox";
            this.tour_userNameTextBox.Size = new System.Drawing.Size(298, 22);
            this.tour_userNameTextBox.TabIndex = 0;
            // 
            // fAdminServiceAndTour
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.userTabControl);
            this.Name = "fAdminServiceAndTour";
            this.Text = "fAdminServiceAndTour";
            this.userTabControl.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.servicePanel.ResumeLayout(false);
            this.servicePanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.unacceptedServiceFormDtgv)).EndInit();
            this.service_userInfoPanel.ResumeLayout(false);
            this.service_userIdPanel.ResumeLayout(false);
            this.service_userIdPanel.PerformLayout();
            this.service_userNamePanel.ResumeLayout(false);
            this.service_userNamePanel.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tourPanel.ResumeLayout(false);
            this.tourPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.unacceptedTourFormDtgv)).EndInit();
            this.tour_userInfoPanel.ResumeLayout(false);
            this.tour_userIdPanel.ResumeLayout(false);
            this.tour_userIdPanel.PerformLayout();
            this.tour_userNamePanel.ResumeLayout(false);
            this.tour_userNamePanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl userTabControl;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Panel servicePanel;
        private System.Windows.Forms.Label unacceptedServiceFormLabel;
        private System.Windows.Forms.DataGridView unacceptedServiceFormDtgv;
        private System.Windows.Forms.Panel service_userInfoPanel;
        private System.Windows.Forms.Button service_detailBtn;
        private System.Windows.Forms.Button service_acceptBtn;
        private System.Windows.Forms.Button service_searchBtn;
        private System.Windows.Forms.Panel service_userIdPanel;
        private System.Windows.Forms.Label service_userId;
        private System.Windows.Forms.TextBox service_userIdTextBox;
        private System.Windows.Forms.Panel service_userNamePanel;
        private System.Windows.Forms.Label service_userName;
        private System.Windows.Forms.TextBox service_userNameTextBox;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Panel tourPanel;
        private System.Windows.Forms.Label unacceptedTourFormLabel;
        private System.Windows.Forms.DataGridView unacceptedTourFormDtgv;
        private System.Windows.Forms.Panel tour_userInfoPanel;
        private System.Windows.Forms.Button tour_detailBtn;
        private System.Windows.Forms.Button tour_acceptBtn;
        private System.Windows.Forms.Button tour_searchBtn;
        private System.Windows.Forms.Panel tour_userIdPanel;
        private System.Windows.Forms.Label tour_userIdLabel;
        private System.Windows.Forms.TextBox tour_userIdTextBox;
        private System.Windows.Forms.Panel tour_userNamePanel;
        private System.Windows.Forms.Label tour_userNameLabel;
        private System.Windows.Forms.TextBox tour_userNameTextBox;
        private System.Windows.Forms.Button service_registerBtn;
        private System.Windows.Forms.Button tour_registerBtn;
        private System.Windows.Forms.Button serviceSearchingBtn;
        private System.Windows.Forms.Button tourSearchingBtn;
    }
}