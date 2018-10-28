using System;
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
        private Button updateDetailsBtn;
        private Button backBtn;
        private Label updatedDetailsConfirmationLbl;
        private Panel panel1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        public Home home;

        public UserProfile()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            this.updatedDetailsConfirmationLbl = new System.Windows.Forms.Label();
            this.updateDetailsBtn = new System.Windows.Forms.Button();
            this.weightUpDown = new System.Windows.Forms.NumericUpDown();
            this.heightUpDown = new System.Windows.Forms.NumericUpDown();
            this.genderListBox = new System.Windows.Forms.ListBox();
            this.wakeTimeLbl = new System.Windows.Forms.Label();
            this.sleepTimeLbl = new System.Windows.Forms.Label();
            this.heightLbl = new System.Windows.Forms.Label();
            this.weightLbl = new System.Windows.Forms.Label();
            this.genderLbl = new System.Windows.Forms.Label();
            this.titleLbl = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.backBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.weightUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.heightUpDown)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // updatedDetailsConfirmationLbl
            // 
            this.updatedDetailsConfirmationLbl.AutoSize = true;
            this.updatedDetailsConfirmationLbl.Location = new System.Drawing.Point(14, 191);
            this.updatedDetailsConfirmationLbl.Name = "updatedDetailsConfirmationLbl";
            this.updatedDetailsConfirmationLbl.Size = new System.Drawing.Size(0, 32);
            this.updatedDetailsConfirmationLbl.TabIndex = 17;
            // 
            // updateDetailsBtn
            // 
            this.updateDetailsBtn.BackColor = System.Drawing.Color.LightSteelBlue;
            this.updateDetailsBtn.Location = new System.Drawing.Point(20, 521);
            this.updateDetailsBtn.Name = "updateDetailsBtn";
            this.updateDetailsBtn.Size = new System.Drawing.Size(339, 57);
            this.updateDetailsBtn.TabIndex = 15;
            this.updateDetailsBtn.Text = "Update Details";
            this.updateDetailsBtn.UseVisualStyleBackColor = false;
            this.updateDetailsBtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // weightUpDown
            // 
            this.weightUpDown.DecimalPlaces = 2;
            this.weightUpDown.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.weightUpDown.Location = new System.Drawing.Point(176, 223);
            this.weightUpDown.Name = "weightUpDown";
            this.weightUpDown.Size = new System.Drawing.Size(107, 39);
            this.weightUpDown.TabIndex = 13;
            // 
            // heightUpDown
            // 
            this.heightUpDown.DecimalPlaces = 2;
            this.heightUpDown.Location = new System.Drawing.Point(176, 166);
            this.heightUpDown.Name = "heightUpDown";
            this.heightUpDown.Size = new System.Drawing.Size(107, 39);
            this.heightUpDown.TabIndex = 12;
            // 
            // genderListBox
            // 
            this.genderListBox.FormattingEnabled = true;
            this.genderListBox.ItemHeight = 32;
            this.genderListBox.Items.AddRange(new object[] {
            "Female",
            "Male"});
            this.genderListBox.Location = new System.Drawing.Point(176, 112);
            this.genderListBox.Name = "genderListBox";
            this.genderListBox.Size = new System.Drawing.Size(107, 36);
            this.genderListBox.TabIndex = 8;
            // 
            // wakeTimeLbl
            // 
            this.wakeTimeLbl.AutoSize = true;
            this.wakeTimeLbl.BackColor = System.Drawing.Color.Transparent;
            this.wakeTimeLbl.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.wakeTimeLbl.ForeColor = System.Drawing.Color.White;
            this.wakeTimeLbl.Location = new System.Drawing.Point(9, 302);
            this.wakeTimeLbl.Name = "wakeTimeLbl";
            this.wakeTimeLbl.Size = new System.Drawing.Size(199, 23);
            this.wakeTimeLbl.TabIndex = 7;
            this.wakeTimeLbl.Text = "Daily Screen-Time Usage";
            // 
            // sleepTimeLbl
            // 
            this.sleepTimeLbl.AutoSize = true;
            this.sleepTimeLbl.BackColor = System.Drawing.Color.Transparent;
            this.sleepTimeLbl.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sleepTimeLbl.ForeColor = System.Drawing.Color.White;
            this.sleepTimeLbl.Location = new System.Drawing.Point(9, 343);
            this.sleepTimeLbl.Name = "sleepTimeLbl";
            this.sleepTimeLbl.Size = new System.Drawing.Size(259, 23);
            this.sleepTimeLbl.TabIndex = 6;
            this.sleepTimeLbl.Text = "No. of Alarm shut-offs (morning)";
            // 
            // heightLbl
            // 
            this.heightLbl.AutoSize = true;
            this.heightLbl.BackColor = System.Drawing.Color.Transparent;
            this.heightLbl.ForeColor = System.Drawing.Color.White;
            this.heightLbl.Location = new System.Drawing.Point(14, 166);
            this.heightLbl.Name = "heightLbl";
            this.heightLbl.Size = new System.Drawing.Size(87, 32);
            this.heightLbl.TabIndex = 3;
            this.heightLbl.Text = "Height";
            // 
            // weightLbl
            // 
            this.weightLbl.AutoSize = true;
            this.weightLbl.BackColor = System.Drawing.Color.Transparent;
            this.weightLbl.ForeColor = System.Drawing.Color.White;
            this.weightLbl.Location = new System.Drawing.Point(14, 223);
            this.weightLbl.Name = "weightLbl";
            this.weightLbl.Size = new System.Drawing.Size(91, 32);
            this.weightLbl.TabIndex = 2;
            this.weightLbl.Text = "Weight";
            // 
            // genderLbl
            // 
            this.genderLbl.AutoSize = true;
            this.genderLbl.BackColor = System.Drawing.Color.Transparent;
            this.genderLbl.ForeColor = System.Drawing.Color.White;
            this.genderLbl.Location = new System.Drawing.Point(14, 112);
            this.genderLbl.Name = "genderLbl";
            this.genderLbl.Size = new System.Drawing.Size(93, 32);
            this.genderLbl.TabIndex = 1;
            this.genderLbl.Text = "Gender";
            // 
            // titleLbl
            // 
            this.titleLbl.AutoSize = true;
            this.titleLbl.BackColor = System.Drawing.Color.Transparent;
            this.titleLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLbl.Location = new System.Drawing.Point(100, 21);
            this.titleLbl.Name = "titleLbl";
            this.titleLbl.Size = new System.Drawing.Size(190, 44);
            this.titleLbl.TabIndex = 0;
            this.titleLbl.Text = "User Data";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightSteelBlue;
            this.panel1.Controls.Add(this.backBtn);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(384, 87);
            this.panel1.TabIndex = 18;
            // 
            // backBtn
            // 
            this.backBtn.BackgroundImage = global::HackManchesterLIVE.Properties.Resources.homeButton;
            this.backBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.backBtn.Location = new System.Drawing.Point(13, 8);
            this.backBtn.Name = "backBtn";
            this.backBtn.Size = new System.Drawing.Size(58, 57);
            this.backBtn.TabIndex = 16;
            this.backBtn.UseVisualStyleBackColor = true;
            this.backBtn.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(271, 302);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 23);
            this.label1.TabIndex = 19;
            this.label1.Text = "4h 12mins";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(307, 343);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(19, 23);
            this.label2.TabIndex = 20;
            this.label2.Text = "3";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(9, 390);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(239, 23);
            this.label3.TabIndex = 21;
            this.label3.Text = "Percentage of Tips Completed";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(297, 390);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 23);
            this.label4.TabIndex = 22;
            this.label4.Text = "75%";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(9, 440);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(268, 23);
            this.label5.TabIndex = 23;
            this.label5.Text = "Daily Body Clock Adjustment Rate";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(297, 440);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 23);
            this.label6.TabIndex = 24;
            this.label6.Text = "1hr";
            // 
            // UserProfile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.ClientSize = new System.Drawing.Size(384, 607);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.updatedDetailsConfirmationLbl);
            this.Controls.Add(this.updateDetailsBtn);
            this.Controls.Add(this.weightUpDown);
            this.Controls.Add(this.heightUpDown);
            this.Controls.Add(this.genderListBox);
            this.Controls.Add(this.wakeTimeLbl);
            this.Controls.Add(this.sleepTimeLbl);
            this.Controls.Add(this.heightLbl);
            this.Controls.Add(this.weightLbl);
            this.Controls.Add(this.genderLbl);
            this.Controls.Add(this.titleLbl);
            this.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "UserProfile";
            this.Load += new System.EventHandler(this.UserProfile_Load);
            ((System.ComponentModel.ISupportInitialize)(this.weightUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.heightUpDown)).EndInit();
            this.panel1.ResumeLayout(false);
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

        private void UserProfile_Load(object sender, EventArgs e)
        {

        }
    }
}
