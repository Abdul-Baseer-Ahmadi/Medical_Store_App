
namespace Medical_Store_App.Project_Forms
{
    partial class AddTestForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.grpBoxTestInfo = new System.Windows.Forms.GroupBox();
            this.txtId = new System.Windows.Forms.TextBox();
            this.lblPrice = new System.Windows.Forms.Label();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.dGridViewTestInfo = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TestName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Edit = new System.Windows.Forms.DataGridViewLinkColumn();
            this.Delete = new System.Windows.Forms.DataGridViewLinkColumn();
            this.lblTestName = new System.Windows.Forms.Label();
            this.txtTestName = new System.Windows.Forms.TextBox();
            this.lblTestInfo = new System.Windows.Forms.Label();
            this.grpBoxTestInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGridViewTestInfo)).BeginInit();
            this.SuspendLayout();
            // 
            // grpBoxTestInfo
            // 
            this.grpBoxTestInfo.Controls.Add(this.txtId);
            this.grpBoxTestInfo.Controls.Add(this.lblPrice);
            this.grpBoxTestInfo.Controls.Add(this.txtPrice);
            this.grpBoxTestInfo.Controls.Add(this.btnSave);
            this.grpBoxTestInfo.Controls.Add(this.dGridViewTestInfo);
            this.grpBoxTestInfo.Controls.Add(this.lblTestName);
            this.grpBoxTestInfo.Controls.Add(this.txtTestName);
            this.grpBoxTestInfo.Controls.Add(this.lblTestInfo);
            this.grpBoxTestInfo.Location = new System.Drawing.Point(441, 45);
            this.grpBoxTestInfo.Name = "grpBoxTestInfo";
            this.grpBoxTestInfo.Size = new System.Drawing.Size(599, 567);
            this.grpBoxTestInfo.TabIndex = 0;
            this.grpBoxTestInfo.TabStop = false;
            this.grpBoxTestInfo.Text = "Test Info";
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(309, 59);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(100, 20);
            this.txtId.TabIndex = 7;
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrice.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblPrice.Location = new System.Drawing.Point(186, 112);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(35, 15);
            this.lblPrice.TabIndex = 6;
            this.lblPrice.Text = "Price";
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(189, 130);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(221, 20);
            this.txtPrice.TabIndex = 2;
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(189, 165);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(221, 28);
            this.btnSave.TabIndex = 3;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // dGridViewTestInfo
            // 
            this.dGridViewTestInfo.AllowUserToAddRows = false;
            this.dGridViewTestInfo.AllowUserToDeleteRows = false;
            this.dGridViewTestInfo.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dGridViewTestInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGridViewTestInfo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.TestName,
            this.Price,
            this.Edit,
            this.Delete});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dGridViewTestInfo.DefaultCellStyle = dataGridViewCellStyle2;
            this.dGridViewTestInfo.Location = new System.Drawing.Point(6, 208);
            this.dGridViewTestInfo.Name = "dGridViewTestInfo";
            this.dGridViewTestInfo.ReadOnly = true;
            this.dGridViewTestInfo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dGridViewTestInfo.Size = new System.Drawing.Size(570, 353);
            this.dGridViewTestInfo.TabIndex = 3;
            this.dGridViewTestInfo.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dGridViewTestInfo_CellContentClick);
            // 
            // Id
            // 
            this.Id.DataPropertyName = "Id";
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            // 
            // TestName
            // 
            this.TestName.DataPropertyName = "Name";
            this.TestName.HeaderText = "Test Name";
            this.TestName.Name = "TestName";
            this.TestName.ReadOnly = true;
            // 
            // Price
            // 
            this.Price.DataPropertyName = "Price";
            this.Price.HeaderText = "Price";
            this.Price.Name = "Price";
            this.Price.ReadOnly = true;
            this.Price.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Price.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Edit
            // 
            this.Edit.HeaderText = "Edit";
            this.Edit.Name = "Edit";
            this.Edit.ReadOnly = true;
            this.Edit.Text = "Edit";
            this.Edit.UseColumnTextForLinkValue = true;
            // 
            // Delete
            // 
            this.Delete.HeaderText = "Delete";
            this.Delete.Name = "Delete";
            this.Delete.ReadOnly = true;
            this.Delete.Text = "Delete";
            this.Delete.UseColumnTextForLinkValue = true;
            // 
            // lblTestName
            // 
            this.lblTestName.AutoSize = true;
            this.lblTestName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTestName.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblTestName.Location = new System.Drawing.Point(186, 67);
            this.lblTestName.Name = "lblTestName";
            this.lblTestName.Size = new System.Drawing.Size(67, 15);
            this.lblTestName.TabIndex = 2;
            this.lblTestName.Text = "Test Name";
            // 
            // txtTestName
            // 
            this.txtTestName.Location = new System.Drawing.Point(189, 85);
            this.txtTestName.Name = "txtTestName";
            this.txtTestName.Size = new System.Drawing.Size(221, 20);
            this.txtTestName.TabIndex = 1;
            // 
            // lblTestInfo
            // 
            this.lblTestInfo.AutoSize = true;
            this.lblTestInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTestInfo.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblTestInfo.Location = new System.Drawing.Point(219, 30);
            this.lblTestInfo.Name = "lblTestInfo";
            this.lblTestInfo.Size = new System.Drawing.Size(155, 22);
            this.lblTestInfo.TabIndex = 0;
            this.lblTestInfo.Text = "Test Information";
            // 
            // AddTestForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1078, 676);
            this.ControlBox = false;
            this.Controls.Add(this.grpBoxTestInfo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AddTestForm";
            this.Text = "Add Test Form";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.AddTestForm_Load);
            this.grpBoxTestInfo.ResumeLayout(false);
            this.grpBoxTestInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGridViewTestInfo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpBoxTestInfo;
        private System.Windows.Forms.Label lblTestInfo;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.DataGridView dGridViewTestInfo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn TestName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
        private System.Windows.Forms.DataGridViewLinkColumn Edit;
        private System.Windows.Forms.DataGridViewLinkColumn Delete;
        private System.Windows.Forms.Label lblTestName;
        private System.Windows.Forms.TextBox txtTestName;
        private System.Windows.Forms.TextBox txtId;
    }
}