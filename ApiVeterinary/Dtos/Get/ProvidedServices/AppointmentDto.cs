using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace ApiVeterinary.Dtos.Get.ProvidedServices;

public class AppointmentDto
{
    public int Id { get; set; }
    public DateTime Date { get; set; }
    public TimeSpan Time { get; set; }

}
