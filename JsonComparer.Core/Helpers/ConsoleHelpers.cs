using Newtonsoft.Json;
using System;

namespace JsonComparer.Core.Helpers
{
    public static class ConsoleHelpers
    {
        public static void PrintObject(object obj, bool shouldFormatJson = false)
        {
            var settings = new JsonSerializerSettings
            {
                NullValueHandling = NullValueHandling.Ignore
            };
            if (shouldFormatJson)
                settings.Formatting = Formatting.Indented;

            Console.WriteLine(JsonConvert.SerializeObject(obj, settings));
        }
    }
}
