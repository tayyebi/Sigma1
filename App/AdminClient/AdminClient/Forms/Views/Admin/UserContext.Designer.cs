﻿namespace AdminClient.Forms.Views.Admin
{
    partial class UserContext
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // rexaButton3
            // 
            this.rexaButton3.Location = new System.Drawing.Point(583, 0);
            // 
            // rexaButton2
            // 
            this.rexaButton2.Location = new System.Drawing.Point(658, 0);
            // 
            // panel2
            // 
            this.panel2.AutoScroll = true;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(12, 58);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(808, 484);
            this.panel2.TabIndex = 2;
            // 
            // UserContext
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(832, 555);
            this.Controls.Add(this.panel2);
            this.Margin = new System.Windows.Forms.Padding(9, 13, 9, 13);
            this.Name = "UserContext";
            this.Padding = new System.Windows.Forms.Padding(12, 13, 12, 13);
            this.Text = "UserContext";
            this.Load += new System.EventHandler(this.UserContext_Load);
            this.Controls.SetChildIndex(this.panel2, 0);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
    }
}