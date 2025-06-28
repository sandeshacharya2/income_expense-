namespace IncomeExpense
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.closeBtn = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.logout_btn = new System.Windows.Forms.Button();
            this.expense_btn = new System.Windows.Forms.Button();
            this.income_btn = new System.Windows.Forms.Button();
            this.addCategory_btn = new System.Windows.Forms.Button();
            this.dashboard_btn = new System.Windows.Forms.Button();
            this.greetUser = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.backgroundWorker2 = new System.ComponentModel.BackgroundWorker();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dashboardUserForm1 = new IncomeExpense.DashboardUserForm();
            this.expenseForm1 = new IncomeExpense.ExpenseForm();
            this.incomeForm1 = new IncomeExpense.IncomeForm();
            this.categoriesForm1 = new IncomeExpense.CategoriesForm();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.closeBtn);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1379, 45);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(37, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(269, 21);
            this.label1.TabIndex = 3;
            this.label1.Text = "Income and Expense Tracker";
            // 
            // closeBtn
            // 
            this.closeBtn.AutoSize = true;
            this.closeBtn.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.closeBtn.Location = new System.Drawing.Point(1353, 5);
            this.closeBtn.Name = "closeBtn";
            this.closeBtn.Size = new System.Drawing.Size(21, 21);
            this.closeBtn.TabIndex = 2;
            this.closeBtn.Text = "X";
            this.closeBtn.Click += new System.EventHandler(this.closeBtn_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(121)))), ((int)(((byte)(84)))));
            this.panel2.Controls.Add(this.pictureBox6);
            this.panel2.Controls.Add(this.pictureBox5);
            this.panel2.Controls.Add(this.pictureBox4);
            this.panel2.Controls.Add(this.pictureBox3);
            this.panel2.Controls.Add(this.pictureBox2);
            this.panel2.Controls.Add(this.logout_btn);
            this.panel2.Controls.Add(this.expense_btn);
            this.panel2.Controls.Add(this.income_btn);
            this.panel2.Controls.Add(this.addCategory_btn);
            this.panel2.Controls.Add(this.dashboard_btn);
            this.panel2.Controls.Add(this.greetUser);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel2.ForeColor = System.Drawing.Color.White;
            this.panel2.Location = new System.Drawing.Point(0, 45);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(234, 748);
            this.panel2.TabIndex = 1;
            // 
            // pictureBox6
            // 
            this.pictureBox6.Image = global::IncomeExpense.Properties.Resources.log_out_real;
            this.pictureBox6.Location = new System.Drawing.Point(44, 672);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(28, 33);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox6.TabIndex = 13;
            this.pictureBox6.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = global::IncomeExpense.Properties.Resources.expense_real;
            this.pictureBox5.Location = new System.Drawing.Point(23, 483);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(28, 33);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox5.TabIndex = 12;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::IncomeExpense.Properties.Resources.add_category_real;
            this.pictureBox4.Location = new System.Drawing.Point(24, 359);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(28, 33);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 11;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::IncomeExpense.Properties.Resources.income_real;
            this.pictureBox3.Location = new System.Drawing.Point(24, 426);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(28, 33);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 10;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::IncomeExpense.Properties.Resources.dashboard_real;
            this.pictureBox2.Location = new System.Drawing.Point(23, 300);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(28, 33);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 9;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // logout_btn
            // 
            this.logout_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(121)))), ((int)(((byte)(84)))));
            this.logout_btn.FlatAppearance.BorderSize = 0;
            this.logout_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.logout_btn.Location = new System.Drawing.Point(17, 665);
            this.logout_btn.Name = "logout_btn";
            this.logout_btn.Size = new System.Drawing.Size(201, 40);
            this.logout_btn.TabIndex = 8;
            this.logout_btn.Text = "Log Out";
            this.logout_btn.UseVisualStyleBackColor = false;
            this.logout_btn.Click += new System.EventHandler(this.button6_Click);
            // 
            // expense_btn
            // 
            this.expense_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(121)))), ((int)(((byte)(84)))));
            this.expense_btn.FlatAppearance.BorderSize = 0;
            this.expense_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.expense_btn.Location = new System.Drawing.Point(1, 476);
            this.expense_btn.Name = "expense_btn";
            this.expense_btn.Size = new System.Drawing.Size(201, 40);
            this.expense_btn.TabIndex = 7;
            this.expense_btn.Text = "Expenses";
            this.expense_btn.UseVisualStyleBackColor = false;
            this.expense_btn.Click += new System.EventHandler(this.expense_btn_Click);
            // 
            // income_btn
            // 
            this.income_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(121)))), ((int)(((byte)(84)))));
            this.income_btn.FlatAppearance.BorderSize = 0;
            this.income_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.income_btn.Location = new System.Drawing.Point(-10, 415);
            this.income_btn.Name = "income_btn";
            this.income_btn.Size = new System.Drawing.Size(201, 40);
            this.income_btn.TabIndex = 6;
            this.income_btn.Text = "Income";
            this.income_btn.UseVisualStyleBackColor = false;
            this.income_btn.Click += new System.EventHandler(this.income_btn_Click);
            // 
            // addCategory_btn
            // 
            this.addCategory_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(121)))), ((int)(((byte)(84)))));
            this.addCategory_btn.FlatAppearance.BorderSize = 0;
            this.addCategory_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addCategory_btn.Location = new System.Drawing.Point(37, 355);
            this.addCategory_btn.Name = "addCategory_btn";
            this.addCategory_btn.Size = new System.Drawing.Size(156, 40);
            this.addCategory_btn.TabIndex = 5;
            this.addCategory_btn.Text = "Add Category";
            this.addCategory_btn.UseVisualStyleBackColor = false;
            this.addCategory_btn.Click += new System.EventHandler(this.addCategory_btn_Click);
            // 
            // dashboard_btn
            // 
            this.dashboard_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(121)))), ((int)(((byte)(84)))));
            this.dashboard_btn.FlatAppearance.BorderSize = 0;
            this.dashboard_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dashboard_btn.Location = new System.Drawing.Point(44, 299);
            this.dashboard_btn.Name = "dashboard_btn";
            this.dashboard_btn.Size = new System.Drawing.Size(124, 40);
            this.dashboard_btn.TabIndex = 3;
            this.dashboard_btn.Text = "Dashboard";
            this.dashboard_btn.UseVisualStyleBackColor = false;
            this.dashboard_btn.Click += new System.EventHandler(this.button2_Click);
            // 
            // greetUser
            // 
            this.greetUser.AutoSize = true;
            this.greetUser.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.greetUser.ForeColor = System.Drawing.Color.White;
            this.greetUser.Location = new System.Drawing.Point(24, 189);
            this.greetUser.Name = "greetUser";
            this.greetUser.Size = new System.Drawing.Size(98, 24);
            this.greetUser.TabIndex = 3;
            this.greetUser.Text = "Welcome,";
            this.greetUser.Click += new System.EventHandler(this.label2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-23, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(253, 249);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Controls.Add(this.dashboardUserForm1);
            this.panel3.Controls.Add(this.expenseForm1);
            this.panel3.Controls.Add(this.incomeForm1);
            this.panel3.Controls.Add(this.categoriesForm1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(234, 45);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1145, 748);
            this.panel3.TabIndex = 0;
            // 
            // dashboardUserForm1
            // 
            this.dashboardUserForm1.Location = new System.Drawing.Point(2, 0);
            this.dashboardUserForm1.Name = "dashboardUserForm1";
            this.dashboardUserForm1.Size = new System.Drawing.Size(1140, 748);
            this.dashboardUserForm1.TabIndex = 3;
            this.dashboardUserForm1.Load += new System.EventHandler(this.dashboardUserForm1_Load);
            // 
            // expenseForm1
            // 
            this.expenseForm1.Location = new System.Drawing.Point(3, 3);
            this.expenseForm1.Name = "expenseForm1";
            this.expenseForm1.Size = new System.Drawing.Size(1142, 745);
            this.expenseForm1.TabIndex = 2;
            this.expenseForm1.Load += new System.EventHandler(this.expenseForm1_Load);
            // 
            // incomeForm1
            // 
            this.incomeForm1.BackColor = System.Drawing.SystemColors.Control;
            this.incomeForm1.Location = new System.Drawing.Point(9, 8);
            this.incomeForm1.Name = "incomeForm1";
            this.incomeForm1.Size = new System.Drawing.Size(1135, 719);
            this.incomeForm1.TabIndex = 1;
            this.incomeForm1.Load += new System.EventHandler(this.incomeForm1_Load);
            // 
            // categoriesForm1
            // 
            this.categoriesForm1.Location = new System.Drawing.Point(6, 6);
            this.categoriesForm1.Name = "categoriesForm1";
            this.categoriesForm1.Size = new System.Drawing.Size(1199, 742);
            this.categoriesForm1.TabIndex = 0;
            this.categoriesForm1.Load += new System.EventHandler(this.categoriesForm1_Load);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1379, 793);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainForm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label closeBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label greetUser;
        private System.Windows.Forms.Button dashboard_btn;
        private System.Windows.Forms.Button logout_btn;
        private System.Windows.Forms.Button expense_btn;
        private System.Windows.Forms.Button income_btn;
        private System.Windows.Forms.Button addCategory_btn;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.ComponentModel.BackgroundWorker backgroundWorker2;
        private System.Windows.Forms.Panel panel3;
        private CategoriesForm categoriesForm1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox6;
        private IncomeForm incomeForm1;
        private ExpenseForm expenseForm1;
        private DashboardUserForm dashboardUserForm1;
    }
}