using System;

namespace JsonComparer.Models
{
    public class JsonObjectDto : IEquatable<JsonObjectDto>
    {
        public JsonPkDto PrimaryKey { get; set; }
        public JsonValueDto Values { get; set; }
        

        public bool Equals(JsonObjectDto other)
        {
            return PrimaryKey.Equals(other.PrimaryKey)
                        && Values.Equals(other.Values);
        }

        public override int GetHashCode()
        {
            return PrimaryKey.GetHashCode() ^ Values.GetHashCode();
        }
    }
}