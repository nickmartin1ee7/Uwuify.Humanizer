using System;
using NUnit.Framework;
using Uwuify.Humanizer;

namespace Uwuify.Tests
{
    public class UwuifyTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [TestCase("Hi", "hai")]
        [TestCase("hi", "hai")]
        [TestCase(".")]
        [TestCase(",")]
        [TestCase("!")]
        [TestCase("?")]
        [TestCase("Hit or miss I guess they never miss, huh? You got a boyfriend, I bet he doesn't kiss ya He gon' find another girl and he won't miss ya He gon' skrrt and hit the dab like Wiz Khalifa.")]
        [TestCase("The FitnessGram™ Pacer Test is a multistage aerobic capacity test that progressively gets more difficult as it continues.The 20 meter pacer test will begin in 30 seconds.Line up at the start.The running speed starts slowly, but gets faster each minute after you hear this signal. [beep] A single lap should be completed each time you hear this sound. [ding] Remember to run in a straight line, and run as long as possible.The second time you fail to complete a lap before the sound, your test is over.The test will begin on the word start.On your mark, get ready, start.")]
        [TestCase("Did you ever hear the tragedy of Darth Plagueis The Wise? I thought not. It’s not a story the Jedi would tell you. It’s a Sith legend. Darth Plagueis was a Dark Lord of the Sith, so powerful and so wise he could use the Force to influence the midichlorians to create life… He had such a knowledge of the dark side that he could even keep the ones he cared about from dying. The dark side of the Force is a pathway to many abilities some consider to be unnatural. He became so powerful… the only thing he was afraid of was losing his power, which eventually, of course, he did. Unfortunately, he taught his apprentice everything he knew, then his apprentice killed him in his sleep. Ironic. He could save others from death, but not himself.")]
        public void UwuifyDefaultTest(string input, string? expected = null)
        {
            var uwu = input.Uwuify();

            if (expected is null)
            {
                Assert.IsTrue(uwu != input); // Should be different
            }
            else
            {
                Assert.IsTrue(uwu == expected);
            }
        }

        [TestCase(0, "Hit or miss I guess they never miss, huh? You got a boyfriend, I bet he doesn't kiss ya He gon' find another girl and he won't miss ya He gon' skrrt and hit the dab like Wiz Khalifa.")]
        [TestCase(0, "The FitnessGram™ Pacer Test is a multistage aerobic capacity test that progressively gets more difficult as it continues.The 20 meter pacer test will begin in 30 seconds.Line up at the start.The running speed starts slowly, but gets faster each minute after you hear this signal. [beep] A single lap should be completed each time you hear this sound. [ding] Remember to run in a straight line, and run as long as possible.The second time you fail to complete a lap before the sound, your test is over.The test will begin on the word start.On your mark, get ready, start.")]
        [TestCase(0, "Did you ever hear the tragedy of Darth Plagueis The Wise? I thought not. It’s not a story the Jedi would tell you. It’s a Sith legend. Darth Plagueis was a Dark Lord of the Sith, so powerful and so wise he could use the Force to influence the midichlorians to create life… He had such a knowledge of the dark side that he could even keep the ones he cared about from dying. The dark side of the Force is a pathway to many abilities some consider to be unnatural. He became so powerful… the only thing he was afraid of was losing his power, which eventually, of course, he did. Unfortunately, he taught his apprentice everything he knew, then his apprentice killed him in his sleep. Ironic. He could save others from death, but not himself.")]
        [TestCase(0, "Hit or miss I guess they never miss, huh? You got a boyfriend, I bet he doesn't kiss ya He gon' find another girl and he won't miss ya He gon' skrrt and hit the dab like Wiz Khalifa.")]
        [TestCase(0.6, "Hit or miss I guess they never miss, huh? You got a boyfriend, I bet he doesn't kiss ya He gon' find another girl and he won't miss ya He gon' skrrt and hit the dab like Wiz Khalifa.")]
        [TestCase(0.6, "The FitnessGram™ Pacer Test is a multistage aerobic capacity test that progressively gets more difficult as it continues.The 20 meter pacer test will begin in 30 seconds.Line up at the start.The running speed starts slowly, but gets faster each minute after you hear this signal. [beep] A single lap should be completed each time you hear this sound. [ding] Remember to run in a straight line, and run as long as possible.The second time you fail to complete a lap before the sound, your test is over.The test will begin on the word start.On your mark, get ready, start.")]
        [TestCase(0.6, "Did you ever hear the tragedy of Darth Plagueis The Wise? I thought not. It’s not a story the Jedi would tell you. It’s a Sith legend. Darth Plagueis was a Dark Lord of the Sith, so powerful and so wise he could use the Force to influence the midichlorians to create life… He had such a knowledge of the dark side that he could even keep the ones he cared about from dying. The dark side of the Force is a pathway to many abilities some consider to be unnatural. He became so powerful… the only thing he was afraid of was losing his power, which eventually, of course, he did. Unfortunately, he taught his apprentice everything he knew, then his apprentice killed him in his sleep. Ironic. He could save others from death, but not himself.")]
        [TestCase(1, "Hit or miss I guess they never miss, huh? You got a boyfriend, I bet he doesn't kiss ya He gon' find another girl and he won't miss ya He gon' skrrt and hit the dab like Wiz Khalifa.")]
        [TestCase(1, "The FitnessGram™ Pacer Test is a multistage aerobic capacity test that progressively gets more difficult as it continues.The 20 meter pacer test will begin in 30 seconds.Line up at the start.The running speed starts slowly, but gets faster each minute after you hear this signal. [beep] A single lap should be completed each time you hear this sound. [ding] Remember to run in a straight line, and run as long as possible.The second time you fail to complete a lap before the sound, your test is over.The test will begin on the word start.On your mark, get ready, start.")]
        [TestCase(1, "Did you ever hear the tragedy of Darth Plagueis The Wise? I thought not. It’s not a story the Jedi would tell you. It’s a Sith legend. Darth Plagueis was a Dark Lord of the Sith, so powerful and so wise he could use the Force to influence the midichlorians to create life… He had such a knowledge of the dark side that he could even keep the ones he cared about from dying. The dark side of the Force is a pathway to many abilities some consider to be unnatural. He became so powerful… the only thing he was afraid of was losing his power, which eventually, of course, he did. Unfortunately, he taught his apprentice everything he knew, then his apprentice killed him in his sleep. Ironic. He could save others from death, but not himself.")]
        public void UwuifyCustomTest(double stutterChance, string input, string? expected = null)
        {
            var uwu = input.Uwuify(stutterChance);

            if (expected is null)
            {
                Assert.IsTrue(uwu != input); // Should be different
            }
            else
            {
                Assert.IsTrue(uwu == expected);
            }
        }

        [TestCase(" ", true)]
        [TestCase(null, true)]
        public void UwuifyNegativeTest(string input, bool shouldThrow = false)
        {

            if (shouldThrow)
            {
                Assert.Throws<ArgumentNullException>(() => input.Uwuify());
            }
            else
            {
                var uwu = input.Uwuify();

                Assert.IsTrue(uwu == input); // Doesn't change
            }
        }

        [TestCase(0.0001, "a")]
        public void UwuifyStutterTest(double stutterChance, string input)
        {

            var uwu = input.Uwuify(stutterChance);

            Assert.AreNotEqual(input, uwu);
            Assert.Contains('-', uwu.ToCharArray());
        }
    }
}