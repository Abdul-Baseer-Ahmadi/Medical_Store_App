﻿
namespace Medical_Store_App.Project_Forms
{
    partial class TestReportForm
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
            this.crystalReportViewerTestReport = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // crystalReportViewerTestReport
            // 
            this.crystalReportViewerTestReport.ActiveViewIndex = -1;
            this.crystalReportViewerTestReport.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crystalReportViewerTestReport.Cursor = System.Windows.Forms.Cursors.Default;
            this.crystalReportViewerTestReport.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crystalReportViewerTestReport.Location = new System.Drawing.Point(0, 0);
            this.crystalReportViewerTestReport.Name = "crystalReportViewerTestReport";
            this.crystalReportViewerTestReport.Size = new System.Drawing.Size(800, 450);
            this.crystalReportViewerTestReport.TabIndex = 0;
            // 
            // TestReportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.crystalReportViewerTestReport);
            this.Name = "TestReportForm";
            this.Text = "TestReportForm";
            this.Load += new System.EventHandler(this.TestReportForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewerTestReport;
    }
}