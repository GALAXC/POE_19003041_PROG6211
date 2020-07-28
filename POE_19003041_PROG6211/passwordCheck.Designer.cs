namespace POE_19003041_PROG6211
{
    partial class PasswordCheck
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PasswordCheck));
            this.passwordBox = new System.Windows.Forms.TextBox();
            this.passwordCheckLabel = new System.Windows.Forms.Label();
            this.okButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.showHidePasswordButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // passwordBox
            // 
            this.passwordBox.Location = new System.Drawing.Point(102, 67);
            this.passwordBox.Name = "passwordBox";
            this.passwordBox.Size = new System.Drawing.Size(214, 20);
            this.passwordBox.TabIndex = 0;
            this.passwordBox.UseSystemPasswordChar = true;
            // 
            // passwordCheckLabel
            // 
            this.passwordCheckLabel.AutoSize = true;
            this.passwordCheckLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordCheckLabel.Location = new System.Drawing.Point(99, 24);
            this.passwordCheckLabel.Name = "passwordCheckLabel";
            this.passwordCheckLabel.Size = new System.Drawing.Size(290, 16);
            this.passwordCheckLabel.TabIndex = 1;
            this.passwordCheckLabel.Text = "Please enter the password for: PLACEHOLDER";
            // 
            // okButton
            // 
            this.okButton.Location = new System.Drawing.Point(87, 116);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(75, 23);
            this.okButton.TabIndex = 2;
            this.okButton.Text = "Ok";
            this.okButton.UseVisualStyleBackColor = true;
            this.okButton.Click += new System.EventHandler(this.OkButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(256, 116);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 23);
            this.cancelButton.TabIndex = 3;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // showHidePasswordButton
            // 
            this.showHidePasswordButton.BackColor = System.Drawing.Color.Transparent;
            this.showHidePasswordButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("showHidePasswordButton.BackgroundImage")));
            this.showHidePasswordButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.showHidePasswordButton.Location = new System.Drawing.Point(336, 66);
            this.showHidePasswordButton.Name = "showHidePasswordButton";
            this.showHidePasswordButton.Size = new System.Drawing.Size(23, 23);
            this.showHidePasswordButton.TabIndex = 178;
            this.showHidePasswordButton.UseVisualStyleBackColor = false;
            this.showHidePasswordButton.Click += new System.EventHandler(this.ShowHidePasswordButton_Click);
            // 
            // PasswordCheck
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(424, 151);
            this.Controls.Add(this.showHidePasswordButton);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.okButton);
            this.Controls.Add(this.passwordCheckLabel);
            this.Controls.Add(this.passwordBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(440, 190);
            this.MinimumSize = new System.Drawing.Size(440, 190);
            this.Name = "PasswordCheck";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Weather Forecaster - Security Check";
            this.Load += new System.EventHandler(this.PasswordCheck_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox passwordBox;
        private System.Windows.Forms.Label passwordCheckLabel;
        private System.Windows.Forms.Button okButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button showHidePasswordButton;
    }
}