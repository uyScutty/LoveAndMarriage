using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Interfaces.Services
{
    
    public interface IProfileService
    {
        Task CreateProfileAsync(CreateProfileRequest request);
        Task<bool> IsProfileNameTakenAsync(string name);
    }

}
