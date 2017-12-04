namespace BookBrokersStore
{
    partial class BookInfoForm
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
            this.lblNotes = new System.Windows.Forms.Label();
            this.btnReturn = new System.Windows.Forms.Button();
            this.btnPrevious = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnAddBookInfo = new System.Windows.Forms.Button();
            this.btnUpdateBookInfo = new System.Windows.Forms.Button();
            this.btnDeleteBookInfo = new System.Windows.Forms.Button();
            this.txtAuthorLastName = new System.Windows.Forms.TextBox();
            this.txtAuthorFirstName = new System.Windows.Forms.TextBox();
            this.txtBookInfoID = new System.Windows.Forms.TextBox();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.txtAuthorID = new System.Windows.Forms.TextBox();
            this.lblAuthorID = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblBookInfoID = new System.Windows.Forms.Label();
            this.lblAuthorFirstName = new System.Windows.Forms.Label();
            this.lblAuthorLastName = new System.Windows.Forms.Label();
            this.lstBookInfo = new System.Windows.Forms.ListBox();
            this.txtNotes = new System.Windows.Forms.TextBox();
            this.pnlAddBookInfo = new System.Windows.Forms.Panel();
            this.cboAddAuthorFirstName = new System.Windows.Forms.ComboBox();
            this.btnAddCancel = new System.Windows.Forms.Button();
            this.btnAddSave = new System.Windows.Forms.Button();
            this.txtAddNotes = new System.Windows.Forms.TextBox();
            this.lblAddTitle = new System.Windows.Forms.Label();
            this.cboAddAuthorLastName = new System.Windows.Forms.ComboBox();
            this.cboAddAuthorID = new System.Windows.Forms.ComboBox();
            this.lblAddAuthor = new System.Windows.Forms.Label();
            this.lblAddNotes = new System.Windows.Forms.Label();
            this.txtAddTitle = new System.Windows.Forms.TextBox();
            this.pnlUpdBookInfo = new System.Windows.Forms.Panel();
            this.txtUpdNotes = new System.Windows.Forms.TextBox();
            this.lblUpdNotes = new System.Windows.Forms.Label();
            this.txtUpdAuthorLastName = new System.Windows.Forms.TextBox();
            this.txtUpdAuthorFirstName = new System.Windows.Forms.TextBox();
            this.txtUpdBookInfoID = new System.Windows.Forms.TextBox();
            this.txtUpdTitle = new System.Windows.Forms.TextBox();
            this.txtUpdAuthorID = new System.Windows.Forms.TextBox();
            this.lblUpdAuthorID = new System.Windows.Forms.Label();
            this.lblUpdTitle = new System.Windows.Forms.Label();
            this.lblUpdBookInfoID = new System.Windows.Forms.Label();
            this.lblUpdAuthorFirstName = new System.Windows.Forms.Label();
            this.lblUpdAuthorLastName = new System.Windows.Forms.Label();
            this.btnUpdCancel = new System.Windows.Forms.Button();
            this.btnUpdSave = new System.Windows.Forms.Button();
            this.pnlAddBookInfo.SuspendLayout();
            this.pnlUpdBookInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblNotes
            // 
            this.lblNotes.AutoSize = true;
            this.lblNotes.Location = new System.Drawing.Point(265, 177);
            this.lblNotes.Name = "lblNotes";
            this.lblNotes.Size = new System.Drawing.Size(38, 13);
            this.lblNotes.TabIndex = 87;
            this.lblNotes.Text = "Notes:";
            // 
            // btnReturn
            // 
            this.btnReturn.Location = new System.Drawing.Point(479, 311);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(75, 23);
            this.btnReturn.TabIndex = 85;
            this.btnReturn.Text = "Return";
            this.btnReturn.UseVisualStyleBackColor = true;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // btnPrevious
            // 
            this.btnPrevious.Location = new System.Drawing.Point(12, 281);
            this.btnPrevious.Name = "btnPrevious";
            this.btnPrevious.Size = new System.Drawing.Size(75, 23);
            this.btnPrevious.TabIndex = 84;
            this.btnPrevious.Text = "Previous";
            this.btnPrevious.UseVisualStyleBackColor = true;
            this.btnPrevious.Click += new System.EventHandler(this.btnPrevious_Click);
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(126, 281);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(75, 23);
            this.btnNext.TabIndex = 83;
            this.btnNext.Text = "Next";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnAddBookInfo
            // 
            this.btnAddBookInfo.Location = new System.Drawing.Point(241, 282);
            this.btnAddBookInfo.Name = "btnAddBookInfo";
            this.btnAddBookInfo.Size = new System.Drawing.Size(91, 23);
            this.btnAddBookInfo.TabIndex = 82;
            this.btnAddBookInfo.Text = "Add Book Info";
            this.btnAddBookInfo.UseVisualStyleBackColor = true;
            this.btnAddBookInfo.Click += new System.EventHandler(this.btnAddBookInfo_Click);
            // 
            // btnUpdateBookInfo
            // 
            this.btnUpdateBookInfo.Location = new System.Drawing.Point(338, 282);
            this.btnUpdateBookInfo.Name = "btnUpdateBookInfo";
            this.btnUpdateBookInfo.Size = new System.Drawing.Size(103, 23);
            this.btnUpdateBookInfo.TabIndex = 81;
            this.btnUpdateBookInfo.Text = "Update Book Info";
            this.btnUpdateBookInfo.UseVisualStyleBackColor = true;
            this.btnUpdateBookInfo.Click += new System.EventHandler(this.btnUpdateBookInfo_Click);
            // 
            // btnDeleteBookInfo
            // 
            this.btnDeleteBookInfo.Location = new System.Drawing.Point(447, 282);
            this.btnDeleteBookInfo.Name = "btnDeleteBookInfo";
            this.btnDeleteBookInfo.Size = new System.Drawing.Size(107, 23);
            this.btnDeleteBookInfo.TabIndex = 80;
            this.btnDeleteBookInfo.Text = "Delete Book Info";
            this.btnDeleteBookInfo.UseVisualStyleBackColor = true;
            this.btnDeleteBookInfo.Click += new System.EventHandler(this.btnDeleteBookInfo_Click);
            // 
            // txtAuthorLastName
            // 
            this.txtAuthorLastName.Location = new System.Drawing.Point(309, 110);
            this.txtAuthorLastName.Name = "txtAuthorLastName";
            this.txtAuthorLastName.Size = new System.Drawing.Size(161, 20);
            this.txtAuthorLastName.TabIndex = 79;
            // 
            // txtAuthorFirstName
            // 
            this.txtAuthorFirstName.Location = new System.Drawing.Point(309, 145);
            this.txtAuthorFirstName.Name = "txtAuthorFirstName";
            this.txtAuthorFirstName.Size = new System.Drawing.Size(161, 20);
            this.txtAuthorFirstName.TabIndex = 78;
            // 
            // txtBookInfoID
            // 
            this.txtBookInfoID.Location = new System.Drawing.Point(309, 10);
            this.txtBookInfoID.Name = "txtBookInfoID";
            this.txtBookInfoID.Size = new System.Drawing.Size(51, 20);
            this.txtBookInfoID.TabIndex = 77;
            // 
            // txtTitle
            // 
            this.txtTitle.Location = new System.Drawing.Point(309, 44);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(245, 20);
            this.txtTitle.TabIndex = 76;
            // 
            // txtAuthorID
            // 
            this.txtAuthorID.Location = new System.Drawing.Point(309, 79);
            this.txtAuthorID.Name = "txtAuthorID";
            this.txtAuthorID.Size = new System.Drawing.Size(51, 20);
            this.txtAuthorID.TabIndex = 75;
            this.txtAuthorID.TextChanged += new System.EventHandler(this.txtAuthorID_TextChanged);
            // 
            // lblAuthorID
            // 
            this.lblAuthorID.AutoSize = true;
            this.lblAuthorID.Location = new System.Drawing.Point(248, 82);
            this.lblAuthorID.Name = "lblAuthorID";
            this.lblAuthorID.Size = new System.Drawing.Size(55, 13);
            this.lblAuthorID.TabIndex = 74;
            this.lblAuthorID.Text = "Author ID:";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Location = new System.Drawing.Point(273, 47);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(30, 13);
            this.lblTitle.TabIndex = 73;
            this.lblTitle.Text = "Title:";
            // 
            // lblBookInfoID
            // 
            this.lblBookInfoID.AutoSize = true;
            this.lblBookInfoID.Location = new System.Drawing.Point(233, 13);
            this.lblBookInfoID.Name = "lblBookInfoID";
            this.lblBookInfoID.Size = new System.Drawing.Size(70, 13);
            this.lblBookInfoID.TabIndex = 72;
            this.lblBookInfoID.Text = "Book Info ID:";
            // 
            // lblAuthorFirstName
            // 
            this.lblAuthorFirstName.AutoSize = true;
            this.lblAuthorFirstName.Location = new System.Drawing.Point(209, 148);
            this.lblAuthorFirstName.Name = "lblAuthorFirstName";
            this.lblAuthorFirstName.Size = new System.Drawing.Size(94, 13);
            this.lblAuthorFirstName.TabIndex = 71;
            this.lblAuthorFirstName.Text = "Author First Name:";
            // 
            // lblAuthorLastName
            // 
            this.lblAuthorLastName.AutoSize = true;
            this.lblAuthorLastName.Location = new System.Drawing.Point(208, 113);
            this.lblAuthorLastName.Name = "lblAuthorLastName";
            this.lblAuthorLastName.Size = new System.Drawing.Size(95, 13);
            this.lblAuthorLastName.TabIndex = 70;
            this.lblAuthorLastName.Text = "Author Last Name:";
            // 
            // lstBookInfo
            // 
            this.lstBookInfo.FormattingEnabled = true;
            this.lstBookInfo.Location = new System.Drawing.Point(12, 12);
            this.lstBookInfo.Name = "lstBookInfo";
            this.lstBookInfo.Size = new System.Drawing.Size(189, 264);
            this.lstBookInfo.TabIndex = 69;
            // 
            // txtNotes
            // 
            this.txtNotes.Location = new System.Drawing.Point(309, 177);
            this.txtNotes.Multiline = true;
            this.txtNotes.Name = "txtNotes";
            this.txtNotes.Size = new System.Drawing.Size(245, 99);
            this.txtNotes.TabIndex = 90;
            // 
            // pnlAddBookInfo
            // 
            this.pnlAddBookInfo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlAddBookInfo.Controls.Add(this.cboAddAuthorFirstName);
            this.pnlAddBookInfo.Controls.Add(this.btnAddCancel);
            this.pnlAddBookInfo.Controls.Add(this.btnAddSave);
            this.pnlAddBookInfo.Controls.Add(this.txtAddNotes);
            this.pnlAddBookInfo.Controls.Add(this.lblAddTitle);
            this.pnlAddBookInfo.Controls.Add(this.cboAddAuthorLastName);
            this.pnlAddBookInfo.Controls.Add(this.cboAddAuthorID);
            this.pnlAddBookInfo.Controls.Add(this.lblAddAuthor);
            this.pnlAddBookInfo.Controls.Add(this.lblAddNotes);
            this.pnlAddBookInfo.Controls.Add(this.txtAddTitle);
            this.pnlAddBookInfo.Location = new System.Drawing.Point(560, 10);
            this.pnlAddBookInfo.Name = "pnlAddBookInfo";
            this.pnlAddBookInfo.Size = new System.Drawing.Size(357, 235);
            this.pnlAddBookInfo.TabIndex = 91;
            this.pnlAddBookInfo.Visible = false;
            // 
            // cboAddAuthorFirstName
            // 
            this.cboAddAuthorFirstName.FormattingEnabled = true;
            this.cboAddAuthorFirstName.Location = new System.Drawing.Point(240, 37);
            this.cboAddAuthorFirstName.Name = "cboAddAuthorFirstName";
            this.cboAddAuthorFirstName.Size = new System.Drawing.Size(102, 21);
            this.cboAddAuthorFirstName.TabIndex = 70;
            // 
            // btnAddCancel
            // 
            this.btnAddCancel.Location = new System.Drawing.Point(229, 201);
            this.btnAddCancel.Name = "btnAddCancel";
            this.btnAddCancel.Size = new System.Drawing.Size(101, 23);
            this.btnAddCancel.TabIndex = 59;
            this.btnAddCancel.Text = "Cancel";
            this.btnAddCancel.UseVisualStyleBackColor = true;
            this.btnAddCancel.Click += new System.EventHandler(this.btnAddCancel_Click);
            // 
            // btnAddSave
            // 
            this.btnAddSave.Location = new System.Drawing.Point(27, 201);
            this.btnAddSave.Name = "btnAddSave";
            this.btnAddSave.Size = new System.Drawing.Size(99, 23);
            this.btnAddSave.TabIndex = 58;
            this.btnAddSave.Text = "Save Book Info";
            this.btnAddSave.UseVisualStyleBackColor = true;
            this.btnAddSave.Click += new System.EventHandler(this.btnAddSave_Click);
            // 
            // txtAddNotes
            // 
            this.txtAddNotes.Location = new System.Drawing.Point(70, 68);
            this.txtAddNotes.Multiline = true;
            this.txtAddNotes.Name = "txtAddNotes";
            this.txtAddNotes.Size = new System.Drawing.Size(272, 127);
            this.txtAddNotes.TabIndex = 83;
            // 
            // lblAddTitle
            // 
            this.lblAddTitle.AutoSize = true;
            this.lblAddTitle.Location = new System.Drawing.Point(34, 14);
            this.lblAddTitle.Name = "lblAddTitle";
            this.lblAddTitle.Size = new System.Drawing.Size(30, 13);
            this.lblAddTitle.TabIndex = 72;
            this.lblAddTitle.Text = "Title:";
            // 
            // cboAddAuthorLastName
            // 
            this.cboAddAuthorLastName.FormattingEnabled = true;
            this.cboAddAuthorLastName.Location = new System.Drawing.Point(125, 37);
            this.cboAddAuthorLastName.Name = "cboAddAuthorLastName";
            this.cboAddAuthorLastName.Size = new System.Drawing.Size(109, 21);
            this.cboAddAuthorLastName.TabIndex = 53;
            // 
            // cboAddAuthorID
            // 
            this.cboAddAuthorID.FormattingEnabled = true;
            this.cboAddAuthorID.Location = new System.Drawing.Point(70, 37);
            this.cboAddAuthorID.Name = "cboAddAuthorID";
            this.cboAddAuthorID.Size = new System.Drawing.Size(46, 21);
            this.cboAddAuthorID.TabIndex = 52;
            // 
            // lblAddAuthor
            // 
            this.lblAddAuthor.AutoSize = true;
            this.lblAddAuthor.Location = new System.Drawing.Point(23, 40);
            this.lblAddAuthor.Name = "lblAddAuthor";
            this.lblAddAuthor.Size = new System.Drawing.Size(41, 13);
            this.lblAddAuthor.TabIndex = 80;
            this.lblAddAuthor.Text = "Author:";
            // 
            // lblAddNotes
            // 
            this.lblAddNotes.AutoSize = true;
            this.lblAddNotes.Location = new System.Drawing.Point(29, 71);
            this.lblAddNotes.Name = "lblAddNotes";
            this.lblAddNotes.Size = new System.Drawing.Size(38, 13);
            this.lblAddNotes.TabIndex = 78;
            this.lblAddNotes.Text = "Notes:";
            // 
            // txtAddTitle
            // 
            this.txtAddTitle.Location = new System.Drawing.Point(70, 11);
            this.txtAddTitle.Name = "txtAddTitle";
            this.txtAddTitle.Size = new System.Drawing.Size(272, 20);
            this.txtAddTitle.TabIndex = 75;
            // 
            // pnlUpdBookInfo
            // 
            this.pnlUpdBookInfo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlUpdBookInfo.Controls.Add(this.txtUpdNotes);
            this.pnlUpdBookInfo.Controls.Add(this.lblUpdNotes);
            this.pnlUpdBookInfo.Controls.Add(this.txtUpdAuthorLastName);
            this.pnlUpdBookInfo.Controls.Add(this.txtUpdAuthorFirstName);
            this.pnlUpdBookInfo.Controls.Add(this.txtUpdBookInfoID);
            this.pnlUpdBookInfo.Controls.Add(this.txtUpdTitle);
            this.pnlUpdBookInfo.Controls.Add(this.txtUpdAuthorID);
            this.pnlUpdBookInfo.Controls.Add(this.lblUpdAuthorID);
            this.pnlUpdBookInfo.Controls.Add(this.lblUpdTitle);
            this.pnlUpdBookInfo.Controls.Add(this.lblUpdBookInfoID);
            this.pnlUpdBookInfo.Controls.Add(this.lblUpdAuthorFirstName);
            this.pnlUpdBookInfo.Controls.Add(this.lblUpdAuthorLastName);
            this.pnlUpdBookInfo.Controls.Add(this.btnUpdCancel);
            this.pnlUpdBookInfo.Controls.Add(this.btnUpdSave);
            this.pnlUpdBookInfo.Location = new System.Drawing.Point(560, 251);
            this.pnlUpdBookInfo.Name = "pnlUpdBookInfo";
            this.pnlUpdBookInfo.Size = new System.Drawing.Size(357, 317);
            this.pnlUpdBookInfo.TabIndex = 92;
            this.pnlUpdBookInfo.Visible = false;
            // 
            // txtUpdNotes
            // 
            this.txtUpdNotes.Location = new System.Drawing.Point(105, 175);
            this.txtUpdNotes.Multiline = true;
            this.txtUpdNotes.Name = "txtUpdNotes";
            this.txtUpdNotes.Size = new System.Drawing.Size(245, 99);
            this.txtUpdNotes.TabIndex = 102;
            // 
            // lblUpdNotes
            // 
            this.lblUpdNotes.AutoSize = true;
            this.lblUpdNotes.Location = new System.Drawing.Point(61, 175);
            this.lblUpdNotes.Name = "lblUpdNotes";
            this.lblUpdNotes.Size = new System.Drawing.Size(38, 13);
            this.lblUpdNotes.TabIndex = 101;
            this.lblUpdNotes.Text = "Notes:";
            // 
            // txtUpdAuthorLastName
            // 
            this.txtUpdAuthorLastName.Location = new System.Drawing.Point(105, 108);
            this.txtUpdAuthorLastName.Name = "txtUpdAuthorLastName";
            this.txtUpdAuthorLastName.Size = new System.Drawing.Size(161, 20);
            this.txtUpdAuthorLastName.TabIndex = 100;
            // 
            // txtUpdAuthorFirstName
            // 
            this.txtUpdAuthorFirstName.Location = new System.Drawing.Point(105, 143);
            this.txtUpdAuthorFirstName.Name = "txtUpdAuthorFirstName";
            this.txtUpdAuthorFirstName.Size = new System.Drawing.Size(161, 20);
            this.txtUpdAuthorFirstName.TabIndex = 99;
            // 
            // txtUpdBookInfoID
            // 
            this.txtUpdBookInfoID.Location = new System.Drawing.Point(105, 8);
            this.txtUpdBookInfoID.Name = "txtUpdBookInfoID";
            this.txtUpdBookInfoID.Size = new System.Drawing.Size(51, 20);
            this.txtUpdBookInfoID.TabIndex = 98;
            // 
            // txtUpdTitle
            // 
            this.txtUpdTitle.Location = new System.Drawing.Point(105, 42);
            this.txtUpdTitle.Name = "txtUpdTitle";
            this.txtUpdTitle.Size = new System.Drawing.Size(245, 20);
            this.txtUpdTitle.TabIndex = 97;
            // 
            // txtUpdAuthorID
            // 
            this.txtUpdAuthorID.Location = new System.Drawing.Point(105, 77);
            this.txtUpdAuthorID.Name = "txtUpdAuthorID";
            this.txtUpdAuthorID.Size = new System.Drawing.Size(51, 20);
            this.txtUpdAuthorID.TabIndex = 96;
            // 
            // lblUpdAuthorID
            // 
            this.lblUpdAuthorID.AutoSize = true;
            this.lblUpdAuthorID.Location = new System.Drawing.Point(44, 80);
            this.lblUpdAuthorID.Name = "lblUpdAuthorID";
            this.lblUpdAuthorID.Size = new System.Drawing.Size(55, 13);
            this.lblUpdAuthorID.TabIndex = 95;
            this.lblUpdAuthorID.Text = "Author ID:";
            // 
            // lblUpdTitle
            // 
            this.lblUpdTitle.AutoSize = true;
            this.lblUpdTitle.Location = new System.Drawing.Point(69, 45);
            this.lblUpdTitle.Name = "lblUpdTitle";
            this.lblUpdTitle.Size = new System.Drawing.Size(30, 13);
            this.lblUpdTitle.TabIndex = 94;
            this.lblUpdTitle.Text = "Title:";
            // 
            // lblUpdBookInfoID
            // 
            this.lblUpdBookInfoID.AutoSize = true;
            this.lblUpdBookInfoID.Location = new System.Drawing.Point(29, 11);
            this.lblUpdBookInfoID.Name = "lblUpdBookInfoID";
            this.lblUpdBookInfoID.Size = new System.Drawing.Size(70, 13);
            this.lblUpdBookInfoID.TabIndex = 93;
            this.lblUpdBookInfoID.Text = "Book Info ID:";
            // 
            // lblUpdAuthorFirstName
            // 
            this.lblUpdAuthorFirstName.AutoSize = true;
            this.lblUpdAuthorFirstName.Location = new System.Drawing.Point(5, 146);
            this.lblUpdAuthorFirstName.Name = "lblUpdAuthorFirstName";
            this.lblUpdAuthorFirstName.Size = new System.Drawing.Size(94, 13);
            this.lblUpdAuthorFirstName.TabIndex = 92;
            this.lblUpdAuthorFirstName.Text = "Author First Name:";
            // 
            // lblUpdAuthorLastName
            // 
            this.lblUpdAuthorLastName.AutoSize = true;
            this.lblUpdAuthorLastName.Location = new System.Drawing.Point(4, 111);
            this.lblUpdAuthorLastName.Name = "lblUpdAuthorLastName";
            this.lblUpdAuthorLastName.Size = new System.Drawing.Size(95, 13);
            this.lblUpdAuthorLastName.TabIndex = 91;
            this.lblUpdAuthorLastName.Text = "Author Last Name:";
            // 
            // btnUpdCancel
            // 
            this.btnUpdCancel.Location = new System.Drawing.Point(229, 280);
            this.btnUpdCancel.Name = "btnUpdCancel";
            this.btnUpdCancel.Size = new System.Drawing.Size(101, 23);
            this.btnUpdCancel.TabIndex = 59;
            this.btnUpdCancel.Text = "Cancel";
            this.btnUpdCancel.UseVisualStyleBackColor = true;
            this.btnUpdCancel.Click += new System.EventHandler(this.btnUpdCancel_Click);
            // 
            // btnUpdSave
            // 
            this.btnUpdSave.Location = new System.Drawing.Point(26, 280);
            this.btnUpdSave.Name = "btnUpdSave";
            this.btnUpdSave.Size = new System.Drawing.Size(99, 23);
            this.btnUpdSave.TabIndex = 58;
            this.btnUpdSave.Text = "Save Changes";
            this.btnUpdSave.UseVisualStyleBackColor = true;
            this.btnUpdSave.Click += new System.EventHandler(this.btnUpdSave_Click);
            // 
            // BookInfoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(558, 338);
            this.Controls.Add(this.pnlUpdBookInfo);
            this.Controls.Add(this.pnlAddBookInfo);
            this.Controls.Add(this.txtNotes);
            this.Controls.Add(this.lblNotes);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.btnPrevious);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.btnAddBookInfo);
            this.Controls.Add(this.btnUpdateBookInfo);
            this.Controls.Add(this.btnDeleteBookInfo);
            this.Controls.Add(this.txtAuthorLastName);
            this.Controls.Add(this.txtAuthorFirstName);
            this.Controls.Add(this.txtBookInfoID);
            this.Controls.Add(this.txtTitle);
            this.Controls.Add(this.txtAuthorID);
            this.Controls.Add(this.lblAuthorID);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.lblBookInfoID);
            this.Controls.Add(this.lblAuthorFirstName);
            this.Controls.Add(this.lblAuthorLastName);
            this.Controls.Add(this.lstBookInfo);
            this.Name = "BookInfoForm";
            this.Text = "Book Info Maintenance";
            this.pnlAddBookInfo.ResumeLayout(false);
            this.pnlAddBookInfo.PerformLayout();
            this.pnlUpdBookInfo.ResumeLayout(false);
            this.pnlUpdBookInfo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNotes;
        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.Button btnPrevious;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnAddBookInfo;
        private System.Windows.Forms.Button btnUpdateBookInfo;
        private System.Windows.Forms.Button btnDeleteBookInfo;
        private System.Windows.Forms.TextBox txtAuthorLastName;
        private System.Windows.Forms.TextBox txtAuthorFirstName;
        private System.Windows.Forms.TextBox txtBookInfoID;
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.TextBox txtAuthorID;
        private System.Windows.Forms.Label lblAuthorID;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblBookInfoID;
        private System.Windows.Forms.Label lblAuthorFirstName;
        private System.Windows.Forms.Label lblAuthorLastName;
        private System.Windows.Forms.ListBox lstBookInfo;
        private System.Windows.Forms.TextBox txtNotes;
        private System.Windows.Forms.Panel pnlAddBookInfo;
        private System.Windows.Forms.ComboBox cboAddAuthorFirstName;
        private System.Windows.Forms.Button btnAddCancel;
        private System.Windows.Forms.Button btnAddSave;
        private System.Windows.Forms.TextBox txtAddNotes;
        private System.Windows.Forms.Label lblAddTitle;
        private System.Windows.Forms.ComboBox cboAddAuthorLastName;
        private System.Windows.Forms.ComboBox cboAddAuthorID;
        private System.Windows.Forms.Label lblAddAuthor;
        private System.Windows.Forms.Label lblAddNotes;
        private System.Windows.Forms.TextBox txtAddTitle;
        private System.Windows.Forms.Panel pnlUpdBookInfo;
        private System.Windows.Forms.Button btnUpdCancel;
        private System.Windows.Forms.Button btnUpdSave;
        private System.Windows.Forms.TextBox txtUpdNotes;
        private System.Windows.Forms.Label lblUpdNotes;
        private System.Windows.Forms.TextBox txtUpdAuthorLastName;
        private System.Windows.Forms.TextBox txtUpdAuthorFirstName;
        private System.Windows.Forms.TextBox txtUpdBookInfoID;
        private System.Windows.Forms.TextBox txtUpdTitle;
        private System.Windows.Forms.TextBox txtUpdAuthorID;
        private System.Windows.Forms.Label lblUpdAuthorID;
        private System.Windows.Forms.Label lblUpdTitle;
        private System.Windows.Forms.Label lblUpdBookInfoID;
        private System.Windows.Forms.Label lblUpdAuthorFirstName;
        private System.Windows.Forms.Label lblUpdAuthorLastName;
    }
}