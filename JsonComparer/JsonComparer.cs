using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using JsonComparer.Helpers;
using JsonComparer.Models;
using Newtonsoft.Json;

namespace JsonComparer.Core
{
    public class JsonComparer : IJsonComparer
    {
        public bool TryParseJsonFiles(string fileA, string fileB, out CompareJsonObjects compareObjects)
        {
            var serializer = new JsonSerializer();
            try
            {
                compareObjects = new CompareJsonObjects
                {
                    JsonA = DeserializeFile(fileA, serializer),
                    JsonB = DeserializeFile(fileB, serializer)
                };

                return true;
            } catch
            {
                compareObjects = null;
                return false;
            }
        }

        public CompareJsonObjects ExceptIntersect(CompareJsonObjects compareObjects)
        {
            throw new NotImplementedException();
        }

        public Dictionary<PrimaryKeyDto, ValueDto> IntersectByPrimaryKey(CompareJsonObjects compareObjects, bool shouldLeaveOnlyChangedValues)
        {
            throw new NotImplementedException();
        }


        private Dictionary<PrimaryKeyDto, ValueDto> DeserializeFile(string fileName, JsonSerializer serializer)
        {
            Dictionary<PrimaryKeyDto, ValueDto> jsonDict;
            using (StreamReader file = File.OpenText(fileName))
            {
                using (JsonReader reader = new JsonTextReader(file))
                {
                    jsonDict = ((List<ParseDataDto>)serializer.Deserialize(file, typeof(List<ParseDataDto>)))
                            .DistinctBy(d => d.PrimaryKey)
                            .ToDictionary(x => x.PrimaryKey, y => y.Values);
                }
            }
            return jsonDict;
        }

    }
}
