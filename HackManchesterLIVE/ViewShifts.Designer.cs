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
            this.finishDateLbl = new System.Windows.Forms.Label();
            this.startDateLbl = new System.Windows.Forms.Label();
            this.finishTimeLbl = new System.Windows.Forms.Label();
            this.startTimeLbl = new System.Windows.Forms.Label();
            this.editShiftBtn = new System.Windows.Forms.Button();
            this.shiftInfoLbl = new System.Windows.Forms.Label();
            this.homeBTN = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // finishDateLbl
            // 
            this.finishDateLbl.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.finishDateLbl.Location = new System.Drawing.Point(15, 419);
            this.finishDateLbl.Name = "finishDateLbl";
            this.finishDateLbl.Size = new System.Drawing.Size(357, 49);
            this.finishDateLbl.TabIndex = 45;
            this.finishDateLbl.Text = "Finish Date:";
            // 
            // startDateLbl
            // 
            this.startDateLbl.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startDateLbl.Location = new System.Drawing.Point(15, 361);
            this.startDateLbl.Name = "startDateLbl";
            this.startDateLbl.Size = new System.Drawing.Size(357, 49);
            this.startDateLbl.TabIndex = 44;
            this.startDateLbl.Text = "Start Date:";
            // 
            // finishTimeLbl
            // 
            this.finishTimeLbl.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.finishTimeLbl.Location = new System.Drawing.Point(15, 303);
            this.finishTimeLbl.Name = "finishTimeLbl";
            this.finishTimeLbl.Size = new System.Drawing.Size(357, 49);
            this.finishTimeLbl.TabIndex = 43;
            this.finishTimeLbl.Text = "Finish Time:";
            // 
            // startTimeLbl
            // 
            this.startTimeLbl.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startTimeLbl.Location = new System.Drawing.Point(15, 246);
            this.startTimeLbl.Name = "startTimeLbl";
            this.startTimeLbl.Size = new System.Drawing.Size(357, 49);
            this.startTimeLbl.TabIndex = 42;
            this.startTimeLbl.Text = "Start Time:";
            // 
            // editShiftBtn
            // 
            this.editShiftBtn.Font = new System.Drawing.Font("Segoe UI", 13.8F);
            this.editShiftBtn.Location = new System.Drawing.Point(12, 486);
            this.editShiftBtn.Name = "editShiftBtn";
            this.editShiftBtn.Size = new System.Drawing.Size(360, 49);
            this.editShiftBtn.TabIndex = 39;
            this.editShiftBtn.Text = "Edit shift";
            this.editShiftBtn.UseVisualStyleBackColor = true;
            this.editShiftBtn.Click += new System.EventHandler(this.editShiftBtn_Click);
            // 
            // shiftInfoLbl
            // 
            this.shiftInfoLbl.Font = new System.Drawing.Font("Segoe UI", 28F);
            this.shiftInfoLbl.Location = new System.Drawing.Point(12, 96);
            this.shiftInfoLbl.Name = "shiftInfoLbl";
            this.shiftInfoLbl.Size = new System.Drawing.Size(360, 134);
            this.shiftInfoLbl.TabIndex = 46;
            this.shiftInfoLbl.Text = "Shift Information";
            this.shiftInfoLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.shiftInfoLbl.Click += new System.EventHandler(this.shiftInfoLbl_Click);
            // 
            // homeBTN
            // 
            this.homeBTN.BackColor = System.Drawing.Color.Transparent;
            this.homeBTN.BackgroundImage = global::HackManchesterLIVE.Properties.Resources.homeButton;
            this.homeBTN.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.homeBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.homeBTN.Font = new System.Drawing.Font("Segoe UI", 13.8F);
            this.homeBTN.Location = new System.Drawing.Point(2, 3);
            this.homeBTN.Name = "homeBTN";
            this.homeBTN.Size = new System.Drawing.Size(97, 70);
            this.homeBTN.TabIndex = 30;
            this.homeBTN.UseVisualStyleBackColor = false;
            this.homeBTN.Click += new System.EventHandler(this.homeBTN_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Segoe UI", 13.8F);
            this.label1.Location = new System.Drawing.Point(13, 547);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(359, 42);
            this.label1.TabIndex = 47;
            this.label1.Text = "Countdown";
            // 
            // ViewShifts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 607);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.homeBTN);
            this.Controls.Add(this.shiftInfoLbl);
            this.Controls.Add(this.finishDateLbl);
            this.Controls.Add(this.startDateLbl);
            this.Controls.Add(this.finishTimeLbl);
            this.Controls.Add(this.startTimeLbl);
            this.Controls.Add(this.editShiftBtn);
            this.Name = "ViewShifts";
            this.Text = "ViewShifts";
            this.Load += new System.EventHandler(this.ViewShifts_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button homeBTN;
        private System.Windows.Forms.Button editShiftBtn;
        private System.Windows.Forms.Label shiftInfoLbl;
        public System.Windows.Forms.Label startTimeLbl;
        public System.Windows.Forms.Label finishDateLbl;
        public System.Windows.Forms.Label startDateLbl;
        public System.Windows.Forms.Label finishTimeLbl;
        private System.Windows.Forms.Label label1;
    }
}