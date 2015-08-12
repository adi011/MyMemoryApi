using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyMemoryApi.Model
{
    public class GetMatch
    {

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("segment")]
        public string Segment { get; set; }

        [JsonProperty("translation")]
        public string Translation { get; set; }

        [JsonProperty("quality")]
        public int Quality { get; set; }

        [JsonProperty("reference")]
        public string Reference { get; set; }

        [JsonProperty("usage-count")]
        public int UsageCount { get; set; }

        [JsonProperty("subject")]
        public string Subject { get; set; }

        [JsonProperty("created-by")]
        public string CreatedBy { get; set; }

        [JsonProperty("last-updated-by")]
        public string LastUpdatedBy { get; set; }

        [JsonConverter(typeof(JsonDateTimeConverter))]
        [JsonProperty("create-date")]
        public DateTime? CreateDate { get; set; }

        [JsonConverter(typeof(JsonDateTimeConverter))]
        [JsonProperty("last-update-date")]
        public DateTime? LastUpdateDate { get; set; }

        [JsonProperty("tm_properties")]
        public string TmProperties { get; set; }

        [JsonProperty("match")]
        public double Match { get; set; }
    }
}
