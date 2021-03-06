﻿using JsonComparer.Models;
using System;

namespace JsonComparer.Core.Models
{
    internal class ParseDataDto : IEquatable<ParseDataDto>
    {
        public JsonPkDto PrimaryKey { get; set; }
        public JsonValueDto Values { get; set; }
        

        public bool Equals(ParseDataDto other)
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