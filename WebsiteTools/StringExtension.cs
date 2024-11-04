namespace WebsiteTools
{
    public static class StringExtension
    {
        public static string ReplaceController(this string str)
        {
            return str.Replace("Controller", "");
        }
    }
}
