namespace noteTakingApp
{
    partial class Form1
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
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblMsg = new System.Windows.Forms.Label();
            this.lblList = new System.Windows.Forms.Label();
            this.txtBxTitle = new System.Windows.Forms.TextBox();
            this.txtBxMsg = new System.Windows.Forms.TextBox();
            this.dtGridMessages = new System.Windows.Forms.DataGridView();
            this.btnNew = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnRead = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtGridMessages)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Location = new System.Drawing.Point(42, 47);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(30, 13);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Title:";
            // 
            // lblMsg
            // 
            this.lblMsg.AutoSize = true;
            this.lblMsg.Location = new System.Drawing.Point(19, 92);
            this.lblMsg.Name = "lblMsg";
            this.lblMsg.Size = new System.Drawing.Size(53, 13);
            this.lblMsg.TabIndex = 1;
            this.lblMsg.Text = "Message:";
            // 
            // lblList
            // 
            this.lblList.AutoSize = true;
            this.lblList.Location = new System.Drawing.Point(259, 92);
            this.lblList.Name = "lblList";
            this.lblList.Size = new System.Drawing.Size(89, 13);
            this.lblList.TabIndex = 2;
            this.lblList.Text = "List of Messages:";
            // 
            // txtBxTitle
            // 
            this.txtBxTitle.Location = new System.Drawing.Point(88, 47);
            this.txtBxTitle.Name = "txtBxTitle";
            this.txtBxTitle.Size = new System.Drawing.Size(100, 20);
            this.txtBxTitle.TabIndex = 3;
            // 
            // txtBxMsg
            // 
            this.txtBxMsg.Location = new System.Drawing.Point(88, 92);
            this.txtBxMsg.Multiline = true;
            this.txtBxMsg.Name = "txtBxMsg";
            this.txtBxMsg.Size = new System.Drawing.Size(165, 178);
            this.txtBxMsg.TabIndex = 4;
            // 
            // dtGridMessages
            // 
            this.dtGridMessages.AllowUserToAddRows = false;
            this.dtGridMessages.AllowUserToDeleteRows = false;
            this.dtGridMessages.AllowUserToResizeColumns = false;
            this.dtGridMessages.AllowUserToResizeRows = false;
            this.dtGridMessages.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtGridMessages.Location = new System.Drawing.Point(354, 92);
            this.dtGridMessages.Name = "dtGridMessages";
            this.dtGridMessages.ReadOnly = true;
            this.dtGridMessages.RowHeadersVisible = false;
            this.dtGridMessages.Size = new System.Drawing.Size(185, 178);
            this.dtGridMessages.TabIndex = 5;
            // 
            // btnNew
            // 
            this.btnNew.Location = new System.Drawing.Point(88, 311);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(75, 23);
            this.btnNew.TabIndex = 6;
            this.btnNew.Text = "New";
            this.btnNew.UseVisualStyleBackColor = true;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(217, 311);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 7;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnRead
            // 
            this.btnRead.Location = new System.Drawing.Point(354, 311);
            this.btnRead.Name = "btnRead";
            this.btnRead.Size = new System.Drawing.Size(75, 23);
            this.btnRead.TabIndex = 8;
            this.btnRead.Text = "Read";
            this.btnRead.UseVisualStyleBackColor = true;
            this.btnRead.Click += new System.EventHandler(this.btnRead_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(473, 311);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 9;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(603, 376);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnRead);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnNew);
            this.Controls.Add(this.dtGridMessages);
            this.Controls.Add(this.txtBxMsg);
            this.Controls.Add(this.txtBxTitle);
            this.Controls.Add(this.lblList);
            this.Controls.Add(this.lblMsg);
            this.Controls.Add(this.lblTitle);
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtGridMessages)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label titleLbl;
        private System.Windows.Forms.Label msgLbl;
        private System.Windows.Forms.TextBox titleTxtBx;
        private System.Windows.Forms.TextBox msgTxtBx;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button newBtn;
        private System.Windows.Forms.Button readBtn;
        private System.Windows.Forms.Button saveBtn;
        private System.Windows.Forms.Button deleteBtn;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblMsg;
        private System.Windows.Forms.Label lblList;
        private System.Windows.Forms.TextBox txtBxTitle;
        private System.Windows.Forms.TextBox txtBxMsg;
        private System.Windows.Forms.DataGridView dtGridMessages;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnRead;
        private System.Windows.Forms.Button btnDelete;
    }
}

