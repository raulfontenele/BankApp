
namespace BankApp.View
{
    partial class StatementForm
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
            this.lbBalanceAvailable = new System.Windows.Forms.Label();
            this.lbBalanceValue = new System.Windows.Forms.Label();
            this.gridStatement = new System.Windows.Forms.DataGridView();
            this.btnSearch = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gridStatement)).BeginInit();
            this.SuspendLayout();
            // 
            // lbBalanceAvailable
            // 
            this.lbBalanceAvailable.AutoSize = true;
            this.lbBalanceAvailable.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbBalanceAvailable.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbBalanceAvailable.ForeColor = System.Drawing.Color.DarkCyan;
            this.lbBalanceAvailable.Location = new System.Drawing.Point(45, 42);
            this.lbBalanceAvailable.Name = "lbBalanceAvailable";
            this.lbBalanceAvailable.Size = new System.Drawing.Size(166, 27);
            this.lbBalanceAvailable.TabIndex = 3;
            this.lbBalanceAvailable.Text = "Saldo Disponível:";
            // 
            // lbBalanceValue
            // 
            this.lbBalanceValue.AutoSize = true;
            this.lbBalanceValue.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbBalanceValue.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbBalanceValue.ForeColor = System.Drawing.Color.DarkCyan;
            this.lbBalanceValue.Location = new System.Drawing.Point(217, 42);
            this.lbBalanceValue.Name = "lbBalanceValue";
            this.lbBalanceValue.Size = new System.Drawing.Size(0, 27);
            this.lbBalanceValue.TabIndex = 2;
            // 
            // gridStatement
            // 
            this.gridStatement.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridStatement.Location = new System.Drawing.Point(50, 173);
            this.gridStatement.Name = "gridStatement";
            this.gridStatement.Size = new System.Drawing.Size(542, 222);
            this.gridStatement.TabIndex = 4;
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.DarkCyan;
            this.btnSearch.FlatAppearance.BorderSize = 0;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Font = new System.Drawing.Font("Comic Sans MS", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.ForeColor = System.Drawing.SystemColors.Control;
            this.btnSearch.Location = new System.Drawing.Point(50, 107);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(263, 44);
            this.btnSearch.TabIndex = 12;
            this.btnSearch.Text = "Últimos 3 meses";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // StatementForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(22)))), ((int)(((byte)(38)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.gridStatement);
            this.Controls.Add(this.lbBalanceAvailable);
            this.Controls.Add(this.lbBalanceValue);
            this.Name = "StatementForm";
            this.Text = "StatementForm";
            this.Load += new System.EventHandler(this.StatementForm_Load);
            this.VisibleChanged += new System.EventHandler(this.StatementForm_VisibleChanged);
            ((System.ComponentModel.ISupportInitialize)(this.gridStatement)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lbBalanceAvailable;
        private System.Windows.Forms.Label lbBalanceValue;
        private System.Windows.Forms.DataGridView gridStatement;
        private System.Windows.Forms.Button btnSearch;
    }
}