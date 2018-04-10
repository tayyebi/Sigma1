namespace AdminClient.Forms.Views
{
    partial class Login
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
            this.rexaTextBox1 = new AdminClient.Components.RexaTextBox(this.components);
            this.rexaTextBox2 = new AdminClient.Components.RexaTextBox(this.components);
            this.rexaLabel2 = new AdminClient.Components.RexaLabel(this.components);
            this.rexaButton4 = new AdminClient.Components.RexaButton(this.components);
            this.SuspendLayout();
            // 
            // rexaButton3
            // 
            this.rexaButton3.Location = new System.Drawing.Point(191, 0);
            // 
            // rexaButton2
            // 
            this.rexaButton2.Location = new System.Drawing.Point(266, 0);
            // 
            // rexaLabel1
            // 
            this.rexaLabel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.rexaLabel1.ForeColor = System.Drawing.Color.White;
            this.rexaLabel1.Location = new System.Drawing.Point(113, 110);
            this.rexaLabel1.Name = "rexaLabel1";
            this.rexaLabel1.Size = new System.Drawing.Size(212, 32);
            this.rexaLabel1.TabIndex = 1;
            this.rexaLabel1.Text = "Username";
            this.rexaLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // rexaTextBox1
            // 
            this.rexaTextBox1.BackColor = System.Drawing.Color.White;
            this.rexaTextBox1.Location = new System.Drawing.Point(113, 153);
            this.rexaTextBox1.Name = "rexaTextBox1";
            this.rexaTextBox1.Size = new System.Drawing.Size(212, 29);
            this.rexaTextBox1.TabIndex = 2;
            this.rexaTextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // rexaTextBox2
            // 
            this.rexaTextBox2.BackColor = System.Drawing.Color.White;
            this.rexaTextBox2.Location = new System.Drawing.Point(113, 232);
            this.rexaTextBox2.Name = "rexaTextBox2";
            this.rexaTextBox2.Size = new System.Drawing.Size(212, 29);
            this.rexaTextBox2.TabIndex = 4;
            this.rexaTextBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // rexaLabel2
            // 
            this.rexaLabel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.rexaLabel2.ForeColor = System.Drawing.Color.White;
            this.rexaLabel2.Location = new System.Drawing.Point(113, 195);
            this.rexaLabel2.Name = "rexaLabel2";
            this.rexaLabel2.Size = new System.Drawing.Size(212, 34);
            this.rexaLabel2.TabIndex = 3;
            this.rexaLabel2.Text = "Password";
            this.rexaLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // rexaButton4
            // 
            this.rexaButton4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.rexaButton4.Location = new System.Drawing.Point(113, 267);
            this.rexaButton4.Name = "rexaButton4";
            this.rexaButton4.Size = new System.Drawing.Size(212, 34);
            this.rexaButton4.TabIndex = 5;
            this.rexaButton4.Text = "Login";
            this.rexaButton4.UseVisualStyleBackColor = false;
            this.rexaButton4.Click += new System.EventHandler(this.rexaButton4_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(426, 423);
            this.Controls.Add(this.rexaButton4);
            this.Controls.Add(this.rexaTextBox2);
            this.Controls.Add(this.rexaLabel2);
            this.Controls.Add(this.rexaTextBox1);
            this.Controls.Add(this.rexaLabel1);
            this.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.Name = "Login";
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Login_Load);
            this.Controls.SetChildIndex(this.rexaLabel1, 0);
            this.Controls.SetChildIndex(this.rexaTextBox1, 0);
            this.Controls.SetChildIndex(this.rexaLabel2, 0);
            this.Controls.SetChildIndex(this.rexaTextBox2, 0);
            this.Controls.SetChildIndex(this.rexaButton4, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Components.RexaLabel rexaLabel1;
        private Components.RexaTextBox rexaTextBox1;
        private Components.RexaTextBox rexaTextBox2;
        private Components.RexaLabel rexaLabel2;
        private Components.RexaButton rexaButton4;
    }
}