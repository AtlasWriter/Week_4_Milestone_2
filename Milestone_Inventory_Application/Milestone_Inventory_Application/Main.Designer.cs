﻿namespace Milestone_Inventory_Application
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.hotPink = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.viewInventory = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.hotPink)).BeginInit();
            this.SuspendLayout();
            // 
            // hotPink
            // 
            this.hotPink.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("hotPink.BackgroundImage")));
            this.hotPink.Location = new System.Drawing.Point(-4, -2);
            this.hotPink.Name = "hotPink";
            this.hotPink.Size = new System.Drawing.Size(261, 454);
            this.hotPink.TabIndex = 0;
            this.hotPink.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MV Boli", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(340, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(405, 45);
            this.label1.TabIndex = 1;
            this.label1.Text = "Inventory Management";
            // 
            // viewInventory
            // 
            this.viewInventory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.viewInventory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.viewInventory.Location = new System.Drawing.Point(61, 91);
            this.viewInventory.Name = "viewInventory";
            this.viewInventory.Size = new System.Drawing.Size(113, 48);
            this.viewInventory.TabIndex = 2;
            this.viewInventory.Text = "View Inventory";
            this.viewInventory.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(61, 158);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(113, 48);
            this.button1.TabIndex = 3;
            this.button1.Text = "Add Inventory";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(61, 229);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(113, 48);
            this.button2.TabIndex = 4;
            this.button2.Text = "Search Inventory";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.viewInventory);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.hotPink);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Main";
            this.Text = "Crafty Southern Heifers";
            ((System.ComponentModel.ISupportInitialize)(this.hotPink)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox hotPink;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button viewInventory;
        private System.Windows.Forms.Button button2;
        public System.Windows.Forms.Button button1;
    }
}

