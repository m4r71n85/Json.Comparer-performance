using Newtonsoft.Json;
using System;

namespace JsonComparer.Core.Helpers
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
    }
}
