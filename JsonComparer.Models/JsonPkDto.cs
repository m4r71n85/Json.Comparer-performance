﻿using Newtonsoft.Json;
using System;

namespace JsonComparer.Models
{
    public class JsonPkDto : IEquatable<JsonPkDto>
    {
        public string Tourist { get; set; }
        public string Zeile { get; set; }
        public string Bund { get; set; }
        public string Country { get; set; }
        public string RefundID { get; set; }
        public string CustomerVers { get; set; }
        public string CustomerID { get; set; }
        public string PaymentID { get; set; }
        public string Attempt { get; set; }
        public string TransactionID { get; set; }
        public string TransactionHistoryID { get; set; }


        public bool Equals(JsonPkDto other)
        {
            return (Tourist == other.Tourist
                    && Zeile == other.Zeile
                    && Bund == other.Bund
                    && Country == other.Country
                    && RefundID == other.RefundID
                    && CustomerVers == other.CustomerVers
                    && CustomerID == other.CustomerID
                    && PaymentID == other.PaymentID
                    && Attempt == other.Attempt
                    && TransactionID == other.TransactionID
                    && TransactionHistoryID == other.TransactionHistoryID);
        }

        public override int GetHashCode()
        {
            return (string.IsNullOrWhiteSpace(Tourist) ? 0 : Tourist.GetHashCode())
                ^ (string.IsNullOrWhiteSpace(Zeile) ? 0 : Zeile.GetHashCode())
                ^ (string.IsNullOrWhiteSpace(Bund) ? 0 : Bund.GetHashCode())
                ^ (string.IsNullOrWhiteSpace(Country) ? 0 : Country.GetHashCode())
                ^ (string.IsNullOrWhiteSpace(RefundID) ? 0 : RefundID.GetHashCode())
                ^ (string.IsNullOrWhiteSpace(CustomerVers) ? 0 : CustomerVers.GetHashCode())
                ^ (string.IsNullOrWhiteSpace(CustomerID) ? 0 : CustomerID.GetHashCode())
                ^ (string.IsNullOrWhiteSpace(PaymentID) ? 0 : PaymentID.GetHashCode())
                ^ (string.IsNullOrWhiteSpace(Attempt) ? 0 : Attempt.GetHashCode())
                ^ (string.IsNullOrWhiteSpace(TransactionID) ? 0 : TransactionID.GetHashCode())
                ^ (string.IsNullOrWhiteSpace(TransactionHistoryID) ? 0 : TransactionHistoryID.GetHashCode());
        }

        //Json.NET doesn't serialize Dictionaries with complex keys
        //https://stackoverflow.com/questions/24504245/not-ableto-serialize-dictionary-with-complex-key-using-json-net/56351540
        //workarounds are overriding ToString of key object or implementing a TypeConverter
        //https://www.newtonsoft.com/json/help/html/SerializationGuide.htm
        public override string ToString()
        {
            return JsonConvert.SerializeObject(this
                , new JsonSerializerSettings
                {
                    NullValueHandling = NullValueHandling.Ignore,
                    //Formatting = Formatting.Indented
                });
        }
    }
}