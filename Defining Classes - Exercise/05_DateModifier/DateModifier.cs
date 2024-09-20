
using System.Globalization;

namespace DateModifier
{
    public static class DateModifier
    {

        public static int GetDifference(string start, string end) 
        {
            DateTime startDate = DateTime.Parse(start);
            DateTime endDate = DateTime.Parse(end);

            TimeSpan difference = startDate - endDate;

            int differenceIndays = difference.Days;

            return Math.Abs(differenceIndays);
        }
    }
}
