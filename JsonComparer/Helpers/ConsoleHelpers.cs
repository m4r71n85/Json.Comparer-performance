using Newtonsoft.Json;
using System;
using System.Diagnostics;

namespace JsonComparer.Helpers
{
    public static class ConsoleHelpers
    {
        public static void PrintObject(object obj)
        {
            Console.WriteLine(JsonConvert.SerializeObject(obj, new JsonSerializerSettings
            {
                NullValueHandling = NullValueHandling.Ignore
            }));
        }

        public static void PrintTimer(string msg, Stopwatch sw)
        {
            Console.WriteLine("{0} - {1}", msg, sw.ElapsedMilliseconds);
            sw.Restart();
        }
    }
}
