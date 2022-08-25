namespace TheBillBook.Inventory
{
    partial class Unit
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGridView_cat = new System.Windows.Forms.DataGridView();
            this.btndelete_cat = new System.Windows.Forms.Button();
            this.btnedit_cat = new System.Windows.Forms.Button();
            this.btnadd_cat = new System.Windows.Forms.Button();
            this.combounit = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtcategory = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtunitname = new System.Windows.Forms.TextBox();
            this.dataGridView_uint = new System.Windows.Forms.DataGridView();
            this.btndelete_unit = new System.Windows.Forms.Button();
            this.btnedit_unit = new System.Windows.Forms.Button();
            this.btnadd_unit = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_cat)).BeginInit();
            this.panel2.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_uint)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Snow;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(395, 450);
            this.panel1.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.dataGridView_cat);
            this.groupBox1.Controls.Add(this.btndelete_cat);
            this.groupBox1.Controls.Add(this.btnedit_cat);
            this.groupBox1.Controls.Add(this.btnadd_cat);
            this.groupBox1.Controls.Add(this.combounit);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtcategory);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Cursor = System.Windows.Forms.Cursors.Default;
            this.groupBox1.Location = new System.Drawing.Point(10, 10);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(364, 426);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Unit Category";
            // 
            // dataGridView_cat
            // 
            this.dataGridView_cat.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView_cat.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_cat.Location = new System.Drawing.Point(15, 103);
            this.dataGridView_cat.Name = "dataGridView_cat";
            this.dataGridView_cat.Size = new System.Drawing.Size(333, 309);
            this.dataGridView_cat.TabIndex = 7;
            // 
            // btndelete_cat
            // 
            this.btndelete_cat.Location = new System.Drawing.Point(250, 74);
            this.btndelete_cat.Name = "btndelete_cat";
            this.btndelete_cat.Size = new System.Drawing.Size(75, 23);
            this.btndelete_cat.TabIndex = 6;
            this.btndelete_cat.Text = "Delete";
            this.btndelete_cat.UseVisualStyleBackColor = true;
            // 
            // btnedit_cat
            // 
            this.btnedit_cat.Location = new System.Drawing.Point(169, 74);
            this.btnedit_cat.Name = "btnedit_cat";
            this.btnedit_cat.Size = new System.Drawing.Size(75, 23);
            this.btnedit_cat.TabIndex = 5;
            this.btnedit_cat.Text = "Edit";
            this.btnedit_cat.UseVisualStyleBackColor = true;
            // 
            // btnadd_cat
            // 
            this.btnadd_cat.Location = new System.Drawing.Point(88, 74);
            this.btnadd_cat.Name = "btnadd_cat";
            this.btnadd_cat.Size = new System.Drawing.Size(75, 23);
            this.btnadd_cat.TabIndex = 4;
            this.btnadd_cat.Text = "Add";
            this.btnadd_cat.UseVisualStyleBackColor = true;
            // 
            // combounit
            // 
            this.combounit.FormattingEnabled = true;
            this.combounit.Location = new System.Drawing.Point(88, 47);
            this.combounit.Name = "combounit";
            this.combounit.Size = new System.Drawing.Size(251, 21);
            this.combounit.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(11, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 19);
            this.label2.TabIndex = 2;
            this.label2.Text = "Unit";
            // 
            // txtcategory
            // 
            this.txtcategory.Location = new System.Drawing.Point(88, 21);
            this.txtcategory.Name = "txtcategory";
            this.txtcategory.Size = new System.Drawing.Size(251, 20);
            this.txtcategory.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(11, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Category";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Snow;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.groupBox2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(401, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(399, 450);
            this.panel2.TabIndex = 1;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.txtunitname);
            this.groupBox2.Controls.Add(this.dataGridView_uint);
            this.groupBox2.Controls.Add(this.btndelete_unit);
            this.groupBox2.Controls.Add(this.btnedit_unit);
            this.groupBox2.Controls.Add(this.btnadd_unit);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Location = new System.Drawing.Point(12, 10);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(364, 426);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Unit";
            // 
            // txtunitname
            // 
            this.txtunitname.Location = new System.Drawing.Point(65, 33);
            this.txtunitname.Name = "txtunitname";
            this.txtunitname.Size = new System.Drawing.Size(274, 20);
            this.txtunitname.TabIndex = 14;
            // 
            // dataGridView_uint
            // 
            this.dataGridView_uint.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView_uint.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_uint.Location = new System.Drawing.Point(15, 88);
            this.dataGridView_uint.Name = "dataGridView_uint";
            this.dataGridView_uint.Size = new System.Drawing.Size(333, 309);
            this.dataGridView_uint.TabIndex = 13;
            // 
            // btndelete_unit
            // 
            this.btndelete_unit.Location = new System.Drawing.Point(250, 59);
            this.btndelete_unit.Name = "btndelete_unit";
            this.btndelete_unit.Size = new System.Drawing.Size(75, 23);
            this.btndelete_unit.TabIndex = 12;
            this.btndelete_unit.Text = "Delete";
            this.btndelete_unit.UseVisualStyleBackColor = true;
            // 
            // btnedit_unit
            // 
            this.btnedit_unit.Location = new System.Drawing.Point(169, 59);
            this.btnedit_unit.Name = "btnedit_unit";
            this.btnedit_unit.Size = new System.Drawing.Size(75, 23);
            this.btnedit_unit.TabIndex = 11;
            this.btnedit_unit.Text = "Edit";
            this.btnedit_unit.UseVisualStyleBackColor = true;
            // 
            // btnadd_unit
            // 
            this.btnadd_unit.Location = new System.Drawing.Point(88, 59);
            this.btnadd_unit.Name = "btnadd_unit";
            this.btnadd_unit.Size = new System.Drawing.Size(75, 23);
            this.btnadd_unit.TabIndex = 10;
            this.btnadd_unit.Text = "Add";
            this.btnadd_unit.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(22, 34);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 19);
            this.label3.TabIndex = 8;
            this.label3.Text = "Unit";
            // 
            // Unit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Unit";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Unit";
            this.panel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_cat)).EndInit();
            this.panel2.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_uint)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtcategory;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox combounit;
        private System.Windows.Forms.Button btndelete_cat;
        private System.Windows.Forms.Button btnedit_cat;
        private System.Windows.Forms.Button btnadd_cat;
        private System.Windows.Forms.DataGridView dataGridView_cat;
        private System.Windows.Forms.DataGridView dataGridView_uint;
        private System.Windows.Forms.Button btndelete_unit;
        private System.Windows.Forms.Button btnedit_unit;
        private System.Windows.Forms.Button btnadd_unit;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtunitname;
    }
}