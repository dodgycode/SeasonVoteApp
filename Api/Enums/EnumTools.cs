namespace SeasonVoting.Api.Enums
{
    public static class EnumTools
    {
        #region ToViewModel
        public static string ToViewModel(TrackAvailability availability)
        {
            string vm;

            switch (availability)
            {
                case TrackAvailability.Free:
                    vm = "Free";
                    break;
                case TrackAvailability.Legacy:
                    vm = "Legacy";
                    break;
                case TrackAvailability.Paid:
                    vm = "Paid";
                    break;
                default:
                    vm = "";
                    break;
            }

            return vm;
        } 
        #endregion
    }
}
