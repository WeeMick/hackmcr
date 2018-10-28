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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home));
            this.addShifsBtn = new System.Windows.Forms.Button();
            this.viewShiftsBtn = new System.Windows.Forms.Button();
            this.todaysTipsBtn = new System.Windows.Forms.Button();
            this.profileComBox = new System.Windows.Forms.ComboBox();
            this.welcomeLbl = new System.Windows.Forms.Label();
            this.tipsLbl = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.addTripsBtn = new System.Windows.Forms.Button();
            this.viewTripsBtn = new System.Windows.Forms.Button();
            this.bottel2PicBox = new System.Windows.Forms.PictureBox();
            this.bottel3PicBox = new System.Windows.Forms.PictureBox();
            this.bottel4PicBox = new System.Windows.Forms.PictureBox();
            this.bottelPicBox = new System.Windows.Forms.PictureBox();
            this.profilePicBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.bottel2PicBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bottel3PicBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bottel4PicBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bottelPicBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.profilePicBox)).BeginInit();
            this.SuspendLayout();
            // 
            // addShifsBtn
            // 
            this.addShifsBtn.BackColor = System.Drawing.SystemColors.Control;
            this.addShifsBtn.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.addShifsBtn.ForeColor = System.Drawing.Color.Black;
            this.addShifsBtn.Location = new System.Drawing.Point(28, 158);
            this.addShifsBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.addShifsBtn.Name = "addShifsBtn";
            this.addShifsBtn.Size = new System.Drawing.Size(331, 49);
            this.addShifsBtn.TabIndex = 0;
            this.addShifsBtn.Text = "Add Shift";
            this.addShifsBtn.UseVisualStyleBackColor = false;
            this.addShifsBtn.Click += new System.EventHandler(this.addShifsBtn_Click);
            // 
            // viewShiftsBtn
            // 
            this.viewShiftsBtn.BackColor = System.Drawing.SystemColors.Control;
            this.viewShiftsBtn.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.viewShiftsBtn.ForeColor = System.Drawing.Color.Black;
            this.viewShiftsBtn.Location = new System.Drawing.Point(28, 211);
            this.viewShiftsBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.viewShiftsBtn.Name = "viewShiftsBtn";
            this.viewShiftsBtn.Size = new System.Drawing.Size(331, 47);
            this.viewShiftsBtn.TabIndex = 1;
            this.viewShiftsBtn.Text = "View Shifts";
            this.viewShiftsBtn.UseVisualStyleBackColor = false;
            this.viewShiftsBtn.Click += new System.EventHandler(this.viewShiftsBtn_Click);
            // 
            // todaysTipsBtn
            // 
            this.todaysTipsBtn.BackColor = System.Drawing.SystemColors.Control;
            this.todaysTipsBtn.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.todaysTipsBtn.ForeColor = System.Drawing.Color.Black;
            this.todaysTipsBtn.Location = new System.Drawing.Point(28, 398);
            this.todaysTipsBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.todaysTipsBtn.Name = "todaysTipsBtn";
            this.todaysTipsBtn.Size = new System.Drawing.Size(331, 49);
            this.todaysTipsBtn.TabIndex = 2;
            this.todaysTipsBtn.Text = "Todays Tips";
            this.todaysTipsBtn.UseVisualStyleBackColor = false;
            this.todaysTipsBtn.Click += new System.EventHandler(this.todaysTipsBtn_Click);
            // 
            // profileComBox
            // 
            this.profileComBox.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.profileComBox.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.profileComBox.FormattingEnabled = true;
            this.profileComBox.Items.AddRange(new object[] {
            "Manage Account",
            "Logout"});
            this.profileComBox.Location = new System.Drawing.Point(228, 76);
            this.profileComBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.profileComBox.Name = "profileComBox";
            this.profileComBox.Size = new System.Drawing.Size(153, 39);
            this.profileComBox.TabIndex = 5;
            this.profileComBox.Text = "Profile";
            this.profileComBox.SelectedIndexChanged += new System.EventHandler(this.profileComBox_SelectedIndexChanged_1);
            // 
            // welcomeLbl
            // 
            this.welcomeLbl.BackColor = System.Drawing.Color.Transparent;
            this.welcomeLbl.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.welcomeLbl.Location = new System.Drawing.Point(24, 5);
            this.welcomeLbl.Name = "welcomeLbl";
            this.welcomeLbl.Size = new System.Drawing.Size(280, 62);
            this.welcomeLbl.TabIndex = 6;
            this.welcomeLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.welcomeLbl.Click += new System.EventHandler(this.welcomeLbl_Click);
            // 
            // tipsLbl
            // 
            this.tipsLbl.BackColor = System.Drawing.Color.Transparent;
            this.tipsLbl.Location = new System.Drawing.Point(76, 489);
            this.tipsLbl.Name = "tipsLbl";
            this.tipsLbl.Size = new System.Drawing.Size(214, 100);
            this.tipsLbl.TabIndex = 7;
            this.tipsLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(347, 464);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(17, 19);
            this.label1.TabIndex = 8;
            this.label1.Text = "4";
            // 
            // addTripsBtn
            // 
            this.addTripsBtn.BackColor = System.Drawing.SystemColors.Control;
            this.addTripsBtn.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.addTripsBtn.ForeColor = System.Drawing.Color.Black;
            this.addTripsBtn.Location = new System.Drawing.Point(28, 275);
            this.addTripsBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.addTripsBtn.Name = "addTripsBtn";
            this.addTripsBtn.Size = new System.Drawing.Size(331, 49);
            this.addTripsBtn.TabIndex = 12;
            this.addTripsBtn.Text = "Add Trips";
            this.addTripsBtn.UseVisualStyleBackColor = false;
            this.addTripsBtn.Click += new System.EventHandler(this.addTripsBtn_Click);
            // 
            // viewTripsBtn
            // 
            this.viewTripsBtn.BackColor = System.Drawing.SystemColors.Control;
            this.viewTripsBtn.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.viewTripsBtn.ForeColor = System.Drawing.Color.Black;
            this.viewTripsBtn.Location = new System.Drawing.Point(28, 328);
            this.viewTripsBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.viewTripsBtn.Name = "viewTripsBtn";
            this.viewTripsBtn.Size = new System.Drawing.Size(331, 49);
            this.viewTripsBtn.TabIndex = 13;
            this.viewTripsBtn.Text = "View Trip";
            this.viewTripsBtn.UseVisualStyleBackColor = false;
            // 
            // bottel2PicBox
            // 
            this.bottel2PicBox.BackColor = System.Drawing.Color.Transparent;
            this.bottel2PicBox.Image = global::HackManchesterLIVE.Properties.Resources.water_bottles_2;
            this.bottel2PicBox.Location = new System.Drawing.Point(319, 486);
            this.bottel2PicBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bottel2PicBox.Name = "bottel2PicBox";
            this.bottel2PicBox.Size = new System.Drawing.Size(62, 116);
            this.bottel2PicBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.bottel2PicBox.TabIndex = 11;
            this.bottel2PicBox.TabStop = false;
            // 
            // bottel3PicBox
            // 
            this.bottel3PicBox.Image = global::HackManchesterLIVE.Properties.Resources.water_bottles_css4;
            this.bottel3PicBox.Location = new System.Drawing.Point(318, 487);
            this.bottel3PicBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bottel3PicBox.Name = "bottel3PicBox";
            this.bottel3PicBox.Size = new System.Drawing.Size(62, 116);
            this.bottel3PicBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.bottel3PicBox.TabIndex = 10;
            this.bottel3PicBox.TabStop = false;
            // 
            // bottel4PicBox
            // 
            this.bottel4PicBox.Image = global::HackManchesterLIVE.Properties.Resources.water_bottles_css5;
            this.bottel4PicBox.Location = new System.Drawing.Point(321, 484);
            this.bottel4PicBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bottel4PicBox.Name = "bottel4PicBox";
            this.bottel4PicBox.Size = new System.Drawing.Size(62, 116);
            this.bottel4PicBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.bottel4PicBox.TabIndex = 9;
            this.bottel4PicBox.TabStop = false;
            // 
            // bottelPicBox
            // 
            this.bottelPicBox.Image = ((System.Drawing.Image)(resources.GetObject("bottelPicBox.Image")));
            this.bottelPicBox.Location = new System.Drawing.Point(318, 484);
            this.bottelPicBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bottelPicBox.Name = "bottelPicBox";
            this.bottelPicBox.Size = new System.Drawing.Size(62, 116);
            this.bottelPicBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.bottelPicBox.TabIndex = 4;
            this.bottelPicBox.TabStop = false;
            // 
            // profilePicBox
            // 
            this.profilePicBox.Image = ((System.Drawing.Image)(resources.GetObject("profilePicBox.Image")));
            this.profilePicBox.Location = new System.Drawing.Point(310, 5);
            this.profilePicBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.profilePicBox.Name = "profilePicBox";
            this.profilePicBox.Size = new System.Drawing.Size(71, 67);
            this.profilePicBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.profilePicBox.TabIndex = 3;
            this.profilePicBox.TabStop = false;
            this.profilePicBox.Click += new System.EventHandler(this.profilePicBox_Click_1);
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 607);
            this.Controls.Add(this.viewTripsBtn);
            this.Controls.Add(this.addTripsBtn);
            this.Controls.Add(this.bottel2PicBox);
            this.Controls.Add(this.bottel3PicBox);
            this.Controls.Add(this.bottel4PicBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tipsLbl);
            this.Controls.Add(this.welcomeLbl);
            this.Controls.Add(this.profileComBox);
            this.Controls.Add(this.bottelPicBox);
            this.Controls.Add(this.profilePicBox);
            this.Controls.Add(this.todaysTipsBtn);
            this.Controls.Add(this.viewShiftsBtn);
            this.Controls.Add(this.addShifsBtn);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Home";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Home";
            this.Load += new System.EventHandler(this.Home_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.bottel2PicBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bottel3PicBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bottel4PicBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bottelPicBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.profilePicBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button addShifsBtn;
        private System.Windows.Forms.Button viewShiftsBtn;
        private System.Windows.Forms.Button todaysTipsBtn;
        private System.Windows.Forms.PictureBox profilePicBox;
        private System.Windows.Forms.PictureBox bottelPicBox;
        private System.Windows.Forms.ComboBox profileComBox;
        public System.Windows.Forms.Label welcomeLbl;
        public System.Windows.Forms.Label tipsLbl;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox bottel4PicBox;
        private System.Windows.Forms.PictureBox bottel3PicBox;
        private System.Windows.Forms.PictureBox bottel2PicBox;
        private System.Windows.Forms.Button addTripsBtn;
        private System.Windows.Forms.Button viewTripsBtn;
    }
}