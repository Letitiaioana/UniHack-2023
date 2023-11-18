namespace Poriect_Atestat_Info
{
    partial class Form_mapa
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
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.button_return = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.btn_coldwar = new System.Windows.Forms.Button();
            this.btn_napoleon = new System.Windows.Forms.Button();
            this.btn_7years = new System.Windows.Forms.Button();
            this.mapa_europa = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mapa_europa)).BeginInit();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 30;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // button_return
            // 
            this.button_return.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button_return.Location = new System.Drawing.Point(10, 563);
            this.button_return.Name = "button_return";
            this.button_return.Size = new System.Drawing.Size(104, 46);
            this.button_return.TabIndex = 2;
            this.button_return.Text = "Return to Menu";
            this.button_return.UseVisualStyleBackColor = true;
            this.button_return.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Peru;
            this.panel1.Controls.Add(this.btn_7years);
            this.panel1.Controls.Add(this.btn_napoleon);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.btn_coldwar);
            this.panel1.Controls.Add(this.button_return);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(125, 656);
            this.panel1.TabIndex = 3;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(11, 68);
            this.button2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(103, 42);
            this.button2.TabIndex = 4;
            this.button2.Text = "Unificarea Italiei si a Germaniei";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            this.button2.MouseHover += new System.EventHandler(this.button2_MouseHover);
            // 
            // btn_coldwar
            // 
            this.btn_coldwar.Location = new System.Drawing.Point(11, 10);
            this.btn_coldwar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_coldwar.Name = "btn_coldwar";
            this.btn_coldwar.Size = new System.Drawing.Size(103, 44);
            this.btn_coldwar.TabIndex = 3;
            this.btn_coldwar.Text = "Razboiul rece";
            this.btn_coldwar.UseVisualStyleBackColor = true;
            this.btn_coldwar.Click += new System.EventHandler(this.button1_Click_1);
            this.btn_coldwar.MouseHover += new System.EventHandler(this.btn_coldwar_MouseHover);
            // 
            // btn_napoleon
            // 
            this.btn_napoleon.Location = new System.Drawing.Point(10, 124);
            this.btn_napoleon.Name = "btn_napoleon";
            this.btn_napoleon.Size = new System.Drawing.Size(104, 44);
            this.btn_napoleon.TabIndex = 5;
            this.btn_napoleon.Text = "Epoca Napoleoniana";
            this.btn_napoleon.UseVisualStyleBackColor = true;
            this.btn_napoleon.Click += new System.EventHandler(this.btn_napoleon_Click);
            this.btn_napoleon.MouseHover += new System.EventHandler(this.btn_napoleon_MouseHover);
            // 
            // btn_7years
            // 
            this.btn_7years.Location = new System.Drawing.Point(10, 183);
            this.btn_7years.Name = "btn_7years";
            this.btn_7years.Size = new System.Drawing.Size(104, 43);
            this.btn_7years.TabIndex = 6;
            this.btn_7years.Text = "Razboiul de 7 ani";
            this.btn_7years.UseVisualStyleBackColor = true;
            this.btn_7years.Click += new System.EventHandler(this.btn_7years_Click);
            this.btn_7years.MouseHover += new System.EventHandler(this.btn_7years_MouseHover);
            // 
            // mapa_europa
            // 
            this.mapa_europa.Image = global::Poriect_Atestat_Info.Properties.Resources.mapa_europa;
            this.mapa_europa.Location = new System.Drawing.Point(-71, -133);
            this.mapa_europa.Name = "mapa_europa";
            this.mapa_europa.Size = new System.Drawing.Size(1433, 880);
            this.mapa_europa.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.mapa_europa.TabIndex = 0;
            this.mapa_europa.TabStop = false;
            // 
            // Form_mapa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1047, 656);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.mapa_europa);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form_mapa";
            this.Text = "``";
            this.MouseEnter += new System.EventHandler(this.Form_mapa_MouseEnter);
            this.MouseLeave += new System.EventHandler(this.Form_mapa_MouseLeave);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.mapa_europa)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox mapa_europa;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button button_return;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_coldwar;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btn_napoleon;
        private System.Windows.Forms.Button btn_7years;
    }
}