using System.Threading;

namespace NLoad.App.LoadTests
{
    internal sealed class InMemoryTest : ITest
    {
        public void Initialize()
        {
            //Console.WriteLine("Initialize test...");
        }

        public TestResult Execute()
        {
            Thread.Sleep(100);

            return TestResult.Default; // todo: turn to mutable
        }
    }
}