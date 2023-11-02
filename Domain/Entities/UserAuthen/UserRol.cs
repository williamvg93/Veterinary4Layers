using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Domain.Entities.UserAuthen;

public class UserRol : BaseEntity
{
    /* Foreign Key for User */

    public int IdUserFk { get; set; }
    public User User { get; set; }


    /* Foreign Key for Rol */
    public int IdRolFk { get; set; }
    public Rol Rol { get; set; }

    /* --------------------------------- */
}
