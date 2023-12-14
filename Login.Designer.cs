
namespace Parinas___INTEPRO_MidtermMP
{
    partial class Login
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.txtUName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPWD = new System.Windows.Forms.TextBox();
            this.btnLogin = new System.Windows.Forms.Button();
            this.btnRPWD = new System.Windows.Forms.Button();
            this.btnAddAcct = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(37, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "USERNAME :";
            // 
            // txtUName
            // 
            this.txtUName.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtUName.Location = new System.Drawing.Point(160, 36);
            this.txtUName.Name = "txtUName";
            this.txtUName.Size = new System.Drawing.Size(299, 30);
            this.txtUName.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(37, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 23);
            this.label2.TabIndex = 2;
            this.label2.Text = "PASSWORD :";
            // 
            // txtPWD
            // 
            this.txtPWD.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtPWD.Location = new System.Drawing.Point(160, 91);
            this.txtPWD.Name = "txtPWD";
            this.txtPWD.PasswordChar = '*';
            this.txtPWD.Size = new System.Drawing.Size(299, 30);
            this.txtPWD.TabIndex = 3;
            // 
            // btnLogin
            // 
            this.btnLogin.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnLogin.Location = new System.Drawing.Point(128, 146);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(255, 29);
            this.btnLogin.TabIndex = 4;
            this.btnLogin.Text = "LOGIN";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // btnRPWD
            // 
            this.btnRPWD.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnRPWD.Location = new System.Drawing.Point(128, 181);
            this.btnRPWD.Name = "btnRPWD";
            this.btnRPWD.Size = new System.Drawing.Size(255, 29);
            this.btnRPWD.TabIndex = 5;
            this.btnRPWD.Text = "RESET PASSWORD";
            this.btnRPWD.UseVisualStyleBackColor = true;
            this.btnRPWD.Click += new System.EventHandler(this.btnRPWD_Click);
            // 
            // btnAddAcct
            // 
            this.btnAddAcct.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnAddAcct.Location = new System.Drawing.Point(128, 216);
            this.btnAddAcct.Name = "btnAddAcct";
            this.btnAddAcct.Size = new System.Drawing.Size(255, 29);
            this.btnAddAcct.TabIndex = 6;
            this.btnAddAcct.Text = "ADD ACCOUNT";
            this.btnAddAcct.UseVisualStyleBackColor = true;
            this.btnAddAcct.Click += new System.EventHandler(this.btnAddAcct_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(515, 272);
            this.Controls.Add(this.btnAddAcct);
            this.Controls.Add(this.btnRPWD);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.txtPWD);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtUName);
            this.Controls.Add(this.label1);
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtUName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPWD;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Button btnRPWD;
        private System.Windows.Forms.Button btnAddAcct;
    }
}

