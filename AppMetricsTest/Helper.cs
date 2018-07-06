using System;
using System.Threading.Tasks;

namespace AppMetricsTest
{
    public static class Helper
    {
        public static async Task Foo()
        {
            Console.WriteLine("Doing something");
            await Task.Delay(500);
        }
    }
}