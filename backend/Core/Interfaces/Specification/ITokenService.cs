using Core.Entities.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Interfaces.Specification
{
    public interface ITokenService
    {
        string CreateToken(AppUser user);
    }
}
