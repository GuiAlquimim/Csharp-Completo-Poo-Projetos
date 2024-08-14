namespace System
{
    internal static class StringExtentions
    {
        public static string Cut(this string thisObj, int max)
        {
            if (thisObj.Length <= max)           
                return thisObj;
            
            return $"{thisObj.Substring(0, max)}...";
        }
    }
}
