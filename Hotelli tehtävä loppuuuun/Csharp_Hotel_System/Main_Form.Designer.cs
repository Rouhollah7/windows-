﻿namespace Csharp_Hotel_System
{
    partial class Main_Form
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
            this.manageClientsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manageRoomsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manageReservationsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.manageClientsToolStripMenuItem,
            this.manageRoomsToolStripMenuItem,
            this.manageReservationsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1047, 35);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // manageClientsToolStripMenuItem
            // 
            this.manageClientsToolStripMenuItem.Name = "manageClientsToolStripMenuItem";
            this.manageClientsToolStripMenuItem.Size = new System.Drawing.Size(149, 29);
            this.manageClientsToolStripMenuItem.Text = "Manage Clients";
            this.manageClientsToolStripMenuItem.Click += new System.EventHandler(this.manageClientsToolStripMenuItem_Click);
            // 
            // manageRoomsToolStripMenuItem
            // 
            this.manageRoomsToolStripMenuItem.Name = "manageRoomsToolStripMenuItem";
            this.manageRoomsToolStripMenuItem.Size = new System.Drawing.Size(153, 29);
            this.manageRoomsToolStripMenuItem.Text = "Manage Rooms";
            this.manageRoomsToolStripMenuItem.Click += new System.EventHandler(this.manageRoomsToolStripMenuItem_Click);
            // 
            // manageReservationsToolStripMenuItem
            // 
            this.manageReservationsToolStripMenuItem.Name = "manageReservationsToolStripMenuItem";
            this.manageReservationsToolStripMenuItem.Size = new System.Drawing.Size(196, 29);
            this.manageReservationsToolStripMenuItem.Text = "Manage Reservations";
            this.manageReservationsToolStripMenuItem.Click += new System.EventHandler(this.manageReservationsToolStripMenuItem_Click);
            // 
            // Main_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1047, 620);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Main_Form";
            this.Text = "Main_Form";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Main_Form_FormClosing);
            this.Load += new System.EventHandler(this.Main_Form_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem manageClientsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manageRoomsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manageReservationsToolStripMenuItem;
    }
}