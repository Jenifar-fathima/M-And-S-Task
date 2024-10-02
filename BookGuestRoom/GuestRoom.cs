namespace BookGuestRoom
{
    public class GuestRoom
    {
        public static string RoomSeperation(int nAdult, int nChildren)
        {

            int nTotalPeople = nAdult + nChildren;
            int nRoomCount = 0;
            string strResult = string.Empty;
            strResult = ValidInputChecker(nAdult, nChildren);

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
                strResult += RoomBookingRules(nAdult, nChildren);

                nTotalPeople = nAdult + nChildren;
            }
            return strResult;
        }

        public static string RoomBookingRules(int adult, int children)
        {
            string strResult = "";

            if (adult == 0 && children > 0)
            {
                strResult += $"No adults available. {children} children have no rooms.";
            }

            if (adult + children > 16)
            {
                strResult += "No entry! Maximum 16 people are allowed";
            }
            return strResult;
        }

        public static string ValidInputChecker(int adult,int children)
        {
            string strResult = string.Empty;
            if (adult == 0)
            {
                if (children == 0)
                {
                    strResult += "Oops! There are no people entered...";
                }
                else if (children > 0)
                {
                    strResult += $"No adults available. {children} children have no rooms.";
                }
            }
            return strResult;
        }
    }
}