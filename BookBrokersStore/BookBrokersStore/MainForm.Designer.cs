namespace BookBrokersStore
{
    partial class MainForm
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
            this.grpMaintenance = new System.Windows.Forms.GroupBox();
            this.btnAddBook = new System.Windows.Forms.Button();
            this.btnOrder = new System.Windows.Forms.Button();
            this.btnBook = new System.Windows.Forms.Button();
            this.btnBookInfo = new System.Windows.Forms.Button();
            this.btnClient = new System.Windows.Forms.Button();
            this.btnVendor = new System.Windows.Forms.Button();
            this.grpReport = new System.Windows.Forms.GroupBox();
            this.btnInvoices = new System.Windows.Forms.Button();
            this.btnVendors = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.grpMaintenance.SuspendLayout();
            this.grpReport.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpMaintenance
            // 
            this.grpMaintenance.Controls.Add(this.btnAddBook);
            this.grpMaintenance.Controls.Add(this.btnOrder);
            this.grpMaintenance.Controls.Add(this.btnBook);
            this.grpMaintenance.Controls.Add(this.btnBookInfo);
            this.grpMaintenance.Controls.Add(this.btnClient);
            this.grpMaintenance.Controls.Add(this.btnVendor);
            this.grpMaintenance.Location = new System.Drawing.Point(30, 12);
            this.grpMaintenance.Name = "grpMaintenance";
            this.grpMaintenance.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.grpMaintenance.Size = new System.Drawing.Size(241, 312);
            this.grpMaintenance.TabIndex = 0;
            this.grpMaintenance.TabStop = false;
            this.grpMaintenance.Text = "Maintenance";
            // 
            // btnAddBook
            // 
            this.btnAddBook.Location = new System.Drawing.Point(40, 273);
            this.btnAddBook.Name = "btnAddBook";
            this.btnAddBook.Size = new System.Drawing.Size(157, 23);
            this.btnAddBook.TabIndex = 5;
            this.btnAddBook.Text = "Add Book to a Client Order";
            this.btnAddBook.UseVisualStyleBackColor = true;
            this.btnAddBook.Click += new System.EventHandler(this.btnAddBook_Click);
            // 
            // btnOrder
            // 
            this.btnOrder.Location = new System.Drawing.Point(40, 226);
            this.btnOrder.Name = "btnOrder";
            this.btnOrder.Size = new System.Drawing.Size(157, 23);
            this.btnOrder.TabIndex = 4;
            this.btnOrder.Text = "Client Order Maintenance";
            this.btnOrder.UseVisualStyleBackColor = true;
            this.btnOrder.Click += new System.EventHandler(this.btnOrder_Click);
            // 
            // btnBook
            // 
            this.btnBook.Location = new System.Drawing.Point(40, 174);
            this.btnBook.Name = "btnBook";
            this.btnBook.Size = new System.Drawing.Size(157, 23);
            this.btnBook.TabIndex = 3;
            this.btnBook.Text = "Book Maintenance";
            this.btnBook.UseVisualStyleBackColor = true;
            this.btnBook.Click += new System.EventHandler(this.btnBook_Click);
            // 
            // btnBookInfo
            // 
            this.btnBookInfo.Location = new System.Drawing.Point(40, 125);
            this.btnBookInfo.Name = "btnBookInfo";
            this.btnBookInfo.Size = new System.Drawing.Size(157, 23);
            this.btnBookInfo.TabIndex = 2;
            this.btnBookInfo.Text = "Book Info Maintenance";
            this.btnBookInfo.UseVisualStyleBackColor = true;
            this.btnBookInfo.Click += new System.EventHandler(this.btnBookInfo_Click);
            // 
            // btnClient
            // 
            this.btnClient.Location = new System.Drawing.Point(40, 77);
            this.btnClient.Name = "btnClient";
            this.btnClient.Size = new System.Drawing.Size(157, 23);
            this.btnClient.TabIndex = 1;
            this.btnClient.Text = "Client Maintenance";
            this.btnClient.UseVisualStyleBackColor = true;
            this.btnClient.Click += new System.EventHandler(this.btnClient_Click);
            // 
            // btnVendor
            // 
            this.btnVendor.Location = new System.Drawing.Point(40, 32);
            this.btnVendor.Name = "btnVendor";
            this.btnVendor.Size = new System.Drawing.Size(157, 23);
            this.btnVendor.TabIndex = 0;
            this.btnVendor.Text = "Vendor Maintenance";
            this.btnVendor.UseVisualStyleBackColor = true;
            this.btnVendor.Click += new System.EventHandler(this.btnVendor_Click);
            // 
            // grpReport
            // 
            this.grpReport.Controls.Add(this.btnInvoices);
            this.grpReport.Controls.Add(this.btnVendors);
            this.grpReport.Controls.Add(this.btnExit);
            this.grpReport.Location = new System.Drawing.Point(356, 12);
            this.grpReport.Name = "grpReport";
            this.grpReport.Size = new System.Drawing.Size(234, 312);
            this.grpReport.TabIndex = 1;
            this.grpReport.TabStop = false;
            this.grpReport.Text = "Reporting";
            // 
            // btnInvoices
            // 
            this.btnInvoices.Location = new System.Drawing.Point(54, 32);
            this.btnInvoices.Name = "btnInvoices";
            this.btnInvoices.Size = new System.Drawing.Size(123, 23);
            this.btnInvoices.TabIndex = 6;
            this.btnInvoices.Text = "Invoices";
            this.btnInvoices.UseVisualStyleBackColor = true;
            this.btnInvoices.Click += new System.EventHandler(this.btnInvoices_Click);
            // 
            // btnVendors
            // 
            this.btnVendors.Location = new System.Drawing.Point(54, 77);
            this.btnVendors.Name = "btnVendors";
            this.btnVendors.Size = new System.Drawing.Size(123, 23);
            this.btnVendors.TabIndex = 7;
            this.btnVendors.Text = "Vendors";
            this.btnVendors.UseVisualStyleBackColor = true;
            this.btnVendors.Click += new System.EventHandler(this.btnVendors_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(54, 273);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(123, 23);
            this.btnExit.TabIndex = 8;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(662, 328);
            this.Controls.Add(this.grpReport);
            this.Controls.Add(this.grpMaintenance);
            this.Name = "MainForm";
            this.Text = "Main Menu";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.grpMaintenance.ResumeLayout(false);
            this.grpReport.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpMaintenance;
        private System.Windows.Forms.Button btnAddBook;
        private System.Windows.Forms.Button btnOrder;
        private System.Windows.Forms.Button btnBook;
        private System.Windows.Forms.Button btnBookInfo;
        private System.Windows.Forms.Button btnClient;
        private System.Windows.Forms.Button btnVendor;
        private System.Windows.Forms.GroupBox grpReport;
        private System.Windows.Forms.Button btnInvoices;
        private System.Windows.Forms.Button btnVendors;
        private System.Windows.Forms.Button btnExit;
    }
}

