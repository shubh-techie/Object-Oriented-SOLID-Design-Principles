using ShubhDev.SolidDesignPrinciples.Application.Model;
using System.Collections.Generic;

namespace ShubhDev.SolidDesignPrinciples.Application.Contracts
{
    public interface IPeopleProvider
    {
        List<Person> GetPeople();
    }
}
