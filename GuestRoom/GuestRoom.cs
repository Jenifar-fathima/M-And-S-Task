class GuestRoom
{
    public static void Main()
    {
        Console.Write("Adult: ");
        _ = int.TryParse(Console.ReadLine(), out int nAdult);
        Console.Write("Children: ");
        _ = int.TryParse(Console.ReadLine(), out int nChildren);

        GuestRoomMethod(nAdult, nChildren);
    }
    public static void GuestRoomMethod(int nAdult, int nChildren)
    {
        int nTotalPeople = nAdult + nChildren;
        int nRoomCount = 0;
        while (nRoomCount < 4 && nTotalPeople <= 16 && nAdult != 0)
        {
            nRoomCount += 1;
            int adultCount = 0;
            int childrenCount = 0;

            for (int nTotalPersonInRoom = 0; nTotalPersonInRoom < 4 && nTotalPersonInRoom < nTotalPeople; nTotalPersonInRoom = adultCount + childrenCount)
            {
                if (adultCount < nAdult)
                {
                    adultCount += 1;
                }
                if (childrenCount < nChildren)
                {
                    childrenCount += 1;
                }
            }
            Console.WriteLine($"room {nRoomCount}:Adult {adultCount} - Children {childrenCount}");
            nAdult -= adultCount;
            nChildren -= childrenCount;
            nTotalPeople = nAdult + nChildren;
        }
    }
}