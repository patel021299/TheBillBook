﻿namespace TheBillBook.Inventory
{
    partial class Inventory_Main
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.unitToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.itemToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.Inventory_Screen = new System.Windows.Forms.Panel();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.unitToolStripMenuItem1,
            this.itemToolStripMenuItem2});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(12, 20);
            // 
            // unitToolStripMenuItem1
            // 
            this.unitToolStripMenuItem1.Name = "unitToolStripMenuItem1";
            this.unitToolStripMenuItem1.Size = new System.Drawing.Size(41, 20);
            this.unitToolStripMenuItem1.Text = "Unit";
            this.unitToolStripMenuItem1.Click += new System.EventHandler(this.unitToolStripMenuItem1_Click);
            // 
            // itemToolStripMenuItem2
            // 
            this.itemToolStripMenuItem2.Name = "itemToolStripMenuItem2";
            this.itemToolStripMenuItem2.Size = new System.Drawing.Size(43, 20);
            this.itemToolStripMenuItem2.Text = "Item";
            // 
            // Inventory_Screen
            // 
            this.Inventory_Screen.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Inventory_Screen.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Inventory_Screen.Location = new System.Drawing.Point(0, 24);
            this.Inventory_Screen.Name = "Inventory_Screen";
            this.Inventory_Screen.Size = new System.Drawing.Size(800, 426);
            this.Inventory_Screen.TabIndex = 1;
            // 
            // Inventory_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Inventory_Screen);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Inventory_Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Inventory";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem unitToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem itemToolStripMenuItem2;
        private System.Windows.Forms.Panel Inventory_Screen;
    }
}