
namespace ivs.system
{
    partial class Suppliers
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            this.StatusDD = new System.Windows.Forms.ComboBox();
            this.StatusErrorLbl = new System.Windows.Forms.Label();
            this.StatusLbl = new System.Windows.Forms.Label();
            this.EmpErrorLbl = new System.Windows.Forms.Label();
            this.EmpNameTxt = new System.Windows.Forms.TextBox();
            this.EmpNameLbl = new System.Windows.Forms.Label();
            this.CompNameErrorLbl = new System.Windows.Forms.Label();
            this.CompNameTxt = new System.Windows.Forms.TextBox();
            this.CompNameLbl = new System.Windows.Forms.Label();
            this.AddressErrorLbl = new System.Windows.Forms.Label();
            this.AddressTxt = new System.Windows.Forms.TextBox();
            this.AddressLbl = new System.Windows.Forms.Label();
            this.NTNTxt = new System.Windows.Forms.TextBox();
            this.NtnLbl = new System.Windows.Forms.Label();
            this.Phn2Txt = new System.Windows.Forms.TextBox();
            this.Phn2Lbl = new System.Windows.Forms.Label();
            this.PhnErrorLbl = new System.Windows.Forms.Label();
            this.PhnTxt = new System.Windows.Forms.TextBox();
            this.PhnLbl = new System.Windows.Forms.Label();
            this.Suppliers_dataGridView = new System.Windows.Forms.DataGridView();
            this.IdGv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CompNameGv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EmployeeGv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AddressGv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NTNGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Phone1Gv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Phone2Gv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StsGv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LeftPanel.SuspendLayout();
            this.rightPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Suppliers_dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // LeftPanel
            // 
            this.LeftPanel.Controls.Add(this.Phn2Txt);
            this.LeftPanel.Controls.Add(this.Phn2Lbl);
            this.LeftPanel.Controls.Add(this.PhnErrorLbl);
            this.LeftPanel.Controls.Add(this.PhnTxt);
            this.LeftPanel.Controls.Add(this.PhnLbl);
            this.LeftPanel.Controls.Add(this.NTNTxt);
            this.LeftPanel.Controls.Add(this.NtnLbl);
            this.LeftPanel.Controls.Add(this.AddressErrorLbl);
            this.LeftPanel.Controls.Add(this.AddressTxt);
            this.LeftPanel.Controls.Add(this.AddressLbl);
            this.LeftPanel.Controls.Add(this.CompNameErrorLbl);
            this.LeftPanel.Controls.Add(this.CompNameTxt);
            this.LeftPanel.Controls.Add(this.CompNameLbl);
            this.LeftPanel.Controls.Add(this.StatusDD);
            this.LeftPanel.Controls.Add(this.StatusErrorLbl);
            this.LeftPanel.Controls.Add(this.StatusLbl);
            this.LeftPanel.Controls.Add(this.EmpErrorLbl);
            this.LeftPanel.Controls.Add(this.EmpNameTxt);
            this.LeftPanel.Controls.Add(this.EmpNameLbl);
            this.LeftPanel.Size = new System.Drawing.Size(200, 612);
            this.LeftPanel.Controls.SetChildIndex(this.EmpNameLbl, 0);
            this.LeftPanel.Controls.SetChildIndex(this.EmpNameTxt, 0);
            this.LeftPanel.Controls.SetChildIndex(this.EmpErrorLbl, 0);
            this.LeftPanel.Controls.SetChildIndex(this.StatusLbl, 0);
            this.LeftPanel.Controls.SetChildIndex(this.StatusErrorLbl, 0);
            this.LeftPanel.Controls.SetChildIndex(this.StatusDD, 0);
            this.LeftPanel.Controls.SetChildIndex(this.CompNameLbl, 0);
            this.LeftPanel.Controls.SetChildIndex(this.CompNameTxt, 0);
            this.LeftPanel.Controls.SetChildIndex(this.CompNameErrorLbl, 0);
            this.LeftPanel.Controls.SetChildIndex(this.AddressLbl, 0);
            this.LeftPanel.Controls.SetChildIndex(this.AddressTxt, 0);
            this.LeftPanel.Controls.SetChildIndex(this.AddressErrorLbl, 0);
            this.LeftPanel.Controls.SetChildIndex(this.NtnLbl, 0);
            this.LeftPanel.Controls.SetChildIndex(this.NTNTxt, 0);
            this.LeftPanel.Controls.SetChildIndex(this.PhnLbl, 0);
            this.LeftPanel.Controls.SetChildIndex(this.PhnTxt, 0);
            this.LeftPanel.Controls.SetChildIndex(this.PhnErrorLbl, 0);
            this.LeftPanel.Controls.SetChildIndex(this.Phn2Lbl, 0);
            this.LeftPanel.Controls.SetChildIndex(this.Phn2Txt, 0);
            // 
            // rightPanel
            // 
            this.rightPanel.Controls.Add(this.Suppliers_dataGridView);
            this.rightPanel.Size = new System.Drawing.Size(763, 612);
            this.rightPanel.Controls.SetChildIndex(this.Suppliers_dataGridView, 0);
            // 
            // StatusDD
            // 
            this.StatusDD.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.StatusDD.FormattingEnabled = true;
            this.StatusDD.Items.AddRange(new object[] {
            "Active",
            "In-Active"});
            this.StatusDD.Location = new System.Drawing.Point(0, 381);
            this.StatusDD.Name = "StatusDD";
            this.StatusDD.Size = new System.Drawing.Size(194, 21);
            this.StatusDD.TabIndex = 33;
            this.StatusDD.SelectedIndexChanged += new System.EventHandler(this.StatusDD_SelectedIndexChanged);
            // 
            // StatusErrorLbl
            // 
            this.StatusErrorLbl.AutoSize = true;
            this.StatusErrorLbl.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.StatusErrorLbl.ForeColor = System.Drawing.Color.Crimson;
            this.StatusErrorLbl.Location = new System.Drawing.Point(65, 365);
            this.StatusErrorLbl.Name = "StatusErrorLbl";
            this.StatusErrorLbl.Size = new System.Drawing.Size(12, 13);
            this.StatusErrorLbl.TabIndex = 37;
            this.StatusErrorLbl.Text = "*";
            this.StatusErrorLbl.Visible = false;
            // 
            // StatusLbl
            // 
            this.StatusLbl.AutoSize = true;
            this.StatusLbl.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.StatusLbl.Location = new System.Drawing.Point(0, 365);
            this.StatusLbl.Name = "StatusLbl";
            this.StatusLbl.Size = new System.Drawing.Size(39, 13);
            this.StatusLbl.TabIndex = 38;
            this.StatusLbl.Text = "Status";
            // 
            // EmpErrorLbl
            // 
            this.EmpErrorLbl.AutoSize = true;
            this.EmpErrorLbl.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.EmpErrorLbl.ForeColor = System.Drawing.Color.Crimson;
            this.EmpErrorLbl.Location = new System.Drawing.Point(65, 160);
            this.EmpErrorLbl.Name = "EmpErrorLbl";
            this.EmpErrorLbl.Size = new System.Drawing.Size(12, 13);
            this.EmpErrorLbl.TabIndex = 34;
            this.EmpErrorLbl.Text = "*";
            this.EmpErrorLbl.Visible = false;
            // 
            // EmpNameTxt
            // 
            this.EmpNameTxt.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.EmpNameTxt.Location = new System.Drawing.Point(0, 176);
            this.EmpNameTxt.MaxLength = 50;
            this.EmpNameTxt.Name = "EmpNameTxt";
            this.EmpNameTxt.Size = new System.Drawing.Size(194, 22);
            this.EmpNameTxt.TabIndex = 35;
            this.EmpNameTxt.TextChanged += new System.EventHandler(this.EmpNameTxt_TextChanged);
            // 
            // EmpNameLbl
            // 
            this.EmpNameLbl.AutoSize = true;
            this.EmpNameLbl.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.EmpNameLbl.Location = new System.Drawing.Point(3, 160);
            this.EmpNameLbl.Name = "EmpNameLbl";
            this.EmpNameLbl.Size = new System.Drawing.Size(56, 13);
            this.EmpNameLbl.TabIndex = 36;
            this.EmpNameLbl.Text = "Employee";
            // 
            // CompNameErrorLbl
            // 
            this.CompNameErrorLbl.AutoSize = true;
            this.CompNameErrorLbl.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.CompNameErrorLbl.ForeColor = System.Drawing.Color.Crimson;
            this.CompNameErrorLbl.Location = new System.Drawing.Point(164, 119);
            this.CompNameErrorLbl.Name = "CompNameErrorLbl";
            this.CompNameErrorLbl.Size = new System.Drawing.Size(12, 13);
            this.CompNameErrorLbl.TabIndex = 39;
            this.CompNameErrorLbl.Text = "*";
            this.CompNameErrorLbl.Visible = false;
            // 
            // CompNameTxt
            // 
            this.CompNameTxt.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.CompNameTxt.Location = new System.Drawing.Point(3, 135);
            this.CompNameTxt.MaxLength = 50;
            this.CompNameTxt.Name = "CompNameTxt";
            this.CompNameTxt.Size = new System.Drawing.Size(194, 22);
            this.CompNameTxt.TabIndex = 40;
            this.CompNameTxt.TextChanged += new System.EventHandler(this.CompNameTxt_TextChanged);
            // 
            // CompNameLbl
            // 
            this.CompNameLbl.AutoSize = true;
            this.CompNameLbl.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.CompNameLbl.Location = new System.Drawing.Point(3, 119);
            this.CompNameLbl.Name = "CompNameLbl";
            this.CompNameLbl.Size = new System.Drawing.Size(102, 13);
            this.CompNameLbl.TabIndex = 41;
            this.CompNameLbl.Text = "Supplier/Company";
            // 
            // AddressErrorLbl
            // 
            this.AddressErrorLbl.AutoSize = true;
            this.AddressErrorLbl.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.AddressErrorLbl.ForeColor = System.Drawing.Color.Crimson;
            this.AddressErrorLbl.Location = new System.Drawing.Point(93, 201);
            this.AddressErrorLbl.Name = "AddressErrorLbl";
            this.AddressErrorLbl.Size = new System.Drawing.Size(12, 13);
            this.AddressErrorLbl.TabIndex = 42;
            this.AddressErrorLbl.Text = "*";
            this.AddressErrorLbl.Visible = false;
            
            // 
            // AddressTxt
            // 
            this.AddressTxt.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.AddressTxt.Location = new System.Drawing.Point(0, 217);
            this.AddressTxt.MaxLength = 100;
            this.AddressTxt.Name = "AddressTxt";
            this.AddressTxt.Size = new System.Drawing.Size(194, 22);
            this.AddressTxt.TabIndex = 43;
            this.AddressTxt.TextChanged += new System.EventHandler(this.AddressTxt_TextChanged);
            // 
            // AddressLbl
            // 
            this.AddressLbl.AutoSize = true;
            this.AddressLbl.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.AddressLbl.Location = new System.Drawing.Point(3, 201);
            this.AddressLbl.Name = "AddressLbl";
            this.AddressLbl.Size = new System.Drawing.Size(48, 13);
            this.AddressLbl.TabIndex = 44;
            this.AddressLbl.Text = "Address";
            // 
            // NTNTxt
            // 
            this.NTNTxt.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.NTNTxt.Location = new System.Drawing.Point(0, 258);
            this.NTNTxt.MaxLength = 20;
            this.NTNTxt.Name = "NTNTxt";
            this.NTNTxt.Size = new System.Drawing.Size(194, 22);
            this.NTNTxt.TabIndex = 46;
            
            // 
            // NtnLbl
            // 
            this.NtnLbl.AutoSize = true;
            this.NtnLbl.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.NtnLbl.Location = new System.Drawing.Point(3, 242);
            this.NtnLbl.Name = "NtnLbl";
            this.NtnLbl.Size = new System.Drawing.Size(32, 13);
            this.NtnLbl.TabIndex = 47;
            this.NtnLbl.Text = "NTN ";
            // 
            // Phn2Txt
            // 
            this.Phn2Txt.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.Phn2Txt.Location = new System.Drawing.Point(0, 340);
            this.Phn2Txt.MaxLength = 40;
            this.Phn2Txt.Name = "Phn2Txt";
            this.Phn2Txt.Size = new System.Drawing.Size(194, 22);
            this.Phn2Txt.TabIndex = 52;
            // 
            // Phn2Lbl
            // 
            this.Phn2Lbl.AutoSize = true;
            this.Phn2Lbl.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.Phn2Lbl.Location = new System.Drawing.Point(-1, 324);
            this.Phn2Lbl.Name = "Phn2Lbl";
            this.Phn2Lbl.Size = new System.Drawing.Size(53, 13);
            this.Phn2Lbl.TabIndex = 53;
            this.Phn2Lbl.Text = "Phone#2";
            // 
            // PhnErrorLbl
            // 
            this.PhnErrorLbl.AutoSize = true;
            this.PhnErrorLbl.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.PhnErrorLbl.ForeColor = System.Drawing.Color.Crimson;
            this.PhnErrorLbl.Location = new System.Drawing.Point(65, 283);
            this.PhnErrorLbl.Name = "PhnErrorLbl";
            this.PhnErrorLbl.Size = new System.Drawing.Size(12, 13);
            this.PhnErrorLbl.TabIndex = 48;
            this.PhnErrorLbl.Text = "*";
            this.PhnErrorLbl.Visible = false;
            
            // 
            // PhnTxt
            // 
            this.PhnTxt.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.PhnTxt.Location = new System.Drawing.Point(3, 299);
            this.PhnTxt.MaxLength = 40;
            this.PhnTxt.Name = "PhnTxt";
            this.PhnTxt.Size = new System.Drawing.Size(194, 22);
            this.PhnTxt.TabIndex = 49;
            this.PhnTxt.TextChanged += new System.EventHandler(this.PhnTxt_TextChanged);
            // 
            // PhnLbl
            // 
            this.PhnLbl.AutoSize = true;
            this.PhnLbl.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.PhnLbl.Location = new System.Drawing.Point(0, 283);
            this.PhnLbl.Name = "PhnLbl";
            this.PhnLbl.Size = new System.Drawing.Size(53, 13);
            this.PhnLbl.TabIndex = 50;
            this.PhnLbl.Text = "Phone#1";
            // 
            // Suppliers_dataGridView
            // 
            this.Suppliers_dataGridView.AllowUserToAddRows = false;
            this.Suppliers_dataGridView.AllowUserToDeleteRows = false;
            this.Suppliers_dataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Suppliers_dataGridView.BackgroundColor = System.Drawing.Color.White;
            this.Suppliers_dataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle11.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Suppliers_dataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle11;
            this.Suppliers_dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Suppliers_dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdGv,
            this.CompNameGv,
            this.EmployeeGv,
            this.AddressGv,
            this.NTNGV,
            this.Phone1Gv,
            this.Phone2Gv,
            this.StsGv});
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.SystemColors.GrayText;
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Suppliers_dataGridView.DefaultCellStyle = dataGridViewCellStyle12;
            this.Suppliers_dataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Suppliers_dataGridView.Location = new System.Drawing.Point(0, 106);
            this.Suppliers_dataGridView.Name = "Suppliers_dataGridView";
            this.Suppliers_dataGridView.ReadOnly = true;
            this.Suppliers_dataGridView.RowHeadersVisible = false;
            this.Suppliers_dataGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.Suppliers_dataGridView.Size = new System.Drawing.Size(763, 506);
            this.Suppliers_dataGridView.TabIndex = 6;
            this.Suppliers_dataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Suppliers_dataGridView_CellClick);
            // 
            // IdGv
            // 
            this.IdGv.HeaderText = "ID";
            this.IdGv.Name = "IdGv";
            this.IdGv.ReadOnly = true;
            this.IdGv.Visible = false;
            // 
            // CompNameGv
            // 
            this.CompNameGv.HeaderText = "Company";
            this.CompNameGv.Name = "CompNameGv";
            this.CompNameGv.ReadOnly = true;
            // 
            // EmployeeGv
            // 
            this.EmployeeGv.HeaderText = "Employees";
            this.EmployeeGv.Name = "EmployeeGv";
            this.EmployeeGv.ReadOnly = true;
            // 
            // AddressGv
            // 
            this.AddressGv.HeaderText = "Address";
            this.AddressGv.Name = "AddressGv";
            this.AddressGv.ReadOnly = true;
            // 
            // NTNGV
            // 
            this.NTNGV.HeaderText = "NTN";
            this.NTNGV.Name = "NTNGV";
            this.NTNGV.ReadOnly = true;
            // 
            // Phone1Gv
            // 
            this.Phone1Gv.HeaderText = "Phone #1";
            this.Phone1Gv.Name = "Phone1Gv";
            this.Phone1Gv.ReadOnly = true;
            // 
            // Phone2Gv
            // 
            this.Phone2Gv.HeaderText = "Phone #2";
            this.Phone2Gv.Name = "Phone2Gv";
            this.Phone2Gv.ReadOnly = true;
            // 
            // StsGv
            // 
            this.StsGv.HeaderText = "Status";
            this.StsGv.Name = "StsGv";
            this.StsGv.ReadOnly = true;
            // 
            // Suppliers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(963, 612);
            this.Name = "Suppliers";
            this.Text = "Suppliers";
            this.Load += new System.EventHandler(this.Suppliers_Load);
            this.LeftPanel.ResumeLayout(false);
            this.LeftPanel.PerformLayout();
            this.rightPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Suppliers_dataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox StatusDD;
        private System.Windows.Forms.Label StatusErrorLbl;
        private System.Windows.Forms.Label StatusLbl;
        private System.Windows.Forms.Label EmpErrorLbl;
        private System.Windows.Forms.TextBox EmpNameTxt;
        private System.Windows.Forms.Label EmpNameLbl;
        private System.Windows.Forms.TextBox Phn2Txt;
        private System.Windows.Forms.Label Phn2Lbl;
        private System.Windows.Forms.Label PhnErrorLbl;
        private System.Windows.Forms.TextBox PhnTxt;
        private System.Windows.Forms.Label PhnLbl;
        private System.Windows.Forms.TextBox NTNTxt;
        private System.Windows.Forms.Label NtnLbl;
        private System.Windows.Forms.Label AddressErrorLbl;
        private System.Windows.Forms.TextBox AddressTxt;
        private System.Windows.Forms.Label AddressLbl;
        private System.Windows.Forms.Label CompNameErrorLbl;
        private System.Windows.Forms.TextBox CompNameTxt;
        private System.Windows.Forms.Label CompNameLbl;
        private System.Windows.Forms.DataGridView Suppliers_dataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdGv;
        private System.Windows.Forms.DataGridViewTextBoxColumn CompNameGv;
        private System.Windows.Forms.DataGridViewTextBoxColumn EmployeeGv;
        private System.Windows.Forms.DataGridViewTextBoxColumn AddressGv;
        private System.Windows.Forms.DataGridViewTextBoxColumn NTNGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn Phone1Gv;
        private System.Windows.Forms.DataGridViewTextBoxColumn Phone2Gv;
        private System.Windows.Forms.DataGridViewTextBoxColumn StsGv;
    }
}