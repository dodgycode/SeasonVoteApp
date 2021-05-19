using SeasonVoting.Api.Enums;

namespace SeasonVoting.Api.StaticClasses
{
    public static class EnumTools
    {
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
    }
}
