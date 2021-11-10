using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShubhDev.SolidDesignPrinciples.OCPDemo
{
    public class FilePolicySource
    {
        public string GetPolicyFromSource()
        {
            return File.ReadAllText(@"\Data\policy.json");
        }
    }
}
