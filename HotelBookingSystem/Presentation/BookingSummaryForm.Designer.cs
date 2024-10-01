namespace HotelBookingSystem.Presentation
{
    partial class BookingSummaryForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BookingSummaryForm));
            this.backButton = new System.Windows.Forms.PictureBox();
            this.homeButton = new System.Windows.Forms.PictureBox();
            this.bookingSummaryLabel = new System.Windows.Forms.Label();
            this.timeFrameHeadingLabel = new System.Windows.Forms.Label();
            this.roomBookingsLabel = new System.Windows.Forms.Label();
            this.totalPriceHeadingLabel = new System.Windows.Forms.Label();
            this.timeFrameLabel = new System.Windows.Forms.Label();
            this.totalPriceLabel = new System.Windows.Forms.Label();
            this.totalDepositPriceLabel = new System.Windows.Forms.Label();
            this.totalDepositPriceHeadingLabel = new System.Windows.Forms.Label();
            this.bookingSummaryListView = new System.Windows.Forms.ListView();
            this.proceedToPaymentButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.backButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.homeButton)).BeginInit();
            this.SuspendLayout();
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
            // bookingSummaryLabel
            // 
            this.bookingSummaryLabel.AutoSize = true;
            this.bookingSummaryLabel.BackColor = System.Drawing.SystemColors.Control;
            this.bookingSummaryLabel.Font = new System.Drawing.Font("Malgun Gothic", 28.24615F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bookingSummaryLabel.Location = new System.Drawing.Point(110, 34);
            this.bookingSummaryLabel.Name = "bookingSummaryLabel";
            this.bookingSummaryLabel.Size = new System.Drawing.Size(356, 51);
            this.bookingSummaryLabel.TabIndex = 10;
            this.bookingSummaryLabel.Text = "Booking Summary";
            // 
            // timeFrameHeadingLabel
            // 
            this.timeFrameHeadingLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.timeFrameHeadingLabel.AutoSize = true;
            this.timeFrameHeadingLabel.BackColor = System.Drawing.SystemColors.Control;
            this.timeFrameHeadingLabel.Font = new System.Drawing.Font("Malgun Gothic", 16.06154F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timeFrameHeadingLabel.Location = new System.Drawing.Point(39, 151);
            this.timeFrameHeadingLabel.Name = "timeFrameHeadingLabel";
            this.timeFrameHeadingLabel.Size = new System.Drawing.Size(137, 30);
            this.timeFrameHeadingLabel.TabIndex = 17;
            this.timeFrameHeadingLabel.Text = "Time Frame";
            // 
            // roomBookingsLabel
            // 
            this.roomBookingsLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.roomBookingsLabel.AutoSize = true;
            this.roomBookingsLabel.BackColor = System.Drawing.SystemColors.Control;
            this.roomBookingsLabel.Font = new System.Drawing.Font("Malgun Gothic", 16.06154F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roomBookingsLabel.Location = new System.Drawing.Point(39, 273);
            this.roomBookingsLabel.Name = "roomBookingsLabel";
            this.roomBookingsLabel.Size = new System.Drawing.Size(180, 30);
            this.roomBookingsLabel.TabIndex = 18;
            this.roomBookingsLabel.Text = "Room Bookings";
            // 
            // totalPriceHeadingLabel
            // 
            this.totalPriceHeadingLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.totalPriceHeadingLabel.AutoSize = true;
            this.totalPriceHeadingLabel.BackColor = System.Drawing.SystemColors.Control;
            this.totalPriceHeadingLabel.Font = new System.Drawing.Font("Malgun Gothic", 16.06154F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalPriceHeadingLabel.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.totalPriceHeadingLabel.Location = new System.Drawing.Point(39, 701);
            this.totalPriceHeadingLabel.Name = "totalPriceHeadingLabel";
            this.totalPriceHeadingLabel.Size = new System.Drawing.Size(126, 30);
            this.totalPriceHeadingLabel.TabIndex = 19;
            this.totalPriceHeadingLabel.Text = "Total Price";
            // 
            // timeFrameLabel
            // 
            this.timeFrameLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.timeFrameLabel.AutoSize = true;
            this.timeFrameLabel.BackColor = System.Drawing.SystemColors.Control;
            this.timeFrameLabel.Font = new System.Drawing.Font("Malgun Gothic Semilight", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timeFrameLabel.Location = new System.Drawing.Point(39, 192);
            this.timeFrameLabel.Name = "timeFrameLabel";
            this.timeFrameLabel.Size = new System.Drawing.Size(22, 30);
            this.timeFrameLabel.TabIndex = 20;
            this.timeFrameLabel.Text = "-";
            // 
            // totalPriceLabel
            // 
            this.totalPriceLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.totalPriceLabel.AutoSize = true;
            this.totalPriceLabel.BackColor = System.Drawing.SystemColors.Control;
            this.totalPriceLabel.Font = new System.Drawing.Font("Malgun Gothic Semilight", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalPriceLabel.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.totalPriceLabel.Location = new System.Drawing.Point(36, 740);
            this.totalPriceLabel.Name = "totalPriceLabel";
            this.totalPriceLabel.Size = new System.Drawing.Size(33, 45);
            this.totalPriceLabel.TabIndex = 21;
            this.totalPriceLabel.Text = "-";
            // 
            // totalDepositPriceLabel
            // 
            this.totalDepositPriceLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.totalDepositPriceLabel.AutoSize = true;
            this.totalDepositPriceLabel.BackColor = System.Drawing.SystemColors.Control;
            this.totalDepositPriceLabel.Font = new System.Drawing.Font("Malgun Gothic Semilight", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalDepositPriceLabel.Location = new System.Drawing.Point(442, 740);
            this.totalDepositPriceLabel.Name = "totalDepositPriceLabel";
            this.totalDepositPriceLabel.Size = new System.Drawing.Size(33, 45);
            this.totalDepositPriceLabel.TabIndex = 23;
            this.totalDepositPriceLabel.Text = "-";
            // 
            // totalDepositPriceHeadingLabel
            // 
            this.totalDepositPriceHeadingLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.totalDepositPriceHeadingLabel.AutoSize = true;
            this.totalDepositPriceHeadingLabel.BackColor = System.Drawing.SystemColors.Control;
            this.totalDepositPriceHeadingLabel.Font = new System.Drawing.Font("Malgun Gothic", 16.06154F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalDepositPriceHeadingLabel.Location = new System.Drawing.Point(445, 701);
            this.totalDepositPriceHeadingLabel.Name = "totalDepositPriceHeadingLabel";
            this.totalDepositPriceHeadingLabel.Size = new System.Drawing.Size(214, 30);
            this.totalDepositPriceHeadingLabel.TabIndex = 22;
            this.totalDepositPriceHeadingLabel.Text = "Total Deposit Price";
            // 
            // bookingSummaryListView
            // 
            this.bookingSummaryListView.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bookingSummaryListView.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bookingSummaryListView.HideSelection = false;
            this.bookingSummaryListView.Location = new System.Drawing.Point(44, 326);
            this.bookingSummaryListView.Name = "bookingSummaryListView";
            this.bookingSummaryListView.Size = new System.Drawing.Size(1383, 335);
            this.bookingSummaryListView.TabIndex = 24;
            this.bookingSummaryListView.UseCompatibleStateImageBehavior = false;
            // 
            // proceedToPaymentButton
            // 
            this.proceedToPaymentButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.proceedToPaymentButton.BackColor = System.Drawing.Color.Black;
            this.proceedToPaymentButton.Font = new System.Drawing.Font("Malgun Gothic", 16.06154F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.proceedToPaymentButton.ForeColor = System.Drawing.Color.White;
            this.proceedToPaymentButton.Location = new System.Drawing.Point(1087, 730);
            this.proceedToPaymentButton.Name = "proceedToPaymentButton";
            this.proceedToPaymentButton.Size = new System.Drawing.Size(340, 55);
            this.proceedToPaymentButton.TabIndex = 25;
            this.proceedToPaymentButton.Text = "Proceed to Payment";
            this.proceedToPaymentButton.UseVisualStyleBackColor = false;
            this.proceedToPaymentButton.Click += new System.EventHandler(this.proceedToPaymentButton_Click);
            // 
            // BookingSummaryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1483, 856);
            this.Controls.Add(this.proceedToPaymentButton);
            this.Controls.Add(this.bookingSummaryListView);
            this.Controls.Add(this.totalDepositPriceLabel);
            this.Controls.Add(this.totalDepositPriceHeadingLabel);
            this.Controls.Add(this.totalPriceLabel);
            this.Controls.Add(this.timeFrameLabel);
            this.Controls.Add(this.totalPriceHeadingLabel);
            this.Controls.Add(this.roomBookingsLabel);
            this.Controls.Add(this.timeFrameHeadingLabel);
            this.Controls.Add(this.bookingSummaryLabel);
            this.Controls.Add(this.homeButton);
            this.Controls.Add(this.backButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "BookingSummaryForm";
            this.Text = "BookingSummaryForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.backButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.homeButton)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox backButton;
        private System.Windows.Forms.PictureBox homeButton;
        private System.Windows.Forms.Label bookingSummaryLabel;
        private System.Windows.Forms.Label timeFrameHeadingLabel;
        private System.Windows.Forms.Label roomBookingsLabel;
        private System.Windows.Forms.Label totalPriceHeadingLabel;
        private System.Windows.Forms.Label timeFrameLabel;
        private System.Windows.Forms.Label totalPriceLabel;
        private System.Windows.Forms.Label totalDepositPriceLabel;
        private System.Windows.Forms.Label totalDepositPriceHeadingLabel;
        private System.Windows.Forms.ListView bookingSummaryListView;
        private System.Windows.Forms.Button proceedToPaymentButton;
    }
}