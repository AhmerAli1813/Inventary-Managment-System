
namespace ivs.system
{
    partial class Catagories
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
            this.CatErrorLbl = new System.Windows.Forms.Label();
            this.Cat_NameTxt = new System.Windows.Forms.TextBox();
            this.CatNameLbl = new System.Windows.Forms.Label();
            this.Cat_dataGridView = new System.Windows.Forms.DataGridView();
            this.IdGv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NameGv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StsGv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LeftPanel.SuspendLayout();
            this.rightPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Cat_dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // searchtxt
            // 
            
            // 
            // LeftPanel
            // 
            this.LeftPanel.Controls.Add(this.StatusDD);
            this.LeftPanel.Controls.Add(this.StatusErrorLbl);
            this.LeftPanel.Controls.Add(this.StatusLbl);
            this.LeftPanel.Controls.Add(this.CatErrorLbl);
            this.LeftPanel.Controls.Add(this.Cat_NameTxt);
            this.LeftPanel.Controls.Add(this.CatNameLbl);
            this.LeftPanel.Size = new System.Drawing.Size(200, 450);
            this.LeftPanel.Controls.SetChildIndex(this.CatNameLbl, 0);
            this.LeftPanel.Controls.SetChildIndex(this.Cat_NameTxt, 0);
            this.LeftPanel.Controls.SetChildIndex(this.CatErrorLbl, 0);
            this.LeftPanel.Controls.SetChildIndex(this.StatusLbl, 0);
            this.LeftPanel.Controls.SetChildIndex(this.StatusErrorLbl, 0);
            this.LeftPanel.Controls.SetChildIndex(this.StatusDD, 0);
            // 
            // rightPanel
            // 
            this.rightPanel.Controls.Add(this.Cat_dataGridView);
            this.rightPanel.Size = new System.Drawing.Size(600, 450);
            this.rightPanel.Controls.SetChildIndex(this.Cat_dataGridView, 0);
            // 
            // StatusDD
            // 
            this.StatusDD.FormattingEnabled = true;
            this.StatusDD.Items.AddRange(new object[] {
            "Active",
            "In-Active"});
            this.StatusDD.Location = new System.Drawing.Point(3, 185);
            this.StatusDD.Name = "StatusDD";
            this.StatusDD.Size = new System.Drawing.Size(194, 28);
            this.StatusDD.TabIndex = 27;
            // 
            // StatusErrorLbl
            // 
            this.StatusErrorLbl.AutoSize = true;
            this.StatusErrorLbl.ForeColor = System.Drawing.Color.Crimson;
            this.StatusErrorLbl.Location = new System.Drawing.Point(85, 162);
            this.StatusErrorLbl.Name = "StatusErrorLbl";
            this.StatusErrorLbl.Size = new System.Drawing.Size(15, 20);
            this.StatusErrorLbl.TabIndex = 31;
            this.StatusErrorLbl.Text = "*";
            this.StatusErrorLbl.Visible = false;
            // 
            // StatusLbl
            // 
            this.StatusLbl.AutoSize = true;
            this.StatusLbl.Location = new System.Drawing.Point(3, 162);
            this.StatusLbl.Name = "StatusLbl";
            this.StatusLbl.Size = new System.Drawing.Size(49, 20);
            this.StatusLbl.TabIndex = 32;
            this.StatusLbl.Text = "Status";
            // 
            // CatErrorLbl
            // 
            this.CatErrorLbl.AutoSize = true;
            this.CatErrorLbl.ForeColor = System.Drawing.Color.Crimson;
            this.CatErrorLbl.Location = new System.Drawing.Point(122, 109);
            this.CatErrorLbl.Name = "CatErrorLbl";
            this.CatErrorLbl.Size = new System.Drawing.Size(15, 20);
            this.CatErrorLbl.TabIndex = 28;
            this.CatErrorLbl.Text = "*";
            this.CatErrorLbl.Visible = false;
            // 
            // Cat_NameTxt
            // 
            this.Cat_NameTxt.Location = new System.Drawing.Point(3, 132);
            this.Cat_NameTxt.MaxLength = 40;
            this.Cat_NameTxt.Name = "Cat_NameTxt";
            this.Cat_NameTxt.Size = new System.Drawing.Size(194, 27);
            this.Cat_NameTxt.TabIndex = 29;
            // 
            // CatNameLbl
            // 
            this.CatNameLbl.AutoSize = true;
            this.CatNameLbl.Location = new System.Drawing.Point(3, 109);
            this.CatNameLbl.Name = "CatNameLbl";
            this.CatNameLbl.Size = new System.Drawing.Size(113, 20);
            this.CatNameLbl.TabIndex = 30;
            this.CatNameLbl.Text = "Catagory Name";
            // 
            // Cat_dataGridView
            // 
            this.Cat_dataGridView.AllowUserToAddRows = false;
            this.Cat_dataGridView.AllowUserToDeleteRows = false;
            this.Cat_dataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Cat_dataGridView.BackgroundColor = System.Drawing.Color.White;
            this.Cat_dataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Cat_dataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.Cat_dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Cat_dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdGv,
            this.NameGv,
            this.StsGv});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.GrayText;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Cat_dataGridView.DefaultCellStyle = dataGridViewCellStyle2;
            this.Cat_dataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Cat_dataGridView.Location = new System.Drawing.Point(0, 106);
            this.Cat_dataGridView.Name = "Cat_dataGridView";
            this.Cat_dataGridView.ReadOnly = true;
            this.Cat_dataGridView.RowHeadersVisible = false;
            this.Cat_dataGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.Cat_dataGridView.Size = new System.Drawing.Size(600, 344);
            this.Cat_dataGridView.TabIndex = 5;
            this.Cat_dataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Cat_dataGridView_CellClick);
            // 
            // IdGv
            // 
            this.IdGv.HeaderText = "ID";
            this.IdGv.Name = "IdGv";
            this.IdGv.ReadOnly = true;
            this.IdGv.Visible = false;
            // 
            // NameGv
            // 
            this.NameGv.HeaderText = "Catagory Name";
            this.NameGv.Name = "NameGv";
            this.NameGv.ReadOnly = true;
            // 
            // StsGv
            // 
            this.StsGv.HeaderText = "Status";
            this.StsGv.Name = "StsGv";
            this.StsGv.ReadOnly = true;
            // 
            // Catagories
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Name = "Catagories";
            this.Text = "Catagories";
            this.Load += new System.EventHandler(this.Catagories_Load);
            this.LeftPanel.ResumeLayout(false);
            this.LeftPanel.PerformLayout();
            this.rightPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Cat_dataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox StatusDD;
        private System.Windows.Forms.Label StatusErrorLbl;
        private System.Windows.Forms.Label StatusLbl;
        private System.Windows.Forms.Label CatErrorLbl;
        private System.Windows.Forms.TextBox Cat_NameTxt;
        private System.Windows.Forms.Label CatNameLbl;
        private System.Windows.Forms.DataGridView Cat_dataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdGv;
        private System.Windows.Forms.DataGridViewTextBoxColumn NameGv;
        private System.Windows.Forms.DataGridViewTextBoxColumn StsGv;
    }
}