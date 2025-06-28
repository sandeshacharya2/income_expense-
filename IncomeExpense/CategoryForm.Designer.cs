namespace IncomeExpense
{
    partial class CategoryForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.category_category = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.category_type = new System.Windows.Forms.ComboBox();
            this.category_status = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.category_addBtn = new System.Windows.Forms.Button();
            this.category_updateBtn = new System.Windows.Forms.Button();
            this.category_deleteBtn = new System.Windows.Forms.Button();
            this.category_clearBtn = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.category_deleteBtn);
            this.panel1.Controls.Add(this.category_clearBtn);
            this.panel1.Controls.Add(this.category_updateBtn);
            this.panel1.Controls.Add(this.category_addBtn);
            this.panel1.Controls.Add(this.category_status);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.category_type);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.category_category);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(12, 21);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(323, 700);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.dataGridView1);
            this.panel2.Location = new System.Drawing.Point(359, 21);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(765, 700);
            this.panel2.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(20, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Category";
            // 
            // category_category
            // 
            this.category_category.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.category_category.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.category_category.Location = new System.Drawing.Point(25, 65);
            this.category_category.Name = "category_category";
            this.category_category.Size = new System.Drawing.Size(287, 34);
            this.category_category.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(20, 124);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 29);
            this.label2.TabIndex = 2;
            this.label2.Text = "Type";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // category_type
            // 
            this.category_type.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.category_type.FormattingEnabled = true;
            this.category_type.Items.AddRange(new object[] {
            "Income",
            "Expense"});
            this.category_type.Location = new System.Drawing.Point(25, 160);
            this.category_type.Name = "category_type";
            this.category_type.Size = new System.Drawing.Size(287, 37);
            this.category_type.TabIndex = 4;
            this.category_type.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // category_status
            // 
            this.category_status.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.category_status.FormattingEnabled = true;
            this.category_status.Items.AddRange(new object[] {
            "Active",
            "Inactive"});
            this.category_status.Location = new System.Drawing.Point(25, 265);
            this.category_status.Name = "category_status";
            this.category_status.Size = new System.Drawing.Size(287, 37);
            this.category_status.TabIndex = 6;
            this.category_status.SelectedIndexChanged += new System.EventHandler(this.comboBox3_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(20, 229);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 29);
            this.label3.TabIndex = 5;
            this.label3.Text = "Status";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // category_addBtn
            // 
            this.category_addBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(121)))), ((int)(((byte)(84)))));
            this.category_addBtn.FlatAppearance.BorderSize = 0;
            this.category_addBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(160)))), ((int)(((byte)(108)))));
            this.category_addBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(160)))), ((int)(((byte)(108)))));
            this.category_addBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.category_addBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.category_addBtn.ForeColor = System.Drawing.Color.White;
            this.category_addBtn.Location = new System.Drawing.Point(25, 353);
            this.category_addBtn.Name = "category_addBtn";
            this.category_addBtn.Size = new System.Drawing.Size(103, 41);
            this.category_addBtn.TabIndex = 0;
            this.category_addBtn.Text = "Add";
            this.category_addBtn.UseVisualStyleBackColor = false;
            this.category_addBtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // category_updateBtn
            // 
            this.category_updateBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(121)))), ((int)(((byte)(84)))));
            this.category_updateBtn.FlatAppearance.BorderSize = 0;
            this.category_updateBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(160)))), ((int)(((byte)(108)))));
            this.category_updateBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(160)))), ((int)(((byte)(108)))));
            this.category_updateBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.category_updateBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.category_updateBtn.ForeColor = System.Drawing.Color.White;
            this.category_updateBtn.Location = new System.Drawing.Point(185, 353);
            this.category_updateBtn.Name = "category_updateBtn";
            this.category_updateBtn.Size = new System.Drawing.Size(103, 41);
            this.category_updateBtn.TabIndex = 7;
            this.category_updateBtn.Text = "Update";
            this.category_updateBtn.UseVisualStyleBackColor = false;
            // 
            // category_deleteBtn
            // 
            this.category_deleteBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(121)))), ((int)(((byte)(84)))));
            this.category_deleteBtn.FlatAppearance.BorderSize = 0;
            this.category_deleteBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(160)))), ((int)(((byte)(108)))));
            this.category_deleteBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(160)))), ((int)(((byte)(108)))));
            this.category_deleteBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.category_deleteBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.category_deleteBtn.ForeColor = System.Drawing.Color.White;
            this.category_deleteBtn.Location = new System.Drawing.Point(185, 434);
            this.category_deleteBtn.Name = "category_deleteBtn";
            this.category_deleteBtn.Size = new System.Drawing.Size(103, 41);
            this.category_deleteBtn.TabIndex = 9;
            this.category_deleteBtn.Text = "Delete";
            this.category_deleteBtn.UseVisualStyleBackColor = false;
            this.category_deleteBtn.Click += new System.EventHandler(this.button3_Click);
            // 
            // category_clearBtn
            // 
            this.category_clearBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(121)))), ((int)(((byte)(84)))));
            this.category_clearBtn.FlatAppearance.BorderSize = 0;
            this.category_clearBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(160)))), ((int)(((byte)(108)))));
            this.category_clearBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(160)))), ((int)(((byte)(108)))));
            this.category_clearBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.category_clearBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.category_clearBtn.ForeColor = System.Drawing.Color.White;
            this.category_clearBtn.Location = new System.Drawing.Point(25, 434);
            this.category_clearBtn.Name = "category_clearBtn";
            this.category_clearBtn.Size = new System.Drawing.Size(103, 41);
            this.category_clearBtn.TabIndex = 8;
            this.category_clearBtn.Text = "Clear";
            this.category_clearBtn.UseVisualStyleBackColor = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(121)))), ((int)(((byte)(84)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.Location = new System.Drawing.Point(17, 60);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(737, 647);
            this.dataGridView1.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(174, 29);
            this.label4.TabIndex = 10;
            this.label4.Text = "Categories List";
            // 
            // fileSystemWatcher1
            // 
            this.fileSystemWatcher1.EnableRaisingEvents = true;
            this.fileSystemWatcher1.SynchronizingObject = this;
            // 
            // CategoryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1145, 748);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CategoryForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CategoryForm";
            this.Load += new System.EventHandler(this.CategoryForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox category_category;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox category_type;
        private System.Windows.Forms.ComboBox category_status;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button category_addBtn;
        private System.Windows.Forms.Button category_deleteBtn;
        private System.Windows.Forms.Button category_clearBtn;
        private System.Windows.Forms.Button category_updateBtn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.IO.FileSystemWatcher fileSystemWatcher1;
    }
}