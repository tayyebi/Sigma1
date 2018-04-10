namespace AdminClient.Forms.Controls
{
    partial class UserCartext
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.rexaDataGridView1 = new AdminClient.Components.RexaDataGridView(this.components);
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.rexaLabel3 = new AdminClient.Components.RexaLabel(this.components);
            this.rexaLabel2 = new AdminClient.Components.RexaLabel(this.components);
            this.rexaLabel1 = new AdminClient.Components.RexaLabel(this.components);
            this.rexaLabel4 = new AdminClient.Components.RexaLabel(this.components);
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rexaDataGridView1)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.pictureBox1);
            this.flowLayoutPanel1.Controls.Add(this.tabControl1);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(6, 78);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(757, 270);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::AdminClient.Properties.Resources.Avatar;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(4, 5);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(369, 282);
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(380, 3);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(374, 284);
            this.tabControl1.TabIndex = 8;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.rexaDataGridView1);
            this.tabPage1.Location = new System.Drawing.Point(4, 30);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(366, 250);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Edits";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // rexaDataGridView1
            // 
            this.rexaDataGridView1.AllowUserToAddRows = false;
            this.rexaDataGridView1.AllowUserToDeleteRows = false;
            this.rexaDataGridView1.AllowUserToOrderColumns = true;
            this.rexaDataGridView1.AllowUserToResizeRows = false;
            this.rexaDataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.rexaDataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.rexaDataGridView1.CausesValidation = false;
            this.rexaDataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.rexaDataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rexaDataGridView1.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.rexaDataGridView1.Location = new System.Drawing.Point(3, 3);
            this.rexaDataGridView1.MultiSelect = false;
            this.rexaDataGridView1.Name = "rexaDataGridView1";
            this.rexaDataGridView1.ReadOnly = true;
            this.rexaDataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.rexaDataGridView1.ShowCellErrors = false;
            this.rexaDataGridView1.ShowCellToolTips = false;
            this.rexaDataGridView1.ShowEditingIcon = false;
            this.rexaDataGridView1.ShowRowErrors = false;
            this.rexaDataGridView1.Size = new System.Drawing.Size(360, 244);
            this.rexaDataGridView1.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.rexaLabel3);
            this.tabPage2.Controls.Add(this.rexaLabel2);
            this.tabPage2.Location = new System.Drawing.Point(4, 30);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(366, 250);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Previous edits";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // rexaLabel3
            // 
            this.rexaLabel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rexaLabel3.Location = new System.Drawing.Point(3, 52);
            this.rexaLabel3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.rexaLabel3.Name = "rexaLabel3";
            this.rexaLabel3.Size = new System.Drawing.Size(360, 195);
            this.rexaLabel3.TabIndex = 5;
            this.rexaLabel3.Text = "0";
            this.rexaLabel3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // rexaLabel2
            // 
            this.rexaLabel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.rexaLabel2.Location = new System.Drawing.Point(3, 3);
            this.rexaLabel2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.rexaLabel2.Name = "rexaLabel2";
            this.rexaLabel2.Size = new System.Drawing.Size(360, 49);
            this.rexaLabel2.TabIndex = 4;
            this.rexaLabel2.Text = "count of edits:";
            this.rexaLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // rexaLabel1
            // 
            this.rexaLabel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.rexaLabel1.Location = new System.Drawing.Point(6, 29);
            this.rexaLabel1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.rexaLabel1.Name = "rexaLabel1";
            this.rexaLabel1.Size = new System.Drawing.Size(757, 49);
            this.rexaLabel1.TabIndex = 8;
            this.rexaLabel1.Text = "rexaLabel1";
            this.rexaLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // rexaLabel4
            // 
            this.rexaLabel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.rexaLabel4.ForeColor = System.Drawing.Color.Red;
            this.rexaLabel4.Location = new System.Drawing.Point(6, 8);
            this.rexaLabel4.Name = "rexaLabel4";
            this.rexaLabel4.Size = new System.Drawing.Size(757, 21);
            this.rexaLabel4.TabIndex = 10;
            this.rexaLabel4.Text = "User is deleted";
            this.rexaLabel4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.rexaLabel4.Visible = false;
            // 
            // UserCartext
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.rexaLabel1);
            this.Controls.Add(this.rexaLabel4);
            this.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.Name = "UserCartext";
            this.Padding = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.Size = new System.Drawing.Size(769, 356);
            this.Load += new System.EventHandler(this.UserCartext_Load);
            this.flowLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.rexaDataGridView1)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private Components.RexaLabel rexaLabel3;
        private Components.RexaLabel rexaLabel2;
        private Components.RexaLabel rexaLabel1;
        private Components.RexaDataGridView rexaDataGridView1;
        private Components.RexaLabel rexaLabel4;
    }
}
