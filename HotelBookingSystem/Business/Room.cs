using System;
using System.Collections.Generic;

namespace HotelBookingSystem.Business
{
    public class Room
    {
        #region Data Members
        // encapsulation: private data members
        private int roomId;
        private string roomNumber;
        private List<string> roomFeatures;
        private decimal lowSeasonPrice;  // Price for low season
        private decimal midSeasonPrice;  // Price for mid season
        private decimal highSeasonPrice; // Price for high season
        private int adults;
        private int teens;
        private int infants;
        #endregion

        #region Property methods
        // Property for roomId
        public int RoomId
        {
            get { return roomId; }
            set { roomId = value; }
        }

        // Property for roomNumber
        public string RoomNumber
        {
            get { return roomNumber; }
            set { roomNumber = value; }
        }

        // Property for roomFeatures
        public List<string> RoomFeatures
        {
            get { return roomFeatures; }
            set { roomFeatures = value; }
        }

        // Property for low season price
        public decimal LowSeasonPrice
        {
            get { return lowSeasonPrice; }
            set { lowSeasonPrice = value; }
        }

        // Property for mid season price
        public decimal MidSeasonPrice
        {
            get { return midSeasonPrice; }
            set { midSeasonPrice = value; }
        }

        // Property for high season price
        public decimal HighSeasonPrice
        {
            get { return highSeasonPrice; }
            set { highSeasonPrice = value; }
        }

        // Getter and Setter for Adults
        public int Adults
        {
            get { return adults; }
            set { adults = value; }
        }

        // Getter and Setter for Teens
        public int Teens
        {
            get { return teens; }
            set { teens = value; }
        }

        // Getter and Setter for Infants
        public int Infants
        {
            get { return infants; }
            set { infants = value; }
        }
        #endregion

        #region Constructor
        // Constructor to initialize the Room with seasonal prices
        public Room(int id, string number, List<string> features, decimal lowPrice, decimal midPrice, decimal highPrice, int adults, int teens, int infants)
        {
            roomId = id;
            roomNumber = number;
            roomFeatures = features;
            lowSeasonPrice = lowPrice;
            midSeasonPrice = midPrice;
            highSeasonPrice = highPrice;
            this.adults = adults;
            this.teens = teens;
            this.infants = infants;
        }
        #endregion

        #region Methods
        // Example method to display room details
        public void DisplayRoomDetails()
        {
            Console.WriteLine($"Room ID: {roomId}, Room Number: {roomNumber}, Features: {roomFeatures}, " +
                              $"Low Season Price: {lowSeasonPrice:C}, Mid Season Price: {midSeasonPrice:C}, High Season Price: {highSeasonPrice:C}");
        }

        // Method to calculate price based on season
        public decimal GetPriceForSeason(string season)
        {
            switch (season.ToLower())
            {
                case "low":
                    return lowSeasonPrice;
                case "mid":
                    return midSeasonPrice;
                case "high":
                    return highSeasonPrice;
                default:
                    throw new ArgumentException("Invalid season. Please provide 'low', 'mid', or 'high'.");
            }
        }
        #endregion
    }
}
