using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace ApiVeterinary.Dtos.Post.ProvidedServices;

public class AppointmentPDto
{
    public DateTime Date { get; set; }
    public TimeSpan Time { get; set; }

    /* Foreign Key for Client */
    public int IdClientFk { get; set; }
    /* Foreign Key for Pet */
    public int IdPetFk { get; set; }
    /* Foreign Key for Service */
    public int IdServiceFk { get; set; }
}
