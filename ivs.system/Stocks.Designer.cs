
namespace ivs.system
{
    partial class Stocks
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.Stocks_dataGridView = new System.Windows.Forms.DataGridView();
            this.PInvAmontPanel = new System.Windows.Forms.Panel();
            this.GrandTableLayout = new System.Windows.Forms.TableLayoutPanel();
            this.GrossAmtPrzTxt = new System.Windows.Forms.Label();
            this.GrossAmtTxtLabl = new System.Windows.Forms.Label();
            this.stkdGv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProIdGv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BarcodeGv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductGv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CatgoeryGv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PrizePrUntGv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.QtyGv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalAmtGv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ExDateGv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StatusGv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rightPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BackBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Stocks_dataGridView)).BeginInit();
            this.PInvAmontPanel.SuspendLayout();
            this.GrandTableLayout.SuspendLayout();
            this.SuspendLayout();
            // 
            // LeftPanel
            // 
            this.LeftPanel.Size = new System.Drawing.Size(200, 450);
            // 
            // rightPanel
            // 
            this.rightPanel.Controls.Add(this.PInvAmontPanel);
            this.rightPanel.Controls.Add(this.Stocks_dataGridView);
            this.rightPanel.Size = new System.Drawing.Size(600, 450);
            this.rightPanel.Controls.SetChildIndex(this.Stocks_dataGridView, 0);
            this.rightPanel.Controls.SetChildIndex(this.PInvAmontPanel, 0);
            // 
            // Stocks_dataGridView
            // 
            this.Stocks_dataGridView.AllowUserToAddRows = false;
            this.Stocks_dataGridView.AllowUserToDeleteRows = false;
            this.Stocks_dataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Stocks_dataGridView.BackgroundColor = System.Drawing.Color.White;
            this.Stocks_dataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Stocks_dataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.Stocks_dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Stocks_dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.stkdGv,
            this.ProIdGv,
            this.BarcodeGv,
            this.ProductGv,
            this.CatgoeryGv,
            this.PrizePrUntGv,
            this.QtyGv,
            this.TotalAmtGv,
            this.ExDateGv,
            this.StatusGv});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.GrayText;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Stocks_dataGridView.DefaultCellStyle = dataGridViewCellStyle2;
            this.Stocks_dataGridView.Dock = System.Windows.Forms.DockStyle.Top;
            this.Stocks_dataGridView.Location = new System.Drawing.Point(0, 106);
            this.Stocks_dataGridView.Name = "Stocks_dataGridView";
            this.Stocks_dataGridView.ReadOnly = true;
            this.Stocks_dataGridView.RowHeadersVisible = false;
            this.Stocks_dataGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.Stocks_dataGridView.Size = new System.Drawing.Size(600, 243);
            this.Stocks_dataGridView.TabIndex = 8;
            // 
            // PInvAmontPanel
            // 
            this.PInvAmontPanel.Controls.Add(this.GrandTableLayout);
            this.PInvAmontPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PInvAmontPanel.Location = new System.Drawing.Point(0, 349);
            this.PInvAmontPanel.Name = "PInvAmontPanel";
            this.PInvAmontPanel.Size = new System.Drawing.Size(600, 101);
            this.PInvAmontPanel.TabIndex = 9;
            // 
            // GrandTableLayout
            // 
            this.GrandTableLayout.BackColor = System.Drawing.Color.Gray;
            this.GrandTableLayout.ColumnCount = 2;
            this.GrandTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.GrandTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.GrandTableLayout.Controls.Add(this.GrossAmtPrzTxt, 1, 0);
            this.GrandTableLayout.Controls.Add(this.GrossAmtTxtLabl, 0, 0);
            this.GrandTableLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GrandTableLayout.ForeColor = System.Drawing.Color.White;
            this.GrandTableLayout.Location = new System.Drawing.Point(0, 0);
            this.GrandTableLayout.Name = "GrandTableLayout";
            this.GrandTableLayout.RowCount = 1;
            this.GrandTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.GrandTableLayout.Size = new System.Drawing.Size(600, 101);
            this.GrandTableLayout.TabIndex = 8;
            // 
            // GrossAmtPrzTxt
            // 
            this.GrossAmtPrzTxt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GrossAmtPrzTxt.Font = new System.Drawing.Font("Segoe UI", 18F);
            this.GrossAmtPrzTxt.Location = new System.Drawing.Point(303, 0);
            this.GrossAmtPrzTxt.Name = "GrossAmtPrzTxt";
            this.GrossAmtPrzTxt.Size = new System.Drawing.Size(294, 101);
            this.GrossAmtPrzTxt.TabIndex = 2;
            this.GrossAmtPrzTxt.Text = "0.00";
            this.GrossAmtPrzTxt.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // GrossAmtTxtLabl
            // 
            this.GrossAmtTxtLabl.BackColor = System.Drawing.Color.DimGray;
            this.GrossAmtTxtLabl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GrossAmtTxtLabl.Font = new System.Drawing.Font("Segoe UI", 18F);
            this.GrossAmtTxtLabl.Location = new System.Drawing.Point(3, 0);
            this.GrossAmtTxtLabl.Name = "GrossAmtTxtLabl";
            this.GrossAmtTxtLabl.Size = new System.Drawing.Size(294, 101);
            this.GrossAmtTxtLabl.TabIndex = 1;
            this.GrossAmtTxtLabl.Text = "Total Amount";
            this.GrossAmtTxtLabl.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // stkdGv
            // 
            this.stkdGv.HeaderText = "Id";
            this.stkdGv.Name = "stkdGv";
            this.stkdGv.ReadOnly = true;
            this.stkdGv.Visible = false;
            // 
            // ProIdGv
            // 
            this.ProIdGv.HeaderText = "ProId";
            this.ProIdGv.Name = "ProIdGv";
            this.ProIdGv.ReadOnly = true;
            this.ProIdGv.Visible = false;
            // 
            // BarcodeGv
            // 
            this.BarcodeGv.HeaderText = "Barcode";
            this.BarcodeGv.Name = "BarcodeGv";
            this.BarcodeGv.ReadOnly = true;
            // 
            // ProductGv
            // 
            this.ProductGv.HeaderText = "Product";
            this.ProductGv.Name = "ProductGv";
            this.ProductGv.ReadOnly = true;
            // 
            // CatgoeryGv
            // 
            this.CatgoeryGv.HeaderText = "Catgoery";
            this.CatgoeryGv.Name = "CatgoeryGv";
            this.CatgoeryGv.ReadOnly = true;
            // 
            // PrizePrUntGv
            // 
            this.PrizePrUntGv.HeaderText = "Prize";
            this.PrizePrUntGv.Name = "PrizePrUntGv";
            this.PrizePrUntGv.ReadOnly = true;
            // 
            // QtyGv
            // 
            this.QtyGv.HeaderText = "Qty";
            this.QtyGv.Name = "QtyGv";
            this.QtyGv.ReadOnly = true;
            // 
            // TotalAmtGv
            // 
            this.TotalAmtGv.HeaderText = "Total Amount";
            this.TotalAmtGv.Name = "TotalAmtGv";
            this.TotalAmtGv.ReadOnly = true;
            // 
            // ExDateGv
            // 
            this.ExDateGv.HeaderText = "Expiry Date";
            this.ExDateGv.Name = "ExDateGv";
            this.ExDateGv.ReadOnly = true;
            // 
            // StatusGv
            // 
            this.StatusGv.HeaderText = "Status";
            this.StatusGv.Name = "StatusGv";
            this.StatusGv.ReadOnly = true;
            this.StatusGv.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.StatusGv.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Stocks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Name = "Stocks";
            this.Text = "Stocks";
            this.Load += new System.EventHandler(this.Stocks_Load);
            this.rightPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.BackBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Stocks_dataGridView)).EndInit();
            this.PInvAmontPanel.ResumeLayout(false);
            this.GrandTableLayout.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView Stocks_dataGridView;
        private System.Windows.Forms.Panel PInvAmontPanel;
        private System.Windows.Forms.TableLayoutPanel GrandTableLayout;
        private System.Windows.Forms.Label GrossAmtPrzTxt;
        private System.Windows.Forms.Label GrossAmtTxtLabl;
        private System.Windows.Forms.DataGridViewTextBoxColumn stkdGv;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProIdGv;
        private System.Windows.Forms.DataGridViewTextBoxColumn BarcodeGv;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductGv;
        private System.Windows.Forms.DataGridViewTextBoxColumn CatgoeryGv;
        private System.Windows.Forms.DataGridViewTextBoxColumn PrizePrUntGv;
        private System.Windows.Forms.DataGridViewTextBoxColumn QtyGv;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalAmtGv;
        private System.Windows.Forms.DataGridViewTextBoxColumn ExDateGv;
        private System.Windows.Forms.DataGridViewTextBoxColumn StatusGv;
    }
}