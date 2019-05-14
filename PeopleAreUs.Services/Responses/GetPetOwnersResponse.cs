using System.Collections.Generic;
using System.Collections.ObjectModel;
using PeopleAreUs.Domain.Models;

namespace PeopleAreUs.Services.Responses
{
    public class GetPetOwnersResponse
    {
        public GetPetOwnersResponse(List<Person> people)
        {
            People = new ReadOnlyCollection<Person>(people ?? new List<Person>());
        }

        public ReadOnlyCollection<Person> People { get; }
    }
}