using System;
using PeopleAreUs.Domain.Models;
using System.ComponentModel;

namespace PeopleAreUs.Console.Requests
{
    public class ShowPetsRequest
    {
        public PetType PetType { get; }
        public Func<Pet, object> OrderBy { get; }

        public ListSortDirection SortDirection { get; set; }

        public ShowPetsRequest(PetType petType, Func<Pet, object> orderBy, ListSortDirection sortDirection = ListSortDirection.Ascending)
        {
            PetType = petType;
            OrderBy = orderBy;
            SortDirection = sortDirection;
        }
    }
}