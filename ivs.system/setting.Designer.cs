
using System;

namespace ivs.system
{
    partial class setting
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
            this.label3 = new System.Windows.Forms.Label();
            this.ServerTexbox = new System.Windows.Forms.TextBox();
            this.DbTexBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.uname = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.pwdTexbox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.intS = new System.Windows.Forms.CheckBox();
            this.SaveBtn = new System.Windows.Forms.Button();
            this.LeftPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // leftPanel
            // 
            this.LeftPanel.Controls.Add(this.SaveBtn);
            this.LeftPanel.Controls.Add(this.intS);
            this.LeftPanel.Controls.Add(this.pwdTexbox);
            this.LeftPanel.Controls.Add(this.label6);
            this.LeftPanel.Controls.Add(this.uname);
            this.LeftPanel.Controls.Add(this.label5);
            this.LeftPanel.Controls.Add(this.DbTexBox);
            this.LeftPanel.Controls.Add(this.label4);
            this.LeftPanel.Controls.Add(this.ServerTexbox);
            this.LeftPanel.Controls.Add(this.label3);
            this.LeftPanel.Size = new System.Drawing.Size(200, 749);
            this.LeftPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.leftPanel_Paint);
            this.LeftPanel.Controls.SetChildIndex(this.label3, 0);
            this.LeftPanel.Controls.SetChildIndex(this.ServerTexbox, 0);
            this.LeftPanel.Controls.SetChildIndex(this.label4, 0);
            this.LeftPanel.Controls.SetChildIndex(this.DbTexBox, 0);
            this.LeftPanel.Controls.SetChildIndex(this.label5, 0);
            this.LeftPanel.Controls.SetChildIndex(this.uname, 0);
            this.LeftPanel.Controls.SetChildIndex(this.label6, 0);
            this.LeftPanel.Controls.SetChildIndex(this.pwdTexbox, 0);
            this.LeftPanel.Controls.SetChildIndex(this.intS, 0);
            this.LeftPanel.Controls.SetChildIndex(this.SaveBtn, 0);
            // 
            
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 139);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 21);
            this.label3.TabIndex = 1;
            this.label3.Text = "Server";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // ServerTexbox
            // 
            this.ServerTexbox.Location = new System.Drawing.Point(7, 163);
            this.ServerTexbox.MaxLength = 50;
            this.ServerTexbox.Name = "ServerTexbox";
            this.ServerTexbox.Size = new System.Drawing.Size(182, 29);
            this.ServerTexbox.TabIndex = 2;
            // 
            // DbTexBox
            // 
            this.DbTexBox.Location = new System.Drawing.Point(7, 216);
            this.DbTexBox.MaxLength = 50;
            this.DbTexBox.Name = "DbTexBox";
            this.DbTexBox.Size = new System.Drawing.Size(182, 29);
            this.DbTexBox.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 192);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 21);
            this.label4.TabIndex = 3;
            this.label4.Text = "Database";
            // 
            // uname
            // 
            this.uname.Location = new System.Drawing.Point(7, 272);
            this.uname.MaxLength = 50;
            this.uname.Name = "uname";
            this.uname.Size = new System.Drawing.Size(182, 29);
            this.uname.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 248);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 21);
            this.label5.TabIndex = 5;
            this.label5.Text = "Username";
            // 
            // pwdTexbox
            // 
            this.pwdTexbox.Location = new System.Drawing.Point(7, 328);
            this.pwdTexbox.MaxLength = 50;
            this.pwdTexbox.Name = "pwdTexbox";
            this.pwdTexbox.Size = new System.Drawing.Size(182, 29);
            this.pwdTexbox.TabIndex = 8;
            this.pwdTexbox.UseSystemPasswordChar = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(3, 304);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(76, 21);
            this.label6.TabIndex = 7;
            this.label6.Text = "Password";
            // 
            // intS
            // 
            this.intS.AutoSize = true;
            this.intS.Location = new System.Drawing.Point(7, 363);
            this.intS.Name = "intS";
            this.intS.Size = new System.Drawing.Size(155, 25);
            this.intS.TabIndex = 9;
            this.intS.Text = "intergrate security";
            this.intS.UseVisualStyleBackColor = true;
            this.intS.CheckedChanged += new System.EventHandler(this.intS_CheckedChange);
            // 
            // SaveBtn
            // 
            this.SaveBtn.FlatAppearance.BorderSize = 2;
            this.SaveBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SaveBtn.Location = new System.Drawing.Point(7, 394);
            this.SaveBtn.Name = "SaveBtn";
            this.SaveBtn.Size = new System.Drawing.Size(182, 47);
            this.SaveBtn.TabIndex = 10;
            this.SaveBtn.Text = "Save";
            this.SaveBtn.UseVisualStyleBackColor = true;
            this.SaveBtn.Click += new System.EventHandler(this.SaveBtn_Click);
            // 
            // setting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 749);
            this.Name = "setting";
            this.Text = "setting";
            this.LeftPanel.ResumeLayout(false);
            this.LeftPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox ServerTexbox;
        private System.Windows.Forms.Button SaveBtn;
        private System.Windows.Forms.CheckBox intS;
        private System.Windows.Forms.TextBox pwdTexbox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox uname;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox DbTexBox;
        private System.Windows.Forms.Label label4;
    }
}