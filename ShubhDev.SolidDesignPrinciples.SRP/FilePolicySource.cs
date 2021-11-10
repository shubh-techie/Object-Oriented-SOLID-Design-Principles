using System.IO;

namespace ShubhDev.SolidDesignPrinciples.SRP
{
    public class FilePolicySource
    {
        public string GetPolicyFromSource()
        {
            return File.ReadAllText("policy.json");
        }
    }
}
