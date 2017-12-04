namespace BookBrokersStore
{
    partial class InvoicesForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InvoicesForm));
            this.btnPrintInvoices = new System.Windows.Forms.Button();
            this.btnReturn = new System.Windows.Forms.Button();
            this.printInvoices = new System.Drawing.Printing.PrintDocument();
            this.prvInvoices = new System.Windows.Forms.PrintPreviewDialog();
            this.SuspendLayout();
            // 
            // btnPrintInvoices
            // 
            this.btnPrintInvoices.Location = new System.Drawing.Point(22, 26);
            this.btnPrintInvoices.Name = "btnPrintInvoices";
            this.btnPrintInvoices.Size = new System.Drawing.Size(183, 23);
            this.btnPrintInvoices.TabIndex = 0;
            this.btnPrintInvoices.Text = "Print Invoices";
            this.btnPrintInvoices.UseVisualStyleBackColor = true;
            this.btnPrintInvoices.Click += new System.EventHandler(this.btnPrintInvoices_Click);
            // 
            // btnReturn
            // 
            this.btnReturn.Location = new System.Drawing.Point(265, 26);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(191, 23);
            this.btnReturn.TabIndex = 1;
            this.btnReturn.Text = "Return";
            this.btnReturn.UseVisualStyleBackColor = true;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // printInvoices
            // 
            this.printInvoices.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printInvoices_PrintPage);
            // 
            // prvInvoices
            // 
            this.prvInvoices.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.prvInvoices.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.prvInvoices.ClientSize = new System.Drawing.Size(400, 300);
            this.prvInvoices.Document = this.printInvoices;
            this.prvInvoices.Enabled = true;
            this.prvInvoices.Icon = ((System.Drawing.Icon)(resources.GetObject("prvInvoices.Icon")));
            this.prvInvoices.Name = "prvInvoices";
            this.prvInvoices.Visible = false;
            // 
            // InvoicesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(468, 74);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.btnPrintInvoices);
            this.Name = "InvoicesForm";
            this.Text = "Invoices";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnPrintInvoices;
        private System.Windows.Forms.Button btnReturn;
        private System.Drawing.Printing.PrintDocument printInvoices;
        private System.Windows.Forms.PrintPreviewDialog prvInvoices;
    }
}