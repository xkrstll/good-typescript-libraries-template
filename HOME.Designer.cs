namespace ATMuto
{
    partial class HOME
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
            System.Windows.Forms.Button transfer;
            System.Windows.Forms.Button miniState;
            System.Windows.Forms.Button balance;
            System.Windows.Forms.Button changePin;
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.exit = new System.Windows.Forms.Label();
            this.AccNumtbl = new System.Windows.Forms.Label();
            this.backToLogin = new System.Windows.Forms.Label();
            transfer = new System.Windows.Forms.Button();
            miniState = new System.Windows.Forms.Button();
            balance = new System.Windows.Forms.Button();
            changePin = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // transfer
            // 
            transfer.BackColor = System.Drawing.Color.DodgerBlue;
            transfer.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            transfer.FlatAppearance.BorderSize = 10;
            transfer.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            transfer.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            transfer.ForeColor = System.Drawing.Color.LavenderBlush;
            transfer.Location = new System.Drawing.Point(98, 221);
            transfer.Name = "transfer";
            transfer.Size = new System.Drawing.Size(229, 56);
            transfer.TabIndex = 12;
            transfer.Text = "TRANSFER";
            transfer.UseCompatibleTextRendering = true;
            transfer.UseVisualStyleBackColor = false;
            transfer.Click += new System.EventHandler(this.transfer_Click);
            // 
            // miniState
            // 
            miniState.BackColor = System.Drawing.Color.DodgerBlue;
            miniState.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            miniState.FlatAppearance.BorderSize = 10;
            miniState.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            miniState.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            miniState.ForeColor = System.Drawing.Color.LavenderBlush;
            miniState.Location = new System.Drawing.Point(460, 353);
            miniState.Name = "miniState";
            miniState.Size = new System.Drawing.Size(229, 56);
            miniState.TabIndex = 14;
            miniState.Text = "MINI STATEMENT";
            miniState.UseCompatibleTextRendering = true;
            miniState.UseVisualStyleBackColor = false;
            miniState.Click += new System.EventHandler(this.miniState_Click);
            // 
            // balance
            // 
            balance.BackColor = System.Drawing.Color.DodgerBlue;
            balance.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            balance.FlatAppearance.BorderSize = 10;
            balance.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            balance.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            balance.ForeColor = System.Drawing.Color.LavenderBlush;
            balance.Location = new System.Drawing.Point(98, 353);
            balance.Name = "balance";
            balance.Size = new System.Drawing.Size(229, 56);
            balance.TabIndex = 15;
            balance.Text = "BALANCE";
            balance.UseCompatibleTextRendering = true;
            balance.UseVisualStyleBackColor = false;
            balance.Click += new System.EventHandler(this.balance_Click);
            // 
            // changePin
            // 
            changePin.BackColor = System.Drawing.Color.DodgerBlue;
            changePin.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            changePin.FlatAppearance.BorderSize = 10;
            changePin.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            changePin.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            changePin.ForeColor = System.Drawing.Color.LavenderBlush;
            changePin.Location = new System.Drawing.Point(460, 221);
            changePin.Name = "changePin";
            changePin.Size = new System.Drawing.Size(229, 56);
            changePin.TabIndex = 16;
            changePin.Text = "CHANGE PIN";
            changePin.UseCompatibleTextRendering = true;
            changePin.UseVisualStyleBackColor = false;
            changePin.Click += new System.EventHandler(this.changepin_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DodgerBlue;
            this.panel1.Controls.Add(this.label3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 100);
            this.panel1.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Mongolian Baiti", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(125, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(551, 43);
            this.label3.TabIndex = 4;
            this.label3.Text = "Select Your Transaction Please";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DodgerBlue;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 510);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(800, 18);
            this.panel2.TabIndex = 17;
            // 
            // exit
            // 
            this.exit.AutoSize = true;
            this.exit.Font = new System.Drawing.Font("Mongolian Baiti", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exit.ForeColor = System.Drawing.Color.DodgerBlue;
            this.exit.Location = new System.Drawing.Point(303, 476);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(47, 20);
            this.exit.TabIndex = 18;
            this.exit.Text = "Quit";
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // AccNumtbl
            // 
            this.AccNumtbl.AutoSize = true;
            this.AccNumtbl.Font = new System.Drawing.Font("Mongolian Baiti", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AccNumtbl.ForeColor = System.Drawing.Color.DodgerBlue;
            this.AccNumtbl.Location = new System.Drawing.Point(303, 118);
            this.AccNumtbl.Name = "AccNumtbl";
            this.AccNumtbl.Size = new System.Drawing.Size(170, 23);
            this.AccNumtbl.TabIndex = 19;
            this.AccNumtbl.Text = "Account Number";
            // 
            // backToLogin
            // 
            this.backToLogin.AutoSize = true;
            this.backToLogin.Font = new System.Drawing.Font("Mongolian Baiti", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backToLogin.ForeColor = System.Drawing.Color.DodgerBlue;
            this.backToLogin.Location = new System.Drawing.Point(381, 476);
            this.backToLogin.Name = "backToLogin";
            this.backToLogin.Size = new System.Drawing.Size(73, 20);
            this.backToLogin.TabIndex = 20;
            this.backToLogin.Text = "Sign In";
            this.backToLogin.Click += new System.EventHandler(this.backToLogin_Click);
            // 
            // HOME
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 528);
            this.Controls.Add(this.backToLogin);
            this.Controls.Add(this.AccNumtbl);
            this.Controls.Add(this.exit);
            this.Controls.Add(this.panel2);
            this.Controls.Add(changePin);
            this.Controls.Add(balance);
            this.Controls.Add(miniState);
            this.Controls.Add(transfer);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "HOME";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HOME";
            this.Load += new System.EventHandler(this.HOME_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label exit;
        private System.Windows.Forms.Label AccNumtbl;
        private System.Windows.Forms.Label backToLogin;
    }
}