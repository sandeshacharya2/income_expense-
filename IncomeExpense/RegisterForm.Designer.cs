namespace IncomeExpense
{
    partial class RegisterForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegisterForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.register_loginBtn = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.register_showPass = new System.Windows.Forms.CheckBox();
            this.register_btn = new System.Windows.Forms.Button();
            this.register_password = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.register_username = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.register = new System.Windows.Forms.Label();
            this.closeBtn = new System.Windows.Forms.Label();
            this.register_cPassword = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(121)))), ((int)(((byte)(84)))));
            this.panel1.Controls.Add(this.register_loginBtn);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(447, 602);
            this.panel1.TabIndex = 10;
            // 
            // register_loginBtn
            // 
            this.register_loginBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(121)))), ((int)(((byte)(84)))));
            this.register_loginBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(160)))), ((int)(((byte)(108)))));
            this.register_loginBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(160)))), ((int)(((byte)(108)))));
            this.register_loginBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.register_loginBtn.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.register_loginBtn.ForeColor = System.Drawing.Color.White;
            this.register_loginBtn.Location = new System.Drawing.Point(29, 436);
            this.register_loginBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.register_loginBtn.Name = "register_loginBtn";
            this.register_loginBtn.Size = new System.Drawing.Size(251, 39);
            this.register_loginBtn.TabIndex = 10;
            this.register_loginBtn.Text = "SIGN IN ";
            this.register_loginBtn.UseVisualStyleBackColor = false;
            this.register_loginBtn.Click += new System.EventHandler(this.register_loginBtn_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(83, 401);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(134, 24);
            this.label6.TabIndex = 10;
            this.label6.Text = "SIGN IN HERE";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(15, 209);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(359, 33);
            this.label2.TabIndex = 2;
            this.label2.Text = "Income and Expense Tracker";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(136, 94);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 100);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // register_showPass
            // 
            this.register_showPass.AutoSize = true;
            this.register_showPass.Cursor = System.Windows.Forms.Cursors.Hand;
            this.register_showPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.register_showPass.Location = new System.Drawing.Point(723, 471);
            this.register_showPass.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.register_showPass.Name = "register_showPass";
            this.register_showPass.Size = new System.Drawing.Size(175, 29);
            this.register_showPass.TabIndex = 18;
            this.register_showPass.Text = "Show Password";
            this.register_showPass.UseVisualStyleBackColor = true;
            this.register_showPass.CheckedChanged += new System.EventHandler(this.register_showPass_CheckedChanged);
            // 
            // register_btn
            // 
            this.register_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(121)))), ((int)(((byte)(84)))));
            this.register_btn.FlatAppearance.BorderSize = 0;
            this.register_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(160)))), ((int)(((byte)(108)))));
            this.register_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(160)))), ((int)(((byte)(108)))));
            this.register_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.register_btn.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.register_btn.ForeColor = System.Drawing.Color.White;
            this.register_btn.Location = new System.Drawing.Point(480, 471);
            this.register_btn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.register_btn.Name = "register_btn";
            this.register_btn.Size = new System.Drawing.Size(135, 39);
            this.register_btn.TabIndex = 17;
            this.register_btn.Text = "SIGN UP";
            this.register_btn.UseVisualStyleBackColor = false;
            this.register_btn.Click += new System.EventHandler(this.register_btn_Click);
            // 
            // register_password
            // 
            this.register_password.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.register_password.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.register_password.Location = new System.Drawing.Point(480, 319);
            this.register_password.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.register_password.Name = "register_password";
            this.register_password.PasswordChar = '*';
            this.register_password.Size = new System.Drawing.Size(311, 34);
            this.register_password.TabIndex = 16;
            this.register_password.TextChanged += new System.EventHandler(this.login_password_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(475, 277);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(94, 24);
            this.label5.TabIndex = 15;
            this.label5.Text = "Password";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // register_username
            // 
            this.register_username.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.register_username.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.register_username.Location = new System.Drawing.Point(480, 223);
            this.register_username.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.register_username.Name = "register_username";
            this.register_username.Size = new System.Drawing.Size(311, 34);
            this.register_username.TabIndex = 14;
            this.register_username.Tag = "";
            this.register_username.TextChanged += new System.EventHandler(this.register_username_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(475, 185);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 24);
            this.label4.TabIndex = 13;
            this.label4.Text = "Username";
            // 
            // register
            // 
            this.register.AutoSize = true;
            this.register.Font = new System.Drawing.Font("Tahoma", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.register.Location = new System.Drawing.Point(487, 111);
            this.register.Name = "register";
            this.register.Size = new System.Drawing.Size(142, 34);
            this.register.TabIndex = 12;
            this.register.Text = "REGISTER";
            // 
            // closeBtn
            // 
            this.closeBtn.AutoSize = true;
            this.closeBtn.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.closeBtn.Location = new System.Drawing.Point(888, 11);
            this.closeBtn.Name = "closeBtn";
            this.closeBtn.Size = new System.Drawing.Size(21, 21);
            this.closeBtn.TabIndex = 11;
            this.closeBtn.Text = "X";
            this.closeBtn.Click += new System.EventHandler(this.closeBtn_Click);
            // 
            // register_cPassword
            // 
            this.register_cPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.register_cPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.register_cPassword.Location = new System.Drawing.Point(480, 417);
            this.register_cPassword.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.register_cPassword.Name = "register_cPassword";
            this.register_cPassword.PasswordChar = '*';
            this.register_cPassword.Size = new System.Drawing.Size(311, 34);
            this.register_cPassword.TabIndex = 19;
            this.register_cPassword.TextChanged += new System.EventHandler(this.register_cPassword_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(475, 375);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(169, 24);
            this.label1.TabIndex = 20;
            this.label1.Text = "Confirm Password";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // RegisterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(919, 602);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.register_cPassword);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.register_showPass);
            this.Controls.Add(this.register_btn);
            this.Controls.Add(this.register_password);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.register_username);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.register);
            this.Controls.Add(this.closeBtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "RegisterForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RegisterForm";
            this.Load += new System.EventHandler(this.RegisterForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button register_loginBtn;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.CheckBox register_showPass;
        private System.Windows.Forms.Button register_btn;
        private System.Windows.Forms.TextBox register_password;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox register_username;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label register;
        private System.Windows.Forms.Label closeBtn;
        private System.Windows.Forms.TextBox register_cPassword;
        private System.Windows.Forms.Label label1;
    }
}