using System.Collections.Generic;

namespace JsonComparer.Models
{
    public class CompareJsonObjects
    {
        public CompareJsonObjects()
        {
            JsonA = new Dictionary<JsonPkDto, JsonValueDto>();
            JsonB = new Dictionary<JsonPkDto, JsonValueDto>();
        }
        public Dictionary<JsonPkDto, JsonValueDto> JsonA { get; set; }
        public Dictionary<JsonPkDto, JsonValueDto> JsonB { get; set; }
    }
}
