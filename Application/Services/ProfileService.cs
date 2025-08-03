using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Application.DTOs.Requests;
using Application.Interfaces.Repositories;
using Application.Interfaces.Services;
using Domain.Entities;
using Domain.ValueObjects;


namespace Application.Services
{
    public class ProfileService : IProfileService
    {
        private readonly IProfileRepository _repo;

        public ProfileService(IProfileRepository repo)
        {
            _repo = repo;
        }

        public async Task CreateProfileAsync(CreateProfileRequest request)
        {
            if (await _repo.ExistsWithNameAsync(request.ProfileName))
                throw new ArgumentException("Profile name is already taken.");

            var profile = new Profile(
                userId: request.UserId,
                profileName: ProfileName.From(request.ProfileName),
                age: Age.FromYears(request.Age),
                height: request.Height,
                weight: request.Weight,
                gender: (Gender)request.Gender,
                bio: request.Bio,
                location: new Location(request.Country, request.City)
            );

            await _repo.AddAsync(profile);
        }


        public async Task<bool> IsProfileNameTakenAsync(string name)
            => await _repo.ExistsWithNameAsync(name);
    }
}
