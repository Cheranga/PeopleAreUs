using System;
using System.ComponentModel;
using PeopleAreUs.Domain.Models;

namespace PeopleAreUs.Console.Requests
{
    public class ShowPetsRequest
    {
        public ShowPetsRequest(PetType petType, Func<Pet, object> orderBy, ListSortDirection sortDirection = ListSortDirection.Ascending)
        {
            PetType = petType;
            OrderBy = orderBy;
            SortDirection = sortDirection;
        }

        public PetType PetType { get; }
        public Func<Pet, object> OrderBy { get; }

        public ListSortDirection SortDirection { get; set; }
    }
}