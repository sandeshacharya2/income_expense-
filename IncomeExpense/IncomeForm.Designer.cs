﻿namespace IncomeExpense
{
    partial class IncomeForm
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.income_clearBtn = new System.Windows.Forms.Button();
            this.income_deletBtn = new System.Windows.Forms.Button();
            this.income_updateBtn = new System.Windows.Forms.Button();
            this.income_addBtn = new System.Windows.Forms.Button();
            this.income_date = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.income_description = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.income_income = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.income_item = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.income_category = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(20, 31);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1107, 318);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(121)))), ((int)(((byte)(84)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.Location = new System.Drawing.Point(17, 56);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1075, 245);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 16F);
            this.label1.Location = new System.Drawing.Point(10, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(152, 33);
            this.label1.TabIndex = 1;
            this.label1.Text = "Income List";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.income_clearBtn);
            this.panel2.Controls.Add(this.income_deletBtn);
            this.panel2.Controls.Add(this.income_updateBtn);
            this.panel2.Controls.Add(this.income_addBtn);
            this.panel2.Controls.Add(this.income_date);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.income_description);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.income_income);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.income_item);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.income_category);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(20, 404);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1107, 308);
            this.panel2.TabIndex = 2;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // income_clearBtn
            // 
            this.income_clearBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(121)))), ((int)(((byte)(84)))));
            this.income_clearBtn.FlatAppearance.BorderSize = 0;
            this.income_clearBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(160)))), ((int)(((byte)(108)))));
            this.income_clearBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(160)))), ((int)(((byte)(108)))));
            this.income_clearBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.income_clearBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.income_clearBtn.ForeColor = System.Drawing.Color.White;
            this.income_clearBtn.Location = new System.Drawing.Point(791, 230);
            this.income_clearBtn.Name = "income_clearBtn";
            this.income_clearBtn.Size = new System.Drawing.Size(103, 41);
            this.income_clearBtn.TabIndex = 14;
            this.income_clearBtn.Text = "Clear";
            this.income_clearBtn.UseVisualStyleBackColor = false;
            this.income_clearBtn.Click += new System.EventHandler(this.button2_Click);
            // 
            // income_deletBtn
            // 
            this.income_deletBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(121)))), ((int)(((byte)(84)))));
            this.income_deletBtn.FlatAppearance.BorderSize = 0;
            this.income_deletBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(160)))), ((int)(((byte)(108)))));
            this.income_deletBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(160)))), ((int)(((byte)(108)))));
            this.income_deletBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.income_deletBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.income_deletBtn.ForeColor = System.Drawing.Color.White;
            this.income_deletBtn.Location = new System.Drawing.Point(643, 230);
            this.income_deletBtn.Name = "income_deletBtn";
            this.income_deletBtn.Size = new System.Drawing.Size(103, 41);
            this.income_deletBtn.TabIndex = 13;
            this.income_deletBtn.Text = "Delete";
            this.income_deletBtn.UseVisualStyleBackColor = false;
            this.income_deletBtn.Click += new System.EventHandler(this.button3_Click);
            // 
            // income_updateBtn
            // 
            this.income_updateBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(121)))), ((int)(((byte)(84)))));
            this.income_updateBtn.FlatAppearance.BorderSize = 0;
            this.income_updateBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(160)))), ((int)(((byte)(108)))));
            this.income_updateBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(160)))), ((int)(((byte)(108)))));
            this.income_updateBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.income_updateBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.income_updateBtn.ForeColor = System.Drawing.Color.White;
            this.income_updateBtn.Location = new System.Drawing.Point(297, 230);
            this.income_updateBtn.Name = "income_updateBtn";
            this.income_updateBtn.Size = new System.Drawing.Size(103, 41);
            this.income_updateBtn.TabIndex = 12;
            this.income_updateBtn.Text = "Update";
            this.income_updateBtn.UseVisualStyleBackColor = false;
            this.income_updateBtn.Click += new System.EventHandler(this.income_updateBtn_Click);
            // 
            // income_addBtn
            // 
            this.income_addBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(121)))), ((int)(((byte)(84)))));
            this.income_addBtn.FlatAppearance.BorderSize = 0;
            this.income_addBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(160)))), ((int)(((byte)(108)))));
            this.income_addBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(160)))), ((int)(((byte)(108)))));
            this.income_addBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.income_addBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.income_addBtn.ForeColor = System.Drawing.Color.White;
            this.income_addBtn.Location = new System.Drawing.Point(149, 230);
            this.income_addBtn.Name = "income_addBtn";
            this.income_addBtn.Size = new System.Drawing.Size(103, 41);
            this.income_addBtn.TabIndex = 11;
            this.income_addBtn.Text = "Add";
            this.income_addBtn.UseVisualStyleBackColor = false;
            this.income_addBtn.Click += new System.EventHandler(this.income_addBtn_Click);
            // 
            // income_date
            // 
            this.income_date.Location = new System.Drawing.Point(673, 145);
            this.income_date.Name = "income_date";
            this.income_date.Size = new System.Drawing.Size(249, 22);
            this.income_date.TabIndex = 10;
            this.income_date.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 12F);
            this.label6.Location = new System.Drawing.Point(597, 143);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 24);
            this.label6.TabIndex = 9;
            this.label6.Text = "Date:";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // income_description
            // 
            this.income_description.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.income_description.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.income_description.Location = new System.Drawing.Point(673, 28);
            this.income_description.Multiline = true;
            this.income_description.Name = "income_description";
            this.income_description.Size = new System.Drawing.Size(372, 89);
            this.income_description.TabIndex = 8;
            this.income_description.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 12F);
            this.label5.Location = new System.Drawing.Point(540, 37);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(117, 24);
            this.label5.TabIndex = 7;
            this.label5.Text = "Description:";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // income_income
            // 
            this.income_income.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.income_income.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.income_income.Location = new System.Drawing.Point(167, 131);
            this.income_income.Name = "income_income";
            this.income_income.Size = new System.Drawing.Size(177, 34);
            this.income_income.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 12F);
            this.label4.Location = new System.Drawing.Point(76, 131);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 24);
            this.label4.TabIndex = 5;
            this.label4.Text = "Income:";
            // 
            // income_item
            // 
            this.income_item.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.income_item.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.income_item.Location = new System.Drawing.Point(167, 83);
            this.income_item.Name = "income_item";
            this.income_item.Size = new System.Drawing.Size(177, 34);
            this.income_item.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 12F);
            this.label3.Location = new System.Drawing.Point(100, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 24);
            this.label3.TabIndex = 3;
            this.label3.Text = "Item:";
            // 
            // income_category
            // 
            this.income_category.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.income_category.FormattingEnabled = true;
            this.income_category.Location = new System.Drawing.Point(167, 30);
            this.income_category.Name = "income_category";
            this.income_category.Size = new System.Drawing.Size(183, 33);
            this.income_category.TabIndex = 2;
            this.income_category.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 12F);
            this.label2.Location = new System.Drawing.Point(62, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "Category:";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // IncomeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "IncomeForm";
            this.Size = new System.Drawing.Size(1145, 748);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox income_category;
        private System.Windows.Forms.TextBox income_income;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox income_item;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.TextBox income_description;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker income_date;
        private System.Windows.Forms.Button income_clearBtn;
        private System.Windows.Forms.Button income_deletBtn;
        private System.Windows.Forms.Button income_updateBtn;
        private System.Windows.Forms.Button income_addBtn;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}
