namespace HotelBookingSystem.Business
{
    public class TestClass
    {
        private int id;
        private string name;

        // Constructor
        public TestClass() { }

        public TestClass(int id, string name)
        {
            this.Id = id;
            this.Name = name;
        }

        // Property for ID
        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        // Property for Name
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
    }
}
