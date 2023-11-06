using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace ApiVeterinary.Dtos.Post.Pet;

public class PetPDto
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Species { get; set; }
    public DateTime BirthDate { get; set; }

    /* Foreign Key for Cliente */
    public int IdClientFk { get; set; }

    /* Foreign Key for PetBred */
    public int IdPetBredFk { get; set; }
}
