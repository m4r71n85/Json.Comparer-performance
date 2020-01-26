using System.Collections.Generic;

namespace JsonComparer.Models
{
    public class CompareJsonObjects
    {
        public CompareJsonObjects()
        {
            JsonA = new Dictionary<PrimaryKeyDto, ValueDto>();
            JsonB = new Dictionary<PrimaryKeyDto, ValueDto>();
        }
        public Dictionary<PrimaryKeyDto, ValueDto> JsonA { get; set; }
        public Dictionary<PrimaryKeyDto, ValueDto> JsonB { get; set; }
    }
}
