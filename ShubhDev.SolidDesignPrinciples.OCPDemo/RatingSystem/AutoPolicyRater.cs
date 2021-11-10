using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ShubhDev.SolidDesignPrinciples.OCPDemo.Common;
using ShubhDev.SolidDesignPrinciples.OCPDemo.Model;

namespace ShubhDev.SolidDesignPrinciples.OCPDemo.RatingSystem
{
    public class AutoPolicyRater : RaterBase
    {
        public AutoPolicyRater(RatingEngine engine, ConsoleLogger logger) : base(engine, logger)
        {

        }
        public override void Rate(Policy policy)
        {
            _logger.Log("Rating AUTO policy...");
            _logger.Log("Validating policy.");
            if (String.IsNullOrEmpty(policy.Make))
            {
                Console.WriteLine("Auto policy must specify Make");
                return;
            }
            if (policy.Make == "BMW")
            {
                if (policy.Deductible < 500)
                {
                    _engine.Rating = 1000m;
                }
                _engine.Rating = 900m;
            }
        }
    }
}
