using System;
using System.Text;

namespace Humanizer.Uwuify
{
    internal class UwuLogic
    {
        private readonly string[] _kaomojiConfuse =
        {
            " (o_O)?", " (°ロ°) !?", " (ーー;)?", " owo?"
        };

        private readonly string[] _kaomojiEmbarassed =
        {
            " (⁄ ⁄>⁄ ▽ ⁄<⁄ ⁄)..", " (*^.^*)..,", "..,", ",,,", "... ", ".. ", " mmm..", "O.o"
        };

        private readonly string[] _kaomojiJoy =
        {
            " (* ^ ω ^)", " (o^▽^o)", " (≧◡≦)", " ☆⌒ヽ(*\"､^*)chu", " ( ˘⌣˘)♡(˘⌣˘ )", " xD"
        };

        private readonly string[] _kaomojiSparkles =
        {
            " *:･ﾟ✧*:･ﾟ✧ ", " ☆*:・ﾟ ", "〜☆ ", " uguu.., ", "-.-"
        };

        private readonly Random _rng = new();
        private readonly double _stutterChance;

        public UwuLogic(double stutterChance)
        {
            _stutterChance = stutterChance;
        }

        public string ConvertToUwuFormat(string input)
        {
            var spanInput = new Span<char>(input
                .ToLower()
                .ToCharArray());

            var outputSb = new StringBuilder();

            for (var i = 0; i < spanInput.Length; i++) Iteration_CharacterReplacement(i, spanInput, outputSb);

            return outputSb.ToString();
        }

        private void Iteration_CharacterReplacement(in int i, in Span<char> spanInput, in StringBuilder outputSb)
        {
            char? previous = i - 1 < 0 ? null : spanInput[i - 1];
            var current = spanInput[i];
            char? next = i + 1 >= spanInput.Length ? spanInput[^1] : spanInput[i + 1];

            var replacement = (previous, current, next) switch
            {
                // Letter swapping
                (_, 'l', 'e') => "w",
                (_, 'l', 'l') => "w",
                (_, 'l', not 'e' and not 'l') => "w",

                ('e', 'r', _) => "w",
                (_, 'r', 'e') => "w",
                (not 'e', 'r', not 'e') => "w",

                (_, 'n', not ' ') => "ny",

                // Stuttering
                (' ', _, _) => _rng.NextDouble() < _stutterChance ? $"{current}-{current}" : current.ToString(),

                // ASCII 
                (_, '.', _) => _kaomojiJoy[(int) (_rng.NextDouble() * _kaomojiJoy.Length)],
                (_, '?', _) => _kaomojiConfuse[(int) (_rng.NextDouble() * _kaomojiConfuse.Length)],
                (_, '!', _) => _kaomojiSparkles[(int) (_rng.NextDouble() * _kaomojiSparkles.Length)],
                (_, ',', _) => _kaomojiEmbarassed[(int) (_rng.NextDouble() * _kaomojiEmbarassed.Length)],

                // No replacement
                _ => current.ToString()
            };

            outputSb.Append(replacement);
        }
    }
}