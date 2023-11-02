using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Domain.Entities.UserAuthen;

public class User : BaseEntity
{
    public string Name { get; set; }
    public string Email { get; set; }
    public string Password { get; set; }

    /* Relationship whit Rols -> Many to Many */
    public ICollection<Rol> Roles { get; set; } = new HashSet<Rol>();

    /* Relationship whit UserRols -> Many to Many */
    public ICollection<UserRol> UserRols { get; set; }

    /* Relationship whit UserRols -> One to Many */
    public ICollection<RefreshToken> RefreshTokens { get; set; } = new HashSet<RefreshToken>();

}
