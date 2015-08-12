using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyMemoryApi.Model
{
    public class GetResponse
    {
        [JsonProperty("responseData")]
        public GetResponseData ResponseData { get; set; }

        [JsonProperty("responseDetails")]
        public string ResponseDetails { get; set; }

        [JsonProperty("responseStatus")]
        public int ResponseStatus { get; set; }

        [JsonProperty("responderId")]
        public string ResponderId { get; set; }

        [JsonProperty("matches")]
        public IList<GetMatch> Matches { get; set; }
    }
}
