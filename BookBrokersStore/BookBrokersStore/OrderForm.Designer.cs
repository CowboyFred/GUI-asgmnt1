namespace BookBrokersStore
{
    partial class OrderForm
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
            this.txtStatus = new System.Windows.Forms.TextBox();
            this.lblStatus = new System.Windows.Forms.Label();
            this.btnReturn = new System.Windows.Forms.Button();
            this.btnPrevious = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnAddClientOrder = new System.Windows.Forms.Button();
            this.btnUpdateClientOrder = new System.Windows.Forms.Button();
            this.btnDeleteClientOrder = new System.Windows.Forms.Button();
            this.txtClientLastName = new System.Windows.Forms.TextBox();
            this.txtClientFirstName = new System.Windows.Forms.TextBox();
            this.txtClientOrderID = new System.Windows.Forms.TextBox();
            this.txtClientOrderDate = new System.Windows.Forms.TextBox();
            this.txtClientID = new System.Windows.Forms.TextBox();
            this.lblClientID = new System.Windows.Forms.Label();
            this.lblClientOrderDate = new System.Windows.Forms.Label();
            this.lblClientOrderID = new System.Windows.Forms.Label();
            this.lblClientFirstName = new System.Windows.Forms.Label();
            this.lblClientLastName = new System.Windows.Forms.Label();
            this.lstClientOrder = new System.Windows.Forms.ListBox();
            this.btnShipped = new System.Windows.Forms.Button();
            this.btnPaid = new System.Windows.Forms.Button();
            this.pnlAddClientOrder = new System.Windows.Forms.Panel();
            this.dtpClientOrderDate = new System.Windows.Forms.DateTimePicker();
            this.cboAddClientFirstName = new System.Windows.Forms.ComboBox();
            this.btnAddCancel = new System.Windows.Forms.Button();
            this.btnAddSave = new System.Windows.Forms.Button();
            this.lblAddClientOrderDate = new System.Windows.Forms.Label();
            this.cboAddClientLastName = new System.Windows.Forms.ComboBox();
            this.cboAddClientID = new System.Windows.Forms.ComboBox();
            this.lblAddClient = new System.Windows.Forms.Label();
            this.pnlUpdClientOrder = new System.Windows.Forms.Panel();
            this.dtpUpdClientOrderDate = new System.Windows.Forms.DateTimePicker();
            this.txtUpdStatus = new System.Windows.Forms.TextBox();
            this.lblUpdStatus = new System.Windows.Forms.Label();
            this.txtUpdClientLastName = new System.Windows.Forms.TextBox();
            this.txtUpdClientFirstName = new System.Windows.Forms.TextBox();
            this.txtUpdClientOrderID = new System.Windows.Forms.TextBox();
            this.txtUpdClientID = new System.Windows.Forms.TextBox();
            this.lblUpdClientID = new System.Windows.Forms.Label();
            this.lblUpdClientOrderDate = new System.Windows.Forms.Label();
            this.lblUpdClientOrderID = new System.Windows.Forms.Label();
            this.lblUpdClientFirstName = new System.Windows.Forms.Label();
            this.lblUpdClientLastName = new System.Windows.Forms.Label();
            this.btnUpdCancel = new System.Windows.Forms.Button();
            this.btnUpdSave = new System.Windows.Forms.Button();
            this.pnlAddClientOrder.SuspendLayout();
            this.pnlUpdClientOrder.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtStatus
            // 
            this.txtStatus.Location = new System.Drawing.Point(274, 169);
            this.txtStatus.Name = "txtStatus";
            this.txtStatus.Size = new System.Drawing.Size(51, 20);
            this.txtStatus.TabIndex = 109;
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(230, 172);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(40, 13);
            this.lblStatus.TabIndex = 108;
            this.lblStatus.Text = "Status:";
            // 
            // btnReturn
            // 
            this.btnReturn.Location = new System.Drawing.Point(439, 238);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(85, 23);
            this.btnReturn.TabIndex = 107;
            this.btnReturn.Text = "Return";
            this.btnReturn.UseVisualStyleBackColor = true;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // btnPrevious
            // 
            this.btnPrevious.Location = new System.Drawing.Point(12, 209);
            this.btnPrevious.Name = "btnPrevious";
            this.btnPrevious.Size = new System.Drawing.Size(75, 23);
            this.btnPrevious.TabIndex = 106;
            this.btnPrevious.Text = "Previous";
            this.btnPrevious.UseVisualStyleBackColor = true;
            this.btnPrevious.Click += new System.EventHandler(this.btnPrevious_Click);
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(96, 209);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(75, 23);
            this.btnNext.TabIndex = 105;
            this.btnNext.Text = "Next";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnAddClientOrder
            // 
            this.btnAddClientOrder.Location = new System.Drawing.Point(192, 209);
            this.btnAddClientOrder.Name = "btnAddClientOrder";
            this.btnAddClientOrder.Size = new System.Drawing.Size(100, 23);
            this.btnAddClientOrder.TabIndex = 104;
            this.btnAddClientOrder.Text = "Add Client Order";
            this.btnAddClientOrder.UseVisualStyleBackColor = true;
            this.btnAddClientOrder.Click += new System.EventHandler(this.btnAddClientOrder_Click);
            // 
            // btnUpdateClientOrder
            // 
            this.btnUpdateClientOrder.Location = new System.Drawing.Point(298, 209);
            this.btnUpdateClientOrder.Name = "btnUpdateClientOrder";
            this.btnUpdateClientOrder.Size = new System.Drawing.Size(113, 23);
            this.btnUpdateClientOrder.TabIndex = 103;
            this.btnUpdateClientOrder.Text = "Update Client Order";
            this.btnUpdateClientOrder.UseVisualStyleBackColor = true;
            this.btnUpdateClientOrder.Click += new System.EventHandler(this.btnUpdateClientOrder_Click);
            // 
            // btnDeleteClientOrder
            // 
            this.btnDeleteClientOrder.Location = new System.Drawing.Point(417, 209);
            this.btnDeleteClientOrder.Name = "btnDeleteClientOrder";
            this.btnDeleteClientOrder.Size = new System.Drawing.Size(107, 23);
            this.btnDeleteClientOrder.TabIndex = 102;
            this.btnDeleteClientOrder.Text = "Delete Client Order";
            this.btnDeleteClientOrder.UseVisualStyleBackColor = true;
            this.btnDeleteClientOrder.Click += new System.EventHandler(this.btnDeleteClientOrder_Click);
            // 
            // txtClientLastName
            // 
            this.txtClientLastName.Location = new System.Drawing.Point(274, 106);
            this.txtClientLastName.Name = "txtClientLastName";
            this.txtClientLastName.Size = new System.Drawing.Size(161, 20);
            this.txtClientLastName.TabIndex = 101;
            // 
            // txtClientFirstName
            // 
            this.txtClientFirstName.Location = new System.Drawing.Point(274, 137);
            this.txtClientFirstName.Name = "txtClientFirstName";
            this.txtClientFirstName.Size = new System.Drawing.Size(161, 20);
            this.txtClientFirstName.TabIndex = 100;
            // 
            // txtClientOrderID
            // 
            this.txtClientOrderID.Location = new System.Drawing.Point(274, 2);
            this.txtClientOrderID.Name = "txtClientOrderID";
            this.txtClientOrderID.Size = new System.Drawing.Size(51, 20);
            this.txtClientOrderID.TabIndex = 99;
            // 
            // txtClientOrderDate
            // 
            this.txtClientOrderDate.Location = new System.Drawing.Point(274, 36);
            this.txtClientOrderDate.Name = "txtClientOrderDate";
            this.txtClientOrderDate.Size = new System.Drawing.Size(63, 20);
            this.txtClientOrderDate.TabIndex = 98;
            // 
            // txtClientID
            // 
            this.txtClientID.Location = new System.Drawing.Point(274, 71);
            this.txtClientID.Name = "txtClientID";
            this.txtClientID.Size = new System.Drawing.Size(51, 20);
            this.txtClientID.TabIndex = 97;
            this.txtClientID.TextChanged += new System.EventHandler(this.txtClientID_TextChanged);
            // 
            // lblClientID
            // 
            this.lblClientID.AutoSize = true;
            this.lblClientID.Location = new System.Drawing.Point(218, 74);
            this.lblClientID.Name = "lblClientID";
            this.lblClientID.Size = new System.Drawing.Size(50, 13);
            this.lblClientID.TabIndex = 96;
            this.lblClientID.Text = "Client ID:";
            // 
            // lblClientOrderDate
            // 
            this.lblClientOrderDate.AutoSize = true;
            this.lblClientOrderDate.Location = new System.Drawing.Point(177, 39);
            this.lblClientOrderDate.Name = "lblClientOrderDate";
            this.lblClientOrderDate.Size = new System.Drawing.Size(91, 13);
            this.lblClientOrderDate.TabIndex = 95;
            this.lblClientOrderDate.Text = "Client Order Date:";
            // 
            // lblClientOrderID
            // 
            this.lblClientOrderID.AutoSize = true;
            this.lblClientOrderID.Location = new System.Drawing.Point(189, 5);
            this.lblClientOrderID.Name = "lblClientOrderID";
            this.lblClientOrderID.Size = new System.Drawing.Size(79, 13);
            this.lblClientOrderID.TabIndex = 94;
            this.lblClientOrderID.Text = "Client Order ID:";
            // 
            // lblClientFirstName
            // 
            this.lblClientFirstName.AutoSize = true;
            this.lblClientFirstName.Location = new System.Drawing.Point(179, 140);
            this.lblClientFirstName.Name = "lblClientFirstName";
            this.lblClientFirstName.Size = new System.Drawing.Size(89, 13);
            this.lblClientFirstName.TabIndex = 93;
            this.lblClientFirstName.Text = "Client First Name:";
            // 
            // lblClientLastName
            // 
            this.lblClientLastName.AutoSize = true;
            this.lblClientLastName.Location = new System.Drawing.Point(178, 109);
            this.lblClientLastName.Name = "lblClientLastName";
            this.lblClientLastName.Size = new System.Drawing.Size(90, 13);
            this.lblClientLastName.TabIndex = 92;
            this.lblClientLastName.Text = "Client Last Name:";
            // 
            // lstClientOrder
            // 
            this.lstClientOrder.FormattingEnabled = true;
            this.lstClientOrder.Location = new System.Drawing.Point(12, 4);
            this.lstClientOrder.Name = "lstClientOrder";
            this.lstClientOrder.Size = new System.Drawing.Size(159, 199);
            this.lstClientOrder.TabIndex = 91;
            // 
            // btnShipped
            // 
            this.btnShipped.Location = new System.Drawing.Point(12, 238);
            this.btnShipped.Name = "btnShipped";
            this.btnShipped.Size = new System.Drawing.Size(186, 23);
            this.btnShipped.TabIndex = 111;
            this.btnShipped.Text = "Mark Client Order as Shipped";
            this.btnShipped.UseVisualStyleBackColor = true;
            this.btnShipped.Click += new System.EventHandler(this.btnShipped_Click);
            // 
            // btnPaid
            // 
            this.btnPaid.Location = new System.Drawing.Point(221, 238);
            this.btnPaid.Name = "btnPaid";
            this.btnPaid.Size = new System.Drawing.Size(190, 23);
            this.btnPaid.TabIndex = 110;
            this.btnPaid.Text = "Mark Client Order as Paid";
            this.btnPaid.UseVisualStyleBackColor = true;
            this.btnPaid.Click += new System.EventHandler(this.btnPaid_Click);
            // 
            // pnlAddClientOrder
            // 
            this.pnlAddClientOrder.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlAddClientOrder.Controls.Add(this.dtpClientOrderDate);
            this.pnlAddClientOrder.Controls.Add(this.cboAddClientFirstName);
            this.pnlAddClientOrder.Controls.Add(this.btnAddCancel);
            this.pnlAddClientOrder.Controls.Add(this.btnAddSave);
            this.pnlAddClientOrder.Controls.Add(this.lblAddClientOrderDate);
            this.pnlAddClientOrder.Controls.Add(this.cboAddClientLastName);
            this.pnlAddClientOrder.Controls.Add(this.cboAddClientID);
            this.pnlAddClientOrder.Controls.Add(this.lblAddClient);
            this.pnlAddClientOrder.Location = new System.Drawing.Point(456, 2);
            this.pnlAddClientOrder.Name = "pnlAddClientOrder";
            this.pnlAddClientOrder.Size = new System.Drawing.Size(389, 113);
            this.pnlAddClientOrder.TabIndex = 112;
            this.pnlAddClientOrder.Visible = false;
            // 
            // dtpClientOrderDate
            // 
            this.dtpClientOrderDate.Location = new System.Drawing.Point(100, 9);
            this.dtpClientOrderDate.Name = "dtpClientOrderDate";
            this.dtpClientOrderDate.Size = new System.Drawing.Size(145, 20);
            this.dtpClientOrderDate.TabIndex = 81;
            // 
            // cboAddClientFirstName
            // 
            this.cboAddClientFirstName.FormattingEnabled = true;
            this.cboAddClientFirstName.Location = new System.Drawing.Point(270, 37);
            this.cboAddClientFirstName.Name = "cboAddClientFirstName";
            this.cboAddClientFirstName.Size = new System.Drawing.Size(102, 21);
            this.cboAddClientFirstName.TabIndex = 70;
            // 
            // btnAddCancel
            // 
            this.btnAddCancel.Location = new System.Drawing.Point(270, 76);
            this.btnAddCancel.Name = "btnAddCancel";
            this.btnAddCancel.Size = new System.Drawing.Size(101, 23);
            this.btnAddCancel.TabIndex = 59;
            this.btnAddCancel.Text = "Cancel";
            this.btnAddCancel.UseVisualStyleBackColor = true;
            this.btnAddCancel.Click += new System.EventHandler(this.btnAddCancel_Click);
            // 
            // btnAddSave
            // 
            this.btnAddSave.Location = new System.Drawing.Point(18, 76);
            this.btnAddSave.Name = "btnAddSave";
            this.btnAddSave.Size = new System.Drawing.Size(99, 23);
            this.btnAddSave.TabIndex = 58;
            this.btnAddSave.Text = "Save Client Order";
            this.btnAddSave.UseVisualStyleBackColor = true;
            this.btnAddSave.Click += new System.EventHandler(this.btnAddSave_Click);
            // 
            // lblAddClientOrderDate
            // 
            this.lblAddClientOrderDate.AutoSize = true;
            this.lblAddClientOrderDate.Location = new System.Drawing.Point(3, 12);
            this.lblAddClientOrderDate.Name = "lblAddClientOrderDate";
            this.lblAddClientOrderDate.Size = new System.Drawing.Size(91, 13);
            this.lblAddClientOrderDate.TabIndex = 72;
            this.lblAddClientOrderDate.Text = "Client Order Date:";
            // 
            // cboAddClientLastName
            // 
            this.cboAddClientLastName.FormattingEnabled = true;
            this.cboAddClientLastName.Location = new System.Drawing.Point(155, 37);
            this.cboAddClientLastName.Name = "cboAddClientLastName";
            this.cboAddClientLastName.Size = new System.Drawing.Size(109, 21);
            this.cboAddClientLastName.TabIndex = 53;
            // 
            // cboAddClientID
            // 
            this.cboAddClientID.FormattingEnabled = true;
            this.cboAddClientID.Location = new System.Drawing.Point(100, 37);
            this.cboAddClientID.Name = "cboAddClientID";
            this.cboAddClientID.Size = new System.Drawing.Size(46, 21);
            this.cboAddClientID.TabIndex = 52;
            // 
            // lblAddClient
            // 
            this.lblAddClient.AutoSize = true;
            this.lblAddClient.Location = new System.Drawing.Point(58, 40);
            this.lblAddClient.Name = "lblAddClient";
            this.lblAddClient.Size = new System.Drawing.Size(36, 13);
            this.lblAddClient.TabIndex = 80;
            this.lblAddClient.Text = "Client:";
            // 
            // pnlUpdClientOrder
            // 
            this.pnlUpdClientOrder.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlUpdClientOrder.Controls.Add(this.dtpUpdClientOrderDate);
            this.pnlUpdClientOrder.Controls.Add(this.txtUpdStatus);
            this.pnlUpdClientOrder.Controls.Add(this.lblUpdStatus);
            this.pnlUpdClientOrder.Controls.Add(this.txtUpdClientLastName);
            this.pnlUpdClientOrder.Controls.Add(this.txtUpdClientFirstName);
            this.pnlUpdClientOrder.Controls.Add(this.txtUpdClientOrderID);
            this.pnlUpdClientOrder.Controls.Add(this.txtUpdClientID);
            this.pnlUpdClientOrder.Controls.Add(this.lblUpdClientID);
            this.pnlUpdClientOrder.Controls.Add(this.lblUpdClientOrderDate);
            this.pnlUpdClientOrder.Controls.Add(this.lblUpdClientOrderID);
            this.pnlUpdClientOrder.Controls.Add(this.lblUpdClientFirstName);
            this.pnlUpdClientOrder.Controls.Add(this.lblUpdClientLastName);
            this.pnlUpdClientOrder.Controls.Add(this.btnUpdCancel);
            this.pnlUpdClientOrder.Controls.Add(this.btnUpdSave);
            this.pnlUpdClientOrder.Location = new System.Drawing.Point(557, 121);
            this.pnlUpdClientOrder.Name = "pnlUpdClientOrder";
            this.pnlUpdClientOrder.Size = new System.Drawing.Size(288, 264);
            this.pnlUpdClientOrder.TabIndex = 113;
            this.pnlUpdClientOrder.Visible = false;
            // 
            // dtpUpdClientOrderDate
            // 
            this.dtpUpdClientOrderDate.Location = new System.Drawing.Point(107, 36);
            this.dtpUpdClientOrderDate.Name = "dtpUpdClientOrderDate";
            this.dtpUpdClientOrderDate.Size = new System.Drawing.Size(145, 20);
            this.dtpUpdClientOrderDate.TabIndex = 122;
            // 
            // txtUpdStatus
            // 
            this.txtUpdStatus.Location = new System.Drawing.Point(107, 172);
            this.txtUpdStatus.Name = "txtUpdStatus";
            this.txtUpdStatus.Size = new System.Drawing.Size(75, 20);
            this.txtUpdStatus.TabIndex = 121;
            // 
            // lblUpdStatus
            // 
            this.lblUpdStatus.AutoSize = true;
            this.lblUpdStatus.Location = new System.Drawing.Point(63, 175);
            this.lblUpdStatus.Name = "lblUpdStatus";
            this.lblUpdStatus.Size = new System.Drawing.Size(40, 13);
            this.lblUpdStatus.TabIndex = 120;
            this.lblUpdStatus.Text = "Status:";
            // 
            // txtUpdClientLastName
            // 
            this.txtUpdClientLastName.Location = new System.Drawing.Point(107, 109);
            this.txtUpdClientLastName.Name = "txtUpdClientLastName";
            this.txtUpdClientLastName.Size = new System.Drawing.Size(161, 20);
            this.txtUpdClientLastName.TabIndex = 119;
            // 
            // txtUpdClientFirstName
            // 
            this.txtUpdClientFirstName.Location = new System.Drawing.Point(107, 140);
            this.txtUpdClientFirstName.Name = "txtUpdClientFirstName";
            this.txtUpdClientFirstName.Size = new System.Drawing.Size(161, 20);
            this.txtUpdClientFirstName.TabIndex = 118;
            // 
            // txtUpdClientOrderID
            // 
            this.txtUpdClientOrderID.Location = new System.Drawing.Point(107, 5);
            this.txtUpdClientOrderID.Name = "txtUpdClientOrderID";
            this.txtUpdClientOrderID.Size = new System.Drawing.Size(51, 20);
            this.txtUpdClientOrderID.TabIndex = 117;
            // 
            // txtUpdClientID
            // 
            this.txtUpdClientID.Location = new System.Drawing.Point(107, 74);
            this.txtUpdClientID.Name = "txtUpdClientID";
            this.txtUpdClientID.Size = new System.Drawing.Size(51, 20);
            this.txtUpdClientID.TabIndex = 115;
            // 
            // lblUpdClientID
            // 
            this.lblUpdClientID.AutoSize = true;
            this.lblUpdClientID.Location = new System.Drawing.Point(51, 77);
            this.lblUpdClientID.Name = "lblUpdClientID";
            this.lblUpdClientID.Size = new System.Drawing.Size(50, 13);
            this.lblUpdClientID.TabIndex = 114;
            this.lblUpdClientID.Text = "Client ID:";
            // 
            // lblUpdClientOrderDate
            // 
            this.lblUpdClientOrderDate.AutoSize = true;
            this.lblUpdClientOrderDate.Location = new System.Drawing.Point(10, 42);
            this.lblUpdClientOrderDate.Name = "lblUpdClientOrderDate";
            this.lblUpdClientOrderDate.Size = new System.Drawing.Size(91, 13);
            this.lblUpdClientOrderDate.TabIndex = 113;
            this.lblUpdClientOrderDate.Text = "Client Order Date:";
            // 
            // lblUpdClientOrderID
            // 
            this.lblUpdClientOrderID.AutoSize = true;
            this.lblUpdClientOrderID.Location = new System.Drawing.Point(22, 8);
            this.lblUpdClientOrderID.Name = "lblUpdClientOrderID";
            this.lblUpdClientOrderID.Size = new System.Drawing.Size(79, 13);
            this.lblUpdClientOrderID.TabIndex = 112;
            this.lblUpdClientOrderID.Text = "Client Order ID:";
            // 
            // lblUpdClientFirstName
            // 
            this.lblUpdClientFirstName.AutoSize = true;
            this.lblUpdClientFirstName.Location = new System.Drawing.Point(12, 143);
            this.lblUpdClientFirstName.Name = "lblUpdClientFirstName";
            this.lblUpdClientFirstName.Size = new System.Drawing.Size(89, 13);
            this.lblUpdClientFirstName.TabIndex = 111;
            this.lblUpdClientFirstName.Text = "Client First Name:";
            // 
            // lblUpdClientLastName
            // 
            this.lblUpdClientLastName.AutoSize = true;
            this.lblUpdClientLastName.Location = new System.Drawing.Point(11, 112);
            this.lblUpdClientLastName.Name = "lblUpdClientLastName";
            this.lblUpdClientLastName.Size = new System.Drawing.Size(90, 13);
            this.lblUpdClientLastName.TabIndex = 110;
            this.lblUpdClientLastName.Text = "Client Last Name:";
            // 
            // btnUpdCancel
            // 
            this.btnUpdCancel.Location = new System.Drawing.Point(169, 227);
            this.btnUpdCancel.Name = "btnUpdCancel";
            this.btnUpdCancel.Size = new System.Drawing.Size(101, 23);
            this.btnUpdCancel.TabIndex = 59;
            this.btnUpdCancel.Text = "Cancel";
            this.btnUpdCancel.UseVisualStyleBackColor = true;
            this.btnUpdCancel.Click += new System.EventHandler(this.btnUpdCancel_Click);
            // 
            // btnUpdSave
            // 
            this.btnUpdSave.Location = new System.Drawing.Point(13, 227);
            this.btnUpdSave.Name = "btnUpdSave";
            this.btnUpdSave.Size = new System.Drawing.Size(99, 23);
            this.btnUpdSave.TabIndex = 58;
            this.btnUpdSave.Text = "Save Changes";
            this.btnUpdSave.UseVisualStyleBackColor = true;
            this.btnUpdSave.Click += new System.EventHandler(this.btnUpdSave_Click);
            // 
            // OrderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(539, 278);
            this.Controls.Add(this.pnlUpdClientOrder);
            this.Controls.Add(this.pnlAddClientOrder);
            this.Controls.Add(this.btnShipped);
            this.Controls.Add(this.btnPaid);
            this.Controls.Add(this.txtStatus);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.btnPrevious);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.btnAddClientOrder);
            this.Controls.Add(this.btnUpdateClientOrder);
            this.Controls.Add(this.btnDeleteClientOrder);
            this.Controls.Add(this.txtClientLastName);
            this.Controls.Add(this.txtClientFirstName);
            this.Controls.Add(this.txtClientOrderID);
            this.Controls.Add(this.txtClientOrderDate);
            this.Controls.Add(this.txtClientID);
            this.Controls.Add(this.lblClientID);
            this.Controls.Add(this.lblClientOrderDate);
            this.Controls.Add(this.lblClientOrderID);
            this.Controls.Add(this.lblClientFirstName);
            this.Controls.Add(this.lblClientLastName);
            this.Controls.Add(this.lstClientOrder);
            this.Name = "OrderForm";
            this.Text = "Client Order Maintenance";
            this.pnlAddClientOrder.ResumeLayout(false);
            this.pnlAddClientOrder.PerformLayout();
            this.pnlUpdClientOrder.ResumeLayout(false);
            this.pnlUpdClientOrder.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtStatus;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.Button btnPrevious;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnAddClientOrder;
        private System.Windows.Forms.Button btnUpdateClientOrder;
        private System.Windows.Forms.Button btnDeleteClientOrder;
        private System.Windows.Forms.TextBox txtClientLastName;
        private System.Windows.Forms.TextBox txtClientFirstName;
        private System.Windows.Forms.TextBox txtClientOrderID;
        private System.Windows.Forms.TextBox txtClientOrderDate;
        private System.Windows.Forms.TextBox txtClientID;
        private System.Windows.Forms.Label lblClientID;
        private System.Windows.Forms.Label lblClientOrderDate;
        private System.Windows.Forms.Label lblClientOrderID;
        private System.Windows.Forms.Label lblClientFirstName;
        private System.Windows.Forms.Label lblClientLastName;
        private System.Windows.Forms.ListBox lstClientOrder;
        private System.Windows.Forms.Button btnShipped;
        private System.Windows.Forms.Button btnPaid;
        private System.Windows.Forms.Panel pnlAddClientOrder;
        private System.Windows.Forms.DateTimePicker dtpClientOrderDate;
        private System.Windows.Forms.ComboBox cboAddClientFirstName;
        private System.Windows.Forms.Button btnAddCancel;
        private System.Windows.Forms.Button btnAddSave;
        private System.Windows.Forms.Label lblAddClientOrderDate;
        private System.Windows.Forms.ComboBox cboAddClientLastName;
        private System.Windows.Forms.ComboBox cboAddClientID;
        private System.Windows.Forms.Label lblAddClient;
        private System.Windows.Forms.Panel pnlUpdClientOrder;
        private System.Windows.Forms.TextBox txtUpdStatus;
        private System.Windows.Forms.Label lblUpdStatus;
        private System.Windows.Forms.TextBox txtUpdClientLastName;
        private System.Windows.Forms.TextBox txtUpdClientFirstName;
        private System.Windows.Forms.TextBox txtUpdClientOrderID;
        private System.Windows.Forms.TextBox txtUpdClientID;
        private System.Windows.Forms.Label lblUpdClientID;
        private System.Windows.Forms.Label lblUpdClientOrderDate;
        private System.Windows.Forms.Label lblUpdClientOrderID;
        private System.Windows.Forms.Label lblUpdClientFirstName;
        private System.Windows.Forms.Label lblUpdClientLastName;
        private System.Windows.Forms.Button btnUpdCancel;
        private System.Windows.Forms.Button btnUpdSave;
        private System.Windows.Forms.DateTimePicker dtpUpdClientOrderDate;
    }
}