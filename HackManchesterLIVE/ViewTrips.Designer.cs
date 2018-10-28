namespace HackManchesterLIVE
{
    partial class ViewTrips
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.homeBtn = new System.Windows.Forms.Button();
            this.AddTripTitleLbl = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.trip1destLbl = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.arrTimeLbl = new System.Windows.Forms.Label();
            this.arrDateLbl = new System.Windows.Forms.Label();
            this.DepTimeLbl = new System.Windows.Forms.Label();
            this.DepDateLbl = new System.Windows.Forms.Label();
            this.nextBtn = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.homeBtn);
            this.panel1.Controls.Add(this.AddTripTitleLbl);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(386, 76);
            this.panel1.TabIndex = 6;
            // 
            // homeBtn
            // 
            this.homeBtn.BackgroundImage = global::HackManchesterLIVE.Properties.Resources.homeButton;
            this.homeBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.homeBtn.Location = new System.Drawing.Point(3, 12);
            this.homeBtn.Name = "homeBtn";
            this.homeBtn.Size = new System.Drawing.Size(58, 50);
            this.homeBtn.TabIndex = 1;
            this.homeBtn.UseVisualStyleBackColor = true;
            this.homeBtn.Click += new System.EventHandler(this.homeBtn_Click);
            // 
            // AddTripTitleLbl
            // 
            this.AddTripTitleLbl.AutoSize = true;
            this.AddTripTitleLbl.BackColor = System.Drawing.Color.Transparent;
            this.AddTripTitleLbl.Font = new System.Drawing.Font("Segoe UI", 20F);
            this.AddTripTitleLbl.ForeColor = System.Drawing.Color.White;
            this.AddTripTitleLbl.Location = new System.Drawing.Point(119, 16);
            this.AddTripTitleLbl.Name = "AddTripTitleLbl";
            this.AddTripTitleLbl.Size = new System.Drawing.Size(145, 46);
            this.AddTripTitleLbl.TabIndex = 0;
            this.AddTripTitleLbl.Text = "My Trips";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.PaleTurquoise;
            this.panel2.Controls.Add(this.trip1destLbl);
            this.panel2.Location = new System.Drawing.Point(74, 158);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(249, 81);
            this.panel2.TabIndex = 7;
            // 
            // trip1destLbl
            // 
            this.trip1destLbl.AutoSize = true;
            this.trip1destLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.trip1destLbl.Location = new System.Drawing.Point(19, 26);
            this.trip1destLbl.Name = "trip1destLbl";
            this.trip1destLbl.Size = new System.Drawing.Size(102, 32);
            this.trip1destLbl.TabIndex = 0;
            this.trip1destLbl.Text = "Trip 1: ";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel3.Controls.Add(this.arrTimeLbl);
            this.panel3.Controls.Add(this.arrDateLbl);
            this.panel3.Controls.Add(this.DepTimeLbl);
            this.panel3.Controls.Add(this.DepDateLbl);
            this.panel3.Location = new System.Drawing.Point(74, 232);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(249, 210);
            this.panel3.TabIndex = 8;
            // 
            // arrTimeLbl
            // 
            this.arrTimeLbl.AutoSize = true;
            this.arrTimeLbl.Location = new System.Drawing.Point(28, 148);
            this.arrTimeLbl.Name = "arrTimeLbl";
            this.arrTimeLbl.Size = new System.Drawing.Size(46, 17);
            this.arrTimeLbl.TabIndex = 3;
            this.arrTimeLbl.Text = "label1";
            // 
            // arrDateLbl
            // 
            this.arrDateLbl.AutoSize = true;
            this.arrDateLbl.Location = new System.Drawing.Point(28, 104);
            this.arrDateLbl.Name = "arrDateLbl";
            this.arrDateLbl.Size = new System.Drawing.Size(46, 17);
            this.arrDateLbl.TabIndex = 2;
            this.arrDateLbl.Text = "label1";
            // 
            // DepTimeLbl
            // 
            this.DepTimeLbl.AutoSize = true;
            this.DepTimeLbl.Location = new System.Drawing.Point(28, 63);
            this.DepTimeLbl.Name = "DepTimeLbl";
            this.DepTimeLbl.Size = new System.Drawing.Size(46, 17);
            this.DepTimeLbl.TabIndex = 1;
            this.DepTimeLbl.Text = "label1";
            // 
            // DepDateLbl
            // 
            this.DepDateLbl.AutoSize = true;
            this.DepDateLbl.Location = new System.Drawing.Point(28, 21);
            this.DepDateLbl.Name = "DepDateLbl";
            this.DepDateLbl.Size = new System.Drawing.Size(46, 17);
            this.DepDateLbl.TabIndex = 0;
            this.DepDateLbl.Text = "label1";
            // 
            // nextBtn
            // 
            this.nextBtn.BackColor = System.Drawing.Color.LightSteelBlue;
            this.nextBtn.Location = new System.Drawing.Point(74, 448);
            this.nextBtn.Name = "nextBtn";
            this.nextBtn.Size = new System.Drawing.Size(249, 70);
            this.nextBtn.TabIndex = 9;
            this.nextBtn.Text = "See Next Trip";
            this.nextBtn.UseVisualStyleBackColor = false;
            // 
            // ViewTrips
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(386, 607);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.nextBtn);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "ViewTrips";
            this.Text = "ViewTrips";
            this.Load += new System.EventHandler(this.ViewTrips_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.Button homeBtn;
        public System.Windows.Forms.Label AddTripTitleLbl;
        public System.Windows.Forms.Panel panel2;
        public System.Windows.Forms.Label trip1destLbl;
        public System.Windows.Forms.Panel panel3;
        public System.Windows.Forms.Label arrTimeLbl;
        public System.Windows.Forms.Label arrDateLbl;
        public System.Windows.Forms.Label DepTimeLbl;
        public System.Windows.Forms.Label DepDateLbl;
        public System.Windows.Forms.Button nextBtn;
    }
}