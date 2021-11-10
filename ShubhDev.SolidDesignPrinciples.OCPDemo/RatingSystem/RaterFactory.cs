using ShubhDev.SolidDesignPrinciples.OCPDemo.Common;
using ShubhDev.SolidDesignPrinciples.OCPDemo.Model;
using System;

namespace ShubhDev.SolidDesignPrinciples.OCPDemo.RatingSystem
{
    public class RaterFactory
    {
        public RaterBase Create(Policy policy, RatingEngine engine)
        {
            switch (policy.Type)
            {
                case PolicyType.Auto:
                    return new AutoPolicyRater(engine, engine.Logger);

                case PolicyType.Flood:
                    return new FloodPolicyRater(engine, engine.Logger);

                case PolicyType.Land:
                    return new LandPolicyRater(engine, engine.Logger);

                case PolicyType.Life:
                    return new LifePolicyRater(engine, engine.Logger);

                default:
                    // currently this can't be reached 
                    return new UnknownPolicyRater(engine, engine.Logger);
            }
        }

        public RaterBase CreateUsingReflection(Policy policy, RatingEngine engine)
        {
            try
            {
                return (RaterBase)Activator.CreateInstance(
                    Type.GetType($"ShubhDev.SolidDesignPrinciples.OCPDemo.RatingSystem.{policy.Type}PolicyRater"),
                        new object[] { engine, engine.Logger });
            }
            catch
            {
                return new UnknownPolicyRater(engine, engine.Logger);
            }
        }
    }
}
