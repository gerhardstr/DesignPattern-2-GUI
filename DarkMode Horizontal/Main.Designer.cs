namespace DarkModeHorizontal
{
    partial class Main
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
            this.panelNavigation = new System.Windows.Forms.Panel();
            this.panelLeft = new System.Windows.Forms.Panel();
            this.panelNavigationBottom = new System.Windows.Forms.Panel();
            this.buttonQuit = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            this.buttonCars = new System.Windows.Forms.Button();
            this.buttonOpen = new System.Windows.Forms.Button();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.panelMainBottom = new System.Windows.Forms.Panel();
            this.buttonNew = new System.Windows.Forms.Button();
            this.panelMain = new System.Windows.Forms.Panel();
            this.pictureBoxUserAvatar = new System.Windows.Forms.PictureBox();
            this.panelNavigation.SuspendLayout();
            this.panelNavigationBottom.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxUserAvatar)).BeginInit();
            this.SuspendLayout();
            // 
            // panelNavigation
            // 
            this.panelNavigation.Controls.Add(this.buttonNew);
            this.panelNavigation.Controls.Add(this.panelNavigationBottom);
            this.panelNavigation.Controls.Add(this.panelLogo);
            this.panelNavigation.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelNavigation.Location = new System.Drawing.Point(0, 0);
            this.panelNavigation.Name = "panelNavigation";
            this.panelNavigation.Size = new System.Drawing.Size(157, 500);
            this.panelNavigation.TabIndex = 0;
            // 
            // panelLeft
            // 
            this.panelLeft.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.panelLeft.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.panelLeft.ForeColor = System.Drawing.Color.White;
            this.panelLeft.Location = new System.Drawing.Point(193, 55);
            this.panelLeft.Name = "panelLeft";
            this.panelLeft.Size = new System.Drawing.Size(93, 7);
            this.panelLeft.TabIndex = 4;
            // 
            // panelNavigationBottom
            // 
            this.panelNavigationBottom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(40)))), ((int)(((byte)(47)))));
            this.panelNavigationBottom.Controls.Add(this.pictureBoxUserAvatar);
            this.panelNavigationBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelNavigationBottom.Location = new System.Drawing.Point(0, 450);
            this.panelNavigationBottom.Name = "panelNavigationBottom";
            this.panelNavigationBottom.Size = new System.Drawing.Size(157, 50);
            this.panelNavigationBottom.TabIndex = 2;
            // 
            // buttonQuit
            // 
            this.buttonQuit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonQuit.FlatAppearance.BorderSize = 0;
            this.buttonQuit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonQuit.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonQuit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.buttonQuit.Image = global::DarkMode_Horizontal.Properties.Resources.exit_25px;
            this.buttonQuit.Location = new System.Drawing.Point(638, 4);
            this.buttonQuit.Name = "buttonQuit";
            this.buttonQuit.Size = new System.Drawing.Size(151, 60);
            this.buttonQuit.TabIndex = 1;
            this.buttonQuit.Text = "Beenden";
            this.buttonQuit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.buttonQuit.UseVisualStyleBackColor = true;
            this.buttonQuit.Click += new System.EventHandler(this.buttonQuit_Click);
            // 
            // buttonSave
            // 
            this.buttonSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonSave.FlatAppearance.BorderSize = 0;
            this.buttonSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSave.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSave.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.buttonSave.Image = global::DarkMode_Horizontal.Properties.Resources.save_25px;
            this.buttonSave.Location = new System.Drawing.Point(481, 4);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(151, 60);
            this.buttonSave.TabIndex = 1;
            this.buttonSave.Text = "Speichern";
            this.buttonSave.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // buttonCars
            // 
            this.buttonCars.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonCars.FlatAppearance.BorderSize = 0;
            this.buttonCars.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCars.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCars.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.buttonCars.Image = global::DarkMode_Horizontal.Properties.Resources.car_25px;
            this.buttonCars.Location = new System.Drawing.Point(324, 4);
            this.buttonCars.Name = "buttonCars";
            this.buttonCars.Size = new System.Drawing.Size(151, 60);
            this.buttonCars.TabIndex = 1;
            this.buttonCars.Text = "Fuhrpark";
            this.buttonCars.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.buttonCars.UseVisualStyleBackColor = true;
            this.buttonCars.Click += new System.EventHandler(this.buttonCars_Click);
            // 
            // buttonOpen
            // 
            this.buttonOpen.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonOpen.FlatAppearance.BorderSize = 0;
            this.buttonOpen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonOpen.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonOpen.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.buttonOpen.Image = global::DarkMode_Horizontal.Properties.Resources.opened_folder_25px;
            this.buttonOpen.Location = new System.Drawing.Point(167, 4);
            this.buttonOpen.Name = "buttonOpen";
            this.buttonOpen.Size = new System.Drawing.Size(151, 60);
            this.buttonOpen.TabIndex = 1;
            this.buttonOpen.Text = "Liste öffnen";
            this.buttonOpen.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.buttonOpen.UseVisualStyleBackColor = true;
            this.buttonOpen.Click += new System.EventHandler(this.buttonOpen_Click);
            // 
            // panelLogo
            // 
            this.panelLogo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.panelLogo.BackgroundImage = global::DarkMode_Horizontal.Properties.Resources.logo_auto_single_dark;
            this.panelLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.ImeMode = System.Windows.Forms.ImeMode.KatakanaHalf;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(157, 63);
            this.panelLogo.TabIndex = 0;
            // 
            // panelMainBottom
            // 
            this.panelMainBottom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(40)))), ((int)(((byte)(47)))));
            this.panelMainBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelMainBottom.Location = new System.Drawing.Point(157, 450);
            this.panelMainBottom.Name = "panelMainBottom";
            this.panelMainBottom.Size = new System.Drawing.Size(843, 50);
            this.panelMainBottom.TabIndex = 1;
            // 
            // buttonNew
            // 
            this.buttonNew.FlatAppearance.BorderSize = 0;
            this.buttonNew.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonNew.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonNew.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.buttonNew.Location = new System.Drawing.Point(9, 87);
            this.buttonNew.Name = "buttonNew";
            this.buttonNew.Size = new System.Drawing.Size(138, 24);
            this.buttonNew.TabIndex = 2;
            this.buttonNew.Text = "Neues Kfz anlegen";
            this.buttonNew.UseVisualStyleBackColor = true;
            this.buttonNew.Click += new System.EventHandler(this.buttonNew_Click);
            // 
            // panelMain
            // 
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelMain.Location = new System.Drawing.Point(157, 66);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(843, 384);
            this.panelMain.TabIndex = 3;
            // 
            // pictureBoxUserAvatar
            // 
            this.pictureBoxUserAvatar.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBoxUserAvatar.Image = global::DarkMode_Horizontal.Properties.Resources.male_user_25px;
            this.pictureBoxUserAvatar.Location = new System.Drawing.Point(0, 0);
            this.pictureBoxUserAvatar.Name = "pictureBoxUserAvatar";
            this.pictureBoxUserAvatar.Size = new System.Drawing.Size(49, 50);
            this.pictureBoxUserAvatar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBoxUserAvatar.TabIndex = 1;
            this.pictureBoxUserAvatar.TabStop = false;
            // 
            // Main
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.ClientSize = new System.Drawing.Size(1000, 500);
            this.Controls.Add(this.panelLeft);
            this.Controls.Add(this.panelMain);
            this.Controls.Add(this.buttonQuit);
            this.Controls.Add(this.panelMainBottom);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.panelNavigation);
            this.Controls.Add(this.buttonCars);
            this.Controls.Add(this.buttonOpen);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(120)))), ((int)(((byte)(138)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.panelNavigation.ResumeLayout(false);
            this.panelNavigationBottom.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxUserAvatar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelNavigation;
        private System.Windows.Forms.Button buttonOpen;
        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.Panel panelMainBottom;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Button buttonCars;
        private System.Windows.Forms.Button buttonQuit;
        private System.Windows.Forms.Button buttonNew;
        private System.Windows.Forms.Panel panelNavigationBottom;
        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.Panel panelLeft;
        private System.Windows.Forms.PictureBox pictureBoxUserAvatar;
    }
}

