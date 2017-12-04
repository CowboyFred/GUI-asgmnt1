namespace BookBrokersStore
{
    partial class BookForm
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
            this.btnReturn = new System.Windows.Forms.Button();
            this.btnPrevious = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnAddBook = new System.Windows.Forms.Button();
            this.btnUpdateBook = new System.Windows.Forms.Button();
            this.btnDeleteBook = new System.Windows.Forms.Button();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.txtDatePublished = new System.Windows.Forms.TextBox();
            this.txtBookID = new System.Windows.Forms.TextBox();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.txtCost = new System.Windows.Forms.TextBox();
            this.lblCost = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblBookID = new System.Windows.Forms.Label();
            this.lblDatePublished = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.lstBook = new System.Windows.Forms.ListBox();
            this.txtClientID = new System.Windows.Forms.TextBox();
            this.txtVendorID = new System.Windows.Forms.TextBox();
            this.txtVendorName = new System.Windows.Forms.TextBox();
            this.lblVendorName = new System.Windows.Forms.Label();
            this.lblVendorID = new System.Windows.Forms.Label();
            this.lblClientID = new System.Windows.Forms.Label();
            this.pnlAddBook = new System.Windows.Forms.Panel();
            this.btnAddCancel = new System.Windows.Forms.Button();
            this.btnAddSave = new System.Windows.Forms.Button();
            this.dtpAddDatePublished = new System.Windows.Forms.DateTimePicker();
            this.txtAddPrice = new System.Windows.Forms.TextBox();
            this.txtAddCost = new System.Windows.Forms.TextBox();
            this.cboAddTitle = new System.Windows.Forms.ComboBox();
            this.cboAddVendorName = new System.Windows.Forms.ComboBox();
            this.cboAddVendorID = new System.Windows.Forms.ComboBox();
            this.cboAddBookID = new System.Windows.Forms.ComboBox();
            this.lblAddBookInfo = new System.Windows.Forms.Label();
            this.lblAddCost = new System.Windows.Forms.Label();
            this.lblAddPrice = new System.Windows.Forms.Label();
            this.lblAddDatePublished = new System.Windows.Forms.Label();
            this.lblAddVendor = new System.Windows.Forms.Label();
            this.pnlUpdBook = new System.Windows.Forms.Panel();
            this.btnUpdCancel = new System.Windows.Forms.Button();
            this.btnUpdSave = new System.Windows.Forms.Button();
            this.dtpUpdDatePublished = new System.Windows.Forms.DateTimePicker();
            this.txtUpdPrice = new System.Windows.Forms.TextBox();
            this.txtUpdCost = new System.Windows.Forms.TextBox();
            this.cboUpdTitle = new System.Windows.Forms.ComboBox();
            this.cboUpdVendorName = new System.Windows.Forms.ComboBox();
            this.cboUpdVendorID = new System.Windows.Forms.ComboBox();
            this.cboUpdBookID = new System.Windows.Forms.ComboBox();
            this.lblUpdBookInfo = new System.Windows.Forms.Label();
            this.lblUpdCost = new System.Windows.Forms.Label();
            this.lblUpdPrice = new System.Windows.Forms.Label();
            this.lblUpdDatePublished = new System.Windows.Forms.Label();
            this.lblUpdVendor = new System.Windows.Forms.Label();
            this.pnlAddBook.SuspendLayout();
            this.pnlUpdBook.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnReturn
            // 
            this.btnReturn.Location = new System.Drawing.Point(464, 353);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(75, 23);
            this.btnReturn.TabIndex = 33;
            this.btnReturn.Text = "Return";
            this.btnReturn.UseVisualStyleBackColor = true;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // btnPrevious
            // 
            this.btnPrevious.Location = new System.Drawing.Point(12, 324);
            this.btnPrevious.Name = "btnPrevious";
            this.btnPrevious.Size = new System.Drawing.Size(75, 23);
            this.btnPrevious.TabIndex = 32;
            this.btnPrevious.Text = "Previous";
            this.btnPrevious.UseVisualStyleBackColor = true;
            this.btnPrevious.Click += new System.EventHandler(this.btnPrevious_Click);
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(160, 324);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(75, 23);
            this.btnNext.TabIndex = 31;
            this.btnNext.Text = "Next";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnAddBook
            // 
            this.btnAddBook.Location = new System.Drawing.Point(267, 324);
            this.btnAddBook.Name = "btnAddBook";
            this.btnAddBook.Size = new System.Drawing.Size(75, 23);
            this.btnAddBook.TabIndex = 30;
            this.btnAddBook.Text = "Add Book";
            this.btnAddBook.UseVisualStyleBackColor = true;
            this.btnAddBook.Click += new System.EventHandler(this.btnAddBook_Click);
            // 
            // btnUpdateBook
            // 
            this.btnUpdateBook.Location = new System.Drawing.Point(348, 324);
            this.btnUpdateBook.Name = "btnUpdateBook";
            this.btnUpdateBook.Size = new System.Drawing.Size(95, 23);
            this.btnUpdateBook.TabIndex = 29;
            this.btnUpdateBook.Text = "Update Book";
            this.btnUpdateBook.UseVisualStyleBackColor = true;
            this.btnUpdateBook.Click += new System.EventHandler(this.btnUpdateBook_Click);
            // 
            // btnDeleteBook
            // 
            this.btnDeleteBook.Location = new System.Drawing.Point(449, 324);
            this.btnDeleteBook.Name = "btnDeleteBook";
            this.btnDeleteBook.Size = new System.Drawing.Size(90, 23);
            this.btnDeleteBook.TabIndex = 28;
            this.btnDeleteBook.Text = "Delete Book";
            this.btnDeleteBook.UseVisualStyleBackColor = true;
            this.btnDeleteBook.Click += new System.EventHandler(this.btnDeleteBook_Click);
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(333, 130);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(51, 20);
            this.txtPrice.TabIndex = 27;
            // 
            // txtDatePublished
            // 
            this.txtDatePublished.Location = new System.Drawing.Point(333, 165);
            this.txtDatePublished.Name = "txtDatePublished";
            this.txtDatePublished.Size = new System.Drawing.Size(63, 20);
            this.txtDatePublished.TabIndex = 26;
            // 
            // txtBookID
            // 
            this.txtBookID.Location = new System.Drawing.Point(333, 30);
            this.txtBookID.Name = "txtBookID";
            this.txtBookID.Size = new System.Drawing.Size(51, 20);
            this.txtBookID.TabIndex = 25;
            this.txtBookID.TextChanged += new System.EventHandler(this.txtBookID_TextChanged);
            // 
            // txtTitle
            // 
            this.txtTitle.Location = new System.Drawing.Point(333, 64);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(191, 20);
            this.txtTitle.TabIndex = 24;
            // 
            // txtCost
            // 
            this.txtCost.Location = new System.Drawing.Point(333, 99);
            this.txtCost.Name = "txtCost";
            this.txtCost.Size = new System.Drawing.Size(51, 20);
            this.txtCost.TabIndex = 23;
            // 
            // lblCost
            // 
            this.lblCost.AutoSize = true;
            this.lblCost.Location = new System.Drawing.Point(292, 102);
            this.lblCost.Name = "lblCost";
            this.lblCost.Size = new System.Drawing.Size(31, 13);
            this.lblCost.TabIndex = 22;
            this.lblCost.Text = "Cost:";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Location = new System.Drawing.Point(292, 67);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(30, 13);
            this.lblTitle.TabIndex = 21;
            this.lblTitle.Text = "Title:";
            // 
            // lblBookID
            // 
            this.lblBookID.AutoSize = true;
            this.lblBookID.Location = new System.Drawing.Point(274, 33);
            this.lblBookID.Name = "lblBookID";
            this.lblBookID.Size = new System.Drawing.Size(49, 13);
            this.lblBookID.TabIndex = 20;
            this.lblBookID.Text = "Book ID:";
            // 
            // lblDatePublished
            // 
            this.lblDatePublished.AutoSize = true;
            this.lblDatePublished.Location = new System.Drawing.Point(241, 168);
            this.lblDatePublished.Name = "lblDatePublished";
            this.lblDatePublished.Size = new System.Drawing.Size(82, 13);
            this.lblDatePublished.TabIndex = 19;
            this.lblDatePublished.Text = "Date Published:";
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Location = new System.Drawing.Point(288, 133);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(34, 13);
            this.lblPrice.TabIndex = 18;
            this.lblPrice.Text = "Price:";
            // 
            // lstBook
            // 
            this.lstBook.FormattingEnabled = true;
            this.lstBook.Location = new System.Drawing.Point(12, 12);
            this.lstBook.Name = "lstBook";
            this.lstBook.Size = new System.Drawing.Size(223, 290);
            this.lstBook.TabIndex = 17;
            // 
            // txtClientID
            // 
            this.txtClientID.Location = new System.Drawing.Point(333, 263);
            this.txtClientID.Name = "txtClientID";
            this.txtClientID.Size = new System.Drawing.Size(51, 20);
            this.txtClientID.TabIndex = 43;
            // 
            // txtVendorID
            // 
            this.txtVendorID.Location = new System.Drawing.Point(333, 197);
            this.txtVendorID.Name = "txtVendorID";
            this.txtVendorID.Size = new System.Drawing.Size(51, 20);
            this.txtVendorID.TabIndex = 40;
            this.txtVendorID.TextChanged += new System.EventHandler(this.txtVendorID_TextChanged);
            // 
            // txtVendorName
            // 
            this.txtVendorName.Location = new System.Drawing.Point(333, 232);
            this.txtVendorName.Name = "txtVendorName";
            this.txtVendorName.Size = new System.Drawing.Size(161, 20);
            this.txtVendorName.TabIndex = 39;
            // 
            // lblVendorName
            // 
            this.lblVendorName.AutoSize = true;
            this.lblVendorName.Location = new System.Drawing.Point(247, 235);
            this.lblVendorName.Name = "lblVendorName";
            this.lblVendorName.Size = new System.Drawing.Size(75, 13);
            this.lblVendorName.TabIndex = 38;
            this.lblVendorName.Text = "Vendor Name:";
            // 
            // lblVendorID
            // 
            this.lblVendorID.AutoSize = true;
            this.lblVendorID.Location = new System.Drawing.Point(264, 200);
            this.lblVendorID.Name = "lblVendorID";
            this.lblVendorID.Size = new System.Drawing.Size(58, 13);
            this.lblVendorID.TabIndex = 37;
            this.lblVendorID.Text = "Vendor ID:";
            // 
            // lblClientID
            // 
            this.lblClientID.AutoSize = true;
            this.lblClientID.Location = new System.Drawing.Point(241, 266);
            this.lblClientID.Name = "lblClientID";
            this.lblClientID.Size = new System.Drawing.Size(79, 13);
            this.lblClientID.TabIndex = 34;
            this.lblClientID.Text = "Client Order ID:";
            // 
            // pnlAddBook
            // 
            this.pnlAddBook.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlAddBook.Controls.Add(this.btnAddCancel);
            this.pnlAddBook.Controls.Add(this.btnAddSave);
            this.pnlAddBook.Controls.Add(this.dtpAddDatePublished);
            this.pnlAddBook.Controls.Add(this.txtAddPrice);
            this.pnlAddBook.Controls.Add(this.txtAddCost);
            this.pnlAddBook.Controls.Add(this.cboAddTitle);
            this.pnlAddBook.Controls.Add(this.cboAddVendorName);
            this.pnlAddBook.Controls.Add(this.cboAddVendorID);
            this.pnlAddBook.Controls.Add(this.cboAddBookID);
            this.pnlAddBook.Controls.Add(this.lblAddBookInfo);
            this.pnlAddBook.Controls.Add(this.lblAddCost);
            this.pnlAddBook.Controls.Add(this.lblAddPrice);
            this.pnlAddBook.Controls.Add(this.lblAddDatePublished);
            this.pnlAddBook.Controls.Add(this.lblAddVendor);
            this.pnlAddBook.Location = new System.Drawing.Point(595, 12);
            this.pnlAddBook.Name = "pnlAddBook";
            this.pnlAddBook.Size = new System.Drawing.Size(367, 192);
            this.pnlAddBook.TabIndex = 45;
            this.pnlAddBook.Visible = false;
            // 
            // btnAddCancel
            // 
            this.btnAddCancel.Location = new System.Drawing.Point(235, 152);
            this.btnAddCancel.Name = "btnAddCancel";
            this.btnAddCancel.Size = new System.Drawing.Size(75, 23);
            this.btnAddCancel.TabIndex = 59;
            this.btnAddCancel.Text = "Cancel";
            this.btnAddCancel.UseVisualStyleBackColor = true;
            this.btnAddCancel.Click += new System.EventHandler(this.btnAddCancel_Click);
            // 
            // btnAddSave
            // 
            this.btnAddSave.Location = new System.Drawing.Point(69, 152);
            this.btnAddSave.Name = "btnAddSave";
            this.btnAddSave.Size = new System.Drawing.Size(75, 23);
            this.btnAddSave.TabIndex = 58;
            this.btnAddSave.Text = "Save Book";
            this.btnAddSave.UseVisualStyleBackColor = true;
            this.btnAddSave.Click += new System.EventHandler(this.btnAddSave_Click);
            // 
            // dtpAddDatePublished
            // 
            this.dtpAddDatePublished.Location = new System.Drawing.Point(98, 90);
            this.dtpAddDatePublished.Name = "dtpAddDatePublished";
            this.dtpAddDatePublished.Size = new System.Drawing.Size(149, 20);
            this.dtpAddDatePublished.TabIndex = 57;
            // 
            // txtAddPrice
            // 
            this.txtAddPrice.Location = new System.Drawing.Point(98, 64);
            this.txtAddPrice.Name = "txtAddPrice";
            this.txtAddPrice.Size = new System.Drawing.Size(76, 20);
            this.txtAddPrice.TabIndex = 56;
            // 
            // txtAddCost
            // 
            this.txtAddCost.Location = new System.Drawing.Point(98, 36);
            this.txtAddCost.Name = "txtAddCost";
            this.txtAddCost.Size = new System.Drawing.Size(76, 20);
            this.txtAddCost.TabIndex = 55;
            // 
            // cboAddTitle
            // 
            this.cboAddTitle.FormattingEnabled = true;
            this.cboAddTitle.Location = new System.Drawing.Point(150, 8);
            this.cboAddTitle.Name = "cboAddTitle";
            this.cboAddTitle.Size = new System.Drawing.Size(212, 21);
            this.cboAddTitle.TabIndex = 54;
            // 
            // cboAddVendorName
            // 
            this.cboAddVendorName.FormattingEnabled = true;
            this.cboAddVendorName.Location = new System.Drawing.Point(150, 117);
            this.cboAddVendorName.Name = "cboAddVendorName";
            this.cboAddVendorName.Size = new System.Drawing.Size(212, 21);
            this.cboAddVendorName.TabIndex = 53;
            // 
            // cboAddVendorID
            // 
            this.cboAddVendorID.FormattingEnabled = true;
            this.cboAddVendorID.Location = new System.Drawing.Point(98, 117);
            this.cboAddVendorID.Name = "cboAddVendorID";
            this.cboAddVendorID.Size = new System.Drawing.Size(46, 21);
            this.cboAddVendorID.TabIndex = 52;
            // 
            // cboAddBookID
            // 
            this.cboAddBookID.FormattingEnabled = true;
            this.cboAddBookID.Location = new System.Drawing.Point(98, 8);
            this.cboAddBookID.Name = "cboAddBookID";
            this.cboAddBookID.Size = new System.Drawing.Size(46, 21);
            this.cboAddBookID.TabIndex = 51;
            // 
            // lblAddBookInfo
            // 
            this.lblAddBookInfo.AutoSize = true;
            this.lblAddBookInfo.Location = new System.Drawing.Point(26, 11);
            this.lblAddBookInfo.Name = "lblAddBookInfo";
            this.lblAddBookInfo.Size = new System.Drawing.Size(56, 13);
            this.lblAddBookInfo.TabIndex = 46;
            this.lblAddBookInfo.Text = "Book Info:";
            // 
            // lblAddCost
            // 
            this.lblAddCost.AutoSize = true;
            this.lblAddCost.Location = new System.Drawing.Point(51, 39);
            this.lblAddCost.Name = "lblAddCost";
            this.lblAddCost.Size = new System.Drawing.Size(31, 13);
            this.lblAddCost.TabIndex = 47;
            this.lblAddCost.Text = "Cost:";
            // 
            // lblAddPrice
            // 
            this.lblAddPrice.AutoSize = true;
            this.lblAddPrice.Location = new System.Drawing.Point(48, 67);
            this.lblAddPrice.Name = "lblAddPrice";
            this.lblAddPrice.Size = new System.Drawing.Size(34, 13);
            this.lblAddPrice.TabIndex = 48;
            this.lblAddPrice.Text = "Price:";
            // 
            // lblAddDatePublished
            // 
            this.lblAddDatePublished.AutoSize = true;
            this.lblAddDatePublished.Location = new System.Drawing.Point(3, 93);
            this.lblAddDatePublished.Name = "lblAddDatePublished";
            this.lblAddDatePublished.Size = new System.Drawing.Size(82, 13);
            this.lblAddDatePublished.TabIndex = 49;
            this.lblAddDatePublished.Text = "Date Published:";
            // 
            // lblAddVendor
            // 
            this.lblAddVendor.AutoSize = true;
            this.lblAddVendor.Location = new System.Drawing.Point(41, 120);
            this.lblAddVendor.Name = "lblAddVendor";
            this.lblAddVendor.Size = new System.Drawing.Size(44, 13);
            this.lblAddVendor.TabIndex = 50;
            this.lblAddVendor.Text = "Vendor:";
            // 
            // pnlUpdBook
            // 
            this.pnlUpdBook.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlUpdBook.Controls.Add(this.btnUpdCancel);
            this.pnlUpdBook.Controls.Add(this.btnUpdSave);
            this.pnlUpdBook.Controls.Add(this.dtpUpdDatePublished);
            this.pnlUpdBook.Controls.Add(this.txtUpdPrice);
            this.pnlUpdBook.Controls.Add(this.txtUpdCost);
            this.pnlUpdBook.Controls.Add(this.cboUpdTitle);
            this.pnlUpdBook.Controls.Add(this.cboUpdVendorName);
            this.pnlUpdBook.Controls.Add(this.cboUpdVendorID);
            this.pnlUpdBook.Controls.Add(this.cboUpdBookID);
            this.pnlUpdBook.Controls.Add(this.lblUpdBookInfo);
            this.pnlUpdBook.Controls.Add(this.lblUpdCost);
            this.pnlUpdBook.Controls.Add(this.lblUpdPrice);
            this.pnlUpdBook.Controls.Add(this.lblUpdDatePublished);
            this.pnlUpdBook.Controls.Add(this.lblUpdVendor);
            this.pnlUpdBook.Location = new System.Drawing.Point(595, 210);
            this.pnlUpdBook.Name = "pnlUpdBook";
            this.pnlUpdBook.Size = new System.Drawing.Size(367, 192);
            this.pnlUpdBook.TabIndex = 60;
            this.pnlUpdBook.Visible = false;
            // 
            // btnUpdCancel
            // 
            this.btnUpdCancel.Location = new System.Drawing.Point(235, 152);
            this.btnUpdCancel.Name = "btnUpdCancel";
            this.btnUpdCancel.Size = new System.Drawing.Size(75, 23);
            this.btnUpdCancel.TabIndex = 59;
            this.btnUpdCancel.Text = "Cancel";
            this.btnUpdCancel.UseVisualStyleBackColor = true;
            this.btnUpdCancel.Click += new System.EventHandler(this.btnUpdCancel_Click);
            // 
            // btnUpdSave
            // 
            this.btnUpdSave.Location = new System.Drawing.Point(69, 152);
            this.btnUpdSave.Name = "btnUpdSave";
            this.btnUpdSave.Size = new System.Drawing.Size(94, 23);
            this.btnUpdSave.TabIndex = 58;
            this.btnUpdSave.Text = "Save Changes";
            this.btnUpdSave.UseVisualStyleBackColor = true;
            this.btnUpdSave.Click += new System.EventHandler(this.btnUpdSave_Click);
            // 
            // dtpUpdDatePublished
            // 
            this.dtpUpdDatePublished.Location = new System.Drawing.Point(98, 90);
            this.dtpUpdDatePublished.Name = "dtpUpdDatePublished";
            this.dtpUpdDatePublished.Size = new System.Drawing.Size(149, 20);
            this.dtpUpdDatePublished.TabIndex = 57;
            // 
            // txtUpdPrice
            // 
            this.txtUpdPrice.Location = new System.Drawing.Point(98, 64);
            this.txtUpdPrice.Name = "txtUpdPrice";
            this.txtUpdPrice.Size = new System.Drawing.Size(76, 20);
            this.txtUpdPrice.TabIndex = 56;
            // 
            // txtUpdCost
            // 
            this.txtUpdCost.Location = new System.Drawing.Point(98, 36);
            this.txtUpdCost.Name = "txtUpdCost";
            this.txtUpdCost.Size = new System.Drawing.Size(76, 20);
            this.txtUpdCost.TabIndex = 55;
            // 
            // cboUpdTitle
            // 
            this.cboUpdTitle.FormattingEnabled = true;
            this.cboUpdTitle.Location = new System.Drawing.Point(150, 8);
            this.cboUpdTitle.Name = "cboUpdTitle";
            this.cboUpdTitle.Size = new System.Drawing.Size(212, 21);
            this.cboUpdTitle.TabIndex = 54;
            // 
            // cboUpdVendorName
            // 
            this.cboUpdVendorName.FormattingEnabled = true;
            this.cboUpdVendorName.Location = new System.Drawing.Point(150, 117);
            this.cboUpdVendorName.Name = "cboUpdVendorName";
            this.cboUpdVendorName.Size = new System.Drawing.Size(212, 21);
            this.cboUpdVendorName.TabIndex = 53;
            // 
            // cboUpdVendorID
            // 
            this.cboUpdVendorID.FormattingEnabled = true;
            this.cboUpdVendorID.Location = new System.Drawing.Point(98, 117);
            this.cboUpdVendorID.Name = "cboUpdVendorID";
            this.cboUpdVendorID.Size = new System.Drawing.Size(46, 21);
            this.cboUpdVendorID.TabIndex = 52;
            // 
            // cboUpdBookID
            // 
            this.cboUpdBookID.FormattingEnabled = true;
            this.cboUpdBookID.Location = new System.Drawing.Point(98, 8);
            this.cboUpdBookID.Name = "cboUpdBookID";
            this.cboUpdBookID.Size = new System.Drawing.Size(46, 21);
            this.cboUpdBookID.TabIndex = 51;
            // 
            // lblUpdBookInfo
            // 
            this.lblUpdBookInfo.AutoSize = true;
            this.lblUpdBookInfo.Location = new System.Drawing.Point(26, 11);
            this.lblUpdBookInfo.Name = "lblUpdBookInfo";
            this.lblUpdBookInfo.Size = new System.Drawing.Size(56, 13);
            this.lblUpdBookInfo.TabIndex = 46;
            this.lblUpdBookInfo.Text = "Book Info:";
            // 
            // lblUpdCost
            // 
            this.lblUpdCost.AutoSize = true;
            this.lblUpdCost.Location = new System.Drawing.Point(51, 39);
            this.lblUpdCost.Name = "lblUpdCost";
            this.lblUpdCost.Size = new System.Drawing.Size(31, 13);
            this.lblUpdCost.TabIndex = 47;
            this.lblUpdCost.Text = "Cost:";
            // 
            // lblUpdPrice
            // 
            this.lblUpdPrice.AutoSize = true;
            this.lblUpdPrice.Location = new System.Drawing.Point(48, 67);
            this.lblUpdPrice.Name = "lblUpdPrice";
            this.lblUpdPrice.Size = new System.Drawing.Size(34, 13);
            this.lblUpdPrice.TabIndex = 48;
            this.lblUpdPrice.Text = "Price:";
            // 
            // lblUpdDatePublished
            // 
            this.lblUpdDatePublished.AutoSize = true;
            this.lblUpdDatePublished.Location = new System.Drawing.Point(3, 93);
            this.lblUpdDatePublished.Name = "lblUpdDatePublished";
            this.lblUpdDatePublished.Size = new System.Drawing.Size(82, 13);
            this.lblUpdDatePublished.TabIndex = 49;
            this.lblUpdDatePublished.Text = "Date Published:";
            // 
            // lblUpdVendor
            // 
            this.lblUpdVendor.AutoSize = true;
            this.lblUpdVendor.Location = new System.Drawing.Point(41, 120);
            this.lblUpdVendor.Name = "lblUpdVendor";
            this.lblUpdVendor.Size = new System.Drawing.Size(44, 13);
            this.lblUpdVendor.TabIndex = 50;
            this.lblUpdVendor.Text = "Vendor:";
            // 
            // BookForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(546, 399);
            this.Controls.Add(this.pnlUpdBook);
            this.Controls.Add(this.pnlAddBook);
            this.Controls.Add(this.txtClientID);
            this.Controls.Add(this.txtVendorID);
            this.Controls.Add(this.txtVendorName);
            this.Controls.Add(this.lblVendorName);
            this.Controls.Add(this.lblVendorID);
            this.Controls.Add(this.lblClientID);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.btnPrevious);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.btnAddBook);
            this.Controls.Add(this.btnUpdateBook);
            this.Controls.Add(this.btnDeleteBook);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.txtDatePublished);
            this.Controls.Add(this.txtBookID);
            this.Controls.Add(this.txtTitle);
            this.Controls.Add(this.txtCost);
            this.Controls.Add(this.lblCost);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.lblBookID);
            this.Controls.Add(this.lblDatePublished);
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.lstBook);
            this.Name = "BookForm";
            this.Text = "Book Maintenance";
            this.pnlAddBook.ResumeLayout(false);
            this.pnlAddBook.PerformLayout();
            this.pnlUpdBook.ResumeLayout(false);
            this.pnlUpdBook.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.Button btnPrevious;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnAddBook;
        private System.Windows.Forms.Button btnUpdateBook;
        private System.Windows.Forms.Button btnDeleteBook;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.TextBox txtDatePublished;
        private System.Windows.Forms.TextBox txtBookID;
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.TextBox txtCost;
        private System.Windows.Forms.Label lblCost;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblBookID;
        private System.Windows.Forms.Label lblDatePublished;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.ListBox lstBook;
        private System.Windows.Forms.TextBox txtClientID;
        private System.Windows.Forms.TextBox txtVendorID;
        private System.Windows.Forms.TextBox txtVendorName;
        private System.Windows.Forms.Label lblVendorName;
        private System.Windows.Forms.Label lblVendorID;
        private System.Windows.Forms.Label lblClientID;
        private System.Windows.Forms.Panel pnlAddBook;
        private System.Windows.Forms.Button btnAddCancel;
        private System.Windows.Forms.Button btnAddSave;
        private System.Windows.Forms.DateTimePicker dtpAddDatePublished;
        private System.Windows.Forms.TextBox txtAddPrice;
        private System.Windows.Forms.TextBox txtAddCost;
        private System.Windows.Forms.ComboBox cboAddTitle;
        private System.Windows.Forms.ComboBox cboAddVendorName;
        private System.Windows.Forms.ComboBox cboAddVendorID;
        private System.Windows.Forms.ComboBox cboAddBookID;
        private System.Windows.Forms.Label lblAddBookInfo;
        private System.Windows.Forms.Label lblAddCost;
        private System.Windows.Forms.Label lblAddPrice;
        private System.Windows.Forms.Label lblAddDatePublished;
        private System.Windows.Forms.Label lblAddVendor;
        private System.Windows.Forms.Panel pnlUpdBook;
        private System.Windows.Forms.Button btnUpdCancel;
        private System.Windows.Forms.Button btnUpdSave;
        private System.Windows.Forms.DateTimePicker dtpUpdDatePublished;
        private System.Windows.Forms.TextBox txtUpdPrice;
        private System.Windows.Forms.TextBox txtUpdCost;
        private System.Windows.Forms.ComboBox cboUpdTitle;
        private System.Windows.Forms.ComboBox cboUpdVendorName;
        private System.Windows.Forms.ComboBox cboUpdVendorID;
        private System.Windows.Forms.ComboBox cboUpdBookID;
        private System.Windows.Forms.Label lblUpdBookInfo;
        private System.Windows.Forms.Label lblUpdCost;
        private System.Windows.Forms.Label lblUpdPrice;
        private System.Windows.Forms.Label lblUpdDatePublished;
        private System.Windows.Forms.Label lblUpdVendor;
    }
}