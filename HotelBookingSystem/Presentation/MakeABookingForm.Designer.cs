namespace HotelBookingSystem.Presentation
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
            this.timeFrameErrorLabel = new System.Windows.Forms.Label();
            this.availableRoomsListView = new System.Windows.Forms.ListView();
            this.selectedRoomsListView = new System.Windows.Forms.ListView();
            this.availableRoomsLabel = new System.Windows.Forms.Label();
            this.selectedRoomsLabel = new System.Windows.Forms.Label();
            this.searchButton = new System.Windows.Forms.Button();
            this.confirmButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.backButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.homeButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.occupantsCounter)).BeginInit();
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
            this.pictureBox2.Location = new System.Drawing.Point(-2, -3);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(656, 876);
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            // 
            // CheckAvailabilityLabel
            // 
            this.CheckAvailabilityLabel.AutoSize = true;
            this.CheckAvailabilityLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(229)))), ((int)(((byte)(229)))));
            this.CheckAvailabilityLabel.Font = new System.Drawing.Font("Roboto Medium", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CheckAvailabilityLabel.Location = new System.Drawing.Point(110, 41);
            this.CheckAvailabilityLabel.Name = "CheckAvailabilityLabel";
            this.CheckAvailabilityLabel.Size = new System.Drawing.Size(338, 49);
            this.CheckAvailabilityLabel.TabIndex = 4;
            this.CheckAvailabilityLabel.Text = "Check Availability";
            // 
            // homeButton
            // 
            this.homeButton.Image = ((System.Drawing.Image)(resources.GetObject("homeButton.Image")));
            this.homeButton.Location = new System.Drawing.Point(1511, 38);
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
            this.timeFrameLabel.Font = new System.Drawing.Font("Roboto Medium", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timeFrameLabel.Location = new System.Drawing.Point(39, 222);
            this.timeFrameLabel.Name = "timeFrameLabel";
            this.timeFrameLabel.Size = new System.Drawing.Size(132, 28);
            this.timeFrameLabel.TabIndex = 6;
            this.timeFrameLabel.Text = "Time Frame";
            // 
            // checkInDateTimePicker
            // 
            this.checkInDateTimePicker.Font = new System.Drawing.Font("Roboto", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkInDateTimePicker.Location = new System.Drawing.Point(44, 263);
            this.checkInDateTimePicker.MaxDate = new System.DateTime(2026, 9, 28, 0, 0, 0, 0);
            this.checkInDateTimePicker.MinDate = new System.DateTime(2024, 9, 28, 0, 0, 0, 0);
            this.checkInDateTimePicker.Name = "checkInDateTimePicker";
            this.checkInDateTimePicker.Size = new System.Drawing.Size(355, 33);
            this.checkInDateTimePicker.TabIndex = 7;
            this.checkInDateTimePicker.Value = new System.DateTime(2024, 9, 28, 0, 0, 0, 0);
            // 
            // checkOutDateTimePicker
            // 
            this.checkOutDateTimePicker.Font = new System.Drawing.Font("Roboto", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkOutDateTimePicker.Location = new System.Drawing.Point(44, 316);
            this.checkOutDateTimePicker.Name = "checkOutDateTimePicker";
            this.checkOutDateTimePicker.Size = new System.Drawing.Size(355, 33);
            this.checkOutDateTimePicker.TabIndex = 8;
            // 
            // occupantsLabel
            // 
            this.occupantsLabel.AutoSize = true;
            this.occupantsLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(229)))), ((int)(((byte)(229)))));
            this.occupantsLabel.Font = new System.Drawing.Font("Roboto Medium", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.occupantsLabel.Location = new System.Drawing.Point(39, 426);
            this.occupantsLabel.Name = "occupantsLabel";
            this.occupantsLabel.Size = new System.Drawing.Size(122, 28);
            this.occupantsLabel.TabIndex = 9;
            this.occupantsLabel.Text = "Occupants";
            // 
            // occupantsCounter
            // 
            this.occupantsCounter.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.occupantsCounter.Font = new System.Drawing.Font("Roboto", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.occupantsCounter.Location = new System.Drawing.Point(44, 457);
            this.occupantsCounter.Name = "occupantsCounter";
            this.occupantsCounter.Size = new System.Drawing.Size(437, 42);
            this.occupantsCounter.TabIndex = 10;
            // 
            // timeFrameErrorLabel
            // 
            this.timeFrameErrorLabel.AutoSize = true;
            this.timeFrameErrorLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(229)))), ((int)(((byte)(229)))));
            this.timeFrameErrorLabel.Font = new System.Drawing.Font("Roboto Medium", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timeFrameErrorLabel.ForeColor = System.Drawing.Color.Red;
            this.timeFrameErrorLabel.Location = new System.Drawing.Point(39, 364);
            this.timeFrameErrorLabel.Name = "timeFrameErrorLabel";
            this.timeFrameErrorLabel.Size = new System.Drawing.Size(137, 28);
            this.timeFrameErrorLabel.TabIndex = 11;
            this.timeFrameErrorLabel.Text = "Invalid Time";
            // 
            // availableRoomsListView
            // 
            this.availableRoomsListView.HideSelection = false;
            this.availableRoomsListView.Location = new System.Drawing.Point(745, 96);
            this.availableRoomsListView.Name = "availableRoomsListView";
            this.availableRoomsListView.Size = new System.Drawing.Size(794, 358);
            this.availableRoomsListView.TabIndex = 13;
            this.availableRoomsListView.UseCompatibleStateImageBehavior = false;
            // 
            // selectedRoomsListView
            // 
            this.selectedRoomsListView.HideSelection = false;
            this.selectedRoomsListView.Location = new System.Drawing.Point(745, 496);
            this.selectedRoomsListView.Name = "selectedRoomsListView";
            this.selectedRoomsListView.Size = new System.Drawing.Size(794, 168);
            this.selectedRoomsListView.TabIndex = 14;
            this.selectedRoomsListView.UseCompatibleStateImageBehavior = false;
            // 
            // availableRoomsLabel
            // 
            this.availableRoomsLabel.AutoSize = true;
            this.availableRoomsLabel.BackColor = System.Drawing.SystemColors.Control;
            this.availableRoomsLabel.Font = new System.Drawing.Font("Roboto Medium", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.availableRoomsLabel.Location = new System.Drawing.Point(740, 62);
            this.availableRoomsLabel.Name = "availableRoomsLabel";
            this.availableRoomsLabel.Size = new System.Drawing.Size(184, 28);
            this.availableRoomsLabel.TabIndex = 15;
            this.availableRoomsLabel.Text = "Available Rooms";
            // 
            // selectedRoomsLabel
            // 
            this.selectedRoomsLabel.AutoSize = true;
            this.selectedRoomsLabel.BackColor = System.Drawing.SystemColors.Control;
            this.selectedRoomsLabel.Font = new System.Drawing.Font("Roboto Medium", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.selectedRoomsLabel.Location = new System.Drawing.Point(740, 465);
            this.selectedRoomsLabel.Name = "selectedRoomsLabel";
            this.selectedRoomsLabel.Size = new System.Drawing.Size(179, 28);
            this.selectedRoomsLabel.TabIndex = 16;
            this.selectedRoomsLabel.Text = "Selected Rooms";
            // 
            // searchButton
            // 
            this.searchButton.BackColor = System.Drawing.Color.Black;
            this.searchButton.Font = new System.Drawing.Font("Roboto Medium", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchButton.ForeColor = System.Drawing.Color.White;
            this.searchButton.Location = new System.Drawing.Point(44, 563);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(437, 79);
            this.searchButton.TabIndex = 17;
            this.searchButton.Text = "Search";
            this.searchButton.UseVisualStyleBackColor = false;
            // 
            // confirmButton
            // 
            this.confirmButton.BackColor = System.Drawing.Color.Black;
            this.confirmButton.Font = new System.Drawing.Font("Roboto Medium", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.confirmButton.ForeColor = System.Drawing.Color.White;
            this.confirmButton.Location = new System.Drawing.Point(1186, 705);
            this.confirmButton.Name = "confirmButton";
            this.confirmButton.Size = new System.Drawing.Size(353, 83);
            this.confirmButton.TabIndex = 18;
            this.confirmButton.Text = "Confirm Room Selection";
            this.confirmButton.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Control;
            this.label1.Font = new System.Drawing.Font("Roboto Medium", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(930, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(210, 28);
            this.label1.TabIndex = 19;
            this.label1.Text = "Max Occupants: 89";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // MakeABookingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1584, 861);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.confirmButton);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.selectedRoomsLabel);
            this.Controls.Add(this.availableRoomsLabel);
            this.Controls.Add(this.selectedRoomsListView);
            this.Controls.Add(this.availableRoomsListView);
            this.Controls.Add(this.timeFrameErrorLabel);
            this.Controls.Add(this.occupantsCounter);
            this.Controls.Add(this.occupantsLabel);
            this.Controls.Add(this.checkOutDateTimePicker);
            this.Controls.Add(this.checkInDateTimePicker);
            this.Controls.Add(this.timeFrameLabel);
            this.Controls.Add(this.homeButton);
            this.Controls.Add(this.CheckAvailabilityLabel);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.pictureBox2);
            this.Name = "MakeABookingForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MakeABookingForm";
            ((System.ComponentModel.ISupportInitialize)(this.backButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.homeButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.occupantsCounter)).EndInit();
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
        private System.Windows.Forms.Label timeFrameErrorLabel;
        private System.Windows.Forms.ListView availableRoomsListView;
        private System.Windows.Forms.ListView selectedRoomsListView;
        private System.Windows.Forms.Label availableRoomsLabel;
        private System.Windows.Forms.Label selectedRoomsLabel;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.Button confirmButton;
        private System.Windows.Forms.Label label1;
    }
}