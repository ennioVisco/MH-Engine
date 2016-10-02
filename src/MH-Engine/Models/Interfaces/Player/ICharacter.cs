using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MH_Engine.Models.Interfaces.Player
{
    /// <summary>                                                             
    /// The basic elements that define the in-game character.
    /// </summary>
    interface ICharacter
    {
        string FirstName { get; set; }
        string LastName { get; set; }
        DateTime Birthday { get; set; }
        Gender Gender { get; set; }
        Race Race { get; set; }
        string Residence { get; set; }
        int Money { get; set; }
        
        bool QuidditchPlayer { get; set; }
    }
}
