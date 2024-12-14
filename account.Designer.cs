using System;
using System.Windows.Forms;

namespace ATMuto
{
    partial class account
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
            this.ok = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.exit = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.AccNameTb = new System.Windows.Forms.TextBox();
            this.AccNumTb = new System.Windows.Forms.TextBox();
            this.AddressTb = new System.Windows.Forms.TextBox();
            this.LastnameTb = new System.Windows.Forms.TextBox();
            this.PhoneTb = new System.Windows.Forms.TextBox();
            this.pinTb = new System.Windows.Forms.TextBox();
            this.educationTb = new System.Windows.Forms.ComboBox();
            this.dobDate = new System.Windows.Forms.DateTimePicker();
            this.panel2 = new System.Windows.Forms.Panel();
            this.back = new System.Windows.Forms.Label();
            this.occupationTb = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.zipCode = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ok
            // 
            this.ok.BackColor = System.Drawing.Color.DodgerBlue;
            this.ok.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ok.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ok.FlatAppearance.BorderSize = 10;
            this.ok.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.ok.Font = new System.Drawing.Font("Mongolian Baiti", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ok.ForeColor = System.Drawing.Color.LavenderBlush;
            this.ok.Location = new System.Drawing.Point(493, 658);
            this.ok.Name = "ok";
            this.ok.Size = new System.Drawing.Size(185, 48);
            this.ok.TabIndex = 27;
            this.ok.Text = "Submit";
            this.ok.UseVisualStyleBackColor = false;
            this.ok.Click += new System.EventHandler(this.ok_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DodgerBlue;
            this.panel1.Controls.Add(this.exit);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1177, 100);
            this.panel1.TabIndex = 1;
            // 
            // exit
            // 
            this.exit.AutoSize = true;
            this.exit.BackColor = System.Drawing.Color.DodgerBlue;
            this.exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exit.ForeColor = System.Drawing.Color.White;
            this.exit.Location = new System.Drawing.Point(1132, 9);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(33, 31);
            this.exit.TabIndex = 5;
            this.exit.Text = "X";
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Mongolian Baiti", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(418, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(325, 43);
            this.label3.TabIndex = 4;
            this.label3.Text = "KLL Online Bank";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Mongolian Baiti", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label4.Location = new System.Drawing.Point(71, 377);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(163, 29);
            this.label4.TabIndex = 5;
            this.label4.Text = "Acc Number";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Mongolian Baiti", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label2.Location = new System.Drawing.Point(71, 197);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 29);
            this.label2.TabIndex = 6;
            this.label2.Text = "Name";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Mongolian Baiti", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label5.Location = new System.Drawing.Point(651, 473);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(190, 29);
            this.label5.TabIndex = 7;
            this.label5.Text = "Phone Number";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Mongolian Baiti", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label6.Location = new System.Drawing.Point(71, 471);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(111, 29);
            this.label6.TabIndex = 8;
            this.label6.Text = "Address";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Mongolian Baiti", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label7.Location = new System.Drawing.Point(71, 284);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(141, 29);
            this.label7.TabIndex = 9;
            this.label7.Text = "Last Name";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Mongolian Baiti", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label8.Location = new System.Drawing.Point(651, 196);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(53, 29);
            this.label8.TabIndex = 10;
            this.label8.Text = "Pin";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Mongolian Baiti", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label10.Location = new System.Drawing.Point(651, 378);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(151, 29);
            this.label10.TabIndex = 12;
            this.label10.Text = "Occupation";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Mongolian Baiti", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label11.Location = new System.Drawing.Point(651, 284);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(135, 29);
            this.label11.TabIndex = 13;
            this.label11.Text = "Education";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Mongolian Baiti", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label12.Location = new System.Drawing.Point(651, 554);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(178, 29);
            this.label12.TabIndex = 14;
            this.label12.Text = "Date Of Birth";
            // 
            // AccNameTb
            // 
            this.AccNameTb.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AccNameTb.Location = new System.Drawing.Point(240, 197);
            this.AccNameTb.Name = "AccNameTb";
            this.AccNameTb.Size = new System.Drawing.Size(221, 30);
            this.AccNameTb.TabIndex = 15;
            // 
            // AccNumTb
            // 
            this.AccNumTb.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AccNumTb.Location = new System.Drawing.Point(240, 376);
            this.AccNumTb.Name = "AccNumTb";
            this.AccNumTb.Size = new System.Drawing.Size(221, 30);
            this.AccNumTb.TabIndex = 16;
            // 
            // AddressTb
            // 
            this.AddressTb.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddressTb.Location = new System.Drawing.Point(240, 473);
            this.AddressTb.Multiline = true;
            this.AddressTb.Name = "AddressTb";
            this.AddressTb.Size = new System.Drawing.Size(221, 29);
            this.AddressTb.TabIndex = 17;
            this.AddressTb.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // LastnameTb
            // 
            this.LastnameTb.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LastnameTb.Location = new System.Drawing.Point(240, 288);
            this.LastnameTb.Name = "LastnameTb";
            this.LastnameTb.Size = new System.Drawing.Size(221, 30);
            this.LastnameTb.TabIndex = 18;
            // 
            // PhoneTb
            // 
            this.PhoneTb.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PhoneTb.Location = new System.Drawing.Point(847, 471);
            this.PhoneTb.Name = "PhoneTb";
            this.PhoneTb.Size = new System.Drawing.Size(221, 30);
            this.PhoneTb.TabIndex = 19;
            // 
            // pinTb
            // 
            this.pinTb.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pinTb.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.pinTb.Location = new System.Drawing.Point(847, 196);
            this.pinTb.Name = "pinTb";
            this.pinTb.Size = new System.Drawing.Size(221, 30);
            this.pinTb.TabIndex = 20;
            // 
            // educationTb
            // 
            this.educationTb.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.educationTb.FormattingEnabled = true;
            this.educationTb.ItemHeight = 25;
            this.educationTb.Items.AddRange(new object[] {
            "Non Graduate",
            "Under Graduate",
            "Post Graduate"});
            this.educationTb.Location = new System.Drawing.Point(847, 285);
            this.educationTb.Name = "educationTb";
            this.educationTb.Size = new System.Drawing.Size(221, 33);
            this.educationTb.TabIndex = 23;
            // 
            // dobDate
            // 
            this.dobDate.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dobDate.CalendarForeColor = System.Drawing.Color.LightPink;
            this.dobDate.CalendarMonthBackground = System.Drawing.Color.LavenderBlush;
            this.dobDate.CalendarTitleBackColor = System.Drawing.Color.Pink;
            this.dobDate.CalendarTitleForeColor = System.Drawing.Color.PaleVioletRed;
            this.dobDate.CalendarTrailingForeColor = System.Drawing.Color.LightPink;
            this.dobDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dobDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dobDate.Location = new System.Drawing.Point(847, 554);
            this.dobDate.Name = "dobDate";
            this.dobDate.Size = new System.Drawing.Size(221, 30);
            this.dobDate.TabIndex = 26;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DodgerBlue;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 776);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1177, 22);
            this.panel2.TabIndex = 28;
            // 
            // back
            // 
            this.back.AutoSize = true;
            this.back.Cursor = System.Windows.Forms.Cursors.Hand;
            this.back.Font = new System.Drawing.Font("Mongolian Baiti", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.back.ForeColor = System.Drawing.Color.DodgerBlue;
            this.back.Location = new System.Drawing.Point(551, 721);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(52, 20);
            this.back.TabIndex = 29;
            this.back.Text = "Back";
            this.back.Click += new System.EventHandler(this.back_click);
            // 
            // occupationTb
            // 
            this.occupationTb.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.occupationTb.Location = new System.Drawing.Point(847, 377);
            this.occupationTb.Name = "occupationTb";
            this.occupationTb.Size = new System.Drawing.Size(221, 30);
            this.occupationTb.TabIndex = 30;
            this.occupationTb.TextChanged += new System.EventHandler(this.textBox7_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Mongolian Baiti", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label1.Location = new System.Drawing.Point(71, 556);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 29);
            this.label1.TabIndex = 31;
            this.label1.Text = "Zip Code";
            // 
            // zipCode
            // 
            this.zipCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.zipCode.Location = new System.Drawing.Point(240, 556);
            this.zipCode.Multiline = true;
            this.zipCode.Name = "zipCode";
            this.zipCode.Size = new System.Drawing.Size(221, 29);
            this.zipCode.TabIndex = 32;
            // 
            // account
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1177, 798);
            this.Controls.Add(this.zipCode);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.occupationTb);
            this.Controls.Add(this.back);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.ok);
            this.Controls.Add(this.dobDate);
            this.Controls.Add(this.educationTb);
            this.Controls.Add(this.PhoneTb);
            this.Controls.Add(this.pinTb);
            this.Controls.Add(this.AddressTb);
            this.Controls.Add(this.LastnameTb);
            this.Controls.Add(this.AccNameTb);
            this.Controls.Add(this.AccNumTb);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "account";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "account";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {
        
        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void label12_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
        
        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label exit;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox AccNameTb;
        private System.Windows.Forms.TextBox AddressTb;
        private System.Windows.Forms.TextBox LastnameTb;
        private System.Windows.Forms.TextBox PhoneTb;
        private System.Windows.Forms.ComboBox educationTb;
        private System.Windows.Forms.DateTimePicker dobDate;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label back;
        private System.Windows.Forms.TextBox occupationTb;
        private Button ok;
        private TextBox pinTb;
        private TextBox AccNumTb;
        private Label label1;
        private TextBox zipCode;
    }
}