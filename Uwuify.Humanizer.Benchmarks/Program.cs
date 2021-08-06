using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Running;
using Uwuify.Humanizer;

namespace Uwuify.Humanizer.Benchmarks
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            _ = BenchmarkRunner.Run<Benchy>();
        }
    }

    [MemoryDiagnoser]
    public class Benchy
    {
        [Benchmark]
        public void Test1()
        {
            "Hit or miss I guess they never miss, huh? You got a boyfriend, I bet he doesn't kiss ya He gon' find another girl and he won't miss ya He gon' skrrt and hit the dab like Wiz Khalifa."
                .Uwuify();
        }

        [Benchmark]
        public void Test2()
        {
            "The FitnessGram™ Pacer Test is a multistage aerobic capacity test that progressively gets more difficult as it continues. The 20 meter pacer test will begin in 30 seconds. Line up at the start. The running speed starts slowly, but gets faster each minute after you hear this signal. [beep] A single lap should be completed each time you hear this sound. [ding] Remember to run in a straight line, and run as long as possible. The second time you fail to complete a lap before the sound, your test is over. The test will begin on the word start. On your mark, get ready, start."
                .Uwuify();
        }

        [Benchmark]
        public void Test3()
        {
            "Did you ever hear the tragedy of Darth Plagueis The Wise? I thought not. It’s not a story the Jedi would tell you. It’s a Sith legend. Darth Plagueis was a Dark Lord of the Sith, so powerful and so wise he could use the Force to influence the midichlorians to create life… He had such a knowledge of the dark side that he could even keep the ones he cared about from dying. The dark side of the Force is a pathway to many abilities some consider to be unnatural. He became so powerful… the only thing he was afraid of was losing his power, which eventually, of course, he did. Unfortunately, he taught his apprentice everything he knew, then his apprentice killed him in his sleep. Ironic. He could save others from death, but not himself."
                .Uwuify();
        }
    }
}