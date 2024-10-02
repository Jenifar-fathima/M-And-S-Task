namespace BookGuestRoom
{
	public class GuestRoom
	{
		public static string RoomSeperation(int nAdult, int nChildren)
		{
			int nTotalPeople = nAdult + nChildren;
			int nRoomCount = 0;
			string strResult = string.Empty;

			strResult += InputValidator.ValidInputChecker(nAdult, nChildren);

			while(nRoomCount < 4 && nAdult != 0)
			{
				nRoomCount += 1;
				int adultCount = 0;
				int childrenCount = 0;
				int nTotalPersonInRoom = 0;

				if(nAdult > 0)
				{
					adultCount = 1;
					nAdult -= adultCount;
					nTotalPersonInRoom += adultCount;
				}

				while(nTotalPersonInRoom < 4 && nTotalPersonInRoom < nTotalPeople)
				{
					if(nChildren > 0 && nTotalPersonInRoom < 4)
					{
						childrenCount += 1;
						nChildren -= 1;
					}
					else if(nAdult > 0 && nTotalPersonInRoom < 4)
					{
						adultCount += 1;
						nAdult -= 1;
					}
					nTotalPersonInRoom = adultCount + childrenCount;
				}
				strResult += $"room {nRoomCount}:Adult {adultCount} - Children {childrenCount}\n";
				strResult += ErrorMessages.RoomBookingRules(nAdult, nChildren);
				nTotalPeople = nAdult + nChildren;
			}
			return strResult;
		}
	}
}