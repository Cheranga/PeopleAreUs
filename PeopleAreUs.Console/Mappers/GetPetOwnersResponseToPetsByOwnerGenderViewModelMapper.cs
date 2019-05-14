using System;
using System.Collections.Generic;
using System.Linq;
using PeopleAreUs.Console.ViewModels;
using PeopleAreUs.Core;
using PeopleAreUs.Services.Responses;

namespace PeopleAreUs.Console.Mappers
{
    public class GetPetOwnersResponseToPetsByOwnerGenderViewModelMapper : IMapper<GetPetOwnersResponse, PetsByOwnerGenderViewModel>
    {
        public PetsByOwnerGenderViewModel Map(GetPetOwnersResponse source)
        {
            if (source == null)
            {
                throw new ArgumentNullException(nameof(source));
            }

            var peopleWithPets = source.People.Where(x => x.Pets != null && x.Pets.Any()).ToList();
            if (!peopleWithPets.Any())
            {
                return new PetsByOwnerGenderViewModel();
            }
            //
            // Group the collection by the owner's gender and select the pet names
            //
            var petsMappedByOwnerGender = peopleWithPets.GroupBy(x => x.Gender)
                .ToDictionary(x => x.Key, x => x.SelectMany(y => y.Pets).ToList());

            var target = new PetsByOwnerGenderViewModel
            {
                PetsMappedByOwnersGender = petsMappedByOwnerGender
            };

            return target;
        }
    }
}