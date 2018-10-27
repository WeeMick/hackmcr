namespace AddTrips
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
            this.addShiftLbl = new System.Windows.Forms.Label();
            this.homeBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // finishDateTb
            // 
            this.finishDateTb.BackColor = System.Drawing.SystemColors.ControlLight;
            this.finishDateTb.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.finishDateTb.Location = new System.Drawing.Point(29, 472);
            this.finishDateTb.Multiline = true;
            this.finishDateTb.Name = "finishDateTb";
            this.finishDateTb.Size = new System.Drawing.Size(328, 49);
            this.finishDateTb.TabIndex = 43;
            this.finishDateTb.Text = "Finish Date";
            this.finishDateTb.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // startDateTb
            // 
            this.startDateTb.BackColor = System.Drawing.SystemColors.ControlLight;
            this.startDateTb.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startDateTb.Location = new System.Drawing.Point(29, 395);
            this.startDateTb.Multiline = true;
            this.startDateTb.Name = "startDateTb";
            this.startDateTb.Size = new System.Drawing.Size(328, 49);
            this.startDateTb.TabIndex = 42;
            this.startDateTb.Text = "Start Date";
            this.startDateTb.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // finishTimeTb
            // 
            this.finishTimeTb.BackColor = System.Drawing.SystemColors.ControlLight;
            this.finishTimeTb.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.finishTimeTb.Location = new System.Drawing.Point(29, 321);
            this.finishTimeTb.Multiline = true;
            this.finishTimeTb.Name = "finishTimeTb";
            this.finishTimeTb.Size = new System.Drawing.Size(328, 49);
            this.finishTimeTb.TabIndex = 44;
            this.finishTimeTb.Text = "Finish Time";
            this.finishTimeTb.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // startTimeTb
            // 
            this.startTimeTb.BackColor = System.Drawing.SystemColors.ControlLight;
            this.startTimeTb.Cursor = System.Windows.Forms.Cursors.Default;
            this.startTimeTb.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startTimeTb.Location = new System.Drawing.Point(29, 249);
            this.startTimeTb.Multiline = true;
            this.startTimeTb.Name = "startTimeTb";
            this.startTimeTb.Size = new System.Drawing.Size(328, 49);
            this.startTimeTb.TabIndex = 41;
            this.startTimeTb.Text = "Start Time";
            this.startTimeTb.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // addShiftLbl
            // 
            this.addShiftLbl.BackColor = System.Drawing.SystemColors.ControlLight;
            this.addShiftLbl.Font = new System.Drawing.Font("Segoe UI", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addShiftLbl.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.addShiftLbl.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.addShiftLbl.Location = new System.Drawing.Point(29, 110);
            this.addShiftLbl.Name = "addShiftLbl";
            this.addShiftLbl.Size = new System.Drawing.Size(328, 66);
            this.addShiftLbl.TabIndex = 39;
            this.addShiftLbl.Text = "Add shift";
            this.addShiftLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // homeBtn
            // 
            this.homeBtn.BackColor = System.Drawing.Color.Transparent;
            this.homeBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.homeBtn.Font = new System.Drawing.Font("Segoe UI", 13.8F);
            this.homeBtn.Location = new System.Drawing.Point(2, 2);
            this.homeBtn.Name = "homeBtn";
            this.homeBtn.Size = new System.Drawing.Size(97, 70);
            this.homeBtn.TabIndex = 40;
            this.homeBtn.Text = "Home";
            this.homeBtn.UseVisualStyleBackColor = false;
            // 
            // AddShifts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 607);
            this.Controls.Add(this.finishDateTb);
            this.Controls.Add(this.startDateTb);
            this.Controls.Add(this.finishTimeTb);
            this.Controls.Add(this.startTimeTb);
            this.Controls.Add(this.addShiftLbl);
            this.Controls.Add(this.homeBtn);
            this.Name = "AddShifts";
            this.Text = "AddShifts";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox finishDateTb;
        private System.Windows.Forms.TextBox startDateTb;
        private System.Windows.Forms.TextBox finishTimeTb;
        private System.Windows.Forms.TextBox startTimeTb;
        private System.Windows.Forms.Label addShiftLbl;
        private System.Windows.Forms.Button homeBtn;
    }
}