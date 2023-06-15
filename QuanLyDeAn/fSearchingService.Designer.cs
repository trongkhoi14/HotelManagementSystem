namespace QuanLyDeAn
{
    partial class fSearchingService
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
            this.serviceDtgv = new System.Windows.Forms.DataGridView();
            this.listServiceLabel = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cancelBtn = new System.Windows.Forms.Button();
            this.chosenServiceLabel = new System.Windows.Forms.Label();
            this.chosenServiceDtgv = new System.Windows.Forms.DataGridView();
            this.serviceInfoPanel = new System.Windows.Forms.Panel();
            this.deleteBtn = new System.Windows.Forms.Button();
            this.addBtn = new System.Windows.Forms.Button();
            this.serviceSearchingBtn = new System.Windows.Forms.Button();
            this.serviceIdPanel = new System.Windows.Forms.Panel();
            this.serviceId = new System.Windows.Forms.Label();
            this.serviceIdTextBox = new System.Windows.Forms.TextBox();
            this.serviceNamePanel = new System.Windows.Forms.Panel();
            this.serviceName = new System.Windows.Forms.Label();
            this.serviceNameTextBox = new System.Windows.Forms.TextBox();
            this.confirmBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.serviceDtgv)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chosenServiceDtgv)).BeginInit();
            this.serviceInfoPanel.SuspendLayout();
            this.serviceIdPanel.SuspendLayout();
            this.serviceNamePanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // serviceDtgv
            // 
            this.serviceDtgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.serviceDtgv.Location = new System.Drawing.Point(15, 34);
            this.serviceDtgv.Name = "serviceDtgv";
            this.serviceDtgv.RowHeadersWidth = 51;
            this.serviceDtgv.RowTemplate.Height = 24;
            this.serviceDtgv.Size = new System.Drawing.Size(594, 451);
            this.serviceDtgv.TabIndex = 6;
            // 
            // listServiceLabel
            // 
            this.listServiceLabel.AutoSize = true;
            this.listServiceLabel.Location = new System.Drawing.Point(12, 15);
            this.listServiceLabel.Name = "listServiceLabel";
            this.listServiceLabel.Size = new System.Drawing.Size(119, 16);
            this.listServiceLabel.TabIndex = 7;
            this.listServiceLabel.Text = "Danh sách dịch vụ:";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.cancelBtn);
            this.panel1.Controls.Add(this.confirmBtn);
            this.panel1.Controls.Add(this.chosenServiceLabel);
            this.panel1.Controls.Add(this.chosenServiceDtgv);
            this.panel1.Controls.Add(this.serviceInfoPanel);
            this.panel1.Location = new System.Drawing.Point(632, 34);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(423, 500);
            this.panel1.TabIndex = 8;
            // 
            // cancelBtn
            // 
            this.cancelBtn.Location = new System.Drawing.Point(324, 474);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(90, 23);
            this.cancelBtn.TabIndex = 10;
            this.cancelBtn.Text = "Thoát";
            this.cancelBtn.UseVisualStyleBackColor = true;
            // 
<<<<<<< Updated upstream
=======
            // confirmBtn
            // 
            this.confirmBtn.Location = new System.Drawing.Point(228, 474);
            this.confirmBtn.Name = "confirmBtn";
            this.confirmBtn.Size = new System.Drawing.Size(90, 23);
            this.confirmBtn.TabIndex = 8;
            this.confirmBtn.Text = "Xác nhận";
            this.confirmBtn.UseVisualStyleBackColor = true;
            this.confirmBtn.Click += new System.EventHandler(this.confirmBtn_Click);
            // 
>>>>>>> Stashed changes
            // chosenServiceLabel
            // 
            this.chosenServiceLabel.AutoSize = true;
            this.chosenServiceLabel.Location = new System.Drawing.Point(1, 128);
            this.chosenServiceLabel.Name = "chosenServiceLabel";
            this.chosenServiceLabel.Size = new System.Drawing.Size(105, 16);
            this.chosenServiceLabel.TabIndex = 9;
            this.chosenServiceLabel.Text = "Dịch vụ đã chọn:";
            // 
            // chosenServiceDtgv
            // 
            this.chosenServiceDtgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.chosenServiceDtgv.Location = new System.Drawing.Point(3, 147);
            this.chosenServiceDtgv.Name = "chosenServiceDtgv";
            this.chosenServiceDtgv.RowHeadersWidth = 51;
            this.chosenServiceDtgv.RowTemplate.Height = 24;
            this.chosenServiceDtgv.Size = new System.Drawing.Size(420, 304);
            this.chosenServiceDtgv.TabIndex = 7;
            // 
            // serviceInfoPanel
            // 
            this.serviceInfoPanel.Controls.Add(this.deleteBtn);
            this.serviceInfoPanel.Controls.Add(this.addBtn);
            this.serviceInfoPanel.Controls.Add(this.serviceSearchingBtn);
            this.serviceInfoPanel.Controls.Add(this.serviceIdPanel);
            this.serviceInfoPanel.Controls.Add(this.serviceNamePanel);
            this.serviceInfoPanel.Location = new System.Drawing.Point(3, 3);
            this.serviceInfoPanel.Name = "serviceInfoPanel";
            this.serviceInfoPanel.Size = new System.Drawing.Size(417, 101);
            this.serviceInfoPanel.TabIndex = 6;
            // 
            // deleteBtn
            // 
            this.deleteBtn.Location = new System.Drawing.Point(321, 69);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Size = new System.Drawing.Size(90, 23);
            this.deleteBtn.TabIndex = 5;
            this.deleteBtn.Text = "Xóa";
            this.deleteBtn.UseVisualStyleBackColor = true;
            this.deleteBtn.Click += new System.EventHandler(this.deleteBtn_Click);
            // 
            // addBtn
            // 
            this.addBtn.Location = new System.Drawing.Point(225, 69);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(90, 23);
            this.addBtn.TabIndex = 4;
            this.addBtn.Text = "Thêm";
            this.addBtn.UseVisualStyleBackColor = true;
            this.addBtn.Click += new System.EventHandler(this.addBtn_Click);
            // 
            // serviceSearchingBtn
            // 
            this.serviceSearchingBtn.Location = new System.Drawing.Point(129, 69);
            this.serviceSearchingBtn.Name = "serviceSearchingBtn";
            this.serviceSearchingBtn.Size = new System.Drawing.Size(90, 23);
            this.serviceSearchingBtn.TabIndex = 3;
            this.serviceSearchingBtn.Text = "Tìm kiếm";
            this.serviceSearchingBtn.UseVisualStyleBackColor = true;
            this.serviceSearchingBtn.Click += new System.EventHandler(this.serviceSearchingBtn_Click);
            // 
            // serviceIdPanel
            // 
            this.serviceIdPanel.Controls.Add(this.serviceId);
            this.serviceIdPanel.Controls.Add(this.serviceIdTextBox);
            this.serviceIdPanel.Location = new System.Drawing.Point(2, 36);
            this.serviceIdPanel.Name = "serviceIdPanel";
            this.serviceIdPanel.Size = new System.Drawing.Size(415, 27);
            this.serviceIdPanel.TabIndex = 2;
            // 
            // serviceId
            // 
            this.serviceId.AutoSize = true;
            this.serviceId.Location = new System.Drawing.Point(5, 4);
            this.serviceId.Name = "serviceId";
            this.serviceId.Size = new System.Drawing.Size(74, 16);
            this.serviceId.TabIndex = 0;
            this.serviceId.Text = "Mã dịch vụ:";
            // 
            // serviceIdTextBox
            // 
            this.serviceIdTextBox.Location = new System.Drawing.Point(116, 1);
            this.serviceIdTextBox.Name = "serviceIdTextBox";
            this.serviceIdTextBox.Size = new System.Drawing.Size(293, 22);
            this.serviceIdTextBox.TabIndex = 0;
            // 
            // serviceNamePanel
            // 
            this.serviceNamePanel.Controls.Add(this.serviceName);
            this.serviceNamePanel.Controls.Add(this.serviceNameTextBox);
            this.serviceNamePanel.Location = new System.Drawing.Point(3, 3);
            this.serviceNamePanel.Name = "serviceNamePanel";
            this.serviceNamePanel.Size = new System.Drawing.Size(412, 27);
            this.serviceNamePanel.TabIndex = 1;
            // 
            // serviceName
            // 
            this.serviceName.AutoSize = true;
            this.serviceName.Location = new System.Drawing.Point(4, 4);
            this.serviceName.Name = "serviceName";
            this.serviceName.Size = new System.Drawing.Size(79, 16);
            this.serviceName.TabIndex = 0;
            this.serviceName.Text = "Tên dịch vụ:";
            // 
            // serviceNameTextBox
            // 
            this.serviceNameTextBox.Location = new System.Drawing.Point(116, 1);
            this.serviceNameTextBox.Name = "serviceNameTextBox";
            this.serviceNameTextBox.Size = new System.Drawing.Size(292, 22);
            this.serviceNameTextBox.TabIndex = 0;
            // 
            // confirmBtn
            // 
            this.confirmBtn.Location = new System.Drawing.Point(228, 474);
            this.confirmBtn.Name = "confirmBtn";
            this.confirmBtn.Size = new System.Drawing.Size(90, 23);
            this.confirmBtn.TabIndex = 8;
            this.confirmBtn.Text = "Xác nhận";
            this.confirmBtn.UseVisualStyleBackColor = true;
            // 
            // fSearchingService
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.listServiceLabel);
            this.Controls.Add(this.serviceDtgv);
            this.Name = "fSearchingService";
            this.Text = "fSearchingService";
            ((System.ComponentModel.ISupportInitialize)(this.serviceDtgv)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chosenServiceDtgv)).EndInit();
            this.serviceInfoPanel.ResumeLayout(false);
            this.serviceIdPanel.ResumeLayout(false);
            this.serviceIdPanel.PerformLayout();
            this.serviceNamePanel.ResumeLayout(false);
            this.serviceNamePanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView serviceDtgv;
        private System.Windows.Forms.Label listServiceLabel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button cancelBtn;
        private System.Windows.Forms.Button confirmBtn;
        private System.Windows.Forms.Label chosenServiceLabel;
        private System.Windows.Forms.DataGridView chosenServiceDtgv;
        private System.Windows.Forms.Panel serviceInfoPanel;
        private System.Windows.Forms.Button deleteBtn;
        private System.Windows.Forms.Button addBtn;
        private System.Windows.Forms.Button serviceSearchingBtn;
        private System.Windows.Forms.Panel serviceIdPanel;
        private System.Windows.Forms.Label serviceId;
        private System.Windows.Forms.TextBox serviceIdTextBox;
        private System.Windows.Forms.Panel serviceNamePanel;
        private System.Windows.Forms.Label serviceName;
        private System.Windows.Forms.TextBox serviceNameTextBox;
    }
}