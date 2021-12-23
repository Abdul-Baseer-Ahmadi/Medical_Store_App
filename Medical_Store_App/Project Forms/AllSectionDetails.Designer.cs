
namespace Medical_Store_App.Project_Forms
{
    partial class AllSectionDetails
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
            this.grpBoxAllSections = new System.Windows.Forms.GroupBox();
            this.lblReportType = new System.Windows.Forms.Label();
            this.comboBoxReportType = new System.Windows.Forms.ComboBox();
            this.lblStartDate = new System.Windows.Forms.Label();
            this.dateTimePickerStartDate = new System.Windows.Forms.DateTimePicker();
            this.lblEndDate = new System.Windows.Forms.Label();
            this.dateTimePickerEndDate = new System.Windows.Forms.DateTimePicker();
            this.btnPrintAnyReport = new System.Windows.Forms.Button();
            this.grpBoxAllSections.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpBoxAllSections
            // 
            this.grpBoxAllSections.Controls.Add(this.btnPrintAnyReport);
            this.grpBoxAllSections.Controls.Add(this.dateTimePickerEndDate);
            this.grpBoxAllSections.Controls.Add(this.lblEndDate);
            this.grpBoxAllSections.Controls.Add(this.dateTimePickerStartDate);
            this.grpBoxAllSections.Controls.Add(this.lblStartDate);
            this.grpBoxAllSections.Controls.Add(this.comboBoxReportType);
            this.grpBoxAllSections.Controls.Add(this.lblReportType);
            this.grpBoxAllSections.Location = new System.Drawing.Point(536, 71);
            this.grpBoxAllSections.Name = "grpBoxAllSections";
            this.grpBoxAllSections.Size = new System.Drawing.Size(300, 298);
            this.grpBoxAllSections.TabIndex = 0;
            this.grpBoxAllSections.TabStop = false;
            this.grpBoxAllSections.Text = "All Reports";
            // 
            // lblReportType
            // 
            this.lblReportType.AutoSize = true;
            this.lblReportType.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReportType.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblReportType.Location = new System.Drawing.Point(5, 50);
            this.lblReportType.Name = "lblReportType";
            this.lblReportType.Size = new System.Drawing.Size(44, 15);
            this.lblReportType.TabIndex = 0;
            this.lblReportType.Text = "Report";
            // 
            // comboBoxReportType
            // 
            this.comboBoxReportType.FormattingEnabled = true;
            this.comboBoxReportType.Items.AddRange(new object[] {
            "--Select Report--",
            "Stock History",
            "Sale Report",
            "Purchase Report"});
            this.comboBoxReportType.Location = new System.Drawing.Point(8, 69);
            this.comboBoxReportType.Name = "comboBoxReportType";
            this.comboBoxReportType.Size = new System.Drawing.Size(284, 23);
            this.comboBoxReportType.TabIndex = 1;
            // 
            // lblStartDate
            // 
            this.lblStartDate.AutoSize = true;
            this.lblStartDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStartDate.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblStartDate.Location = new System.Drawing.Point(5, 102);
            this.lblStartDate.Name = "lblStartDate";
            this.lblStartDate.Size = new System.Drawing.Size(61, 15);
            this.lblStartDate.TabIndex = 2;
            this.lblStartDate.Text = "Start Date";
            // 
            // dateTimePickerStartDate
            // 
            this.dateTimePickerStartDate.Location = new System.Drawing.Point(8, 121);
            this.dateTimePickerStartDate.Name = "dateTimePickerStartDate";
            this.dateTimePickerStartDate.Size = new System.Drawing.Size(284, 21);
            this.dateTimePickerStartDate.TabIndex = 3;
            // 
            // lblEndDate
            // 
            this.lblEndDate.AutoSize = true;
            this.lblEndDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEndDate.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblEndDate.Location = new System.Drawing.Point(5, 152);
            this.lblEndDate.Name = "lblEndDate";
            this.lblEndDate.Size = new System.Drawing.Size(58, 15);
            this.lblEndDate.TabIndex = 4;
            this.lblEndDate.Text = "End Date";
            // 
            // dateTimePickerEndDate
            // 
            this.dateTimePickerEndDate.Location = new System.Drawing.Point(8, 172);
            this.dateTimePickerEndDate.Name = "dateTimePickerEndDate";
            this.dateTimePickerEndDate.Size = new System.Drawing.Size(284, 21);
            this.dateTimePickerEndDate.TabIndex = 5;
            // 
            // btnPrintAnyReport
            // 
            this.btnPrintAnyReport.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnPrintAnyReport.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrintAnyReport.ForeColor = System.Drawing.Color.White;
            this.btnPrintAnyReport.Location = new System.Drawing.Point(8, 215);
            this.btnPrintAnyReport.Name = "btnPrintAnyReport";
            this.btnPrintAnyReport.Size = new System.Drawing.Size(284, 32);
            this.btnPrintAnyReport.TabIndex = 6;
            this.btnPrintAnyReport.Text = "Print Report";
            this.btnPrintAnyReport.UseVisualStyleBackColor = false;
            this.btnPrintAnyReport.Click += new System.EventHandler(this.btnPrintAnyReport_Click);
            // 
            // AllSectionDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1290, 722);
            this.ControlBox = false;
            this.Controls.Add(this.grpBoxAllSections);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.Highlight;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AllSectionDetails";
            this.Text = "AllSectionDetails";
            this.grpBoxAllSections.ResumeLayout(false);
            this.grpBoxAllSections.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpBoxAllSections;
        private System.Windows.Forms.Button btnPrintAnyReport;
        private System.Windows.Forms.DateTimePicker dateTimePickerEndDate;
        private System.Windows.Forms.Label lblEndDate;
        private System.Windows.Forms.DateTimePicker dateTimePickerStartDate;
        private System.Windows.Forms.Label lblStartDate;
        private System.Windows.Forms.ComboBox comboBoxReportType;
        private System.Windows.Forms.Label lblReportType;
    }
}