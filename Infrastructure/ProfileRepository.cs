using System;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Application.Interfaces.Repositories;
using Domain.Entities;



namespace Infrastructure
{
    public class ProfileRepository : IProfileRepository
    {
        private readonly AppDbContext _context;

        public ProfileRepository(AppDbContext context)
        {
            _context = context;
        }

        public async Task<bool> ExistsWithNameAsync(string profileName)
        {
            return await _context.Profiles
                .AnyAsync(p => p.ProfileName.Value == profileName);
        }

        public async Task AddAsync(Profile profile)
        {
            await _context.Profiles.AddAsync(profile);
            await _context.SaveChangesAsync();
        }
    }
}
