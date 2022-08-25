namespace TheBillBook
{
    partial class Home
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
            this.screenpanel = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.mnu_inventory = new System.Windows.Forms.Button();
            this.mnu_reports = new System.Windows.Forms.Button();
            this.mnu_exit = new System.Windows.Forms.Button();
            this.mnu_bill = new System.Windows.Forms.Button();
            this.mnu_setting = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // screenpanel
            // 
            this.screenpanel.BackColor = System.Drawing.Color.Transparent;
            this.screenpanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.screenpanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.screenpanel.Location = new System.Drawing.Point(133, 0);
            this.screenpanel.Name = "screenpanel";
            this.screenpanel.Size = new System.Drawing.Size(667, 450);
            this.screenpanel.TabIndex = 4;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.mnu_setting);
            this.panel2.Controls.Add(this.mnu_inventory);
            this.panel2.Controls.Add(this.mnu_reports);
            this.panel2.Controls.Add(this.mnu_exit);
            this.panel2.Controls.Add(this.mnu_bill);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(133, 450);
            this.panel2.TabIndex = 3;
            // 
            // mnu_inventory
            // 
            this.mnu_inventory.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.mnu_inventory.Location = new System.Drawing.Point(-2, 36);
            this.mnu_inventory.Name = "mnu_inventory";
            this.mnu_inventory.Size = new System.Drawing.Size(133, 32);
            this.mnu_inventory.TabIndex = 3;
            this.mnu_inventory.Text = "Inventory";
            this.mnu_inventory.UseVisualStyleBackColor = false;
            this.mnu_inventory.Click += new System.EventHandler(this.mnu_inventory_Click);
            // 
            // mnu_reports
            // 
            this.mnu_reports.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.mnu_reports.Location = new System.Drawing.Point(-2, 74);
            this.mnu_reports.Name = "mnu_reports";
            this.mnu_reports.Size = new System.Drawing.Size(133, 32);
            this.mnu_reports.TabIndex = 2;
            this.mnu_reports.Text = "Reports";
            this.mnu_reports.UseVisualStyleBackColor = false;
            // 
            // mnu_exit
            // 
            this.mnu_exit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.mnu_exit.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.mnu_exit.Location = new System.Drawing.Point(-2, 404);
            this.mnu_exit.Name = "mnu_exit";
            this.mnu_exit.Size = new System.Drawing.Size(133, 32);
            this.mnu_exit.TabIndex = 1;
            this.mnu_exit.Text = "Exit";
            this.mnu_exit.UseVisualStyleBackColor = false;
            this.mnu_exit.Click += new System.EventHandler(this.mnu_exit_Click);
            // 
            // mnu_bill
            // 
            this.mnu_bill.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.mnu_bill.Location = new System.Drawing.Point(-2, -2);
            this.mnu_bill.Name = "mnu_bill";
            this.mnu_bill.Size = new System.Drawing.Size(133, 32);
            this.mnu_bill.TabIndex = 0;
            this.mnu_bill.Text = "Bill\'s";
            this.mnu_bill.UseVisualStyleBackColor = false;
            // 
            // mnu_setting
            // 
            this.mnu_setting.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.mnu_setting.Location = new System.Drawing.Point(-2, 112);
            this.mnu_setting.Name = "mnu_setting";
            this.mnu_setting.Size = new System.Drawing.Size(133, 32);
            this.mnu_setting.TabIndex = 4;
            this.mnu_setting.Text = "Setting";
            this.mnu_setting.UseVisualStyleBackColor = false;
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.screenpanel);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Home";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "The Bill Book";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel screenpanel;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button mnu_inventory;
        private System.Windows.Forms.Button mnu_reports;
        private System.Windows.Forms.Button mnu_exit;
        private System.Windows.Forms.Button mnu_bill;
        private System.Windows.Forms.Button mnu_setting;
    }
}

