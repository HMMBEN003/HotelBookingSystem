﻿namespace HotelBookingSystem.Presentation
{
    partial class MakeABookingForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MakeABookingForm));
            this.backButton = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.CheckAvailabilityLabel = new System.Windows.Forms.Label();
            this.homeButton = new System.Windows.Forms.PictureBox();
            this.timeFrameLabel = new System.Windows.Forms.Label();
            this.checkInDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.checkOutDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.occupantsLabel = new System.Windows.Forms.Label();
            this.occupantsCounter = new System.Windows.Forms.NumericUpDown();
            this.invalidTimeFrameLabel = new System.Windows.Forms.Label();
            this.availableRoomsListView = new System.Windows.Forms.ListView();
            this.selectedRoomsListView = new System.Windows.Forms.ListView();
            this.availableRoomsLabel = new System.Windows.Forms.Label();
            this.selectedRoomsLabel = new System.Windows.Forms.Label();
            this.searchButton = new System.Windows.Forms.Button();
            this.confirmButton = new System.Windows.Forms.Button();
            this.maxOccupantsLabel = new System.Windows.Forms.Label();
            this.CheckInLabel = new System.Windows.Forms.Label();
            this.CheckOutLabel = new System.Windows.Forms.Label();
            this.clickToUnselectLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.roomBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hotelDBDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.Room = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Rate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Description = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.maxOccupantsCountLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.backButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.homeButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.occupantsCounter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.roomBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hotelDBDataSetBindingSource)).BeginInit();
            this.SuspendLayout();
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
            this.backButton.TabIndex = 2;
            this.backButton.TabStop = false;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(229)))), ((int)(((byte)(229)))));
            this.pictureBox2.Location = new System.Drawing.Point(-2, -137);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(508, 1934);
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            // 
            // CheckAvailabilityLabel
            // 
            this.CheckAvailabilityLabel.AutoSize = true;
            this.CheckAvailabilityLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(229)))), ((int)(((byte)(229)))));
            this.CheckAvailabilityLabel.Font = new System.Drawing.Font("Malgun Gothic", 28.24615F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CheckAvailabilityLabel.Location = new System.Drawing.Point(110, 34);
            this.CheckAvailabilityLabel.Name = "CheckAvailabilityLabel";
            this.CheckAvailabilityLabel.Size = new System.Drawing.Size(341, 51);
            this.CheckAvailabilityLabel.TabIndex = 4;
            this.CheckAvailabilityLabel.Text = "Check Availability";
            // 
            // homeButton
            // 
            this.homeButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.homeButton.Image = ((System.Drawing.Image)(resources.GetObject("homeButton.Image")));
            this.homeButton.Location = new System.Drawing.Point(1392, 33);
            this.homeButton.Name = "homeButton";
            this.homeButton.Size = new System.Drawing.Size(52, 52);
            this.homeButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.homeButton.TabIndex = 5;
            this.homeButton.TabStop = false;
            this.homeButton.Click += new System.EventHandler(this.homeButton_Click);
            // 
            // timeFrameLabel
            // 
            this.timeFrameLabel.AutoSize = true;
            this.timeFrameLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(229)))), ((int)(((byte)(229)))));
            this.timeFrameLabel.Font = new System.Drawing.Font("Malgun Gothic", 16.06154F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timeFrameLabel.Location = new System.Drawing.Point(55, 267);
            this.timeFrameLabel.Name = "timeFrameLabel";
            this.timeFrameLabel.Size = new System.Drawing.Size(137, 30);
            this.timeFrameLabel.TabIndex = 6;
            this.timeFrameLabel.Text = "Time Frame";
            // 
            // checkInDateTimePicker
            // 
            this.checkInDateTimePicker.Font = new System.Drawing.Font("Malgun Gothic", 16.06154F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkInDateTimePicker.Location = new System.Drawing.Point(60, 337);
            this.checkInDateTimePicker.MaxDate = new System.DateTime(2026, 9, 28, 0, 0, 0, 0);
            this.checkInDateTimePicker.MinDate = new System.DateTime(2024, 9, 28, 0, 0, 0, 0);
            this.checkInDateTimePicker.Name = "checkInDateTimePicker";
            this.checkInDateTimePicker.Size = new System.Drawing.Size(355, 36);
            this.checkInDateTimePicker.TabIndex = 7;
            this.checkInDateTimePicker.Value = new System.DateTime(2024, 9, 28, 0, 0, 0, 0);
            // 
            // checkOutDateTimePicker
            // 
            this.checkOutDateTimePicker.Font = new System.Drawing.Font("Malgun Gothic", 16.06154F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkOutDateTimePicker.Location = new System.Drawing.Point(60, 406);
            this.checkOutDateTimePicker.Name = "checkOutDateTimePicker";
            this.checkOutDateTimePicker.Size = new System.Drawing.Size(356, 36);
            this.checkOutDateTimePicker.TabIndex = 8;
            // 
            // occupantsLabel
            // 
            this.occupantsLabel.AutoSize = true;
            this.occupantsLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(229)))), ((int)(((byte)(229)))));
            this.occupantsLabel.Font = new System.Drawing.Font("Malgun Gothic", 16.06154F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.occupantsLabel.Location = new System.Drawing.Point(57, 493);
            this.occupantsLabel.Name = "occupantsLabel";
            this.occupantsLabel.Size = new System.Drawing.Size(122, 30);
            this.occupantsLabel.TabIndex = 9;
            this.occupantsLabel.Text = "Occupants";
            // 
            // occupantsCounter
            // 
            this.occupantsCounter.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.occupantsCounter.Font = new System.Drawing.Font("Malgun Gothic", 23.81538F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.occupantsCounter.Location = new System.Drawing.Point(60, 541);
            this.occupantsCounter.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.occupantsCounter.Name = "occupantsCounter";
            this.occupantsCounter.Size = new System.Drawing.Size(355, 46);
            this.occupantsCounter.TabIndex = 10;
            this.occupantsCounter.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // invalidTimeFrameLabel
            // 
            this.invalidTimeFrameLabel.AutoSize = true;
            this.invalidTimeFrameLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(229)))), ((int)(((byte)(229)))));
            this.invalidTimeFrameLabel.Font = new System.Drawing.Font("Malgun Gothic Semilight", 12.18462F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.invalidTimeFrameLabel.ForeColor = System.Drawing.Color.Red;
            this.invalidTimeFrameLabel.Location = new System.Drawing.Point(56, 453);
            this.invalidTimeFrameLabel.Name = "invalidTimeFrameLabel";
            this.invalidTimeFrameLabel.Size = new System.Drawing.Size(369, 23);
            this.invalidTimeFrameLabel.TabIndex = 11;
            this.invalidTimeFrameLabel.Text = "Invalid Time Frame: Check-Out before Check-In";
            this.invalidTimeFrameLabel.Visible = false;
            // 
            // availableRoomsListView
            // 
            this.availableRoomsListView.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.availableRoomsListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Room,
            this.Rate,
            this.Description});
            this.availableRoomsListView.Font = new System.Drawing.Font("Malgun Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.availableRoomsListView.HideSelection = false;
            this.availableRoomsListView.Location = new System.Drawing.Point(592, 104);
            this.availableRoomsListView.Name = "availableRoomsListView";
            this.availableRoomsListView.Size = new System.Drawing.Size(764, 358);
            this.availableRoomsListView.TabIndex = 13;
            this.availableRoomsListView.UseCompatibleStateImageBehavior = false;
            this.availableRoomsListView.SelectedIndexChanged += new System.EventHandler(this.availableRoomsListView_SelectedIndexChanged);
            // 
            // selectedRoomsListView
            // 
            this.selectedRoomsListView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.selectedRoomsListView.Font = new System.Drawing.Font("Malgun Gothic Semilight", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.selectedRoomsListView.HideSelection = false;
            this.selectedRoomsListView.Location = new System.Drawing.Point(592, 542);
            this.selectedRoomsListView.Name = "selectedRoomsListView";
            this.selectedRoomsListView.Size = new System.Drawing.Size(764, 168);
            this.selectedRoomsListView.TabIndex = 14;
            this.selectedRoomsListView.UseCompatibleStateImageBehavior = false;
            // 
            // availableRoomsLabel
            // 
            this.availableRoomsLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.availableRoomsLabel.AutoSize = true;
            this.availableRoomsLabel.BackColor = System.Drawing.SystemColors.Control;
            this.availableRoomsLabel.Font = new System.Drawing.Font("Malgun Gothic", 16.06154F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.availableRoomsLabel.Location = new System.Drawing.Point(587, 68);
            this.availableRoomsLabel.Name = "availableRoomsLabel";
            this.availableRoomsLabel.Size = new System.Drawing.Size(188, 30);
            this.availableRoomsLabel.TabIndex = 15;
            this.availableRoomsLabel.Text = "Available Rooms";
            // 
            // selectedRoomsLabel
            // 
            this.selectedRoomsLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.selectedRoomsLabel.AutoSize = true;
            this.selectedRoomsLabel.BackColor = System.Drawing.SystemColors.Control;
            this.selectedRoomsLabel.Font = new System.Drawing.Font("Malgun Gothic", 16.06154F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.selectedRoomsLabel.Location = new System.Drawing.Point(587, 478);
            this.selectedRoomsLabel.Name = "selectedRoomsLabel";
            this.selectedRoomsLabel.Size = new System.Drawing.Size(180, 30);
            this.selectedRoomsLabel.TabIndex = 16;
            this.selectedRoomsLabel.Text = "Selected Rooms";
            // 
            // searchButton
            // 
            this.searchButton.BackColor = System.Drawing.Color.Black;
            this.searchButton.Font = new System.Drawing.Font("Malgun Gothic", 16.06154F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchButton.ForeColor = System.Drawing.Color.White;
            this.searchButton.Location = new System.Drawing.Point(60, 625);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(354, 55);
            this.searchButton.TabIndex = 17;
            this.searchButton.Text = "Search";
            this.searchButton.UseVisualStyleBackColor = false;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // confirmButton
            // 
            this.confirmButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.confirmButton.BackColor = System.Drawing.Color.Black;
            this.confirmButton.Font = new System.Drawing.Font("Malgun Gothic", 16.06154F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.confirmButton.ForeColor = System.Drawing.Color.White;
            this.confirmButton.Location = new System.Drawing.Point(1016, 736);
            this.confirmButton.Name = "confirmButton";
            this.confirmButton.Size = new System.Drawing.Size(340, 55);
            this.confirmButton.TabIndex = 18;
            this.confirmButton.Text = "Confirm Room Selection";
            this.confirmButton.UseVisualStyleBackColor = false;
            // 
            // maxOccupantsLabel
            // 
            this.maxOccupantsLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.maxOccupantsLabel.AutoSize = true;
            this.maxOccupantsLabel.BackColor = System.Drawing.SystemColors.Control;
            this.maxOccupantsLabel.Font = new System.Drawing.Font("Malgun Gothic", 16.06154F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maxOccupantsLabel.Location = new System.Drawing.Point(1141, 71);
            this.maxOccupantsLabel.Name = "maxOccupantsLabel";
            this.maxOccupantsLabel.Size = new System.Drawing.Size(181, 30);
            this.maxOccupantsLabel.TabIndex = 19;
            this.maxOccupantsLabel.Text = "Max Occupants:";
            // 
            // CheckInLabel
            // 
            this.CheckInLabel.AutoSize = true;
            this.CheckInLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(229)))), ((int)(((byte)(229)))));
            this.CheckInLabel.Font = new System.Drawing.Font("Malgun Gothic Semilight", 12.18462F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CheckInLabel.Location = new System.Drawing.Point(56, 309);
            this.CheckInLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.CheckInLabel.Name = "CheckInLabel";
            this.CheckInLabel.Size = new System.Drawing.Size(117, 23);
            this.CheckInLabel.TabIndex = 20;
            this.CheckInLabel.Text = "Check-in Date";
            // 
            // CheckOutLabel
            // 
            this.CheckOutLabel.AutoSize = true;
            this.CheckOutLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(229)))), ((int)(((byte)(229)))));
            this.CheckOutLabel.Font = new System.Drawing.Font("Malgun Gothic Semilight", 12.18462F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CheckOutLabel.Location = new System.Drawing.Point(56, 379);
            this.CheckOutLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.CheckOutLabel.Name = "CheckOutLabel";
            this.CheckOutLabel.Size = new System.Drawing.Size(128, 23);
            this.CheckOutLabel.TabIndex = 21;
            this.CheckOutLabel.Text = "Check-out Date";
            // 
            // clickToUnselectLabel
            // 
            this.clickToUnselectLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.clickToUnselectLabel.AutoSize = true;
            this.clickToUnselectLabel.BackColor = System.Drawing.SystemColors.Control;
            this.clickToUnselectLabel.Font = new System.Drawing.Font("Malgun Gothic Semilight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clickToUnselectLabel.Location = new System.Drawing.Point(588, 510);
            this.clickToUnselectLabel.Name = "clickToUnselectLabel";
            this.clickToUnselectLabel.Size = new System.Drawing.Size(126, 21);
            this.clickToUnselectLabel.TabIndex = 22;
            this.clickToUnselectLabel.Text = "Click to Unselect";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.Control;
            this.label2.Font = new System.Drawing.Font("Malgun Gothic Semilight", 12.18462F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(972, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(152, 23);
            this.label2.TabIndex = 23;
            this.label2.Text = "Not Enough Space";
            this.label2.Visible = false;
            // 
            // maxOccupantsCountLabel
            // 
            this.maxOccupantsCountLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.maxOccupantsCountLabel.AutoSize = true;
            this.maxOccupantsCountLabel.BackColor = System.Drawing.SystemColors.Control;
            this.maxOccupantsCountLabel.Font = new System.Drawing.Font("Malgun Gothic", 16.06154F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maxOccupantsCountLabel.Location = new System.Drawing.Point(1317, 71);
            this.maxOccupantsCountLabel.Name = "maxOccupantsCountLabel";
            this.maxOccupantsCountLabel.Size = new System.Drawing.Size(39, 30);
            this.maxOccupantsCountLabel.TabIndex = 24;
            this.maxOccupantsCountLabel.Text = "89";
            this.maxOccupantsCountLabel.Click += new System.EventHandler(this.label3_Click);
            // 
            // MakeABookingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1483, 856);
            this.Controls.Add(this.maxOccupantsCountLabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.clickToUnselectLabel);
            this.Controls.Add(this.CheckOutLabel);
            this.Controls.Add(this.CheckInLabel);
            this.Controls.Add(this.maxOccupantsLabel);
            this.Controls.Add(this.confirmButton);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.selectedRoomsLabel);
            this.Controls.Add(this.availableRoomsLabel);
            this.Controls.Add(this.selectedRoomsListView);
            this.Controls.Add(this.availableRoomsListView);
            this.Controls.Add(this.invalidTimeFrameLabel);
            this.Controls.Add(this.occupantsCounter);
            this.Controls.Add(this.occupantsLabel);
            this.Controls.Add(this.checkOutDateTimePicker);
            this.Controls.Add(this.checkInDateTimePicker);
            this.Controls.Add(this.timeFrameLabel);
            this.Controls.Add(this.homeButton);
            this.Controls.Add(this.CheckAvailabilityLabel);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.pictureBox2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "MakeABookingForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MakeABookingForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.backButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.homeButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.occupantsCounter)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.roomBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hotelDBDataSetBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox backButton;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label CheckAvailabilityLabel;
        private System.Windows.Forms.PictureBox homeButton;
        private System.Windows.Forms.Label timeFrameLabel;
        private System.Windows.Forms.DateTimePicker checkInDateTimePicker;
        private System.Windows.Forms.DateTimePicker checkOutDateTimePicker;
        private System.Windows.Forms.Label occupantsLabel;
        private System.Windows.Forms.NumericUpDown occupantsCounter;
        private System.Windows.Forms.Label invalidTimeFrameLabel;
        private System.Windows.Forms.ListView availableRoomsListView;
        private System.Windows.Forms.ListView selectedRoomsListView;
        private System.Windows.Forms.Label availableRoomsLabel;
        private System.Windows.Forms.Label selectedRoomsLabel;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.Button confirmButton;
        private System.Windows.Forms.Label maxOccupantsLabel;
        private System.Windows.Forms.Label CheckInLabel;
        private System.Windows.Forms.Label CheckOutLabel;
        private System.Windows.Forms.Label clickToUnselectLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.BindingSource hotelDBDataSetBindingSource;
        private System.Windows.Forms.BindingSource roomBindingSource;
        private System.Windows.Forms.ColumnHeader Room;
        private System.Windows.Forms.ColumnHeader Rate;
        private System.Windows.Forms.ColumnHeader Description;
        private System.Windows.Forms.Label maxOccupantsCountLabel;
    }
}