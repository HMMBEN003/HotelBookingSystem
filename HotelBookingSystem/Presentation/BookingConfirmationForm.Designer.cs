namespace HotelBookingSystem.Presentation
{
    partial class BookingConfirmationForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BookingConfirmationForm));
            this.bookingSummaryListView = new System.Windows.Forms.ListView();
            this.timeFrameLabel = new System.Windows.Forms.Label();
            this.roomBookingsLabel = new System.Windows.Forms.Label();
            this.timeFrameHeadingLabel = new System.Windows.Forms.Label();
            this.bookingSummaryLabel = new System.Windows.Forms.Label();
            this.homeButton = new System.Windows.Forms.PictureBox();
            this.referenceNumberLabel = new System.Windows.Forms.Label();
            this.referenceNumberHeadingLabel = new System.Windows.Forms.Label();
            this.nameLabel = new System.Windows.Forms.Label();
            this.nameHeadingLabel = new System.Windows.Forms.Label();
            this.emailLabel = new System.Windows.Forms.Label();
            this.emailHeadingLabel = new System.Windows.Forms.Label();
            this.statusLabel = new System.Windows.Forms.Label();
            this.statusHeadingLabel = new System.Windows.Forms.Label();
            this.totalPriceLabel = new System.Windows.Forms.Label();
            this.totalPriceHeadingLabel = new System.Windows.Forms.Label();
            this.returnToHomePageButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.homeButton)).BeginInit();
            this.SuspendLayout();
            // 
            // bookingSummaryListView
            // 
            this.bookingSummaryListView.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bookingSummaryListView.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bookingSummaryListView.HideSelection = false;
            this.bookingSummaryListView.Location = new System.Drawing.Point(34, 405);
            this.bookingSummaryListView.Name = "bookingSummaryListView";
            this.bookingSummaryListView.Size = new System.Drawing.Size(1383, 335);
            this.bookingSummaryListView.TabIndex = 31;
            this.bookingSummaryListView.UseCompatibleStateImageBehavior = false;
            // 
            // timeFrameLabel
            // 
            this.timeFrameLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.timeFrameLabel.AutoSize = true;
            this.timeFrameLabel.BackColor = System.Drawing.SystemColors.Control;
            this.timeFrameLabel.Font = new System.Drawing.Font("Malgun Gothic Semilight", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timeFrameLabel.Location = new System.Drawing.Point(29, 271);
            this.timeFrameLabel.Name = "timeFrameLabel";
            this.timeFrameLabel.Size = new System.Drawing.Size(22, 30);
            this.timeFrameLabel.TabIndex = 30;
            this.timeFrameLabel.Text = "-";
            // 
            // roomBookingsLabel
            // 
            this.roomBookingsLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.roomBookingsLabel.AutoSize = true;
            this.roomBookingsLabel.BackColor = System.Drawing.SystemColors.Control;
            this.roomBookingsLabel.Font = new System.Drawing.Font("Malgun Gothic", 16.06154F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roomBookingsLabel.Location = new System.Drawing.Point(29, 352);
            this.roomBookingsLabel.Name = "roomBookingsLabel";
            this.roomBookingsLabel.Size = new System.Drawing.Size(180, 30);
            this.roomBookingsLabel.TabIndex = 29;
            this.roomBookingsLabel.Text = "Room Bookings";
            // 
            // timeFrameHeadingLabel
            // 
            this.timeFrameHeadingLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.timeFrameHeadingLabel.AutoSize = true;
            this.timeFrameHeadingLabel.BackColor = System.Drawing.SystemColors.Control;
            this.timeFrameHeadingLabel.Font = new System.Drawing.Font("Malgun Gothic", 16.06154F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timeFrameHeadingLabel.Location = new System.Drawing.Point(29, 230);
            this.timeFrameHeadingLabel.Name = "timeFrameHeadingLabel";
            this.timeFrameHeadingLabel.Size = new System.Drawing.Size(137, 30);
            this.timeFrameHeadingLabel.TabIndex = 28;
            this.timeFrameHeadingLabel.Text = "Time Frame";
            // 
            // bookingSummaryLabel
            // 
            this.bookingSummaryLabel.AutoSize = true;
            this.bookingSummaryLabel.BackColor = System.Drawing.SystemColors.Control;
            this.bookingSummaryLabel.Font = new System.Drawing.Font("Malgun Gothic", 28.24615F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bookingSummaryLabel.Location = new System.Drawing.Point(25, 40);
            this.bookingSummaryLabel.Name = "bookingSummaryLabel";
            this.bookingSummaryLabel.Size = new System.Drawing.Size(423, 51);
            this.bookingSummaryLabel.TabIndex = 27;
            this.bookingSummaryLabel.Text = "Booking Confirmation";
            // 
            // homeButton
            // 
            this.homeButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.homeButton.Image = ((System.Drawing.Image)(resources.GetObject("homeButton.Image")));
            this.homeButton.Location = new System.Drawing.Point(1382, 40);
            this.homeButton.Name = "homeButton";
            this.homeButton.Size = new System.Drawing.Size(52, 52);
            this.homeButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.homeButton.TabIndex = 26;
            this.homeButton.TabStop = false;
            this.homeButton.Click += new System.EventHandler(this.homeButton_Click);
            // 
            // referenceNumberLabel
            // 
            this.referenceNumberLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.referenceNumberLabel.AutoSize = true;
            this.referenceNumberLabel.BackColor = System.Drawing.SystemColors.Control;
            this.referenceNumberLabel.Font = new System.Drawing.Font("Malgun Gothic Semilight", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.referenceNumberLabel.Location = new System.Drawing.Point(29, 164);
            this.referenceNumberLabel.Name = "referenceNumberLabel";
            this.referenceNumberLabel.Size = new System.Drawing.Size(22, 30);
            this.referenceNumberLabel.TabIndex = 33;
            this.referenceNumberLabel.Text = "-";
            // 
            // referenceNumberHeadingLabel
            // 
            this.referenceNumberHeadingLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.referenceNumberHeadingLabel.AutoSize = true;
            this.referenceNumberHeadingLabel.BackColor = System.Drawing.SystemColors.Control;
            this.referenceNumberHeadingLabel.Font = new System.Drawing.Font("Malgun Gothic", 16.06154F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.referenceNumberHeadingLabel.Location = new System.Drawing.Point(29, 123);
            this.referenceNumberHeadingLabel.Name = "referenceNumberHeadingLabel";
            this.referenceNumberHeadingLabel.Size = new System.Drawing.Size(210, 30);
            this.referenceNumberHeadingLabel.TabIndex = 32;
            this.referenceNumberHeadingLabel.Text = "Reference Number";
            // 
            // nameLabel
            // 
            this.nameLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.nameLabel.AutoSize = true;
            this.nameLabel.BackColor = System.Drawing.SystemColors.Control;
            this.nameLabel.Font = new System.Drawing.Font("Malgun Gothic Semilight", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameLabel.Location = new System.Drawing.Point(489, 164);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(22, 30);
            this.nameLabel.TabIndex = 35;
            this.nameLabel.Text = "-";
            // 
            // nameHeadingLabel
            // 
            this.nameHeadingLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.nameHeadingLabel.AutoSize = true;
            this.nameHeadingLabel.BackColor = System.Drawing.SystemColors.Control;
            this.nameHeadingLabel.Font = new System.Drawing.Font("Malgun Gothic", 16.06154F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameHeadingLabel.Location = new System.Drawing.Point(489, 123);
            this.nameHeadingLabel.Name = "nameHeadingLabel";
            this.nameHeadingLabel.Size = new System.Drawing.Size(75, 30);
            this.nameHeadingLabel.TabIndex = 34;
            this.nameHeadingLabel.Text = "Name";
            // 
            // emailLabel
            // 
            this.emailLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.emailLabel.AutoSize = true;
            this.emailLabel.BackColor = System.Drawing.SystemColors.Control;
            this.emailLabel.Font = new System.Drawing.Font("Malgun Gothic Semilight", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emailLabel.Location = new System.Drawing.Point(489, 271);
            this.emailLabel.Name = "emailLabel";
            this.emailLabel.Size = new System.Drawing.Size(22, 30);
            this.emailLabel.TabIndex = 37;
            this.emailLabel.Text = "-";
            // 
            // emailHeadingLabel
            // 
            this.emailHeadingLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.emailHeadingLabel.AutoSize = true;
            this.emailHeadingLabel.BackColor = System.Drawing.SystemColors.Control;
            this.emailHeadingLabel.Font = new System.Drawing.Font("Malgun Gothic", 16.06154F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emailHeadingLabel.Location = new System.Drawing.Point(489, 230);
            this.emailHeadingLabel.Name = "emailHeadingLabel";
            this.emailHeadingLabel.Size = new System.Drawing.Size(161, 30);
            this.emailHeadingLabel.TabIndex = 36;
            this.emailHeadingLabel.Text = "Email Address";
            // 
            // statusLabel
            // 
            this.statusLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.statusLabel.AutoSize = true;
            this.statusLabel.BackColor = System.Drawing.SystemColors.Control;
            this.statusLabel.Font = new System.Drawing.Font("Malgun Gothic Semilight", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statusLabel.Location = new System.Drawing.Point(976, 164);
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(130, 30);
            this.statusLabel.TabIndex = 39;
            this.statusLabel.Text = "Deposit Paid";
            // 
            // statusHeadingLabel
            // 
            this.statusHeadingLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.statusHeadingLabel.AutoSize = true;
            this.statusHeadingLabel.BackColor = System.Drawing.SystemColors.Control;
            this.statusHeadingLabel.Font = new System.Drawing.Font("Malgun Gothic", 16.06154F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statusHeadingLabel.Location = new System.Drawing.Point(976, 123);
            this.statusHeadingLabel.Name = "statusHeadingLabel";
            this.statusHeadingLabel.Size = new System.Drawing.Size(76, 30);
            this.statusHeadingLabel.TabIndex = 38;
            this.statusHeadingLabel.Text = "Status";
            // 
            // totalPriceLabel
            // 
            this.totalPriceLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.totalPriceLabel.AutoSize = true;
            this.totalPriceLabel.BackColor = System.Drawing.SystemColors.Control;
            this.totalPriceLabel.Font = new System.Drawing.Font("Malgun Gothic Semilight", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalPriceLabel.Location = new System.Drawing.Point(976, 271);
            this.totalPriceLabel.Name = "totalPriceLabel";
            this.totalPriceLabel.Size = new System.Drawing.Size(22, 30);
            this.totalPriceLabel.TabIndex = 41;
            this.totalPriceLabel.Text = "-";
            // 
            // totalPriceHeadingLabel
            // 
            this.totalPriceHeadingLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.totalPriceHeadingLabel.AutoSize = true;
            this.totalPriceHeadingLabel.BackColor = System.Drawing.SystemColors.Control;
            this.totalPriceHeadingLabel.Font = new System.Drawing.Font("Malgun Gothic", 16.06154F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalPriceHeadingLabel.Location = new System.Drawing.Point(976, 230);
            this.totalPriceHeadingLabel.Name = "totalPriceHeadingLabel";
            this.totalPriceHeadingLabel.Size = new System.Drawing.Size(126, 30);
            this.totalPriceHeadingLabel.TabIndex = 40;
            this.totalPriceHeadingLabel.Text = "Total Price";
            // 
            // returnToHomePageButton
            // 
            this.returnToHomePageButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.returnToHomePageButton.BackColor = System.Drawing.Color.Black;
            this.returnToHomePageButton.Font = new System.Drawing.Font("Malgun Gothic", 16.06154F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.returnToHomePageButton.ForeColor = System.Drawing.Color.White;
            this.returnToHomePageButton.Location = new System.Drawing.Point(1077, 775);
            this.returnToHomePageButton.Name = "returnToHomePageButton";
            this.returnToHomePageButton.Size = new System.Drawing.Size(340, 55);
            this.returnToHomePageButton.TabIndex = 42;
            this.returnToHomePageButton.Text = "Return to Home Page";
            this.returnToHomePageButton.UseVisualStyleBackColor = false;
            this.returnToHomePageButton.Click += new System.EventHandler(this.returnToHomePageButton_Click);
            // 
            // BookingConfirmationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1483, 856);
            this.Controls.Add(this.returnToHomePageButton);
            this.Controls.Add(this.totalPriceLabel);
            this.Controls.Add(this.totalPriceHeadingLabel);
            this.Controls.Add(this.statusLabel);
            this.Controls.Add(this.statusHeadingLabel);
            this.Controls.Add(this.emailLabel);
            this.Controls.Add(this.emailHeadingLabel);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.nameHeadingLabel);
            this.Controls.Add(this.referenceNumberLabel);
            this.Controls.Add(this.referenceNumberHeadingLabel);
            this.Controls.Add(this.bookingSummaryListView);
            this.Controls.Add(this.timeFrameLabel);
            this.Controls.Add(this.roomBookingsLabel);
            this.Controls.Add(this.timeFrameHeadingLabel);
            this.Controls.Add(this.bookingSummaryLabel);
            this.Controls.Add(this.homeButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "BookingConfirmationForm";
            this.Text = "BookingConfirmationForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.homeButton)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView bookingSummaryListView;
        private System.Windows.Forms.Label timeFrameLabel;
        private System.Windows.Forms.Label roomBookingsLabel;
        private System.Windows.Forms.Label timeFrameHeadingLabel;
        private System.Windows.Forms.Label bookingSummaryLabel;
        private System.Windows.Forms.PictureBox homeButton;
        private System.Windows.Forms.Label referenceNumberLabel;
        private System.Windows.Forms.Label referenceNumberHeadingLabel;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label nameHeadingLabel;
        private System.Windows.Forms.Label emailLabel;
        private System.Windows.Forms.Label emailHeadingLabel;
        private System.Windows.Forms.Label statusLabel;
        private System.Windows.Forms.Label statusHeadingLabel;
        private System.Windows.Forms.Label totalPriceLabel;
        private System.Windows.Forms.Label totalPriceHeadingLabel;
        private System.Windows.Forms.Button returnToHomePageButton;
    }
}