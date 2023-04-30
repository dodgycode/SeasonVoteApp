namespace SeasonVoting.Api.Enums
{
    public static class EnumTools
    {
        #region ToViewModel
        public static string ToViewModel(this TrackAvailability availability)
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

        public static string ToViewModel(TrackType trackType)
        {
            string vm;

            switch (trackType)
            {
                case TrackType.Oval:
                    vm = "Oval";
                    break;
                case TrackType.Road:
                    vm = "Road";
                    break;
                case TrackType.DirtOval:
                    vm = "Dirt Oval";
                    break;
                case TrackType.DirtRoad:
                    vm = "Dirt Road";
                    break;
                default:
                    vm = "";
                    break;
            }

            return vm;
        }
        #endregion

        #region FromViewModel
        public static TrackAvailability FromTrackAvailabilityString(string availability)
        {
            TrackAvailability a;

            switch (availability)
            {
                case "Free":
                    a = TrackAvailability.Free;
                    break;
                case "Legacy":
                    a = TrackAvailability.Legacy;
                    break;
                case "Paid":
                    a = TrackAvailability.Paid;
                    break;
                default:
                    a = TrackAvailability.Free;
                    break;
            }

            return a;
        }

        public static TrackType FromTrackTypeString(string trackType)
        {
            TrackType vm;

            switch (trackType)
            {
                case "Oval":
                    vm = TrackType.Oval;
                    break;
                case "Road":
                    vm = TrackType.Road;
                    break;
                case "Dirt Oval":
                    vm = TrackType.DirtOval;
                    break;
                case "Dirt Road":
                    vm = TrackType.DirtRoad;
                    break;
                default:
                    vm = TrackType.Oval;
                    break;
            }

            return vm;
        }
        #endregion
    }
}
