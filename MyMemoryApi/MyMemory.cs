using MyMemoryApi.Model;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace MyMemoryApi
{
    public static class MyMemory
    {
        private static HttpClient client = new HttpClient();
        private const string API_BASE = "http://api.mymemory.translated.net";
        /// <summary>
        /// Searches MyMemory for matches against a segment.
        /// </summary>
        /// <param name="text">Text to translate. Maximum size: 500 bytes</param>
        /// <param name="languagePair">Source and language pair, separated by the | symbol. Use ISO standard names or RFC3066. Example: en|it</param>
        /// <param name="isMachineTranslationAllowed">Enables Machine Translation in results.You can turn it off if you want just human segments</param>
        /// <param name="key">Authenticates the request; matches from your private TM are returned too. Get your key <a href="http://mymemory.translated.net/doc/keygen.php">here</a> or use the keygen API</param>
        /// <param name="onlyPrivate">If your request is authenticated, returns only matches from your private TM</param>
        /// <returns>GetResponse</returns>
        public static async Task<GetResponse> GetAsync(string text,string languagePair,bool isMachineTranslationAllowed=true,string key=null,bool onlyPrivate=false)
        {
            if (Encoding.UTF8.GetByteCount(text)>500)
                throw new ArgumentException("Text too long");
            if (!languagePair.Contains('|'))
                throw new FormatException("Bad language pair format");
            RequestBuilder builder = new RequestBuilder(API_BASE + @"/get");
            builder.AddParameter("q", text);
            builder.AddParameter("langpair", languagePair);
            if (isMachineTranslationAllowed == false)
                builder.AddParameter("mt", "0");
            if (!String.IsNullOrEmpty(key))
                builder.AddParameter("key", key);
            if (onlyPrivate)
                builder.AddParameter("onlyprivate", "1");
            var response = await client.GetStringAsync(builder.RequestUrl);
            var obj=JsonConvert.DeserializeObject<GetResponse>(response);
            return obj;
        }
    }
}
