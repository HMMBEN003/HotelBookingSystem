namespace HotelBookingSystem
{
    partial class LoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this.loginLabel = new System.Windows.Forms.Label();
            this.staffNumberTextBox = new System.Windows.Forms.TextBox();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.staffNumberLabel = new System.Windows.Forms.Label();
            this.passwordLabel = new System.Windows.Forms.Label();
            this.logInButton = new System.Windows.Forms.Button();
            this.incorrectLabel = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // loginLabel
            // 
            this.loginLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.loginLabel.AutoSize = true;
            this.loginLabel.BackColor = System.Drawing.Color.Transparent;
            this.loginLabel.Font = new System.Drawing.Font("Malgun Gothic", 39.87692F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginLabel.Location = new System.Drawing.Point(324, 129);
            this.loginLabel.Name = "loginLabel";
            this.loginLabel.Size = new System.Drawing.Size(173, 72);
            this.loginLabel.TabIndex = 2;
            this.loginLabel.Text = "Login";
            // 
            // staffNumberTextBox
            // 
            this.staffNumberTextBox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.staffNumberTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.staffNumberTextBox.Font = new System.Drawing.Font("Malgun Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.staffNumberTextBox.Location = new System.Drawing.Point(234, 261);
            this.staffNumberTextBox.Name = "staffNumberTextBox";
            this.staffNumberTextBox.Size = new System.Drawing.Size(340, 36);
            this.staffNumberTextBox.TabIndex = 3;
            this.staffNumberTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.passwordTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.passwordTextBox.Font = new System.Drawing.Font("Malgun Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordTextBox.Location = new System.Drawing.Point(234, 366);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.Size = new System.Drawing.Size(340, 36);
            this.passwordTextBox.TabIndex = 4;
            this.passwordTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.passwordTextBox.UseSystemPasswordChar = true;
            // 
            // staffNumberLabel
            // 
            this.staffNumberLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.staffNumberLabel.AutoSize = true;
            this.staffNumberLabel.BackColor = System.Drawing.Color.Transparent;
            this.staffNumberLabel.Font = new System.Drawing.Font("Malgun Gothic", 16.06154F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.staffNumberLabel.Location = new System.Drawing.Point(339, 225);
            this.staffNumberLabel.Name = "staffNumberLabel";
            this.staffNumberLabel.Size = new System.Drawing.Size(148, 30);
            this.staffNumberLabel.TabIndex = 5;
            this.staffNumberLabel.Text = "Staff Number";
            // 
            // passwordLabel
            // 
            this.passwordLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.BackColor = System.Drawing.Color.Transparent;
            this.passwordLabel.Font = new System.Drawing.Font("Malgun Gothic", 16.06154F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordLabel.Location = new System.Drawing.Point(357, 330);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(107, 30);
            this.passwordLabel.TabIndex = 6;
            this.passwordLabel.Text = "Password";
            // 
            // logInButton
            // 
            this.logInButton.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.logInButton.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.logInButton.Font = new System.Drawing.Font("Malgun Gothic", 16.06154F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logInButton.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.logInButton.Location = new System.Drawing.Point(234, 459);
            this.logInButton.Name = "logInButton";
            this.logInButton.Padding = new System.Windows.Forms.Padding(8);
            this.logInButton.Size = new System.Drawing.Size(340, 55);
            this.logInButton.TabIndex = 7;
            this.logInButton.Text = "Log In";
            this.logInButton.UseVisualStyleBackColor = false;
            this.logInButton.Click += new System.EventHandler(this.logInButton_Click);
            // 
            // incorrectLabel
            // 
            this.incorrectLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.incorrectLabel.AutoSize = true;
            this.incorrectLabel.BackColor = System.Drawing.Color.Transparent;
            this.incorrectLabel.Font = new System.Drawing.Font("Malgun Gothic Semilight", 12.18462F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.incorrectLabel.ForeColor = System.Drawing.Color.Red;
            this.incorrectLabel.Location = new System.Drawing.Point(230, 422);
            this.incorrectLabel.Name = "incorrectLabel";
            this.incorrectLabel.Size = new System.Drawing.Size(360, 23);
            this.incorrectLabel.TabIndex = 8;
            this.incorrectLabel.Text = "Incorrect Staff Number or Password, Try Again";
            this.incorrectLabel.Visible = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(784, 611);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(0, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(800, 1800);
            this.pictureBox2.TabIndex = 10;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(212, 25);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(362, 186);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox3.TabIndex = 11;
            this.pictureBox3.TabStop = false;
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(784, 611);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.incorrectLabel);
            this.Controls.Add(this.logInButton);
            this.Controls.Add(this.passwordLabel);
            this.Controls.Add(this.staffNumberLabel);
            this.Controls.Add(this.passwordTextBox);
            this.Controls.Add(this.staffNumberTextBox);
            this.Controls.Add(this.loginLabel);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.MinimumSize = new System.Drawing.Size(800, 650);
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login Page";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label loginLabel;
        private System.Windows.Forms.TextBox staffNumberTextBox;
        private System.Windows.Forms.TextBox passwordTextBox;
        private System.Windows.Forms.Label staffNumberLabel;
        private System.Windows.Forms.Label passwordLabel;
        private System.Windows.Forms.Button logInButton;
        private System.Windows.Forms.Label incorrectLabel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
    }
}

