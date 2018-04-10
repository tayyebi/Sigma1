namespace AdminClient.Forms.Master
{
    partial class RexaMessage
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
            this.rexaButton4 = new AdminClient.Components.RexaButton(this.components);
            this.SuspendLayout();
            // 
            // rexaButton3
            // 
            this.rexaButton3.Location = new System.Drawing.Point(510, 0);
            // 
            // rexaButton2
            // 
            this.rexaButton2.Location = new System.Drawing.Point(585, 0);
            // 
            // rexaLabel1
            // 
            this.rexaLabel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rexaLabel1.Location = new System.Drawing.Point(8, 32);
            this.rexaLabel1.Name = "rexaLabel1";
            this.rexaLabel1.Size = new System.Drawing.Size(735, 182);
            this.rexaLabel1.TabIndex = 1;
            this.rexaLabel1.Text = "rexaLabel1";
            this.rexaLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // rexaButton4
            // 
            this.rexaButton4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.rexaButton4.Location = new System.Drawing.Point(302, 171);
            this.rexaButton4.Name = "rexaButton4";
            this.rexaButton4.Size = new System.Drawing.Size(144, 40);
            this.rexaButton4.TabIndex = 2;
            this.rexaButton4.Text = "Ok";
            this.rexaButton4.UseVisualStyleBackColor = false;
            this.rexaButton4.Click += new System.EventHandler(this.rexaButton4_Click);
            // 
            // RexaMessage
            // 
            this.AcceptButton = this.rexaButton4;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(751, 222);
            this.Controls.Add(this.rexaButton4);
            this.Controls.Add(this.rexaLabel1);
            this.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.Name = "RexaMessage";
            this.Padding = new System.Windows.Forms.Padding(8);
            this.Text = "RexaMessage";
            this.Load += new System.EventHandler(this.RexaMessage_Load);
            this.Controls.SetChildIndex(this.rexaLabel1, 0);
            this.Controls.SetChildIndex(this.rexaButton4, 0);
            this.ResumeLayout(false);

        }

        #endregion

        private Components.RexaLabel rexaLabel1;
        private Components.RexaButton rexaButton4;
    }
}