
namespace BankApp.View
{
    partial class RemovelForm
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
            this.lbBalanceValue = new System.Windows.Forms.Label();
            this.lbBalanceAvailable = new System.Windows.Forms.Label();
            this.txBoxValue = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbBalanceValue
            // 
            this.lbBalanceValue.AutoSize = true;
            this.lbBalanceValue.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbBalanceValue.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbBalanceValue.ForeColor = System.Drawing.Color.DarkCyan;
            this.lbBalanceValue.Location = new System.Drawing.Point(319, 53);
            this.lbBalanceValue.Name = "lbBalanceValue";
            this.lbBalanceValue.Size = new System.Drawing.Size(0, 27);
            this.lbBalanceValue.TabIndex = 0;
            // 
            // lbBalanceAvailable
            // 
            this.lbBalanceAvailable.AutoSize = true;
            this.lbBalanceAvailable.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbBalanceAvailable.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbBalanceAvailable.ForeColor = System.Drawing.Color.DarkCyan;
            this.lbBalanceAvailable.Location = new System.Drawing.Point(147, 53);
            this.lbBalanceAvailable.Name = "lbBalanceAvailable";
            this.lbBalanceAvailable.Size = new System.Drawing.Size(166, 27);
            this.lbBalanceAvailable.TabIndex = 1;
            this.lbBalanceAvailable.Text = "Saldo Disponível:";
            // 
            // txBoxValue
            // 
            this.txBoxValue.Location = new System.Drawing.Point(324, 163);
            this.txBoxValue.Name = "txBoxValue";
            this.txBoxValue.Size = new System.Drawing.Size(100, 20);
            this.txBoxValue.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkCyan;
            this.label1.Location = new System.Drawing.Point(147, 163);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(166, 27);
            this.label1.TabIndex = 3;
            this.label1.Text = "Saldo Disponível:";
            // 
            // btnRemove
            // 
            this.btnRemove.BackColor = System.Drawing.Color.DarkCyan;
            this.btnRemove.FlatAppearance.BorderSize = 0;
            this.btnRemove.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemove.Font = new System.Drawing.Font("Comic Sans MS", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemove.ForeColor = System.Drawing.SystemColors.Control;
            this.btnRemove.Location = new System.Drawing.Point(180, 330);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(263, 44);
            this.btnRemove.TabIndex = 12;
            this.btnRemove.Text = "Sacar";
            this.btnRemove.UseVisualStyleBackColor = false;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.DarkCyan;
            this.btnAdd.FlatAppearance.BorderSize = 0;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Comic Sans MS", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.SystemColors.Control;
            this.btnAdd.Location = new System.Drawing.Point(180, 253);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(263, 44);
            this.btnAdd.TabIndex = 11;
            this.btnAdd.Text = "Adicionar";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // RemovelForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(22)))), ((int)(((byte)(38)))));
            this.ClientSize = new System.Drawing.Size(1149, 643);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txBoxValue);
            this.Controls.Add(this.lbBalanceAvailable);
            this.Controls.Add(this.lbBalanceValue);
            this.Name = "RemovelForm";
            this.Text = "RemovelForm";
            this.Load += new System.EventHandler(this.RemovelForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbBalanceValue;
        private System.Windows.Forms.Label lbBalanceAvailable;
        private System.Windows.Forms.TextBox txBoxValue;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Button btnAdd;
    }
}