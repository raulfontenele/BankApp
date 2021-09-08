
namespace BankApp.View
{
    partial class RegistrationForm
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
            this.panelLogin = new System.Windows.Forms.Panel();
            this.lbConfPassword = new System.Windows.Forms.Label();
            this.txBoxConfPassword = new System.Windows.Forms.TextBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.lbPassword = new System.Windows.Forms.Label();
            this.txBoxPassword = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.txBoxLastName = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbCPF = new System.Windows.Forms.Label();
            this.lbFristName = new System.Windows.Forms.Label();
            this.txBoxFirstName = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txBoxCPF = new System.Windows.Forms.TextBox();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnRegister = new System.Windows.Forms.Button();
            this.iconBank = new FontAwesome.Sharp.IconPictureBox();
            this.pnLine = new System.Windows.Forms.Panel();
            this.panelLogin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconBank)).BeginInit();
            this.SuspendLayout();
            // 
            // panelLogin
            // 
            this.panelLogin.Controls.Add(this.lbConfPassword);
            this.panelLogin.Controls.Add(this.txBoxConfPassword);
            this.panelLogin.Controls.Add(this.panel4);
            this.panelLogin.Controls.Add(this.lbPassword);
            this.panelLogin.Controls.Add(this.txBoxPassword);
            this.panelLogin.Controls.Add(this.panel3);
            this.panelLogin.Controls.Add(this.label1);
            this.panelLogin.Controls.Add(this.txBoxLastName);
            this.panelLogin.Controls.Add(this.panel1);
            this.panelLogin.Controls.Add(this.lbCPF);
            this.panelLogin.Controls.Add(this.lbFristName);
            this.panelLogin.Controls.Add(this.txBoxFirstName);
            this.panelLogin.Controls.Add(this.panel2);
            this.panelLogin.Controls.Add(this.txBoxCPF);
            this.panelLogin.Controls.Add(this.btnBack);
            this.panelLogin.Controls.Add(this.btnRegister);
            this.panelLogin.Controls.Add(this.iconBank);
            this.panelLogin.Controls.Add(this.pnLine);
            this.panelLogin.Location = new System.Drawing.Point(208, 38);
            this.panelLogin.Name = "panelLogin";
            this.panelLogin.Size = new System.Drawing.Size(450, 598);
            this.panelLogin.TabIndex = 9;
            // 
            // lbConfPassword
            // 
            this.lbConfPassword.AutoSize = true;
            this.lbConfPassword.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbConfPassword.Font = new System.Drawing.Font("Comic Sans MS", 11F, System.Drawing.FontStyle.Bold);
            this.lbConfPassword.ForeColor = System.Drawing.Color.DarkCyan;
            this.lbConfPassword.Location = new System.Drawing.Point(68, 372);
            this.lbConfPassword.Name = "lbConfPassword";
            this.lbConfPassword.Size = new System.Drawing.Size(152, 21);
            this.lbConfPassword.TabIndex = 24;
            this.lbConfPassword.Text = "Confirmação senha:";
            // 
            // txBoxConfPassword
            // 
            this.txBoxConfPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(22)))), ((int)(((byte)(38)))));
            this.txBoxConfPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txBoxConfPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txBoxConfPassword.ForeColor = System.Drawing.SystemColors.Control;
            this.txBoxConfPassword.Location = new System.Drawing.Point(219, 361);
            this.txBoxConfPassword.MaxLength = 20;
            this.txBoxConfPassword.Multiline = true;
            this.txBoxConfPassword.Name = "txBoxConfPassword";
            this.txBoxConfPassword.PasswordChar = '*';
            this.txBoxConfPassword.Size = new System.Drawing.Size(178, 29);
            this.txBoxConfPassword.TabIndex = 23;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.DarkCyan;
            this.panel4.ForeColor = System.Drawing.Color.Transparent;
            this.panel4.Location = new System.Drawing.Point(134, 392);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(263, 1);
            this.panel4.TabIndex = 22;
            // 
            // lbPassword
            // 
            this.lbPassword.AutoSize = true;
            this.lbPassword.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbPassword.Font = new System.Drawing.Font("Comic Sans MS", 11F, System.Drawing.FontStyle.Bold);
            this.lbPassword.ForeColor = System.Drawing.Color.DarkCyan;
            this.lbPassword.Location = new System.Drawing.Point(68, 322);
            this.lbPassword.Name = "lbPassword";
            this.lbPassword.Size = new System.Drawing.Size(60, 21);
            this.lbPassword.TabIndex = 21;
            this.lbPassword.Text = "Senha:";
            // 
            // txBoxPassword
            // 
            this.txBoxPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(22)))), ((int)(((byte)(38)))));
            this.txBoxPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txBoxPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txBoxPassword.ForeColor = System.Drawing.SystemColors.Control;
            this.txBoxPassword.Location = new System.Drawing.Point(134, 311);
            this.txBoxPassword.MaxLength = 20;
            this.txBoxPassword.Multiline = true;
            this.txBoxPassword.Name = "txBoxPassword";
            this.txBoxPassword.PasswordChar = '*';
            this.txBoxPassword.Size = new System.Drawing.Size(270, 29);
            this.txBoxPassword.TabIndex = 20;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.DarkCyan;
            this.panel3.ForeColor = System.Drawing.Color.Transparent;
            this.panel3.Location = new System.Drawing.Point(134, 342);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(263, 1);
            this.panel3.TabIndex = 19;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 11F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.DarkCyan;
            this.label1.Location = new System.Drawing.Point(68, 214);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 21);
            this.label1.TabIndex = 18;
            this.label1.Text = "Sobrenome:";
            // 
            // txBoxLastName
            // 
            this.txBoxLastName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(22)))), ((int)(((byte)(38)))));
            this.txBoxLastName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txBoxLastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txBoxLastName.ForeColor = System.Drawing.SystemColors.Control;
            this.txBoxLastName.Location = new System.Drawing.Point(160, 203);
            this.txBoxLastName.MaxLength = 30;
            this.txBoxLastName.Multiline = true;
            this.txBoxLastName.Name = "txBoxLastName";
            this.txBoxLastName.Size = new System.Drawing.Size(244, 29);
            this.txBoxLastName.TabIndex = 17;
            this.txBoxLastName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbBoxLastName_KeyPress);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkCyan;
            this.panel1.ForeColor = System.Drawing.Color.Transparent;
            this.panel1.Location = new System.Drawing.Point(134, 234);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(263, 1);
            this.panel1.TabIndex = 16;
            // 
            // lbCPF
            // 
            this.lbCPF.AutoSize = true;
            this.lbCPF.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbCPF.Font = new System.Drawing.Font("Comic Sans MS", 11F, System.Drawing.FontStyle.Bold);
            this.lbCPF.ForeColor = System.Drawing.Color.DarkCyan;
            this.lbCPF.Location = new System.Drawing.Point(68, 268);
            this.lbCPF.Name = "lbCPF";
            this.lbCPF.Size = new System.Drawing.Size(43, 21);
            this.lbCPF.TabIndex = 15;
            this.lbCPF.Text = "CPF:";
            // 
            // lbFristName
            // 
            this.lbFristName.AutoSize = true;
            this.lbFristName.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbFristName.Font = new System.Drawing.Font("Comic Sans MS", 11F, System.Drawing.FontStyle.Bold);
            this.lbFristName.ForeColor = System.Drawing.Color.DarkCyan;
            this.lbFristName.Location = new System.Drawing.Point(68, 158);
            this.lbFristName.Name = "lbFristName";
            this.lbFristName.Size = new System.Drawing.Size(57, 21);
            this.lbFristName.TabIndex = 14;
            this.lbFristName.Text = "Nome:";
            // 
            // txBoxFirstName
            // 
            this.txBoxFirstName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(22)))), ((int)(((byte)(38)))));
            this.txBoxFirstName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txBoxFirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txBoxFirstName.ForeColor = System.Drawing.SystemColors.Control;
            this.txBoxFirstName.Location = new System.Drawing.Point(134, 147);
            this.txBoxFirstName.MaxLength = 30;
            this.txBoxFirstName.Multiline = true;
            this.txBoxFirstName.Name = "txBoxFirstName";
            this.txBoxFirstName.Size = new System.Drawing.Size(270, 29);
            this.txBoxFirstName.TabIndex = 13;
            this.txBoxFirstName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txBoxFirstName_KeyPress);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DarkCyan;
            this.panel2.ForeColor = System.Drawing.Color.Transparent;
            this.panel2.Location = new System.Drawing.Point(134, 178);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(263, 1);
            this.panel2.TabIndex = 12;
            // 
            // txBoxCPF
            // 
            this.txBoxCPF.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(22)))), ((int)(((byte)(38)))));
            this.txBoxCPF.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txBoxCPF.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txBoxCPF.ForeColor = System.Drawing.SystemColors.Control;
            this.txBoxCPF.Location = new System.Drawing.Point(134, 257);
            this.txBoxCPF.MaxLength = 11;
            this.txBoxCPF.Multiline = true;
            this.txBoxCPF.Name = "txBoxCPF";
            this.txBoxCPF.Size = new System.Drawing.Size(270, 29);
            this.txBoxCPF.TabIndex = 11;
            this.txBoxCPF.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txBoxCPF_KeyPress);
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.DarkCyan;
            this.btnBack.FlatAppearance.BorderSize = 0;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.Font = new System.Drawing.Font("Comic Sans MS", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.ForeColor = System.Drawing.SystemColors.Control;
            this.btnBack.Location = new System.Drawing.Point(100, 519);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(263, 44);
            this.btnBack.TabIndex = 10;
            this.btnBack.Text = "Voltar";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnRegister
            // 
            this.btnRegister.BackColor = System.Drawing.Color.DarkCyan;
            this.btnRegister.FlatAppearance.BorderSize = 0;
            this.btnRegister.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegister.Font = new System.Drawing.Font("Comic Sans MS", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegister.ForeColor = System.Drawing.SystemColors.Control;
            this.btnRegister.Location = new System.Drawing.Point(100, 444);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(263, 44);
            this.btnRegister.TabIndex = 9;
            this.btnRegister.Text = "Cadastrar";
            this.btnRegister.UseVisualStyleBackColor = false;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // iconBank
            // 
            this.iconBank.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(22)))), ((int)(((byte)(38)))));
            this.iconBank.ForeColor = System.Drawing.Color.DarkCyan;
            this.iconBank.IconChar = FontAwesome.Sharp.IconChar.Bitcoin;
            this.iconBank.IconColor = System.Drawing.Color.DarkCyan;
            this.iconBank.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconBank.IconSize = 91;
            this.iconBank.Location = new System.Drawing.Point(173, 17);
            this.iconBank.Name = "iconBank";
            this.iconBank.Size = new System.Drawing.Size(91, 91);
            this.iconBank.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.iconBank.TabIndex = 8;
            this.iconBank.TabStop = false;
            // 
            // pnLine
            // 
            this.pnLine.BackColor = System.Drawing.Color.DarkCyan;
            this.pnLine.ForeColor = System.Drawing.Color.Transparent;
            this.pnLine.Location = new System.Drawing.Point(134, 288);
            this.pnLine.Name = "pnLine";
            this.pnLine.Size = new System.Drawing.Size(263, 1);
            this.pnLine.TabIndex = 4;
            // 
            // RegistrationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(22)))), ((int)(((byte)(38)))));
            this.ClientSize = new System.Drawing.Size(889, 690);
            this.Controls.Add(this.panelLogin);
            this.Name = "RegistrationForm";
            this.Text = "RegistrationForm";
            this.panelLogin.ResumeLayout(false);
            this.panelLogin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconBank)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelLogin;
        private System.Windows.Forms.Label lbFristName;
        private System.Windows.Forms.TextBox txBoxFirstName;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txBoxCPF;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnRegister;
        private FontAwesome.Sharp.IconPictureBox iconBank;
        private System.Windows.Forms.Panel pnLine;
        private System.Windows.Forms.Label lbConfPassword;
        private System.Windows.Forms.TextBox txBoxConfPassword;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label lbPassword;
        private System.Windows.Forms.TextBox txBoxPassword;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txBoxLastName;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbCPF;
    }
}