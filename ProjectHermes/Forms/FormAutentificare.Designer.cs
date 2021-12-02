namespace ProjectHermes
{
    partial class FormAutentificare
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
            this.adviceLabel = new System.Windows.Forms.Label();
            this.guna2CirclePictureBox1 = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.textBoxUsername = new Guna.UI2.WinForms.Guna2TextBox();
            this.textBoxPassword = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnLogin = new Guna.UI2.WinForms.Guna2TileButton();
            this.labelLogin = new System.Windows.Forms.Label();
            this.loginClose = new Guna.UI2.WinForms.Guna2ControlBox();
            this.loginMinimize = new Guna.UI2.WinForms.Guna2ControlBox();
            ((System.ComponentModel.ISupportInitialize)(this.guna2CirclePictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // adviceLabel
            // 
            this.adviceLabel.AutoSize = true;
            this.adviceLabel.BackColor = System.Drawing.Color.Transparent;
            this.adviceLabel.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.adviceLabel.ForeColor = System.Drawing.Color.White;
            this.adviceLabel.Location = new System.Drawing.Point(216, 447);
            this.adviceLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.adviceLabel.Name = "adviceLabel";
            this.adviceLabel.Size = new System.Drawing.Size(30, 16);
            this.adviceLabel.TabIndex = 6;
            this.adviceLabel.Text = "NaN";
            this.adviceLabel.Visible = false;
            // 
            // guna2CirclePictureBox1
            // 
            this.guna2CirclePictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.guna2CirclePictureBox1.Image = global::ProjectHermes.Properties.Resources.LOGO;
            this.guna2CirclePictureBox1.ImageRotate = 0F;
            this.guna2CirclePictureBox1.Location = new System.Drawing.Point(250, 56);
            this.guna2CirclePictureBox1.Name = "guna2CirclePictureBox1";
            this.guna2CirclePictureBox1.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.guna2CirclePictureBox1.ShadowDecoration.Parent = this.guna2CirclePictureBox1;
            this.guna2CirclePictureBox1.Size = new System.Drawing.Size(122, 118);
            this.guna2CirclePictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.guna2CirclePictureBox1.TabIndex = 8;
            this.guna2CirclePictureBox1.TabStop = false;
            this.guna2CirclePictureBox1.UseTransparentBackground = true;
            // 
            // textBoxUsername
            // 
            this.textBoxUsername.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBoxUsername.DefaultText = "";
            this.textBoxUsername.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.textBoxUsername.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.textBoxUsername.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textBoxUsername.DisabledState.Parent = this.textBoxUsername;
            this.textBoxUsername.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textBoxUsername.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textBoxUsername.FocusedState.Parent = this.textBoxUsername;
            this.textBoxUsername.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxUsername.ForeColor = System.Drawing.Color.Black;
            this.textBoxUsername.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textBoxUsername.HoverState.Parent = this.textBoxUsername;
            this.textBoxUsername.Location = new System.Drawing.Point(208, 269);
            this.textBoxUsername.Name = "textBoxUsername";
            this.textBoxUsername.PasswordChar = '\0';
            this.textBoxUsername.PlaceholderForeColor = System.Drawing.Color.Black;
            this.textBoxUsername.PlaceholderText = "Nume Utilizator";
            this.textBoxUsername.SelectedText = "";
            this.textBoxUsername.ShadowDecoration.Parent = this.textBoxUsername;
            this.textBoxUsername.Size = new System.Drawing.Size(200, 38);
            this.textBoxUsername.TabIndex = 9;
            this.textBoxUsername.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBoxPassword.DefaultText = "";
            this.textBoxPassword.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.textBoxPassword.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.textBoxPassword.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textBoxPassword.DisabledState.Parent = this.textBoxPassword;
            this.textBoxPassword.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textBoxPassword.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textBoxPassword.FocusedState.Parent = this.textBoxPassword;
            this.textBoxPassword.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPassword.ForeColor = System.Drawing.Color.Black;
            this.textBoxPassword.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textBoxPassword.HoverState.Parent = this.textBoxPassword;
            this.textBoxPassword.Location = new System.Drawing.Point(208, 324);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.PasswordChar = '*';
            this.textBoxPassword.PlaceholderForeColor = System.Drawing.Color.Black;
            this.textBoxPassword.PlaceholderText = "Parola";
            this.textBoxPassword.SelectedText = "";
            this.textBoxPassword.ShadowDecoration.Parent = this.textBoxPassword;
            this.textBoxPassword.Size = new System.Drawing.Size(200, 38);
            this.textBoxPassword.TabIndex = 10;
            this.textBoxPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnLogin
            // 
            this.btnLogin.Animated = true;
            this.btnLogin.CheckedState.Parent = this.btnLogin;
            this.btnLogin.CustomImages.Parent = this.btnLogin;
            this.btnLogin.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnLogin.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnLogin.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnLogin.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnLogin.DisabledState.Parent = this.btnLogin;
            this.btnLogin.FillColor = System.Drawing.SystemColors.HotTrack;
            this.btnLogin.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.ForeColor = System.Drawing.Color.White;
            this.btnLogin.HoverState.Parent = this.btnLogin;
            this.btnLogin.Location = new System.Drawing.Point(208, 377);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.ShadowDecoration.Parent = this.btnLogin;
            this.btnLogin.Size = new System.Drawing.Size(200, 51);
            this.btnLogin.TabIndex = 11;
            this.btnLogin.Text = "Autentificare";
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // labelLogin
            // 
            this.labelLogin.AutoSize = true;
            this.labelLogin.BackColor = System.Drawing.Color.Transparent;
            this.labelLogin.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLogin.ForeColor = System.Drawing.Color.White;
            this.labelLogin.Location = new System.Drawing.Point(185, 188);
            this.labelLogin.Name = "labelLogin";
            this.labelLogin.Size = new System.Drawing.Size(251, 69);
            this.labelLogin.TabIndex = 12;
            this.labelLogin.Text = "Project Hermes\r\nEducational Management\r\nSoftware";
            this.labelLogin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // loginClose
            // 
            this.loginClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.loginClose.Animated = true;
            this.loginClose.BackColor = System.Drawing.Color.Transparent;
            this.loginClose.FillColor = System.Drawing.Color.Transparent;
            this.loginClose.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginClose.HoverState.Parent = this.loginClose;
            this.loginClose.IconColor = System.Drawing.Color.White;
            this.loginClose.Location = new System.Drawing.Point(581, 0);
            this.loginClose.Name = "loginClose";
            this.loginClose.PressedColor = System.Drawing.SystemColors.HotTrack;
            this.loginClose.ShadowDecoration.Parent = this.loginClose;
            this.loginClose.Size = new System.Drawing.Size(45, 29);
            this.loginClose.TabIndex = 13;
            // 
            // loginMinimize
            // 
            this.loginMinimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.loginMinimize.Animated = true;
            this.loginMinimize.BackColor = System.Drawing.Color.Transparent;
            this.loginMinimize.ControlBoxType = Guna.UI2.WinForms.Enums.ControlBoxType.MinimizeBox;
            this.loginMinimize.FillColor = System.Drawing.Color.Transparent;
            this.loginMinimize.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginMinimize.HoverState.Parent = this.loginMinimize;
            this.loginMinimize.IconColor = System.Drawing.Color.White;
            this.loginMinimize.Location = new System.Drawing.Point(536, 0);
            this.loginMinimize.Name = "loginMinimize";
            this.loginMinimize.PressedColor = System.Drawing.SystemColors.HotTrack;
            this.loginMinimize.ShadowDecoration.Parent = this.loginMinimize;
            this.loginMinimize.Size = new System.Drawing.Size(45, 29);
            this.loginMinimize.TabIndex = 14;
            // 
            // FormAutentificare
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ProjectHermes.Properties.Resources.wallpaper;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(626, 584);
            this.ControlBox = false;
            this.Controls.Add(this.loginMinimize);
            this.Controls.Add(this.loginClose);
            this.Controls.Add(this.labelLogin);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.textBoxPassword);
            this.Controls.Add(this.textBoxUsername);
            this.Controls.Add(this.guna2CirclePictureBox1);
            this.Controls.Add(this.adviceLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "FormAutentificare";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Project Hermes";
            ((System.ComponentModel.ISupportInitialize)(this.guna2CirclePictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label adviceLabel;
        private Guna.UI2.WinForms.Guna2CirclePictureBox guna2CirclePictureBox1;
        private Guna.UI2.WinForms.Guna2TextBox textBoxUsername;
        private Guna.UI2.WinForms.Guna2TextBox textBoxPassword;
        private Guna.UI2.WinForms.Guna2TileButton btnLogin;
        private System.Windows.Forms.Label labelLogin;
        private Guna.UI2.WinForms.Guna2ControlBox loginClose;
        private Guna.UI2.WinForms.Guna2ControlBox loginMinimize;
    }
}

