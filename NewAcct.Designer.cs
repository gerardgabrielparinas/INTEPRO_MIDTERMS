
namespace Parinas___INTEPRO_MidtermMP
{
    partial class NewAcct
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtNewUName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNewPWD = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtConfirmPWD = new System.Windows.Forms.TextBox();
            this.btnNewAcct = new System.Windows.Forms.Button();
            this.btnReturn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(20, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(178, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "ENTER A USERNAME :";
            // 
            // txtNewUName
            // 
            this.txtNewUName.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtNewUName.Location = new System.Drawing.Point(204, 19);
            this.txtNewUName.Name = "txtNewUName";
            this.txtNewUName.Size = new System.Drawing.Size(259, 30);
            this.txtNewUName.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(20, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(184, 23);
            this.label2.TabIndex = 2;
            this.label2.Text = "ENTER A PASSWORD : ";
            // 
            // txtNewPWD
            // 
            this.txtNewPWD.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtNewPWD.Location = new System.Drawing.Point(204, 67);
            this.txtNewPWD.Name = "txtNewPWD";
            this.txtNewPWD.PasswordChar = '*';
            this.txtNewPWD.Size = new System.Drawing.Size(259, 30);
            this.txtNewPWD.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(12, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(193, 23);
            this.label3.TabIndex = 4;
            this.label3.Text = "CONFIRM PASSWORD : ";
            // 
            // txtConfirmPWD
            // 
            this.txtConfirmPWD.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtConfirmPWD.Location = new System.Drawing.Point(204, 116);
            this.txtConfirmPWD.Name = "txtConfirmPWD";
            this.txtConfirmPWD.PasswordChar = '*';
            this.txtConfirmPWD.Size = new System.Drawing.Size(259, 30);
            this.txtConfirmPWD.TabIndex = 5;
            // 
            // btnNewAcct
            // 
            this.btnNewAcct.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnNewAcct.Location = new System.Drawing.Point(127, 178);
            this.btnNewAcct.Name = "btnNewAcct";
            this.btnNewAcct.Size = new System.Drawing.Size(240, 29);
            this.btnNewAcct.TabIndex = 6;
            this.btnNewAcct.Text = "ADD ACCOUNT";
            this.btnNewAcct.UseVisualStyleBackColor = true;
            this.btnNewAcct.Click += new System.EventHandler(this.btnNewAcct_Click);
            // 
            // btnReturn
            // 
            this.btnReturn.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnReturn.Location = new System.Drawing.Point(127, 213);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(240, 29);
            this.btnReturn.TabIndex = 7;
            this.btnReturn.Text = "BACK";
            this.btnReturn.UseVisualStyleBackColor = true;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // NewAcct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(533, 281);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.btnNewAcct);
            this.Controls.Add(this.txtConfirmPWD);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtNewPWD);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtNewUName);
            this.Controls.Add(this.label1);
            this.Name = "NewAcct";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add Account";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNewUName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNewPWD;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtConfirmPWD;
        private System.Windows.Forms.Button btnNewAcct;
        private System.Windows.Forms.Button btnReturn;
    }
}