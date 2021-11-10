using ShubhDev.SolidDesignPrinciples.OCPDemo.Common;
using ShubhDev.SolidDesignPrinciples.OCPDemo.Model;

namespace ShubhDev.SolidDesignPrinciples.OCPDemo.RatingSystem
{
    public class UnknownPolicyRater : RaterBase
    {
        public UnknownPolicyRater(RatingEngine engine, ConsoleLogger logger)
            : base(engine, logger)
        {
        }

        public override void Rate(Policy policy)
        {
            _logger.Log("Unknown policy type");
        }
    }
}
