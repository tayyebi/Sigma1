namespace AdminClient.Forms.Master
{
    partial class Admin
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
            this.components = new System.ComponentModel.Container();
            this.rexaLabel1 = new AdminClient.Components.RexaLabel(this.components);
            this.SuspendLayout();
            // 
            // rexaButton3
            // 
            this.rexaButton3.Location = new System.Drawing.Point(375, 0);
            // 
            // rexaButton2
            // 
            this.rexaButton2.Location = new System.Drawing.Point(450, 0);
            // 
            // rexaLabel1
            // 
            this.rexaLabel1.BackColor = System.Drawing.Color.Lime;
            this.rexaLabel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.rexaLabel1.ForeColor = System.Drawing.Color.White;
            this.rexaLabel1.Location = new System.Drawing.Point(8, 32);
            this.rexaLabel1.Name = "rexaLabel1";
            this.rexaLabel1.Size = new System.Drawing.Size(600, 21);
            this.rexaLabel1.TabIndex = 1;
            this.rexaLabel1.Text = "Authorized for administrator";
            this.rexaLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(616, 457);
            this.Controls.Add(this.rexaLabel1);
            this.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.Name = "Admin";
            this.Padding = new System.Windows.Forms.Padding(8, 8, 8, 8);
            this.Text = "Admin";
            this.Load += new System.EventHandler(this.Admin_Load);
            this.Controls.SetChildIndex(this.rexaLabel1, 0);
            this.ResumeLayout(false);

        }

        #endregion

        private Components.RexaLabel rexaLabel1;
    }
}