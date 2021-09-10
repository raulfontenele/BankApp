
namespace BankApp.View
{
    partial class LoginForm
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
            this.iconUser = new FontAwesome.Sharp.IconPictureBox();
            this.pnLine = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.iconPassword = new FontAwesome.Sharp.IconPictureBox();
            this.txBoxPassword = new System.Windows.Forms.TextBox();
            this.panelLogin = new System.Windows.Forms.Panel();
            this.txBoxCPF = new System.Windows.Forms.TextBox();
            this.btnCreateAccount = new System.Windows.Forms.Button();
            this.btnLogin = new System.Windows.Forms.Button();
            this.iconBank = new FontAwesome.Sharp.IconPictureBox();
            this.lbCPF = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.iconUser)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPassword)).BeginInit();
            this.panelLogin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconBank)).BeginInit();
            this.SuspendLayout();
            // 
            // iconUser
            // 
            this.iconUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(22)))), ((int)(((byte)(38)))));
            this.iconUser.ForeColor = System.Drawing.Color.DarkCyan;
            this.iconUser.IconChar = FontAwesome.Sharp.IconChar.UserAlt;
            this.iconUser.IconColor = System.Drawing.Color.DarkCyan;
            this.iconUser.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconUser.IconSize = 34;
            this.iconUser.Location = new System.Drawing.Point(72, 174);
            this.iconUser.Name = "iconUser";
            this.iconUser.Size = new System.Drawing.Size(39, 34);
            this.iconUser.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.iconUser.TabIndex = 3;
            this.iconUser.TabStop = false;
            // 
            // pnLine
            // 
            this.pnLine.BackColor = System.Drawing.Color.DarkCyan;
            this.pnLine.ForeColor = System.Drawing.Color.Transparent;
            this.pnLine.Location = new System.Drawing.Point(72, 214);
            this.pnLine.Name = "pnLine";
            this.pnLine.Size = new System.Drawing.Size(263, 1);
            this.pnLine.TabIndex = 4;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkCyan;
            this.panel1.ForeColor = System.Drawing.Color.Transparent;
            this.panel1.Location = new System.Drawing.Point(72, 303);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(263, 1);
            this.panel1.TabIndex = 7;
            // 
            // iconPassword
            // 
            this.iconPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(22)))), ((int)(((byte)(38)))));
            this.iconPassword.ForeColor = System.Drawing.Color.DarkCyan;
            this.iconPassword.IconChar = FontAwesome.Sharp.IconChar.Lock;
            this.iconPassword.IconColor = System.Drawing.Color.DarkCyan;
            this.iconPassword.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPassword.IconSize = 34;
            this.iconPassword.Location = new System.Drawing.Point(72, 263);
            this.iconPassword.Name = "iconPassword";
            this.iconPassword.Size = new System.Drawing.Size(39, 34);
            this.iconPassword.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.iconPassword.TabIndex = 6;
            this.iconPassword.TabStop = false;
            // 
            // txBoxPassword
            // 
            this.txBoxPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(22)))), ((int)(((byte)(38)))));
            this.txBoxPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txBoxPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txBoxPassword.ForeColor = System.Drawing.SystemColors.Control;
            this.txBoxPassword.Location = new System.Drawing.Point(110, 268);
            this.txBoxPassword.MaxLength = 20;
            this.txBoxPassword.Multiline = true;
            this.txBoxPassword.Name = "txBoxPassword";
            this.txBoxPassword.PasswordChar = '*';
            this.txBoxPassword.Size = new System.Drawing.Size(225, 29);
            this.txBoxPassword.TabIndex = 5;
            // 
            // panelLogin
            // 
            this.panelLogin.Controls.Add(this.lbCPF);
            this.panelLogin.Controls.Add(this.txBoxCPF);
            this.panelLogin.Controls.Add(this.btnCreateAccount);
            this.panelLogin.Controls.Add(this.btnLogin);
            this.panelLogin.Controls.Add(this.iconBank);
            this.panelLogin.Controls.Add(this.panel1);
            this.panelLogin.Controls.Add(this.iconPassword);
            this.panelLogin.Controls.Add(this.txBoxPassword);
            this.panelLogin.Controls.Add(this.pnLine);
            this.panelLogin.Controls.Add(this.iconUser);
            this.panelLogin.Location = new System.Drawing.Point(242, 26);
            this.panelLogin.Name = "panelLogin";
            this.panelLogin.Size = new System.Drawing.Size(426, 527);
            this.panelLogin.TabIndex = 8;
            // 
            // txBoxCPF
            // 
            this.txBoxCPF.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(22)))), ((int)(((byte)(38)))));
            this.txBoxCPF.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txBoxCPF.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txBoxCPF.ForeColor = System.Drawing.SystemColors.Control;
            this.txBoxCPF.Location = new System.Drawing.Point(117, 179);
            this.txBoxCPF.MaxLength = 11;
            this.txBoxCPF.Multiline = true;
            this.txBoxCPF.Name = "txBoxCPF";
            this.txBoxCPF.Size = new System.Drawing.Size(225, 29);
            this.txBoxCPF.TabIndex = 11;
            this.txBoxCPF.TextChanged += new System.EventHandler(this.txBoxCPF_TextChanged);
            this.txBoxCPF.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txBoxCPF_KeyPress);
            // 
            // btnCreateAccount
            // 
            this.btnCreateAccount.BackColor = System.Drawing.Color.DarkCyan;
            this.btnCreateAccount.FlatAppearance.BorderSize = 0;
            this.btnCreateAccount.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCreateAccount.Font = new System.Drawing.Font("Comic Sans MS", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreateAccount.ForeColor = System.Drawing.SystemColors.Control;
            this.btnCreateAccount.Location = new System.Drawing.Point(72, 415);
            this.btnCreateAccount.Name = "btnCreateAccount";
            this.btnCreateAccount.Size = new System.Drawing.Size(263, 44);
            this.btnCreateAccount.TabIndex = 10;
            this.btnCreateAccount.Text = "Criar Conta";
            this.btnCreateAccount.UseVisualStyleBackColor = false;
            this.btnCreateAccount.Click += new System.EventHandler(this.btnCreateAccount_Click);
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.DarkCyan;
            this.btnLogin.FlatAppearance.BorderSize = 0;
            this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogin.Font = new System.Drawing.Font("Comic Sans MS", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.ForeColor = System.Drawing.SystemColors.Control;
            this.btnLogin.Location = new System.Drawing.Point(72, 340);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(263, 44);
            this.btnLogin.TabIndex = 9;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // iconBank
            // 
            this.iconBank.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(22)))), ((int)(((byte)(38)))));
            this.iconBank.ForeColor = System.Drawing.Color.DarkCyan;
            this.iconBank.IconChar = FontAwesome.Sharp.IconChar.Bitcoin;
            this.iconBank.IconColor = System.Drawing.Color.DarkCyan;
            this.iconBank.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconBank.IconSize = 91;
            this.iconBank.Location = new System.Drawing.Point(158, 35);
            this.iconBank.Name = "iconBank";
            this.iconBank.Size = new System.Drawing.Size(91, 91);
            this.iconBank.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.iconBank.TabIndex = 8;
            this.iconBank.TabStop = false;
            // 
            // lbCPF
            // 
            this.lbCPF.AutoSize = true;
            this.lbCPF.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCPF.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.lbCPF.Location = new System.Drawing.Point(117, 179);
            this.lbCPF.Name = "lbCPF";
            this.lbCPF.Size = new System.Drawing.Size(38, 23);
            this.lbCPF.TabIndex = 12;
            this.lbCPF.Text = "CPF";
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(22)))), ((int)(((byte)(38)))));
            this.ClientSize = new System.Drawing.Size(881, 612);
            this.Controls.Add(this.panelLogin);
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "LoginForm";
            ((System.ComponentModel.ISupportInitialize)(this.iconUser)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPassword)).EndInit();
            this.panelLogin.ResumeLayout(false);
            this.panelLogin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconBank)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private FontAwesome.Sharp.IconPictureBox iconUser;
        private System.Windows.Forms.Panel pnLine;
        private System.Windows.Forms.Panel panel1;
        private FontAwesome.Sharp.IconPictureBox iconPassword;
        private System.Windows.Forms.TextBox txBoxPassword;
        private System.Windows.Forms.Panel panelLogin;
        private System.Windows.Forms.Button btnLogin;
        private FontAwesome.Sharp.IconPictureBox iconBank;
        private System.Windows.Forms.Button btnCreateAccount;
        private System.Windows.Forms.TextBox txBoxCPF;
        private System.Windows.Forms.Label lbCPF;
    }
}