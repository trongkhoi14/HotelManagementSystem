namespace QuanLyDeAn
{
    partial class fServiceFormDetail
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
            this.serviceListDtgv = new System.Windows.Forms.DataGridView();
            this.prepaidBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.serviceListDtgv)).BeginInit();
            this.SuspendLayout();
            // 
            // serviceListDtgv
            // 
            this.serviceListDtgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.serviceListDtgv.Location = new System.Drawing.Point(12, 12);
            this.serviceListDtgv.Name = "serviceListDtgv";
            this.serviceListDtgv.RowHeadersWidth = 51;
            this.serviceListDtgv.RowTemplate.Height = 24;
            this.serviceListDtgv.Size = new System.Drawing.Size(1043, 498);
            this.serviceListDtgv.TabIndex = 0;
            // 
            // prepaidBtn
            // 
            this.prepaidBtn.Location = new System.Drawing.Point(848, 519);
            this.prepaidBtn.Name = "prepaidBtn";
            this.prepaidBtn.Size = new System.Drawing.Size(207, 23);
            this.prepaidBtn.TabIndex = 1;
            this.prepaidBtn.Text = "Tính phí dịch vụ tạm thời";
            this.prepaidBtn.UseVisualStyleBackColor = true;
            this.prepaidBtn.Click += new System.EventHandler(this.prepaidBtn_Click);
            // 
            // fServiceFormDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.prepaidBtn);
            this.Controls.Add(this.serviceListDtgv);
            this.Name = "fServiceFormDetail";
            this.Text = "fServiceFromDetail";
            ((System.ComponentModel.ISupportInitialize)(this.serviceListDtgv)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView serviceListDtgv;
        private System.Windows.Forms.Button prepaidBtn;
    }
}