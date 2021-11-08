using Newtonsoft.Json;
using ShubhDev.SolidDesignPrinciples.Application.Model;
using ShubhDev.SolidDesignPrinciples.DataAccess.Contracts;
using System.Collections.Generic;
using System.Net;

namespace ShubhDev.SolidDesignPrinciples.DataAccess
{
    public class ServiceReader : IPersonReader
    {
        WebClient client = new WebClient();
        string baseUri = "http://localhost:9874/api/people";

        public IEnumerable<Person> GetPeople()
        {
            string result = client.DownloadString(baseUri);
            var people = JsonConvert.DeserializeObject<IEnumerable<Person>>(result);
            return people;
        }

        public Person GetPerson(int id)
        {
            string result = client.DownloadString($"{baseUri}/{id}");
            var person = JsonConvert.DeserializeObject<Person>(result);
            return person;
        }

    }
}
