namespace BookGuestRoom.Test
{
    [TestClass]
    public class UnitTest1
    {

        #region Tests
        [TestMethod]
        public void TestBookRooms_3A_5C()
        {
            string strMessage = BookGuestRoom.GuestRoom.RoomSeperation(3, 5);
            Assert.AreEqual("room 1:Adult 1 - Children 3\nroom 2:Adult 2 - Children 2\n", strMessage);
        }

        [TestMethod]
        public void TestBookRooms_4A_5C()
        {
            string strMessage = BookGuestRoom.GuestRoom.RoomSeperation(4, 5);
            Assert.AreEqual("room 1:Adult 1 - Children 3\nroom 2:Adult 2 - Children 2\nroom 3:Adult 1 - Children 0\n", strMessage);
        }

        [TestMethod]
        public void TestBookRooms_4A_6C()
        {
            string strMessage = BookGuestRoom.GuestRoom.RoomSeperation(4, 6);
            Assert.AreEqual("room 1:Adult 1 - Children 3\nroom 2:Adult 1 - Children 3\nroom 3:Adult 2 - Children 0\n", strMessage);
        }

        [TestMethod]
        public void TestBookRooms_3A_8C()
        {
            string strMessage = BookGuestRoom.GuestRoom.RoomSeperation(3, 8);
            Assert.AreEqual("room 1:Adult 1 - Children 3\nroom 2:Adult 1 - Children 3\nroom 3:Adult 1 - Children 2\n", strMessage);
        }
        [TestMethod]
        public void TestBookRooms_2A_8C()
        {
            string strMessage = BookGuestRoom.GuestRoom.RoomSeperation(2, 8);
            Assert.AreEqual("room 1:Adult 1 - Children 3\nroom 2:Adult 1 - Children 3\nNo adults available. 2 children have no rooms.", strMessage);
        }
        [TestMethod]
        public void TestBookRooms_1A_0C()
        {
            string strMessage = BookGuestRoom.GuestRoom.RoomSeperation(1, 0);
            Assert.AreEqual("room 1:Adult 1 - Children 0\n", strMessage);
        }

        [TestMethod]
        public void TestBookRooms_1A_1C()
        {
            string strMessage = BookGuestRoom.GuestRoom.RoomSeperation(1, 1);
            Assert.AreEqual("room 1:Adult 1 - Children 1\n", strMessage);
        }

        [TestMethod]
        public void TestBookRooms_4A_0C()
        {
            string strMessage = BookGuestRoom.GuestRoom.RoomSeperation(4, 0);
            Assert.AreEqual("room 1:Adult 4 - Children 0\n", strMessage);
        }

        [TestMethod]
        public void TestBookRooms_0A_0C()
        {
            string strMessage = BookGuestRoom.GuestRoom.RoomSeperation(0, 0);
            Assert.AreEqual("Oops! There are no people entered...", strMessage);
        }
        [TestMethod]
        public void TestBookRooms_10A_7C()
        {
            string strMessage = BookGuestRoom.GuestRoom.RoomSeperation(10, 7);
            Assert.AreEqual("room 1:Adult 1 - Children 3\nroom 2:Adult 1 - Children 3\nroom 3:Adult 3 - Children 1\nroom 4:Adult 4 - Children 0\nNo entry! Maximum 16 people are allowed", strMessage);
        }
        [TestMethod]
        public void TestBookRooms_0A_1C()
        {
            string strMessage = BookGuestRoom.GuestRoom.RoomSeperation(0, 1);
            Assert.AreEqual("No adults available. 1 children have no rooms.", strMessage);
        }
        #endregion
    }
}