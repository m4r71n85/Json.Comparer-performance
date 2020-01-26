using System.Collections.Generic;

namespace JsonComparer.Models
{
    public class ComparePrimaryKeysObjects
    {
        public ComparePrimaryKeysObjects()
        {
            JsonAPrimaryKeys = new List<PrimaryKeyDto>();
            JsonBPrimaryKeys = new List<PrimaryKeyDto>();
        }
        public List<PrimaryKeyDto> JsonAPrimaryKeys { get; set; }
        public List<PrimaryKeyDto> JsonBPrimaryKeys { get; set; }
    }
}
