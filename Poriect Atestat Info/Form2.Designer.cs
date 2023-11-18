namespace Poriect_Atestat_Info
{
    partial class Principal_Menu
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
            this.button_incepe = new System.Windows.Forms.Button();
            this.button_test = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button_incepe
            // 
            this.button_incepe.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button_incepe.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_incepe.Location = new System.Drawing.Point(442, 326);
            this.button_incepe.Name = "button_incepe";
            this.button_incepe.Size = new System.Drawing.Size(195, 86);
            this.button_incepe.TabIndex = 1;
            this.button_incepe.Text = "Descopera mapele";
            this.button_incepe.UseVisualStyleBackColor = true;
            this.button_incepe.Click += new System.EventHandler(this.button_incepe_Click);
            // 
            // button_test
            // 
            this.button_test.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button_test.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_test.Location = new System.Drawing.Point(442, 428);
            this.button_test.Name = "button_test";
            this.button_test.Size = new System.Drawing.Size(195, 94);
            this.button_test.TabIndex = 2;
            this.button_test.Text = "Testeaza ce ai invatat";
            this.button_test.UseVisualStyleBackColor = true;
            this.button_test.Click += new System.EventHandler(this.button_test_Click);
            // 
            // Principal_Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Poriect_Atestat_Info.Properties.Resources._1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1047, 656);
            this.Controls.Add(this.button_test);
            this.Controls.Add(this.button_incepe);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Principal_Menu";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Principal_Menu_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button button_incepe;
        private System.Windows.Forms.Button button_test;
    }
}