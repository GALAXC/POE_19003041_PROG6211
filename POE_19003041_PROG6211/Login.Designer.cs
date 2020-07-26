namespace POE_19003041_PROG6211
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.loginQuitButton = new System.Windows.Forms.Button();
            this.loginButton = new System.Windows.Forms.Button();
            this.loginUsernameBox = new System.Windows.Forms.TextBox();
            this.loginPasswordBox = new System.Windows.Forms.TextBox();
            this.loginUsernameLabel = new System.Windows.Forms.Label();
            this.loginPasswordLabel = new System.Windows.Forms.Label();
            this.loginWelcomeLabel = new System.Windows.Forms.Label();
            this.showHidePasswordButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // loginQuitButton
            // 
            this.loginQuitButton.Location = new System.Drawing.Point(289, 160);
            this.loginQuitButton.Name = "loginQuitButton";
            this.loginQuitButton.Size = new System.Drawing.Size(75, 23);
            this.loginQuitButton.TabIndex = 0;
            this.loginQuitButton.Text = "Quit";
            this.loginQuitButton.UseVisualStyleBackColor = true;
            this.loginQuitButton.Click += new System.EventHandler(this.loginQuitButton_Click);
            // 
            // loginButton
            // 
            this.loginButton.Location = new System.Drawing.Point(82, 160);
            this.loginButton.Name = "loginButton";
            this.loginButton.Size = new System.Drawing.Size(75, 23);
            this.loginButton.TabIndex = 1;
            this.loginButton.Text = "Login";
            this.loginButton.UseVisualStyleBackColor = true;
            this.loginButton.Click += new System.EventHandler(this.loginButton_Click);
            // 
            // loginUsernameBox
            // 
            this.loginUsernameBox.Location = new System.Drawing.Point(82, 91);
            this.loginUsernameBox.Name = "loginUsernameBox";
            this.loginUsernameBox.Size = new System.Drawing.Size(282, 20);
            this.loginUsernameBox.TabIndex = 2;
            this.loginUsernameBox.Text = "Taine";
            // 
            // loginPasswordBox
            // 
            this.loginPasswordBox.Location = new System.Drawing.Point(82, 118);
            this.loginPasswordBox.Name = "loginPasswordBox";
            this.loginPasswordBox.Size = new System.Drawing.Size(282, 20);
            this.loginPasswordBox.TabIndex = 3;
            this.loginPasswordBox.Text = "Password123";
            this.loginPasswordBox.UseSystemPasswordChar = true;
            // 
            // loginUsernameLabel
            // 
            this.loginUsernameLabel.AutoSize = true;
            this.loginUsernameLabel.Location = new System.Drawing.Point(18, 94);
            this.loginUsernameLabel.Name = "loginUsernameLabel";
            this.loginUsernameLabel.Size = new System.Drawing.Size(58, 13);
            this.loginUsernameLabel.TabIndex = 4;
            this.loginUsernameLabel.Text = "Username:";
            // 
            // loginPasswordLabel
            // 
            this.loginPasswordLabel.AutoSize = true;
            this.loginPasswordLabel.Location = new System.Drawing.Point(20, 121);
            this.loginPasswordLabel.Name = "loginPasswordLabel";
            this.loginPasswordLabel.Size = new System.Drawing.Size(56, 13);
            this.loginPasswordLabel.TabIndex = 5;
            this.loginPasswordLabel.Text = "Password:";
            // 
            // loginWelcomeLabel
            // 
            this.loginWelcomeLabel.AutoSize = true;
            this.loginWelcomeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginWelcomeLabel.Location = new System.Drawing.Point(127, 9);
            this.loginWelcomeLabel.MaximumSize = new System.Drawing.Size(200, 0);
            this.loginWelcomeLabel.Name = "loginWelcomeLabel";
            this.loginWelcomeLabel.Size = new System.Drawing.Size(176, 60);
            this.loginWelcomeLabel.TabIndex = 6;
            this.loginWelcomeLabel.Text = "Welcome to the Weather Forecaster Desktop App";
            this.loginWelcomeLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // showHidePasswordButton
            // 
            this.showHidePasswordButton.BackColor = System.Drawing.Color.Transparent;
            this.showHidePasswordButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("showHidePasswordButton.BackgroundImage")));
            this.showHidePasswordButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.showHidePasswordButton.Location = new System.Drawing.Point(377, 117);
            this.showHidePasswordButton.Name = "showHidePasswordButton";
            this.showHidePasswordButton.Size = new System.Drawing.Size(23, 23);
            this.showHidePasswordButton.TabIndex = 179;
            this.showHidePasswordButton.UseVisualStyleBackColor = false;
            this.showHidePasswordButton.Click += new System.EventHandler(this.showHidePasswordButton_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(414, 195);
            this.Controls.Add(this.showHidePasswordButton);
            this.Controls.Add(this.loginWelcomeLabel);
            this.Controls.Add(this.loginPasswordLabel);
            this.Controls.Add(this.loginUsernameLabel);
            this.Controls.Add(this.loginPasswordBox);
            this.Controls.Add(this.loginUsernameBox);
            this.Controls.Add(this.loginButton);
            this.Controls.Add(this.loginQuitButton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(430, 234);
            this.MinimumSize = new System.Drawing.Size(430, 234);
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Weather Forecaster - Login";
            this.Load += new System.EventHandler(this.Login_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button loginQuitButton;
        private System.Windows.Forms.Button loginButton;
        private System.Windows.Forms.TextBox loginUsernameBox;
        private System.Windows.Forms.TextBox loginPasswordBox;
        private System.Windows.Forms.Label loginUsernameLabel;
        private System.Windows.Forms.Label loginPasswordLabel;
        private System.Windows.Forms.Label loginWelcomeLabel;
        private System.Windows.Forms.Button showHidePasswordButton;
    }
}