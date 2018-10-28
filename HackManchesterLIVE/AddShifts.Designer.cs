namespace HackManchesterLIVE
{
    partial class AddShifts
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
            this.finishDateTb = new System.Windows.Forms.TextBox();
            this.startDateTb = new System.Windows.Forms.TextBox();
            this.finishTimeTb = new System.Windows.Forms.TextBox();
            this.startTimeTb = new System.Windows.Forms.TextBox();
            this.homeBtn = new System.Windows.Forms.Button();
            this.addShiftBtn = new System.Windows.Forms.Button();
            this.infoLbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // finishDateTb
            // 
            this.finishDateTb.BackColor = System.Drawing.SystemColors.ControlLight;
            this.finishDateTb.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.finishDateTb.Location = new System.Drawing.Point(25, 502);
            this.finishDateTb.Multiline = true;
            this.finishDateTb.Name = "finishDateTb";
            this.finishDateTb.Size = new System.Drawing.Size(336, 52);
            this.finishDateTb.TabIndex = 43;
            this.finishDateTb.Text = "Finish Date";
            this.finishDateTb.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.finishDateTb.Enter += new System.EventHandler(this.finishDateTb_Enter);
            // 
            // startDateTb
            // 
            this.startDateTb.BackColor = System.Drawing.SystemColors.ControlLight;
            this.startDateTb.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startDateTb.Location = new System.Drawing.Point(26, 420);
            this.startDateTb.Multiline = true;
            this.startDateTb.Name = "startDateTb";
            this.startDateTb.Size = new System.Drawing.Size(335, 52);
            this.startDateTb.TabIndex = 42;
            this.startDateTb.Text = "Start Date";
            this.startDateTb.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.startDateTb.Enter += new System.EventHandler(this.startDateTb_Enter);
            // 
            // finishTimeTb
            // 
            this.finishTimeTb.BackColor = System.Drawing.SystemColors.ControlLight;
            this.finishTimeTb.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.finishTimeTb.Location = new System.Drawing.Point(26, 341);
            this.finishTimeTb.Multiline = true;
            this.finishTimeTb.Name = "finishTimeTb";
            this.finishTimeTb.Size = new System.Drawing.Size(335, 52);
            this.finishTimeTb.TabIndex = 44;
            this.finishTimeTb.Text = "Finish Time";
            this.finishTimeTb.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.finishTimeTb.Enter += new System.EventHandler(this.finishTimeTb_Enter);
            // 
            // startTimeTb
            // 
            this.startTimeTb.BackColor = System.Drawing.SystemColors.ControlLight;
            this.startTimeTb.Cursor = System.Windows.Forms.Cursors.Default;
            this.startTimeTb.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startTimeTb.Location = new System.Drawing.Point(26, 265);
            this.startTimeTb.Multiline = true;
            this.startTimeTb.Name = "startTimeTb";
            this.startTimeTb.Size = new System.Drawing.Size(335, 52);
            this.startTimeTb.TabIndex = 41;
            this.startTimeTb.Text = "Start Time";
            this.startTimeTb.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.startTimeTb.Enter += new System.EventHandler(this.startTimeTb_Enter);
            // 
            // homeBtn
            // 
            this.homeBtn.BackColor = System.Drawing.Color.Transparent;
            this.homeBtn.BackgroundImage = global::HackManchesterLIVE.Properties.Resources.homeButton;
            this.homeBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.homeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.homeBtn.Font = new System.Drawing.Font("Segoe UI", 13.8F);
            this.homeBtn.Location = new System.Drawing.Point(2, 2);
            this.homeBtn.Name = "homeBtn";
            this.homeBtn.Size = new System.Drawing.Size(85, 74);
            this.homeBtn.TabIndex = 40;
            this.homeBtn.UseVisualStyleBackColor = false;
            this.homeBtn.Click += new System.EventHandler(this.homeBtn_Click);
            // 
            // addShiftBtn
            // 
            this.addShiftBtn.Font = new System.Drawing.Font("Segoe UI", 28.2F);
            this.addShiftBtn.Location = new System.Drawing.Point(26, 125);
            this.addShiftBtn.Name = "addShiftBtn";
            this.addShiftBtn.Size = new System.Drawing.Size(334, 75);
            this.addShiftBtn.TabIndex = 45;
            this.addShiftBtn.Text = "Add Shift";
            this.addShiftBtn.UseVisualStyleBackColor = true;
            this.addShiftBtn.Click += new System.EventHandler(this.addShiftBtn_Click);
            // 
            // infoLbl
            // 
            this.infoLbl.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.infoLbl.Location = new System.Drawing.Point(11, 218);
            this.infoLbl.Name = "infoLbl";
            this.infoLbl.Size = new System.Drawing.Size(362, 336);
            this.infoLbl.TabIndex = 46;
            // 
            // AddShifts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 607);
            this.Controls.Add(this.infoLbl);
            this.Controls.Add(this.addShiftBtn);
            this.Controls.Add(this.finishDateTb);
            this.Controls.Add(this.startDateTb);
            this.Controls.Add(this.finishTimeTb);
            this.Controls.Add(this.startTimeTb);
            this.Controls.Add(this.homeBtn);
            this.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "AddShifts";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddShifts";
            this.Load += new System.EventHandler(this.AddShifts_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.TextBox finishDateTb;
        public System.Windows.Forms.TextBox startDateTb;
        public System.Windows.Forms.TextBox finishTimeTb;
        public System.Windows.Forms.TextBox startTimeTb;
        public System.Windows.Forms.Button homeBtn;
        private System.Windows.Forms.Button addShiftBtn;
        private System.Windows.Forms.Label infoLbl;
    }
}