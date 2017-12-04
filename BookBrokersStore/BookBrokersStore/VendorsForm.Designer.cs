namespace BookBrokersStore
{
    partial class VendorsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VendorsForm));
            this.btnReturn = new System.Windows.Forms.Button();
            this.btnPrintVendors = new System.Windows.Forms.Button();
            this.printVendors = new System.Drawing.Printing.PrintDocument();
            this.prvVendors = new System.Windows.Forms.PrintPreviewDialog();
            this.SuspendLayout();
            // 
            // btnReturn
            // 
            this.btnReturn.Location = new System.Drawing.Point(255, 12);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(191, 23);
            this.btnReturn.TabIndex = 3;
            this.btnReturn.Text = "Return";
            this.btnReturn.UseVisualStyleBackColor = true;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // btnPrintVendors
            // 
            this.btnPrintVendors.Location = new System.Drawing.Point(12, 12);
            this.btnPrintVendors.Name = "btnPrintVendors";
            this.btnPrintVendors.Size = new System.Drawing.Size(183, 23);
            this.btnPrintVendors.TabIndex = 2;
            this.btnPrintVendors.Text = "Print Vendors";
            this.btnPrintVendors.UseVisualStyleBackColor = true;
            this.btnPrintVendors.Click += new System.EventHandler(this.btnPrintVendors_Click);
            // 
            // printVendors
            // 
            this.printVendors.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printVendors_PrintPage);
            // 
            // prvVendors
            // 
            this.prvVendors.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.prvVendors.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.prvVendors.ClientSize = new System.Drawing.Size(400, 300);
            this.prvVendors.Document = this.printVendors;
            this.prvVendors.Enabled = true;
            this.prvVendors.Icon = ((System.Drawing.Icon)(resources.GetObject("prvVendors.Icon")));
            this.prvVendors.Name = "prvVendors";
            this.prvVendors.Visible = false;
            // 
            // VendorsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(460, 54);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.btnPrintVendors);
            this.Name = "VendorsForm";
            this.Text = "Vendors";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.Button btnPrintVendors;
        private System.Drawing.Printing.PrintDocument printVendors;
        private System.Windows.Forms.PrintPreviewDialog prvVendors;
    }
}