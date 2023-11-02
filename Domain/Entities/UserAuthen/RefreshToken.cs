using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Domain.Entities.Person;

namespace Domain.Entities.UserAuthen;

public class RefreshToken : BaseEntity
{
    public string Token { get; set; }
    public DateTime Expires { get; set; }
    public DateTime Created { get; set; }
    public DateTime? Revoked { get; set; }
    public bool IsExpired => DateTime.UtcNow >= Expires;
    public bool IsActive => Revoked == null && !IsExpired;

    /* --------- Foreign Keys ---------- */

    /* Foreign Key for Client */
    [Required]
    public int IdPersonFk { get; set; }
    public Client Client { get; set; }
    public int IdUserFk { get; set; }
    public User User { get; set; }
    /* --------------------------------- */

}
