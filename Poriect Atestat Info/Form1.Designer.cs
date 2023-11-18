namespace Poriect_Atestat_Info
{
    partial class Form_start
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
            this.upperpanel = new System.Windows.Forms.Panel();
            this.close_button = new System.Windows.Forms.Button();
            this.button_minimize = new System.Windows.Forms.Button();
            this.main_panel = new System.Windows.Forms.Panel();
            this.upperpanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // upperpanel
            // 
            this.upperpanel.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.upperpanel.Controls.Add(this.close_button);
            this.upperpanel.Controls.Add(this.button_minimize);
            this.upperpanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.upperpanel.Location = new System.Drawing.Point(0, 0);
            this.upperpanel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.upperpanel.Name = "upperpanel";
            this.upperpanel.Size = new System.Drawing.Size(1396, 26);
            this.upperpanel.TabIndex = 0;
            this.upperpanel.Paint += new System.Windows.Forms.PaintEventHandler(this.upperpanel_Paint);
            // 
            // close_button
            // 
            this.close_button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.close_button.BackgroundImage = global::Poriect_Atestat_Info.Properties.Resources.tacsu_lu_barbu__2_;
            this.close_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.close_button.Location = new System.Drawing.Point(1345, 0);
            this.close_button.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.close_button.Name = "close_button";
            this.close_button.Size = new System.Drawing.Size(47, 34);
            this.close_button.TabIndex = 0;
            this.close_button.UseVisualStyleBackColor = true;
            this.close_button.Click += new System.EventHandler(this.close_button_Click);
            // 
            // button_minimize
            // 
            this.button_minimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button_minimize.BackgroundImage = global::Poriect_Atestat_Info.Properties.Resources.tacsu_lu_pleata__1_1;
            this.button_minimize.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button_minimize.Location = new System.Drawing.Point(1276, 0);
            this.button_minimize.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button_minimize.Name = "button_minimize";
            this.button_minimize.Size = new System.Drawing.Size(47, 34);
            this.button_minimize.TabIndex = 1;
            this.button_minimize.UseVisualStyleBackColor = true;
            this.button_minimize.Click += new System.EventHandler(this.button_minimize_Click);
            // 
            // main_panel
            // 
            this.main_panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.main_panel.Location = new System.Drawing.Point(0, 26);
            this.main_panel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.main_panel.Name = "main_panel";
            this.main_panel.Size = new System.Drawing.Size(1396, 781);
            this.main_panel.TabIndex = 1;
            this.main_panel.Paint += new System.Windows.Forms.PaintEventHandler(this.main_panel_Paint);
            // 
            // Form_start
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1396, 807);
            this.Controls.Add(this.main_panel);
            this.Controls.Add(this.upperpanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form_start";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form_start_Load);
            this.MouseEnter += new System.EventHandler(this.Form_start_MouseEnter);
            this.MouseLeave += new System.EventHandler(this.Form_start_MouseLeave);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form_start_MouseMove);
            this.upperpanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel upperpanel;
        private System.Windows.Forms.Panel main_panel;
        private System.Windows.Forms.Button button_minimize;
        private System.Windows.Forms.Button close_button;
    }
}

