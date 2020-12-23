using System.Linq;

namespace System // prefer namespace for using
{
    public static class StringExtensions // property naming convention
    {
        // convention of first argument needs to follow
        public static string Shorten(this string str, int numberOfWords)
        {
            // sending a nicer exception
            if (numberOfWords < 0)
                throw new ArgumentOutOfRangeException("numberOfWords should be greater than or equal to 0");
            if (numberOfWords == 0)
                return "";

            var words = str.Split(' ');
            var isShortEnough = words.Length < numberOfWords;
            var shortenStr = string.Join(" ", words.Take(numberOfWords).Append("..."));
            return isShortEnough ? str : shortenStr;
        }
    }
}