namespace QuanLyDeAn
{
    partial class fSearchingTravelTour
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
            this.listTourLabel = new System.Windows.Forms.Label();
            this.tourDtgv = new System.Windows.Forms.DataGridView();
            this.tourInfoPanel = new System.Windows.Forms.Panel();
            this.supplierPanel = new System.Windows.Forms.Panel();
            this.supplierLabel = new System.Windows.Forms.Label();
            this.supplierTextBox = new System.Windows.Forms.TextBox();
            this.deleteBtn = new System.Windows.Forms.Button();
            this.addBtn = new System.Windows.Forms.Button();
            this.serviceSearchingBtn = new System.Windows.Forms.Button();
            this.tourIdPanel = new System.Windows.Forms.Panel();
            this.tourId = new System.Windows.Forms.Label();
            this.tourIdTextBox = new System.Windows.Forms.TextBox();
            this.tourNamePanel = new System.Windows.Forms.Panel();
            this.tourName = new System.Windows.Forms.Label();
            this.tourNameTextBox = new System.Windows.Forms.TextBox();
            this.chosenTourDgtv = new System.Windows.Forms.DataGridView();
            this.chosenServiceLabel = new System.Windows.Forms.Label();
            this.confirmBtn = new System.Windows.Forms.Button();
            this.cancelBtn = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.tourDtgv)).BeginInit();
            this.tourInfoPanel.SuspendLayout();
            this.supplierPanel.SuspendLayout();
            this.tourIdPanel.SuspendLayout();
            this.tourNamePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chosenTourDgtv)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // listTourLabel
            // 
            this.listTourLabel.AutoSize = true;
            this.listTourLabel.Location = new System.Drawing.Point(12, 15);
            this.listTourLabel.Name = "listTourLabel";
            this.listTourLabel.Size = new System.Drawing.Size(99, 16);
            this.listTourLabel.TabIndex = 14;
            this.listTourLabel.Text = "Danh sách tour:";
            // 
            // tourDtgv
            // 
            this.tourDtgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tourDtgv.Location = new System.Drawing.Point(15, 34);
            this.tourDtgv.Name = "tourDtgv";
            this.tourDtgv.RowHeadersWidth = 51;
            this.tourDtgv.RowTemplate.Height = 24;
            this.tourDtgv.Size = new System.Drawing.Size(594, 451);
            this.tourDtgv.TabIndex = 13;
            // 
            // tourInfoPanel
            // 
            this.tourInfoPanel.Controls.Add(this.supplierPanel);
            this.tourInfoPanel.Controls.Add(this.deleteBtn);
            this.tourInfoPanel.Controls.Add(this.addBtn);
            this.tourInfoPanel.Controls.Add(this.serviceSearchingBtn);
            this.tourInfoPanel.Controls.Add(this.tourIdPanel);
            this.tourInfoPanel.Controls.Add(this.tourNamePanel);
            this.tourInfoPanel.Location = new System.Drawing.Point(3, 3);
            this.tourInfoPanel.Name = "tourInfoPanel";
            this.tourInfoPanel.Size = new System.Drawing.Size(417, 137);
            this.tourInfoPanel.TabIndex = 13;
            // 
            // supplierPanel
            // 
            this.supplierPanel.Controls.Add(this.supplierLabel);
            this.supplierPanel.Controls.Add(this.supplierTextBox);
            this.supplierPanel.Location = new System.Drawing.Point(3, 69);
            this.supplierPanel.Name = "supplierPanel";
            this.supplierPanel.Size = new System.Drawing.Size(411, 27);
            this.supplierPanel.TabIndex = 6;
            // 
            // supplierLabel
            // 
            this.supplierLabel.AutoSize = true;
            this.supplierLabel.Location = new System.Drawing.Point(5, 4);
            this.supplierLabel.Name = "supplierLabel";
            this.supplierLabel.Size = new System.Drawing.Size(93, 16);
            this.supplierLabel.TabIndex = 0;
            this.supplierLabel.Text = "Nhà cung cấp:";
            // 
            // supplierTextBox
            // 
            this.supplierTextBox.Location = new System.Drawing.Point(116, 1);
            this.supplierTextBox.Name = "supplierTextBox";
            this.supplierTextBox.Size = new System.Drawing.Size(292, 22);
            this.supplierTextBox.TabIndex = 0;
            // 
            // deleteBtn
            // 
            this.deleteBtn.Location = new System.Drawing.Point(322, 102);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Size = new System.Drawing.Size(90, 23);
            this.deleteBtn.TabIndex = 5;
            this.deleteBtn.Text = "Xóa";
            this.deleteBtn.UseVisualStyleBackColor = true;
            this.deleteBtn.Click += new System.EventHandler(this.deleteBtn_Click);
            // 
            // addBtn
            // 
            this.addBtn.Location = new System.Drawing.Point(226, 102);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(90, 23);
            this.addBtn.TabIndex = 4;
            this.addBtn.Text = "Thêm";
            this.addBtn.UseVisualStyleBackColor = true;
            this.addBtn.Click += new System.EventHandler(this.addBtn_Click);
            // 
            // serviceSearchingBtn
            // 
            this.serviceSearchingBtn.Location = new System.Drawing.Point(130, 102);
            this.serviceSearchingBtn.Name = "serviceSearchingBtn";
            this.serviceSearchingBtn.Size = new System.Drawing.Size(90, 23);
            this.serviceSearchingBtn.TabIndex = 3;
            this.serviceSearchingBtn.Text = "Tìm kiếm";
            this.serviceSearchingBtn.UseVisualStyleBackColor = true;
            this.serviceSearchingBtn.Click += new System.EventHandler(this.serviceSearchingBtn_Click);
            // 
            // tourIdPanel
            // 
            this.tourIdPanel.Controls.Add(this.tourId);
            this.tourIdPanel.Controls.Add(this.tourIdTextBox);
            this.tourIdPanel.Location = new System.Drawing.Point(2, 36);
            this.tourIdPanel.Name = "tourIdPanel";
            this.tourIdPanel.Size = new System.Drawing.Size(412, 27);
            this.tourIdPanel.TabIndex = 2;
            // 
            // tourId
            // 
            this.tourId.AutoSize = true;
            this.tourId.Location = new System.Drawing.Point(5, 4);
            this.tourId.Name = "tourId";
            this.tourId.Size = new System.Drawing.Size(54, 16);
            this.tourId.TabIndex = 0;
            this.tourId.Text = "Mã tour:";
            // 
            // tourIdTextBox
            // 
            this.tourIdTextBox.Location = new System.Drawing.Point(116, 1);
            this.tourIdTextBox.Name = "tourIdTextBox";
            this.tourIdTextBox.Size = new System.Drawing.Size(293, 22);
            this.tourIdTextBox.TabIndex = 0;
            // 
            // tourNamePanel
            // 
            this.tourNamePanel.Controls.Add(this.tourName);
            this.tourNamePanel.Controls.Add(this.tourNameTextBox);
            this.tourNamePanel.Location = new System.Drawing.Point(3, 3);
            this.tourNamePanel.Name = "tourNamePanel";
            this.tourNamePanel.Size = new System.Drawing.Size(411, 27);
            this.tourNamePanel.TabIndex = 1;
            // 
            // tourName
            // 
            this.tourName.AutoSize = true;
            this.tourName.Location = new System.Drawing.Point(4, 4);
            this.tourName.Name = "tourName";
            this.tourName.Size = new System.Drawing.Size(59, 16);
            this.tourName.TabIndex = 0;
            this.tourName.Text = "Tên tour:";
            // 
            // tourNameTextBox
            // 
            this.tourNameTextBox.Location = new System.Drawing.Point(116, 1);
            this.tourNameTextBox.Name = "tourNameTextBox";
            this.tourNameTextBox.Size = new System.Drawing.Size(292, 22);
            this.tourNameTextBox.TabIndex = 0;
            // 
            // chosenTourDgtv
            // 
            this.chosenTourDgtv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.chosenTourDgtv.Location = new System.Drawing.Point(3, 177);
            this.chosenTourDgtv.Name = "chosenTourDgtv";
            this.chosenTourDgtv.RowHeadersWidth = 51;
            this.chosenTourDgtv.RowTemplate.Height = 24;
            this.chosenTourDgtv.Size = new System.Drawing.Size(417, 274);
            this.chosenTourDgtv.TabIndex = 14;
            // 
            // chosenServiceLabel
            // 
            this.chosenServiceLabel.AutoSize = true;
            this.chosenServiceLabel.Location = new System.Drawing.Point(2, 158);
            this.chosenServiceLabel.Name = "chosenServiceLabel";
            this.chosenServiceLabel.Size = new System.Drawing.Size(89, 16);
            this.chosenServiceLabel.TabIndex = 16;
            this.chosenServiceLabel.Text = "Tour đã chọn:";
            // 
            // confirmBtn
            // 
            this.confirmBtn.Location = new System.Drawing.Point(228, 474);
            this.confirmBtn.Name = "confirmBtn";
            this.confirmBtn.Size = new System.Drawing.Size(83, 23);
            this.confirmBtn.TabIndex = 15;
            this.confirmBtn.Text = "Xác nhận";
            this.confirmBtn.UseVisualStyleBackColor = true;
            this.confirmBtn.Click += new System.EventHandler(this.confirmBtn_Click);
            // 
            // cancelBtn
            // 
            this.cancelBtn.Location = new System.Drawing.Point(328, 474);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(90, 23);
            this.cancelBtn.TabIndex = 17;
            this.cancelBtn.Text = "Thoát";
            this.cancelBtn.UseVisualStyleBackColor = true;
            this.cancelBtn.Click += new System.EventHandler(this.cancelBtn_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.cancelBtn);
            this.panel1.Controls.Add(this.confirmBtn);
            this.panel1.Controls.Add(this.chosenServiceLabel);
            this.panel1.Controls.Add(this.chosenTourDgtv);
            this.panel1.Controls.Add(this.tourInfoPanel);
            this.panel1.Location = new System.Drawing.Point(632, 34);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(423, 500);
            this.panel1.TabIndex = 15;
            // 
            // fSearchingTravelTour
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.listTourLabel);
            this.Controls.Add(this.tourDtgv);
            this.Name = "fSearchingTravelTour";
            this.Text = "Tra cứu tour du lịch";
            ((System.ComponentModel.ISupportInitialize)(this.tourDtgv)).EndInit();
            this.tourInfoPanel.ResumeLayout(false);
            this.supplierPanel.ResumeLayout(false);
            this.supplierPanel.PerformLayout();
            this.tourIdPanel.ResumeLayout(false);
            this.tourIdPanel.PerformLayout();
            this.tourNamePanel.ResumeLayout(false);
            this.tourNamePanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chosenTourDgtv)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label listTourLabel;
        private System.Windows.Forms.DataGridView tourDtgv;
        private System.Windows.Forms.Panel tourInfoPanel;
        private System.Windows.Forms.Panel supplierPanel;
        private System.Windows.Forms.Label supplierLabel;
        private System.Windows.Forms.TextBox supplierTextBox;
        private System.Windows.Forms.Button deleteBtn;
        private System.Windows.Forms.Button addBtn;
        private System.Windows.Forms.Button serviceSearchingBtn;
        private System.Windows.Forms.Panel tourIdPanel;
        private System.Windows.Forms.Label tourId;
        private System.Windows.Forms.TextBox tourIdTextBox;
        private System.Windows.Forms.Panel tourNamePanel;
        private System.Windows.Forms.Label tourName;
        private System.Windows.Forms.TextBox tourNameTextBox;
        private System.Windows.Forms.DataGridView chosenTourDgtv;
        private System.Windows.Forms.Label chosenServiceLabel;
        private System.Windows.Forms.Button confirmBtn;
        private System.Windows.Forms.Button cancelBtn;
        private System.Windows.Forms.Panel panel1;
    }
}