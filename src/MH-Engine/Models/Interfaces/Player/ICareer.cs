using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MH_Engine.Models.Interfaces.Player
{
    /// <summary>                                                             
    /// The set of characteristics and achieved results of the 
    /// <see cref="ICharacter"/> as a student.
    /// </summary>
    interface ICareer
    {
        House House { get; set; }
        int Level { get; set; }
        Year Year { get; set; }
        DateTime? GraduationDay { get; set; }
        bool Failed { get; set; }
        bool Expelled { get; set; }
        int CupPoints { get; set; }
        bool Wizard { get; set; }
    }
}
