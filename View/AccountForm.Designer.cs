
namespace BankApp.View
{
    partial class AccountForm
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
            this.panelMenu = new System.Windows.Forms.Panel();
            this.btnInvest = new FontAwesome.Sharp.IconButton();
            this.btnRemove = new FontAwesome.Sharp.IconButton();
            this.btnExtract = new FontAwesome.Sharp.IconButton();
            this.contentPanel = new System.Windows.Forms.Panel();
            this.btnTransfer = new FontAwesome.Sharp.IconButton();
            this.panelMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.panelMenu.Controls.Add(this.btnTransfer);
            this.panelMenu.Controls.Add(this.btnInvest);
            this.panelMenu.Controls.Add(this.btnRemove);
            this.panelMenu.Controls.Add(this.btnExtract);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(228, 500);
            this.panelMenu.TabIndex = 5;
            // 
            // btnInvest
            // 
            this.btnInvest.FlatAppearance.BorderSize = 0;
            this.btnInvest.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInvest.Font = new System.Drawing.Font("NSimSun", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInvest.ForeColor = System.Drawing.Color.DarkCyan;
            this.btnInvest.IconChar = FontAwesome.Sharp.IconChar.University;
            this.btnInvest.IconColor = System.Drawing.Color.DarkCyan;
            this.btnInvest.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnInvest.IconSize = 40;
            this.btnInvest.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnInvest.Location = new System.Drawing.Point(0, 201);
            this.btnInvest.Margin = new System.Windows.Forms.Padding(0);
            this.btnInvest.Name = "btnInvest";
            this.btnInvest.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btnInvest.Size = new System.Drawing.Size(228, 99);
            this.btnInvest.TabIndex = 6;
            this.btnInvest.Text = "Investimento";
            this.btnInvest.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnInvest.UseVisualStyleBackColor = true;
            // 
            // btnRemove
            // 
            this.btnRemove.FlatAppearance.BorderSize = 0;
            this.btnRemove.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemove.Font = new System.Drawing.Font("NSimSun", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemove.ForeColor = System.Drawing.Color.DarkCyan;
            this.btnRemove.IconChar = FontAwesome.Sharp.IconChar.MoneyBill;
            this.btnRemove.IconColor = System.Drawing.Color.DarkCyan;
            this.btnRemove.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnRemove.IconSize = 40;
            this.btnRemove.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRemove.Location = new System.Drawing.Point(0, 0);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.btnRemove.Size = new System.Drawing.Size(228, 99);
            this.btnRemove.TabIndex = 5;
            this.btnRemove.Text = "Saque";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // btnExtract
            // 
            this.btnExtract.FlatAppearance.BorderSize = 0;
            this.btnExtract.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExtract.Font = new System.Drawing.Font("NSimSun", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExtract.ForeColor = System.Drawing.Color.DarkCyan;
            this.btnExtract.IconChar = FontAwesome.Sharp.IconChar.FileAlt;
            this.btnExtract.IconColor = System.Drawing.Color.DarkCyan;
            this.btnExtract.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnExtract.IconSize = 40;
            this.btnExtract.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExtract.Location = new System.Drawing.Point(0, 105);
            this.btnExtract.Name = "btnExtract";
            this.btnExtract.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btnExtract.Size = new System.Drawing.Size(228, 99);
            this.btnExtract.TabIndex = 4;
            this.btnExtract.Text = "Extrato";
            this.btnExtract.UseVisualStyleBackColor = true;
            this.btnExtract.Click += new System.EventHandler(this.btnExtract_Click);
            // 
            // contentPanel
            // 
            this.contentPanel.AutoSize = true;
            this.contentPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.contentPanel.Location = new System.Drawing.Point(228, 0);
            this.contentPanel.Name = "contentPanel";
            this.contentPanel.Size = new System.Drawing.Size(745, 500);
            this.contentPanel.TabIndex = 6;
            // 
            // btnTransfer
            // 
            this.btnTransfer.FlatAppearance.BorderSize = 0;
            this.btnTransfer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTransfer.Font = new System.Drawing.Font("NSimSun", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTransfer.ForeColor = System.Drawing.Color.DarkCyan;
            this.btnTransfer.IconChar = FontAwesome.Sharp.IconChar.ExchangeAlt;
            this.btnTransfer.IconColor = System.Drawing.Color.DarkCyan;
            this.btnTransfer.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnTransfer.IconSize = 40;
            this.btnTransfer.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTransfer.Location = new System.Drawing.Point(0, 300);
            this.btnTransfer.Margin = new System.Windows.Forms.Padding(0);
            this.btnTransfer.Name = "btnTransfer";
            this.btnTransfer.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btnTransfer.Size = new System.Drawing.Size(228, 99);
            this.btnTransfer.TabIndex = 7;
            this.btnTransfer.Text = "Transferência";
            this.btnTransfer.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnTransfer.UseVisualStyleBackColor = true;
            // 
            // AccountForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(973, 500);
            this.Controls.Add(this.contentPanel);
            this.Controls.Add(this.panelMenu);
            this.Name = "AccountForm";
            this.Text = "AccontForm";
            this.Load += new System.EventHandler(this.AccountForm_Load);
            this.panelMenu.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelMenu;
        private FontAwesome.Sharp.IconButton btnRemove;
        private FontAwesome.Sharp.IconButton btnExtract;
        private System.Windows.Forms.Panel contentPanel;
        private FontAwesome.Sharp.IconButton btnInvest;
        private FontAwesome.Sharp.IconButton btnTransfer;
    }
}