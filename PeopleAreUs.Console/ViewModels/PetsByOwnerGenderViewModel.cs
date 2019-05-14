using System.Collections.Generic;
using PeopleAreUs.Domain.Models;

namespace PeopleAreUs.Console.ViewModels
{
    public class PetsByOwnerGenderViewModel
    {
        public IDictionary<Gender, List<Pet>> PetsMappedByOwnersGender { get; set; }

        public PetsByOwnerGenderViewModel()
        {
            PetsMappedByOwnersGender = new Dictionary<Gender, List<Pet>>();
        }

        //public Gender Gender { get; set; }
        //public List<string> Pets { get; set; }

        //public PetsByOwnerGenderViewModel()
        //{
        //    Pets = new List<string>();
        //}
    }
}