namespace BookGuestRoom
{
    public class GuestRoom
    {
        public static string RoomSeperation(int nAdult, int nChildren)
        {

            int nTotalPeople = nAdult + nChildren;
            int nRoomCount = 0;
            string strResult = string.Empty;
            strResult = InputValidator(nAdult, nChildren);
            while (nRoomCount < 4 &&  nAdult != 0)
            {
                nRoomCount += 1;
                int adultCount = 0;
                int childrenCount = 0;
                int nTotalPersonInRoom = 0;

                if (nAdult > 0)
                {
                    adultCount = 1;
                    nAdult -= adultCount;
                    nTotalPersonInRoom += adultCount;
                }

                while (nTotalPersonInRoom < 4 && nTotalPersonInRoom < nTotalPeople)
                {
                    if (nChildren > 0 && nTotalPersonInRoom < 4)
                    {
                        childrenCount += 1;
                        nChildren -= 1;
                    }
                    else if (nAdult > 0 && nTotalPersonInRoom < 4)
                    {
                        adultCount += 1;
                        nAdult -= 1;
                    }
                    nTotalPersonInRoom = adultCount + childrenCount;
                }
                strResult += $"room {nRoomCount}:Adult {adultCount} - Children {childrenCount}\n";
                nTotalPeople = nAdult + nChildren;
            }
            return strResult;
        }
        public static string InputValidator(int adult, int children)
        {
            string strResult = "";
            if (adult == 0 && children == 0)
            {
                strResult += "Oops! There are no people entered...";
            }

            else if (adult + children > 16)
            {
                strResult += "No entry! Maximum 16 people are allowed\n";
            }
            return strResult;
        }
    }
}
