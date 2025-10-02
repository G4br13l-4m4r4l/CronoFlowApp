namespace CronoFlow
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panelSideMenu = new Panel();
            ConfigBtn = new FontAwesome.Sharp.IconButton();
            ProgressBtn = new FontAwesome.Sharp.IconButton();
            homeBtn = new FontAwesome.Sharp.IconButton();
            iconeApp = new Panel();
            pictureBox1 = new PictureBox();
            panelSideMenu.SuspendLayout();
            iconeApp.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panelSideMenu
            // 
            panelSideMenu.BackColor = SystemColors.WindowFrame;
            panelSideMenu.BackgroundImageLayout = ImageLayout.None;
            panelSideMenu.Controls.Add(ConfigBtn);
            panelSideMenu.Controls.Add(ProgressBtn);
            panelSideMenu.Controls.Add(homeBtn);
            panelSideMenu.Controls.Add(iconeApp);
            panelSideMenu.Dock = DockStyle.Left;
            panelSideMenu.Location = new Point(0, 0);
            panelSideMenu.Name = "panelSideMenu";
            panelSideMenu.Size = new Size(225, 598);
            panelSideMenu.TabIndex = 0;
            // 
            // ConfigBtn
            // 
            ConfigBtn.Dock = DockStyle.Top;
            ConfigBtn.FlatAppearance.BorderSize = 0;
            ConfigBtn.FlatStyle = FlatStyle.Flat;
            ConfigBtn.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ConfigBtn.ForeColor = Color.PaleGreen;
            ConfigBtn.IconChar = FontAwesome.Sharp.IconChar.Cog;
            ConfigBtn.IconColor = Color.PaleGreen;
            ConfigBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            ConfigBtn.IconSize = 38;
            ConfigBtn.ImageAlign = ContentAlignment.MiddleLeft;
            ConfigBtn.Location = new Point(0, 220);
            ConfigBtn.Name = "ConfigBtn";
            ConfigBtn.Padding = new Padding(10, 0, 20, 0);
            ConfigBtn.Size = new Size(225, 60);
            ConfigBtn.TabIndex = 3;
            ConfigBtn.Text = "Config.";
            ConfigBtn.TextAlign = ContentAlignment.MiddleLeft;
            ConfigBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
            ConfigBtn.UseVisualStyleBackColor = true;
            ConfigBtn.Click += ConfigBtn_Click;
            // 
            // ProgressBtn
            // 
            ProgressBtn.Dock = DockStyle.Top;
            ProgressBtn.FlatAppearance.BorderSize = 0;
            ProgressBtn.FlatStyle = FlatStyle.Flat;
            ProgressBtn.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ProgressBtn.ForeColor = Color.PaleGreen;
            ProgressBtn.IconChar = FontAwesome.Sharp.IconChar.ChartLine;
            ProgressBtn.IconColor = Color.PaleGreen;
            ProgressBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            ProgressBtn.IconSize = 38;
            ProgressBtn.ImageAlign = ContentAlignment.MiddleLeft;
            ProgressBtn.Location = new Point(0, 160);
            ProgressBtn.Name = "ProgressBtn";
            ProgressBtn.Padding = new Padding(10, 0, 20, 0);
            ProgressBtn.Size = new Size(225, 60);
            ProgressBtn.TabIndex = 2;
            ProgressBtn.Text = "Progress";
            ProgressBtn.TextAlign = ContentAlignment.MiddleLeft;
            ProgressBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
            ProgressBtn.UseVisualStyleBackColor = true;
            ProgressBtn.Click += ProgressBtn_Click;
            // 
            // homeBtn
            // 
            homeBtn.BackColor = SystemColors.WindowFrame;
            homeBtn.Dock = DockStyle.Top;
            homeBtn.FlatAppearance.BorderSize = 0;
            homeBtn.FlatStyle = FlatStyle.Flat;
            homeBtn.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            homeBtn.ForeColor = Color.PaleGreen;
            homeBtn.IconChar = FontAwesome.Sharp.IconChar.Play;
            homeBtn.IconColor = Color.PaleGreen;
            homeBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            homeBtn.IconSize = 38;
            homeBtn.ImageAlign = ContentAlignment.MiddleLeft;
            homeBtn.Location = new Point(0, 100);
            homeBtn.Name = "homeBtn";
            homeBtn.Padding = new Padding(10, 0, 20, 0);
            homeBtn.Size = new Size(225, 60);
            homeBtn.TabIndex = 1;
            homeBtn.Text = "Action";
            homeBtn.TextAlign = ContentAlignment.MiddleLeft;
            homeBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
            homeBtn.UseVisualStyleBackColor = false;
            homeBtn.Click += homeBtn_Click;
            // 
            // iconeApp
            // 
            iconeApp.BackColor = SystemColors.Menu;
            iconeApp.Controls.Add(pictureBox1);
            iconeApp.Dock = DockStyle.Top;
            iconeApp.Location = new Point(0, 0);
            iconeApp.Name = "iconeApp";
            iconeApp.Size = new Size(225, 100);
            iconeApp.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(0, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(222, 97);
            pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(961, 598);
            Controls.Add(panelSideMenu);
            Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            panelSideMenu.ResumeLayout(false);
            iconeApp.ResumeLayout(false);
            iconeApp.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelSideMenu;
        private Panel iconeApp;
        private FontAwesome.Sharp.IconButton homeBtn;
        private FontAwesome.Sharp.IconButton ProgressBtn;
        private FontAwesome.Sharp.IconButton ConfigBtn;
        private PictureBox pictureBox1;
    }
}
