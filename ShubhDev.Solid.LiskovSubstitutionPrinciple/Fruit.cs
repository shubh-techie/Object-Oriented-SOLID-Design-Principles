using System;

namespace ShubhDev.Solid.LiskovSubstitutionPrinciple
{
    public abstract class Fruit
    {
        public abstract string GetColor();
    }
    public class Apple : Fruit
    {
        public override string GetColor()
        {
            return "RED";
        }
    }

    public class Orange : Fruit
    {
        public override string GetColor()
        {
            return "ORANGE";
        }
    }
}
