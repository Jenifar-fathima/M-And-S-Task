using GuestRoom;
namespace GuestRoom.Test
{
    [TestClass]
    public class UnitTest
    {
        [TestMethod]
        public void TestMethod()
        {
            string strMessage = GuestRoom.RoomSeperation(3, 5);
            Assert.AreEqual("", strMessage);
        }
    }
}