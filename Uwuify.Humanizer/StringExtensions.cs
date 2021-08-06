namespace Uwuify.Humanizer
{
    public static class StringExtensions
    {
        private static readonly UwuLogic _UwuLogic = new(0.3);

        public static string Uwuify(this string input)
        {
            return _UwuLogic.ConvertToUwuFormat(input);
        }
    }
}