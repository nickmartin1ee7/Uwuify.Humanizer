using System;
using System.Text;

namespace Uwuify.Humanizer
{
    internal class UwuLogic
    {
        private readonly string[] _kaomojiConfuse =
        {
            " (o_O)?", " (°ロ°) !?", " (ーー;)?", " owo?"
        };

        private readonly string[] _kaomojiEmbarassed =
        {
            " (⁄ ⁄>⁄ ▽ ⁄<⁄ ⁄)..", " (*^.^*)..,", "..,", ",,,", "... ", ".. ", " mmm..", " O.o"
        };

        private readonly string[] _kaomojiJoy =
        {
            " (* ^ ω ^)", " (o^▽^o)", " (≧◡≦)", " ☆⌒ヽ(*\"､^*)chu", " ( ˘⌣˘)♡(˘⌣˘ )", " xD"
        };

        private readonly string[] _kaomojiSparkles =
        {
            " *:･ﾟ✧*:･ﾟ✧ ", " ☆*:・ﾟ ", "〜☆ ", " uguu.., ", " -.-"
        };

        private readonly Random _rng = new();
        private readonly double _stutterChance;

        public UwuLogic(double stutterChance)
        {
            _stutterChance = stutterChance;
        }

        public string ConvertToUwuFormat(string input)
        {
            if (string.IsNullOrWhiteSpace(input))
                throw new ArgumentNullException(nameof(input));


            string output;
            var outputSb = new StringBuilder();
            var looped = false; // Control flag whether a single pass has no effect on input; double chance
            var lastAttempt = false; // Set to true when stutterChance is 100%
            var stutterChance = _stutterChance;
            var spanInput = new Span<char>(input
                .ToLower()
                .ToCharArray());

            do
            {
                if (looped && stutterChance <= 1)
                {
                    stutterChance *= 2;

                    if (stutterChance > 1) // Clamp to 100%
                    {
                        stutterChance = 1;
                        lastAttempt = true;
                    }
                }

                for (var i = 0; i < spanInput.Length; i++)
                    Iteration_CharacterReplacement(i, spanInput, outputSb, stutterChance);

                output = outputSb.ToString();
                outputSb.Clear();
                looped = true;

                if (stutterChance <= 0) // Nothing more to do!
                {
                    break;
                }

            } while (output == input && !lastAttempt);

            return output;
        }

        private void Iteration_CharacterReplacement(in int i,
            in Span<char> spanInput,
            in StringBuilder outputSb,
            in double stutterChance)
        {
            char? previous = i - 1 < 0 ? null : spanInput[i - 1];
            var current = spanInput[i];
            char? next = i + 1 >= spanInput.Length ? null : spanInput[i + 1];

            var replacement = (previous, current, next) switch
            {
                // Ignores
                (' ' or null, '<', '@' or '#') => current.ToString(), // Discord Mentions

                // Letter swapping
                (_, 'l', 'e') => "w",
                (_, 'l', 'l') => "w",
                (_, 'l', not 'e' and not 'l') => "w",

                ('e', 'r', _) => "w",
                (_, 'r', 'e') => "w",
                (not 'e', 'r', not 'e') => "w",

                (' ' or null, 'n', _) => "ny",
                (' ' or null, 'h', 'i') => "ha", // hai

                // Stuttering
                (' ' or null, not ' ', _) => _rng.NextDouble() < stutterChance ? $"{current}-{current}" : current.ToString(),

                // Kaomoji
                (_, '.', _) => _kaomojiJoy[(int)(_rng.NextDouble() * _kaomojiJoy.Length)],
                (_, '?', _) => _kaomojiConfuse[(int)(_rng.NextDouble() * _kaomojiConfuse.Length)],
                (not '@', '!', _) => _kaomojiSparkles[(int)(_rng.NextDouble() * _kaomojiSparkles.Length)],
                (_, ',', _) => _kaomojiEmbarassed[(int)(_rng.NextDouble() * _kaomojiEmbarassed.Length)],

                // No replacement
                _ => current.ToString()
            };

            outputSb.Append(replacement);
        }
    }
}
