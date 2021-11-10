using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using ShubhDev.SolidDesignPrinciples.OCPDemo.Model;

namespace ShubhDev.SolidDesignPrinciples.OCPDemo
{
    public class JsonPolicySerializer
    {
        public Policy GetPolicyFromJsonString(string jsonString)
        {
            return JsonConvert.DeserializeObject<Policy>(jsonString,
                new StringEnumConverter());
        }
    }
}
