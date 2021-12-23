
namespace Medical_Store_App.Project_Forms
{
    partial class StockReportForm
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
            this.crystalReportViewerStockHistory = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // crystalReportViewerStockHistory
            // 
            this.crystalReportViewerStockHistory.ActiveViewIndex = -1;
            this.crystalReportViewerStockHistory.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crystalReportViewerStockHistory.Cursor = System.Windows.Forms.Cursors.Default;
            this.crystalReportViewerStockHistory.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crystalReportViewerStockHistory.Location = new System.Drawing.Point(0, 0);
            this.crystalReportViewerStockHistory.Name = "crystalReportViewerStockHistory";
            this.crystalReportViewerStockHistory.Size = new System.Drawing.Size(800, 450);
            this.crystalReportViewerStockHistory.TabIndex = 0;
            // 
            // StockReportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.crystalReportViewerStockHistory);
            this.Name = "StockReportForm";
            this.Text = "StockReportForm";
            this.Load += new System.EventHandler(this.StockReportForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewerStockHistory;
    }
}