using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Application.Interfaces;
using Domain.Entities;


namespace Application.Interfaces.Repositories
{
    public interface IProfileRepository
    {
        Task<bool> ExistsWithNameAsync(string profileName);
        Task AddAsync(Profile profile);
    }

}
