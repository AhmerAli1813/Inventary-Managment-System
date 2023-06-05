
namespace ivs.system
{
    partial class PurchuaseInvoice
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.PurInv_dataGridView = new System.Windows.Forms.DataGridView();
            this.ProIdGv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CompNameGv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductGv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PrizePUGv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.QtyGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalAmtGv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DeleteGv = new System.Windows.Forms.DataGridViewButtonColumn();
            this.PInvAmontPanel = new System.Windows.Forms.Panel();
            this.GrandTableLayout = new System.Windows.Forms.TableLayoutPanel();
            this.GrossAmtPrzTxt = new System.Windows.Forms.Label();
            this.GrossAmtTxtLabl = new System.Windows.Forms.Label();
            this.CompanyDD = new System.Windows.Forms.ComboBox();
            this.CompanyErrorLbl = new System.Windows.Forms.Label();
            this.StatusLbl = new System.Windows.Forms.Label();
            this.PPrizeTxt = new System.Windows.Forms.TextBox();
            this.PPLbl = new System.Windows.Forms.Label();
            this.BarcodeTxt = new System.Windows.Forms.TextBox();
            this.barcode = new System.Windows.Forms.Label();
            this.ProductTxt = new System.Windows.Forms.TextBox();
            this.PNameLbl = new System.Windows.Forms.Label();
            this.QtyErrorLbl = new System.Windows.Forms.Label();
            this.QtyTxt = new System.Windows.Forms.TextBox();
            this.QtyLbl = new System.Windows.Forms.Label();
            this.BarErrorLbl = new System.Windows.Forms.Label();
            this.AddCartBtn = new System.Windows.Forms.Button();
            this.TtAmtLbl = new System.Windows.Forms.Label();
            this.TtaAmtLbl = new System.Windows.Forms.Label();
            this.imsDbDataSet1 = new ivs.system.imsDbDataSet();
            this.LeftPanel.SuspendLayout();
            this.rightPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BackBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PurInv_dataGridView)).BeginInit();
            this.PInvAmontPanel.SuspendLayout();
            this.GrandTableLayout.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imsDbDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // LeftPanel
            // 
            this.LeftPanel.Controls.Add(this.TtaAmtLbl);
            this.LeftPanel.Controls.Add(this.TtAmtLbl);
            this.LeftPanel.Controls.Add(this.AddCartBtn);
            this.LeftPanel.Controls.Add(this.QtyErrorLbl);
            this.LeftPanel.Controls.Add(this.QtyTxt);
            this.LeftPanel.Controls.Add(this.QtyLbl);
            this.LeftPanel.Controls.Add(this.ProductTxt);
            this.LeftPanel.Controls.Add(this.PNameLbl);
            this.LeftPanel.Controls.Add(this.BarErrorLbl);
            this.LeftPanel.Controls.Add(this.BarcodeTxt);
            this.LeftPanel.Controls.Add(this.barcode);
            this.LeftPanel.Controls.Add(this.CompanyDD);
            this.LeftPanel.Controls.Add(this.CompanyErrorLbl);
            this.LeftPanel.Controls.Add(this.StatusLbl);
            this.LeftPanel.Controls.Add(this.PPrizeTxt);
            this.LeftPanel.Controls.Add(this.PPLbl);
            this.LeftPanel.Size = new System.Drawing.Size(200, 477);
            this.LeftPanel.Controls.SetChildIndex(this.PPLbl, 0);
            this.LeftPanel.Controls.SetChildIndex(this.PPrizeTxt, 0);
            this.LeftPanel.Controls.SetChildIndex(this.StatusLbl, 0);
            this.LeftPanel.Controls.SetChildIndex(this.CompanyErrorLbl, 0);
            this.LeftPanel.Controls.SetChildIndex(this.CompanyDD, 0);
            this.LeftPanel.Controls.SetChildIndex(this.barcode, 0);
            this.LeftPanel.Controls.SetChildIndex(this.BarcodeTxt, 0);
            this.LeftPanel.Controls.SetChildIndex(this.BarErrorLbl, 0);
            this.LeftPanel.Controls.SetChildIndex(this.PNameLbl, 0);
            this.LeftPanel.Controls.SetChildIndex(this.ProductTxt, 0);
            this.LeftPanel.Controls.SetChildIndex(this.QtyLbl, 0);
            this.LeftPanel.Controls.SetChildIndex(this.QtyTxt, 0);
            this.LeftPanel.Controls.SetChildIndex(this.QtyErrorLbl, 0);
            this.LeftPanel.Controls.SetChildIndex(this.AddCartBtn, 0);
            this.LeftPanel.Controls.SetChildIndex(this.TtAmtLbl, 0);
            this.LeftPanel.Controls.SetChildIndex(this.TtaAmtLbl, 0);
            // 
            // rightPanel
            // 
            this.rightPanel.Controls.Add(this.PInvAmontPanel);
            this.rightPanel.Controls.Add(this.PurInv_dataGridView);
            this.rightPanel.Size = new System.Drawing.Size(671, 477);
            this.rightPanel.Controls.SetChildIndex(this.PurInv_dataGridView, 0);
            this.rightPanel.Controls.SetChildIndex(this.PInvAmontPanel, 0);
            // 
            // PurInv_dataGridView
            // 
            this.PurInv_dataGridView.AllowUserToAddRows = false;
            this.PurInv_dataGridView.AllowUserToDeleteRows = false;
            this.PurInv_dataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.PurInv_dataGridView.BackgroundColor = System.Drawing.Color.White;
            this.PurInv_dataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.PurInv_dataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.PurInv_dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.PurInv_dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ProIdGv,
            this.CompNameGv,
            this.ProductGv,
            this.PrizePUGv,
            this.QtyGV,
            this.TotalAmtGv,
            this.DeleteGv});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.GrayText;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.PurInv_dataGridView.DefaultCellStyle = dataGridViewCellStyle3;
            this.PurInv_dataGridView.Dock = System.Windows.Forms.DockStyle.Top;
            this.PurInv_dataGridView.Location = new System.Drawing.Point(0, 106);
            this.PurInv_dataGridView.Name = "PurInv_dataGridView";
            this.PurInv_dataGridView.ReadOnly = true;
            this.PurInv_dataGridView.RowHeadersVisible = false;
            this.PurInv_dataGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.PurInv_dataGridView.Size = new System.Drawing.Size(671, 296);
            this.PurInv_dataGridView.TabIndex = 6;
            this.PurInv_dataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.PurInv_dataGridView_CellClick);
            // 
            // ProIdGv
            // 
            this.ProIdGv.HeaderText = "ID";
            this.ProIdGv.Name = "ProIdGv";
            this.ProIdGv.ReadOnly = true;
            this.ProIdGv.Visible = false;
            // 
            // CompNameGv
            // 
            this.CompNameGv.HeaderText = "Company";
            this.CompNameGv.Name = "CompNameGv";
            this.CompNameGv.ReadOnly = true;
            // 
            // ProductGv
            // 
            this.ProductGv.HeaderText = "Products";
            this.ProductGv.Name = "ProductGv";
            this.ProductGv.ReadOnly = true;
            // 
            // PrizePUGv
            // 
            this.PrizePUGv.HeaderText = "Prize Per Unit";
            this.PrizePUGv.Name = "PrizePUGv";
            this.PrizePUGv.ReadOnly = true;
            // 
            // QtyGV
            // 
            this.QtyGV.HeaderText = "Qautity";
            this.QtyGV.Name = "QtyGV";
            this.QtyGV.ReadOnly = true;
            // 
            // TotalAmtGv
            // 
            this.TotalAmtGv.HeaderText = "Total Amount";
            this.TotalAmtGv.Name = "TotalAmtGv";
            this.TotalAmtGv.ReadOnly = true;
            // 
            // DeleteGv
            // 
            this.DeleteGv.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Gray;
            this.DeleteGv.DefaultCellStyle = dataGridViewCellStyle2;
            this.DeleteGv.FillWeight = 110F;
            this.DeleteGv.HeaderText = "Action";
            this.DeleteGv.Name = "DeleteGv";
            this.DeleteGv.ReadOnly = true;
            this.DeleteGv.Text = "Delete";
            this.DeleteGv.UseColumnTextForButtonValue = true;
            // 
            // PInvAmontPanel
            // 
            this.PInvAmontPanel.Controls.Add(this.GrandTableLayout);
            this.PInvAmontPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PInvAmontPanel.Location = new System.Drawing.Point(0, 402);
            this.PInvAmontPanel.Name = "PInvAmontPanel";
            this.PInvAmontPanel.Size = new System.Drawing.Size(671, 75);
            this.PInvAmontPanel.TabIndex = 7;
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
            this.GrandTableLayout.Size = new System.Drawing.Size(671, 75);
            this.GrandTableLayout.TabIndex = 8;
            // 
            // GrossAmtPrzTxt
            // 
            this.GrossAmtPrzTxt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GrossAmtPrzTxt.Font = new System.Drawing.Font("Segoe UI", 18F);
            this.GrossAmtPrzTxt.Location = new System.Drawing.Point(338, 0);
            this.GrossAmtPrzTxt.Name = "GrossAmtPrzTxt";
            this.GrossAmtPrzTxt.Size = new System.Drawing.Size(330, 75);
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
            this.GrossAmtTxtLabl.Size = new System.Drawing.Size(329, 75);
            this.GrossAmtTxtLabl.TabIndex = 1;
            this.GrossAmtTxtLabl.Text = "Total Amount";
            this.GrossAmtTxtLabl.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // CompanyDD
            // 
            this.CompanyDD.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.CompanyDD.FormattingEnabled = true;
            this.CompanyDD.Items.AddRange(new object[] {
            "Active",
            "In-Active"});
            this.CompanyDD.Location = new System.Drawing.Point(6, 125);
            this.CompanyDD.Name = "CompanyDD";
            this.CompanyDD.Size = new System.Drawing.Size(184, 21);
            this.CompanyDD.TabIndex = 33;
            this.CompanyDD.SelectedIndexChanged += new System.EventHandler(this.CompanyDD_SelectedIndexChanged);
            // 
            // CompanyErrorLbl
            // 
            this.CompanyErrorLbl.AutoSize = true;
            this.CompanyErrorLbl.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.CompanyErrorLbl.ForeColor = System.Drawing.Color.Crimson;
            this.CompanyErrorLbl.Location = new System.Drawing.Point(85, 109);
            this.CompanyErrorLbl.Name = "CompanyErrorLbl";
            this.CompanyErrorLbl.Size = new System.Drawing.Size(12, 13);
            this.CompanyErrorLbl.TabIndex = 37;
            this.CompanyErrorLbl.Text = "*";
            this.CompanyErrorLbl.Visible = false;
            // 
            // StatusLbl
            // 
            this.StatusLbl.AutoSize = true;
            this.StatusLbl.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.StatusLbl.Location = new System.Drawing.Point(3, 109);
            this.StatusLbl.Name = "StatusLbl";
            this.StatusLbl.Size = new System.Drawing.Size(55, 13);
            this.StatusLbl.TabIndex = 38;
            this.StatusLbl.Text = "Company";
            // 
            // PPrizeTxt
            // 
            this.PPrizeTxt.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.PPrizeTxt.Enabled = false;
            this.PPrizeTxt.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.PPrizeTxt.Location = new System.Drawing.Point(6, 247);
            this.PPrizeTxt.MaxLength = 40;
            this.PPrizeTxt.Name = "PPrizeTxt";
            this.PPrizeTxt.Size = new System.Drawing.Size(184, 22);
            this.PPrizeTxt.TabIndex = 35;
            // 
            // PPLbl
            // 
            this.PPLbl.AutoSize = true;
            this.PPLbl.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.PPLbl.Location = new System.Drawing.Point(3, 231);
            this.PPLbl.Name = "PPLbl";
            this.PPLbl.Size = new System.Drawing.Size(31, 13);
            this.PPLbl.TabIndex = 36;
            this.PPLbl.Text = "Prize";
            // 
            // BarcodeTxt
            // 
            this.BarcodeTxt.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.BarcodeTxt.Location = new System.Drawing.Point(6, 165);
            this.BarcodeTxt.MaxLength = 40;
            this.BarcodeTxt.Name = "BarcodeTxt";
            this.BarcodeTxt.Size = new System.Drawing.Size(184, 22);
            this.BarcodeTxt.TabIndex = 40;
            this.BarcodeTxt.TextChanged += new System.EventHandler(this.BarcodeTxt_TextChanged);
            // 
            // barcode
            // 
            this.barcode.AutoSize = true;
            this.barcode.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.barcode.Location = new System.Drawing.Point(3, 149);
            this.barcode.Name = "barcode";
            this.barcode.Size = new System.Drawing.Size(48, 13);
            this.barcode.TabIndex = 41;
            this.barcode.Text = "Barcode";
            // 
            // ProductTxt
            // 
            this.ProductTxt.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.ProductTxt.Enabled = false;
            this.ProductTxt.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.ProductTxt.Location = new System.Drawing.Point(6, 206);
            this.ProductTxt.MaxLength = 40;
            this.ProductTxt.Name = "ProductTxt";
            this.ProductTxt.Size = new System.Drawing.Size(184, 22);
            this.ProductTxt.TabIndex = 43;
            // 
            // PNameLbl
            // 
            this.PNameLbl.AutoSize = true;
            this.PNameLbl.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.PNameLbl.Location = new System.Drawing.Point(3, 190);
            this.PNameLbl.Name = "PNameLbl";
            this.PNameLbl.Size = new System.Drawing.Size(47, 13);
            this.PNameLbl.TabIndex = 44;
            this.PNameLbl.Text = "Product";
            // 
            // QtyErrorLbl
            // 
            this.QtyErrorLbl.AutoSize = true;
            this.QtyErrorLbl.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.QtyErrorLbl.ForeColor = System.Drawing.Color.Crimson;
            this.QtyErrorLbl.Location = new System.Drawing.Point(115, 268);
            this.QtyErrorLbl.Name = "QtyErrorLbl";
            this.QtyErrorLbl.Size = new System.Drawing.Size(12, 13);
            this.QtyErrorLbl.TabIndex = 45;
            this.QtyErrorLbl.Text = "*";
            this.QtyErrorLbl.Visible = false;
            // 
            // QtyTxt
            // 
            this.QtyTxt.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.QtyTxt.Location = new System.Drawing.Point(6, 284);
            this.QtyTxt.MaxLength = 40;
            this.QtyTxt.Name = "QtyTxt";
            this.QtyTxt.Size = new System.Drawing.Size(184, 22);
            this.QtyTxt.TabIndex = 46;
            this.QtyTxt.TextChanged += new System.EventHandler(this.QtyTxt_TextChanged);
            // 
            // QtyLbl
            // 
            this.QtyLbl.AutoSize = true;
            this.QtyLbl.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.QtyLbl.Location = new System.Drawing.Point(3, 268);
            this.QtyLbl.Name = "QtyLbl";
            this.QtyLbl.Size = new System.Drawing.Size(44, 13);
            this.QtyLbl.TabIndex = 47;
            this.QtyLbl.Text = "Qautity";
            // 
            // BarErrorLbl
            // 
            this.BarErrorLbl.AutoSize = true;
            this.BarErrorLbl.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.BarErrorLbl.ForeColor = System.Drawing.Color.Crimson;
            this.BarErrorLbl.Location = new System.Drawing.Point(115, 149);
            this.BarErrorLbl.Name = "BarErrorLbl";
            this.BarErrorLbl.Size = new System.Drawing.Size(12, 13);
            this.BarErrorLbl.TabIndex = 39;
            this.BarErrorLbl.Text = "*";
            this.BarErrorLbl.Visible = false;
            // 
            // AddCartBtn
            // 
            this.AddCartBtn.FlatAppearance.BorderSize = 2;
            this.AddCartBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddCartBtn.Location = new System.Drawing.Point(6, 316);
            this.AddCartBtn.Name = "AddCartBtn";
            this.AddCartBtn.Size = new System.Drawing.Size(184, 33);
            this.AddCartBtn.TabIndex = 8;
            this.AddCartBtn.Text = "Add Cards";
            this.AddCartBtn.UseVisualStyleBackColor = true;
            this.AddCartBtn.Click += new System.EventHandler(this.AddCartBtn_Click);
            // 
            // TtAmtLbl
            // 
            this.TtAmtLbl.AutoSize = true;
            this.TtAmtLbl.Font = new System.Drawing.Font("Segoe UI", 13.25F);
            this.TtAmtLbl.Location = new System.Drawing.Point(12, 377);
            this.TtAmtLbl.Name = "TtAmtLbl";
            this.TtAmtLbl.Size = new System.Drawing.Size(119, 25);
            this.TtAmtLbl.TabIndex = 0;
            this.TtAmtLbl.Text = "Total Amount";
            // 
            // TtaAmtLbl
            // 
            this.TtaAmtLbl.AutoSize = true;
            this.TtaAmtLbl.Font = new System.Drawing.Font("Segoe UI", 14.25F);
            this.TtaAmtLbl.Location = new System.Drawing.Point(42, 402);
            this.TtaAmtLbl.Name = "TtaAmtLbl";
            this.TtaAmtLbl.Size = new System.Drawing.Size(46, 25);
            this.TtaAmtLbl.TabIndex = 48;
            this.TtaAmtLbl.Text = "00.0";
            // 
            // imsDbDataSet1
            // 
            this.imsDbDataSet1.DataSetName = "imsDbDataSet";
            this.imsDbDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // PurchuaseInvoice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(871, 477);
            this.Name = "PurchuaseInvoice";
            this.Text = "PurchuaseInvoice";
            this.Load += new System.EventHandler(this.PurchuaseInvoice_Load);
            this.LeftPanel.ResumeLayout(false);
            this.LeftPanel.PerformLayout();
            this.rightPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.BackBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PurInv_dataGridView)).EndInit();
            this.PInvAmontPanel.ResumeLayout(false);
            this.GrandTableLayout.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.imsDbDataSet1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PInvAmontPanel;
        private System.Windows.Forms.DataGridView PurInv_dataGridView;
        private System.Windows.Forms.ComboBox CompanyDD;
        private System.Windows.Forms.Label CompanyErrorLbl;
        private System.Windows.Forms.Label StatusLbl;
        private System.Windows.Forms.TextBox PPrizeTxt;
        private System.Windows.Forms.Label PPLbl;
        private System.Windows.Forms.TextBox ProductTxt;
        private System.Windows.Forms.Label PNameLbl;
        private System.Windows.Forms.TextBox BarcodeTxt;
        private System.Windows.Forms.Label barcode;
        private System.Windows.Forms.Label QtyErrorLbl;
        private System.Windows.Forms.TextBox QtyTxt;
        private System.Windows.Forms.Label QtyLbl;
        private System.Windows.Forms.Label BarErrorLbl;
        private System.Windows.Forms.Button AddCartBtn;
        private System.Windows.Forms.TableLayoutPanel GrandTableLayout;
        private System.Windows.Forms.Label TtaAmtLbl;
        private System.Windows.Forms.Label TtAmtLbl;
        private System.Windows.Forms.Label GrossAmtPrzTxt;
        private System.Windows.Forms.Label GrossAmtTxtLabl;
        private imsDbDataSet imsDbDataSet1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProIdGv;
        private System.Windows.Forms.DataGridViewTextBoxColumn CompNameGv;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductGv;
        private System.Windows.Forms.DataGridViewTextBoxColumn PrizePUGv;
        private System.Windows.Forms.DataGridViewTextBoxColumn QtyGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalAmtGv;
        private System.Windows.Forms.DataGridViewButtonColumn DeleteGv;
    }
}