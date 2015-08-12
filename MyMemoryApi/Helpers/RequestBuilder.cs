using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyMemoryApi
{
    class RequestBuilder
    {
        public string BaseUrl { get;private set; }
        public string RequestUrl { get { return str.ToString(); } }
        private int parametersNumber=0;
        private StringBuilder str=new StringBuilder();
        public RequestBuilder(string baseUrl)
        {
            BaseUrl = baseUrl;
        }
        public void AddParameter(string name,string value)
        {
            str.Append(parametersNumber == 0 ? BaseUrl+"?" : "&");
            str.Append(name);
            str.Append('=');
            str.Append(value);
            parametersNumber++;
        }
    }
}
