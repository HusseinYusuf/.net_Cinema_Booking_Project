
namespace Cinema_Booking_Sample
{
    partial class Main
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
            this.textName = new System.Windows.Forms.TextBox();
            this.textSurname = new System.Windows.Forms.TextBox();
            this.textEmail = new System.Windows.Forms.TextBox();
            this.textPassw = new System.Windows.Forms.TextBox();
            this.textConfirm = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textPhone = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textName
            // 
            this.textName.Location = new System.Drawing.Point(396, 131);
            this.textName.Name = "textName";
            this.textName.Size = new System.Drawing.Size(216, 20);
            this.textName.TabIndex = 0;
            this.textName.TextChanged += new System.EventHandler(this.textName_TextChanged);
            // 
            // textSurname
            // 
            this.textSurname.Location = new System.Drawing.Point(396, 157);
            this.textSurname.Name = "textSurname";
            this.textSurname.Size = new System.Drawing.Size(216, 20);
            this.textSurname.TabIndex = 1;
            this.textSurname.TextChanged += new System.EventHandler(this.textPhone_TextChanged);
            // 
            // textEmail
            // 
            this.textEmail.Location = new System.Drawing.Point(396, 183);
            this.textEmail.Name = "textEmail";
            this.textEmail.Size = new System.Drawing.Size(216, 20);
            this.textEmail.TabIndex = 2;
            this.textEmail.TextChanged += new System.EventHandler(this.textEmail_TextChanged);
            // 
            // textPassw
            // 
            this.textPassw.Location = new System.Drawing.Point(396, 235);
            this.textPassw.Name = "textPassw";
            this.textPassw.PasswordChar = '*';
            this.textPassw.Size = new System.Drawing.Size(216, 20);
            this.textPassw.TabIndex = 3;
            this.textPassw.TextChanged += new System.EventHandler(this.textPassw_TextChanged);
            // 
            // textConfirm
            // 
            this.textConfirm.Location = new System.Drawing.Point(396, 261);
            this.textConfirm.Name = "textConfirm";
            this.textConfirm.PasswordChar = '*';
            this.textConfirm.Size = new System.Drawing.Size(216, 20);
            this.textConfirm.TabIndex = 4;
            this.textConfirm.TextChanged += new System.EventHandler(this.textConfirm_TextChanged);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.button1.Location = new System.Drawing.Point(396, 335);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 39);
            this.button1.TabIndex = 5;
            this.button1.Text = "Register";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.button2.Location = new System.Drawing.Point(537, 335);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 39);
            this.button2.TabIndex = 6;
            this.button2.Text = "Cancel";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Red;
            this.button3.Location = new System.Drawing.Point(396, 70);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(216, 55);
            this.button3.TabIndex = 7;
            this.button3.Text = "Registration";
            this.button3.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(322, 134);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(313, 160);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Surname";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(325, 183);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Email";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(308, 238);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Password";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(285, 264);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Confirm Password";
            // 
            // textPhone
            // 
            this.textPhone.Location = new System.Drawing.Point(396, 209);
            this.textPhone.Name = "textPhone";
            this.textPhone.Size = new System.Drawing.Size(216, 20);
            this.textPhone.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(322, 212);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(38, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "Phone";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BackgroundImage = global::Cinema_Booking_Sample.Properties.Resources.download;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textPhone);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textConfirm);
            this.Controls.Add(this.textPassw);
            this.Controls.Add(this.textEmail);
            this.Controls.Add(this.textSurname);
            this.Controls.Add(this.textName);
            this.Name = "Main";
            this.Text = "Main";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Main_FormClosing);
            this.Load += new System.EventHandler(this.Main_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textName;
        private System.Windows.Forms.TextBox textSurname;
        private System.Windows.Forms.TextBox textEmail;
        private System.Windows.Forms.TextBox textPassw;
        private System.Windows.Forms.TextBox textConfirm;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textPhone;
        private System.Windows.Forms.Label label6;
    }
}