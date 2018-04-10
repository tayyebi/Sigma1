namespace AdminClient.Forms.Master
{
    partial class Public
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.rexaButton3 = new AdminClient.Components.RexaButton(this.components);
            this.rexaButton2 = new AdminClient.Components.RexaButton(this.components);
            this.rexaButton1 = new AdminClient.Components.RexaButton(this.components);
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.panel1.Controls.Add(this.rexaButton3);
            this.panel1.Controls.Add(this.rexaButton2);
            this.panel1.Controls.Add(this.rexaButton1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(5, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(750, 24);
            this.panel1.TabIndex = 0;
            // 
            // rexaButton3
            // 
            this.rexaButton3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.rexaButton3.Dock = System.Windows.Forms.DockStyle.Right;
            this.rexaButton3.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.rexaButton3.Location = new System.Drawing.Point(525, 0);
            this.rexaButton3.Name = "rexaButton3";
            this.rexaButton3.Size = new System.Drawing.Size(75, 24);
            this.rexaButton3.TabIndex = 2;
            this.rexaButton3.Text = "Minimize";
            this.rexaButton3.UseVisualStyleBackColor = false;
            this.rexaButton3.Visible = false;
            this.rexaButton3.Click += new System.EventHandler(this.rexaButton3_Click);
            // 
            // rexaButton2
            // 
            this.rexaButton2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.rexaButton2.Dock = System.Windows.Forms.DockStyle.Right;
            this.rexaButton2.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.rexaButton2.Location = new System.Drawing.Point(600, 0);
            this.rexaButton2.Name = "rexaButton2";
            this.rexaButton2.Size = new System.Drawing.Size(75, 24);
            this.rexaButton2.TabIndex = 1;
            this.rexaButton2.Text = "Maximize";
            this.rexaButton2.UseVisualStyleBackColor = false;
            this.rexaButton2.Visible = false;
            this.rexaButton2.Click += new System.EventHandler(this.rexaButton2_Click);
            // 
            // rexaButton1
            // 
            this.rexaButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.rexaButton1.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.rexaButton1.Dock = System.Windows.Forms.DockStyle.Right;
            this.rexaButton1.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.rexaButton1.Location = new System.Drawing.Point(675, 0);
            this.rexaButton1.Name = "rexaButton1";
            this.rexaButton1.Size = new System.Drawing.Size(75, 24);
            this.rexaButton1.TabIndex = 0;
            this.rexaButton1.Text = "Close";
            this.rexaButton1.UseVisualStyleBackColor = false;
            this.rexaButton1.Click += new System.EventHandler(this.rexaButton1_Click);
            // 
            // Public
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.CancelButton = this.rexaButton1;
            this.ClientSize = new System.Drawing.Size(760, 392);
            this.ControlBox = false;
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Public";
            this.Padding = new System.Windows.Forms.Padding(5);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Public";
            this.Load += new System.EventHandler(this.Public_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Public_Paint);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private Components.RexaButton rexaButton1;
        protected Components.RexaButton rexaButton3;
        protected Components.RexaButton rexaButton2;
    }
}