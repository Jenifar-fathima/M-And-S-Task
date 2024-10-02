namespace BookGuestRoom
{
	public class ErrorMessages
	{
		public static string RoomBookingRules(int adult, int children)
		{
			string strResult = string.Empty;
			if(adult == 0 && children > 0)
			{
				strResult += MessageConstants.NoAdultsAvailable + " " +
							 string.Format(MessageConstants.ChildrenWithoutRooms, children);
			}
			return strResult;
		}
	}
}
