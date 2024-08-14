namespace System
{
    internal static class DateTimeExtensions
    {
        public static string ElapsedTime(this DateTime thisObj)
        {
            TimeSpan duration = DateTime.Now.Subtract(thisObj);

            if (duration.TotalHours < 24)
            {
                return $"{Math.Truncate(duration.TotalHours)} hours";
            }
            else
            {
                return $"{Math.Truncate(duration.TotalDays)} days";
            }
            
        }


    }
}
