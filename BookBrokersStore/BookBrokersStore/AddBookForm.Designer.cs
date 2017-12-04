namespace BookBrokersStore
{
    partial class AddBookForm
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
            this.dgvClient = new System.Windows.Forms.DataGridView();
            this.dgvBook = new System.Windows.Forms.DataGridView();
            this.dgvOrderBook = new System.Windows.Forms.DataGridView();
            this.btnAddBook = new System.Windows.Forms.Button();
            this.btnRemoveBook = new System.Windows.Forms.Button();
            this.btnReturn = new System.Windows.Forms.Button();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.txtClientLastName = new System.Windows.Forms.TextBox();
            this.txtClientFirstName = new System.Windows.Forms.TextBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblClientLastName = new System.Windows.Forms.Label();
            this.lblClientFirstName = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClient)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBook)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrderBook)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvClient
            // 
            this.dgvClient.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvClient.Location = new System.Drawing.Point(12, 12);
            this.dgvClient.Name = "dgvClient";
            this.dgvClient.Size = new System.Drawing.Size(447, 153);
            this.dgvClient.TabIndex = 0;
            this.dgvClient.SelectionChanged += new System.EventHandler(this.dgvClient_SelectionChanged);
            // 
            // dgvBook
            // 
            this.dgvBook.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBook.Location = new System.Drawing.Point(483, 186);
            this.dgvBook.Name = "dgvBook";
            this.dgvBook.Size = new System.Drawing.Size(407, 150);
            this.dgvBook.TabIndex = 1;
            this.dgvBook.SelectionChanged += new System.EventHandler(this.dgvBook_SelectionChanged);
            // 
            // dgvOrderBook
            // 
            this.dgvOrderBook.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOrderBook.Location = new System.Drawing.Point(12, 186);
            this.dgvOrderBook.Name = "dgvOrderBook";
            this.dgvOrderBook.Size = new System.Drawing.Size(447, 150);
            this.dgvOrderBook.TabIndex = 2;
            // 
            // btnAddBook
            // 
            this.btnAddBook.Location = new System.Drawing.Point(150, 398);
            this.btnAddBook.Name = "btnAddBook";
            this.btnAddBook.Size = new System.Drawing.Size(106, 23);
            this.btnAddBook.TabIndex = 3;
            this.btnAddBook.Text = "Add Book";
            this.btnAddBook.UseVisualStyleBackColor = true;
            this.btnAddBook.Click += new System.EventHandler(this.btnAddBook_Click);
            // 
            // btnRemoveBook
            // 
            this.btnRemoveBook.Location = new System.Drawing.Point(412, 398);
            this.btnRemoveBook.Name = "btnRemoveBook";
            this.btnRemoveBook.Size = new System.Drawing.Size(120, 23);
            this.btnRemoveBook.TabIndex = 4;
            this.btnRemoveBook.Text = "Remove Book";
            this.btnRemoveBook.UseVisualStyleBackColor = true;
            this.btnRemoveBook.Click += new System.EventHandler(this.btnRemoveBook_Click);
            // 
            // btnReturn
            // 
            this.btnReturn.Location = new System.Drawing.Point(691, 398);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(115, 23);
            this.btnReturn.TabIndex = 5;
            this.btnReturn.Text = "Return";
            this.btnReturn.UseVisualStyleBackColor = true;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // txtTitle
            // 
            this.txtTitle.Location = new System.Drawing.Point(383, 357);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(255, 20);
            this.txtTitle.TabIndex = 6;
            // 
            // txtClientLastName
            // 
            this.txtClientLastName.Location = new System.Drawing.Point(644, 57);
            this.txtClientLastName.Name = "txtClientLastName";
            this.txtClientLastName.Size = new System.Drawing.Size(100, 20);
            this.txtClientLastName.TabIndex = 7;
            // 
            // txtClientFirstName
            // 
            this.txtClientFirstName.Location = new System.Drawing.Point(644, 90);
            this.txtClientFirstName.Name = "txtClientFirstName";
            this.txtClientFirstName.Size = new System.Drawing.Size(100, 20);
            this.txtClientFirstName.TabIndex = 8;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Location = new System.Drawing.Point(347, 360);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(30, 13);
            this.lblTitle.TabIndex = 9;
            this.lblTitle.Text = "Title:";
            // 
            // lblClientLastName
            // 
            this.lblClientLastName.AutoSize = true;
            this.lblClientLastName.Location = new System.Drawing.Point(548, 60);
            this.lblClientLastName.Name = "lblClientLastName";
            this.lblClientLastName.Size = new System.Drawing.Size(90, 13);
            this.lblClientLastName.TabIndex = 10;
            this.lblClientLastName.Text = "Client Last Name:";
            // 
            // lblClientFirstName
            // 
            this.lblClientFirstName.AutoSize = true;
            this.lblClientFirstName.Location = new System.Drawing.Point(549, 93);
            this.lblClientFirstName.Name = "lblClientFirstName";
            this.lblClientFirstName.Size = new System.Drawing.Size(89, 13);
            this.lblClientFirstName.TabIndex = 11;
            this.lblClientFirstName.Text = "Client First Name:";
            // 
            // AddBookForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(902, 429);
            this.Controls.Add(this.lblClientFirstName);
            this.Controls.Add(this.lblClientLastName);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.txtClientFirstName);
            this.Controls.Add(this.txtClientLastName);
            this.Controls.Add(this.txtTitle);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.btnRemoveBook);
            this.Controls.Add(this.btnAddBook);
            this.Controls.Add(this.dgvOrderBook);
            this.Controls.Add(this.dgvBook);
            this.Controls.Add(this.dgvClient);
            this.Name = "AddBookForm";
            this.Text = "Add Book to a Client Order";
            ((System.ComponentModel.ISupportInitialize)(this.dgvClient)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBook)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrderBook)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvClient;
        private System.Windows.Forms.DataGridView dgvBook;
        private System.Windows.Forms.DataGridView dgvOrderBook;
        private System.Windows.Forms.Button btnAddBook;
        private System.Windows.Forms.Button btnRemoveBook;
        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.TextBox txtClientLastName;
        private System.Windows.Forms.TextBox txtClientFirstName;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblClientLastName;
        private System.Windows.Forms.Label lblClientFirstName;
    }
}