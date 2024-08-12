using System;
using System.Collections.Generic;
using System.Text;

namespace Skarp.HubSpotClient.Core
{
    public class RequestParamBuilder
    {
        private List<string> paraw = new List<string>();
        public RequestParamBuilder() { }
    
        public void Add(List<string> param, string name)
        {
            paraw.Add(param.AsUriListParameter(name));
        }
        
        public override string ToString()
        {
            if(paraw.Count > 0)
            {
                return "&" + string.Join("&", paraw);
            }

            return string.Empty;
        }
    }
}
