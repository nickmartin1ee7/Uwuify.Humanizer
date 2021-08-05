using System;
using System.Text;

namespace Humanizer.Uwuify
{
    internal class BadUwuLogic
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


        public string ConvertToUwuFormat(string input)
        {
            var sb = new StringBuilder();
            var splitInput = input.ToLower().Split(' ');

            foreach (var word in splitInput) sb.Append(ConvertWordToUwu(word));

            return sb.ToString();
        }

        private string ConvertWordToUwu(string word)
        {
            var sb = new StringBuilder();
            var end = string.Empty;
            var lastChar = word[^1];

            if (lastChar is '.' or '?' or '!' or ',')
            {
                word = word[..^1];
                end = lastChar.ToString();
            }

            end = AddEmoji(end);

            MutateLettersToW(word, sb, end);

            MutateWithStutter(word, sb);

            return sb.ToString();
        }

        private void MutateWithStutter(string word, StringBuilder sb)
        {
            if (word.Length > 2 && char.IsLetter(word[0]) && char.IsLetter(word[1]))
            {
                var random = Math.Floor(_rng.NextDouble() * 6);
                if (random == 0) sb.Append(word[0] + '-' + word);
            }
        }

        private static void MutateLettersToW(string word, StringBuilder sb, string end)
        {
            if (word.IndexOf('l') != -1)
            {
                if (word[^2..] == "le" || word[^2..] == "ll")
                {
                    var temp = new StringBuilder(word[..^2]);
                    sb.Append(temp
                        .Replace("l", "w")
                        .Replace("r", "w")
                        .Append(word[^2..])
                        .Append(end + ' ')
                        .ToString());
                }
                else if (word[^3..] == "les" || word[^3..] == "lls")
                {
                    var temp = new StringBuilder(word[..^2]);
                    sb.Append(temp
                        .Replace("l", "w")
                        .Replace("r", "w")
                        .Append(word[^3..])
                        .Append(end + ' ')
                        .ToString());
                }
                else
                {
                    var temp = new StringBuilder(word[..^2]);
                    sb.Append(temp
                        .Replace("l", "w")
                        .Replace("r", "w")
                        .Append(end + ' ')
                        .ToString());
                }
            }
            else if (word.IndexOf('r') != -1)
            {
                if (word[^2..] == "er" || word[^2..] == "re")
                {
                    var temp = new StringBuilder(word[..^2]);
                    sb.Append(temp
                        .Replace("r", "w")
                        .Append(word[^2..])
                        .Append(end + ' ')
                        .ToString());
                }
                else if (word[^3..] == "ers" || word[^3..] == "res")
                {
                    var temp = new StringBuilder(word[..^2]);
                    sb.Append(temp
                        .Replace("r", "w")
                        .Append(word[^3..])
                        .Append(end + ' ')
                        .ToString());
                }
                else
                {
                    var temp = new StringBuilder(word[..^2]);
                    sb.Append(temp
                        .Replace("r", "w")
                        .Append(end + ' ')
                        .ToString());
                }
            }
            else
            {
                sb.Append(word + end + ' ');
            }
        }

        private string AddEmoji(string end)
        {
            double random;
            switch (end)
            {
                case ".":
                    random = _rng.NextDouble() * _kaomojiJoy.Length;
                    random = Math.Floor(random);
                    end = _kaomojiJoy[(int) random];
                    break;
                case "?":
                    random = _rng.Next() * _kaomojiConfuse.Length;
                    random = Math.Floor(random);
                    end = _kaomojiConfuse[(int) random];
                    break;
                case "!":
                    random = _rng.Next() * _kaomojiJoy.Length;
                    random = Math.Floor(random);
                    end = _kaomojiJoy[(int) random];
                    break;
                case ",":
                    random = _rng.Next() * _kaomojiEmbarassed.Length;
                    random = Math.Floor(random);
                    end = _kaomojiEmbarassed[(int) random];
                    break;
                default:
                    random = _rng.Next() * _kaomojiSparkles.Length;
                    random = Math.Floor(random);
                    end = _kaomojiSparkles[(int) random];
                    break;
            }

            return end;
        }
    }
}