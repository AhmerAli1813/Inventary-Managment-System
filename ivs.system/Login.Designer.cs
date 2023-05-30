
namespace ivs.system
{
    partial class Login
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
            this.unameTxt = new System.Windows.Forms.TextBox();
            this.unameLbl = new System.Windows.Forms.Label();
            this.PassLbl = new System.Windows.Forms.Label();
            this.PassTxt = new System.Windows.Forms.TextBox();
            this.LoginBtn = new System.Windows.Forms.Button();
            this.unameErrorLbl = new System.Windows.Forms.Label();
            this.PassErrorLbl = new System.Windows.Forms.Label();
            this.LeftPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // LeftPanel
            // 
            this.LeftPanel.AutoScroll = true;
            this.LeftPanel.Controls.Add(this.LoginBtn);
            this.LeftPanel.Controls.Add(this.PassLbl);
            this.LeftPanel.Controls.Add(this.PassTxt);
            this.LeftPanel.Controls.Add(this.unameLbl);
            this.LeftPanel.Controls.Add(this.unameTxt);
            this.LeftPanel.Controls.Add(this.PassErrorLbl);
            this.LeftPanel.Controls.Add(this.unameErrorLbl);
            this.LeftPanel.Size = new System.Drawing.Size(200, 611);
            this.LeftPanel.Controls.SetChildIndex(this.unameErrorLbl, 0);
            this.LeftPanel.Controls.SetChildIndex(this.PassErrorLbl, 0);
            this.LeftPanel.Controls.SetChildIndex(this.unameTxt, 0);
            this.LeftPanel.Controls.SetChildIndex(this.unameLbl, 0);
            this.LeftPanel.Controls.SetChildIndex(this.PassTxt, 0);
            this.LeftPanel.Controls.SetChildIndex(this.PassLbl, 0);
            this.LeftPanel.Controls.SetChildIndex(this.LoginBtn, 0);
            // 
            // rightPanel
            // 
            this.rightPanel.Size = new System.Drawing.Size(738, 611);
            // 
            // unameTxt
            // 
            this.unameTxt.Location = new System.Drawing.Point(3, 140);
            this.unameTxt.MaxLength = 50;
            this.unameTxt.Name = "unameTxt";
            this.unameTxt.Size = new System.Drawing.Size(191, 27);
            this.unameTxt.TabIndex = 1;
            this.unameTxt.Text = "ali";
            this.unameTxt.TextChanged += new System.EventHandler(this.unameTxt_TextChanged);
            // 
            // unameLbl
            // 
            this.unameLbl.AutoSize = true;
            this.unameLbl.Location = new System.Drawing.Point(3, 116);
            this.unameLbl.Name = "unameLbl";
            this.unameLbl.Size = new System.Drawing.Size(75, 20);
            this.unameLbl.TabIndex = 2;
            this.unameLbl.Text = "Username";
            // 
            // PassLbl
            // 
            this.PassLbl.AutoSize = true;
            this.PassLbl.Location = new System.Drawing.Point(0, 175);
            this.PassLbl.Name = "PassLbl";
            this.PassLbl.Size = new System.Drawing.Size(70, 20);
            this.PassLbl.TabIndex = 4;
            this.PassLbl.Text = "Password";
            // 
            // PassTxt
            // 
            this.PassTxt.Location = new System.Drawing.Point(3, 199);
            this.PassTxt.MaxLength = 50;
            this.PassTxt.Name = "PassTxt";
            this.PassTxt.Size = new System.Drawing.Size(191, 27);
            this.PassTxt.TabIndex = 3;
            this.PassTxt.Text = "123";
            this.PassTxt.UseSystemPasswordChar = true;
            this.PassTxt.TextChanged += new System.EventHandler(this.PassTxt_TextChanged);
            // 
            // LoginBtn
            // 
            this.LoginBtn.FlatAppearance.BorderSize = 2;
            this.LoginBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LoginBtn.ForeColor = System.Drawing.Color.White;
            this.LoginBtn.Location = new System.Drawing.Point(3, 234);
            this.LoginBtn.Name = "LoginBtn";
            this.LoginBtn.Size = new System.Drawing.Size(191, 39);
            this.LoginBtn.TabIndex = 5;
            this.LoginBtn.Text = "Login";
            this.LoginBtn.UseVisualStyleBackColor = true;
            this.LoginBtn.Click += new System.EventHandler(this.LoginBtn_Click);
            // 
            // unameErrorLbl
            // 
            this.unameErrorLbl.AutoSize = true;
            this.unameErrorLbl.ForeColor = System.Drawing.Color.Red;
            this.unameErrorLbl.Location = new System.Drawing.Point(93, 116);
            this.unameErrorLbl.Name = "unameErrorLbl";
            this.unameErrorLbl.Size = new System.Drawing.Size(15, 20);
            this.unameErrorLbl.TabIndex = 1;
            this.unameErrorLbl.Text = "*";
            this.unameErrorLbl.Visible = false;
            // 
            // PassErrorLbl
            // 
            this.PassErrorLbl.AutoSize = true;
            this.PassErrorLbl.ForeColor = System.Drawing.Color.Red;
            this.PassErrorLbl.Location = new System.Drawing.Point(76, 176);
            this.PassErrorLbl.Name = "PassErrorLbl";
            this.PassErrorLbl.Size = new System.Drawing.Size(15, 20);
            this.PassErrorLbl.TabIndex = 6;
            this.PassErrorLbl.Text = "*";
            this.PassErrorLbl.Visible = false;
            // 
            // Login
            // 
            this.AcceptButton = this.LoginBtn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(938, 611);
            this.Name = "Login";
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Login_Load);
            this.LeftPanel.ResumeLayout(false);
            this.LeftPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox unameTxt;
        private System.Windows.Forms.Label PassLbl;
        private System.Windows.Forms.TextBox PassTxt;
        private System.Windows.Forms.Label unameLbl;
        private System.Windows.Forms.Label unameErrorLbl;
        private System.Windows.Forms.Label PassErrorLbl;
        protected System.Windows.Forms.Button LoginBtn;
    }
}