namespace HackManchesterLIVE
{
    partial class Home
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
            this.addShifsBtn = new System.Windows.Forms.Button();
            this.viewShiftsBtn = new System.Windows.Forms.Button();
            this.todaysTipsBtn = new System.Windows.Forms.Button();
            this.profilePicBox = new System.Windows.Forms.PictureBox();
            this.bottelPicBox = new System.Windows.Forms.PictureBox();
            this.profileComBox = new System.Windows.Forms.ComboBox();
            this.welcomeLbl = new System.Windows.Forms.Label();
            this.tipsLbl = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.profilePicBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bottelPicBox)).BeginInit();
            this.SuspendLayout();
            // 
            // addShifsBtn
            // 
            this.addShifsBtn.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.addShifsBtn.Location = new System.Drawing.Point(32, 139);
            this.addShifsBtn.Name = "addShifsBtn";
            this.addShifsBtn.Size = new System.Drawing.Size(328, 51);
            this.addShifsBtn.TabIndex = 0;
            this.addShifsBtn.Text = "Add Shifts";
            this.addShifsBtn.UseVisualStyleBackColor = true;
            this.addShifsBtn.Click += new System.EventHandler(this.addShifsBtn_Click);
            // 
            // viewShiftsBtn
            // 
            this.viewShiftsBtn.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.viewShiftsBtn.Location = new System.Drawing.Point(32, 215);
            this.viewShiftsBtn.Name = "viewShiftsBtn";
            this.viewShiftsBtn.Size = new System.Drawing.Size(328, 51);
            this.viewShiftsBtn.TabIndex = 1;
            this.viewShiftsBtn.Text = "View Shifts";
            this.viewShiftsBtn.UseVisualStyleBackColor = true;
            this.viewShiftsBtn.Click += new System.EventHandler(this.viewShiftsBtn_Click);
            // 
            // todaysTipsBtn
            // 
            this.todaysTipsBtn.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.todaysTipsBtn.Location = new System.Drawing.Point(32, 297);
            this.todaysTipsBtn.Name = "todaysTipsBtn";
            this.todaysTipsBtn.Size = new System.Drawing.Size(328, 51);
            this.todaysTipsBtn.TabIndex = 2;
            this.todaysTipsBtn.Text = "Todays Tips";
            this.todaysTipsBtn.UseVisualStyleBackColor = true;
            this.todaysTipsBtn.Click += new System.EventHandler(this.todaysTipsBtn_Click);
            // 
            // profilePicBox
            // 
            this.profilePicBox.Location = new System.Drawing.Point(306, 2);
            this.profilePicBox.Name = "profilePicBox";
            this.profilePicBox.Size = new System.Drawing.Size(78, 50);
            this.profilePicBox.TabIndex = 3;
            this.profilePicBox.TabStop = false;
            // 
            // bottelPicBox
            // 
            this.bottelPicBox.Location = new System.Drawing.Point(306, 467);
            this.bottelPicBox.Name = "bottelPicBox";
            this.bottelPicBox.Size = new System.Drawing.Size(67, 124);
            this.bottelPicBox.TabIndex = 4;
            this.bottelPicBox.TabStop = false;
            // 
            // profileComBox
            // 
            this.profileComBox.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.profileComBox.FormattingEnabled = true;
            this.profileComBox.Items.AddRange(new object[] {
            "Manage Account",
            "Logout"});
            this.profileComBox.Location = new System.Drawing.Point(251, 58);
            this.profileComBox.Name = "profileComBox";
            this.profileComBox.Size = new System.Drawing.Size(133, 46);
            this.profileComBox.TabIndex = 5;
            this.profileComBox.Text = "Profile";
            // 
            // welcomeLbl
            // 
            this.welcomeLbl.Location = new System.Drawing.Point(24, 9);
            this.welcomeLbl.Name = "welcomeLbl";
            this.welcomeLbl.Size = new System.Drawing.Size(276, 39);
            this.welcomeLbl.TabIndex = 6;
            this.welcomeLbl.Text = "label1";
            // 
            // tipsLbl
            // 
            this.tipsLbl.Location = new System.Drawing.Point(12, 467);
            this.tipsLbl.Name = "tipsLbl";
            this.tipsLbl.Size = new System.Drawing.Size(276, 39);
            this.tipsLbl.TabIndex = 7;
            this.tipsLbl.Text = "label2";
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(386, 646);
            this.Controls.Add(this.tipsLbl);
            this.Controls.Add(this.welcomeLbl);
            this.Controls.Add(this.profileComBox);
            this.Controls.Add(this.bottelPicBox);
            this.Controls.Add(this.profilePicBox);
            this.Controls.Add(this.todaysTipsBtn);
            this.Controls.Add(this.viewShiftsBtn);
            this.Controls.Add(this.addShifsBtn);
            this.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Home";
            this.Text = "Home";
            ((System.ComponentModel.ISupportInitialize)(this.profilePicBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bottelPicBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button addShifsBtn;
        private System.Windows.Forms.Button viewShiftsBtn;
        private System.Windows.Forms.Button todaysTipsBtn;
        private System.Windows.Forms.PictureBox profilePicBox;
        private System.Windows.Forms.PictureBox bottelPicBox;
        private System.Windows.Forms.ComboBox profileComBox;
        private System.Windows.Forms.Label welcomeLbl;
        private System.Windows.Forms.Label tipsLbl;
    }
}