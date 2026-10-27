namespace ExtensionMethodExample.Extensions
{
    public static class StringExtensions
    {
        public static bool ContainsSpecificString(this string s, string whatToLookFor)
        {
            return s.Contains(whatToLookFor);
        }
    }
}
