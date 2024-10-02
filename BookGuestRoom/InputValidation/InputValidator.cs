namespace BookGuestRoom
{
    public class InputValidator
    {
        public static string ValidInputChecker(int adult, int children)
        {
            string strResult = string.Empty;
            if (adult == 0)
            {
                if (children == 0)
                {
                    strResult = MessageConstants.NoPeopleEntered;
                }
                else if (children > 0)
                {
                    strResult = MessageConstants.NoAdultsAvailable + " " +
                                string.Format(MessageConstants.ChildrenWithoutRooms, children);
                }
            }
            if (adult + children > 16)
            {
                strResult += MessageConstants.MaxPeopleExceeded;
            }
            return strResult;
        }
    }
}