using System.Collections.ObjectModel;
using HotelBookingSystem.Data;

namespace HotelBookingSystem.Business
{
    public class TestController
    {
        public TestDB testDB;
        public Collection<TestClass> tests; // Collection to store tests in memory

        // Constructor to initialize TestDB and fetch the data
        public TestController()
        {
            testDB = new TestDB();
            tests = testDB.GetAllTests();  // Get all tests from the database
        }

        // Method to add a new test record
        public void AddTestRecord(TestClass testClass)
        {
            testDB.AddTest(testClass);
        }

        // Method to update an existing test record
        public void UpdateTestRecord(TestClass testClass)
        {
            testDB.UpdateDataSource(testClass);
        }

        public int GetHighestIdFromDB()
        {
            return testDB.GetHighestId();  // This will call the method in TestDB to get the highest ID from the table
        }

    }
}
