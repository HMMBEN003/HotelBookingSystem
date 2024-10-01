namespace HotelBookingSystem.Presentation
{
    partial class OTPForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OTPForm));
            this.homeButton = new System.Windows.Forms.PictureBox();
            this.verifyOTPLabel = new System.Windows.Forms.Label();
            this.backButton = new System.Windows.Forms.PictureBox();
            this.OTPInfoLabel = new System.Windows.Forms.Label();
            this.emailLabel = new System.Windows.Forms.Label();
            this.OTPtextBox = new System.Windows.Forms.TextBox();
            this.verifyButton = new System.Windows.Forms.Button();
            this.resendOTPButton = new System.Windows.Forms.Button();
            this.summariseBookingButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.homeButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.backButton)).BeginInit();
            this.SuspendLayout();
            // 
            // homeButton
            // 
            this.homeButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.homeButton.Image = ((System.Drawing.Image)(resources.GetObject("homeButton.Image")));
            this.homeButton.Location = new System.Drawing.Point(1392, 33);
            this.homeButton.Name = "homeButton";
            this.homeButton.Size = new System.Drawing.Size(52, 52);
            this.homeButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.homeButton.TabIndex = 10;
            this.homeButton.TabStop = false;
            this.homeButton.Click += new System.EventHandler(this.homeButton_Click);
            // 
            // verifyOTPLabel
            // 
            this.verifyOTPLabel.AutoSize = true;
            this.verifyOTPLabel.BackColor = System.Drawing.SystemColors.Control;
            this.verifyOTPLabel.Font = new System.Drawing.Font("Malgun Gothic", 28.24615F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.verifyOTPLabel.Location = new System.Drawing.Point(110, 34);
            this.verifyOTPLabel.Name = "verifyOTPLabel";
            this.verifyOTPLabel.Size = new System.Drawing.Size(215, 51);
            this.verifyOTPLabel.TabIndex = 9;
            this.verifyOTPLabel.Text = "Verify OTP";
            // 
            // backButton
            // 
            this.backButton.BackColor = System.Drawing.SystemColors.Control;
            this.backButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.backButton.Image = ((System.Drawing.Image)(resources.GetObject("backButton.Image")));
            this.backButton.Location = new System.Drawing.Point(44, 36);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(60, 49);
            this.backButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.backButton.TabIndex = 8;
            this.backButton.TabStop = false;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // OTPInfoLabel
            // 
            this.OTPInfoLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.OTPInfoLabel.AutoSize = true;
            this.OTPInfoLabel.BackColor = System.Drawing.SystemColors.Control;
            this.OTPInfoLabel.Font = new System.Drawing.Font("Malgun Gothic", 16.06154F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OTPInfoLabel.Location = new System.Drawing.Point(493, 169);
            this.OTPInfoLabel.Name = "OTPInfoLabel";
            this.OTPInfoLabel.Size = new System.Drawing.Size(508, 30);
            this.OTPInfoLabel.TabIndex = 16;
            this.OTPInfoLabel.Text = "An OTP has been sent to the customer\'s email:";
            // 
            // emailLabel
            // 
            this.emailLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.emailLabel.AutoSize = true;
            this.emailLabel.BackColor = System.Drawing.SystemColors.Control;
            this.emailLabel.Font = new System.Drawing.Font("Malgun Gothic", 16.06154F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emailLabel.Location = new System.Drawing.Point(812, 216);
            this.emailLabel.Name = "emailLabel";
            this.emailLabel.Size = new System.Drawing.Size(22, 30);
            this.emailLabel.TabIndex = 17;
            this.emailLabel.Text = "-";
            this.emailLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // OTPtextBox
            // 
            this.OTPtextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.OTPtextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.OTPtextBox.Font = new System.Drawing.Font("Malgun Gothic", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OTPtextBox.Location = new System.Drawing.Point(313, 262);
            this.OTPtextBox.Name = "OTPtextBox";
            this.OTPtextBox.Size = new System.Drawing.Size(861, 135);
            this.OTPtextBox.TabIndex = 18;
            this.OTPtextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // verifyButton
            // 
            this.verifyButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.verifyButton.BackColor = System.Drawing.Color.White;
            this.verifyButton.Font = new System.Drawing.Font("Malgun Gothic", 16.06154F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.verifyButton.ForeColor = System.Drawing.Color.Black;
            this.verifyButton.Location = new System.Drawing.Point(577, 423);
            this.verifyButton.Name = "verifyButton";
            this.verifyButton.Size = new System.Drawing.Size(340, 55);
            this.verifyButton.TabIndex = 19;
            this.verifyButton.Text = "Verify";
            this.verifyButton.UseVisualStyleBackColor = false;
            this.verifyButton.Click += new System.EventHandler(this.verifyButton_Click);
            // 
            // resendOTPButton
            // 
            this.resendOTPButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.resendOTPButton.BackColor = System.Drawing.Color.White;
            this.resendOTPButton.Font = new System.Drawing.Font("Malgun Gothic", 16.06154F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resendOTPButton.ForeColor = System.Drawing.Color.Black;
            this.resendOTPButton.Location = new System.Drawing.Point(99, 732);
            this.resendOTPButton.Name = "resendOTPButton";
            this.resendOTPButton.Size = new System.Drawing.Size(340, 55);
            this.resendOTPButton.TabIndex = 20;
            this.resendOTPButton.Text = "Resend OTP";
            this.resendOTPButton.UseVisualStyleBackColor = false;
            this.resendOTPButton.Click += new System.EventHandler(this.resendOTPButton_Click);
            // 
            // summariseBookingButton
            // 
            this.summariseBookingButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.summariseBookingButton.BackColor = System.Drawing.Color.LightGray;
            this.summariseBookingButton.Enabled = false;
            this.summariseBookingButton.Font = new System.Drawing.Font("Malgun Gothic", 16.06154F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.summariseBookingButton.ForeColor = System.Drawing.Color.Transparent;
            this.summariseBookingButton.Location = new System.Drawing.Point(1070, 732);
            this.summariseBookingButton.Name = "summariseBookingButton";
            this.summariseBookingButton.Size = new System.Drawing.Size(340, 55);
            this.summariseBookingButton.TabIndex = 21;
            this.summariseBookingButton.Text = "Summarise Booking";
            this.summariseBookingButton.UseVisualStyleBackColor = false;
            this.summariseBookingButton.Click += new System.EventHandler(this.summariseBookingButton_Click);
            // 
            // OTPForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1483, 856);
            this.Controls.Add(this.summariseBookingButton);
            this.Controls.Add(this.resendOTPButton);
            this.Controls.Add(this.verifyButton);
            this.Controls.Add(this.OTPtextBox);
            this.Controls.Add(this.emailLabel);
            this.Controls.Add(this.OTPInfoLabel);
            this.Controls.Add(this.homeButton);
            this.Controls.Add(this.verifyOTPLabel);
            this.Controls.Add(this.backButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "OTPForm";
            this.Text = "OTP Page";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.homeButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.backButton)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox homeButton;
        private System.Windows.Forms.Label verifyOTPLabel;
        private System.Windows.Forms.PictureBox backButton;
        private System.Windows.Forms.Label OTPInfoLabel;
        private System.Windows.Forms.Label emailLabel;
        private System.Windows.Forms.TextBox OTPtextBox;
        private System.Windows.Forms.Button verifyButton;
        private System.Windows.Forms.Button resendOTPButton;
        private System.Windows.Forms.Button summariseBookingButton;
    }
}