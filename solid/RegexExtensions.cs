using System.Text.RegularExpressions;

namespace solid
{
    public static class RegexExtensions
    {
        public static string FindStrRegex(this string src, string pattern)
        {
            var r = new Regex(pattern);
            return r.Match(src).ToString();
        }
        public static string FindStrRegex(this string src, string pattern, string groupName)
        {
            var r = new Regex(pattern);
            return r.Match(src)?.Groups?.GetValueOrDefault(groupName)?.Value ?? "";
        }
        public static List<string> FindAllStrRegex(this string src, string pattern)
        {
            var r = new Regex(pattern);
            return r.Matches(src).Select(x=>x.ToString()).ToList();
        }
        public static List<string> FindAllStrRegex(this string src, string pattern, string groupName)
        {
            var r = new Regex(pattern);
            return r.Matches(src)
                .Where(x => x.Groups.GetValueOrDefault(groupName) != null)
                .Select(x => x.ToString()).ToList();
        }
    }
}
