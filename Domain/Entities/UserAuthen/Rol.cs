using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Domain.Entities.UserAuthen;

public class Rol : BaseEntity
{
    public string Name { get; set; }

    /* Relationship whit Users -> Many to Many */
    public ICollection<User> Users { get; set; } = new HashSet<User>();

    /* Relationship whit UserRols -> Many to Many */
    public ICollection<UserRol> UserRols { get; set; }



}
