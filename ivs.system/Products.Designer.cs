
namespace ivs.system
{
    partial class Products
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
            this.StatusDD = new System.Windows.Forms.ComboBox();
            this.StatusErrorLbl = new System.Windows.Forms.Label();
            this.StatusLbl = new System.Windows.Forms.Label();
            this.ExDatePickerErrorLbl = new System.Windows.Forms.Label();
            this.ExDatePickerLbl = new System.Windows.Forms.Label();
            this.CatIdDD = new System.Windows.Forms.ComboBox();
            this.CatIdDDErrorLbl = new System.Windows.Forms.Label();
            this.CatIdDDLbl = new System.Windows.Forms.Label();
            this.PNameErrorLbl = new System.Windows.Forms.Label();
            this.PNameTxt = new System.Windows.Forms.TextBox();
            this.PNameLbl = new System.Windows.Forms.Label();
            this.BrErrorLbl = new System.Windows.Forms.Label();
            this.BrTxt = new System.Windows.Forms.TextBox();
            this.BrLbl = new System.Windows.Forms.Label();
            this.PPrizeErrorLbl = new System.Windows.Forms.Label();
            this.PPrizeTxt = new System.Windows.Forms.TextBox();
            this.PPrizeLbl = new System.Windows.Forms.Label();
            this.ExDatePickerTxt = new System.Windows.Forms.DateTimePicker();
            this.Product_dataGridView = new System.Windows.Forms.DataGridView();
            this.IdGv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BarchorGv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NameGv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CatIDGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CatNameGv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PrizeGv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ExDateGv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StsGv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LeftPanel.SuspendLayout();
            this.rightPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Product_dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // LeftPanel
            // 
            this.LeftPanel.Controls.Add(this.ExDatePickerTxt);
            this.LeftPanel.Controls.Add(this.PPrizeErrorLbl);
            this.LeftPanel.Controls.Add(this.PPrizeTxt);
            this.LeftPanel.Controls.Add(this.PPrizeLbl);
            this.LeftPanel.Controls.Add(this.BrErrorLbl);
            this.LeftPanel.Controls.Add(this.BrTxt);
            this.LeftPanel.Controls.Add(this.BrLbl);
            this.LeftPanel.Controls.Add(this.CatIdDD);
            this.LeftPanel.Controls.Add(this.CatIdDDErrorLbl);
            this.LeftPanel.Controls.Add(this.CatIdDDLbl);
            this.LeftPanel.Controls.Add(this.PNameErrorLbl);
            this.LeftPanel.Controls.Add(this.PNameTxt);
            this.LeftPanel.Controls.Add(this.PNameLbl);
            this.LeftPanel.Controls.Add(this.StatusDD);
            this.LeftPanel.Controls.Add(this.StatusErrorLbl);
            this.LeftPanel.Controls.Add(this.StatusLbl);
            this.LeftPanel.Controls.Add(this.ExDatePickerErrorLbl);
            this.LeftPanel.Controls.Add(this.ExDatePickerLbl);
            this.LeftPanel.Size = new System.Drawing.Size(200, 748);
            this.LeftPanel.Controls.SetChildIndex(this.ExDatePickerLbl, 0);
            this.LeftPanel.Controls.SetChildIndex(this.ExDatePickerErrorLbl, 0);
            this.LeftPanel.Controls.SetChildIndex(this.StatusLbl, 0);
            this.LeftPanel.Controls.SetChildIndex(this.StatusErrorLbl, 0);
            this.LeftPanel.Controls.SetChildIndex(this.StatusDD, 0);
            this.LeftPanel.Controls.SetChildIndex(this.PNameLbl, 0);
            this.LeftPanel.Controls.SetChildIndex(this.PNameTxt, 0);
            this.LeftPanel.Controls.SetChildIndex(this.PNameErrorLbl, 0);
            this.LeftPanel.Controls.SetChildIndex(this.CatIdDDLbl, 0);
            this.LeftPanel.Controls.SetChildIndex(this.CatIdDDErrorLbl, 0);
            this.LeftPanel.Controls.SetChildIndex(this.CatIdDD, 0);
            this.LeftPanel.Controls.SetChildIndex(this.BrLbl, 0);
            this.LeftPanel.Controls.SetChildIndex(this.BrTxt, 0);
            this.LeftPanel.Controls.SetChildIndex(this.BrErrorLbl, 0);
            this.LeftPanel.Controls.SetChildIndex(this.PPrizeLbl, 0);
            this.LeftPanel.Controls.SetChildIndex(this.PPrizeTxt, 0);
            this.LeftPanel.Controls.SetChildIndex(this.PPrizeErrorLbl, 0);
            this.LeftPanel.Controls.SetChildIndex(this.ExDatePickerTxt, 0);
            // 
            // rightPanel
            // 
            this.rightPanel.Controls.Add(this.Product_dataGridView);
            this.rightPanel.Size = new System.Drawing.Size(1011, 748);
            this.rightPanel.Controls.SetChildIndex(this.Product_dataGridView, 0);
            // 
            // StatusDD
            // 
            this.StatusDD.FormattingEnabled = true;
            this.StatusDD.Items.AddRange(new object[] {
            "Active",
            "In-Active"});
            this.StatusDD.Location = new System.Drawing.Point(6, 403);
            this.StatusDD.Name = "StatusDD";
            this.StatusDD.Size = new System.Drawing.Size(194, 28);
            this.StatusDD.TabIndex = 33;
            // 
            // StatusErrorLbl
            // 
            this.StatusErrorLbl.AutoSize = true;
            this.StatusErrorLbl.ForeColor = System.Drawing.Color.Crimson;
            this.StatusErrorLbl.Location = new System.Drawing.Point(180, 380);
            this.StatusErrorLbl.Name = "StatusErrorLbl";
            this.StatusErrorLbl.Size = new System.Drawing.Size(15, 20);
            this.StatusErrorLbl.TabIndex = 37;
            this.StatusErrorLbl.Text = "*";
            this.StatusErrorLbl.Visible = false;
            // 
            // StatusLbl
            // 
            this.StatusLbl.AutoSize = true;
            this.StatusLbl.Location = new System.Drawing.Point(6, 380);
            this.StatusLbl.Name = "StatusLbl";
            this.StatusLbl.Size = new System.Drawing.Size(49, 20);
            this.StatusLbl.TabIndex = 38;
            this.StatusLbl.Text = "Status";
            // 
            // ExDatePickerErrorLbl
            // 
            this.ExDatePickerErrorLbl.AutoSize = true;
            this.ExDatePickerErrorLbl.ForeColor = System.Drawing.Color.Crimson;
            this.ExDatePickerErrorLbl.Location = new System.Drawing.Point(180, 274);
            this.ExDatePickerErrorLbl.Name = "ExDatePickerErrorLbl";
            this.ExDatePickerErrorLbl.Size = new System.Drawing.Size(15, 20);
            this.ExDatePickerErrorLbl.TabIndex = 34;
            this.ExDatePickerErrorLbl.Text = "*";
            this.ExDatePickerErrorLbl.Visible = false;
            // 
            // ExDatePickerLbl
            // 
            this.ExDatePickerLbl.AutoSize = true;
            this.ExDatePickerLbl.Location = new System.Drawing.Point(6, 274);
            this.ExDatePickerLbl.Name = "ExDatePickerLbl";
            this.ExDatePickerLbl.Size = new System.Drawing.Size(85, 20);
            this.ExDatePickerLbl.TabIndex = 36;
            this.ExDatePickerLbl.Text = "Expriy Date";
            // 
            // CatIdDD
            // 
            this.CatIdDD.FormattingEnabled = true;
            this.CatIdDD.Items.AddRange(new object[] {
            "Active",
            "In-Active"});
            this.CatIdDD.Location = new System.Drawing.Point(6, 243);
            this.CatIdDD.Name = "CatIdDD";
            this.CatIdDD.Size = new System.Drawing.Size(194, 28);
            this.CatIdDD.TabIndex = 39;
            // 
            // CatIdDDErrorLbl
            // 
            this.CatIdDDErrorLbl.AutoSize = true;
            this.CatIdDDErrorLbl.ForeColor = System.Drawing.Color.Crimson;
            this.CatIdDDErrorLbl.Location = new System.Drawing.Point(180, 220);
            this.CatIdDDErrorLbl.Name = "CatIdDDErrorLbl";
            this.CatIdDDErrorLbl.Size = new System.Drawing.Size(15, 20);
            this.CatIdDDErrorLbl.TabIndex = 43;
            this.CatIdDDErrorLbl.Text = "*";
            this.CatIdDDErrorLbl.Visible = false;
            // 
            // CatIdDDLbl
            // 
            this.CatIdDDLbl.AutoSize = true;
            this.CatIdDDLbl.Location = new System.Drawing.Point(6, 220);
            this.CatIdDDLbl.Name = "CatIdDDLbl";
            this.CatIdDDLbl.Size = new System.Drawing.Size(69, 20);
            this.CatIdDDLbl.TabIndex = 44;
            this.CatIdDDLbl.Text = "Catagory";
            // 
            // PNameErrorLbl
            // 
            this.PNameErrorLbl.AutoSize = true;
            this.PNameErrorLbl.ForeColor = System.Drawing.Color.Crimson;
            this.PNameErrorLbl.Location = new System.Drawing.Point(180, 167);
            this.PNameErrorLbl.Name = "PNameErrorLbl";
            this.PNameErrorLbl.Size = new System.Drawing.Size(15, 20);
            this.PNameErrorLbl.TabIndex = 40;
            this.PNameErrorLbl.Text = "*";
            this.PNameErrorLbl.Visible = false;
            // 
            // PNameTxt
            // 
            this.PNameTxt.Location = new System.Drawing.Point(6, 190);
            this.PNameTxt.MaxLength = 40;
            this.PNameTxt.Name = "PNameTxt";
            this.PNameTxt.Size = new System.Drawing.Size(194, 27);
            this.PNameTxt.TabIndex = 41;
            // 
            // PNameLbl
            // 
            this.PNameLbl.AutoSize = true;
            this.PNameLbl.Location = new System.Drawing.Point(6, 167);
            this.PNameLbl.Name = "PNameLbl";
            this.PNameLbl.Size = new System.Drawing.Size(104, 20);
            this.PNameLbl.TabIndex = 42;
            this.PNameLbl.Text = "Product Name";
            // 
            // BrErrorLbl
            // 
            this.BrErrorLbl.AutoSize = true;
            this.BrErrorLbl.ForeColor = System.Drawing.Color.Crimson;
            this.BrErrorLbl.Location = new System.Drawing.Point(180, 114);
            this.BrErrorLbl.Name = "BrErrorLbl";
            this.BrErrorLbl.Size = new System.Drawing.Size(15, 20);
            this.BrErrorLbl.TabIndex = 45;
            this.BrErrorLbl.Text = "*";
            this.BrErrorLbl.Visible = false;
            // 
            // BrTxt
            // 
            this.BrTxt.Location = new System.Drawing.Point(6, 137);
            this.BrTxt.MaxLength = 40;
            this.BrTxt.Name = "BrTxt";
            this.BrTxt.Size = new System.Drawing.Size(194, 27);
            this.BrTxt.TabIndex = 46;
            // 
            // BrLbl
            // 
            this.BrLbl.AutoSize = true;
            this.BrLbl.Location = new System.Drawing.Point(6, 114);
            this.BrLbl.Name = "BrLbl";
            this.BrLbl.Size = new System.Drawing.Size(60, 20);
            this.BrLbl.TabIndex = 47;
            this.BrLbl.Text = "Barchor";
            // 
            // PPrizeErrorLbl
            // 
            this.PPrizeErrorLbl.AutoSize = true;
            this.PPrizeErrorLbl.ForeColor = System.Drawing.Color.Crimson;
            this.PPrizeErrorLbl.Location = new System.Drawing.Point(180, 327);
            this.PPrizeErrorLbl.Name = "PPrizeErrorLbl";
            this.PPrizeErrorLbl.Size = new System.Drawing.Size(15, 20);
            this.PPrizeErrorLbl.TabIndex = 43;
            this.PPrizeErrorLbl.Text = "*";
            this.PPrizeErrorLbl.Visible = false;
            // 
            // PPrizeTxt
            // 
            this.PPrizeTxt.Location = new System.Drawing.Point(6, 350);
            this.PPrizeTxt.MaxLength = 40;
            this.PPrizeTxt.Name = "PPrizeTxt";
            this.PPrizeTxt.Size = new System.Drawing.Size(194, 27);
            this.PPrizeTxt.TabIndex = 44;
            // 
            // PPrizeLbl
            // 
            this.PPrizeLbl.AutoSize = true;
            this.PPrizeLbl.Location = new System.Drawing.Point(6, 327);
            this.PPrizeLbl.Name = "PPrizeLbl";
            this.PPrizeLbl.Size = new System.Drawing.Size(41, 20);
            this.PPrizeLbl.TabIndex = 45;
            this.PPrizeLbl.Text = "Prize";
            // 
            // ExDatePickerTxt
            // 
            this.ExDatePickerTxt.Location = new System.Drawing.Point(5, 297);
            this.ExDatePickerTxt.Name = "ExDatePickerTxt";
            this.ExDatePickerTxt.Size = new System.Drawing.Size(200, 27);
            this.ExDatePickerTxt.TabIndex = 3;
            // 
            // Product_dataGridView
            // 
            this.Product_dataGridView.AllowUserToAddRows = false;
            this.Product_dataGridView.AllowUserToDeleteRows = false;
            this.Product_dataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Product_dataGridView.BackgroundColor = System.Drawing.Color.White;
            this.Product_dataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Product_dataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.Product_dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Product_dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdGv,
            this.BarchorGv,
            this.NameGv,
            this.CatIDGV,
            this.CatNameGv,
            this.PrizeGv,
            this.ExDateGv,
            this.StsGv});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.GrayText;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Product_dataGridView.DefaultCellStyle = dataGridViewCellStyle2;
            this.Product_dataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Product_dataGridView.Location = new System.Drawing.Point(0, 106);
            this.Product_dataGridView.Name = "Product_dataGridView";
            this.Product_dataGridView.ReadOnly = true;
            this.Product_dataGridView.RowHeadersVisible = false;
            this.Product_dataGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.Product_dataGridView.Size = new System.Drawing.Size(1011, 642);
            this.Product_dataGridView.TabIndex = 6;
            this.Product_dataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Product_dataGridView_CellClick);
            // 
            // IdGv
            // 
            this.IdGv.HeaderText = "ID";
            this.IdGv.Name = "IdGv";
            this.IdGv.ReadOnly = true;
            this.IdGv.Visible = false;
            // 
            // BarchorGv
            // 
            this.BarchorGv.HeaderText = "Barchor";
            this.BarchorGv.Name = "BarchorGv";
            this.BarchorGv.ReadOnly = true;
            // 
            // NameGv
            // 
            this.NameGv.HeaderText = "Product Name";
            this.NameGv.Name = "NameGv";
            this.NameGv.ReadOnly = true;
            // 
            // CatIDGV
            // 
            this.CatIDGV.HeaderText = "CatID";
            this.CatIDGV.Name = "CatIDGV";
            this.CatIDGV.ReadOnly = true;
            this.CatIDGV.Visible = false;
            // 
            // CatNameGv
            // 
            this.CatNameGv.HeaderText = "Catagory";
            this.CatNameGv.Name = "CatNameGv";
            this.CatNameGv.ReadOnly = true;
            // 
            // PrizeGv
            // 
            this.PrizeGv.HeaderText = "Prize";
            this.PrizeGv.Name = "PrizeGv";
            this.PrizeGv.ReadOnly = true;
            // 
            // ExDateGv
            // 
            this.ExDateGv.HeaderText = "Expiry Date";
            this.ExDateGv.Name = "ExDateGv";
            this.ExDateGv.ReadOnly = true;
            // 
            // StsGv
            // 
            this.StsGv.HeaderText = "Status";
            this.StsGv.Name = "StsGv";
            this.StsGv.ReadOnly = true;
            // 
            // Products
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1211, 748);
            this.Name = "Products";
            this.Text = "Products";
            this.Load += new System.EventHandler(this.Products_Load);
            this.LeftPanel.ResumeLayout(false);
            this.LeftPanel.PerformLayout();
            this.rightPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Product_dataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox StatusDD;
        private System.Windows.Forms.Label StatusErrorLbl;
        private System.Windows.Forms.Label StatusLbl;
        private System.Windows.Forms.Label ExDatePickerErrorLbl;
        private System.Windows.Forms.Label ExDatePickerLbl;
        private System.Windows.Forms.Label PPrizeErrorLbl;
        private System.Windows.Forms.TextBox PPrizeTxt;
        private System.Windows.Forms.Label PPrizeLbl;
        private System.Windows.Forms.Label BrErrorLbl;
        private System.Windows.Forms.TextBox BrTxt;
        private System.Windows.Forms.Label BrLbl;
        private System.Windows.Forms.ComboBox CatIdDD;
        private System.Windows.Forms.Label CatIdDDErrorLbl;
        private System.Windows.Forms.Label CatIdDDLbl;
        private System.Windows.Forms.Label PNameErrorLbl;
        private System.Windows.Forms.TextBox PNameTxt;
        private System.Windows.Forms.Label PNameLbl;
        private System.Windows.Forms.DateTimePicker ExDatePickerTxt;
        private System.Windows.Forms.DataGridView Product_dataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdGv;
        private System.Windows.Forms.DataGridViewTextBoxColumn BarchorGv;
        private System.Windows.Forms.DataGridViewTextBoxColumn NameGv;
        private System.Windows.Forms.DataGridViewTextBoxColumn CatIDGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn CatNameGv;
        private System.Windows.Forms.DataGridViewTextBoxColumn PrizeGv;
        private System.Windows.Forms.DataGridViewTextBoxColumn ExDateGv;
        private System.Windows.Forms.DataGridViewTextBoxColumn StsGv;
    }
}