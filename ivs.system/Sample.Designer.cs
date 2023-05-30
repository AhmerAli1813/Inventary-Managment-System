
namespace ivs.system
{
    partial class Sample
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
            this.LeftPanel = new System.Windows.Forms.Panel();
            this.LeftTopPanel = new System.Windows.Forms.Panel();
            this.BackBtn = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.rightPanel = new System.Windows.Forms.Panel();
            this.RightTopPanel = new System.Windows.Forms.Panel();
            this.WlcUserLbl = new System.Windows.Forms.Label();
            this.LeftPanel.SuspendLayout();
            this.LeftTopPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BackBtn)).BeginInit();
            this.rightPanel.SuspendLayout();
            this.RightTopPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // LeftPanel
            // 
            this.LeftPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.LeftPanel.Controls.Add(this.LeftTopPanel);
            this.LeftPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.LeftPanel.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LeftPanel.ForeColor = System.Drawing.Color.White;
            this.LeftPanel.Location = new System.Drawing.Point(0, 0);
            this.LeftPanel.Margin = new System.Windows.Forms.Padding(0);
            this.LeftPanel.Name = "LeftPanel";
            this.LeftPanel.Size = new System.Drawing.Size(200, 450);
            this.LeftPanel.TabIndex = 0;
            // 
            // LeftTopPanel
            // 
            this.LeftTopPanel.Controls.Add(this.BackBtn);
            this.LeftTopPanel.Controls.Add(this.label1);
            this.LeftTopPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.LeftTopPanel.Location = new System.Drawing.Point(0, 0);
            this.LeftTopPanel.Name = "LeftTopPanel";
            this.LeftTopPanel.Size = new System.Drawing.Size(200, 56);
            this.LeftTopPanel.TabIndex = 0;
            // 
            // BackBtn
            // 
            this.BackBtn.Image = global::ivs.system.Properties.Resources.backBtn;
            this.BackBtn.Location = new System.Drawing.Point(2, 3);
            this.BackBtn.Name = "BackBtn";
            this.BackBtn.Size = new System.Drawing.Size(56, 50);
            this.BackBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.BackBtn.TabIndex = 1;
            this.BackBtn.TabStop = false;
            this.BackBtn.Click += new System.EventHandler(this.BackBtn_Click);
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Right;
            this.label1.Location = new System.Drawing.Point(64, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 56);
            this.label1.TabIndex = 0;
            this.label1.Text = "Welcome";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // rightPanel
            // 
            this.rightPanel.Controls.Add(this.RightTopPanel);
            this.rightPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rightPanel.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rightPanel.Location = new System.Drawing.Point(200, 0);
            this.rightPanel.Margin = new System.Windows.Forms.Padding(0);
            this.rightPanel.Name = "rightPanel";
            this.rightPanel.Size = new System.Drawing.Size(600, 450);
            this.rightPanel.TabIndex = 1;
            // 
            // RightTopPanel
            // 
            this.RightTopPanel.Controls.Add(this.WlcUserLbl);
            this.RightTopPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.RightTopPanel.Location = new System.Drawing.Point(0, 0);
            this.RightTopPanel.Name = "RightTopPanel";
            this.RightTopPanel.Size = new System.Drawing.Size(600, 56);
            this.RightTopPanel.TabIndex = 0;
            // 
            // WlcUserLbl
            // 
            this.WlcUserLbl.Dock = System.Windows.Forms.DockStyle.Left;
            this.WlcUserLbl.Location = new System.Drawing.Point(0, 0);
            this.WlcUserLbl.Name = "WlcUserLbl";
            this.WlcUserLbl.Size = new System.Drawing.Size(73, 56);
            this.WlcUserLbl.TabIndex = 0;
            this.WlcUserLbl.Text = "User";
            this.WlcUserLbl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Sample
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.ControlBox = false;
            this.Controls.Add(this.rightPanel);
            this.Controls.Add(this.LeftPanel);
            this.Name = "Sample";
            this.LeftPanel.ResumeLayout(false);
            this.LeftTopPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.BackBtn)).EndInit();
            this.rightPanel.ResumeLayout(false);
            this.RightTopPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        protected System.Windows.Forms.Panel LeftPanel;
        private System.Windows.Forms.Panel LeftTopPanel;
        private System.Windows.Forms.Label label1;
        protected System.Windows.Forms.Panel rightPanel;
        private System.Windows.Forms.Panel RightTopPanel;
        protected System.Windows.Forms.Label WlcUserLbl;
        public System.Windows.Forms.PictureBox BackBtn;
    }
}