namespace HotelBookingSystem.Presentation
{
    partial class PricingForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PricingForm));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.backButton = new System.Windows.Forms.PictureBox();
            this.BookingPricingLabel = new System.Windows.Forms.Label();
            this.homeButton = new System.Windows.Forms.PictureBox();
            this.selectedRoomsLabel = new System.Windows.Forms.Label();
            this.selectedRoomsListView = new System.Windows.Forms.ListView();
            this.clickToConfigureLabel = new System.Windows.Forms.Label();
            this.adultUpDown = new System.Windows.Forms.NumericUpDown();
            this.childrenUpDown = new System.Windows.Forms.NumericUpDown();
            this.infantsUpDown = new System.Windows.Forms.NumericUpDown();
            this.numberOfAdultsLabel = new System.Windows.Forms.Label();
            this.numberOfChildrenLabel = new System.Windows.Forms.Label();
            this.numberOfInfantsLabel = new System.Windows.Forms.Label();
            this.confirmDepositPricingButton = new System.Windows.Forms.Button();
            this.totalPriceHeadingLabel = new System.Windows.Forms.Label();
            this.depositHeadingLabel = new System.Windows.Forms.Label();
            this.depositLabel = new System.Windows.Forms.Label();
            this.totalPriceLabel = new System.Windows.Forms.Label();
            this.timeFrameLabel = new System.Windows.Forms.Label();
            this.importantInfoLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.backButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.homeButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.adultUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.childrenUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.infantsUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(229)))), ((int)(((byte)(229)))));
            this.pictureBox1.Location = new System.Drawing.Point(-2, -137);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(508, 1934);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // backButton
            // 
            this.backButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(229)))), ((int)(((byte)(229)))));
            this.backButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.backButton.Image = ((System.Drawing.Image)(resources.GetObject("backButton.Image")));
            this.backButton.Location = new System.Drawing.Point(44, 41);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(60, 49);
            this.backButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.backButton.TabIndex = 3;
            this.backButton.TabStop = false;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // BookingPricingLabel
            // 
            this.BookingPricingLabel.AutoSize = true;
            this.BookingPricingLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(229)))), ((int)(((byte)(229)))));
            this.BookingPricingLabel.Font = new System.Drawing.Font("Malgun Gothic", 28.24615F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BookingPricingLabel.Location = new System.Drawing.Point(110, 34);
            this.BookingPricingLabel.Name = "BookingPricingLabel";
            this.BookingPricingLabel.Size = new System.Drawing.Size(309, 51);
            this.BookingPricingLabel.TabIndex = 5;
            this.BookingPricingLabel.Text = "Booking Pricing";
            // 
            // homeButton
            // 
            this.homeButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.homeButton.Image = ((System.Drawing.Image)(resources.GetObject("homeButton.Image")));
            this.homeButton.Location = new System.Drawing.Point(1392, 33);
            this.homeButton.Name = "homeButton";
            this.homeButton.Size = new System.Drawing.Size(52, 52);
            this.homeButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.homeButton.TabIndex = 6;
            this.homeButton.TabStop = false;
            this.homeButton.Click += new System.EventHandler(this.homeButton_Click);
            // 
            // selectedRoomsLabel
            // 
            this.selectedRoomsLabel.AutoSize = true;
            this.selectedRoomsLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(229)))), ((int)(((byte)(229)))));
            this.selectedRoomsLabel.Font = new System.Drawing.Font("Malgun Gothic", 16.06154F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.selectedRoomsLabel.Location = new System.Drawing.Point(39, 167);
            this.selectedRoomsLabel.Name = "selectedRoomsLabel";
            this.selectedRoomsLabel.Size = new System.Drawing.Size(180, 30);
            this.selectedRoomsLabel.TabIndex = 7;
            this.selectedRoomsLabel.Text = "Selected Rooms";
            // 
            // selectedRoomsListView
            // 
            this.selectedRoomsListView.Font = new System.Drawing.Font("Malgun Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.selectedRoomsListView.HideSelection = false;
            this.selectedRoomsListView.Location = new System.Drawing.Point(44, 223);
            this.selectedRoomsListView.Name = "selectedRoomsListView";
            this.selectedRoomsListView.Size = new System.Drawing.Size(415, 118);
            this.selectedRoomsListView.TabIndex = 8;
            this.selectedRoomsListView.UseCompatibleStateImageBehavior = false;
            // 
            // clickToConfigureLabel
            // 
            this.clickToConfigureLabel.AutoSize = true;
            this.clickToConfigureLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(229)))), ((int)(((byte)(229)))));
            this.clickToConfigureLabel.Font = new System.Drawing.Font("Malgun Gothic Semilight", 12.18462F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clickToConfigureLabel.Location = new System.Drawing.Point(40, 197);
            this.clickToConfigureLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.clickToConfigureLabel.Name = "clickToConfigureLabel";
            this.clickToConfigureLabel.Size = new System.Drawing.Size(142, 23);
            this.clickToConfigureLabel.TabIndex = 21;
            this.clickToConfigureLabel.Text = "Click to configure";
            // 
            // adultUpDown
            // 
            this.adultUpDown.Font = new System.Drawing.Font("Malgun Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adultUpDown.Location = new System.Drawing.Point(44, 397);
            this.adultUpDown.Maximum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.adultUpDown.Name = "adultUpDown";
            this.adultUpDown.Size = new System.Drawing.Size(175, 35);
            this.adultUpDown.TabIndex = 24;
            this.adultUpDown.Visible = false;
            // 
            // childrenUpDown
            // 
            this.childrenUpDown.Font = new System.Drawing.Font("Malgun Gothic", 15.75F);
            this.childrenUpDown.Location = new System.Drawing.Point(44, 470);
            this.childrenUpDown.Maximum = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.childrenUpDown.Name = "childrenUpDown";
            this.childrenUpDown.Size = new System.Drawing.Size(175, 35);
            this.childrenUpDown.TabIndex = 25;
            this.childrenUpDown.Visible = false;
            // 
            // infantsUpDown
            // 
            this.infantsUpDown.Font = new System.Drawing.Font("Malgun Gothic", 15.75F);
            this.infantsUpDown.Location = new System.Drawing.Point(44, 543);
            this.infantsUpDown.Maximum = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.infantsUpDown.Name = "infantsUpDown";
            this.infantsUpDown.Size = new System.Drawing.Size(175, 35);
            this.infantsUpDown.TabIndex = 26;
            this.infantsUpDown.Visible = false;
            // 
            // numberOfAdultsLabel
            // 
            this.numberOfAdultsLabel.AutoSize = true;
            this.numberOfAdultsLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(229)))), ((int)(((byte)(229)))));
            this.numberOfAdultsLabel.Font = new System.Drawing.Font("Malgun Gothic Semilight", 12.18462F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numberOfAdultsLabel.Location = new System.Drawing.Point(40, 371);
            this.numberOfAdultsLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.numberOfAdultsLabel.Name = "numberOfAdultsLabel";
            this.numberOfAdultsLabel.Size = new System.Drawing.Size(145, 23);
            this.numberOfAdultsLabel.TabIndex = 27;
            this.numberOfAdultsLabel.Text = "Number of Adults";
            this.numberOfAdultsLabel.Visible = false;
            // 
            // numberOfChildrenLabel
            // 
            this.numberOfChildrenLabel.AutoSize = true;
            this.numberOfChildrenLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(229)))), ((int)(((byte)(229)))));
            this.numberOfChildrenLabel.Font = new System.Drawing.Font("Malgun Gothic Semilight", 12.18462F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numberOfChildrenLabel.Location = new System.Drawing.Point(40, 444);
            this.numberOfChildrenLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.numberOfChildrenLabel.Name = "numberOfChildrenLabel";
            this.numberOfChildrenLabel.Size = new System.Drawing.Size(238, 23);
            this.numberOfChildrenLabel.TabIndex = 28;
            this.numberOfChildrenLabel.Text = "Number of Children (5-16 y/o)";
            this.numberOfChildrenLabel.Visible = false;
            // 
            // numberOfInfantsLabel
            // 
            this.numberOfInfantsLabel.AutoSize = true;
            this.numberOfInfantsLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(229)))), ((int)(((byte)(229)))));
            this.numberOfInfantsLabel.Font = new System.Drawing.Font("Malgun Gothic Semilight", 12.18462F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numberOfInfantsLabel.Location = new System.Drawing.Point(40, 517);
            this.numberOfInfantsLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.numberOfInfantsLabel.Name = "numberOfInfantsLabel";
            this.numberOfInfantsLabel.Size = new System.Drawing.Size(252, 23);
            this.numberOfInfantsLabel.TabIndex = 29;
            this.numberOfInfantsLabel.Text = "Number of Infants (under 5 y/o)";
            this.numberOfInfantsLabel.Visible = false;
            // 
            // confirmDepositPricingButton
            // 
            this.confirmDepositPricingButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.confirmDepositPricingButton.BackColor = System.Drawing.Color.Black;
            this.confirmDepositPricingButton.Font = new System.Drawing.Font("Malgun Gothic", 16.06154F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.confirmDepositPricingButton.ForeColor = System.Drawing.Color.White;
            this.confirmDepositPricingButton.Location = new System.Drawing.Point(807, 692);
            this.confirmDepositPricingButton.Name = "confirmDepositPricingButton";
            this.confirmDepositPricingButton.Size = new System.Drawing.Size(438, 101);
            this.confirmDepositPricingButton.TabIndex = 30;
            this.confirmDepositPricingButton.Text = "Confirm Deposit Pricing";
            this.confirmDepositPricingButton.UseVisualStyleBackColor = false;
            this.confirmDepositPricingButton.Click += new System.EventHandler(this.confirmDepositPricingButton_Click);
            // 
            // totalPriceHeadingLabel
            // 
            this.totalPriceHeadingLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.totalPriceHeadingLabel.AutoSize = true;
            this.totalPriceHeadingLabel.BackColor = System.Drawing.SystemColors.Control;
            this.totalPriceHeadingLabel.Font = new System.Drawing.Font("Malgun Gothic Semilight", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalPriceHeadingLabel.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.totalPriceHeadingLabel.Location = new System.Drawing.Point(948, 141);
            this.totalPriceHeadingLabel.Name = "totalPriceHeadingLabel";
            this.totalPriceHeadingLabel.Size = new System.Drawing.Size(110, 30);
            this.totalPriceHeadingLabel.TabIndex = 31;
            this.totalPriceHeadingLabel.Text = "Total Price";
            // 
            // depositHeadingLabel
            // 
            this.depositHeadingLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.depositHeadingLabel.AutoSize = true;
            this.depositHeadingLabel.BackColor = System.Drawing.SystemColors.Control;
            this.depositHeadingLabel.Font = new System.Drawing.Font("Malgun Gothic", 16.06154F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.depositHeadingLabel.Location = new System.Drawing.Point(926, 411);
            this.depositHeadingLabel.Name = "depositHeadingLabel";
            this.depositHeadingLabel.Size = new System.Drawing.Size(162, 30);
            this.depositHeadingLabel.TabIndex = 32;
            this.depositHeadingLabel.Text = "Deposit (10%)";
            // 
            // depositLabel
            // 
            this.depositLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.depositLabel.AutoSize = true;
            this.depositLabel.BackColor = System.Drawing.SystemColors.Control;
            this.depositLabel.Font = new System.Drawing.Font("Malgun Gothic", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.depositLabel.Location = new System.Drawing.Point(889, 466);
            this.depositLabel.Name = "depositLabel";
            this.depositLabel.Size = new System.Drawing.Size(116, 86);
            this.depositLabel.TabIndex = 33;
            this.depositLabel.Text = "R0";
            this.depositLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // totalPriceLabel
            // 
            this.totalPriceLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.totalPriceLabel.AutoSize = true;
            this.totalPriceLabel.BackColor = System.Drawing.SystemColors.Control;
            this.totalPriceLabel.Font = new System.Drawing.Font("Malgun Gothic Semilight", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalPriceLabel.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.totalPriceLabel.Location = new System.Drawing.Point(889, 197);
            this.totalPriceLabel.Name = "totalPriceLabel";
            this.totalPriceLabel.Size = new System.Drawing.Size(109, 86);
            this.totalPriceLabel.TabIndex = 34;
            this.totalPriceLabel.Text = "R0";
            this.totalPriceLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // timeFrameLabel
            // 
            this.timeFrameLabel.AutoSize = true;
            this.timeFrameLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(229)))), ((int)(((byte)(229)))));
            this.timeFrameLabel.Font = new System.Drawing.Font("Malgun Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timeFrameLabel.Location = new System.Drawing.Point(40, 108);
            this.timeFrameLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.timeFrameLabel.Name = "timeFrameLabel";
            this.timeFrameLabel.Size = new System.Drawing.Size(310, 21);
            this.timeFrameLabel.TabIndex = 36;
            this.timeFrameLabel.Text = "Time Frame: 8 Oct 2024 - 12 Nov 2024";
            // 
            // importantInfoLabel
            // 
            this.importantInfoLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.importantInfoLabel.AutoSize = true;
            this.importantInfoLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(229)))), ((int)(((byte)(229)))));
            this.importantInfoLabel.Font = new System.Drawing.Font("Malgun Gothic Semilight", 12.18462F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.importantInfoLabel.Location = new System.Drawing.Point(40, 721);
            this.importantInfoLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.importantInfoLabel.Name = "importantInfoLabel";
            this.importantInfoLabel.Size = new System.Drawing.Size(436, 69);
            this.importantInfoLabel.TabIndex = 37;
            this.importantInfoLabel.Text = "*Rates per night may vary:\r\nMid Season (8-15 December): R750 per room per night\r\n" +
    "High Season (16-31 December): R995 per room per night";
            this.importantInfoLabel.Visible = false;
            // 
            // PricingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1483, 856);
            this.Controls.Add(this.importantInfoLabel);
            this.Controls.Add(this.timeFrameLabel);
            this.Controls.Add(this.totalPriceLabel);
            this.Controls.Add(this.depositLabel);
            this.Controls.Add(this.depositHeadingLabel);
            this.Controls.Add(this.totalPriceHeadingLabel);
            this.Controls.Add(this.confirmDepositPricingButton);
            this.Controls.Add(this.numberOfInfantsLabel);
            this.Controls.Add(this.numberOfChildrenLabel);
            this.Controls.Add(this.numberOfAdultsLabel);
            this.Controls.Add(this.infantsUpDown);
            this.Controls.Add(this.childrenUpDown);
            this.Controls.Add(this.adultUpDown);
            this.Controls.Add(this.clickToConfigureLabel);
            this.Controls.Add(this.selectedRoomsListView);
            this.Controls.Add(this.selectedRoomsLabel);
            this.Controls.Add(this.homeButton);
            this.Controls.Add(this.BookingPricingLabel);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "PricingForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PricingForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.backButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.homeButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.adultUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.childrenUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.infantsUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox backButton;
        private System.Windows.Forms.Label BookingPricingLabel;
        private System.Windows.Forms.PictureBox homeButton;
        private System.Windows.Forms.Label selectedRoomsLabel;
        private System.Windows.Forms.ListView selectedRoomsListView;
        private System.Windows.Forms.Label clickToConfigureLabel;
        private System.Windows.Forms.NumericUpDown adultUpDown;
        private System.Windows.Forms.NumericUpDown childrenUpDown;
        private System.Windows.Forms.NumericUpDown infantsUpDown;
        private System.Windows.Forms.Label numberOfAdultsLabel;
        private System.Windows.Forms.Label numberOfChildrenLabel;
        private System.Windows.Forms.Label numberOfInfantsLabel;
        private System.Windows.Forms.Button confirmDepositPricingButton;
        private System.Windows.Forms.Label totalPriceHeadingLabel;
        private System.Windows.Forms.Label depositHeadingLabel;
        private System.Windows.Forms.Label depositLabel;
        private System.Windows.Forms.Label totalPriceLabel;
        private System.Windows.Forms.Label timeFrameLabel;
        private System.Windows.Forms.Label importantInfoLabel;
    }
}