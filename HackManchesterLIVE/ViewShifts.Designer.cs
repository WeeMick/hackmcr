namespace AddTrips
{
    partial class ViewShifts
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
            this.nextBtn = new System.Windows.Forms.Button();
            this.prevBtn = new System.Windows.Forms.Button();
            this.addShiftLbl = new System.Windows.Forms.Label();
            this.homeBTN = new System.Windows.Forms.Button();
            this.editShiftBtn = new System.Windows.Forms.Button();
            this.countdownLbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // nextBtn
            // 
            this.nextBtn.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nextBtn.Location = new System.Drawing.Point(342, 240);
            this.nextBtn.Name = "nextBtn";
            this.nextBtn.Size = new System.Drawing.Size(40, 40);
            this.nextBtn.TabIndex = 26;
            this.nextBtn.Text = ">";
            this.nextBtn.UseVisualStyleBackColor = true;
            // 
            // prevBtn
            // 
            this.prevBtn.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.prevBtn.Location = new System.Drawing.Point(2, 240);
            this.prevBtn.Name = "prevBtn";
            this.prevBtn.Size = new System.Drawing.Size(40, 40);
            this.prevBtn.TabIndex = 25;
            this.prevBtn.Text = "<";
            this.prevBtn.UseVisualStyleBackColor = true;
            // 
            // addShiftLbl
            // 
            this.addShiftLbl.BackColor = System.Drawing.SystemColors.Control;
            this.addShiftLbl.Font = new System.Drawing.Font("Segoe UI", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addShiftLbl.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.addShiftLbl.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.addShiftLbl.Location = new System.Drawing.Point(38, 134);
            this.addShiftLbl.Name = "addShiftLbl";
            this.addShiftLbl.Size = new System.Drawing.Size(328, 252);
            this.addShiftLbl.TabIndex = 24;
            this.addShiftLbl.Text = "Shift Information";
            this.addShiftLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // homeBTN
            // 
            this.homeBTN.BackColor = System.Drawing.Color.Transparent;
            this.homeBTN.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.homeBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.homeBTN.Font = new System.Drawing.Font("Segoe UI", 13.8F);
            this.homeBTN.Location = new System.Drawing.Point(2, 2);
            this.homeBTN.Name = "homeBTN";
            this.homeBTN.Size = new System.Drawing.Size(97, 70);
            this.homeBTN.TabIndex = 23;
            this.homeBTN.Text = "Home";
            this.homeBTN.UseVisualStyleBackColor = false;
            // 
            // editShiftBtn
            // 
            this.editShiftBtn.Font = new System.Drawing.Font("Segoe UI", 13.8F);
            this.editShiftBtn.Location = new System.Drawing.Point(38, 411);
            this.editShiftBtn.Name = "editShiftBtn";
            this.editShiftBtn.Size = new System.Drawing.Size(328, 49);
            this.editShiftBtn.TabIndex = 22;
            this.editShiftBtn.Text = "Edit shift";
            this.editShiftBtn.UseVisualStyleBackColor = true;
            // 
            // countdownLbl
            // 
            this.countdownLbl.Font = new System.Drawing.Font("Segoe UI", 13.8F);
            this.countdownLbl.Location = new System.Drawing.Point(232, 556);
            this.countdownLbl.Name = "countdownLbl";
            this.countdownLbl.Size = new System.Drawing.Size(149, 47);
            this.countdownLbl.TabIndex = 21;
            this.countdownLbl.Text = "Countdown";
            // 
            // ViewShifts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 607);
            this.Controls.Add(this.nextBtn);
            this.Controls.Add(this.prevBtn);
            this.Controls.Add(this.addShiftLbl);
            this.Controls.Add(this.homeBTN);
            this.Controls.Add(this.editShiftBtn);
            this.Controls.Add(this.countdownLbl);
            this.Name = "ViewShifts";
            this.Text = "ViewShifts";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button nextBtn;
        private System.Windows.Forms.Button prevBtn;
        private System.Windows.Forms.Label addShiftLbl;
        private System.Windows.Forms.Button homeBTN;
        private System.Windows.Forms.Button editShiftBtn;
        private System.Windows.Forms.Label countdownLbl;
    }
}