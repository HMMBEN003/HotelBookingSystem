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
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.numberOfAdultsLabel = new System.Windows.Forms.Label();
            this.numberOfChildrenLabel = new System.Windows.Forms.Label();
            this.numberOfInfantsLabel = new System.Windows.Forms.Label();
            this.confirmDepositPricingButton = new System.Windows.Forms.Button();
            this.totalPriceLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.depositPrice = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.backButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.homeButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.adultUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.childrenUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(229)))), ((int)(((byte)(229)))));
            this.pictureBox1.Location = new System.Drawing.Point(12, -2);
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
            // 
            // selectedRoomsLabel
            // 
            this.selectedRoomsLabel.AutoSize = true;
            this.selectedRoomsLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(229)))), ((int)(((byte)(229)))));
            this.selectedRoomsLabel.Font = new System.Drawing.Font("Malgun Gothic", 16.06154F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.selectedRoomsLabel.Location = new System.Drawing.Point(39, 141);
            this.selectedRoomsLabel.Name = "selectedRoomsLabel";
            this.selectedRoomsLabel.Size = new System.Drawing.Size(180, 30);
            this.selectedRoomsLabel.TabIndex = 7;
            this.selectedRoomsLabel.Text = "Selected Rooms";
            // 
            // selectedRoomsListView
            // 
            this.selectedRoomsListView.HideSelection = false;
            this.selectedRoomsListView.Location = new System.Drawing.Point(44, 197);
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
            this.clickToConfigureLabel.Location = new System.Drawing.Point(40, 171);
            this.clickToConfigureLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.clickToConfigureLabel.Name = "clickToConfigureLabel";
            this.clickToConfigureLabel.Size = new System.Drawing.Size(142, 23);
            this.clickToConfigureLabel.TabIndex = 21;
            this.clickToConfigureLabel.Text = "Click to configure";
            // 
            // adultUpDown
            // 
            this.adultUpDown.Font = new System.Drawing.Font("Malgun Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adultUpDown.Location = new System.Drawing.Point(44, 371);
            this.adultUpDown.Name = "adultUpDown";
            this.adultUpDown.Size = new System.Drawing.Size(175, 35);
            this.adultUpDown.TabIndex = 24;
            // 
            // childrenUpDown
            // 
            this.childrenUpDown.Font = new System.Drawing.Font("Malgun Gothic", 15.75F);
            this.childrenUpDown.Location = new System.Drawing.Point(44, 444);
            this.childrenUpDown.Name = "childrenUpDown";
            this.childrenUpDown.Size = new System.Drawing.Size(175, 35);
            this.childrenUpDown.TabIndex = 25;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Font = new System.Drawing.Font("Malgun Gothic", 15.75F);
            this.numericUpDown1.Location = new System.Drawing.Point(44, 517);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(175, 35);
            this.numericUpDown1.TabIndex = 26;
            // 
            // numberOfAdultsLabel
            // 
            this.numberOfAdultsLabel.AutoSize = true;
            this.numberOfAdultsLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(229)))), ((int)(((byte)(229)))));
            this.numberOfAdultsLabel.Font = new System.Drawing.Font("Malgun Gothic Semilight", 12.18462F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numberOfAdultsLabel.Location = new System.Drawing.Point(40, 345);
            this.numberOfAdultsLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.numberOfAdultsLabel.Name = "numberOfAdultsLabel";
            this.numberOfAdultsLabel.Size = new System.Drawing.Size(145, 23);
            this.numberOfAdultsLabel.TabIndex = 27;
            this.numberOfAdultsLabel.Text = "Number of Adults";
            // 
            // numberOfChildrenLabel
            // 
            this.numberOfChildrenLabel.AutoSize = true;
            this.numberOfChildrenLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(229)))), ((int)(((byte)(229)))));
            this.numberOfChildrenLabel.Font = new System.Drawing.Font("Malgun Gothic Semilight", 12.18462F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numberOfChildrenLabel.Location = new System.Drawing.Point(40, 418);
            this.numberOfChildrenLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.numberOfChildrenLabel.Name = "numberOfChildrenLabel";
            this.numberOfChildrenLabel.Size = new System.Drawing.Size(238, 23);
            this.numberOfChildrenLabel.TabIndex = 28;
            this.numberOfChildrenLabel.Text = "Number of Children (5-16 y/o)";
            // 
            // numberOfInfantsLabel
            // 
            this.numberOfInfantsLabel.AutoSize = true;
            this.numberOfInfantsLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(229)))), ((int)(((byte)(229)))));
            this.numberOfInfantsLabel.Font = new System.Drawing.Font("Malgun Gothic Semilight", 12.18462F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numberOfInfantsLabel.Location = new System.Drawing.Point(40, 491);
            this.numberOfInfantsLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.numberOfInfantsLabel.Name = "numberOfInfantsLabel";
            this.numberOfInfantsLabel.Size = new System.Drawing.Size(252, 23);
            this.numberOfInfantsLabel.TabIndex = 29;
            this.numberOfInfantsLabel.Text = "Number of Infants (under 5 y/o)";
            // 
            // confirmDepositPricingButton
            // 
            this.confirmDepositPricingButton.BackColor = System.Drawing.Color.Black;
            this.confirmDepositPricingButton.Font = new System.Drawing.Font("Malgun Gothic", 16.06154F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.confirmDepositPricingButton.ForeColor = System.Drawing.Color.White;
            this.confirmDepositPricingButton.Location = new System.Drawing.Point(807, 692);
            this.confirmDepositPricingButton.Name = "confirmDepositPricingButton";
            this.confirmDepositPricingButton.Size = new System.Drawing.Size(438, 101);
            this.confirmDepositPricingButton.TabIndex = 30;
            this.confirmDepositPricingButton.Text = "Confirm Deposit Pricing";
            this.confirmDepositPricingButton.UseVisualStyleBackColor = false;
            this.confirmDepositPricingButton.Visible = false;
            // 
            // totalPriceLabel
            // 
            this.totalPriceLabel.AutoSize = true;
            this.totalPriceLabel.BackColor = System.Drawing.SystemColors.Control;
            this.totalPriceLabel.Font = new System.Drawing.Font("Malgun Gothic Semilight", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalPriceLabel.Location = new System.Drawing.Point(948, 141);
            this.totalPriceLabel.Name = "totalPriceLabel";
            this.totalPriceLabel.Size = new System.Drawing.Size(110, 30);
            this.totalPriceLabel.TabIndex = 31;
            this.totalPriceLabel.Text = "Total Price";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Control;
            this.label1.Font = new System.Drawing.Font("Malgun Gothic", 16.06154F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(926, 411);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(162, 30);
            this.label1.TabIndex = 32;
            this.label1.Text = "Deposit (10%)";
            // 
            // depositPrice
            // 
            this.depositPrice.AutoSize = true;
            this.depositPrice.BackColor = System.Drawing.SystemColors.Control;
            this.depositPrice.Font = new System.Drawing.Font("Malgun Gothic", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.depositPrice.Location = new System.Drawing.Point(889, 466);
            this.depositPrice.Name = "depositPrice";
            this.depositPrice.Size = new System.Drawing.Size(116, 86);
            this.depositPrice.TabIndex = 33;
            this.depositPrice.Text = "R0";
            this.depositPrice.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.Control;
            this.label2.Font = new System.Drawing.Font("Malgun Gothic Semilight", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(889, 197);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 86);
            this.label2.TabIndex = 34;
            this.label2.Text = "R0";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // PricingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1483, 856);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.depositPrice);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.totalPriceLabel);
            this.Controls.Add(this.confirmDepositPricingButton);
            this.Controls.Add(this.numberOfInfantsLabel);
            this.Controls.Add(this.numberOfChildrenLabel);
            this.Controls.Add(this.numberOfAdultsLabel);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.childrenUpDown);
            this.Controls.Add(this.adultUpDown);
            this.Controls.Add(this.clickToConfigureLabel);
            this.Controls.Add(this.selectedRoomsListView);
            this.Controls.Add(this.selectedRoomsLabel);
            this.Controls.Add(this.homeButton);
            this.Controls.Add(this.BookingPricingLabel);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.pictureBox1);
            this.Location = new System.Drawing.Point(-2, -137);
            this.MaximizeBox = false;
            this.Name = "PricingForm";
            this.Text = "PricingForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.backButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.homeButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.adultUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.childrenUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
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
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label numberOfAdultsLabel;
        private System.Windows.Forms.Label numberOfChildrenLabel;
        private System.Windows.Forms.Label numberOfInfantsLabel;
        private System.Windows.Forms.Button confirmDepositPricingButton;
        private System.Windows.Forms.Label totalPriceLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label depositPrice;
        private System.Windows.Forms.Label label2;
    }
}