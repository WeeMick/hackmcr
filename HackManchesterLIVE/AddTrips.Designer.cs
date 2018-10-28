namespace HackManchesterLIVE
{
    partial class AddTrips
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
            this.AddTripBtn = new System.Windows.Forms.Button();
            this.depDateTb = new System.Windows.Forms.MaskedTextBox();
            this.arrDateTb = new System.Windows.Forms.MaskedTextBox();
            this.DepTimeTb = new System.Windows.Forms.MaskedTextBox();
            this.arrTimeTb = new System.Windows.Forms.MaskedTextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.homeBtn = new System.Windows.Forms.Button();
            this.AddTripTitleLbl = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.destTb = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // AddTripBtn
            // 
            this.AddTripBtn.BackColor = System.Drawing.Color.AliceBlue;
            this.AddTripBtn.FlatAppearance.BorderSize = 0;
            this.AddTripBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddTripBtn.ForeColor = System.Drawing.Color.Black;
            this.AddTripBtn.Location = new System.Drawing.Point(21, 538);
            this.AddTripBtn.Name = "AddTripBtn";
            this.AddTripBtn.Size = new System.Drawing.Size(332, 55);
            this.AddTripBtn.TabIndex = 0;
            this.AddTripBtn.Text = "Add Trip";
            this.AddTripBtn.UseVisualStyleBackColor = false;
            this.AddTripBtn.Click += new System.EventHandler(this.AddTripBtn_Click);
            // 
            // depDateTb
            // 
            this.depDateTb.Location = new System.Drawing.Point(39, 216);
            this.depDateTb.Mask = "00/00/0000";
            this.depDateTb.Name = "depDateTb";
            this.depDateTb.Size = new System.Drawing.Size(287, 34);
            this.depDateTb.TabIndex = 1;
            this.depDateTb.ValidatingType = typeof(System.DateTime);
            // 
            // arrDateTb
            // 
            this.arrDateTb.Location = new System.Drawing.Point(39, 389);
            this.arrDateTb.Mask = "00/00/0000";
            this.arrDateTb.Name = "arrDateTb";
            this.arrDateTb.Size = new System.Drawing.Size(287, 34);
            this.arrDateTb.TabIndex = 2;
            this.arrDateTb.ValidatingType = typeof(System.DateTime);
            // 
            // DepTimeTb
            // 
            this.DepTimeTb.Location = new System.Drawing.Point(39, 294);
            this.DepTimeTb.Mask = "00:00";
            this.DepTimeTb.Name = "DepTimeTb";
            this.DepTimeTb.Size = new System.Drawing.Size(287, 34);
            this.DepTimeTb.TabIndex = 3;
            this.DepTimeTb.ValidatingType = typeof(System.DateTime);
            // 
            // arrTimeTb
            // 
            this.arrTimeTb.Location = new System.Drawing.Point(39, 481);
            this.arrTimeTb.Mask = "00:00";
            this.arrTimeTb.Name = "arrTimeTb";
            this.arrTimeTb.Size = new System.Drawing.Size(287, 34);
            this.arrTimeTb.TabIndex = 4;
            this.arrTimeTb.ValidatingType = typeof(System.DateTime);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.homeBtn);
            this.panel1.Controls.Add(this.AddTripTitleLbl);
            this.panel1.Location = new System.Drawing.Point(-28, -57);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(416, 111);
            this.panel1.TabIndex = 5;
            // 
            // homeBtn
            // 
            this.homeBtn.BackgroundImage = global::HackManchesterLIVE.Properties.Resources.homeButton;
            this.homeBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.homeBtn.Location = new System.Drawing.Point(40, 61);
            this.homeBtn.Name = "homeBtn";
            this.homeBtn.Size = new System.Drawing.Size(44, 42);
            this.homeBtn.TabIndex = 1;
            this.homeBtn.UseVisualStyleBackColor = true;
            this.homeBtn.Click += new System.EventHandler(this.homeBtn_Click);
            // 
            // AddTripTitleLbl
            // 
            this.AddTripTitleLbl.AutoSize = true;
            this.AddTripTitleLbl.BackColor = System.Drawing.Color.Transparent;
            this.AddTripTitleLbl.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddTripTitleLbl.ForeColor = System.Drawing.Color.White;
            this.AddTripTitleLbl.Location = new System.Drawing.Point(148, 66);
            this.AddTripTitleLbl.Name = "AddTripTitleLbl";
            this.AddTripTitleLbl.Size = new System.Drawing.Size(160, 32);
            this.AddTripTitleLbl.TabIndex = 0;
            this.AddTripTitleLbl.Text = "Plan Your Trip";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(38, 176);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(146, 28);
            this.label2.TabIndex = 6;
            this.label2.Text = "Departure Date";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(34, 263);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(147, 28);
            this.label3.TabIndex = 7;
            this.label3.Text = "Departure Time";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Location = new System.Drawing.Point(38, 358);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(306, 28);
            this.label4.TabIndex = 8;
            this.label4.Text = "Arrival Date (Local to Destination)";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Location = new System.Drawing.Point(37, 450);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(307, 28);
            this.label5.TabIndex = 9;
            this.label5.Text = "Arrival Time (Local to Destination)";
            // 
            // destTb
            // 
            this.destTb.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.destTb.Location = new System.Drawing.Point(39, 113);
            this.destTb.Name = "destTb";
            this.destTb.Size = new System.Drawing.Size(287, 34);
            this.destTb.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Location = new System.Drawing.Point(34, 82);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(112, 28);
            this.label6.TabIndex = 11;
            this.label6.Text = "Destination";
            // 
            // AddTrips
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(386, 607);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.destTb);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.arrTimeTb);
            this.Controls.Add(this.DepTimeTb);
            this.Controls.Add(this.arrDateTb);
            this.Controls.Add(this.depDateTb);
            this.Controls.Add(this.AddTripBtn);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "AddTrips";
            this.Text = "AddTrips";
            this.Load += new System.EventHandler(this.AddTrips_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button AddTripBtn;
        private System.Windows.Forms.MaskedTextBox depDateTb;
        private System.Windows.Forms.MaskedTextBox arrDateTb;
        private System.Windows.Forms.MaskedTextBox DepTimeTb;
        private System.Windows.Forms.MaskedTextBox arrTimeTb;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label AddTripTitleLbl;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox destTb;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button homeBtn;
    }
}