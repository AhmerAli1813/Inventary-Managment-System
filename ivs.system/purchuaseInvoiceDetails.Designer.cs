﻿
namespace ivs.system
{
    partial class purchuaseInvoiceDetails
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
            this.CompanyDD = new System.Windows.Forms.ComboBox();
            this.CompanyErrorLbl = new System.Windows.Forms.Label();
            this.StatusLbl = new System.Windows.Forms.Label();
            this.DatePicker = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.DateLbl = new System.Windows.Forms.Label();
            this.PurInv_dataGridView = new System.Windows.Forms.DataGridView();
            this.PInvAmontPanel = new System.Windows.Forms.Panel();
            this.GrandTableLayout = new System.Windows.Forms.TableLayoutPanel();
            this.GrossAmtPrzTxt = new System.Windows.Forms.Label();
            this.GrossAmtTxtLabl = new System.Windows.Forms.Label();
            this.ProIdGv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductGv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PrizePUGv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.QtyGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalAmtGv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DeleteGv = new System.Windows.Forms.DataGridViewButtonColumn();
            this.LeftPanel.SuspendLayout();
            this.rightPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BackBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PurInv_dataGridView)).BeginInit();
            this.PInvAmontPanel.SuspendLayout();
            this.GrandTableLayout.SuspendLayout();
            this.SuspendLayout();
            // 
            // LeftPanel
            // 
            this.LeftPanel.Controls.Add(this.label2);
            this.LeftPanel.Controls.Add(this.DateLbl);
            this.LeftPanel.Controls.Add(this.DatePicker);
            this.LeftPanel.Controls.Add(this.CompanyDD);
            this.LeftPanel.Controls.Add(this.CompanyErrorLbl);
            this.LeftPanel.Controls.Add(this.StatusLbl);
            this.LeftPanel.Size = new System.Drawing.Size(200, 450);
            this.LeftPanel.Controls.SetChildIndex(this.StatusLbl, 0);
            this.LeftPanel.Controls.SetChildIndex(this.CompanyErrorLbl, 0);
            this.LeftPanel.Controls.SetChildIndex(this.CompanyDD, 0);
            this.LeftPanel.Controls.SetChildIndex(this.DatePicker, 0);
            this.LeftPanel.Controls.SetChildIndex(this.DateLbl, 0);
            this.LeftPanel.Controls.SetChildIndex(this.label2, 0);
            // 
            // rightPanel
            // 
            this.rightPanel.Controls.Add(this.PInvAmontPanel);
            this.rightPanel.Controls.Add(this.PurInv_dataGridView);
            this.rightPanel.Size = new System.Drawing.Size(600, 450);
            this.rightPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.rightPanel_Paint);
            this.rightPanel.Controls.SetChildIndex(this.PurInv_dataGridView, 0);
            this.rightPanel.Controls.SetChildIndex(this.PInvAmontPanel, 0);
            // 
            // CompanyDD
            // 
            this.CompanyDD.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.CompanyDD.FormattingEnabled = true;
            this.CompanyDD.Items.AddRange(new object[] {
            "Active",
            "In-Active"});
            this.CompanyDD.Location = new System.Drawing.Point(6, 184);
            this.CompanyDD.Name = "CompanyDD";
            this.CompanyDD.Size = new System.Drawing.Size(184, 21);
            this.CompanyDD.TabIndex = 42;
            this.CompanyDD.SelectedIndexChanged += new System.EventHandler(this.CompanyDD_SelectedIndexChanged);
            // 
            // CompanyErrorLbl
            // 
            this.CompanyErrorLbl.AutoSize = true;
            this.CompanyErrorLbl.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.CompanyErrorLbl.ForeColor = System.Drawing.Color.Crimson;
            this.CompanyErrorLbl.Location = new System.Drawing.Point(148, 168);
            this.CompanyErrorLbl.Name = "CompanyErrorLbl";
            this.CompanyErrorLbl.Size = new System.Drawing.Size(12, 13);
            this.CompanyErrorLbl.TabIndex = 43;
            this.CompanyErrorLbl.Text = "*";
            this.CompanyErrorLbl.Visible = false;
            // 
            // StatusLbl
            // 
            this.StatusLbl.AutoSize = true;
            this.StatusLbl.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.StatusLbl.Location = new System.Drawing.Point(3, 168);
            this.StatusLbl.Name = "StatusLbl";
            this.StatusLbl.Size = new System.Drawing.Size(55, 13);
            this.StatusLbl.TabIndex = 44;
            this.StatusLbl.Text = "Company";
            // 
            // DatePicker
            // 
            this.DatePicker.CustomFormat = "                     MMM-yyyy";
            this.DatePicker.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.DatePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DatePicker.Location = new System.Drawing.Point(6, 143);
            this.DatePicker.Name = "DatePicker";
            this.DatePicker.ShowUpDown = true;
            this.DatePicker.Size = new System.Drawing.Size(184, 22);
            this.DatePicker.TabIndex = 9;
            this.DatePicker.ValueChanged += new System.EventHandler(this.DatePicker_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.label2.ForeColor = System.Drawing.Color.Crimson;
            this.label2.Location = new System.Drawing.Point(148, 127);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(12, 13);
            this.label2.TabIndex = 45;
            this.label2.Text = "*";
            this.label2.Visible = false;
            // 
            // DateLbl
            // 
            this.DateLbl.AutoSize = true;
            this.DateLbl.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.DateLbl.Location = new System.Drawing.Point(3, 127);
            this.DateLbl.Name = "DateLbl";
            this.DateLbl.Size = new System.Drawing.Size(31, 13);
            this.DateLbl.TabIndex = 46;
            this.DateLbl.Text = "Date";
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
            this.PurInv_dataGridView.Size = new System.Drawing.Size(600, 277);
            this.PurInv_dataGridView.TabIndex = 7;
            // 
            // PInvAmontPanel
            // 
            this.PInvAmontPanel.Controls.Add(this.GrandTableLayout);
            this.PInvAmontPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PInvAmontPanel.Location = new System.Drawing.Point(0, 383);
            this.PInvAmontPanel.Name = "PInvAmontPanel";
            this.PInvAmontPanel.Size = new System.Drawing.Size(600, 67);
            this.PInvAmontPanel.TabIndex = 8;
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
            this.GrandTableLayout.Size = new System.Drawing.Size(600, 67);
            this.GrandTableLayout.TabIndex = 8;
            // 
            // GrossAmtPrzTxt
            // 
            this.GrossAmtPrzTxt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GrossAmtPrzTxt.Font = new System.Drawing.Font("Segoe UI", 18F);
            this.GrossAmtPrzTxt.Location = new System.Drawing.Point(303, 0);
            this.GrossAmtPrzTxt.Name = "GrossAmtPrzTxt";
            this.GrossAmtPrzTxt.Size = new System.Drawing.Size(294, 67);
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
            this.GrossAmtTxtLabl.Size = new System.Drawing.Size(294, 67);
            this.GrossAmtTxtLabl.TabIndex = 1;
            this.GrossAmtTxtLabl.Text = "Total Amount";
            this.GrossAmtTxtLabl.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // ProIdGv
            // 
            this.ProIdGv.HeaderText = "ID";
            this.ProIdGv.Name = "ProIdGv";
            this.ProIdGv.ReadOnly = true;
            this.ProIdGv.Visible = false;
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
            // purchuaseInvoiceDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Name = "purchuaseInvoiceDetails";
            this.Text = "purchuaseInvoiceDetails";
            this.Load += new System.EventHandler(this.purchuaseInvoiceDetails_Load);
            this.LeftPanel.ResumeLayout(false);
            this.LeftPanel.PerformLayout();
            this.rightPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.BackBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PurInv_dataGridView)).EndInit();
            this.PInvAmontPanel.ResumeLayout(false);
            this.GrandTableLayout.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ComboBox CompanyDD;
        private System.Windows.Forms.Label CompanyErrorLbl;
        private System.Windows.Forms.Label StatusLbl;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label DateLbl;
        private System.Windows.Forms.DateTimePicker DatePicker;
        private System.Windows.Forms.DataGridView PurInv_dataGridView;
        private System.Windows.Forms.Panel PInvAmontPanel;
        private System.Windows.Forms.TableLayoutPanel GrandTableLayout;
        private System.Windows.Forms.Label GrossAmtPrzTxt;
        private System.Windows.Forms.Label GrossAmtTxtLabl;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProIdGv;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductGv;
        private System.Windows.Forms.DataGridViewTextBoxColumn PrizePUGv;
        private System.Windows.Forms.DataGridViewTextBoxColumn QtyGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalAmtGv;
        private System.Windows.Forms.DataGridViewButtonColumn DeleteGv;
    }
}