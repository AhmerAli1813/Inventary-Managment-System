
namespace ivs.system
{
    partial class Sample2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        protected System.ComponentModel.IContainer components = null;

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
        protected void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.RightTopTblPnl = new System.Windows.Forms.TableLayoutPanel();
            this.DelBtn = new System.Windows.Forms.Button();
            this.EditBtn = new System.Windows.Forms.Button();
            this.SaveBtn = new System.Windows.Forms.Button();
            this.AddBtn = new System.Windows.Forms.Button();
            this.viewBtn = new System.Windows.Forms.Button();
            this.SearchPanel = new System.Windows.Forms.Panel();
            this.searchtxt = new System.Windows.Forms.TextBox();
            this.SearchLbl = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.panel2 = new System.Windows.Forms.Panel();
            this.LeftPanel.SuspendLayout();
            this.rightPanel.SuspendLayout();
            this.RightTopTblPnl.SuspendLayout();
            this.SearchPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // LeftPanel
            // 
            this.LeftPanel.Controls.Add(this.panel2);
            this.LeftPanel.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.LeftPanel.Size = new System.Drawing.Size(200, 571);
            this.LeftPanel.Controls.SetChildIndex(this.panel2, 0);
            // 
            // rightPanel
            // 
            this.rightPanel.Controls.Add(this.RightTopTblPnl);
            this.rightPanel.Size = new System.Drawing.Size(1067, 571);
            this.rightPanel.Controls.SetChildIndex(this.RightTopTblPnl, 0);
            // 
            // RightTopTblPnl
            // 
            this.RightTopTblPnl.ColumnCount = 6;
            this.RightTopTblPnl.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 13F));
            this.RightTopTblPnl.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 13F));
            this.RightTopTblPnl.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 13F));
            this.RightTopTblPnl.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 13F));
            this.RightTopTblPnl.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 13F));
            this.RightTopTblPnl.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35F));
            this.RightTopTblPnl.Controls.Add(this.DelBtn, 0, 0);
            this.RightTopTblPnl.Controls.Add(this.EditBtn, 0, 0);
            this.RightTopTblPnl.Controls.Add(this.SaveBtn, 0, 0);
            this.RightTopTblPnl.Controls.Add(this.AddBtn, 0, 0);
            this.RightTopTblPnl.Controls.Add(this.viewBtn, 4, 0);
            this.RightTopTblPnl.Controls.Add(this.SearchPanel, 5, 0);
            this.RightTopTblPnl.Dock = System.Windows.Forms.DockStyle.Top;
            this.RightTopTblPnl.Location = new System.Drawing.Point(0, 56);
            this.RightTopTblPnl.Name = "RightTopTblPnl";
            this.RightTopTblPnl.RowCount = 1;
            this.RightTopTblPnl.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.RightTopTblPnl.Size = new System.Drawing.Size(1067, 50);
            this.RightTopTblPnl.TabIndex = 2;
            // 
            // DelBtn
            // 
            this.DelBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DelBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DelBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.DelBtn.FlatAppearance.BorderSize = 2;
            this.DelBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.DelBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DelBtn.Location = new System.Drawing.Point(279, 3);
            this.DelBtn.Name = "DelBtn";
            this.DelBtn.Size = new System.Drawing.Size(132, 44);
            this.DelBtn.TabIndex = 6;
            this.DelBtn.Text = "Delete";
            this.DelBtn.UseVisualStyleBackColor = true;
            this.DelBtn.Click += new System.EventHandler(this.DelBtn_Click);
            // 
            // EditBtn
            // 
            this.EditBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.EditBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.EditBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.EditBtn.FlatAppearance.BorderSize = 2;
            this.EditBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.EditBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EditBtn.Location = new System.Drawing.Point(417, 3);
            this.EditBtn.Name = "EditBtn";
            this.EditBtn.Size = new System.Drawing.Size(132, 44);
            this.EditBtn.TabIndex = 3;
            this.EditBtn.Text = "Edit";
            this.EditBtn.UseVisualStyleBackColor = true;
            this.EditBtn.Click += new System.EventHandler(this.EditBtn_Click);
            // 
            // SaveBtn
            // 
            this.SaveBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SaveBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SaveBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.SaveBtn.FlatAppearance.BorderSize = 2;
            this.SaveBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.SaveBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SaveBtn.Location = new System.Drawing.Point(3, 3);
            this.SaveBtn.Name = "SaveBtn";
            this.SaveBtn.Size = new System.Drawing.Size(132, 44);
            this.SaveBtn.TabIndex = 2;
            this.SaveBtn.Text = "Save";
            this.SaveBtn.UseVisualStyleBackColor = true;
            this.SaveBtn.Click += new System.EventHandler(this.SaveBtn_Click);
            // 
            // AddBtn
            // 
            this.AddBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AddBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AddBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.AddBtn.FlatAppearance.BorderSize = 2;
            this.AddBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.AddBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddBtn.Location = new System.Drawing.Point(141, 3);
            this.AddBtn.Name = "AddBtn";
            this.AddBtn.Size = new System.Drawing.Size(132, 44);
            this.AddBtn.TabIndex = 1;
            this.AddBtn.Text = "Add";
            this.AddBtn.UseVisualStyleBackColor = true;
            this.AddBtn.Click += new System.EventHandler(this.AddBtn_Click);
            // 
            // viewBtn
            // 
            this.viewBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.viewBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.viewBtn.FlatAppearance.BorderSize = 2;
            this.viewBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.viewBtn.Location = new System.Drawing.Point(555, 3);
            this.viewBtn.Name = "viewBtn";
            this.viewBtn.Size = new System.Drawing.Size(132, 44);
            this.viewBtn.TabIndex = 7;
            this.viewBtn.Text = "View";
            this.viewBtn.UseVisualStyleBackColor = true;
            this.viewBtn.Click += new System.EventHandler(this.viewBtn_Click);
            // 
            // SearchPanel
            // 
            this.SearchPanel.Controls.Add(this.searchtxt);
            this.SearchPanel.Controls.Add(this.SearchLbl);
            this.SearchPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SearchPanel.Location = new System.Drawing.Point(693, 3);
            this.SearchPanel.Name = "SearchPanel";
            this.SearchPanel.Size = new System.Drawing.Size(371, 44);
            this.SearchPanel.TabIndex = 8;
            // 
            // searchtxt
            // 
            this.searchtxt.Location = new System.Drawing.Point(3, 14);
            this.searchtxt.MaxLength = 50;
            this.searchtxt.Name = "searchtxt";
            this.searchtxt.Size = new System.Drawing.Size(236, 27);
            this.searchtxt.TabIndex = 3;
            this.searchtxt.TextChanged += new System.EventHandler(this.searchtxt_TextChanged);
            // 
            // SearchLbl
            // 
            this.SearchLbl.AutoSize = true;
            this.SearchLbl.Location = new System.Drawing.Point(-1, -3);
            this.SearchLbl.Name = "SearchLbl";
            this.SearchLbl.Size = new System.Drawing.Size(53, 20);
            this.SearchLbl.TabIndex = 3;
            this.SearchLbl.Text = "Search";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // panel2
            // 
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 56);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 50);
            this.panel2.TabIndex = 11;
            // 
            // Sample2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1267, 571);
            this.Name = "Sample2";
            this.Text = "Sample2";
            this.Load += new System.EventHandler(this.Sample2_Load);
            this.Controls.SetChildIndex(this.LeftPanel, 0);
            this.Controls.SetChildIndex(this.rightPanel, 0);
            this.LeftPanel.ResumeLayout(false);
            this.rightPanel.ResumeLayout(false);
            this.RightTopTblPnl.ResumeLayout(false);
            this.SearchPanel.ResumeLayout(false);
            this.SearchPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        protected System.Windows.Forms.Button SaveBtn;
        protected System.Windows.Forms.Button AddBtn;
        protected System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        public System.Windows.Forms.TableLayoutPanel RightTopTblPnl;
        protected System.Windows.Forms.Panel panel2;
        protected System.Windows.Forms.Button DelBtn;
        protected System.Windows.Forms.Button EditBtn;
        protected System.Windows.Forms.Button viewBtn;
        protected System.Windows.Forms.Panel SearchPanel;
        protected System.Windows.Forms.Label SearchLbl;
        protected System.Windows.Forms.TextBox searchtxt;
    }
}