﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HackManchesterLIVE
{
    public partial class UserProfile : BaseForm
    {
        private Label titleLbl;
        private Label genderLbl;
        private Label weightLbl;
        private Label heightLbl;
        private Label sleepTimeLbl;
        private Label wakeTimeLbl;
        private ListBox genderListBox;
        private NumericUpDown heightUpDown;
        private NumericUpDown weightUpDown;
        private DateTimePicker wakeTimePicker;
        private Button updateDetailsBtn;
        private Button backBtn;
        private DateTimePicker sleepDateTimePicker;
        private Label updatedDetailsConfirmationLbl;
        public Home home;

        public UserProfile()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            this.titleLbl = new System.Windows.Forms.Label();
            this.genderLbl = new System.Windows.Forms.Label();
            this.weightLbl = new System.Windows.Forms.Label();
            this.heightLbl = new System.Windows.Forms.Label();
            this.sleepTimeLbl = new System.Windows.Forms.Label();
            this.wakeTimeLbl = new System.Windows.Forms.Label();
            this.genderListBox = new System.Windows.Forms.ListBox();
            this.sleepDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.heightUpDown = new System.Windows.Forms.NumericUpDown();
            this.weightUpDown = new System.Windows.Forms.NumericUpDown();
            this.wakeTimePicker = new System.Windows.Forms.DateTimePicker();
            this.updateDetailsBtn = new System.Windows.Forms.Button();
            this.backBtn = new System.Windows.Forms.Button();
            this.updatedDetailsConfirmationLbl = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.heightUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.weightUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // titleLbl
            // 
            this.titleLbl.AutoSize = true;
            this.titleLbl.Font = new System.Drawing.Font("Segoe UI", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLbl.Location = new System.Drawing.Point(81, 9);
            this.titleLbl.Name = "titleLbl";
            this.titleLbl.Size = new System.Drawing.Size(210, 50);
            this.titleLbl.TabIndex = 0;
            this.titleLbl.Text = "User Profile";
            // 
            // genderLbl
            // 
            this.genderLbl.AutoSize = true;
            this.genderLbl.Location = new System.Drawing.Point(30, 76);
            this.genderLbl.Name = "genderLbl";
            this.genderLbl.Size = new System.Drawing.Size(74, 25);
            this.genderLbl.TabIndex = 1;
            this.genderLbl.Text = "Gender";
            // 
            // weightLbl
            // 
            this.weightLbl.AutoSize = true;
            this.weightLbl.Location = new System.Drawing.Point(30, 166);
            this.weightLbl.Name = "weightLbl";
            this.weightLbl.Size = new System.Drawing.Size(72, 25);
            this.weightLbl.TabIndex = 2;
            this.weightLbl.Text = "Weight";
            // 
            // heightLbl
            // 
            this.heightLbl.AutoSize = true;
            this.heightLbl.Location = new System.Drawing.Point(30, 117);
            this.heightLbl.Name = "heightLbl";
            this.heightLbl.Size = new System.Drawing.Size(68, 25);
            this.heightLbl.TabIndex = 3;
            this.heightLbl.Text = "Height";
            // 
            // sleepTimeLbl
            // 
            this.sleepTimeLbl.AutoSize = true;
            this.sleepTimeLbl.Location = new System.Drawing.Point(30, 212);
            this.sleepTimeLbl.Name = "sleepTimeLbl";
            this.sleepTimeLbl.Size = new System.Drawing.Size(132, 50);
            this.sleepTimeLbl.TabIndex = 6;
            this.sleepTimeLbl.Text = "Average Sleep\r\nStart Time";
            // 
            // wakeTimeLbl
            // 
            this.wakeTimeLbl.AutoSize = true;
            this.wakeTimeLbl.Location = new System.Drawing.Point(34, 272);
            this.wakeTimeLbl.Name = "wakeTimeLbl";
            this.wakeTimeLbl.Size = new System.Drawing.Size(140, 50);
            this.wakeTimeLbl.TabIndex = 7;
            this.wakeTimeLbl.Text = "Average Wake-\r\nup  Time";
            // 
            // genderListBox
            // 
            this.genderListBox.FormattingEnabled = true;
            this.genderListBox.ItemHeight = 25;
            this.genderListBox.Items.AddRange(new object[] {
            "Female",
            "Male"});
            this.genderListBox.Location = new System.Drawing.Point(174, 76);
            this.genderListBox.Name = "genderListBox";
            this.genderListBox.Size = new System.Drawing.Size(107, 29);
            this.genderListBox.TabIndex = 8;
            // 
            // sleepDateTimePicker
            // 
            this.sleepDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.sleepDateTimePicker.Location = new System.Drawing.Point(174, 212);
            this.sleepDateTimePicker.Name = "sleepDateTimePicker";
            this.sleepDateTimePicker.ShowUpDown = true;
            this.sleepDateTimePicker.Size = new System.Drawing.Size(107, 33);
            this.sleepDateTimePicker.TabIndex = 11;
            this.sleepDateTimePicker.Value = new System.DateTime(2018, 10, 28, 0, 23, 0, 0);
            // 
            // heightUpDown
            // 
            this.heightUpDown.Location = new System.Drawing.Point(174, 117);
            this.heightUpDown.Name = "heightUpDown";
            this.heightUpDown.Size = new System.Drawing.Size(107, 33);
            this.heightUpDown.TabIndex = 12;
            // 
            // weightUpDown
            // 
            this.weightUpDown.DecimalPlaces = 2;
            this.weightUpDown.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.weightUpDown.Location = new System.Drawing.Point(174, 164);
            this.weightUpDown.Name = "weightUpDown";
            this.weightUpDown.Size = new System.Drawing.Size(107, 33);
            this.weightUpDown.TabIndex = 13;
            // 
            // wakeTimePicker
            // 
            this.wakeTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.wakeTimePicker.Location = new System.Drawing.Point(174, 272);
            this.wakeTimePicker.Name = "wakeTimePicker";
            this.wakeTimePicker.ShowUpDown = true;
            this.wakeTimePicker.Size = new System.Drawing.Size(107, 33);
            this.wakeTimePicker.TabIndex = 14;
            this.wakeTimePicker.Value = new System.DateTime(2018, 10, 28, 0, 23, 0, 0);
            // 
            // updateDetailsBtn
            // 
            this.updateDetailsBtn.Location = new System.Drawing.Point(215, 340);
            this.updateDetailsBtn.Name = "updateDetailsBtn";
            this.updateDetailsBtn.Size = new System.Drawing.Size(145, 57);
            this.updateDetailsBtn.TabIndex = 15;
            this.updateDetailsBtn.Text = "Update Details";
            this.updateDetailsBtn.UseVisualStyleBackColor = true;
            this.updateDetailsBtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // backBtn
            // 
            this.backBtn.Location = new System.Drawing.Point(50, 340);
            this.backBtn.Name = "backBtn";
            this.backBtn.Size = new System.Drawing.Size(145, 57);
            this.backBtn.TabIndex = 16;
            this.backBtn.Text = "Back";
            this.backBtn.UseVisualStyleBackColor = true;
            this.backBtn.Click += new System.EventHandler(this.button2_Click);
            // 
            // updatedDetailsConfirmationLbl
            // 
            this.updatedDetailsConfirmationLbl.AutoSize = true;
            this.updatedDetailsConfirmationLbl.Location = new System.Drawing.Point(30, 142);
            this.updatedDetailsConfirmationLbl.Name = "updatedDetailsConfirmationLbl";
            this.updatedDetailsConfirmationLbl.Size = new System.Drawing.Size(0, 25);
            this.updatedDetailsConfirmationLbl.TabIndex = 17;
            // 
            // UserProfile
            // 
            this.ClientSize = new System.Drawing.Size(386, 615);
            this.Controls.Add(this.updatedDetailsConfirmationLbl);
            this.Controls.Add(this.backBtn);
            this.Controls.Add(this.updateDetailsBtn);
            this.Controls.Add(this.wakeTimePicker);
            this.Controls.Add(this.weightUpDown);
            this.Controls.Add(this.heightUpDown);
            this.Controls.Add(this.sleepDateTimePicker);
            this.Controls.Add(this.genderListBox);
            this.Controls.Add(this.wakeTimeLbl);
            this.Controls.Add(this.sleepTimeLbl);
            this.Controls.Add(this.heightLbl);
            this.Controls.Add(this.weightLbl);
            this.Controls.Add(this.genderLbl);
            this.Controls.Add(this.titleLbl);
            this.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "UserProfile";
            ((System.ComponentModel.ISupportInitialize)(this.heightUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.weightUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Details succesfully updated");
           
            if (home == null)
            {
                home = new Home();
                home.FormClosed += delegate { home = null; };
            }
            home.Show();
            this.Hide(); 
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (home == null)
            {
                home = new Home();
                home.FormClosed += delegate { home = null; };
            }
            home.Show();
            this.Hide();
        }
    }
}
