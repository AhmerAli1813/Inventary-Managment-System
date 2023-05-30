
namespace ivs.system
{
    partial class Users
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
            this.NameLbl = new System.Windows.Forms.Label();
            this.U_NameTxt = new System.Windows.Forms.TextBox();
            this.U_NameErrorLbl = new System.Windows.Forms.Label();
            this.U_EmailErrorLbl = new System.Windows.Forms.Label();
            this.U_EmailTxt = new System.Windows.Forms.TextBox();
            this.U_EmailLbl = new System.Windows.Forms.Label();
            this.U_UsernameErrorLbl = new System.Windows.Forms.Label();
            this.U_UsernameTxt = new System.Windows.Forms.TextBox();
            this.U_UsernameLbl = new System.Windows.Forms.Label();
            this.U_PassErrorLbl = new System.Windows.Forms.Label();
            this.U_PassTxt = new System.Windows.Forms.TextBox();
            this.U_PassLbl = new System.Windows.Forms.Label();
            this.U_StatusErrorLbl = new System.Windows.Forms.Label();
            this.U_StatusLbl = new System.Windows.Forms.Label();
            this.U_StatusDD = new System.Windows.Forms.ComboBox();
            this.UserdataGridView1 = new System.Windows.Forms.DataGridView();
            this.U_IdGv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.U_NameGv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.U_UsernameGv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.U_EmailGv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.U_PassGv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.U_StsGv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LeftPanel.SuspendLayout();
            this.rightPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.UserdataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // LeftPanel
            // 
            this.LeftPanel.Controls.Add(this.U_StatusDD);
            this.LeftPanel.Controls.Add(this.U_StatusErrorLbl);
            this.LeftPanel.Controls.Add(this.U_StatusLbl);
            this.LeftPanel.Controls.Add(this.U_PassErrorLbl);
            this.LeftPanel.Controls.Add(this.U_PassTxt);
            this.LeftPanel.Controls.Add(this.U_PassLbl);
            this.LeftPanel.Controls.Add(this.U_UsernameErrorLbl);
            this.LeftPanel.Controls.Add(this.U_UsernameTxt);
            this.LeftPanel.Controls.Add(this.U_UsernameLbl);
            this.LeftPanel.Controls.Add(this.U_EmailErrorLbl);
            this.LeftPanel.Controls.Add(this.U_EmailTxt);
            this.LeftPanel.Controls.Add(this.U_EmailLbl);
            this.LeftPanel.Controls.Add(this.U_NameErrorLbl);
            this.LeftPanel.Controls.Add(this.U_NameTxt);
            this.LeftPanel.Controls.Add(this.NameLbl);
            this.LeftPanel.Size = new System.Drawing.Size(200, 707);
            this.LeftPanel.Controls.SetChildIndex(this.NameLbl, 0);
            this.LeftPanel.Controls.SetChildIndex(this.U_NameTxt, 0);
            this.LeftPanel.Controls.SetChildIndex(this.U_NameErrorLbl, 0);
            this.LeftPanel.Controls.SetChildIndex(this.U_EmailLbl, 0);
            this.LeftPanel.Controls.SetChildIndex(this.U_EmailTxt, 0);
            this.LeftPanel.Controls.SetChildIndex(this.U_EmailErrorLbl, 0);
            this.LeftPanel.Controls.SetChildIndex(this.U_UsernameLbl, 0);
            this.LeftPanel.Controls.SetChildIndex(this.U_UsernameTxt, 0);
            this.LeftPanel.Controls.SetChildIndex(this.U_UsernameErrorLbl, 0);
            this.LeftPanel.Controls.SetChildIndex(this.U_PassLbl, 0);
            this.LeftPanel.Controls.SetChildIndex(this.U_PassTxt, 0);
            this.LeftPanel.Controls.SetChildIndex(this.U_PassErrorLbl, 0);
            this.LeftPanel.Controls.SetChildIndex(this.U_StatusLbl, 0);
            this.LeftPanel.Controls.SetChildIndex(this.U_StatusErrorLbl, 0);
            this.LeftPanel.Controls.SetChildIndex(this.U_StatusDD, 0);
            // 
            // rightPanel
            // 
            this.rightPanel.Controls.Add(this.UserdataGridView1);
            this.rightPanel.Size = new System.Drawing.Size(600, 707);
            this.rightPanel.Controls.SetChildIndex(this.UserdataGridView1, 0);
            // 
            // NameLbl
            // 
            this.NameLbl.AutoSize = true;
            this.NameLbl.Location = new System.Drawing.Point(3, 152);
            this.NameLbl.Name = "NameLbl";
            this.NameLbl.Size = new System.Drawing.Size(76, 20);
            this.NameLbl.TabIndex = 4;
            this.NameLbl.Text = "Full Name";
            // 
            // U_NameTxt
            // 
            this.U_NameTxt.Location = new System.Drawing.Point(3, 175);
            this.U_NameTxt.MaxLength = 40;
            this.U_NameTxt.Name = "U_NameTxt";
            this.U_NameTxt.Size = new System.Drawing.Size(194, 27);
            this.U_NameTxt.TabIndex = 4;
            // 
            // U_NameErrorLbl
            // 
            this.U_NameErrorLbl.AutoSize = true;
            this.U_NameErrorLbl.ForeColor = System.Drawing.Color.Crimson;
            this.U_NameErrorLbl.Location = new System.Drawing.Point(85, 152);
            this.U_NameErrorLbl.Name = "U_NameErrorLbl";
            this.U_NameErrorLbl.Size = new System.Drawing.Size(15, 20);
            this.U_NameErrorLbl.TabIndex = 4;
            this.U_NameErrorLbl.Text = "*";
            this.U_NameErrorLbl.Visible = false;
            // 
            // U_EmailErrorLbl
            // 
            this.U_EmailErrorLbl.AutoSize = true;
            this.U_EmailErrorLbl.ForeColor = System.Drawing.Color.Crimson;
            this.U_EmailErrorLbl.Location = new System.Drawing.Point(81, 259);
            this.U_EmailErrorLbl.Name = "U_EmailErrorLbl";
            this.U_EmailErrorLbl.Size = new System.Drawing.Size(15, 20);
            this.U_EmailErrorLbl.TabIndex = 12;
            this.U_EmailErrorLbl.Text = "*";
            this.U_EmailErrorLbl.Visible = false;
            // 
            // U_EmailTxt
            // 
            this.U_EmailTxt.Location = new System.Drawing.Point(-1, 282);
            this.U_EmailTxt.MaxLength = 40;
            this.U_EmailTxt.Name = "U_EmailTxt";
            this.U_EmailTxt.Size = new System.Drawing.Size(194, 27);
            this.U_EmailTxt.TabIndex = 13;
            // 
            // U_EmailLbl
            // 
            this.U_EmailLbl.AutoSize = true;
            this.U_EmailLbl.Location = new System.Drawing.Point(-1, 259);
            this.U_EmailLbl.Name = "U_EmailLbl";
            this.U_EmailLbl.Size = new System.Drawing.Size(46, 20);
            this.U_EmailLbl.TabIndex = 14;
            this.U_EmailLbl.Text = "Email";
            // 
            // U_UsernameErrorLbl
            // 
            this.U_UsernameErrorLbl.AutoSize = true;
            this.U_UsernameErrorLbl.ForeColor = System.Drawing.Color.Crimson;
            this.U_UsernameErrorLbl.Location = new System.Drawing.Point(85, 206);
            this.U_UsernameErrorLbl.Name = "U_UsernameErrorLbl";
            this.U_UsernameErrorLbl.Size = new System.Drawing.Size(15, 20);
            this.U_UsernameErrorLbl.TabIndex = 18;
            this.U_UsernameErrorLbl.Text = "*";
            this.U_UsernameErrorLbl.Visible = false;
            // 
            // U_UsernameTxt
            // 
            this.U_UsernameTxt.Location = new System.Drawing.Point(3, 229);
            this.U_UsernameTxt.MaxLength = 40;
            this.U_UsernameTxt.Name = "U_UsernameTxt";
            this.U_UsernameTxt.Size = new System.Drawing.Size(194, 27);
            this.U_UsernameTxt.TabIndex = 19;
            // 
            // U_UsernameLbl
            // 
            this.U_UsernameLbl.AutoSize = true;
            this.U_UsernameLbl.Location = new System.Drawing.Point(3, 206);
            this.U_UsernameLbl.Name = "U_UsernameLbl";
            this.U_UsernameLbl.Size = new System.Drawing.Size(75, 20);
            this.U_UsernameLbl.TabIndex = 20;
            this.U_UsernameLbl.Text = "Username";
            // 
            // U_PassErrorLbl
            // 
            this.U_PassErrorLbl.AutoSize = true;
            this.U_PassErrorLbl.ForeColor = System.Drawing.Color.Crimson;
            this.U_PassErrorLbl.Location = new System.Drawing.Point(85, 312);
            this.U_PassErrorLbl.Name = "U_PassErrorLbl";
            this.U_PassErrorLbl.Size = new System.Drawing.Size(15, 20);
            this.U_PassErrorLbl.TabIndex = 21;
            this.U_PassErrorLbl.Text = "*";
            this.U_PassErrorLbl.Visible = false;
            // 
            // U_PassTxt
            // 
            this.U_PassTxt.Location = new System.Drawing.Point(3, 335);
            this.U_PassTxt.MaxLength = 40;
            this.U_PassTxt.Name = "U_PassTxt";
            this.U_PassTxt.Size = new System.Drawing.Size(194, 27);
            this.U_PassTxt.TabIndex = 22;
            // 
            // U_PassLbl
            // 
            this.U_PassLbl.AutoSize = true;
            this.U_PassLbl.Location = new System.Drawing.Point(3, 312);
            this.U_PassLbl.Name = "U_PassLbl";
            this.U_PassLbl.Size = new System.Drawing.Size(70, 20);
            this.U_PassLbl.TabIndex = 23;
            this.U_PassLbl.Text = "Password";
            // 
            // U_StatusErrorLbl
            // 
            this.U_StatusErrorLbl.AutoSize = true;
            this.U_StatusErrorLbl.ForeColor = System.Drawing.Color.Crimson;
            this.U_StatusErrorLbl.Location = new System.Drawing.Point(85, 365);
            this.U_StatusErrorLbl.Name = "U_StatusErrorLbl";
            this.U_StatusErrorLbl.Size = new System.Drawing.Size(15, 20);
            this.U_StatusErrorLbl.TabIndex = 24;
            this.U_StatusErrorLbl.Text = "*";
            this.U_StatusErrorLbl.Visible = false;
            // 
            // U_StatusLbl
            // 
            this.U_StatusLbl.AutoSize = true;
            this.U_StatusLbl.Location = new System.Drawing.Point(3, 365);
            this.U_StatusLbl.Name = "U_StatusLbl";
            this.U_StatusLbl.Size = new System.Drawing.Size(49, 20);
            this.U_StatusLbl.TabIndex = 26;
            this.U_StatusLbl.Text = "Status";
            // 
            // U_StatusDD
            // 
            this.U_StatusDD.FormattingEnabled = true;
            this.U_StatusDD.Items.AddRange(new object[] {
            "Active",
            "In-Active"});
            this.U_StatusDD.Location = new System.Drawing.Point(-1, 388);
            this.U_StatusDD.Name = "U_StatusDD";
            this.U_StatusDD.Size = new System.Drawing.Size(194, 28);
            this.U_StatusDD.TabIndex = 4;
            // 
            // UserdataGridView1
            // 
            this.UserdataGridView1.AllowUserToAddRows = false;
            this.UserdataGridView1.AllowUserToDeleteRows = false;
            this.UserdataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.UserdataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.UserdataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.UserdataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.UserdataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.UserdataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.U_IdGv,
            this.U_NameGv,
            this.U_UsernameGv,
            this.U_EmailGv,
            this.U_PassGv,
            this.U_StsGv});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.GrayText;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.UserdataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            this.UserdataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.UserdataGridView1.Location = new System.Drawing.Point(0, 106);
            this.UserdataGridView1.Name = "UserdataGridView1";
            this.UserdataGridView1.ReadOnly = true;
            this.UserdataGridView1.RowHeadersVisible = false;
            this.UserdataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.UserdataGridView1.Size = new System.Drawing.Size(600, 601);
            this.UserdataGridView1.TabIndex = 4;
            this.UserdataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.UserdataGridView1_CellClick_1);
            // 
            // U_IdGv
            // 
            this.U_IdGv.HeaderText = "ID";
            this.U_IdGv.Name = "U_IdGv";
            this.U_IdGv.ReadOnly = true;
            this.U_IdGv.Visible = false;
            // 
            // U_NameGv
            // 
            this.U_NameGv.HeaderText = "Full Name";
            this.U_NameGv.Name = "U_NameGv";
            this.U_NameGv.ReadOnly = true;
            // 
            // U_UsernameGv
            // 
            this.U_UsernameGv.HeaderText = "Username";
            this.U_UsernameGv.Name = "U_UsernameGv";
            this.U_UsernameGv.ReadOnly = true;
            // 
            // U_EmailGv
            // 
            this.U_EmailGv.HeaderText = "Email";
            this.U_EmailGv.Name = "U_EmailGv";
            this.U_EmailGv.ReadOnly = true;
            // 
            // U_PassGv
            // 
            this.U_PassGv.HeaderText = "Password";
            this.U_PassGv.Name = "U_PassGv";
            this.U_PassGv.ReadOnly = true;
            this.U_PassGv.Visible = false;
            // 
            // U_StsGv
            // 
            this.U_StsGv.HeaderText = "Status";
            this.U_StsGv.Name = "U_StsGv";
            this.U_StsGv.ReadOnly = true;
            // 
            // Users
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 707);
            this.Name = "Users";
            this.Text = "Users";
            this.Load += new System.EventHandler(this.Users_Load);
            this.LeftPanel.ResumeLayout(false);
            this.LeftPanel.PerformLayout();
            this.rightPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.UserdataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        
        private System.Windows.Forms.TextBox U_NameTxt;
        private System.Windows.Forms.Label NameLbl;
        private System.Windows.Forms.ComboBox U_StatusDD;
        private System.Windows.Forms.Label U_StatusErrorLbl;
        private System.Windows.Forms.Label U_StatusLbl;
        private System.Windows.Forms.Label U_PassErrorLbl;
        private System.Windows.Forms.TextBox U_PassTxt;
        private System.Windows.Forms.Label U_PassLbl;
        private System.Windows.Forms.Label U_UsernameErrorLbl;
        private System.Windows.Forms.TextBox U_UsernameTxt;
        private System.Windows.Forms.Label U_UsernameLbl;
        private System.Windows.Forms.Label U_EmailErrorLbl;
        private System.Windows.Forms.TextBox U_EmailTxt;
        private System.Windows.Forms.Label U_EmailLbl;
        private System.Windows.Forms.Label U_NameErrorLbl;
        private System.Windows.Forms.DataGridView UserdataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn U_IdGv;
        private System.Windows.Forms.DataGridViewTextBoxColumn U_NameGv;
        private System.Windows.Forms.DataGridViewTextBoxColumn U_UsernameGv;
        private System.Windows.Forms.DataGridViewTextBoxColumn U_EmailGv;
        private System.Windows.Forms.DataGridViewTextBoxColumn U_PassGv;
        private System.Windows.Forms.DataGridViewTextBoxColumn U_StsGv;
    }
}