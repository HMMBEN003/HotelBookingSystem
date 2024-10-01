namespace HotelBookingSystem.Presentation
{
    partial class FindCustomerForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FindCustomerForm));
            this.FindCustomerLabel = new System.Windows.Forms.Label();
            this.backButton = new System.Windows.Forms.PictureBox();
            this.homeButton = new System.Windows.Forms.PictureBox();
            this.border = new System.Windows.Forms.PictureBox();
            this.enterEmailAddressLabel = new System.Windows.Forms.Label();
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.searchButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.backButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.homeButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.border)).BeginInit();
            this.SuspendLayout();
            // 
            // FindCustomerLabel
            // 
            this.FindCustomerLabel.AutoSize = true;
            this.FindCustomerLabel.BackColor = System.Drawing.SystemColors.Control;
            this.FindCustomerLabel.Font = new System.Drawing.Font("Malgun Gothic", 28.24615F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FindCustomerLabel.Location = new System.Drawing.Point(110, 34);
            this.FindCustomerLabel.Name = "FindCustomerLabel";
            this.FindCustomerLabel.Size = new System.Drawing.Size(287, 51);
            this.FindCustomerLabel.TabIndex = 7;
            this.FindCustomerLabel.Text = "Find Customer";
            // 
            // backButton
            // 
            this.backButton.BackColor = System.Drawing.SystemColors.Control;
            this.backButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.backButton.Image = ((System.Drawing.Image)(resources.GetObject("backButton.Image")));
            this.backButton.Location = new System.Drawing.Point(44, 41);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(60, 49);
            this.backButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.backButton.TabIndex = 6;
            this.backButton.TabStop = false;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // homeButton
            // 
            this.homeButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.homeButton.Image = ((System.Drawing.Image)(resources.GetObject("homeButton.Image")));
            this.homeButton.Location = new System.Drawing.Point(1392, 33);
            this.homeButton.Name = "homeButton";
            this.homeButton.Size = new System.Drawing.Size(52, 52);
            this.homeButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.homeButton.TabIndex = 8;
            this.homeButton.TabStop = false;
            this.homeButton.Click += new System.EventHandler(this.homeButton_Click);
            // 
            // border
            // 
            this.border.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.border.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.border.Location = new System.Drawing.Point(534, 244);
            this.border.Name = "border";
            this.border.Size = new System.Drawing.Size(520, 280);
            this.border.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.border.TabIndex = 9;
            this.border.TabStop = false;
            // 
            // enterEmailAddressLabel
            // 
            this.enterEmailAddressLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.enterEmailAddressLabel.AutoSize = true;
            this.enterEmailAddressLabel.BackColor = System.Drawing.SystemColors.Control;
            this.enterEmailAddressLabel.Font = new System.Drawing.Font("Malgun Gothic", 28.24615F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.enterEmailAddressLabel.Location = new System.Drawing.Point(603, 261);
            this.enterEmailAddressLabel.Name = "enterEmailAddressLabel";
            this.enterEmailAddressLabel.Size = new System.Drawing.Size(385, 51);
            this.enterEmailAddressLabel.TabIndex = 10;
            this.enterEmailAddressLabel.Text = "Enter Email Address";
            // 
            // emailTextBox
            // 
            this.emailTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.emailTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.emailTextBox.Font = new System.Drawing.Font("Malgun Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emailTextBox.Location = new System.Drawing.Point(624, 351);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(340, 43);
            this.emailTextBox.TabIndex = 11;
            this.emailTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.emailTextBox.TextChanged += new System.EventHandler(this.emailTextBox_TextChanged);
            // 
            // searchButton
            // 
            this.searchButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.searchButton.BackColor = System.Drawing.Color.LightGray;
            this.searchButton.Font = new System.Drawing.Font("Malgun Gothic", 16.06154F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchButton.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.searchButton.Location = new System.Drawing.Point(624, 436);
            this.searchButton.Name = "searchButton";
            this.searchButton.Padding = new System.Windows.Forms.Padding(8);
            this.searchButton.Size = new System.Drawing.Size(340, 55);
            this.searchButton.TabIndex = 12;
            this.searchButton.Text = "Search";
            this.searchButton.UseVisualStyleBackColor = false;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // FindCustomerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1483, 856);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.emailTextBox);
            this.Controls.Add(this.enterEmailAddressLabel);
            this.Controls.Add(this.border);
            this.Controls.Add(this.homeButton);
            this.Controls.Add(this.FindCustomerLabel);
            this.Controls.Add(this.backButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "FindCustomerForm";
            this.Text = "FindCustomerForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.backButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.homeButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.border)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label FindCustomerLabel;
        private System.Windows.Forms.PictureBox backButton;
        private System.Windows.Forms.PictureBox homeButton;
        private System.Windows.Forms.PictureBox border;
        private System.Windows.Forms.Label enterEmailAddressLabel;
        private System.Windows.Forms.TextBox emailTextBox;
        private System.Windows.Forms.Button searchButton;
    }
}