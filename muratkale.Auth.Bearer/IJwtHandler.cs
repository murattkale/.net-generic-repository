using System;

namespace muratkale.Auth.Bearer
{
    public interface IJwtHandler
    {
        JsonWebToken Create(Guid userId);     
    }
}