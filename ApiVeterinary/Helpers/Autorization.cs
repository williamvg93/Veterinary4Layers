using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiVeterinary.Helpers;

public class Autorization
{

    public enum Roles
    {
        Administrator,
        Manager,
        Employee
    }

    public const Roles rol_default = Roles.Employee;
}
