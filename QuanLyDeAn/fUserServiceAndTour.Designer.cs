namespace QuanLyDeAn
{
    partial class fUserServiceAndTour
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
            this.chosenServiceLabel = new System.Windows.Forms.Label();
            this.chosenServiceDataGridView = new System.Windows.Forms.DataGridView();
            this.service_userInfoPanel = new System.Windows.Forms.Panel();
            this.service_helpBtn = new System.Windows.Forms.Button();
            this.service_confirmBtn = new System.Windows.Forms.Button();
            this.service_SearchingBtn = new System.Windows.Forms.Button();
            this.service_userIdPanel = new System.Windows.Forms.Panel();
            this.service_userId = new System.Windows.Forms.Label();
            this.service_userIdTextBox = new System.Windows.Forms.TextBox();
            this.service_bookingFormIdPanel = new System.Windows.Forms.Panel();
            this.bookingFormId = new System.Windows.Forms.Label();
            this.bookingFormIdTextBox = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tourPanel = new System.Windows.Forms.Panel();
            this.chosenTourLabel = new System.Windows.Forms.Label();
            this.chosenTourDataGridView = new System.Windows.Forms.DataGridView();
            this.tour_userInfoPanel = new System.Windows.Forms.Panel();
<<<<<<< Updated upstream
            this.tour_helpBtn = new System.Windows.Forms.Button();
=======
            this.panel4 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.specRequestTextBox = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dvDuaDonComboBox = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.numberOfGroupTxb = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
>>>>>>> Stashed changes
            this.tour_confirmBtn = new System.Windows.Forms.Button();
            this.tourSearchingBtn = new System.Windows.Forms.Button();
            this.tour_userIdPanel = new System.Windows.Forms.Panel();
            this.tour_userIdLabel = new System.Windows.Forms.Label();
            this.tour_userIdTextBox = new System.Windows.Forms.TextBox();
            this.tour_userNamePanel = new System.Windows.Forms.Panel();
            this.tour_userNameLabel = new System.Windows.Forms.Label();
            this.tour_userNameTextBox = new System.Windows.Forms.TextBox();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.userTabControl.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.servicePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chosenServiceDataGridView)).BeginInit();
            this.service_userInfoPanel.SuspendLayout();
            this.service_userIdPanel.SuspendLayout();
            this.service_bookingFormIdPanel.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tourPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chosenTourDataGridView)).BeginInit();
            this.tour_userInfoPanel.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
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
            this.userTabControl.TabIndex = 0;
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
            this.servicePanel.Controls.Add(this.chosenServiceLabel);
            this.servicePanel.Controls.Add(this.chosenServiceDataGridView);
            this.servicePanel.Controls.Add(this.service_userInfoPanel);
            this.servicePanel.Location = new System.Drawing.Point(0, 0);
            this.servicePanel.Name = "servicePanel";
            this.servicePanel.Size = new System.Drawing.Size(1035, 482);
            this.servicePanel.TabIndex = 0;
            // 
            // chosenServiceLabel
            // 
            this.chosenServiceLabel.AutoSize = true;
            this.chosenServiceLabel.Location = new System.Drawing.Point(6, 3);
            this.chosenServiceLabel.Name = "chosenServiceLabel";
            this.chosenServiceLabel.Size = new System.Drawing.Size(105, 16);
            this.chosenServiceLabel.TabIndex = 3;
            this.chosenServiceLabel.Text = "Dịch vụ đã chọn:";
            // 
            // chosenServiceDataGridView
            // 
            this.chosenServiceDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.chosenServiceDataGridView.Location = new System.Drawing.Point(6, 23);
            this.chosenServiceDataGridView.Name = "chosenServiceDataGridView";
            this.chosenServiceDataGridView.RowHeadersWidth = 51;
            this.chosenServiceDataGridView.RowTemplate.Height = 24;
            this.chosenServiceDataGridView.Size = new System.Drawing.Size(594, 453);
            this.chosenServiceDataGridView.TabIndex = 2;
            // 
            // service_userInfoPanel
            // 
            this.service_userInfoPanel.Controls.Add(this.service_helpBtn);
            this.service_userInfoPanel.Controls.Add(this.service_confirmBtn);
            this.service_userInfoPanel.Controls.Add(this.service_SearchingBtn);
            this.service_userInfoPanel.Controls.Add(this.service_userIdPanel);
            this.service_userInfoPanel.Controls.Add(this.service_bookingFormIdPanel);
            this.service_userInfoPanel.Location = new System.Drawing.Point(606, 23);
            this.service_userInfoPanel.Name = "service_userInfoPanel";
            this.service_userInfoPanel.Size = new System.Drawing.Size(423, 453);
            this.service_userInfoPanel.TabIndex = 1;
            // 
            // service_helpBtn
            // 
            this.service_helpBtn.Location = new System.Drawing.Point(124, 69);
            this.service_helpBtn.Name = "service_helpBtn";
            this.service_helpBtn.Size = new System.Drawing.Size(75, 23);
            this.service_helpBtn.TabIndex = 5;
            this.service_helpBtn.Text = "Giúp đỡ";
            this.service_helpBtn.UseVisualStyleBackColor = true;
            this.service_helpBtn.Click += new System.EventHandler(this.service_helpBtn_Click);
            // 
            // service_confirmBtn
            // 
            this.service_confirmBtn.Location = new System.Drawing.Point(332, 69);
            this.service_confirmBtn.Name = "service_confirmBtn";
            this.service_confirmBtn.Size = new System.Drawing.Size(89, 23);
            this.service_confirmBtn.TabIndex = 4;
            this.service_confirmBtn.Text = "Xác nhận";
            this.service_confirmBtn.UseVisualStyleBackColor = true;
            this.service_confirmBtn.Click += new System.EventHandler(this.service_confirmBtn_Click);
            // 
            // service_SearchingBtn
            // 
            this.service_SearchingBtn.Location = new System.Drawing.Point(205, 69);
            this.service_SearchingBtn.Name = "service_SearchingBtn";
            this.service_SearchingBtn.Size = new System.Drawing.Size(121, 23);
            this.service_SearchingBtn.TabIndex = 3;
            this.service_SearchingBtn.Text = "Tra cứu dịch vụ";
            this.service_SearchingBtn.UseVisualStyleBackColor = true;
            this.service_SearchingBtn.Click += new System.EventHandler(this.service_SearchingBtn_Click);
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
            this.service_userIdTextBox.Location = new System.Drawing.Point(139, 1);
            this.service_userIdTextBox.Name = "service_userIdTextBox";
            this.service_userIdTextBox.Size = new System.Drawing.Size(279, 22);
            this.service_userIdTextBox.TabIndex = 0;
            // 
            // service_bookingFormIdPanel
            // 
            this.service_bookingFormIdPanel.Controls.Add(this.bookingFormId);
            this.service_bookingFormIdPanel.Controls.Add(this.bookingFormIdTextBox);
            this.service_bookingFormIdPanel.Location = new System.Drawing.Point(3, 3);
            this.service_bookingFormIdPanel.Name = "service_bookingFormIdPanel";
            this.service_bookingFormIdPanel.Size = new System.Drawing.Size(417, 27);
            this.service_bookingFormIdPanel.TabIndex = 1;
            // 
            // bookingFormId
            // 
            this.bookingFormId.AutoSize = true;
            this.bookingFormId.Location = new System.Drawing.Point(4, 4);
            this.bookingFormId.Name = "bookingFormId";
            this.bookingFormId.Size = new System.Drawing.Size(128, 16);
            this.bookingFormId.TabIndex = 0;
            this.bookingFormId.Text = "Mã phiếu đặt phòng:";
            // 
            // bookingFormIdTextBox
            // 
            this.bookingFormIdTextBox.Location = new System.Drawing.Point(138, 1);
            this.bookingFormIdTextBox.Name = "bookingFormIdTextBox";
            this.bookingFormIdTextBox.Size = new System.Drawing.Size(276, 22);
            this.bookingFormIdTextBox.TabIndex = 0;
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
            this.tourPanel.Controls.Add(this.chosenTourLabel);
            this.tourPanel.Controls.Add(this.chosenTourDataGridView);
            this.tourPanel.Controls.Add(this.tour_userInfoPanel);
            this.tourPanel.Location = new System.Drawing.Point(0, 0);
            this.tourPanel.Name = "tourPanel";
            this.tourPanel.Size = new System.Drawing.Size(1035, 482);
            this.tourPanel.TabIndex = 1;
            // 
            // chosenTourLabel
            // 
            this.chosenTourLabel.AutoSize = true;
            this.chosenTourLabel.Location = new System.Drawing.Point(6, 3);
            this.chosenTourLabel.Name = "chosenTourLabel";
            this.chosenTourLabel.Size = new System.Drawing.Size(89, 16);
            this.chosenTourLabel.TabIndex = 3;
            this.chosenTourLabel.Text = "Tour đã chọn:";
            // 
            // chosenTourDataGridView
            // 
            this.chosenTourDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.chosenTourDataGridView.Location = new System.Drawing.Point(6, 23);
            this.chosenTourDataGridView.Name = "chosenTourDataGridView";
            this.chosenTourDataGridView.RowHeadersWidth = 51;
            this.chosenTourDataGridView.RowTemplate.Height = 24;
            this.chosenTourDataGridView.Size = new System.Drawing.Size(594, 453);
            this.chosenTourDataGridView.TabIndex = 2;
            // 
            // tour_userInfoPanel
            // 
<<<<<<< Updated upstream
            this.tour_userInfoPanel.Controls.Add(this.tour_helpBtn);
=======
            this.tour_userInfoPanel.Controls.Add(this.panel4);
            this.tour_userInfoPanel.Controls.Add(this.panel3);
            this.tour_userInfoPanel.Controls.Add(this.panel2);
            this.tour_userInfoPanel.Controls.Add(this.panel1);
>>>>>>> Stashed changes
            this.tour_userInfoPanel.Controls.Add(this.tour_confirmBtn);
            this.tour_userInfoPanel.Controls.Add(this.tourSearchingBtn);
            this.tour_userInfoPanel.Controls.Add(this.tour_userIdPanel);
            this.tour_userInfoPanel.Controls.Add(this.tour_userNamePanel);
            this.tour_userInfoPanel.Location = new System.Drawing.Point(606, 23);
            this.tour_userInfoPanel.Name = "tour_userInfoPanel";
            this.tour_userInfoPanel.Size = new System.Drawing.Size(423, 453);
            this.tour_userInfoPanel.TabIndex = 1;
            // 
<<<<<<< Updated upstream
            // tour_helpBtn
            // 
            this.tour_helpBtn.Location = new System.Drawing.Point(126, 69);
            this.tour_helpBtn.Name = "tour_helpBtn";
            this.tour_helpBtn.Size = new System.Drawing.Size(75, 23);
            this.tour_helpBtn.TabIndex = 5;
            this.tour_helpBtn.Text = "Giúp đỡ";
            this.tour_helpBtn.UseVisualStyleBackColor = true;
            this.tour_helpBtn.Click += new System.EventHandler(this.tour_helpBtn_Click);
=======
            // panel4
            // 
            this.panel4.Controls.Add(this.label4);
            this.panel4.Controls.Add(this.specRequestTextBox);
            this.panel4.Location = new System.Drawing.Point(0, 173);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(421, 33);
            this.panel4.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(5, 4);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(110, 16);
            this.label4.TabIndex = 0;
            this.label4.Text = "Yêu cầu đặc biệt:";
            // 
            // specRequestTextBox
            // 
            this.specRequestTextBox.Location = new System.Drawing.Point(128, 4);
            this.specRequestTextBox.Name = "specRequestTextBox";
            this.specRequestTextBox.Size = new System.Drawing.Size(290, 22);
            this.specRequestTextBox.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.dvDuaDonComboBox);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Location = new System.Drawing.Point(3, 142);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(421, 27);
            this.panel3.TabIndex = 7;
            // 
            // dvDuaDonComboBox
            // 
            this.dvDuaDonComboBox.FormattingEnabled = true;
            this.dvDuaDonComboBox.Items.AddRange(new object[] {
            "Xe bus",
            "Xe taxi",
            "Trực thăng"});
            this.dvDuaDonComboBox.Location = new System.Drawing.Point(125, 1);
            this.dvDuaDonComboBox.Name = "dvDuaDonComboBox";
            this.dvDuaDonComboBox.Size = new System.Drawing.Size(292, 24);
            this.dvDuaDonComboBox.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(5, 4);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 16);
            this.label3.TabIndex = 0;
            this.label3.Text = "Dịch vụ đưa đón:";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.numberOfGroupTxb);
            this.panel2.Location = new System.Drawing.Point(3, 109);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(421, 27);
            this.panel2.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(5, 4);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "Số người tham gia";
            // 
            // numberOfGroupTxb
            // 
            this.numberOfGroupTxb.Location = new System.Drawing.Point(125, 1);
            this.numberOfGroupTxb.Name = "numberOfGroupTxb";
            this.numberOfGroupTxb.Size = new System.Drawing.Size(293, 22);
            this.numberOfGroupTxb.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dateTimePicker);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(2, 69);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(421, 34);
            this.panel1.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Thời gian";
>>>>>>> Stashed changes
            // 
            // tour_confirmBtn
            // 
            this.tour_confirmBtn.Location = new System.Drawing.Point(332, 207);
            this.tour_confirmBtn.Name = "tour_confirmBtn";
            this.tour_confirmBtn.Size = new System.Drawing.Size(89, 23);
            this.tour_confirmBtn.TabIndex = 4;
            this.tour_confirmBtn.Text = "Xác nhận";
            this.tour_confirmBtn.UseVisualStyleBackColor = true;
            this.tour_confirmBtn.Click += new System.EventHandler(this.tour_confirmBtn_Click);
            // 
            // tourSearchingBtn
            // 
            this.tourSearchingBtn.Location = new System.Drawing.Point(207, 207);
            this.tourSearchingBtn.Name = "tourSearchingBtn";
            this.tourSearchingBtn.Size = new System.Drawing.Size(121, 23);
            this.tourSearchingBtn.TabIndex = 3;
            this.tourSearchingBtn.Text = "Tra cứu tour";
            this.tourSearchingBtn.UseVisualStyleBackColor = true;
            this.tourSearchingBtn.Click += new System.EventHandler(this.tourSearchingBtn_Click);
            // 
            // tour_userIdPanel
            // 
            this.tour_userIdPanel.Controls.Add(this.tour_userIdLabel);
            this.tour_userIdPanel.Controls.Add(this.tour_userIdTextBox);
            this.tour_userIdPanel.Location = new System.Drawing.Point(2, 36);
            this.tour_userIdPanel.Name = "tour_userIdPanel";
            this.tour_userIdPanel.Size = new System.Drawing.Size(421, 27);
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
            this.tour_userIdTextBox.Location = new System.Drawing.Point(126, 1);
            this.tour_userIdTextBox.Name = "tour_userIdTextBox";
            this.tour_userIdTextBox.Size = new System.Drawing.Size(292, 22);
            this.tour_userIdTextBox.TabIndex = 0;
            // 
            // tour_userNamePanel
            // 
            this.tour_userNamePanel.Controls.Add(this.tour_userNameLabel);
            this.tour_userNamePanel.Controls.Add(this.tour_userNameTextBox);
            this.tour_userNamePanel.Location = new System.Drawing.Point(3, 3);
            this.tour_userNamePanel.Name = "tour_userNamePanel";
            this.tour_userNamePanel.Size = new System.Drawing.Size(420, 27);
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
            this.tour_userNameTextBox.Location = new System.Drawing.Point(125, 1);
            this.tour_userNameTextBox.Name = "tour_userNameTextBox";
            this.tour_userNameTextBox.Size = new System.Drawing.Size(292, 22);
            this.tour_userNameTextBox.TabIndex = 0;
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.Location = new System.Drawing.Point(126, 4);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(293, 22);
            this.dateTimePicker.TabIndex = 1;
            // 
            // fUserServiceAndTour
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.userTabControl);
            this.Name = "fUserServiceAndTour";
            this.Text = "fUserServiceAndTour";
            this.userTabControl.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.servicePanel.ResumeLayout(false);
            this.servicePanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chosenServiceDataGridView)).EndInit();
            this.service_userInfoPanel.ResumeLayout(false);
            this.service_userIdPanel.ResumeLayout(false);
            this.service_userIdPanel.PerformLayout();
            this.service_bookingFormIdPanel.ResumeLayout(false);
            this.service_bookingFormIdPanel.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tourPanel.ResumeLayout(false);
            this.tourPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chosenTourDataGridView)).EndInit();
            this.tour_userInfoPanel.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tour_userIdPanel.ResumeLayout(false);
            this.tour_userIdPanel.PerformLayout();
            this.tour_userNamePanel.ResumeLayout(false);
            this.tour_userNamePanel.PerformLayout();
            this.ResumeLayout(false);

        }


        #endregion

        private System.Windows.Forms.TabControl userTabControl;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Panel servicePanel;
        private System.Windows.Forms.TextBox bookingFormIdTextBox;
        private System.Windows.Forms.Panel service_userInfoPanel;
        private System.Windows.Forms.Panel service_bookingFormIdPanel;
        private System.Windows.Forms.Label bookingFormId;
        private System.Windows.Forms.Panel service_userIdPanel;
        private System.Windows.Forms.Label service_userId;
        private System.Windows.Forms.TextBox service_userIdTextBox;
        private System.Windows.Forms.Label chosenServiceLabel;
        private System.Windows.Forms.DataGridView chosenServiceDataGridView;
        private System.Windows.Forms.Button service_SearchingBtn;
        private System.Windows.Forms.Button service_confirmBtn;
        private System.Windows.Forms.Button service_helpBtn;
        private System.Windows.Forms.Panel tourPanel;
        private System.Windows.Forms.Label chosenTourLabel;
        private System.Windows.Forms.DataGridView chosenTourDataGridView;
        private System.Windows.Forms.Panel tour_userInfoPanel;
        private System.Windows.Forms.Button tour_helpBtn;
        private System.Windows.Forms.Button tour_confirmBtn;
        private System.Windows.Forms.Button tourSearchingBtn;
        private System.Windows.Forms.Panel tour_userIdPanel;
        private System.Windows.Forms.Label tour_userIdLabel;
        private System.Windows.Forms.TextBox tour_userIdTextBox;
        private System.Windows.Forms.Panel tour_userNamePanel;
        private System.Windows.Forms.Label tour_userNameLabel;
        private System.Windows.Forms.TextBox tour_userNameTextBox;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox specRequestTextBox;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox numberOfGroupTxb;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox dvDuaDonComboBox;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
    }
}