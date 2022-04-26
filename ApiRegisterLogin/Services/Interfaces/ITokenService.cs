using System.Collections.Generic;

namespace ApiRegisterLogin.Services.Interfaces
{
    public interface ITokenService
    {
        string GenerateJwtToken(string username, List<string> roles);
    }
}
