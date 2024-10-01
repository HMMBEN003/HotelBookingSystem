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
        private int totalPrice; // Total price of room over time frame
        private Occupants occupants;
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

        // Getter and Setter for TotalPrice
        public int TotalPrice
        {
            get { return totalPrice; }
            set { totalPrice = value; }
        }

        // Property for Occupants
        public Occupants Occupants
        {
            get { return occupants; }
            set { occupants = value; }
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
            occupants = PopulateOccupants(adults, teens, infants); // Call the method to populate occupants
        }
        #endregion

        #region Methods
        // Method to populate occupants
        private Occupants PopulateOccupants(int adults, int teens, int infants)
        {
            Occupants occupants = new Occupants();

            // Set Adults
            if (adults >= 1)
            {
                occupants.Occupant1 = OccupantTye.Adult;
                if (adults == 2)
                {
                    occupants.Occupant2 = OccupantTye.Adult;
                }
            }

            // Set Children
            int occupantIndex = adults; // Keep track of next occupant slot (adults take initial slots)
            if (teens > 0)
            {
                if (occupantIndex == 1)
                    occupants.Occupant2 = OccupantTye.Child;
                else if (occupantIndex == 2)
                    occupants.Occupant3 = OccupantTye.Child;
                else if (occupantIndex == 3)
                    occupants.Occupant4 = OccupantTye.Child;
                occupantIndex++;
            }

            if (teens > 1)
            {
                if (occupantIndex == 2)
                    occupants.Occupant3 = OccupantTye.Child;
                else if (occupantIndex == 3)
                    occupants.Occupant4 = OccupantTye.Child;
                occupantIndex++;
            }

            // Set Infants
            if (infants > 0)
            {
                if (occupantIndex == 1)
                    occupants.Occupant2 = OccupantTye.Infant;
                else if (occupantIndex == 2)
                    occupants.Occupant3 = OccupantTye.Infant;
                else if (occupantIndex == 3)
                    occupants.Occupant4 = OccupantTye.Infant;
                occupantIndex++;
            }

            if (infants > 1)
            {
                if (occupantIndex == 2)
                    occupants.Occupant3 = OccupantTye.Infant;
                else if (occupantIndex == 3)
                    occupants.Occupant4 = OccupantTye.Infant;
            }

            return occupants;
        }
 
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
