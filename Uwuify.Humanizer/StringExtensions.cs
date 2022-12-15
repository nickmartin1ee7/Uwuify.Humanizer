namespace Uwuify.Humanizer
{
    public static class StringExtensions
    {
        private static readonly UwuLogic _uwuLogic = new(0.3);

        /// <summary>
        /// Formats <paramref name="input"/> into the UwU meme format.
        /// </summary>
        /// <param name="input">Given input string.</param>
        /// <returns>A new formatted version of the original string.</returns>
        public static string Uwuify(this string input) =>
            _uwuLogic.ConvertToUwuFormat(input);

        /// <summary>
        /// Formats <paramref name="input"/> into the UwU meme format.
        /// This overload is slightly slower than the <see cref="Uwuify(string)" /> method.
        /// </summary>
        /// <param name="input">Given input string.</param>
        /// <param name="stutterChance">Define a c-custom s-stutter c-chance.</param>
        /// <returns>A new formatted version of the original string.</returns>
        public static string Uwuify(this string input, double stutterChance) =>
            new UwuLogic(stutterChance).ConvertToUwuFormat(input);
    }
}