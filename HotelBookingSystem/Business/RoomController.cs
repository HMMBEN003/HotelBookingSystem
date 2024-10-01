using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using HotelBookingSystem.Data;

namespace HotelBookingSystem.Business
{
    // This class handles room-related business logic, such as CRUD operations and room searches
    public class RoomController
    {
        #region Data Members
        // Object for interacting with the database
        RoomDB roomDB;
        // Collection to store all room objects in memory
        Collection<Room> rooms;
        #endregion

        #region Properties
        // Property to expose all rooms to the outside world
        public Collection<Room> AllRooms
        {
            get
            {
                return rooms;
            }
        }
        #endregion

        #region Constructor
        // Constructor initializes the roomDB object and loads all rooms into memory
        public RoomController()
        {
            roomDB = new RoomDB();  // Communicates with the database
            rooms = roomDB.AllRooms; // Populate rooms from the database
        }
        #endregion

        #region Database Communication
        // This method is responsible for performing CRUD operations (Add, Edit, Delete) on rooms
        public void DataMaintenance(Room aRoom, DB.DBOperation operation)
        {
            // Declare a variable to track the index of a room in the collection
            int index = 0;

            // Call the database communication layer to execute the operation (CRUD)
            roomDB.DataSetChange(aRoom, operation);

            // Switch-case for determining the action to perform after the database operation
            switch (operation)
            {
                case DB.DBOperation.Add:
                    rooms.Add(aRoom); // Add room to collection
                    break;

                case DB.DBOperation.Edit:
                    index = FindIndex(aRoom); // Find the index of the room to be edited

                    if (index >= 0) // Ensure index is valid
                    {
                        rooms[index] = aRoom; // Update the room in the collection
                    }
                    break;

                case DB.DBOperation.Delete:
                    index = FindIndex(aRoom); // Find the index of the room to be deleted

                    if (index >= 0)
                    {
                        rooms.RemoveAt(index); // Remove the room from the collection
                    }
                    break;
            }
        }

        // Commit changes made to the room collection to the database
        public bool FinalizeChanges(Room room)
        {
            return roomDB.UpdateDataSource(room); // Calls RoomDB to commit changes
        }
        #endregion

        #region Search Method
        // This method finds a room by its unique room ID
        public Room Find(int roomId)
        {
            int index = 0; // Start with the first index
            bool found = (rooms[index].RoomId == roomId); // Check if the room is found

            int count = rooms.Count; // Get total number of rooms

            // Loop through all rooms until the room is found or the end of the collection is reached
            while (!found && index < (count - 1))
            {
                index++;
                found = (rooms[index].RoomId == roomId); // Check if the current room matches the roomId
            }

            return found ? rooms[index] : null; // Return the found room or null if not found
        }

        // This method finds the index of a room within the room collection
        public int FindIndex(Room aRoom)
        {
            int counter = 0;
            bool found = (aRoom.RoomId == rooms[counter].RoomId); // Compare room IDs

            int count = rooms.Count;

            // Iterate over the collection to find the room
            while (!found && counter < (count - 1))
            {
                counter++;
                found = (aRoom.RoomId == rooms[counter].RoomId);
            }

            return found ? counter : -1; // Return index if found, otherwise -1
        }
        #endregion

        #region FindByFeature Method
        // This method finds rooms by a specific feature (e.g., "Moutain View", "Garden Access")
        public Collection<Room> FindByFeature(Collection<Room> allRooms, string feature)
        {
            Collection<Room> matches = new Collection<Room>();
            foreach (Room room in allRooms)
            {
                // Check if the room contains the feature and add it to matches
                if (room.RoomFeatures.Contains(feature))
                {
                    matches.Add(room);
                }
            }
            return matches; // Return all rooms that match the feature
        }
        #endregion
    }
}