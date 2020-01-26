using System.Collections.Generic;

namespace JsonComparer.Models
{
    public class ComparePkDto
    {
        public ComparePkDto()
        {
            JsonAPrimaryKeys = new List<JsonPkDto>();
            JsonBPrimaryKeys = new List<JsonPkDto>();
        }
        public List<JsonPkDto> JsonAPrimaryKeys { get; set; }
        public List<JsonPkDto> JsonBPrimaryKeys { get; set; }
    }
}
