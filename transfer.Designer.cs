namespace ATMuto
{
    partial class transfer
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
            System.Windows.Forms.Button trans;
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.back = new System.Windows.Forms.Label();
            this.amount = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.balancetbl = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.accNumberToLabel = new System.Windows.Forms.Label();
            this.accountNumberTo = new System.Windows.Forms.TextBox();
            trans = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // trans
            // 
            trans.BackColor = System.Drawing.Color.DodgerBlue;
            trans.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            trans.FlatAppearance.BorderSize = 10;
            trans.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            trans.Font = new System.Drawing.Font("Mongolian Baiti", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            trans.ForeColor = System.Drawing.Color.LavenderBlush;
            trans.Location = new System.Drawing.Point(300, 300);
            trans.Name = "trans";
            trans.Size = new System.Drawing.Size(159, 31);
            trans.TabIndex = 45;
            trans.Text = "Transfer";
            trans.UseCompatibleTextRendering = true;
            trans.UseVisualStyleBackColor = false;
            trans.Click += new System.EventHandler(this.trans_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DodgerBlue;
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(625, 100);
            this.panel1.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Mongolian Baiti", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(190, 36);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(241, 30);
            this.label3.TabIndex = 3;
            this.label3.Text = "KLL Online Bank";
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 23);
            this.label1.TabIndex = 4;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DodgerBlue;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 390);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(625, 17);
            this.panel2.TabIndex = 41;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.Control;
            this.label4.Font = new System.Drawing.Font("Mongolian Baiti", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label4.Location = new System.Drawing.Point(263, 114);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(102, 25);
            this.label4.TabIndex = 42;
            this.label4.Text = "Transfer";
            // 
            // back
            // 
            this.back.AutoSize = true;
            this.back.Font = new System.Drawing.Font("Mongolian Baiti", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.back.ForeColor = System.Drawing.Color.DodgerBlue;
            this.back.Location = new System.Drawing.Point(344, 351);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(52, 20);
            this.back.TabIndex = 46;
            this.back.Text = "Back";
            this.back.Click += new System.EventHandler(this.back_Click);
            // 
            // amount
            // 
            this.amount.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.amount.Location = new System.Drawing.Point(268, 247);
            this.amount.Name = "amount";
            this.amount.Size = new System.Drawing.Size(221, 30);
            this.amount.TabIndex = 44;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Mongolian Baiti", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label13.Location = new System.Drawing.Point(74, 247);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(104, 25);
            this.label13.TabIndex = 43;
            this.label13.Text = "Amount:";
            // 
            // balancetbl
            // 
            this.balancetbl.AutoSize = true;
            this.balancetbl.BackColor = System.Drawing.SystemColors.Control;
            this.balancetbl.Font = new System.Drawing.Font("Mongolian Baiti", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.balancetbl.ForeColor = System.Drawing.Color.DodgerBlue;
            this.balancetbl.Location = new System.Drawing.Point(74, 167);
            this.balancetbl.Name = "balancetbl";
            this.balancetbl.Size = new System.Drawing.Size(192, 25);
            this.balancetbl.TabIndex = 47;
            this.balancetbl.Text = "Current Balance:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.Control;
            this.label2.Font = new System.Drawing.Font("Mongolian Baiti", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label2.Location = new System.Drawing.Point(209, 167);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 25);
            this.label2.TabIndex = 48;
            // 
            // accNumberToLabel
            // 
            this.accNumberToLabel.AutoSize = true;
            this.accNumberToLabel.Font = new System.Drawing.Font("Mongolian Baiti", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.accNumberToLabel.ForeColor = System.Drawing.Color.DodgerBlue;
            this.accNumberToLabel.Location = new System.Drawing.Point(74, 208);
            this.accNumberToLabel.Name = "accNumberToLabel";
            this.accNumberToLabel.Size = new System.Drawing.Size(188, 25);
            this.accNumberToLabel.TabIndex = 49;
            this.accNumberToLabel.Text = "Acount Number:";
            // 
            // accountNumberTo
            // 
            this.accountNumberTo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.accountNumberTo.Location = new System.Drawing.Point(268, 203);
            this.accountNumberTo.Name = "accountNumberTo";
            this.accountNumberTo.Size = new System.Drawing.Size(221, 30);
            this.accountNumberTo.TabIndex = 50;
            // 
            // transfer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.Disable;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(625, 407);
            this.Controls.Add(this.accountNumberTo);
            this.Controls.Add(this.accNumberToLabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.balancetbl);
            this.Controls.Add(this.back);
            this.Controls.Add(trans);
            this.Controls.Add(this.amount);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "transfer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "withdraw";
            this.Load += new System.EventHandler(this.transfer_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label back;
        private System.Windows.Forms.TextBox amount;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label balancetbl;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label accNumberToLabel;
        private System.Windows.Forms.TextBox accountNumberTo;
    }
}