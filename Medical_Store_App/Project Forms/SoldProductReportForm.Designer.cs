
namespace Medical_Store_App.Project_Forms
{
    partial class SoldProductReportForm
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
            this.crystalReportViewerSoldProduct = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // crystalReportViewerSoldProduct
            // 
            this.crystalReportViewerSoldProduct.ActiveViewIndex = -1;
            this.crystalReportViewerSoldProduct.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crystalReportViewerSoldProduct.Cursor = System.Windows.Forms.Cursors.Default;
            this.crystalReportViewerSoldProduct.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crystalReportViewerSoldProduct.Location = new System.Drawing.Point(0, 0);
            this.crystalReportViewerSoldProduct.Name = "crystalReportViewerSoldProduct";
            this.crystalReportViewerSoldProduct.Size = new System.Drawing.Size(800, 450);
            this.crystalReportViewerSoldProduct.TabIndex = 0;
            // 
            // SoldProductReportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.crystalReportViewerSoldProduct);
            this.Name = "SoldProductReportForm";
            this.Text = "Sale Report";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewerSoldProduct;
    }
}