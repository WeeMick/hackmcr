namespace HackManchesterLIVE
{
    partial class Register
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
            this.titleLbl = new System.Windows.Forms.Label();
            this.nameLbl = new System.Windows.Forms.Label();
            this.ageLbl = new System.Windows.Forms.Label();
            this.emailLbl = new System.Windows.Forms.Label();
            this.passwordLbl = new System.Windows.Forms.Label();
            this.cPasswordLbl = new System.Windows.Forms.Label();
            this.nameTb = new System.Windows.Forms.TextBox();
            this.passwordTb = new System.Windows.Forms.TextBox();
            this.cPasswordTb = new System.Windows.Forms.TextBox();
            this.emailTb = new System.Windows.Forms.TextBox();
            this.ageUpDown = new System.Windows.Forms.NumericUpDown();
            this.backBtn = new System.Windows.Forms.Button();
            this.registerBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ageUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // titleLbl
            // 
            this.titleLbl.AutoSize = true;
            this.titleLbl.Font = new System.Drawing.Font("Segoe UI", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLbl.Location = new System.Drawing.Point(108, 20);
            this.titleLbl.Name = "titleLbl";
            this.titleLbl.Size = new System.Drawing.Size(154, 50);
            this.titleLbl.TabIndex = 1;
            this.titleLbl.Text = "Register";
            // 
            // nameLbl
            // 
            this.nameLbl.AutoSize = true;
            this.nameLbl.Location = new System.Drawing.Point(12, 82);
            this.nameLbl.Name = "nameLbl";
            this.nameLbl.Size = new System.Drawing.Size(62, 25);
            this.nameLbl.TabIndex = 2;
            this.nameLbl.Text = "Name";
            // 
            // ageLbl
            // 
            this.ageLbl.AutoSize = true;
            this.ageLbl.Location = new System.Drawing.Point(12, 150);
            this.ageLbl.Name = "ageLbl";
            this.ageLbl.Size = new System.Drawing.Size(45, 25);
            this.ageLbl.TabIndex = 3;
            this.ageLbl.Text = "Age";
            // 
            // emailLbl
            // 
            this.emailLbl.AutoSize = true;
            this.emailLbl.Location = new System.Drawing.Point(12, 209);
            this.emailLbl.Name = "emailLbl";
            this.emailLbl.Size = new System.Drawing.Size(58, 25);
            this.emailLbl.TabIndex = 4;
            this.emailLbl.Text = "Email";
            // 
            // passwordLbl
            // 
            this.passwordLbl.AutoSize = true;
            this.passwordLbl.Location = new System.Drawing.Point(12, 268);
            this.passwordLbl.Name = "passwordLbl";
            this.passwordLbl.Size = new System.Drawing.Size(91, 25);
            this.passwordLbl.TabIndex = 5;
            this.passwordLbl.Text = "Password";
            // 
            // cPasswordLbl
            // 
            this.cPasswordLbl.AutoSize = true;
            this.cPasswordLbl.Location = new System.Drawing.Point(12, 334);
            this.cPasswordLbl.Name = "cPasswordLbl";
            this.cPasswordLbl.Size = new System.Drawing.Size(91, 50);
            this.cPasswordLbl.TabIndex = 6;
            this.cPasswordLbl.Text = "Confirm\r\nPassword";
            // 
            // nameTb
            // 
            this.nameTb.Location = new System.Drawing.Point(124, 82);
            this.nameTb.Name = "nameTb";
            this.nameTb.Size = new System.Drawing.Size(200, 33);
            this.nameTb.TabIndex = 7;
            // 
            // passwordTb
            // 
            this.passwordTb.Location = new System.Drawing.Point(124, 268);
            this.passwordTb.Name = "passwordTb";
            this.passwordTb.Size = new System.Drawing.Size(200, 33);
            this.passwordTb.TabIndex = 8;
            // 
            // cPasswordTb
            // 
            this.cPasswordTb.Location = new System.Drawing.Point(124, 334);
            this.cPasswordTb.Name = "cPasswordTb";
            this.cPasswordTb.Size = new System.Drawing.Size(200, 33);
            this.cPasswordTb.TabIndex = 9;
            // 
            // emailTb
            // 
            this.emailTb.Location = new System.Drawing.Point(124, 209);
            this.emailTb.Name = "emailTb";
            this.emailTb.Size = new System.Drawing.Size(200, 33);
            this.emailTb.TabIndex = 10;
            // 
            // ageUpDown
            // 
            this.ageUpDown.Location = new System.Drawing.Point(129, 153);
            this.ageUpDown.Name = "ageUpDown";
            this.ageUpDown.Size = new System.Drawing.Size(194, 33);
            this.ageUpDown.TabIndex = 11;
            this.ageUpDown.Value = new decimal(new int[] {
            20,
            0,
            0,
            0});
            // 
            // backBtn
            // 
            this.backBtn.Location = new System.Drawing.Point(35, 468);
            this.backBtn.Name = "backBtn";
            this.backBtn.Size = new System.Drawing.Size(114, 48);
            this.backBtn.TabIndex = 13;
            this.backBtn.Text = "Back";
            this.backBtn.UseVisualStyleBackColor = true;
            this.backBtn.Click += new System.EventHandler(this.backBtn_Click);
            // 
            // registerBtn
            // 
            this.registerBtn.Location = new System.Drawing.Point(204, 468);
            this.registerBtn.Name = "registerBtn";
            this.registerBtn.Size = new System.Drawing.Size(114, 48);
            this.registerBtn.TabIndex = 12;
            this.registerBtn.Text = "Register";
            this.registerBtn.UseVisualStyleBackColor = true;
            // 
            // Register
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(386, 615);
            this.Controls.Add(this.backBtn);
            this.Controls.Add(this.registerBtn);
            this.Controls.Add(this.ageUpDown);
            this.Controls.Add(this.emailTb);
            this.Controls.Add(this.cPasswordTb);
            this.Controls.Add(this.passwordTb);
            this.Controls.Add(this.nameTb);
            this.Controls.Add(this.cPasswordLbl);
            this.Controls.Add(this.passwordLbl);
            this.Controls.Add(this.emailLbl);
            this.Controls.Add(this.ageLbl);
            this.Controls.Add(this.nameLbl);
            this.Controls.Add(this.titleLbl);
            this.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "Register";
            this.Text = "Register";
            ((System.ComponentModel.ISupportInitialize)(this.ageUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label titleLbl;
        private System.Windows.Forms.Label nameLbl;
        private System.Windows.Forms.Label ageLbl;
        private System.Windows.Forms.Label emailLbl;
        private System.Windows.Forms.Label passwordLbl;
        private System.Windows.Forms.Label cPasswordLbl;
        private System.Windows.Forms.TextBox nameTb;
        private System.Windows.Forms.TextBox passwordTb;
        private System.Windows.Forms.TextBox cPasswordTb;
        private System.Windows.Forms.TextBox emailTb;
        private System.Windows.Forms.NumericUpDown ageUpDown;
        private System.Windows.Forms.Button backBtn;
        private System.Windows.Forms.Button registerBtn;
    }
}