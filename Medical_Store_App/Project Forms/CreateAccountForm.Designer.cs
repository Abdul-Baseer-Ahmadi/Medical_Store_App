
namespace Medical_Store_App.Project_Forms
{
    partial class CreateAccountForm
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.grpBoxCreateAccount = new System.Windows.Forms.GroupBox();
            this.txtId = new System.Windows.Forms.TextBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnCreateAccount = new System.Windows.Forms.Button();
            this.comboRole = new System.Windows.Forms.ComboBox();
            this.lblRole = new System.Windows.Forms.Label();
            this.txtConfirmPass = new System.Windows.Forms.TextBox();
            this.lblConfirmPass = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.grpBoxUserList = new System.Windows.Forms.GroupBox();
            this.dGrdViewUserList = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.passwordDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.confirmPassDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.roleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnEdit = new System.Windows.Forms.DataGridViewLinkColumn();
            this.btnDelete = new System.Windows.Forms.DataGridViewLinkColumn();
            this.userLoginsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.medicalStoreDataSet = new Medical_Store_App.MedicalStoreDataSet();
            this.userLoginsTableAdapter = new Medical_Store_App.MedicalStoreDataSetTableAdapters.UserLoginsTableAdapter();
            this.grpBoxCreateAccount.SuspendLayout();
            this.grpBoxUserList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGrdViewUserList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userLoginsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.medicalStoreDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // grpBoxCreateAccount
            // 
            this.grpBoxCreateAccount.Controls.Add(this.txtId);
            this.grpBoxCreateAccount.Controls.Add(this.btnCancel);
            this.grpBoxCreateAccount.Controls.Add(this.btnCreateAccount);
            this.grpBoxCreateAccount.Controls.Add(this.comboRole);
            this.grpBoxCreateAccount.Controls.Add(this.lblRole);
            this.grpBoxCreateAccount.Controls.Add(this.txtConfirmPass);
            this.grpBoxCreateAccount.Controls.Add(this.lblConfirmPass);
            this.grpBoxCreateAccount.Controls.Add(this.txtPassword);
            this.grpBoxCreateAccount.Controls.Add(this.lblPassword);
            this.grpBoxCreateAccount.Controls.Add(this.txtUserName);
            this.grpBoxCreateAccount.Controls.Add(this.lblName);
            this.grpBoxCreateAccount.ForeColor = System.Drawing.Color.Black;
            this.grpBoxCreateAccount.Location = new System.Drawing.Point(1, 12);
            this.grpBoxCreateAccount.Name = "grpBoxCreateAccount";
            this.grpBoxCreateAccount.Size = new System.Drawing.Size(284, 369);
            this.grpBoxCreateAccount.TabIndex = 0;
            this.grpBoxCreateAccount.TabStop = false;
            this.grpBoxCreateAccount.Text = "Create Account";
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(162, 15);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(100, 20);
            this.txtId.TabIndex = 10;
            this.txtId.Visible = false;
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.Crimson;
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.Color.White;
            this.btnCancel.Location = new System.Drawing.Point(6, 294);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(252, 33);
            this.btnCancel.TabIndex = 6;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnCreateAccount
            // 
            this.btnCreateAccount.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnCreateAccount.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreateAccount.ForeColor = System.Drawing.Color.White;
            this.btnCreateAccount.Location = new System.Drawing.Point(7, 255);
            this.btnCreateAccount.Name = "btnCreateAccount";
            this.btnCreateAccount.Size = new System.Drawing.Size(252, 33);
            this.btnCreateAccount.TabIndex = 5;
            this.btnCreateAccount.Text = "Create Account";
            this.btnCreateAccount.UseVisualStyleBackColor = false;
            this.btnCreateAccount.Click += new System.EventHandler(this.btnCreateAccount_Click);
            // 
            // comboRole
            // 
            this.comboRole.FormattingEnabled = true;
            this.comboRole.Items.AddRange(new object[] {
            "Admin",
            "Pharmacist"});
            this.comboRole.Location = new System.Drawing.Point(7, 207);
            this.comboRole.Name = "comboRole";
            this.comboRole.Size = new System.Drawing.Size(252, 21);
            this.comboRole.TabIndex = 4;
            this.comboRole.Text = "--Select Role--";
            // 
            // lblRole
            // 
            this.lblRole.AutoSize = true;
            this.lblRole.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRole.Location = new System.Drawing.Point(4, 186);
            this.lblRole.Name = "lblRole";
            this.lblRole.Size = new System.Drawing.Size(41, 17);
            this.lblRole.TabIndex = 6;
            this.lblRole.Text = "Role";
            // 
            // txtConfirmPass
            // 
            this.txtConfirmPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtConfirmPass.Location = new System.Drawing.Point(7, 151);
            this.txtConfirmPass.Name = "txtConfirmPass";
            this.txtConfirmPass.Size = new System.Drawing.Size(252, 23);
            this.txtConfirmPass.TabIndex = 3;
            // 
            // lblConfirmPass
            // 
            this.lblConfirmPass.AutoSize = true;
            this.lblConfirmPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConfirmPass.Location = new System.Drawing.Point(4, 131);
            this.lblConfirmPass.Name = "lblConfirmPass";
            this.lblConfirmPass.Size = new System.Drawing.Size(137, 17);
            this.lblConfirmPass.TabIndex = 4;
            this.lblConfirmPass.Text = "Confirm Password";
            // 
            // txtPassword
            // 
            this.txtPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.Location = new System.Drawing.Point(7, 95);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(252, 23);
            this.txtPassword.TabIndex = 2;
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassword.Location = new System.Drawing.Point(4, 75);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(77, 17);
            this.lblPassword.TabIndex = 2;
            this.lblPassword.Text = "Password";
            // 
            // txtUserName
            // 
            this.txtUserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUserName.Location = new System.Drawing.Point(7, 41);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(252, 23);
            this.txtUserName.TabIndex = 1;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(4, 21);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(49, 17);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Name";
            // 
            // grpBoxUserList
            // 
            this.grpBoxUserList.Controls.Add(this.dGrdViewUserList);
            this.grpBoxUserList.Location = new System.Drawing.Point(291, 12);
            this.grpBoxUserList.Name = "grpBoxUserList";
            this.grpBoxUserList.Size = new System.Drawing.Size(1067, 623);
            this.grpBoxUserList.TabIndex = 2;
            this.grpBoxUserList.TabStop = false;
            this.grpBoxUserList.Text = "User Information";
            // 
            // dGrdViewUserList
            // 
            this.dGrdViewUserList.AllowUserToAddRows = false;
            this.dGrdViewUserList.AllowUserToDeleteRows = false;
            this.dGrdViewUserList.AllowUserToResizeColumns = false;
            this.dGrdViewUserList.AllowUserToResizeRows = false;
            this.dGrdViewUserList.AutoGenerateColumns = false;
            this.dGrdViewUserList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dGrdViewUserList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dGrdViewUserList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGrdViewUserList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.passwordDataGridViewTextBoxColumn,
            this.confirmPassDataGridViewTextBoxColumn,
            this.roleDataGridViewTextBoxColumn,
            this.btnEdit,
            this.btnDelete});
            this.dGrdViewUserList.DataSource = this.userLoginsBindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dGrdViewUserList.DefaultCellStyle = dataGridViewCellStyle2;
            this.dGrdViewUserList.Location = new System.Drawing.Point(6, 21);
            this.dGrdViewUserList.MultiSelect = false;
            this.dGrdViewUserList.Name = "dGrdViewUserList";
            this.dGrdViewUserList.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dGrdViewUserList.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dGrdViewUserList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dGrdViewUserList.Size = new System.Drawing.Size(1055, 593);
            this.dGrdViewUserList.TabIndex = 0;
            this.dGrdViewUserList.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dGrdViewUserList_CellContentClick);
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "User Name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // passwordDataGridViewTextBoxColumn
            // 
            this.passwordDataGridViewTextBoxColumn.DataPropertyName = "Password";
            this.passwordDataGridViewTextBoxColumn.HeaderText = "Password";
            this.passwordDataGridViewTextBoxColumn.Name = "passwordDataGridViewTextBoxColumn";
            this.passwordDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // confirmPassDataGridViewTextBoxColumn
            // 
            this.confirmPassDataGridViewTextBoxColumn.DataPropertyName = "Confirm_Pass";
            this.confirmPassDataGridViewTextBoxColumn.HeaderText = "Confirm Password";
            this.confirmPassDataGridViewTextBoxColumn.Name = "confirmPassDataGridViewTextBoxColumn";
            this.confirmPassDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // roleDataGridViewTextBoxColumn
            // 
            this.roleDataGridViewTextBoxColumn.DataPropertyName = "Role";
            this.roleDataGridViewTextBoxColumn.HeaderText = "User Role";
            this.roleDataGridViewTextBoxColumn.Name = "roleDataGridViewTextBoxColumn";
            this.roleDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // btnEdit
            // 
            this.btnEdit.HeaderText = "Edit";
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.ReadOnly = true;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseColumnTextForLinkValue = true;
            // 
            // btnDelete
            // 
            this.btnDelete.HeaderText = "Delete";
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.ReadOnly = true;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseColumnTextForLinkValue = true;
            // 
            // userLoginsBindingSource
            // 
            this.userLoginsBindingSource.DataMember = "UserLogins";
            this.userLoginsBindingSource.DataSource = this.medicalStoreDataSet;
            // 
            // medicalStoreDataSet
            // 
            this.medicalStoreDataSet.DataSetName = "MedicalStoreDataSet";
            this.medicalStoreDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // userLoginsTableAdapter
            // 
            this.userLoginsTableAdapter.ClearBeforeFill = true;
            // 
            // CreateAccountForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1370, 711);
            this.ControlBox = false;
            this.Controls.Add(this.grpBoxUserList);
            this.Controls.Add(this.grpBoxCreateAccount);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CreateAccountForm";
            this.Text = "CreateAccount";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.CreateAccount_Load);
            this.grpBoxCreateAccount.ResumeLayout(false);
            this.grpBoxCreateAccount.PerformLayout();
            this.grpBoxUserList.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dGrdViewUserList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userLoginsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.medicalStoreDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpBoxCreateAccount;
        private System.Windows.Forms.ComboBox comboRole;
        private System.Windows.Forms.Label lblRole;
        private System.Windows.Forms.TextBox txtConfirmPass;
        private System.Windows.Forms.Label lblConfirmPass;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnCreateAccount;
        private System.Windows.Forms.GroupBox grpBoxUserList;
        private System.Windows.Forms.DataGridView dGrdViewUserList;
        private MedicalStoreDataSet medicalStoreDataSet;
        private System.Windows.Forms.BindingSource userLoginsBindingSource;
        private MedicalStoreDataSetTableAdapters.UserLoginsTableAdapter userLoginsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn passwordDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn confirmPassDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn roleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewLinkColumn btnEdit;
        private System.Windows.Forms.DataGridViewLinkColumn btnDelete;
        private System.Windows.Forms.TextBox txtId;
    }
}