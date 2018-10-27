namespace HackManchesterLIVE
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
            this.startTimeLbl = new System.Windows.Forms.Label();
            this.nextBtn = new System.Windows.Forms.Button();
            this.prevBtn = new System.Windows.Forms.Button();
            this.homeBTN = new System.Windows.Forms.Button();
            this.editShiftBtn = new System.Windows.Forms.Button();
            this.countdownLbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // startTimeLbl
            // 
            this.startTimeLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.2F);
            this.startTimeLbl.Location = new System.Drawing.Point(35, 145);
            this.startTimeLbl.Name = "startTimeLbl";
            this.startTimeLbl.Size = new System.Drawing.Size(310, 49);
            this.startTimeLbl.TabIndex = 33;
            this.startTimeLbl.Text = "Start Time";
            // 
            // nextBtn
            // 
            this.nextBtn.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nextBtn.Location = new System.Drawing.Point(342, 241);
            this.nextBtn.Name = "nextBtn";
            this.nextBtn.Size = new System.Drawing.Size(40, 40);
            this.nextBtn.TabIndex = 32;
            this.nextBtn.Text = ">";
            this.nextBtn.UseVisualStyleBackColor = true;
            // 
            // prevBtn
            // 
            this.prevBtn.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.prevBtn.Location = new System.Drawing.Point(2, 241);
            this.prevBtn.Name = "prevBtn";
            this.prevBtn.Size = new System.Drawing.Size(40, 40);
            this.prevBtn.TabIndex = 31;
            this.prevBtn.Text = "<";
            this.prevBtn.UseVisualStyleBackColor = true;
            // 
            // homeBTN
            // 
            this.homeBTN.BackColor = System.Drawing.Color.Transparent;
            this.homeBTN.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.homeBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.homeBTN.Font = new System.Drawing.Font("Segoe UI", 13.8F);
            this.homeBTN.Location = new System.Drawing.Point(2, 3);
            this.homeBTN.Name = "homeBTN";
            this.homeBTN.Size = new System.Drawing.Size(97, 70);
            this.homeBTN.TabIndex = 30;
            this.homeBTN.Text = "Home";
            this.homeBTN.UseVisualStyleBackColor = false;
            // 
            // editShiftBtn
            // 
            this.editShiftBtn.Font = new System.Drawing.Font("Segoe UI", 13.8F);
            this.editShiftBtn.Location = new System.Drawing.Point(38, 412);
            this.editShiftBtn.Name = "editShiftBtn";
            this.editShiftBtn.Size = new System.Drawing.Size(328, 49);
            this.editShiftBtn.TabIndex = 29;
            this.editShiftBtn.Text = "Edit shift";
            this.editShiftBtn.UseVisualStyleBackColor = true;
            // 
            // countdownLbl
            // 
            this.countdownLbl.Font = new System.Drawing.Font("Segoe UI", 13.8F);
            this.countdownLbl.Location = new System.Drawing.Point(232, 557);
            this.countdownLbl.Name = "countdownLbl";
            this.countdownLbl.Size = new System.Drawing.Size(149, 47);
            this.countdownLbl.TabIndex = 28;
            this.countdownLbl.Text = "Countdown";
            // 
            // ViewShifts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 607);
            this.Controls.Add(this.startTimeLbl);
            this.Controls.Add(this.nextBtn);
            this.Controls.Add(this.prevBtn);
            this.Controls.Add(this.homeBTN);
            this.Controls.Add(this.editShiftBtn);
            this.Controls.Add(this.countdownLbl);
            this.Name = "ViewShifts";
            this.Text = "ViewShifts";
            this.Load += new System.EventHandler(this.ViewShifts_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label startTimeLbl;
        private System.Windows.Forms.Button nextBtn;
        private System.Windows.Forms.Button prevBtn;
        private System.Windows.Forms.Button homeBTN;
        private System.Windows.Forms.Button editShiftBtn;
        private System.Windows.Forms.Label countdownLbl;
    }
}