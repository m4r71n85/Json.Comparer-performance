using System.Collections.Generic;
using System.IO;
using System.Linq;
using JsonComparer.Core.Helpers;
using JsonComparer.Core.Models;
using JsonComparer.Models;
using Newtonsoft.Json;

namespace JsonComparer.Core
{
    public class JsonCompare : IJsonCompare
    {
        public CompareJsonObjects ParseJsonFiles(string fileA, string fileB)
        {
            var serializer = new JsonSerializer();
            return new CompareJsonObjects
            {
                JsonA = DeserializeFile(fileA, serializer),
                JsonB = DeserializeFile(fileB, serializer)
            };
        }

        public ComparePkDto IntersectPrimaryKeys(CompareJsonObjects compareObjects)
        {
            var jsonA = compareObjects.JsonA;
            var jsonB = compareObjects.JsonB;

            var compPk = new ComparePkDto();
            foreach (var a in jsonA)
            {
                if (!jsonB.ContainsKey(a.Key))
                    compPk.JsonAPrimaryKeys.Add(a.Key);
            }

            foreach (var b in jsonB)
            {
                if (!jsonA.ContainsKey(b.Key))
                    compPk.JsonBPrimaryKeys.Add(b.Key);
            }

            return compPk;
        }

        public IEnumerable<JsonObjectDto> IntersectChangedValues(CompareJsonObjects compareObjects)
        {
            var jsonA = compareObjects.JsonA;
            var jsonB = compareObjects.JsonB;
            var changedValues = new Dictionary<JsonPkDto, JsonValueDto>();
            foreach (var a in jsonA)
            {
                //if have same keys and different values
                if (jsonB.ContainsKey(a.Key) && !a.Value.Equals(jsonB[a.Key]))
                {
                    var mergedValue = a.Value.Merge(jsonB[a.Key]);
                    if (mergedValue.HasValue())
                        changedValues.Add(a.Key, mergedValue);
                }
            }
            var jsonObjects = changedValues.Select(c => new JsonObjectDto
            {
                PrimaryKey = c.Key,
                Values = c.Value
            });

            return jsonObjects;
        }


        private Dictionary<JsonPkDto, JsonValueDto> DeserializeFile(string fileName, JsonSerializer serializer)
        {
            Dictionary<JsonPkDto, JsonValueDto> jsonDict;
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
